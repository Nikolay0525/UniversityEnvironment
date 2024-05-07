using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class CourseStudent : CourseUser
    {
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
