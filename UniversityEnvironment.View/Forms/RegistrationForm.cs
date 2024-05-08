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
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Validator.ViewValidator;
using UniversityEnvironment.Data.Enums;
using System.CodeDom;

namespace UniversityEnvironment.View.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrateAccountButton_Click(object sender, EventArgs e)
        {
            #region Validation
            var result = Admin.Checked
                ? ValidateUserExists<Admin>(UsernameTextBox.Text)
                : Teacher.Checked
                    ? ValidateUserExists<Teacher>(UsernameTextBox.Text)
                    : ValidateUserExists<Student>(UsernameTextBox.Text);

            if (!result)
            {
                MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
                return;
            }
            #endregion

            if (Admin.Checked)
            {
                User userToCreate = CreateUser<Admin>(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
                var admin = userToCreate as Admin;
                RepositoryManager.GetRepo<Admin>().Create(admin);
            }
            else if (Teacher.Checked)
            {
                User userToCreate = CreateUser<Teacher>(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
                var teacher = userToCreate as Teacher;
                teacher.ScienceDegree = Microsoft.VisualBasic.Interaction.InputBox("Введіть вашу ступінь:", "Введення тексту", "");
                RepositoryManager.GetRepo<Teacher>().Create(teacher);
            }
            else
            {
                User userToCreate = CreateUser<Student>(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
                var student = userToCreate as Student;
                student.CoursesStudents = new();
                student.QuestionAnswersStudent = new();
                RepositoryManager.GetRepo<Student>().Create(student);
            }
            MessageBox.Show("Account successfully created", "Registration", MessageBoxButtons.OK);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
