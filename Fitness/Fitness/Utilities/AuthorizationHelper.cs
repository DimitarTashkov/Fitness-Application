using Fitness.Common.Messages;
using Fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Utilities
{
    public class AuthorizationHelper
    {
        public static bool IsUserAuthorized(User user)
        {
            if(user.IsAuthorized)
            {
                return true;
            }
            return false;
        }
        
    }
}
