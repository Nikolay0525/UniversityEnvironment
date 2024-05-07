using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class Student : User
    {
        private List<Test>? _tests;
        private List<TestStudent>? _testsStudents;
        private List<QuestionAnswer>? _questionAnswers;
        private List<QuestionAnswerStudent>? _questionAnswersStudents;
        private List<CourseStudent>? _coursesStudents;
        public List<Test>? Tests { get => _tests; set => _tests = value; }
        public List<TestStudent>? TestsStudents { get => _testsStudents; set => _testsStudents = value; }
        public List<QuestionAnswer>? QuestionAnswers { get => _questionAnswers; set => _questionAnswers = value; }
        public List<QuestionAnswerStudent>? QuestionAnswersStudent { get => _questionAnswersStudents; set => _questionAnswersStudents = value; }
        public List<CourseStudent>? CoursesStudents { get => _coursesStudents; set => _coursesStudents = value; }

        public new string Role => "Student";
    }
}
