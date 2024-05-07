using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public abstract class CourseUser
    {
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
    }
}
