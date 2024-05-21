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

namespace UniversityEnvironment.View.Forms
{
    public partial class BaseTestForm : MaterialForm
    {
        private readonly User? _user;
        private readonly Course? _course;
        private readonly Test? _test;
        private readonly List<QuestionAnswer>? _answers;
        private readonly List<TestQuestion>? _questions;
        private List<List<bool>>? _questionsAnswers;

        public BaseTestForm(User user, Course course, Test test)
        {
            _user = user;
            _course = course;
            _test = test;
            InitializeComponent();
            Text = course.Name;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
