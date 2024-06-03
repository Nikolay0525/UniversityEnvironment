using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using UniversityEnvironment.Data;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;
using static UniversityEnvironment.View.Validators.ViewValidators;

namespace UniversityEnvironment.View.Utility
{
    internal class AdminViewHelper
    {

        internal static readonly int RowsPerPage = 10;

        public static void NextPage(Role role, ref int currentPage,
        Action? adminOperation = null, Action? teacherOperation = null, Action? studentOperation = null)
        {
            currentPage++;
            ExecuteRoleOperation(role, adminOperation, teacherOperation, studentOperation);
        }

        public static void PreviousPage(Role role, ref int currentPage,
            Action? adminOperation = null, Action? teacherOperation = null, Action? studentOperation = null)
        {
            currentPage = currentPage > 0 ? currentPage - 1 : currentPage;
            ExecuteRoleOperation(role, adminOperation, teacherOperation, studentOperation);
        }

        private static void ExecuteRoleOperation(Role role,
            Action? adminOperation = null, Action? teacherOperation = null, Action? studentOperation = null)
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
            (MaterialForm current, MaterialForm next, DataGridView table, T obj, User user, Action<DataGridView, T, User> updateAction)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.FormClosed += (s, arg) => updateAction(table, obj, user);
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
            (User? user, string? username, Action operation,MaterialForm thisForm, Func<User, MaterialForm> createForm)
            where T : User
        {
            user = SetUserRole<T>(username);
            if (ValidateNull(user, "user")) return;
            ShowNextForm(thisForm, createForm(user!), operation);
        }

        internal static void UpdateRequestsTable<T>(DataGridView table, IEnumerable<T> users) where T : User
        {
            if (ValidateNull(users, "users")) return;
            table.Rows.Clear();

            foreach (var user in users)
            {
                if (!user.Confirmed) table.Rows.Add(user.Username, user.Role, "Confirm account");
                else if (user.ForgetPassword && !user.CanChangePassword) table.Rows.Add(user.Username, user.Role, "Forget password");
            }
        }

        internal static void UpdateUsersTable<T>(DataGridView table, IEnumerable<T> users) where T : User
        {
            if (ValidateNull(users, "users")) return;
            table.Rows.Clear();

            foreach (var user in users)
            {
                if (user.Confirmed) table.Rows.Add(user.Username, user.FirstName + " " + user.LastName, user.Role);
            }
        }
        internal static List<T> RequestsQuery<T>(int currentPage, UniversityEnvironmentContext context) where T : User, new()
        {
            return context.Set<T>()
                .AsNoTracking()
                .Where(user => user.ForgetPassword == true || user.Confirmed == false)
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
                .OrderBy(user => user.Username)
                .Select(user => new T
                {
                    Id = user.Id,
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    Role = user.Role,
                    Confirmed = user.Confirmed,
                    ForgetPassword = user.ForgetPassword,
                    CanChangePassword = user.CanChangePassword
                })
                .ToList();
        }
        
        internal static List<T> UsersQuery<T>
            (int currentPage, UniversityEnvironmentContext context, bool? flag = null, string? text = null) where T : User, new()
        {
            IQueryable<T> query = context.Set<T>(); // Getting all instances of type T in context

            if (flag == true && text != null) // Сhecking if the filter is needed
            {
                query = query.Where(t => EF.Functions.Like(t.Username, $"%{text}%"));
            }
            else if (flag == false && text != null)
            {
                query = query.Where(t => EF.Functions.Like(t.FirstName + t.LastName, $"%{text}%"));
            }

            return query // Returning the list of instances.
                .AsNoTracking()
                .OrderBy(u => u.Username)
                .Skip(currentPage * RowsPerPage)
                .Take(RowsPerPage)
                .Select(user => new T
                {
                    Id = user.Id,
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    Role = user.Role,
                    Confirmed = user.Confirmed,
                    ForgetPassword = user.ForgetPassword,
                    CanChangePassword = user.CanChangePassword,
                })
                .ToList();
        }

        #region Creation,Removing
        internal static void CreateAnswer<T>
            (TestQuestion testQuestion, Action<DataGridView, T> operation, DataGridView table, T obj)
        {
            string? answer = Microsoft.VisualBasic.Interaction.InputBox("Enter answer:", "Answer creator", "");
            if (ValidateNull(answer, "answer") || answer == "" || ValidateStringOnLength("answer", answer, 1, 50)) return;
            QuestionAnswer questionAnswer = new()
            {
                AnswerText = answer,
                TestQuestionId = testQuestion.Id
            };
            Create(questionAnswer);
            operation(table, obj);
        }

