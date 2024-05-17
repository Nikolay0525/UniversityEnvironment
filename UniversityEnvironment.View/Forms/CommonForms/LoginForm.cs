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
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.ViewHelper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using UniversityEnvironment.Data;


namespace UniversityEnvironment.View.Forms
{
    public partial class LoginForm : MaterialForm
    {
        private UniversityEnvironmentContext _context;
        public LoginForm()
        {
            InitializeComponent();
            MaterialFormSkinChanger.SetParametersOfForm(this);
            _context = new UniversityEnvironmentContext();
        }

        private T? SetUserRole<T>() where T : User
        {
            var user = RepositoryManager.GetRepo<T>(_context)
                .FindByFilter(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
            if (user == null) return null;
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
    }
}
