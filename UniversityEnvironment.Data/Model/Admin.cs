using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Enums;

namespace UniversityEnvironment.Data.Model
{
    public class Admin : User
    {
        public List<CourseAdmin>? CoursesAdmins { get; set; }
        public override Role Role => Role.Admin;
    }

}
