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
        private bool _forgetPassword = false;
        private bool _canChangePassword = false;
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public virtual Role Role { get; set; }
        public virtual bool Confirmed { get; set; } = true;
        public bool ForgetPassword
        {
            get => _forgetPassword;
            set { if (Confirmed == true) _forgetPassword = value; }
        }
        public bool CanChangePassword
        {
            get => _canChangePassword;
            set { if (_forgetPassword == true) _canChangePassword = value; }
        }
    }
}