        internal static void DeleteAnswer(Guid testQuestionId, DataGridView? answerTable, bool deleteAll = false)
        {
            List<QuestionAnswer> answers = new();
            if (deleteAll)
            {
                List<QuestionAnswer> allAnswers = FindAll<QuestionAnswer>().ToList();
                answers.AddRange(allAnswers.Where(answer => answer.TestQuestionId == testQuestionId));
                Remove(null,answers);
                return;
            }
            if (answerTable == null) return;
            for (int i = 0; i < answerTable.RowCount; i++)
            {
                var id = answerTable.Rows[i].Cells[0].Value.ToString();
                var check = answerTable.Rows[i].Cells[1].Value.ToString();
                var description = answerTable.Rows[i].Cells[2].Value.ToString();
                if (ValidateNull(id, "id") || ValidateNull(check, "check") ||
                    ValidateNull(description, "description")) return;
                if (Guid.TryParse(id, out Guid parsedId) &&
                    bool.TryParse(check, out bool checkParsed) && checkParsed)
                {
                    answers.Add(new() { Id = parsedId, AnswerText = description, TestQuestionId = testQuestionId });
                }
            }
            var count = Remove(null,answers);
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
                Remove(null, questions);
                return;
            }
            if (questionTable == null) return;
            for (int i = 0; i < questionTable.RowCount; i++)
            {
                var id = questionTable.Rows[i].Cells[0].Value.ToString();
                var manyQuestion = questionTable.Rows[i].Cells[1].Value.ToString();
                var check = questionTable.Rows[i].Cells[2].Value.ToString();
                var text = questionTable.Rows[i].Cells[3].Value.ToString();
                if (ValidateNull(id, "id") || ValidateNull(check, "check") ||
                    ValidateNull(check, "check") || ValidateNull(text, "text")) return;
                if (Guid.TryParse(id, out Guid parsedId) &&
                    bool.TryParse(check, out bool checkParsed) && checkParsed &&
                    bool.TryParse(manyQuestion, out bool manyQuestionParsed))
                {
                    questions.Add(new() { Id = parsedId, ManyAnswers = manyQuestionParsed, QuestionText = text, TestId = testId });
                    DeleteAnswer(parsedId, questionTable, deleteAll = true);
                }
            }
            var count = Remove(null, questions);
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
                Remove(null, tests);
                return;
            }
            if (testTable == null) return; 
            for (int i = 0; i < testTable.RowCount; i++)
            {
                var id = testTable.Rows[i].Cells[0].Value.ToString();
                var check = testTable.Rows[i].Cells[1].Value.ToString();
                var name = testTable.Rows[i].Cells[2].Value.ToString();
                var description = testTable.Rows[i].Cells[3].Value.ToString();
                if (ValidateNull(id, "id") || ValidateNull(check, "check") ||
                    ValidateNull(name, "name") || ValidateNull(description, "description")) return;
                if (Guid.TryParse(id, out Guid parsedId) &&
                    bool.TryParse(check, out bool checkParsed) && checkParsed)
                {
                    tests.Add(new()
                    {
                        Id = parsedId,
                        Name = name,
                        Description = description,
                        CourseId = courseId
                    });
                    DeleteQuestion(parsedId, null, true);
                }
            }
            var count = Remove(null, tests);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted tests!", "Course", MessageBoxButtons.OK);
        }
        internal static void DeleteCourse(DataGridView courseTable)
        {
            List<Course> courses = new();
            for (int i = 0; i < courseTable.RowCount; i++)
            {
                var id = courseTable.Rows[i].Cells[0].Value.ToString();
                var check = courseTable.Rows[i].Cells[1].Value.ToString();
                var name = courseTable.Rows[i].Cells[2].Value.ToString();
                var faculty = courseTable.Rows[i].Cells[3].Value.ToString();
                if (ValidateNull(id, "id") || ValidateNull(check, "check") ||
                    ValidateNull(name, "courseName") || ValidateNull(faculty, "facultyName")) return;
                if (Guid.TryParse(id, out Guid parsedId) &&
                    bool.TryParse(check, out bool checkParsed) && checkParsed)
                {
                    courses.Add(new()
                    {
                        Id = parsedId,
                        Name = name,
                        FacultyName = faculty,
                    });
                    DeleteTest(parsedId, null ,true);
                }
            }
            var count = Remove(null, courses);
            if (count == 0) return;
            MessageBox.Show("Successfully deleted courses!", "Admin Control", MessageBoxButtons.OK);
        }
        internal static void FindAndRemove<T>(MaterialForm currentForm, Guid id) where T : User
        {
            List<T> users = FindAll<T>().ToList();
            T? user = users.FirstOrDefault(a => a.Id == id);
            if (ValidateNull(user, "user")) return;
            Remove(user);
            currentForm.Close();
        }
        #endregion

        #region RequestForm
        internal static void GenericAccept<T>(Action<T> action, AdminRequestForm thisForm, User user) where T : User
        {
            var foundedUser = FindByFilter<T>(a => user.Username == a.Username);
            if (ValidateNull(foundedUser, "foundedUser")) return;
            action.Invoke(foundedUser!);
            Update(foundedUser);
            thisForm.Close();
        }
        internal static void GenericDecline<T>
            (AdminRequestForm thisForm, User user, Func<T?, IEnumerable<T>?, int>? func = null, Action<T>? action = null, Func<T?, IEnumerable<T>?, T?>? op = null)
            where T : User
        {
            var foundedUser = FindByFilter<T>(a => user.Username == a.Username);
            if (ValidateNull(foundedUser, "foundedUser")) return;
            func?.Invoke(foundedUser, null);
            action?.Invoke(foundedUser!);
            op?.Invoke(foundedUser, null);
            thisForm.Close();
        }
        #endregion
    }
}
