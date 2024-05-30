using MaterialSkin.Controls;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;
namespace UniversityEnvironment.View.Forms.AdminForms.CreatorForms
{
    public partial class QuestionCreatorForm : CreatorForm
    {
        private Guid _testId;
        public QuestionCreatorForm(Test test)
        {
            InitializeComponent();
            _testId = test.Id;
        }

        protected override void CreateButton_Click(object sender, EventArgs e)
        {
            TestQuestion question = new()
            {
                ManyAnswers = ManyAnswersButton.Checked,
                QuestionText = QuestionTextBox.Text,
                TestId = _testId
            };
            Create<TestQuestion>(question);
            Close();
        }
    }
}
