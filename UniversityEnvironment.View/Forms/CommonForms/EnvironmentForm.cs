using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using UniversityEnvironment.View.Utility;
using System.Collections.Generic;
using static UniversityEnvironment.View.Validator.ViewValidator;

using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.ViewHelper;
using UniversityEnvironment.View.Enums;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data;
using Microsoft.VisualBasic.Devices;

namespace UniversityEnvironment.View.Forms

{
    public partial class EnvironmentForm : MaterialForm
    {
        private readonly User _user;

        public EnvironmentForm(User user)
        {
            _user = user;
            InitializeComponent();
            PersonName.Text = user.FirstName + " " + user.LastName;
            PersonRole.Text = user.Role.ToString();
            AvailableCoursesTableUpdate(AvailableCoursesTable, FindAll<Course>().ToList());
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
            ClickOnCourse(0, this, ActualCoursesTable,e,_user);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
