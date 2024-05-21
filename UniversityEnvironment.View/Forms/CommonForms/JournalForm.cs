using System;
using System.IO;
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
using UniversityEnvironment.Data.Model.Tables;
using System.Xml.Linq;
using UniversityEnvironment.View.Utility;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repository;
using UniversityEnvironment.Data;


namespace UniversityEnvironment.View.Forms
{
    public partial class JournalForm : MaterialForm
    {
        private UniversityEnvironmentContext _context;
        private readonly User _user;
        private readonly Course _course;
        public JournalForm(User User, Course course)
        {
            _context = new UniversityEnvironmentContext();
            _user = User;
            _course = course;
            this.Text = "Welcome to " + course.Name + " journal!";
            InitializeComponent();
            if (_user.Role == Data.Enums.Role.Student) // access to table
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = true;
                }
            }
            else
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = false;
                }
            }
            //RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<Course>(JournalTable, 1, _course, UpdateContentOfTableJournal);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (_user.Role == Data.Enums.Role.Teacher)
            {
                //RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadAndWriteOperationsWithTable<Course>(JournalTable, 0, _course, ApplyChangesToDBJournal);
                return;
            }
            MessageBox.Show("You aren't teacher!", "Journal", MessageBoxButtons.OK);
        }

        private void JournalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = JournalTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["ActualGridColumnCourseId"].Value.ToString();
                List<Course> courses = MakeObjectsList<Course>(CoursesDBPath);
                foreach (var course in courses)
                {
                    if (course.Id == int.Parse(selectedId))
                    {
                        Hide();
                        Form formInstance = FormCreater.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
                        formInstance.FormClosed += (s, arg) =>
                        {
                            Show();
                        };
                        formInstance.Show();
                    }
                }

            }*/

        }
    }
}
