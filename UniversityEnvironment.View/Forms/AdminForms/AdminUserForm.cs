using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.View.Forms.CommonForms;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.Data.Service.MySqlService;

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
            if (profileUser.Role == Data.Enums.Role.Admin || profileUser.Role == Data.Enums.Role.Student)
            {
                if(profileUser.Role == Data.Enums.Role.Admin)
                {
                    CoursesLabel.Visible = false;
                    DeleteButton.Visible = false;
                    CloseButton.Left = 12;
                    CloseButton.Width = 280;
                    CloseButton.Height = 144;
                    CloseButton.Top = 212;
                    Height = 368;
                    var admin = FindByFilter<Admin>(a => a.Id == profileUser.Id);
                    if (admin == null) return;
                    if (admin.SuperAdmin)
                    {
                        DeleteButton.Visible = true;
                        Height = 451;
                    }
                }
                CloseButton.Height = 144;
                CloseButton.Top = 212;
            }
            else if (profileUser.Role == Data.Enums.Role.Teacher)
            {
                CloseButton.Height = 96;
                CloseButton.Top = 260;
            }
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
