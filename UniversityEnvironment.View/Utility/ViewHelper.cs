using MaterialSkin.Controls;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Enums;
using UniversityEnvironment.View.Forms.CommonForms;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Validators.ViewValidators;
//using Microsoft.VisualBasic.ApplicationServices;

namespace UniversityEnvironment.View.Utility
{
    internal static class ViewHelper
    {

        #region Form event operations
        internal static void ShowNextForm(MaterialForm current, MaterialForm next)
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.Show();
        }
        internal static void ShowNextForm(MaterialForm current, MaterialForm next, Action operation)
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
            if (ValidateNull(courses, "available courses")) return;
            table.Rows.Clear();

            foreach (var course in courses)
            {
                table.Rows.Add(course.Id,false, course.Name, course.FacultyName);
            }
        }
        internal static void ActualCoursesTableAddRows(DataGridView table, IEnumerable<Course> courses)
        {
            if (ValidateNull(courses, "actual courses")) return;

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
            if (ValidateNull(courseList, "courses list")) return;
            ActualCoursesTableAddRows(table, courseList);
        }

        internal static void UserCourseOperation<T, Q>(DataGridView table, User user, CourseOperation @op) where T : CourseUser, new() where Q : User
        {
            List<Course> courses = FindAll<Course>().ToList();
            var userCourses = new List<T>();
            var foundedUser = FindByFilter<Q>(u => u.Id == user.Id);
            if (ValidateNull(foundedUser, "foundedUser")) return;
            for (int i = 0; i < courses.Count; i++)
            {
                var rowCheck = table.Rows[i].Cells[1].Value.ToString();
                if (ValidateNull(rowCheck, "rowCheck")) return;
                if (bool.TryParse(rowCheck, out bool parsed) && parsed)
                {
                    userCourses.Add(new() { UserId = user.Id, CourseId = courses[i].Id });
                }
            }
            if (@op == 0)
            {
                var count = Create(null,userCourses);
                if (count == 0) return;
                MessageBox.Show("Successfully signed on courses!", "Environment", MessageBoxButtons.OK);
            }
            else
            {
                var count = Remove(null,userCourses);
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
            teachers.ForEach(t => table.Rows.Add(t.Id,t.FirstName + " " + t.LastName));
        }
        internal static void UpdateTestsTable(DataGridView table, Course course, User user)
        {
            var tests = FindAll<Test>(t => t.CourseId == course.Id);
            if (ValidateNull(tests, "tests on course")) return;
            table.Rows.Clear();
            bool completed = false;
            foreach (var test in tests) 
            { 
                if(user.Role == Role.Student) completed = FindByFilter<TestStudent>
                        (ts => ts.TestId == test.Id && ts.StudentId == user.Id) != null ? true : false;
                table.Rows.Add(test.Id, completed, test.Name, test.Description);
            }

        }
        internal static void UpdateQuestionTable(DataGridView table, Test test, User user)
        {
            var questions = FindAll<TestQuestion>(q => q.TestId == test.Id);
            if (ValidateNull(questions, "questions on test")) return;
            table.Rows.Clear();
            foreach (var question in questions) { table.Rows.Add(question.Id,question.ManyAnswers ,false, question.QuestionText); }

        }
        internal static void UpdateAnswerTable(DataGridView table, TestQuestion testQuestion)
        {
            var answers = FindAll<QuestionAnswer>(a => a.TestQuestionId == testQuestion.Id);
            if (ValidateNull(answers, "answers on question")) return;
            table.Rows.Clear();
            foreach (var answer in answers) { table.Rows.Add(answer.Id,false, answer.AnswerText); }

        }
        internal static void UpdateNotificationTable(DataGridView table, User user)
        {
            var messages = FindAll<StudentMessage>(m => m.StudentId == user.Id);
            if (ValidateNull(messages, "message to student")) return;
            table.Rows.Clear();
            foreach (var message in messages) { table.Rows.Add(message.Id,message.Initials, message.CourseName, message.MessageText); }
        }
        internal static void UpdateStudentAnswersTable
            (int columnIndex, DataGridViewCellEventArgs e, 
            DataGridView answersTable,DataGridView studentAnswersTable)
        {
            if (e != null && e.RowIndex! >= 0 && e.ColumnIndex! >= columnIndex)
            {
                studentAnswersTable.Rows.Clear();
                DataGridViewRow selectedRow = answersTable.Rows[e.RowIndex];
                var selectedAnswerId = selectedRow.Cells["IdColumn"].Value.ToString();
                if (ValidateNull(selectedAnswerId, "selectedAnswerId")) return;
                if (Guid.TryParse(selectedAnswerId, out Guid parsedId))
                {
                    foreach(var studentAnswer in FindAll<QuestionAnswerStudent>(qas => qas.QuestionAnswerId == parsedId))
                    {
                        var foundedStudent = FindByFilter<Student>(s => s.Id == studentAnswer.StudentId);
                        if (foundedStudent != null) 
                            studentAnswersTable.Rows.Add(foundedStudent.FirstName + foundedStudent.LastName);
                    }
                }
            }
        }
        #endregion
        #region ClickOnMethods
        internal static void ClickOnNotification
            (DataGridView notificationTable, DataGridViewCellEventArgs e, User user)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = notificationTable.Rows[e.RowIndex];
                var selectedMessageId = selectedRow.Cells["IdColumn"].Value.ToString();
                if (ValidateNull(selectedMessageId, "selectedMessageId")) return;
                if (selectedMessageId != null && Guid.TryParse(selectedMessageId, out Guid parsedId))
                {
                    if (MessageBox.Show("Want to delete message?", "Environment", MessageBoxButtons.OKCancel)
                        == DialogResult.Cancel) return;
                    Remove(FindByFilter<StudentMessage>(sm => sm.Id == parsedId));
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
                if (ValidateNull(selectedCourse, "selectedCourse")) return;
                var course = FindByFilter<Course>(c => c.Name == selectedCourse);
                if (ValidateNull(course, "selectedCourse")) return;
                ShowNextForm(form, new CourseForm(user, course!));
            }
        }
        internal static void ClickOnTeacherTable
            (MaterialForm form,DataGridView table, DataGridViewCellEventArgs e, User realUser, Course course)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                string? selectedTeacherId = selectedRow.Cells["TeacherIdColumn"].Value.ToString();
                if (ValidateNull(selectedTeacherId, "selectedTeacherId")) return;
                if (Guid.TryParse(selectedTeacherId, out Guid parsedId))
                {
                    var teacher = FindByFilter<Teacher>(t => t.Id == parsedId);
                    if (ValidateNull(teacher, "teacher")) return;
                    ShowNextForm(form, new UserForm(teacher!,course, realUser));
                }
            }
        }
        
        internal static void ClickOnTest
            (int columnIndex,CourseForm thisForm,DataGridView table, DataGridViewCellEventArgs e, User user, Course course)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                var selectedTest = selectedRow.Cells["IdColumn"].Value.ToString();
                if (ValidateNull(selectedTest, "selectedTest")) return;
                Test? test = null;
                if (Guid.TryParse(selectedTest, out Guid parsedId))
                {
                    test = FindByFilter<Test>(t => t.Id == parsedId);
                }
                if (ValidateNull(test, "test")) return;
                ShowNextForm(thisForm, new TestForm(thisForm, user, course, test!));
            }
        }
        internal static Guid? ClickOnQuestion
            (int columnIndex,TestForm currentTestForm, DataGridView table,DataGridViewCellEventArgs e, User user, Test test)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= columnIndex)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                var selectedQuestion = selectedRow.Cells["IdColumn"].Value.ToString();
                if (ValidateNull(selectedQuestion, "selectedQuestionId")) return null;
                TestQuestion? question = null;
                if(Guid.TryParse(selectedQuestion, out Guid parsedId))
                {
                    question = FindByFilter<TestQuestion>(q => q.Id == parsedId);
                }
                if (ValidateNull(question, "question")) return null;
                ShowNextForm(currentTestForm, new QuestionForm(currentTestForm, user, test, question!));
                return question!.Id;
            }
            return null;
        }
        internal static void SetCheckedToQuestion(Guid testQuestionId,DataGridView questionTable)
        {
            foreach(DataGridViewRow row in questionTable.Rows)
            {
                var id = row.Cells["IdColumn"].Value.ToString();
                if (id == null) continue;
                if (id == "true") break;
                if (Guid.TryParse(id, out Guid parsedId))
                {
                    if (parsedId == testQuestionId) row.Cells["CheckColumn"].Value = true;
                }
            }
        }
        internal static void AnswerOnQuestion
            (TestForm currentTestForm, QuestionForm currentForm, bool manyQuestion,DataGridView answerTable, 
            DataGridView studentAnswerTable, Guid testQuestionId, User user, DataGridViewCellEventArgs? e = null)
        {
            int columnIndex = manyQuestion ? 1 : 0;
            if(e != null &&(user.Role == Role.Admin || user.Role == Role.Teacher))
            {
                UpdateStudentAnswersTable(columnIndex,e, answerTable ,studentAnswerTable);
                return;
            }
            List<QuestionAnswerStudent> studentAnswers = new();
            if (manyQuestion)
            {
                for (int i = 0; i < answerTable.Rows.Count; i++)
                {
                    var answerId = answerTable.Rows[i].Cells[0].Value.ToString();
                    var rowCheck = answerTable.Rows[i].Cells[1].Value.ToString();
                    if (ValidateNull(answerId, "answerId")) return;
                    if (ValidateNull(rowCheck, "rowCheck")) return;
                    if (bool.TryParse(rowCheck, out bool parsed) && parsed
                        && Guid.TryParse(answerId, out Guid parsedId))
                    {
                        studentAnswers.Add(new() { StudentId = user.Id, QuestionAnswerId = parsedId });
                    }
                }
                currentTestForm.AddAnswer(testQuestionId , studentAnswers);
                currentForm.Close();
            }
            else if(e != null && e.RowIndex! >= 0 && e.ColumnIndex! >= columnIndex)
            {
                if (MessageBox.Show("Are you sure in you're answer?", "Test", MessageBoxButtons.OKCancel) 
                    == DialogResult.Cancel) return;
                DataGridViewRow selectedRow = answerTable.Rows[e.RowIndex];
                var selectedAnswerId = selectedRow.Cells["IdColumn"].Value.ToString();
                if (selectedAnswerId != null && Guid.TryParse(selectedAnswerId, out Guid parsedId))
                {
                    studentAnswers.Add(new() { StudentId = user.Id, QuestionAnswerId = parsedId });
                }
                currentTestForm.AddAnswer(testQuestionId, studentAnswers);
                currentForm.Close();
            }
        }
        #endregion


        internal static void UpdateJournalTable(DataGridView journalTable, Course course)
        {
            journalTable.Columns.Clear();  // Cleaning all stuff from table
            journalTable.Rows.Clear();
            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn(); // Adding of two main columns 
            idColumn.Name = "IdColumn";
            idColumn.HeaderText = "Id";
            idColumn.Visible = false; // invisible column just to put in it Guid, and then get it from it
            journalTable.Columns.Add(idColumn);
            journalTable.Columns.Add("StudentName", "Student"); 
            List<Test> tests = FindAll<Test>(t => t.CourseId == course.Id).ToList(); // Finding all tests on course
            List<TestStudent> testStudents = new(); 
            foreach (var test in tests) // Adding columns with names of tests on course, and adding all TestStudents on this course
            {
                DataGridViewTextBoxColumn testColumn = new DataGridViewTextBoxColumn();
                testColumn.HeaderText = test.Name;
                testColumn.Name = test.Name;
                journalTable.Columns.Add(testColumn);
                testStudents.AddRange(FindAll<TestStudent>(ts => ts.TestId == test.Id));
            }

            Dictionary<Guid, DataGridViewRow> studentRows = new(); // Dictionary to add students id and rows that belongs to them

            foreach (var testStudent in testStudents)
            {
                Student? foundedStudent = FindByFilter<Student>(s => s.Id == testStudent.StudentId); // Finding instance of student
                Test? foundedTest = FindByFilter<Test>(t => t.Id == testStudent.TestId); // and same for Test for they names.
                if (foundedStudent == null || foundedTest == null) continue; // Validate if each is not null
                if (!studentRows.TryGetValue(foundedStudent.Id, out var existingRow)) // Trying to find row by student id in Dictionary
                {
                    existingRow = new DataGridViewRow(); // if we not find creating such one and adding values in main columns
                    existingRow.CreateCells(journalTable);
                    existingRow.Cells[journalTable.Columns["IdColumn"].Index].Value
                        = foundedStudent.Id.ToString();
                    existingRow.Cells[journalTable.Columns["StudentName"].Index].Value
                        = foundedStudent.FirstName + " " + foundedStudent.LastName;
                    journalTable.Rows.Add(existingRow);
                    studentRows[foundedStudent.Id] = existingRow;
                }
                existingRow.Cells[journalTable.Columns[foundedTest.Name].Index].Value = testStudent.Mark; // if find, set mark for test.
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
                            var idCell = row.Cells["IdColumn"].Value.ToString();
                            if (ValidateNull(idCell, "id in cell")) return;
                            if (Guid.TryParse(idCell, out Guid parsedId))
                            {
                                if (parsedId != foundedStudent.Id) continue;
                                var cellValue = cell.Value.ToString();
                                if (ValidateNull(idCell, "cell value")) return;
                                if (int.TryParse(cellValue, out int mark))
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
                if (ValidateNull(selectedStudentId, "selectedStudentId")) return;
                Student? student = null;
                if (Guid.TryParse(selectedStudentId, out Guid parsedId))
                {
                    student = FindByFilter<Student>(s => s.Id == parsedId);
                }
                if (ValidateNull(student, "student")) return;
                ShowNextForm(currentForm, new UserForm(student!, course, user));
            }
        }

        private static void FillCourseGeneric<T>(List<Course> allCourses,ListBox coursesList, User user) 
            where T : CourseUser
        {
            var allCoursesOfUser = FindAll<T>(ct => ct.UserId == user.Id).ToList();

            foreach (var courseTeacher in allCoursesOfUser)
            {
                var course = allCourses.Find(c => c.Id == courseTeacher.CourseId);
                if (ValidateNull(course, "course")) return;
                coursesList.Items.Add(course!.Name!);
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

                Remove(null, thisStudentAnswers);
                Remove(null, thisStudentCompletedTests);
                Remove(FindByFilter<CourseStudent>(cs => cs.UserId == student.Id && cs.CourseId == course.Id));
                Create<StudentMessage>(new()
                {
                    Initials = teacher.FirstName + " " + teacher.LastName,
                    MessageText = Microsoft.VisualBasic.Interaction.InputBox("Enter message-reason to student:", "Course", ""),
                    CourseName = course.Name,
                    StudentId = student.Id
                });
                MessageBox.Show("Student was deducted succesfully.", "Course", MessageBoxButtons.OK);
                currentForm.Close();
                return;
            }
            MessageBox.Show("You cannot deduct this student, because he doesn't have marks below 3", "Course", MessageBoxButtons.OK);
            return;
        }
    }
}
