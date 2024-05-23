using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.ViewHelper;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data;
using UniversityEnvironment.Data.Enums;
using MaterialSkin.Controls;
using UniversityEnvironment.View.Forms;
using UniversityEnvironment.View.Forms.AdminForms;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.View.Enums;

namespace UniversityEnvironment.View.Utility
{
    internal class AdminViewHelper
    {
        internal static void ShowNextFormUpdateTestTable
            (MaterialForm current, MaterialForm next, DataGridView table, Course course)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.FormClosed += (s, arg) => UpdateTestsTable(table, course);
            next.Show();
        }
        internal static void ShowNextFormUpdateCourseTable(MaterialForm current, MaterialForm next, DataGridView table)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.FormClosed += (s, arg) => AvailableCoursesTableUpdate(table, FindAll<Course>().ToList());
            next.Show();
        }

        internal static void GenericClickOnUsers<T>
            (User? user, string? username, VoidOperation operation,MaterialForm thisForm, Func<User, MaterialForm> createForm)
            where T : User
        {
            user = SetUserRole<T>(username);
            ArgumentNullException.ThrowIfNull(user);
            ShowNextForm(thisForm, createForm(user), operation);
        }


        internal static void UpdateRequestsTable<T>(DataGridView table, IEnumerable<T> users) where T : User
        {
            ArgumentNullException.ThrowIfNull(users);
            table.Rows.Clear();

            foreach (var user in users)
            {
                if (!user.Confirmed) table.Rows.Add(user.Username, user.Role, "Confirm account");
                else if (user.ForgetPassword && !user.CanChangePassword) table.Rows.Add(user.Username, user.Role, "Forget password");
            }
        }

        internal static void UpdateUsersTable<T>(DataGridView table, IEnumerable<T> users) where T : User
        {
            ArgumentNullException.ThrowIfNull(users);
            table.Rows.Clear();

            foreach (var user in users)
            {
                if (user.Confirmed) table.Rows.Add(user.Username, user.FirstName + " " + user.LastName, user.Role);
            }
        }
        internal static List<Admin> AdminsRequest(int currentPage,UniversityEnvironmentContext context)
        {
            return context.Admins
                .AsNoTracking()
                .Where(admin => admin.ForgetPassword == true || admin.Confirmed == false)
                .Skip(currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .OrderBy(admin => admin.Username)
                .Select(admin => new Admin
                {
                    Username = admin.Username,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Password = admin.Password,
                    Confirmed = admin.Confirmed,
                    ForgetPassword = admin.ForgetPassword,
                    CanChangePassword = admin.CanChangePassword
                })
                .ToList();
        }
        internal static List<Teacher> TeachersRequest(int currentPage, UniversityEnvironmentContext context)
        {
            return context.Teachers
                .AsNoTracking()
                .Where(teacher => teacher.ForgetPassword == true || teacher.Confirmed == false)
                .Skip(currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .OrderBy(teacher => teacher.Username)
                .Select(teacher => new Teacher
                {
                    Username = teacher.Username,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Password = teacher.Password,
                    ScienceDegree = teacher.ScienceDegree,
                    Confirmed = teacher.Confirmed,
                    ForgetPassword = teacher.ForgetPassword,
                    CanChangePassword = teacher.CanChangePassword
                })
                .ToList();
        }
        internal static List<Student> StudentsRequest(int currentPage, UniversityEnvironmentContext context)
        {
            return context.Students
                .AsNoTracking()
                .Where(student => student.ForgetPassword == true)
                .Skip(currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .OrderBy(student => student.Username)
                .Select(student => new Student
                {
                    Username = student.Username,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Password = student.Password,
                    Confirmed = student.Confirmed,
                    ForgetPassword = student.ForgetPassword,
                    CanChangePassword = student.CanChangePassword
                })
                .ToList();
        }
        internal static List<Admin> AdminsUsersRequest
            (int currentPage, UniversityEnvironmentContext context,bool? flag = null, string? text = null)
        {
            IQueryable<Admin> query = context.Admins;

            if (flag == true && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query
                .AsNoTracking()
                .OrderBy(admin => admin.Username)
                .Skip(currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .Select(admin => new Admin
                {
                    Username = admin.Username,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Password = admin.Password,
                    Confirmed = admin.Confirmed,
                    ForgetPassword = admin.ForgetPassword,
                    CanChangePassword = admin.CanChangePassword
                })
                .ToList();
        }
        internal static List<Teacher> TeachersUsersRequest
            (int currentPage, UniversityEnvironmentContext context,bool? flag = null, string? text = null)
        {
            IQueryable<Teacher> query = context.Teachers;

            if (flag == true && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query
                .AsNoTracking()
                .OrderBy(teacher => teacher.Username)
                .Skip(currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .Select(teacher => new Teacher
                {
                    Username = teacher.Username,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Password = teacher.Password,
                    ScienceDegree = teacher.ScienceDegree,
                    Confirmed = teacher.Confirmed,
                    ForgetPassword = teacher.ForgetPassword,
                    CanChangePassword = teacher.CanChangePassword
                })
                .ToList();
        }
        internal static List<Student> StudentsUsersRequest
            (int currentPage, UniversityEnvironmentContext context, bool? flag = null, string? text = null)
        {
            IQueryable<Student> query = context.Students;

            if (flag == true && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query
                .AsNoTracking()
                .OrderBy(s => s.Username)
                .Skip(currentPage * Constants.RowsPerPage)
                .Take(Constants.RowsPerPage)
                .Select(student => new Student
                {
                    Username = student.Username,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Password = student.Password,
                    Confirmed = student.Confirmed,
                    ForgetPassword = student.ForgetPassword,
                    CanChangePassword = student.CanChangePassword
                })
                .ToList();
        }
        internal static void DeleteOperation<T, Q>(DataGridView table, User user, CourseOperation @op) where T : CourseUser, new() where Q : User
        {
           /* List<Course> courses = FindAll<Course>().ToList();
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
            var count = Remove<T>(userCourses);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted courses!", "Environment", MessageBoxButtons.OK);*/
        }
        internal static void CreateQuestion<T>
            (Test test, GenericOperationWithTable<T> operation, DataGridView table, T obj)
        {
            string? question = Microsoft.VisualBasic.Interaction.InputBox("Enter question:", "Entering text", "");
            if (question == null || question == "") return;
            TestQuestion testQuestion = new()
            {
                QuestionText = question,
                TestId = test.Id
            };
            Create<TestQuestion>(testQuestion);
            operation(table,obj);
        }
        internal static void CreateAnswer<T>
            (TestQuestion testQuestion, GenericOperationWithTable<T> operation, DataGridView table, T obj)
        {
            string? answer = Microsoft.VisualBasic.Interaction.InputBox("Enter answer:", "Entering text", "");
            if (answer == null || answer == "") return;
            QuestionAnswer questionAnswer = new()
            {
                AnswerText = answer,
                TestQuestionId = testQuestion.Id
            };
            Create<QuestionAnswer>(questionAnswer);
            operation(table, obj);
        }
    }
}
