using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;

namespace UniversityEnvironment.View.Forms.AdminForms
{
    public partial class TestCreatorForm : CreatorForm
    {
        private Guid _courseId;
        public TestCreatorForm(Course course) : base()
        {
            _courseId = course.Id;
            InitializeComponent();
        }

        override protected void CreateButton_Click(object sender, EventArgs e)
        {
            Test test = new()
            {
                Name = TestNameBox.Text,
                Description = DescriptionBox.Text,
                CourseId = _courseId
            };
            Create<Test>(test);
            Close();
        }
    }
}
