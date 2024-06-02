using MaterialSkin.Controls;
using UniversityEnvironment.Data;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms.AdminForms;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

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
                if (Validators.ViewValidators.ValidateNull(selectedUsername, "selectedUsername")) return;
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
                if (Validators.ViewValidators.ValidateNull(selectedUsername, "selectedUsername") 
                    || Validators.ViewValidators.ValidateNull(selectedRequest, "selectedRequest")) return;
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

        private void AdminsRequestUpdate()
        {
            _roleFlag = Role.Admin;
            UpdateRequestsTable<Admin>(RequestsTable, AdminsRequest(_currentPage, _context));
        }
        private void TeachersRequestUpdate()
        {
            _roleFlag = Role.Teacher;
            UpdateRequestsTable<Teacher>(RequestsTable, TeachersRequest(_currentPage, _context));
        }
        private void StudentRequestUpdate()
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
            NextPage(_roleFlag, ref _currentPage, AdminsRequestUpdate, TeachersRequestUpdate, StudentRequestUpdate);
        }
        private void PreviousPageRequests_Click(object sender, EventArgs e)
        {
            PreviousPage(_roleFlag, ref _currentPage, AdminsRequestUpdate, TeachersRequestUpdate, StudentRequestUpdate);
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
                UpdateUsersTable(UsersTable, AdminsUsersRequest(_currentPage, _context, ByUsernameCheck.Checked, FilterTextBox.Text));
            }
            else if (_roleFlag == Role.Teacher)
            {
                UpdateUsersTable(UsersTable, TeachersUsersRequest(_currentPage, _context, ByUsernameCheck.Checked, FilterTextBox.Text));
            }
            else if (_roleFlag == Role.Student)
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
            NextPage(_roleFlag, ref _currentPage, AdminsUsersUpdate, TeachersUsersUpdate, StudentsUsersUpdate);
        }

        private void PreviousUsersButton_Click(object sender, EventArgs e)
        {
            PreviousPage(_roleFlag, ref _currentPage, AdminsUsersUpdate, TeachersUsersUpdate, StudentsUsersUpdate);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ShowNextFormUpdateCourseTable(this, new CourseCreatorForm(), AvailableCoursesTable);
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {
            DeleteCourse(AvailableCoursesTable);
        }
    }
}
