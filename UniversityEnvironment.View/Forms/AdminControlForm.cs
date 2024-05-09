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

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminControlForm : MaterialForm
    {
        private readonly User _user;
        private UniversityEnvironmentContext _context;
        private Role _roleFlag;
        private int _requestAdminPage = 0;
        private int _requestTeacherPage = 0;
        private int _requestStudentPage = 0;
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
            UsersMessageBox.Text = "Searching in admins...";
        }

        private void TeacherUsers_Click(object sender, EventArgs e)
        {
            UsersMessageBox.Text = "Searching in teachers...";
        }

        private void StudentUsers_Click(object sender, EventArgs e)
        {
            UsersMessageBox.Text = "Searching in students...";
        }
        #endregion
        #region Requests
        private void GenericRequestClick<T>(User? user, string? username, UpdateRequestAfterClosing operation) where T : User
        {
            RepositoryManager.GetRepo<T>().FindByFilter(a => a.Username == username);
            user = SetUserRole<T>(username);
            ArgumentNullException.ThrowIfNull(user);
            ShowNextForm(this, new AdminRequestForm(user), operation);
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
                    GenericRequestClick<Admin>(user, selectedUsername, AdminsRequestUpdate);
                }
                else if (_roleFlag == Role.Teacher)
                {
                    GenericRequestClick<Teacher>(user, selectedUsername, TeachersRequestUpdate);
                }
                else if (_roleFlag == Role.Student)
                {
                    GenericRequestClick<Student>(user, selectedUsername, StudentRequestUpdate);
                }

            }
        }
        internal void AdminsRequestUpdate()
        {
            _roleFlag = Role.Admin;
            _context = new UniversityEnvironmentContext();
            var query = _context.Admins
                .Where(admin => admin.ForgetPassword == true || admin.Confirmed == false)
                .Skip(_requestAdminPage * Constants.RowsPerPage)
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
            RequestMessageBox.Text = "Searching in admins...";
            AdminsRequestUpdate();
        }
        internal void TeachersRequestUpdate()
        {
            _roleFlag = Role.Teacher;
            _context = new UniversityEnvironmentContext();
            var query = _context.Teachers
                .Where(teacher => teacher.ForgetPassword == true || teacher.Confirmed == false)
                .Skip(_requestTeacherPage * Constants.RowsPerPage)
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
            RequestMessageBox.Text = "Searching in teachers...";
            TeachersRequestUpdate();
        }

        internal void StudentRequestUpdate()
        {
            _roleFlag = Role.Student;
            _context = new UniversityEnvironmentContext();
            var query = _context.Students
                .Where(student => student.ForgetPassword == true)
                .Skip(_requestStudentPage * Constants.RowsPerPage)
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
            RequestMessageBox.Text = "Searching in students...";
            StudentRequestUpdate();
        }

        private void NextPageRequests_Click(object sender, EventArgs e)
        {
            if (_roleFlag == Role.Admin)
            {
                _requestAdminPage++;
                AdminsRequestUpdate();
            }
            else if (_roleFlag == Role.Admin)
            {
                _requestTeacherPage++;
                TeachersRequestUpdate();
            }
            else
            {
                _requestStudentPage++;
                StudentRequestUpdate();
            }
        }
        private void PreviousPageRequests_Click(object sender, EventArgs e)
        {
            if (_roleFlag == Role.Admin)
            {
                _requestAdminPage = _requestAdminPage > 0 ? _requestAdminPage - 1 : _requestAdminPage;
                AdminsRequestUpdate();
            }
            else if (_roleFlag == Role.Admin)
            {
                _requestTeacherPage = _requestTeacherPage > 0 ? _requestTeacherPage - 1 : _requestTeacherPage;
                TeachersRequestUpdate();
            }
            else
            {
                _requestStudentPage = _requestStudentPage > 0 ? _requestStudentPage - 1 : _requestStudentPage;
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
