using MaterialSkin.Controls;

namespace UniversityEnvironment.View.Forms.AdminForms
{
    public partial class CreatorForm : MaterialForm
    {
        public CreatorForm()
        {
            InitializeComponent();
        }

        protected virtual void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
