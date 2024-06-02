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
            if (Validators.ViewValidators.ValidateStringOnLength("text of question", QuestionTextBox.Text, 1, 50)) return;
            TestQuestion question = new()
            {
                ManyAnswers = ManyAnswersButton.Checked,
                QuestionText = QuestionTextBox.Text,
                TestId = _testId
            };
            Create(question);
            Close();
        }
    }
}
