﻿using System;
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
using UniversityEnvironment.Data.Repositories;

namespace UniversityEnvironment.View.Forms
{
    public partial class UserForm : MaterialForm
    {
        protected User _user;
        public UserForm(User user)
        {
            _user = user;
            InitializeComponent();
            NameLabel.Text = user.FirstName;
            SurnameLabel.Text = user.LastName;
            RoleLabel.Text = user.Role.ToString();
            if (user.Role == Data.Enums.Role.Teacher)
            {
                ScienceDegreeLabel.Show();
                var teacher = RepositoryManager.GetRepo<Teacher>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(teacher);
                ScienceDegreeLabel.Text = teacher.ScienceDegree;
            }
            else { ScienceDegreeLabel.Hide(); }
        }
    }
}