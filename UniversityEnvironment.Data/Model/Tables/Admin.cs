using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Enums;

namespace UniversityEnvironment.Data.Model.Tables
{
    public class Admin : User
    {
        public override Role Role => Role.Admin;
        public override bool Confirmed { get; set; } = false;
        public bool SuperAdmin { get; set; } = false;
    }

}
