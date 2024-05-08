using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;

namespace UniversityEnvironment.Data.Model.MtoMTables
{
    public class TestStudent
    {
        public Guid StudentId { get; set; }
        public Guid TestId { get; set; }
        public Student? Student { get; set; }
        public Test? Test { get; set; }
    }
}
