﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static UniversityEnvironment.View.Utility.Constants;
using static System.Net.Mime.MediaTypeNames;
using UniversityEnvironment.Data.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using UniversityEnvironment.Data.Repositories;
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Devices;
using MaterialSkin.Controls;
using UniversityEnvironment.View.Enums;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.View.Utility
{
    internal static class ViewHelper
    {
        
        internal static void ShowNextForm(MaterialForm current, MaterialForm next)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.Show();
        }
        internal static void ShowNextForm(MaterialForm current, MaterialForm next, DataGridView table)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.FormClosed += (s, arg) => table.Rows.Clear();
            next.Show();
        }
        internal static void AvailableCoursesTableAddRows(DataGridView table, IEnumerable<Course> courses)
        {
            ArgumentNullException.ThrowIfNull(courses);

            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Name, course.FacultyName);
            }
        }
        internal static void ActualCoursesTableAddRows(DataGridView table, IEnumerable<Course> courses)
        {
            ArgumentNullException.ThrowIfNull(courses);

            foreach (var course in courses)
            {
                table.Rows.Add(course.Name, course.FacultyName);
            }
        }

        internal static void UpdateTableWithActualCourses<T>(DataGridView table, User user) where T : CourseUser
        {
            table.Rows.Clear();
            var courseList = RepositoryManager.GetRepo<Course>().GetAll().ToList();
            List<T> courseUser = RepositoryManager.GetRepo<T>().GetAll(u => u.UserId == user.Id).ToList();
            courseList.RemoveAll(course => !courseUser.Any(cu => cu.CourseId == course.Id));
            ArgumentNullException.ThrowIfNull(courseList);
            ActualCoursesTableAddRows(table, courseList);
        }

        internal static void UserCourseOperation<T,Q>(DataGridView table, User user, CourseOperation @op) where T : CourseUser,new() where Q : User
        {
            List<Course> courses = RepositoryManager.GetRepo<Course>().GetAll().ToList();
            var userCourses = new List<T>();
            var foundedUser = RepositoryManager.GetRepo<Q>().FindById(user.Id);
            ArgumentNullException.ThrowIfNull(foundedUser);
            for (int i = 0; i < courses.Count; i++)
            {
                var value = table.Rows[i].Cells[0].Value;
                if (value != null && bool.TryParse(value.ToString(), out bool parsed) && parsed)
                {
                    userCourses.Add(new() { UserId = user.Id, CourseId = courses[i].Id });
                }
            }
            if(@op == 0) 
            { 
                var count = RepositoryManager.GetRepo<T>().Create(userCourses);
                if (count == 0) return;
                MessageBox.Show("Successfully signed on courses!", "Environment", MessageBoxButtons.OK);
            }
            else 
            {
                var count = RepositoryManager.GetRepo<T>().Create(userCourses);
                RepositoryManager.GetRepo<T>().Remove(userCourses);
                if (count != 0) return;
                MessageBox.Show("Successfully unsigned from courses!", "Environment", MessageBoxButtons.OK);
            }
            
        }

        public static void UpdateRequestsTable<T>(DataGridView table, IEnumerable<T> users) where T : User
        {
            ArgumentNullException.ThrowIfNull(users);
            table.Rows.Clear();

            foreach (var user in users)
            {
                if (!user.Confirmed) table.Rows.Add(user.Username, user.Role, "Confirm account");
                else if(user.ForgetPassword) table.Rows.Add(user.Username, user.Role, "Forget password");
            }
        }
        /* internal static void UpdateTeacherTable(DataGridView table, List<Course> courses, Course course)
         {
             foreach (var user in course.Users)
             {
                 if (user.Role == "Teacher" && table != null)
                 {
                     DataGridViewRow newRow = new DataGridViewRow();
                     DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                     nameCell.Value = user.Username;
                     newRow.Cells.Add(nameCell);
                     table.Rows.Add(newRow);
                 }
             }
         }
         internal static void UpdateContentOfTableJournal(DataGridView table, List<Course> courses, Course course)
         {
             foreach (var test in course.Tests)
             {
                 if (table.Columns[test.Name] == null)
                 {
                     DataGridViewTextBoxColumn testColumn = new DataGridViewTextBoxColumn();
                     testColumn.HeaderText = test.Name;
                     testColumn.Name = test.Name;
                     testColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                     table.Columns.Add(testColumn);
                 }
             }

             foreach (var test in course.Tests)
             {
                 foreach (var student in test.Students)
                 {
                     bool match = false;
                     if (table.Rows.Count != 0)
                     {
                         Console.WriteLine();
                         foreach (DataGridViewRow row in table.Rows)
                         {
                             if (row.Cells[0].Value.ToString() == student.Username)
                             {
                                 row.Cells[course.Tests.FindIndex(t => t.Id == test.Id) + 1].Value = student.Mark;
                                 match = true;
                                 break;
                             }
                         }
                     }
                     if (!match)
                     {
                         List<Course> lists = RepoImplementation<Course>.GetRepo(CoursesDBPath).GetAllObjectsByFilter();
                         foreach (var l in lists)
                         {
                             Console.WriteLine(l.Tests.ToString());
                         }
                         DataGridViewRow newRow = new DataGridViewRow();
                         newRow.CreateCells(table);
                         newRow.Cells[0].Value = student.Username;
                         newRow.Cells[course.Tests.FindIndex(t => t.Id == test.Id) + 1].Value = student.Mark;
                         table.Rows.Add(newRow);
                     }
                 }
             }
         }
         internal static void ApplyChangesToDBJournal(DataGridView table, List<Course> courses, Course course)
         {
             foreach (DataGridViewRow row in table.Rows)
             {
                 foreach (DataGridViewCell cell in row.Cells)
                 {
                     foreach (var test in course.Tests)
                     {
                         if (test.Name == cell.OwningColumn.Name)
                         {
                             foreach (var student in test.Students)
                             {
                                 if (row.Cells[0].Value.ToString() == student.Username)
                                 {
                                     if (int.TryParse(cell.Value.ToString(), out int mark))
                                     {
                                         student.Mark = mark;
                                     }
                                 }
                             }
                         }
                     }
                 }
             }
         }

         internal static void SendTestAnswers(List<Course> courses, User user, Course course, Test test, List<List<bool>> questions)
         {
             if (user.Role != "Teacher")
             {
                 List<Student> students = test.Students;
                 foreach (var studentCheker in students)
                 {
                     Console.WriteLine(studentCheker.Username);
                     if (studentCheker.Username == user.Username)
                     {
                         MessageBox.Show("You can't pass it twice...", test.Name, MessageBoxButtons.OK);
                         return;
                     }
                 }
                 Student student = new Student(user.Username, user.FirstName, user.LastName);
                 courses.FirstOrDefault(c => c.Id == course.Id).Tests.FirstOrDefault(t => t.Id == test.Id).AddObject(student);

                 for (int i = 0; i < questions.Count; i++)
                 {
                     var question = questions[i];
                     for (int j = 0; j < question.Count; j++)
                     {
                         var answer = question[j];
                         if (answer == true)
                         {
                             courses.FirstOrDefault(c => c.Id == course.Id).Tests.FirstOrDefault(t => t.Id == test.Id).Questions[i].Answers[j].Students.Add(student);
                         }
                     }
                 }
                 MessageBox.Show("Successful! Now wait for assessment...", test.Name, MessageBoxButtons.OK);
                 return;
             }
             MessageBox.Show("You are not student...", test.Name, MessageBoxButtons.OK);
         }*/
    }
}
