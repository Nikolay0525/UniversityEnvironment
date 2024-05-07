using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Repositories;

namespace UniversityEnvironment.View.Validator
{
    internal static class ViewValidator
    {
        internal static bool ValidateUserExists<T>(string userName) where T : User
        {
            var foundUser = RepositoryManager
                .GetRepo<T>()
                .FindByFilter(u => u.Username == userName);

            return foundUser == null;
        }
    }
}
