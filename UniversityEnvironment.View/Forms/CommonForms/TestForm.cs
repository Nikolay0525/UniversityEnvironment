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
        private List<QuestionAnswerStudent> _questionAnswerStudents = new();
        private readonly User _user;
        private readonly Test _test;

        public TestForm(User user, Test test)
        {
            _user = user;
            _test = test;
            InitializeComponent();
            Text = test.Name;
            if(user.Role != Role.Admin)
            {
                Height = 368;
                CreateQuestionButton.Visible = false;
                DeleteQuestionButton.Visible = false;
                QuestionTable.Columns["CheckColumn"].Visible = false;
            }
            UpdateQuestionTable(QuestionTable, test);
        }

        public void AddAnswer(QuestionAnswerStudent? answer = null, IEnumerable<QuestionAnswerStudent>? answers = null)
        {
            if (answer != null)
                _questionAnswerStudents.Add(answer);
            else if (answers != null) _questionAnswerStudents.ForEach(_questionAnswerStudents.Add);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateQuestionButton_Click(object sender, EventArgs e)
        {
            ShowNextFormUpdateTable<Test>(this, new QuestionCreatorForm(_test), QuestionTable, _test, UpdateQuestionTable);
        }

        private void QuestionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(_user.Role == Role.Admin) ClickOnQuestion(1, this, QuestionTable, e, _user);
            else ClickOnQuestion(1, this, QuestionTable, e, _user);
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestion(_test.Id, QuestionTable, false);
        }

        private void SendAnswersButton_Click(object sender, EventArgs e)
        {
            Create<QuestionAnswerStudent>(null, _questionAnswerStudents);
            Create<TestStudent>(new() { Mark = 0, StudentId = _user.Id, TestId = _test.Id });
        }
    }
}
