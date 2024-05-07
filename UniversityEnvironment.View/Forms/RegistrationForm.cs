using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.Data.Model;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repositories;

namespace UniversityEnvironment.View.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private bool ValidateUserExists<T>(string userName) where T : User
        {
           var foundUser = RepositoryManager
               .GetRepo<T>()
               .FindByFilter(u => u.Username == userName);

            return foundUser == null;
        }

        private void RegistrateAccountButton_Click(object sender, EventArgs e)
        {
            #region Validation
            var result = AdminCheck.Checked
                ? ValidateUserExists<Admin>(UsernameTextBox.Text) 
                : TeacherCheck.Checked
                    ? ValidateUserExists<Teacher>(UsernameTextBox.Text)
                    : ValidateUserExists<Student>(UsernameTextBox.Text);
                    
            if (!result)
            {
                  MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
                  return;
            }

            #endregion

             var userToCreate = new User
             {
                 Username = UsernameTextBox.Text,
                 FirstName = FirstNameTextBox.Text,
                 LastName = LastNameTextBox.Text,
                 Password = PasswordTextBox.Text
             }

             if (AdminCheck.Checked)
             {
                var admin = userToCreate as Admin;
                admin.Role = "Admin";
                userToCreate = admin;
             }
             else if (TeacherCheck.Checked)
             {
                var teacher = userToCreate as Teacher;
                teacher.Role = "Teacher";
                teacher.SinceDegree = Microsoft.VisualBasic.Interaction.InputBox("Введіть вашу ступінь:", "Введення тексту", "");
                userToCreate = teacher;
             }
             else
             {
                var student = userToCreate as Student;
                student.Role = "Student";
                userToCreate = student;
             }
             
            RepositoryManager.GetRepo<User>().Create(userToCreate);
        }


        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
