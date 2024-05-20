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
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.View.Utility;
using UniversityEnvironment.View.Forms.AdminForms;

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminControlForm : MaterialForm
    {
        private readonly User _user;
        private UniversityEnvironmentContext _context;
        private Role _roleFlag;
        private int _currentPage = 0;
        public AdminControlForm(User user)
        {
            _user = user;
            _context = new UniversityEnvironmentContext();
            InitializeComponent();
            this.Text = "Welcome back " + user.FirstName + " " + user.LastName + "!";
        }

        #region Users requests

        internal List<Admin> AdminsRequest()
        {
            return _context.Admins
                .Where(admin => admin.ForgetPassword == true || admin.Confirmed == false)
                .Skip(_currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .OrderBy(admin => admin.Username)
                .Select(admin => new Admin
                {
                    Username = admin.Username,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Password = admin.Password,
                })
                .ToList();
        }
        internal List<Teacher> TeachersRequest()
        {
            return _context.Teachers
                .Where(teacher => teacher.ForgetPassword == true || teacher.Confirmed == false)
                .Skip(_currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .OrderBy(teacher => teacher.Username)
                .Select(teacher => new Teacher
                {
                    Username = teacher.Username,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Password = teacher.Password,
                    ScienceDegree = teacher.ScienceDegree,
                })
                .ToList();
        }
        internal List<Student> StudentsRequest()
        {
            return _context.Students
                .Where(student => student.ForgetPassword == true)
                .Skip(_currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .OrderBy(student => student.Username)
                .Select(student => new Student
                {
                    Username = student.Username,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Password = student.Password,
                })
                .ToList();
        }
        internal List<Admin> AdminsUsersRequest(bool? flag = null, string? text = null)
        {
            IQueryable<Admin> query = _context.Admins;

            if (flag == true && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query
                .OrderBy(teacher => teacher.Username)
                .Skip(_currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .Select(teacher => new Admin
                {
                    Username = teacher.Username,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Password = teacher.Password,
                })
                .ToList();
        }
        internal List<Teacher> TeachersUsersRequest(bool? flag = null, string? text = null)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (flag == true && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query
                .OrderBy(teacher => teacher.Username)
                .Skip(_currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .Select(teacher => new Teacher
                {
                    Username = teacher.Username,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Password = teacher.Password,
                    ScienceDegree = teacher.ScienceDegree,
                })
                .ToList();
        }
        internal List<Student> StudentsUsersRequest(bool? flag = null, string? text = null)
        {
            IQueryable<Student> query = _context.Students;

            if (flag == true && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query
                .OrderBy(s => s.Username)
                .Skip(_currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .Select(student => new Student
                {
                    Username = student.Username,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Password = student.Password,
                })
                .ToList();
        }
        #endregion

        #region Users tab
        private void AdminUsers_Click(object sender, EventArgs e)
        {
            _roleFlag = Role.Admin;
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in admins...";
            UpdateUsersTable<Admin>(UsersTable, AdminsRequest());
        }

        private void TeacherUsers_Click(object sender, EventArgs e)
        {
            _roleFlag = Role.Teacher;
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in teachers...";
            UpdateUsersTable<Teacher>(UsersTable, TeachersRequest());
        }

        private void StudentUsers_Click(object sender, EventArgs e)
        {
            _roleFlag = Role.Student;
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in students...";
            UpdateUsersTable<Student>(UsersTable, StudentsRequest());
        }
        private void UsersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = UsersTable.Rows[e.RowIndex];
                string? selectedUsername = selectedRow.Cells["UsernameColumn"].Value.ToString();
                User? user = new();
                if (_roleFlag == Role.Admin)
                {
                    GenericClick<Admin>(user, selectedUsername, AdminsRequestUpdate, user => new AdminUserForm(user));
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericClick<Teacher>(user, selectedUsername, TeachersRequestUpdate, user => new AdminUserForm(user));
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericClick<Student>(user, selectedUsername, StudentRequestUpdate, user => new AdminUserForm(user));
                }

            }
        }
        #endregion
        #region Requests tab
        private void GenericClick<T>(User? user, string? username, UpdateRequestAfterClosing operation, Func<User, MaterialForm> createForm) where T : User
        {
            user = SetUserRole<T>(_context, username);
            ArgumentNullException.ThrowIfNull(user);
            ShowNextForm(this, createForm(user), operation);
        }
        private void RequestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = RequestsTable.Rows[e.RowIndex];
                string? selectedUsername = selectedRow.Cells["FromUsernameColumn"].Value.ToString();
                User? user = new();
                if (_roleFlag == Role.Admin)
                {
                    GenericClick<Admin>(user, selectedUsername, AdminsRequestUpdate, user => new AdminRequestForm(user));
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericClick<Teacher>(user, selectedUsername, TeachersRequestUpdate, user => new AdminRequestForm(user));
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericClick<Student>(user, selectedUsername, StudentRequestUpdate, user => new AdminRequestForm(user));
                }

            }
        }
        internal void AdminsRequestUpdate()
        {
            _roleFlag = Role.Admin;
            var query = AdminsRequest();
            UpdateRequestsTable<Admin>(RequestsTable, query);
        }

        private void AdminsRequests_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            RequestMessageBox.Text = "Searching in admins...";
            AdminsRequestUpdate();
        }

        internal void TeachersRequestUpdate()
        {
            _roleFlag = Role.Teacher;
            var query = TeachersRequest();
            UpdateRequestsTable<Teacher>(RequestsTable, query);
        }

        private void TeachersRequests_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            RequestMessageBox.Text = "Searching in teachers...";
            TeachersRequestUpdate();
        }

        internal void StudentRequestUpdate()
        {
            _roleFlag = Role.Student;
            var query = StudentsRequest();
            UpdateRequestsTable<Student>(RequestsTable, query);
        }

        private void StudentsRequests_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            RequestMessageBox.Text = "Searching in students...";
            StudentRequestUpdate();
        }

        private void NextPageRequests_Click(object sender, EventArgs e)
        {
            _currentPage++;
            if (_roleFlag == Role.Admin)
            {
                AdminsRequestUpdate();
            }
            else if (_roleFlag == Role.Admin)
            {
                TeachersRequestUpdate();
            }
            else
            {
                StudentRequestUpdate();
            }
        }
        private void PreviousPageRequests_Click(object sender, EventArgs e)
        {
            _currentPage = _currentPage > 0 ? _currentPage - 1 : _currentPage;
            if (_roleFlag == Role.Admin)
            {

                AdminsRequestUpdate();
            }
            else if (_roleFlag == Role.Admin)
            {
                TeachersRequestUpdate();
            }
            else
            {
                StudentRequestUpdate();
            }
        }
        #endregion
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            if (_roleFlag == Role.Admin)
            {
                AdminsUsersRequest(ByUsernameCheck.Checked, FilterTextBox.Text);
            }
            else if (_roleFlag == Role.Admin)
            {
                TeachersUsersRequest(ByUsernameCheck.Checked, FilterTextBox.Text);
            }
            else
            {
                StudentsUsersRequest(ByUsernameCheck.Checked, FilterTextBox.Text);
            }
        }

    }
}
