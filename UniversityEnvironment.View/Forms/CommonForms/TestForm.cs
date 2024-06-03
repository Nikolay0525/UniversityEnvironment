using MaterialSkin.Controls;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms.AdminForms.CreatorForms;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class TestForm : MaterialForm
    {
        private Dictionary<Guid, List<QuestionAnswerStudent>> _questionAnswerStudents = new();
        private Dictionary<Guid, List<QuestionAnswerStudent>> _fakeQuestionAnswerToCompareWithOriginal = new();
        private Guid? _lastQuestion = null;

        private CourseForm _previousForm;
        private Course _course;
        private readonly User _user;
        private readonly Test _test;

        public TestForm(CourseForm previousForm, User user, Course course, Test test)
        {
            _previousForm = previousForm;
            _user = user;
            _course = course;
            _test = test;
            InitializeComponent();
            Text = test.Name;
            if (user.Role == Role.Admin || user.Role == Role.Teacher)
            {
                SendAnswersButton.Visible = false;
                CloseButton.Width = 280;
            }
            if (user.Role != Role.Admin)
            {
                Height = 368;
                CreateQuestionButton.Visible = false;
                DeleteQuestionButton.Visible = false;
                QuestionTable.Columns["CheckColumn"].ReadOnly = true;
            }
            UpdateQuestionTable(QuestionTable, test, user);
            this.VisibleChanged += FormIsShowed_Shown;
        }

        public void AddAnswer(Guid questionId, List<QuestionAnswerStudent>? answers = null)
        {
            if (answers != null) 
            {
                if (_questionAnswerStudents.ContainsKey(questionId))
                    _questionAnswerStudents.Remove(questionId);
                _questionAnswerStudents.Add(questionId, answers);
            }
        }

        private void CreateQuestionButton_Click(object sender, EventArgs e)
        {
            ShowNextFormUpdateTable<Test>(this, new QuestionCreatorForm(_test), QuestionTable, _test, _user, UpdateQuestionTable);
        }

        private void QuestionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _fakeQuestionAnswerToCompareWithOriginal = new(_questionAnswerStudents);
            _lastQuestion = ClickOnQuestion(3, this, QuestionTable, e, _user,_test);
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestion(_test.Id, QuestionTable, false);
        }

        private void SendAnswersButton_Click(object sender, EventArgs e)
        {
            foreach(var list in _questionAnswerStudents.Values)
            {
                Create(null, list);
            }
            Create<TestStudent>(new() { Mark = 0, StudentId = _user.Id, TestId = _test.Id });
            MessageBox.Show("Successfully sended answers, wait for checking...", "Test", MessageBoxButtons.OK);
            Close();
        }

        private void FormIsShowed_Shown(object? sender, EventArgs e)
        {
            if(_lastQuestion.HasValue && _lastQuestion != null && (_fakeQuestionAnswerToCompareWithOriginal.Count != _questionAnswerStudents.Count))
            {
                SetCheckedToQuestion(_lastQuestion.Value, QuestionTable);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UpdateTestsTable(_previousForm.GetTestsTable(), _course, _user);
            Close();
        }
    }
}
