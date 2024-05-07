using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class QuestionAnswer : EnvironmentObject
    {
        public TestQuestion? Question { get; set; }
        public List<Student>? Students { get; set; }
        public List<QuestionAnswerStudent>? QuestionAnswersStudents { get; set; }
    }
}
