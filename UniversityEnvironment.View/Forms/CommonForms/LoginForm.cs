using MaterialSkin.Controls;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Utility;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;
using static UniversityEnvironment.View.Validators.ViewValidators;
//using Microsoft.VisualBasic.ApplicationServices;


namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialFormSkinChanger.SetParametersOfForm(this);
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
                user = SetUserRole<Admin>(UsernameTextBox.Text, PasswordTextBox.Text);
            }
            else if (TeacherCheck.Checked)
            {
                user = SetUserRole<Teacher>(UsernameTextBox.Text, PasswordTextBox.Text);
            }
            else
            {
                user = SetUserRole<Student>(UsernameTextBox.Text, PasswordTextBox.Text);
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
            var username = Microsoft.VisualBasic.Interaction.InputBox("Enter you're username...", "Forget password", "");
            if (username == "") return;
            if (AdminCheck.Checked)
            {
                ForgetPasswordRequest<Admin>(username);
            }
            else if (TeacherCheck.Checked)
            {
                ForgetPasswordRequest<Teacher>(username);
            }
            else if (StudentCheck.Checked)
            {
                ForgetPasswordRequest<Student>(username);
            }

            MessageBox.Show("Wait until admins review you're request, then you will be able to enter you're new password when logging", "Login", MessageBoxButtons.OK);
        }
    }
}
