using MaterialSkin.Controls;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Enums;
using UniversityEnvironment.View.Forms.CommonForms;
using static UniversityEnvironment.Data.Service.MySqlService;
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
                var rowCheck = table.Rows[i].Cells[0].Value;
                if (rowCheck != null && bool.TryParse(rowCheck.ToString(), out bool parsed) && parsed)
                {
                    userCourses.Add(new() { UserId = user.Id, CourseId = courses[i].Id });
                }
            }
            if (@op == 0)
            {
                var count = Create<T>(null,userCourses);
                if (count == 0) return;
                MessageBox.Show("Successfully signed on courses!", "Environment", MessageBoxButtons.OK);
            }
            else
            {
                var count = Remove<T>(null,userCourses);
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
            foreach (var test in tests) { table.Rows.Add(test.Id,false, test.Name, test.Description); }

        }
        internal static void UpdateQuestionTable(DataGridView table, Test test)
        {
            var questions = FindAll<TestQuestion>(q => q.TestId == test.Id);
            if (questions == null) return;
            table.Rows.Clear();
            foreach (var question in questions) { table.Rows.Add(question.Id,question.ManyAnswers ,false, question.QuestionText); }

        }
        internal static void UpdateAnswerTable(DataGridView table, TestQuestion testQuestion)
        {
            var answers = FindAll<QuestionAnswer>(a => a.TestQuestionId == testQuestion.Id);
            if (answers == null) return;
            table.Rows.Clear();
            foreach (var answer in answers) { table.Rows.Add(answer.Id,false, answer.AnswerText); }

        }
        internal static void UpdateNotificationTable(DataGridView table, User user)
        {
            var messages = FindAll<StudentMessage>(m => m.StudentId == user.Id);
            if (messages == null) return;
            table.Rows.Clear();
            foreach (var message in messages) { table.Rows.Add(message.Id,message.Initials, message.CourseName, message.MessageText); }
        }
        #endregion
        #region ClickOnMethods
        internal static void ClickOnNotification
            (DataGridView notificationTable, DataGridViewCellEventArgs e, User user)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = notificationTable.Rows[e.RowIndex];
                var selectedMessageId = selectedRow.Cells["IdColumn"].Value;
                if (selectedMessageId != null && Guid.TryParse(selectedMessageId.ToString(), out Guid parsedId))
                {
                    if (MessageBox.Show("Want to delete message?", "Environment", MessageBoxButtons.OKCancel)
                        == DialogResult.Cancel) return;
                    Remove<StudentMessage>(FindByFilter<StudentMessage>(sm => sm.Id == parsedId));
                    UpdateNotificationTable(notificationTable, user);
                }
            }
        }
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
                ShowNextForm(form, new CourseForm(user, course));
            }
        }
        
        internal static void ClickOnTest
            (int columnIndex,MaterialForm form,DataGridView table, DataGridViewCellEventArgs e, User user)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                string? selectedTest = selectedRow.Cells["IdColumn"].Value.ToString();
                Test? test = null;
                if (selectedTest != null && Guid.TryParse(selectedTest, out Guid parsedId))
                {
                    test = FindByFilter<Test>(t => t.Id == parsedId);
                }
                if (test == null) return;
                ShowNextForm(form, new TestForm(user, test));
            }
        }
        internal static void ClickOnQuestion
            (int columnIndex,TestForm currentTestForm, DataGridView table,DataGridViewCellEventArgs e, User user)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                var selectedQuestion = selectedRow.Cells["IdColumn"].Value.ToString();
                TestQuestion? question = null;
                if(selectedQuestion != null && Guid.TryParse(selectedQuestion, out Guid parsedId))
                {
                    question = FindByFilter<TestQuestion>(q => q.Id == parsedId);
                }
                if (question == null) return;
                ShowNextForm(currentTestForm, new QuestionForm(currentTestForm, user, question));
            }
        }
        internal static void AnswerOnQuestion
            (TestForm currentTestForm, QuestionForm currentForm, bool manyQuestion,DataGridView table,
            Guid testQuestionId, User user, DataGridViewCellEventArgs? e = null)
        {
            int columnIndex = (manyQuestion || user.Role == Role.Admin) ? 1 : 0;
            var studentAnswers = new List<QuestionAnswerStudent>();
            if (manyQuestion)
            {
                List<QuestionAnswerStudent> allStudentAnswers = FindAll<QuestionAnswerStudent>().ToList();
                for (int i = 0; i < allStudentAnswers.Count; i++)
                {
                    var answerId = table.Rows[i].Cells[0].Value;
                    var rowCheck = table.Rows[i].Cells[1].Value;

                    if (rowCheck != null && bool.TryParse(rowCheck.ToString(), out bool parsed) && parsed
                        && answerId != null && Guid.TryParse(answerId.ToString(), out Guid parsedId))
                    {
                        studentAnswers.Add(new() { StudentId = user.Id, QuestionAnswerId = parsedId });
                    }
                }
                currentTestForm.AddAnswer(null, studentAnswers);
                currentForm.Close();
            }
            else if(e != null && e.RowIndex! >= 0 && e.ColumnIndex! >= columnIndex)
            {
                if (MessageBox.Show("Are you sure in you're answer?", "Test", MessageBoxButtons.OKCancel) 
                    == DialogResult.Cancel) return;
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                var selectedAnswerId = selectedRow.Cells["IdColumn"].Value;
                QuestionAnswerStudent? answer = null;
                if (selectedAnswerId != null && Guid.TryParse(selectedAnswerId.ToString(), out Guid parsedId))
                {
                    answer = new() { StudentId = user.Id, QuestionAnswerId = parsedId };
                }
                if (answer != null) currentTestForm.AddAnswer(answer);
                currentForm.Close();
            }
        }
        #endregion


        internal static void UpdateJournalTable(DataGridView journalTable, Course course)
        {
            journalTable.Columns.Clear();
            journalTable.Rows.Clear();

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "IdColumn";
            idColumn.HeaderText = "Id";
            idColumn.Visible = false;
            journalTable.Columns.Add(idColumn);
            journalTable.Columns.Add("StudentName", "Student");
            List<Test> tests = FindAll<Test>(t => t.CourseId == course.Id).ToList();
            List<TestStudent> testStudents = new();
            foreach (var test in tests)
            {
                DataGridViewTextBoxColumn testColumn = new DataGridViewTextBoxColumn();
                testColumn.HeaderText = test.Name;
                testColumn.Name = test.Name;
                journalTable.Columns.Add(testColumn);
                testStudents.AddRange(FindAll<TestStudent>(ts => ts.TestId == test.Id));
            }
            if (testStudents == null) return;

            Dictionary<Guid, DataGridViewRow> studentRows = new();

            foreach (var testStudent in testStudents)
            {
                Student? foundedStudent = FindByFilter<Student>(s => s.Id == testStudent.StudentId);
                Test? foundedTest = FindByFilter<Test>(t => t.Id == testStudent.TestId);
                if (foundedStudent == null || foundedTest == null) continue;
                if (!studentRows.TryGetValue(foundedStudent.Id, out var existingRow))
                {
                    existingRow = new DataGridViewRow();
                    existingRow.CreateCells(journalTable);
                    existingRow.Cells[journalTable.Columns["IdColumn"].Index].Value = foundedStudent.Id.ToString();
                    existingRow.Cells[journalTable.Columns["StudentName"].Index].Value 
                        = foundedStudent.FirstName + " " + foundedStudent.LastName;
                    journalTable.Rows.Add(existingRow);
                    studentRows[foundedStudent.Id] = existingRow;
                }
                existingRow.Cells[journalTable.Columns[foundedTest.Name].Index].Value = testStudent.Mark;
            }
        }
        internal static void ApplyChangesToDBJournal(DataGridView journalTable, Course course)
        {
            List<Test> tests = FindAll<Test>(t => t.CourseId == course.Id).ToList();
            List<TestStudent> testStudents = new();
            tests.ForEach(t => testStudents.AddRange(FindAll<TestStudent>(ts => ts.TestId == t.Id)));

            foreach (DataGridViewRow row in journalTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    foreach (var testStudent in testStudents)
                    {
                        Student? foundedStudent = FindByFilter<Student>(s => s.Id == testStudent.StudentId);
                        Test? foundedTest = FindByFilter<Test>(t => t.Id == testStudent.TestId);
                        if (foundedTest != null && foundedStudent != null && foundedTest.Name == cell.OwningColumn.Name)
                        {
                            var idCell = row.Cells["IdColumn"].Value;
                            if (idCell != null && Guid.TryParse(idCell.ToString(), out Guid parsedId))
                            {
                                if (parsedId != foundedStudent.Id) continue;
                                if (int.TryParse(cell.Value.ToString(), out int mark))
                                {
                                    testStudent.Mark = mark;
                                }
                            }
                        }
                    }
                }
            }
            Update<TestStudent>(null, testStudents);
        }
        internal static void ClickOnJournal
            (MaterialForm currentForm, DataGridView journalTable, DataGridViewCellEventArgs e, Course course, User user)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = journalTable.Rows[e.RowIndex];
                var selectedStudentId = selectedRow.Cells["IdColumn"].Value.ToString();
                Student? student = null;
                if (selectedStudentId != null && Guid.TryParse(selectedStudentId, out Guid parsedId))
                {
                    student = FindByFilter<Student>(s => s.Id == parsedId);
                }
                if (student == null) return;
                ShowNextForm(currentForm, new UserForm(student, course, user));
            }
        }

        private static void FillCourseGeneric<T>(List<Course> allCourses,ListBox coursesList, User user) 
            where T : CourseUser
        {
            var allCoursesOfUser = FindAll<T>(ct => ct.UserId == user.Id).ToList();

            foreach (var courseTeacher in allCoursesOfUser)
            {
                var course = allCourses.Find(c => c.Id == courseTeacher.CourseId);
                if (course != null && course.Name != null)
                {
                    coursesList.Items.Add(course.Name);
                }
            }
        }

        internal static void FillCourseList(ListBox coursesList, User user)
        {
            var allCourses = FindAll<Course>().ToList();
            if (user.Role == Role.Admin)
            {
                coursesList.Visible = false;
            }
            else if (user.Role == Role.Teacher)
            {
                FillCourseGeneric<CourseTeacher>(allCourses, coursesList, user);
            }
            else
            {
                FillCourseGeneric<CourseStudent>(allCourses, coursesList, user);
            }
        }

        internal static void DeductStudentFromCourse(UserForm currentForm,Course course,User teacher, User student)
        {
            List<TestStudent> thisStudentCompletedTests = new();
            List<QuestionAnswerStudent> thisStudentAnswers = new();
            var tests = FindAll<Test>(t => t.CourseId == course.Id);
            
            foreach(var test in tests)
            {
                var testStudent = FindByFilter<TestStudent>(ts => ts.TestId == test.Id && ts.StudentId == student.Id);
                if (testStudent == null) continue;
                thisStudentCompletedTests.Add(testStudent);
            }

            if(thisStudentCompletedTests.Any(t => t.Mark < 3))
            {
                foreach (var test in tests)
                {
                    foreach (var question in FindAll<TestQuestion>(q => q.TestId == test.Id))
                    {
                        foreach (var answer in FindAll<QuestionAnswer>(a => a.TestQuestionId == question.Id))
                        {
                            thisStudentAnswers.Add(new() { QuestionAnswerId = answer.Id, StudentId = student.Id });
                        }
                    }
                }

                Remove<QuestionAnswerStudent>(null, thisStudentAnswers);
                Remove<TestStudent>(null, thisStudentCompletedTests);
                Remove<CourseStudent>(FindByFilter<CourseStudent>(cs => cs.UserId == student.Id && cs.CourseId == course.Id));
                Create<StudentMessage>(new()
                {
                    Initials = teacher.FirstName + " " + teacher.LastName,
                    MessageText = Microsoft.VisualBasic.Interaction.InputBox("Enter message-reason to student:", "Course", ""),
                    CourseName = course.Name,
                    StudentId = student.Id
                });
                MessageBox.Show("Student was deducted succesfully.");
                currentForm.Close();
                return;
            }
            MessageBox.Show("You cannot deduct this student, because he doesn't have marks below 3");
            return;
        }
    }
}
