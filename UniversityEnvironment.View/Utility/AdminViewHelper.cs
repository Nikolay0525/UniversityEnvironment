using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using UniversityEnvironment.Data;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Utility
{
    internal class AdminViewHelper
    {

        internal static readonly int RowsPerPage = 10;

        public static void NextPage(Role role, ref int currentPage,
        VoidOperation? adminOperation = null, Action? teacherOperation = null, VoidOperation? studentOperation = null)
        {
            currentPage++;
            ExecuteRoleOperation(role, adminOperation, teacherOperation, studentOperation);
        }

        public static void PreviousPage(Role role, ref int currentPage,
            VoidOperation? adminOperation = null, Action? teacherOperation = null, VoidOperation? studentOperation = null)
        {
            currentPage = currentPage > 0 ? currentPage - 1 : currentPage;
            ExecuteRoleOperation(role, adminOperation, teacherOperation, studentOperation);
        }

        private static void ExecuteRoleOperation(Role role,
            VoidOperation? adminOperation = null, Action? teacherOperation = null, VoidOperation? studentOperation = null)
        {
            switch (role)
            {
                case Role.Admin:
                    adminOperation?.Invoke();
                    break;
                case Role.Teacher:
                    teacherOperation?.Invoke();
                    break;
                case Role.Student:
                    studentOperation?.Invoke();
                    break;
            }
        }

        internal static void ShowNextFormUpdateTable<T>
            (MaterialForm current, MaterialForm next, DataGridView table, T obj, Action<DataGridView, T> updateAction)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.FormClosed += (s, arg) => updateAction(table, obj);
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
        internal static List<Admin> AdminsRequest(int currentPage,UniversityEnvironmentContext context) // make one request with
            // expression in params to change cond. dynamicly, then i don't need Sciencedegree at all so it make sense to 
            // make request where selected only fields of User model
        {
            return context.Admins
                .AsNoTracking()
                .Where(admin => admin.ForgetPassword == true || admin.Confirmed == false)
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
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
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
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
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
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
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
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
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
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
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
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

        #region Creation,Removing
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

        internal static void DeleteAnswer(Guid testQuestionId, DataGridView? answerTable, bool deleteAll = false)
        {
            List<QuestionAnswer> answers = new();
            if (deleteAll)
            {
                List<QuestionAnswer> allAnswers = FindAll<QuestionAnswer>().ToList();
                answers.AddRange(allAnswers.Where(answer => answer.TestQuestionId == testQuestionId));
                Remove<QuestionAnswer>(null,answers);
                return;
            }
            if (answerTable == null) return;
            for (int i = 0; i < answerTable.RowCount; i++)
            {
                var id = answerTable.Rows[i].Cells[0].Value;
                var check = answerTable.Rows[i].Cells[1].Value;
                var description = answerTable.Rows[i].Cells[2].Value;
                if (id != null && Guid.TryParse(id.ToString(), out Guid parsedId) &&
                    check != null && bool.TryParse(check.ToString(), out bool checkParsed) && checkParsed)
                {
                    answers.Add(new() { Id = parsedId, AnswerText = description.ToString(), TestQuestionId = testQuestionId });
                }
            }
            var count = Remove<QuestionAnswer>(null,answers);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted answers!", "Test", MessageBoxButtons.OK);
        }
        internal static void DeleteQuestion(Guid testId, DataGridView? questionTable,  bool deleteAll = false)
        {
            List<TestQuestion> questions = new();
            if (deleteAll)
            {
                List<TestQuestion> allQuestions = FindAll<TestQuestion>().ToList();
                questions.AddRange(allQuestions.Where(question => question.TestId == testId));
                foreach(var question in questions)
                {
                    DeleteAnswer(question.Id, null, true);
                }
                Remove<TestQuestion>(null, questions);
                return;
            }
            if (questionTable == null) return;
            for (int i = 0; i < questionTable.RowCount; i++)
            {
                var id = questionTable.Rows[i].Cells[0].Value;
                var manyQuestion = questionTable.Rows[i].Cells[1].Value;
                var check = questionTable.Rows[i].Cells[2].Value;
                var text = questionTable.Rows[i].Cells[3].Value;
                if (id != null && Guid.TryParse(id.ToString(), out Guid parsedId) &&
                    check != null && bool.TryParse(check.ToString(), out bool checkParsed) && checkParsed &&
                    manyQuestion != null && bool.TryParse(manyQuestion.ToString(), out bool manyQuestionParsed))
                {
                    questions.Add(new() { Id = parsedId, ManyAnswers = manyQuestionParsed, QuestionText = text.ToString(), TestId = testId });
                    DeleteAnswer(parsedId, questionTable, deleteAll = true);
                }
            }
            var count = Remove<TestQuestion>(null, questions);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted questions!", "Test", MessageBoxButtons.OK);
        }
        internal static void DeleteTest(Guid courseId, DataGridView? testTable,  bool deleteAll = false)
        {
            List<Test> tests = new();
            if (deleteAll)
            {
                List<Test> allTests = FindAll<Test>().ToList();
                tests.AddRange(allTests.Where(test => test.CourseId == courseId));
                foreach (var test in tests)
                {
                    DeleteQuestion(test.Id, null, true);
                }
                Remove<Test>(null, tests);
                return;
            }
            if (testTable == null) return; 
            for (int i = 0; i < testTable.RowCount; i++)
            {
                var id = testTable.Rows[i].Cells[0].Value;
                var check = testTable.Rows[i].Cells[1].Value;
                var name = testTable.Rows[i].Cells[2].Value;
                var description = testTable.Rows[i].Cells[3].Value;
                if (id != null && Guid.TryParse(id.ToString(), out Guid parsedId) &&
                    check != null && bool.TryParse(check.ToString(), out bool checkParsed) && checkParsed)
                {
                    tests.Add(new()
                    {
                        Id = parsedId,
                        Name = name.ToString(),
                        Description = description.ToString(),
                        CourseId = courseId
                    });
                    DeleteQuestion(parsedId, null, true);
                }
            }
            var count = Remove<Test>(null, tests);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted tests!", "Course", MessageBoxButtons.OK);
        }
        internal static void DeleteCourse(DataGridView courseTable)
        {
            List<Course> courses = new();
            for (int i = 0; i < courseTable.RowCount; i++)
            {
                var id = courseTable.Rows[i].Cells[0].Value;
                var check = courseTable.Rows[i].Cells[1].Value;
                var name = courseTable.Rows[i].Cells[2].Value;
                var faculty = courseTable.Rows[i].Cells[3].Value;
                if (id != null && Guid.TryParse(id.ToString(), out Guid parsedId) &&
                    check != null && bool.TryParse(check.ToString(), out bool checkParsed) && checkParsed)
                {
                    courses.Add(new()
                    {
                        Id = parsedId,
                        Name = name.ToString(),
                        FacultyName = faculty.ToString(),
                    });
                    DeleteTest(parsedId, null ,true);
                }
            }
            var count = Remove<Course>(null, courses);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted courses!", "Admin Panel", MessageBoxButtons.OK);
        }
        internal static void FindAndRemove<T>(MaterialForm currentForm, Guid id) where T : User
        {
            List<T> users = FindAll<T>().ToList();
            T? user = users.FirstOrDefault(a => a.Id == id);
            if (user != null) Remove<T>(user);
            currentForm.Close();
        }
        #endregion
    }
}
