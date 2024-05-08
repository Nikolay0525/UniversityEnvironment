using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Enums;

namespace UniversityEnvironment.Data.Model.Tables
{
    public class User : EnvironmentObject
    {
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public virtual Role Role { get; set; }
        public virtual bool Confirmed { get; set; } = true;
    }
}
