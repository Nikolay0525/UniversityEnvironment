using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Model.MtoMTables;
using UniversityEnvironment.Data.Repositories;
using UniversityEnvironment.Data;

namespace UniversityEnvironment.View.Validator
{
    internal static class ViewValidator
    {
        internal static bool ValidateUserExists<T>(UniversityEnvironmentContext context, string userName) where T : User
        {
            var foundUser = RepositoryManager
                .GetRepo<T>(context)
                .FindByFilter(u => u.Username == userName);

            return foundUser != null;
        }
    }
}
