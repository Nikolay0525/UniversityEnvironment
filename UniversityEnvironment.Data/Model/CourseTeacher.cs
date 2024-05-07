using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class CourseTeacher : CourseUser
    {
        public Teacher? Teacher { get; set; }
        public Course? Course { get; set; }
    }
}
