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
using UniversityEnvironment.Data;

namespace UniversityEnvironment.View.Forms

{
    public partial class EnvironmentForm : MaterialForm
    {
        private UniversityEnvironmentContext _context;
        private readonly User _user;

        public EnvironmentForm(User user)
        {
            _context = new UniversityEnvironmentContext();
            _user = user;
            InitializeComponent();
            PersonName.Text = user.FirstName + " " + user.LastName;
            PersonRole.Text = user.Role.ToString();
            AvailableCoursesTableAddRows(AvailableCoursesTable, RepositoryManager.GetRepo<Course>(_context).FindAll().ToList());
            if(_user.Role == Role.Teacher) UpdateTableWithActualCourses<CourseTeacher>(_context, ActualCoursesTable, user);
            else UpdateTableWithActualCourses<CourseStudent>(_context, ActualCoursesTable, user);
        }
        
        private void SignButton_Click(object sender, EventArgs e)
        {
            
            if (_user.Role == Role.Teacher)
            {
                UserCourseOperation<CourseTeacher, Teacher>(_context, AvailableCoursesTable, _user, CourseOperation.Create);
                UpdateTableWithActualCourses<CourseTeacher>(_context, ActualCoursesTable, _user);
            }
                
            else
            {
                UserCourseOperation<CourseStudent, Student>(_context, AvailableCoursesTable, _user, CourseOperation.Create);
                UpdateTableWithActualCourses<CourseStudent>(_context, ActualCoursesTable, _user);
            }
                
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            if (_user.Role == Role.Teacher)
            {
                UserCourseOperation<CourseTeacher, Teacher>(_context, AvailableCoursesTable, _user, CourseOperation.Remove);
                UpdateTableWithActualCourses<CourseTeacher>(_context, ActualCoursesTable, _user);
            }

            else
            {
                UserCourseOperation<CourseStudent, Student>(_context, AvailableCoursesTable, _user, CourseOperation.Remove);
                UpdateTableWithActualCourses<CourseStudent>(_context, ActualCoursesTable, _user);
            }
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickOnCourse(_context, this,ActualCoursesTable,e,_user);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
