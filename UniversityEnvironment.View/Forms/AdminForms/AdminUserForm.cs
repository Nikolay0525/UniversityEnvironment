using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms.CommonForms;
using static UniversityEnvironment.View.Utility.AdminViewHelper;

namespace UniversityEnvironment.View.Forms.AdminForms
{
    public partial class AdminUserForm : UserForm
    {
        public AdminUserForm() : base()
        {
            InitializeComponent();
        }
        public AdminUserForm(User profileUser) : base(profileUser)
        {
            InitializeComponent();
            DeductButton.Visible = false;
            CloseButton.Height = 96;
            CloseButton.Top = 260;
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_profileUser.Role == Data.Enums.Role.Admin) 
            {
                FindAndRemove<Admin>(this, _profileUser.Id);
            } 
            else if (_profileUser.Role == Data.Enums.Role.Teacher)
            {
                FindAndRemove<Teacher>(this, _profileUser.Id);
            }
            else
            {
                FindAndRemove<Student>(this, _profileUser.Id);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
