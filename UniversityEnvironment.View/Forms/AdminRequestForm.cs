using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using UniversityEnvironment.Data.Model.Tables;
using MaterialSkin;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using UniversityEnvironment.Data.Enums;

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminRequestForm : MaterialForm 
    {
        private User _user;
        public AdminRequestForm(User user)
        {
            _user = user;
            InitializeComponent();
            UsernameText.Text = user.Username;
            FullNameText.Text = user.FirstName + user.LastName;
            RoleText.Text = user.Role.ToString();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            #region Account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                var foundedAdmin = RepositoryManager.GetRepo<Admin>().FindByFilter(a => _user.Username == a.Username);
                ArgumentNullException.ThrowIfNull(foundedAdmin);
                foundedAdmin.Confirmed = true;
                Close();
            }
            else if(_user.Role == Role.Teacher && !_user.Confirmed)
            {
                var foundedTeacher = RepositoryManager.GetRepo<Teacher>().FindByFilter(a => _user.Username == a.Username);
                ArgumentNullException.ThrowIfNull(foundedTeacher);
                foundedTeacher.Confirmed = true;
                Close();
            }
            #endregion
            #region Reseting account password
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                
            }
            else if (_user.Role == Role.Teacher && !_user.Confirmed)
            {
                
            }
            else
            {

            }
            #endregion
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            #region Regret account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                var foundedAdmin = RepositoryManager.GetRepo<Admin>().FindByFilter(a => _user.Username == a.Username);
                ArgumentNullException.ThrowIfNull(foundedAdmin);
                RepositoryManager.GetRepo<Admin>().Remove(foundedAdmin);
                Close();
            }
            else if (_user.Role == Role.Teacher && !_user.Confirmed)
            {
                var foundedTeacher = RepositoryManager.GetRepo<Teacher>().FindByFilter(a => _user.Username == a.Username);
                ArgumentNullException.ThrowIfNull(foundedTeacher);
                RepositoryManager.GetRepo<Teacher>().Remove(foundedTeacher);
                Close();
            }
            #endregion
            #region Regret reseting password
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {

            }
            else if (_user.Role == Role.Teacher && !_user.Confirmed)
            {

            }
            else
            {

            }
            #endregion
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
