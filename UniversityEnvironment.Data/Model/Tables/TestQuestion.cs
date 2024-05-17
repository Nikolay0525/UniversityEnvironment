using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model.Tables
{
    public sealed class TestQuestion : EnvironmentObject
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Test? Test { get; set; }
        public List<QuestionAnswer>? Answers { get; set; }
    }
}
