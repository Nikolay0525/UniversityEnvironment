using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model.Tables
{
    public sealed class TestQuestion : EnvironmentObject
    {
        public string? QuestionText { get; set; }
        public Guid? TestId { get; set; }
        public Test? Test { get; set; }
        public List<QuestionAnswer>? Answers { get; set; }
    }
}
