using MaterialSkin.Controls;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using static UniversityEnvironment.View.Validators.ViewValidators;

namespace UniversityEnvironment.View.Forms.CommonForms
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
            if (ValidateUserCorrectInput(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text)) return;
            if (ValidateUserExists(UsernameTextBox.Text))
            {
                MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
                return;
            }
            #endregion

            RegistrateUser(Admin.Checked, Teacher.Checked,
                UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = ShowPasswordCheck.Checked ? '\0' : '*';
        }
    }
}
