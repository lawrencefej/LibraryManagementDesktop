using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.DataAccess
{
    public class SqlConnections
    {

        public String Login(string emailAddress, string password)
        {
            List<Models.User> Login = new List<Models.User>();
            //var output = "";
            var s = "";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                
                //var output = connection.Query<Person>($"select * from people where LastName = '{ lastName }'").ToList();
                var output = connection.Query<Models.User>("spUserLogin @EmailAddress, @Password", new { EmailAddress = emailAddress, Password = password }).ToList();
                s = LoginValidation(output);
            }
            return s;
        }

        public String LoginValidation(List<Models.User> users)
        {
            if (users.Count > 0)
            {
                return "Login Successful";
            }
            else
            {
                return "Invalid Login Credentials";
            }
        }

        public List<Models.User> Login2(string emailAddress, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<Models.User>("spUserLogin @EmailAddress, @Password", new { EmailAddress = emailAddress, Password = password }).ToList();
                return output;
            }
        }

        public void Validation2()
        {

        }
    }
}
