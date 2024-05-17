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
        private void FindAndRemove<T>(Guid id) where T : User
        {
            List<T> users = RepositoryManager.GetRepo<T>(_context).FindAll().ToList();
            T? user = users.FirstOrDefault(a => a.Id == id);
            if (user != null) users.Remove(user);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_user.Role == Data.Enums.Role.Admin) 
            {
                FindAndRemove<Admin>(_user.Id);
            } 
            else if (_user.Role == Data.Enums.Role.Teacher)
            {
                FindAndRemove<Teacher>(_user.Id);
            }
            else
            {
                FindAndRemove<Student>(_user.Id);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
