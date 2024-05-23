using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.View.Forms;
using UniversityEnvironment.View.Utility;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using UniversityEnvironment.Data;
using static UniversityEnvironment.Data.Service.MySqlService;
//using Microsoft.VisualBasic.ApplicationServices;


namespace UniversityEnvironment.View.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialFormSkinChanger.SetParametersOfForm(this);
        }

        private T? SetUserRole<T>() where T : User
        {
            var userCheck = FindByFilter<T>(u => u.Username == UsernameTextBox.Text);
            if (userCheck == null) return null;
            T? user = userCheck.CanChangePassword
                ? userCheck
                : FindByFilter<T>(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
            if (user == null) return null;

            if (user.CanChangePassword)
            {
                user.Password = PasswordTextBox.Text;
                user.CanChangePassword = false;
                user.ForgetPassword = false;
                Update<T>(user);
            }

            return user;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ShowNextForm(this, new RegistrationForm());
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User? user = new();
            if (AdminCheck.Checked)
            {
                user = SetUserRole<Admin>();
            }
            else if (TeacherCheck.Checked)
            {
                user = SetUserRole<Teacher>();
            }
            else
            {
                user = SetUserRole<Student>();
            }

            #region Validation
            if (user == null)
            {
                MessageBox.Show("Wrong username or password...", "Login", MessageBoxButtons.OK);
                return;
            }
            #endregion

            if (user.Role == Role.Admin && user.Confirmed)
            {
                ShowNextForm(this, new AdminControlForm(user));
                return;
            }
            else if (user.Confirmed)
            {
                ShowNextForm(this, new EnvironmentForm(user));
                return;
            }
            else MessageBox.Show("Wait until admins accept you're request...", "Login", MessageBoxButtons.OK);
        }

        private void ForgetButton_Click(object sender, EventArgs e)
        {
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter you're username...", "Forget password", "");
            if (username == "") return;
            User? user = new();
            if (AdminCheck.Checked)
            {
                user = ForgetPasswordRequest<Admin>(username);
            }
            else if (TeacherCheck.Checked)
            {
                user = ForgetPasswordRequest<Teacher>(username);
            }
            else
            {
                user = ForgetPasswordRequest<Student>(username);
            }

            #region Validation
            if (user == null)
            {
                MessageBox.Show("Wrong username...", "Login", MessageBoxButtons.OK);
                return;
            }
            #endregion

            MessageBox.Show("Wait until admins review you're request, then you will be able to enter you're new password when logging", "Login", MessageBoxButtons.OK);
        }
    }
}
