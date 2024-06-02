using MaterialSkin.Controls;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class QuestionForm : MaterialForm
    {
        private readonly TestForm _currentTestForm;
        private readonly User _user;
        private readonly TestQuestion _testQuestion;

        public QuestionForm(TestForm currentTestForm, User user, Test test, TestQuestion testQuestion)
        {
            _currentTestForm = currentTestForm;
            _user = user;
            _testQuestion = testQuestion;
            InitializeComponent();
            Text = test.Name;
            GuideLineAnswer.Visible = false;
            if (user.Role != Role.Admin)
            {
                Height = 398;
                CreateAnswerButton.Visible = false;
                DeleteAnswerButton.Visible = false;
            }
            if (user.Role == Role.Student)
            {
                Width = 304;
                StudentAnswerTable.Visible = false;
            }
            if (!_testQuestion.ManyAnswers &&( user.Role == Role.Admin || user.Role == Role.Teacher))
            {
                if(user.Role == Role.Admin || user.Role == Role.Teacher)
                {
                    CloseButton.Width = 280;
                    SendAnswersButton.Visible = false;
                }
                AnswerTable.Columns["CheckColumn"].Visible = false;
                GuideLineAnswer.Visible = true;
            }
            QuestionLabel.Text = testQuestion.QuestionText;
            UpdateAnswerTable(AnswerTable, _testQuestion);
        }

        private void CreateAnswerButton_Click(object sender, EventArgs e)
        {
            CreateAnswer(_testQuestion, UpdateAnswerTable, AnswerTable, _testQuestion);
        }
        private void DeleteAnswerButton_Click(object sender, EventArgs e)
        {
            DeleteAnswer(_testQuestion.Id, AnswerTable);
        }
        private void AnswerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_testQuestion.ManyAnswers && _user.Role == Role.Student) return;
            GuideLineAnswer.Visible = false;
            AnswerOnQuestion(_currentTestForm, this, _testQuestion.ManyAnswers, AnswerTable, StudentAnswerTable, _testQuestion.Id, _user, e);
        }
        private void SendAnswersButton_Click(object sender, EventArgs e)
        {
            AnswerOnQuestion(_currentTestForm, this, _testQuestion.ManyAnswers, AnswerTable, StudentAnswerTable, _testQuestion.Id, _user);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
