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
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Repository;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms
{
    public partial class BaseCourseForm : MaterialForm
    {
        private readonly User _user;
        private Course _course;

        public BaseCourseForm(User user, Course course)
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
            ClickOnTest(this, TestsTable, e, _user, _course);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
