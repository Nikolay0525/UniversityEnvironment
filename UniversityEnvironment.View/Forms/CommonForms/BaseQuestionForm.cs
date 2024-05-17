using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnvironment.Data.Model.Tables;

namespace UniversityEnvironment.View.Forms.CommonForms
{
    public partial class BaseQuestionForm : MaterialForm
    {
        private Test _test;
        private User _user;

        public BaseQuestionForm(Test test, User user)
        {
            _test = test;
            _user = user;
            InitializeComponent();
        }
    }
}
