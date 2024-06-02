using MaterialSkin.Controls;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AdminViewHelper;

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminRequestForm : MaterialForm 
    {
        private User _user;
        public AdminRequestForm(User user, string? requestPurpose)
        {
            InitializeComponent();
            Text = requestPurpose;
            _user = user;
            UsernameBox.Text = user.Username;
            FullNameBox.Text = user.FirstName + " " + user.LastName;
            RoleBox.Text = user.Role.ToString();
            if (user.Role == Role.Teacher)
            {
                var teacher = FindByFilter<Teacher>(t => t.Id == user.Id);
                Validators.ViewValidators.ValidateNull(teacher, "teacher");
                ScienceDegreeBox.Text = teacher!.ScienceDegree;
            }
            else
            {
                ScienceDegreeBox.Hide();
                ScienceDegreeLabel.Hide();
            }
        }

        
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            #region Account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                GenericAccept<Admin>(a => a.Confirmed = true, this, _user);
            }
            else if(_user.Role == Role.Teacher && !_user.Confirmed)
            {
                GenericAccept<Teacher>(t => t.Confirmed = true, this, _user);
            }
            #endregion
            #region Reseting account password
            if (_user.Role == Role.Admin && _user.ForgetPassword)
            {
                GenericAccept<Admin>(a => a.CanChangePassword = true, this, _user);
            }
            else if (_user.Role == Role.Teacher && _user.ForgetPassword)
            {
                GenericAccept<Teacher>(t => t.CanChangePassword = true, this, _user);
            }
            else if (_user.Role == Role.Student && _user.ForgetPassword)
            {
                GenericAccept<Student>(s => s.CanChangePassword = true, this, _user);
            }
            #endregion
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            #region Regret account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                GenericDecline<Admin>(this, _user,Remove);    
            }
            else if (_user.Role == Role.Teacher && !_user.Confirmed)
            {
                GenericDecline<Teacher>(this, _user,Remove);
            }
            #endregion
            #region Regret reseting password
            if (_user.Role == Role.Admin && _user.ForgetPassword)
            {
                GenericDecline<Admin>(this, _user, null, a => a.ForgetPassword = false, Data.Service.MySqlService.Update);
            }
            else if (_user.Role == Role.Teacher && _user.ForgetPassword)
            {
                GenericDecline<Teacher>(this, _user, null, t => t.ForgetPassword = false, Data.Service.MySqlService.Update);
            }
            else if (_user.Role == Role.Student && _user.ForgetPassword)
            {
                GenericDecline<Student>(this, _user, null, s => s.ForgetPassword = false, Data.Service.MySqlService.Update);
            }
            #endregion
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
