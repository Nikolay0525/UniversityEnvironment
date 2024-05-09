using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using UniversityEnvironment.View.Utility;
using System.Collections.Generic;
using static UniversityEnvironment.View.Validator.ViewValidator;
using UniversityEnvironment.Data.Repository;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.ViewHelper;
using UniversityEnvironment.View.Enums;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.View.Forms

{
    public partial class EnvironmentForm : MaterialForm
    {
        private readonly User _user;

        public EnvironmentForm(User user)
        {
            InitializeComponent();
            _user = user;
            PersonName.Text = user.FirstName + " " + user.LastName;
            PersonRole.Text = user.Role.ToString();
            AvailableCoursesTableAddRows(AvailableCoursesTable, RepositoryManager.GetRepo<Course>().GetAll().ToList());
            if(_user.Role == Role.Teacher) UpdateTableWithActualCourses<CourseTeacher>(ActualCoursesTable, user);
            else UpdateTableWithActualCourses<CourseStudent>(ActualCoursesTable, user);
        }
        
        private void SignButton_Click(object sender, EventArgs e)
        {
            
            if (_user.Role == Role.Teacher)
            {
                UserCourseOperation<CourseTeacher, Teacher>(AvailableCoursesTable, _user, CourseOperation.Create);
                UpdateTableWithActualCourses<CourseTeacher>(ActualCoursesTable, _user);
            }
                
            else
            {
                UserCourseOperation<CourseStudent, Student>(AvailableCoursesTable, _user, CourseOperation.Create);
                UpdateTableWithActualCourses<CourseStudent>(ActualCoursesTable, _user);
            }
                
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            if (_user.Role == Role.Teacher)
            {
                UserCourseOperation<CourseTeacher, Teacher>(AvailableCoursesTable, _user, CourseOperation.Remove);
                UpdateTableWithActualCourses<CourseTeacher>(ActualCoursesTable, _user);
            }

            else
            {
                UserCourseOperation<CourseStudent, Student>(AvailableCoursesTable, _user, CourseOperation.Remove);
                UpdateTableWithActualCourses<CourseStudent>(ActualCoursesTable, _user);
            }
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = ActualCoursesTable.Rows[e.RowIndex];
                string? selectedCourse = selectedRow.Cells["ActualGridColumnCourseName"].Value.ToString();
                if (RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Name == selectedCourse) != null)
                {
                    Course? course = RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Name == selectedCourse);
                    Hide();
                    Form formInstance = FormCreater.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
                    formInstance.FormClosed += (s, arg) =>
                    {
                        Show();
                    };
                    formInstance.Show();
                }

            }*/
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
