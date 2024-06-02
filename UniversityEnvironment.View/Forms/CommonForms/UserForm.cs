using MaterialSkin.Controls;
using System.Diagnostics.Contracts;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class UserForm : MaterialForm
    {
        protected Course? _course;
        protected User? _realUser;
        protected User _profileUser;
        public UserForm()
        {

        }

        public UserForm(User profileUser,Course? course = null,User? realUser = null)
        {
            InitializeComponent();
            _course = course;
            _profileUser = profileUser;
            _realUser = realUser;
            NameBox.Text = _profileUser.FirstName;
            SurnameBox.Text = _profileUser.LastName;
            RoleBox.Text = _profileUser.Role.ToString();
            if(realUser != null && (realUser.Role == Data.Enums.Role.Student || realUser.Role == Data.Enums.Role.Admin))
            {
                DeductButton.Visible = false;
                CloseButton.Height = 144;
                CloseButton.Top = 212;
            }
            if (_profileUser.Role == Data.Enums.Role.Teacher)
            {
                var teacher = FindByFilter<Teacher>(t => t.Id == _profileUser.Id);
                Validators.ViewValidators.ValidateNull(teacher, "teacher");
                ScienceDegreeBox.Text = teacher!.ScienceDegree;
            }
            else
            {
                ScienceDegreeBox.Hide();
                ScienceDegreeLabel.Hide();
            }
            FillCourseList(CoursesList, _profileUser);
        }

        private void DeductButton_Click(object sender, EventArgs e)
        {
            if (_course == null || _realUser == null) return;
            DeductStudentFromCourse(this, _course, _realUser, _profileUser);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
