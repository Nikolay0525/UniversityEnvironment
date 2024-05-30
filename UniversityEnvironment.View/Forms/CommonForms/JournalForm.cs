using MaterialSkin.Controls;
using UniversityEnvironment.Data;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.View.Utility.ViewHelper;


namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class JournalForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        public JournalForm(User User, Course course)
        {
            _user = User;
            _course = course;
            this.Text = "Welcome to " + course.Name + " journal!";
            InitializeComponent();
            UpdateJournalTable(JournalTable, course);
            if (_user.Role == Data.Enums.Role.Admin || _user.Role == Data.Enums.Role.Teacher)
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = false;
                }
            }
            else
            {
                CloseButton.Width = 576;
                ApplyButton.Visible = false;
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = true;
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ApplyChangesToDBJournal(JournalTable, _course);
            return;
        }

        private void JournalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickOnJournal(this, JournalTable, e, _course, _user);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
