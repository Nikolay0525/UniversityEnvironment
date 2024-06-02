using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data;
using static UniversityEnvironment.Data.Service.MySqlService;


namespace UniversityEnvironment.View.Validators
{
    internal static class ViewValidators
    {
        internal static bool ValidateStringOnLength(string title,string text, int minLength)
        {
            if(text.Length < minLength)
            {
                MessageBox.Show($"You're {title} is short, you must have atleast {minLength} symbols in it.", "Registration");
                return false;
            }
            return true;
        }
        #region Login
        internal static bool ValidateCorrectInput
            (string username, string fname, string lname, string password)
        {
            bool usernameValidate = ValidateStringOnLength("username", username, 4);
            if (!usernameValidate) return usernameValidate;

            bool fnameValidate = ValidateStringOnLength("name", fname, 2);
            if (!fnameValidate) return fnameValidate;

            bool lnameValidate = ValidateStringOnLength("surname", lname, 2);
            if (!lnameValidate) return lnameValidate;

            bool passwordValidate = ValidateStringOnLength("password", password, 2);
            if (!lnameValidate) return lnameValidate;

            return true;
        }
        internal static bool ValidateScienceDegree
            (string degree)
        {
            if (degree.Length < 4) 
            {
                MessageBox.Show("You're username is short, you must have atleast 4 symbols in it.", "Registration");
                return false;
            }
            return true;
        }

        internal static bool ValidateNull<T>(T? obj, string title, string message)
        {
            if (obj == null)
            {
                MessageBox.Show($"Something went wrong. {message}", title, MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        internal static bool ValidateUserExists(string userName)
        {
            using UniversityEnvironmentContext context = new();
            bool UserExistsInRepo<T>(UniversityEnvironmentContext context, string name) where T : User
            {
                return FindByFilter<T>(u => u.Username == name) != null;
            }

            return UserExistsInRepo<Admin>(context, userName) ||
                   UserExistsInRepo<Teacher>(context, userName) ||
                   UserExistsInRepo<Student>(context, userName);
        }

        #endregion
        internal static bool TestCompleted(DataGridView testTable, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in testTable.Rows)
            {
                var cell = row.Cells["CheckColumn"];
                if (cell.Value == null) continue;
                var cellString = cell.Value.ToString();
                if (cellString != null && bool.TryParse(cellString, out bool parsedBool))
                {
                    if (parsedBool)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
