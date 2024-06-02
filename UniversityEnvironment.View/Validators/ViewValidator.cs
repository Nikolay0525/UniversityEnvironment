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
        internal static bool ValidateStringOnLength(string objName,string obj, int minLength, int? maxLength = null)
        {
            if(obj.Length < minLength)
            {
                MessageBox.Show($"You're {objName} is too short, you must have atleast {minLength} symbols in it.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if(maxLength != null && obj.Length > maxLength)
            {
                MessageBox.Show($"You're {objName} is too long, you must have not more than {maxLength} symbols in it.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        #region Login
        internal static bool ValidateUserCorrectInput
            (string username, string fname, string lname, string password)
        {
            bool usernameValidate = ValidateStringOnLength("username", username, 4, 20);
            if (usernameValidate) return true;

            bool fnameValidate = ValidateStringOnLength("name", fname, 2, 30);
            if (fnameValidate) return true;

            bool lnameValidate = ValidateStringOnLength("surname", lname, 2, 30);
            if (lnameValidate) return true;

            bool passwordValidate = ValidateStringOnLength("password", password, 4, 20);
            if (lnameValidate) return true;

            return false;
        }

        internal static bool ValidateNull<T>(T? obj, string objName)
        {
            if (obj == null)
            {
                MessageBox.Show($"Something went wrong. The {objName} cannot be null", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        internal static bool ValidateNull<T>(IEnumerable<T>? obj, string objectsName)
        {
            if (obj == null)
            {
                MessageBox.Show($"Something went wrong. The {objectsName} cannot be null", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
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
