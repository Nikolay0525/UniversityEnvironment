using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data.Repository;
using UniversityEnvironment.Data;

namespace UniversityEnvironment.View.Validator
{
    internal static class ViewValidator
    {
        internal static bool ValidateUserExists(string userName)
        {
            using UniversityEnvironmentContext context = new();
            bool UserExistsInRepo<T>(UniversityEnvironmentContext context, string name) where T : User
            {
                return RepositoryManager
                    .GetRepo<T>(context)
                    .FindByFilter(u => u.Username == name) != null;
            }

            return UserExistsInRepo<Admin>(context, userName) ||
                   UserExistsInRepo<Teacher>(context, userName) ||
                   UserExistsInRepo<Student>(context, userName);
        }
    }
}
