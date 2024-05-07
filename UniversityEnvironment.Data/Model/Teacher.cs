using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Enums;

namespace UniversityEnvironment.Data.Model
{
    public class Teacher : User
    {
        public string? ScienceDegree { get; set; }
        public List<CourseTeacher>? CoursesTeachers { get; set; }

        public new Role Role => Role.Teacher;
    }
}
