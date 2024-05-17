using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Repositories;
using UniversityEnvironment.Data.Repository;

namespace UniversityEnvironment.View.Forms.AdminForms
{
    public partial class AdminUserForm : UserForm
    {
        public AdminUserForm(User user) : base(user)
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            User user = new 
            if (_user.Role == Data.Enums.Role.Admin) RepositoryManager.GetRepo<Admin>().FindById(_user.Id);
            else if (_user.Role == Data.Enums.Role.Teacher) RepositoryManager.GetRepo<Teacher>().FindById(_user.Id);
        }
    }
}
