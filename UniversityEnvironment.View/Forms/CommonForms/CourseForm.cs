using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.Data;
using UniversityEnvironment.View.Forms.AdminForms;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.View.Utility.AdminViewHelper;

using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms
{
    public partial class CourseForm : MaterialForm
    {
        private readonly User _user;
        private Course _course;

        public CourseForm(User user, Course course)
        {
            _user = user;
            _course = course;
            this.Text = "Welcome to " + course.Name + " course!";
            InitializeComponent();
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
            ClickOnTest(1, this, TestsTable, e, _user, _course);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ShowNextFormUpdateTestTable(this, new TestCreatorForm(_course), TestsTable, _course); 
        }

        private void DeleteTestButton_Click(object sender, EventArgs e)
        {
            DeleteTest(_course.Id, TestsTable, false);
        }
    }
}
