using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Model;

namespace UniversityEnvironment.View.Utility
{
    internal static class AuthorizationHelper
    {
        public static T CreateUser<T>(string username, string fname, string lname, string password) where T : User,new()
        {
            var userToCreate = new T()
            {
                Username = username,
                FirstName = fname,
                LastName = lname,
                Password = password,
                Courses = new(),
            };
            return userToCreate;
        }
    }
}
