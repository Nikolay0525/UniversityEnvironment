using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;

namespace UniversityEnvironment.View.Forms.AdminForms
{
    public partial class TestCreatorForm : CreatorForm
    {
        private Guid CourseId;
        public TestCreatorForm(Course course) : base()
        {
            CourseId = course.Id;
            InitializeComponent();
        }

        override protected void CreateButton_Click(object sender, EventArgs e)
        {
            Test test = new()
            {
                Name = TestNameBox.Text,
                Description = DescriptionBox.Text,
                CourseId = CourseId
            };
            Create<Test>(test);
            Close();
        }
    }
}
