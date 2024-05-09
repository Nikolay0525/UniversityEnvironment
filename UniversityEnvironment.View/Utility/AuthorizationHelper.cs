using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using UniversityEnvironment.Data.Enums;
using UniversityEnvironment.Data.Repositories;
using UniversityEnvironment.Data.Model.Tables;

namespace UniversityEnvironment.View.Utility
{
    internal static class AuthorizationHelper
    {
        internal static T CreateUser<T>(string username, string fname, string lname, string password) where T : User,new()
        {
            var userToCreate = new T()
            {
                Username = username,
                FirstName = fname,
                LastName = lname,
                Password = password,
            };
            return userToCreate;
        }
        internal static T? SetUserRole<T>(string? name) where T : User
        {
            var user = RepositoryManager.GetRepo<T>()
                .FindByFilter(u => u.Username == name);
            if (user == null) return null;
            return user;
        }
    }
}
