using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSLibrary.DataAccess;
using LMSLibrary.Models;

namespace LMSLibrary.Validation
{
    public class LoginValidation
    {
        SqlConnections access = new SqlConnections();

        public List<UserModel> InputValidation(string emailAddress, string password)
        {
            //SqlConnections access = new SqlConnections();
            var login = access.Login2(emailAddress, password);
            Validation2(login);
            return login;
            
        }

        public void Validation2(List<UserModel> users)
        {
            if (users.Count != 1)
            {
                throw new Exception("Invalid login credentials");
            }
        }

        public bool GetRole(List<UserModel> user)
        {
            bool role = false;
                     
            if (user[0].RoleID == 2)
            {
                    role = true;
            }
            return role;
        }


    }
}
