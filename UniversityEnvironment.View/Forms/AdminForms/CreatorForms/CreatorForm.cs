using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
