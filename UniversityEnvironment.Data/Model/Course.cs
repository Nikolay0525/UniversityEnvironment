using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class Course : EnvironmentObject
    {
        public string? Name { get; set; }
        public string? FacultyName { get; set; }
        public List<Test>? Tests { get; set; }
        public List<Admin>? Admins { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Student>? Students { get; set; }
        public List<CourseAdmin>? CoursesAdmins { get; set; }
        public List<CourseTeacher>? CoursesTeachers { get; set; }
        public List<CourseStudent>? CoursesStudents { get; set; }
    }
}
