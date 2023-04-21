using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Library
{
    public static class Verification
    {
        public static bool ValidateUserData(string login, string password)
        {
           foreach(var item in App.DataBase.User)
            {
                if (login.Equals(item.Login) && password.Equals(item.Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
