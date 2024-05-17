﻿using System;
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
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore;

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminRequestForm : MaterialForm 
    {
        private UniversityEnvironmentContext _context;
        private User _user;
        public AdminRequestForm(User user)
        {
            _context = new UniversityEnvironmentContext();
            _user = user;
            InitializeComponent();
            UsernameText.Text = user.Username;
            FullNameText.Text = user.FirstName + user.LastName;
            RoleText.Text = user.Role.ToString();
        }

        private void GenericAccept<T>() where T : User
        {
            var foundedUser = RepositoryManager.GetRepo<T>(_context).FindByFilter(a => _user.Username == a.Username);
            ArgumentNullException.ThrowIfNull(foundedUser);
            foundedUser.Confirmed = true;
            RepositoryManager.GetRepo<T>(_context).Update(foundedUser);
            Close();
        }
        private void GenericDecline<T>() where T : User
        {
            var foundedUser = RepositoryManager.GetRepo<T>(_context).FindByFilter(a => _user.Username == a.Username);
            ArgumentNullException.ThrowIfNull(foundedUser);
            RepositoryManager.GetRepo<T>(_context).Remove(foundedUser);
            Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            #region Account confirm
            if (_user.Role == Role.Admin && !_user.Confirmed)
            {
                GenericAccept<Admin>();
            }
            else if(_user.Role == Role.Teacher && !_user.Confirmed)
            {
                GenericAccept<Teacher>();
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
                GenericDecline<Admin>();    
            }
            else if (_user.Role == Role.Teacher && !_user.Confirmed)
            {
                GenericDecline<Teacher>();
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
