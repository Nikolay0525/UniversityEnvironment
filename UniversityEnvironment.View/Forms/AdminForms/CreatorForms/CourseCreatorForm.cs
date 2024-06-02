using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;

namespace UniversityEnvironment.View.Forms.AdminForms
{
    public partial class CourseCreatorForm : CreatorForm
    {
        public CourseCreatorForm() : base()
        {
            InitializeComponent();
        }

        override protected void CreateButton_Click(object sender, EventArgs e)
        {
            if (Validators.ViewValidators.ValidateStringOnLength("name", CourseNameBox.Text, 2, 20)
                || Validators.ViewValidators.ValidateStringOnLength("faculty name", CourseNameBox.Text, 2, 30)) return;
            Course course = new()
            {
                Name = CourseNameBox.Text,
                FacultyName = FacultyNameBox.Text
            };
            Create(course);
            Close();
        }
    }
}
