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
//using UniversityEnvironment.View.Forms.AdminForms;

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

        #region Users
        private void AdminUsers_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in admins...";
        }

        private void TeacherUsers_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in teachers...";
        }

        private void StudentUsers_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            UsersMessageBox.Text = "Searching in students...";
        }
        private void UsersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = RequestsTable.Rows[e.RowIndex];
                string? selectedUsername = selectedRow.Cells["FromUsernameColumn"].Value.ToString();
                User? user = new();
                if (_roleFlag == Role.Admin)
                {
                    GenericClick<Admin>(this, new AdminUserForm(user), user, selectedUsername, AdminsRequestUpdate);
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericClick<Teacher>(this, new AdminUserForm(user), user, selectedUsername, TeachersRequestUpdate);
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericClick<Student>(this, new AdminUserForm(user), user, selectedUsername, StudentRequestUpdate);
                }

            }*/
        }
        #endregion
        private void GenericClick<T>(MaterialForm thisForm,MaterialForm nextForm, User? user, string? username, UpdateRequestAfterClosing operation) where T : User
        {
            RepositoryManager.GetRepo<T>(_context).FindByFilter(a => a.Username == username);
            user = SetUserRole<T>(_context, username);
            ArgumentNullException.ThrowIfNull(user);
            ShowNextForm(thisForm, nextForm, operation);
        }
        #region Requests
        private void RequestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = RequestsTable.Rows[e.RowIndex];
                string? selectedUsername = selectedRow.Cells["FromUsernameColumn"].Value.ToString();
                User? user = new();
                if (_roleFlag == Role.Admin)
                {
                    GenericClick<Admin>(this,new AdminRequestForm(user), user, selectedUsername, AdminsRequestUpdate);
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericClick<Teacher>(this,new AdminRequestForm(user),user, selectedUsername, TeachersRequestUpdate);
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericClick<Student>(this, new AdminRequestForm(user), user, selectedUsername, StudentRequestUpdate);
                }

            }
        }
        internal void AdminsRequestUpdate()
        {
            _roleFlag = Role.Admin;
            var query = _context.Admins
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
            var query = _context.Teachers
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
                    CoursesTeachers = teacher.CoursesTeachers
                })
                .ToList();
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
            var query = _context.Students
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
                    QuestionAnswersStudent = student.QuestionAnswersStudent,
                    TestsStudents = student.TestsStudents,
                    CoursesStudents = student.CoursesStudents
                })
                .ToList();

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
    }
}
