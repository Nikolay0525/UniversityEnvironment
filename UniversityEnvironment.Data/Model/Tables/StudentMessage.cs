using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model.Tables
{
    public class StudentMessage : EnvironmentObject
    {
        public string? Initials { get; set; }
        public string? MessageText { get; set; }
        public string? CourseName {  get; set; }
        public Guid StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
