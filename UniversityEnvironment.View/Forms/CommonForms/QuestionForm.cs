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
using UniversityEnvironment.Data;
using UniversityEnvironment.View.Forms.AdminForms;
using static UniversityEnvironment.View.Utility.AdminViewHelper;
using static UniversityEnvironment.View.Utility.ViewHelper;

namespace UniversityEnvironment.View.Forms
{
    public partial class QuestionForm : MaterialForm
    {
        private User _user;
        private Course _course;
        private Test _test;
        private TestQuestion _testQuestion;

        public QuestionForm(User user, Course course, Test test, TestQuestion testQuestion)
        {
            _user = user;
            _course = course;
            _test = test;
            _testQuestion = testQuestion;
            InitializeComponent();
            QuestionLabel.Text = testQuestion.QuestionText;
            UpdateAnswerTable(AnswerTable, _testQuestion);
        }

        private void CreateAnswerButton_Click(object sender, EventArgs e)
        {
            CreateAnswer(_testQuestion, UpdateAnswerTable, AnswerTable, _testQuestion);
        }
        private void DeleteAnswerButton_Click(object sender, EventArgs e)
        {

        }
        private void AnswerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
