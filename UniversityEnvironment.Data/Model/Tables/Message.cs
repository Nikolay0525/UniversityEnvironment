using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model.Tables
{
    public class StudentMessage : EnvironmentObject
    {
        public string? MessageText { get; set; }
        public Guid StudentId { get; set; }
        public Student? student { get; set; }
    }
}
