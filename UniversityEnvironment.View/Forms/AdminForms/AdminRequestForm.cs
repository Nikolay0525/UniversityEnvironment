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
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.ViewHelper;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore;

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
            if (user.Role == Data.Enums.Role.Teacher)
            {
                var teacher = FindByFilter<Teacher>(t => t.Id == user.Id);
                ArgumentNullException.ThrowIfNull(teacher);
                ScienceDegreeBox.Text = teacher.ScienceDegree;
            }
            else
            {
                ScienceDegreeBox.Hide();
                ScienceDegreeLabel.Hide();
            }
        }

        private void GenericAccept<T>(Action<T> action) where T : User
        {
            var foundedUser = FindByFilter<T>(a => _user.Username == a.Username);
            ArgumentNullException.ThrowIfNull(foundedUser);
            action.Invoke(foundedUser);
            Update<T>(foundedUser);
            Close();
        }
        private void GenericDecline<T>(Action<T>? action = null, GenericOperationWithUserObj<T>? op = null) where T : User
        {
            var foundedUser = FindByFilter<T>(a => _user.Username == a.Username);
            ArgumentNullException.ThrowIfNull(foundedUser);
            action?.Invoke(foundedUser);
            op?.Invoke(foundedUser);
            Close();
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            #region Account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                GenericAccept<Admin>(a => a.Confirmed = true);
            }
            else if(_user.Role == Role.Teacher && !_user.Confirmed)
            {
                GenericAccept<Teacher>(t => t.Confirmed = true);
            }
            #endregion
            #region Reseting account password
            if (_user.Role == Role.Admin && _user.ForgetPassword)
            {
                GenericAccept<Admin>(a => a.CanChangePassword = true);
            }
            else if (_user.Role == Role.Teacher && _user.ForgetPassword)
            {
                GenericAccept<Teacher>(t => t.CanChangePassword = true);
            }
            else if (_user.Role == Role.Student && _user.ForgetPassword)
            {
                GenericAccept<Student>(s => s.CanChangePassword = true);
            }
            #endregion
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            #region Regret account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                GenericDecline<Admin>(Remove);    
            }
            else if (_user.Role == Role.Teacher && !_user.Confirmed)
            {
                GenericDecline<Teacher>(Remove);
            }
            #endregion
            #region Regret reseting password
            if (_user.Role == Role.Admin && _user.ForgetPassword)
            {
                GenericDecline<Admin>(a => a.ForgetPassword = false, Data.Service.MySqlService.Update);
            }
            else if (_user.Role == Role.Teacher && _user.ForgetPassword)
            {
                GenericDecline<Teacher>(t => t.ForgetPassword = false, Data.Service.MySqlService.Update);
            }
            else if (_user.Role == Role.Student && _user.ForgetPassword)
            {
                GenericDecline<Student>(s => s.ForgetPassword = false, Data.Service.MySqlService.Update);
            }
            #endregion
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
