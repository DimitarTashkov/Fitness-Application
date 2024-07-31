using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Common.Messages
{
    public static class UserMessages
    {
        public static string RegistrationSuccess = "Successful registration !";
        public static string UnauthorizedAccess = "Unathourized access !";
        public static string UserDataUpdate = "Successfully updated {0}'s information !";
        public static string UserDeleted= "Successfully deleted user {0} !";
        public static string UserExists = "Such user already exists !";
        public static string InvalidInput = "Invalid input data ! Please fill in all \"*\" inputs with correct data !";
        public static string InvalidCredentials = "Invalid username or password !";
        public static string LogUserRegistered = "{0} has registered successfully !";
        public static string LogUserLoggedIn = "{0} has logged in successfully !";
        public static string LogUserEdited = "{0} has updated his credentials successfully !";


    }
}
