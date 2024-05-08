using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.Data.Model.Tables
{
    public sealed class Student : User
    {
        public List<TestStudent>? TestsStudents { get; set; }
        public List<CourseStudent>? CoursesStudents { get; set; }
        public List<QuestionAnswerStudent>? QuestionAnswersStudent { get; set; }
        public override Role Role => Role.Student;
    }
}
