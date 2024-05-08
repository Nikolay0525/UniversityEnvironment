using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.Data.Model.Tables
{
    public sealed class Test : EnvironmentObject
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Course? Course { get; set; }
        public List<TestMark>? Marks { get; set; }
        public List<TestQuestion>? Questions { get; set; }
        public List<TestStudent>? TestsStudents { get; set; }
    }
}
