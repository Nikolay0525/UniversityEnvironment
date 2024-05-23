using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.Data;
using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;

namespace UniversityEnvironment.View.Forms
{
    public partial class UserForm : MaterialForm
    {
        protected User _user;
        public UserForm()
        {

        }
        public UserForm(User user)
        {
            InitializeComponent();
            _user = user;
            NameBox.Text = user.FirstName;
            SurnameBox.Text = user.LastName;
            RoleBox.Text = user.Role.ToString();
            if (user.Role == Data.Enums.Role.Teacher)
            {
                var teacher = FindByFilter<Teacher>(t => t.Id == user.Id);
                ArgumentNullException.ThrowIfNull(teacher);
                ScienceDegreeBox.Text = teacher.ScienceDegree;
            }
            else
            {
                ScienceDegreeBox.Hide();
                ScienceDegreeLabel.Hide();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
