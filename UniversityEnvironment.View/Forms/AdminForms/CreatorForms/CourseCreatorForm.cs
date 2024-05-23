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
using System.Configuration;
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
            Course course = new()
            {
                Name = CourseNameBox.Text,
                FacultyName = FacultyNameBox.Text
            };
            Create<Course>(course);
            Close();
        }
    }
}
