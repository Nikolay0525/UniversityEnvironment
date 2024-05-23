using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static UniversityEnvironment.View.Utility.Constants;
using static System.Net.Mime.MediaTypeNames;

using static System.Runtime.InteropServices.JavaScript.JSType;
using static UniversityEnvironment.Data.Service.MySqlService;
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Devices;
using MaterialSkin.Controls;
using UniversityEnvironment.View.Enums;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;
//using Microsoft.VisualBasic.ApplicationServices;

namespace UniversityEnvironment.View.Utility
{
    internal static class ViewHelper
    {
        internal delegate void VoidOperation();
        internal delegate T? GenericOperationWithUserObj<T>(T obj) where T : User;
        internal delegate void GenericOperationWithTable<T>(DataGridView table, T obj);
        #region Form event operations
        internal static void ShowNextForm(MaterialForm current, MaterialForm next)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.Show();
        }
        internal static void ShowNextForm(MaterialForm current, MaterialForm next, VoidOperation operation)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.FormClosed += (s, arg) => operation();
            next.Show();
        }
        #endregion
        
        #region Table operation methods
        internal static void AvailableCoursesTableUpdate(DataGridView table, IEnumerable<Course> courses)
        {
            ArgumentNullException.ThrowIfNull(courses);
            table.Rows.Clear();

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
            var courseList = FindAll<Course>().ToList();
            List<T> courseUser = FindAll<T>(u => u.UserId == user.Id).ToList();
            courseList.RemoveAll(course => !courseUser.Any(cu => cu.CourseId == course.Id));
            ArgumentNullException.ThrowIfNull(courseList);
            ActualCoursesTableAddRows(table, courseList);
        }

        internal static void UserCourseOperation<T, Q>(DataGridView table, User user, CourseOperation @op) where T : CourseUser, new() where Q : User
        {
            List<Course> courses = FindAll<Course>().ToList();
            var userCourses = new List<T>();
            var foundedUser = FindByFilter<Q>(u => u.Id == user.Id);
            ArgumentNullException.ThrowIfNull(foundedUser);
            for (int i = 0; i < courses.Count; i++)
            {
                var value = table.Rows[i].Cells[0].Value;
                if (value != null && bool.TryParse(value.ToString(), out bool parsed) && parsed)
                {
                    userCourses.Add(new() { UserId = user.Id, CourseId = courses[i].Id });
                }
            }
            if (@op == 0)
            {
                var count = Create<T>(userCourses);
                if (count == 0) return;
                MessageBox.Show("Successfully signed on courses!", "Environment", MessageBoxButtons.OK);
            }
            else
            {
                var count = Remove<T>(userCourses);
                if (count == 0) return;
                MessageBox.Show("Successfully unsigned from courses!", "Environment", MessageBoxButtons.OK);
            }
        }
        internal static void UpdateTeacherTable(DataGridView table, Course course)
        {
            List<Teacher> teachers = new List<Teacher>();
            List<Teacher> allTeachers = FindAll<Teacher>().ToList();
            List<CourseTeacher> coursesTeachers = FindAll<CourseTeacher>(ct => ct.CourseId == course.Id).ToList();

            foreach (var courseTeacher in coursesTeachers)
            {
                var teacher = allTeachers.FirstOrDefault(t => t.Id == courseTeacher.UserId);
                if (teacher != null) teachers.Add(teacher);
            }
            teachers.ForEach(t => table.Rows.Add(t.FirstName + " " + t.LastName));
        }
        internal static void UpdateTestsTable(DataGridView table, Course course)
        {
            var tests = FindAll<Test>(t => t.CourseId == course.Id);
            if (tests == null) return;
            table.Rows.Clear();
            foreach (var test in tests) { table.Rows.Add(false, test.Name, test.Description); }

        }
        internal static void UpdateQuestionTable(DataGridView table, Test test)
        {
            var questions = FindAll<TestQuestion>(q => q.TestId == test.Id);
            if (questions == null) return;
            table.Rows.Clear();
            foreach (var question in questions) { table.Rows.Add(question.Id,false, question.QuestionText); }

        }
        internal static void UpdateAnswerTable(DataGridView table, TestQuestion testQuestion)
        {
            var answers = FindAll<QuestionAnswer>(a => a.TestQuestionId == testQuestion.Id);
            if (answers == null) return;
            table.Rows.Clear();
            foreach (var answer in answers) { table.Rows.Add(answer.Id,false, answer.AnswerText); }

        }
        #endregion
        #region ClickOnMethods
        internal static void ClickOnCourse
            (int columnIndex,MaterialForm form,DataGridView table, DataGridViewCellEventArgs e, User user)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                string? selectedCourse = selectedRow.Cells["CourseColumn"].Value.ToString();
                if (selectedCourse == null) return;
                var course = FindByFilter<Course>(c => c.Name == selectedCourse);
                if (course == null) return;
                ShowNextForm(form, new View.Forms.BaseCourseForm(user, course));
            }
        }
        internal static void ClickOnTest
            (int columnIndex,MaterialForm form,DataGridView table, DataGridViewCellEventArgs e, User user, Course course)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                string? selectedTest = selectedRow.Cells["TestName"].Value.ToString();
                var test = FindByFilter<Test>(t => t.CourseId == course.Id);
                if (test == null) return;
                ShowNextForm(form, new View.Forms.BaseTestForm(user, course, test));
            }
        }
        internal static void ClickOnQuestion
            (int columnIndex,MaterialForm form, DataGridView table,DataGridViewCellEventArgs e, User user ,Course course,Test test)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                var selectedQuestion = selectedRow.Cells["IdColumn"].Value.ToString();
                TestQuestion? question = null;
                if(selectedQuestion != null && Guid.TryParse(selectedQuestion, out Guid result))
                {
                    question = FindByFilter<TestQuestion>(q => q.Id == result);
                }
                if (question == null) return;
                ShowNextForm(form, new View.Forms.BaseQuestionForm(user, course, test, question));
            }
        }
        #endregion
        

        /*internal static void UpdateContentOfTableJournal(DataGridView table, List<Course> courses, Course course)
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
        }*/
        /*
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
