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
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.Constants;

namespace UniversityEnvironment.View.Forms
{
    public partial class BaseCourseForm : MaterialForm
    {
        private UniversityEnvironmentContext _context;
        private readonly User? _user;
        private readonly Course? _course;

        public BaseCourseForm(User user, Course course)
        {
            _context = new UniversityEnvironmentContext();
            _user = user;
            _course = course;
            this.Text = "Welcome to " + course.Name + " course!";
            InitializeComponent();
            //RepositoryManager.GetRepo<Course>(_context).ReadingOperationsWithTable<Course>(TeacherTable, 1, _course, UpdateTeacherTable);
        }

        private void JournalButton_Click(object sender, EventArgs e)
        {
            //RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<Course>(TeacherTable, 1, _course, UpdateTeacherTable);
            Hide();
            JournalForm journalForm = new JournalForm(_user, _course);
            journalForm.FormClosed += (s, arg) =>
            {
                Show();
            };
            journalForm.Show();
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
