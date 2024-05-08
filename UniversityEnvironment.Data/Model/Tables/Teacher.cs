using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.Data.Model.Tables
{
    public class Teacher : User
    {
        public string? ScienceDegree { get; set; }
        public List<CourseTeacher>? CoursesTeachers { get; set; }
        public override Role Role => Role.Teacher;
        public override bool Confirmed { get; set; } = false;
    }
}
