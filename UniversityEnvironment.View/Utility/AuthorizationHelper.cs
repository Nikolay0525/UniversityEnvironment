﻿using UniversityEnvironment.Data.Model.Tables;
using static UniversityEnvironment.Data.Service.MySqlService;
using static UniversityEnvironment.View.Validators.ViewValidators;

namespace UniversityEnvironment.View.Utility
{
    internal static class AuthorizationHelper
    {
        internal static T? SetUserRole<T>(string username, string password) where T : User
        {
            var userCheck = FindByFilter<T>(u => u.Username == username);
            if (userCheck == null) return null;
            T? user = userCheck.CanChangePassword
                ? userCheck
                : FindByFilter<T>(u => u.Username == username && u.Password == password);
            if (user == null) return null;

            if (user.CanChangePassword)
            {
                user.Password = password;
                user.CanChangePassword = false;
                user.ForgetPassword = false;
                Update(user);
            }

            return user;
        }
        internal static void RegistrateUser
            (bool adminCheck, bool teacherCheck,
            string username, string firstName, string lastName, string password)
        {
            if (adminCheck)
            {
                User userToCreate = CreateUser<Admin>(username, firstName, lastName, password);
                var admin = userToCreate as Admin;
                if(ValidateNull(admin, "admin")) return;
                if (!FindAll<Admin>().Any())
                {
                    admin!.Confirmed = true;
                    admin.SuperAdmin = true;
                    MessageBox.Show("You are the first admin and the main, be fair!", "Registration", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Request on creating sended", "Registration", MessageBoxButtons.OK);
                Create(admin);
            }
            else if (teacherCheck)
            {
                User userToCreate = CreateUser<Teacher>(username, firstName, lastName, password);
                var teacher = userToCreate as Teacher;
                if(ValidateNull(teacher, "teacher")) return;
                while (1 == 1)
                {
                    string scienceDegree = Microsoft.VisualBasic.Interaction.InputBox("Enter you're science degree:", "Entering text", "");
                    if (ValidateStringOnLength("science degree", scienceDegree, 1)) continue;
                    teacher!.ScienceDegree = scienceDegree;
                    break;
                }
                Create(teacher);
                MessageBox.Show("Request on creating sended", "Registration", MessageBoxButtons.OK);
            }
            else
            {
                User userToCreate = CreateUser<Student>(username, firstName, lastName, password);
                var student = userToCreate as Student;
                if(ValidateNull(student, "student")) return;
                Create(student);
                MessageBox.Show("Account successfully created", "Registration", MessageBoxButtons.OK);
            }
        }

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
            if (ValidateNull(user, "user")) return null;
            return user;
        }

        internal static T? ForgetPasswordRequest<T>(string username) where T : User
        {
            var user = FindByFilter<T>(u => u.Username == username);
            if (ValidateNull(user, "user")) return null;
            user!.ForgetPassword = true;
            return Update(user);
        }
    }
}
