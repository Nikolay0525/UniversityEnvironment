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
using static UniversityEnvironment.View.Utility.ViewHelper;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using static UniversityEnvironment.Data.Service.MySqlService;
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
            InitializeComponent();
            _user = user;
            _context = new UniversityEnvironmentContext();
            AvailableCoursesTableUpdate(AvailableCoursesTable, FindAll<Course>().ToList());
            Text = "Welcome back " + user.FirstName + " " + user.LastName + "!";
        }

        private void NextPage(Role role,
            VoidOperation? adminOperation = null, VoidOperation? teacherOperation = null, VoidOperation? studentOperation = null)
        {
            _currentPage++;
            if (role == Role.Admin)
            {
                adminOperation?.Invoke();
            }
            else if (role == Role.Admin)
            {
                teacherOperation?.Invoke();
            }
            else if (role == Role.Student)
            {
                studentOperation?.Invoke();
            }
        }
        private void PreviousPage(Role role,
            VoidOperation? adminOperation = null, VoidOperation? teacherOperation = null, VoidOperation? studentOperation = null)
        {
            _currentPage = _currentPage > 0 ? _currentPage - 1 : _currentPage;
            if (role == Role.Admin)
            {
                adminOperation?.Invoke();
            }
            else if (role == Role.Admin)
            {
                teacherOperation?.Invoke();
            }
            else if (role == Role.Student)
            {
                studentOperation?.Invoke();
            }
        }
        #region Users tab

        private void AdminsUsersUpdate()
        {
            _roleFlag = Role.Admin;
            UpdateUsersTable<Admin>(UsersTable, AdminsUsersRequest(_currentPage, _context));
        }
        private void AdminUsers_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in admins...";
            AdminsUsersUpdate();
        }

        private void TeachersUsersUpdate()
        {
            _roleFlag = Role.Teacher;
            UpdateUsersTable<Teacher>(UsersTable, TeachersUsersRequest(_currentPage, _context));
        }
        private void TeacherUsers_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in teachers...";
            TeachersUsersUpdate();
        }

        private void StudentsUsersUpdate()
        {
            _roleFlag = Role.Student;
            UpdateUsersTable<Student>(UsersTable, StudentsUsersRequest(_currentPage, _context));
        }
        private void StudentUsers_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in students...";
            StudentsUsersUpdate();
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
                    GenericClickOnUsers<Admin>(user, selectedUsername, AdminsUsersUpdate, this, user => new AdminUserForm(user));
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericClickOnUsers<Teacher>(user, selectedUsername, TeachersUsersUpdate, this, user => new AdminUserForm(user));
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericClickOnUsers<Student>(user, selectedUsername, StudentsUsersUpdate, this, user => new AdminUserForm(user));
                }

            }
        }
        #endregion
        #region Requests tab

        private void RequestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = RequestsTable.Rows[e.RowIndex];
                string? selectedUsername = selectedRow.Cells["FromUsernameColumn"].Value.ToString();
                string? selectedRequest = selectedRow.Cells["TypeColumn"].Value.ToString();
                User? user = new();
                if (_roleFlag == Role.Admin)
                {
                    GenericClickOnUsers<Admin>(user, selectedUsername, AdminsRequestUpdate, this, user => new AdminRequestForm(user, selectedRequest));
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericClickOnUsers<Teacher>(user, selectedUsername, TeachersRequestUpdate, this, user => new AdminRequestForm(user, selectedRequest));
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericClickOnUsers<Student>(user, selectedUsername, StudentRequestUpdate, this, user => new AdminRequestForm(user, selectedRequest));
                }

            }
        }

        internal void AdminsRequestUpdate()
        {
            _roleFlag = Role.Admin;
            UpdateRequestsTable<Admin>(RequestsTable, AdminsRequest(_currentPage, _context));
        }
        internal void TeachersRequestUpdate()
        {
            _roleFlag = Role.Teacher;
            UpdateRequestsTable<Teacher>(RequestsTable, TeachersRequest(_currentPage, _context));
        }
        internal void StudentRequestUpdate()
        {
            _roleFlag = Role.Student;
            UpdateRequestsTable<Student>(RequestsTable, StudentsRequest(_currentPage, _context));
        }


        private void AdminsRequests_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            RequestMessageBox.Text = "Searching in admins...";
            AdminsRequestUpdate();
        }


        private void TeachersRequests_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            RequestMessageBox.Text = "Searching in teachers...";
            TeachersRequestUpdate();
        }

        private void StudentsRequests_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            RequestMessageBox.Text = "Searching in students...";
            StudentRequestUpdate();
        }

        private void NextPageRequests_Click(object sender, EventArgs e)
        {
            NextPage(_roleFlag, AdminsRequestUpdate, TeachersRequestUpdate, StudentRequestUpdate);
        }
        private void PreviousPageRequests_Click(object sender, EventArgs e)
        {
            PreviousPage(_roleFlag, AdminsRequestUpdate, TeachersRequestUpdate, StudentRequestUpdate);
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
                AdminsUsersRequest(_currentPage, _context, ByUsernameCheck.Checked, FilterTextBox.Text);
            }
            else if (_roleFlag == Role.Admin)
            {
                TeachersUsersRequest(_currentPage, _context, ByUsernameCheck.Checked, FilterTextBox.Text);
            }
            else
            {
                UpdateUsersTable(UsersTable, StudentsUsersRequest(_currentPage, _context, ByUsernameCheck.Checked, FilterTextBox.Text));
            }
        }
        #region Courses tab
        private void AvailableCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickOnCourse(1, this, AvailableCoursesTable, e, _user);
        }
        #endregion

        private void NextUsersButton_Click(object sender, EventArgs e)
        {
            NextPage(_roleFlag, AdminsUsersUpdate, TeachersUsersUpdate, StudentsUsersUpdate);
        }

        private void PreviousUsersButton_Click(object sender, EventArgs e)
        {
            PreviousPage(_roleFlag, AdminsUsersUpdate, TeachersUsersUpdate, StudentsUsersUpdate);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ShowNextFormUpdateCourseTable(this, new CourseCreatorForm(), AvailableCoursesTable);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {

        }
    }
}
