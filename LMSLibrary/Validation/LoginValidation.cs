using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSLibrary.DataAccess;

namespace LMSLibrary.Validation
{
    public class LoginValidation
    {
        public void InputValidation(string emailAddress, string password)
        {
            SqlConnections access = new SqlConnections();
            var login = access.Login2(emailAddress, password);
            Validation2(login);
        }

        public void Validation2(List<Models.User> users)
        {
            if (users.Count != 1)
            {
                throw new Exception("Invalid login credentials");
            }

        }


    }
}
