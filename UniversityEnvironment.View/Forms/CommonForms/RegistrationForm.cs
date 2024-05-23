﻿    using System;
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
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;

using static UniversityEnvironment.View.Validator.ViewValidator;
using UniversityEnvironment.Data.Enums;
using System.CodeDom;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data;
using static UniversityEnvironment.Data.Service.MySqlService;

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
            if (ValidateUserExists(UsernameTextBox.Text))
            {
                MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
                return;
            }
            #endregion

            if (Admin.Checked)
            {
                User userToCreate = CreateUser<Admin>(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
                var admin = userToCreate as Admin;
                ArgumentNullException.ThrowIfNull(admin);
                if (!FindAll<Admin>().Any()) 
                {
                    admin.Confirmed = true;
                    MessageBox.Show("You are the first admin and the main, be fair!", "Registration", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Request on creating sended", "Registration", MessageBoxButtons.OK);
                Create<Admin>(admin);
            }
            else if (Teacher.Checked)
            {
                User userToCreate = CreateUser<Teacher>(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
                var teacher = userToCreate as Teacher;
                ArgumentNullException.ThrowIfNull(teacher);
                teacher.ScienceDegree = Microsoft.VisualBasic.Interaction.InputBox("Enter you're science degree:", "Entering text", "");
                teacher.CoursesTeachers = new();
                Create<Teacher>(teacher);
                MessageBox.Show("Request on creating sended", "Registration", MessageBoxButtons.OK);
            }
            else
            {
                User userToCreate = CreateUser<Student>(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
                var student = userToCreate as Student;
                ArgumentNullException.ThrowIfNull(student);
                student.TestsStudents = new();
                student.CoursesStudents = new();
                student.QuestionAnswersStudent = new();
                Create<Student>(student);
                MessageBox.Show("Account successfully created", "Registration", MessageBoxButtons.OK);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
