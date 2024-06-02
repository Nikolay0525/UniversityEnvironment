using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;

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
            var user = FindByFilter<T>(u => u.Username == name);
            if (user == null) return null;
            return user;
        }
        internal static T? ForgetPasswordRequest<T>(string username) where T : User
        {
            var user = FindByFilter<T>(u => u.Username == username);
            if (user == null) return null;
            user.ForgetPassword = true;
            return Update<T>(user);
        }
    }
}
