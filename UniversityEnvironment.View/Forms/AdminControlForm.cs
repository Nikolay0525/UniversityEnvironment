using MaterialSkin.Controls;
using MaterialSkin;
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
using static UniversityEnvironment.View.Utility.ViewHelper;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using Microsoft.EntityFrameworkCore;
using UniversityEnvironment.Data;

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminControlForm : MaterialForm
    {
        private readonly User _user;
        private UniversityEnvironmentContext _context;
        public AdminControlForm(User user)
        {
            _user = user;
            _context = new UniversityEnvironmentContext();
            InitializeComponent();
        }
        private T? SetUserRole<T>(string? name) where T : User
        {
            var user = RepositoryManager.GetRepo<T>()
                .FindByFilter(u => u.Username == name);
            if (user == null) return null;
            return user;
        }
        private void RequestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = RequestsTable.Rows[e.RowIndex];
                string? selectedUsername = selectedRow.Cells["FromUsernameColumn"].Value.ToString();
                User? user = new();
                if (RepositoryManager.GetRepo<Admin>().FindByFilter(a => a.Username == selectedUsername) != null)
                {
                    user = SetUserRole<Admin>(selectedUsername);
                }
                else if (RepositoryManager.GetRepo<Teacher>().FindByFilter(a => a.Username == selectedUsername) != null)
                {
                    user = SetUserRole<Teacher>(selectedUsername);
                }
                else if (RepositoryManager.GetRepo<Student>().FindByFilter(a => a.Username == selectedUsername) != null)
                {
                    user = SetUserRole<Student>(selectedUsername);
                }
                ArgumentNullException.ThrowIfNull(user);
                ShowNextForm(this, new AdminRequestForm(user), RequestsTable);
            }
        }

        #region Users
        private void AdminUsers_Click(object sender, EventArgs e)
        {
            UsersMessageBox.Text = "Searching in admins";
        }

        private void TeacherUsers_Click(object sender, EventArgs e)
        {
            UsersMessageBox.Text = "Searching in teachers";
        }

        private void StudentUsers_Click(object sender, EventArgs e)
        {
            UsersMessageBox.Text = "Searching in teachers";
        }
        #endregion
        #region Requests
        private void AdminsRequests_Click(object sender, EventArgs e)
        {
            _context = new UniversityEnvironmentContext();
            var query = _context.Admins
                .Where(admin => admin.ForgetPassword == true || admin.Confirmed == false)
                .ToList();
            UpdateRequestsTable<Admin>(RequestsTable, query);
        }

        private void TeachersRequests_Click(object sender, EventArgs e)
        {
            _context = new UniversityEnvironmentContext();
            var query = _context.Teachers
                .Where(teacher => teacher.ForgetPassword == true || teacher.Confirmed == false)
                .ToList();
            UpdateRequestsTable<Teacher>(RequestsTable, query);
        }

        private void StudentsRequests_Click(object sender, EventArgs e)
        {
            _context = new UniversityEnvironmentContext();
            var query = _context.Students
                .Where(student => student.ForgetPassword == true)
                .ToList();
            UpdateRequestsTable<Student>(RequestsTable, query);
        }
        #endregion
    }
}
