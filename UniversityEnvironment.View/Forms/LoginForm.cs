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
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.View.Utility;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.ViewHelper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UniversityEnvironment.Data.Enums;


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
            var role = typeof(T).Name;
            var user = RepositoryManager.GetRepo<T>()
                .FindByFilter(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
            if (user == null) return null;
            if (Enum.TryParse(role, out Role @enum)) user.Role = @enum;
            else throw new ArgumentException($"Failed to parse {role}");
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

            if (user != null)
            {
                ShowNextForm(this, new EnvironmentForm(user));
            }
            MessageBox.Show("Wrong username or password...", "Login", MessageBoxButtons.OK);
        }
    }
}
