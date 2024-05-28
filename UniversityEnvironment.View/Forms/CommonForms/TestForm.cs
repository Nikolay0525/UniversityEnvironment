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
using UniversityEnvironment.View.Forms.AdminForms;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms
{
    public partial class TestForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        private readonly Test _test;

        public TestForm(User user, Course course, Test test)
        {
            Text = course.Name;
            _user = user;
            _course = course;
            _test = test;
            InitializeComponent();
            UpdateQuestionTable(QuestionTable, _test);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateQuestionButton_Click(object sender, EventArgs e)
        {
            CreateQuestion(_test, UpdateQuestionTable, QuestionTable, _test);
        }

        private void QuestionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickOnQuestion(1, this, QuestionTable, e, _user, _course, _test);
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestions(QuestionTable, _test.Id);
        }
    }
}
