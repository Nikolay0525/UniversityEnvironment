using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms.AdminForms;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class CourseForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;

        public CourseForm(User user, Course course)
        {
            _user = user;
            _course = course;
            this.Text = "Welcome to " + course.Name + " course!";
            InitializeComponent();
            if (user.Role != Role.Admin)
            {
                Height = 400;
                CreateTestButton.Visible = false;
                DeleteTestButton.Visible = false;
            }
            UpdateTeacherTable(TeacherTable, _course);
            UpdateTestsTable(TestsTable, _course);
        }

        private void JournalButton_Click(object sender, EventArgs e)
        {
            ShowNextForm(this, new JournalForm(_user, _course));
            return;
        }
        private void TestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickOnTest(1, this, TestsTable, e, _user);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ShowNextFormUpdateTable<Course>(this, new TestCreatorForm(_course), TestsTable, _course, UpdateTestsTable);
        }

        private void DeleteTestButton_Click(object sender, EventArgs e)
        {
            DeleteTest(_course.Id, TestsTable, false);
        }

        private void TeacherTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GenericClickOnUsers<Teacher>(_user, selectedUsername, TeachersUsersUpdate, this, user => new AdminUserForm(user));
        }
    }
}
