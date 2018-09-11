using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSLibrary.Models;

namespace LMSLibrary.DataAccess
{
    public class SqlConnections
    {
        /// <summary>
        /// retrieves the email and password from the SQLConnection class.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        /// <returns> Returns a list that contains the email and password. </returns>
        public List<User> Login2(string emailAddress, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<User>("spUserLogin @EmailAddress, @Password", new { EmailAddress = emailAddress, Password = password }).ToList();
                return output;
            }
        }

        public User UserRegistration(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", user.FirstName);
                p.Add("@LastName", user.LastName);
                p.Add("@EmailAddress", user.EmailAddress);
                p.Add("@Password", user.Password);
                p.Add("@PhoneNumber", user.PhoneNumber);
                p.Add("@Address1", user.Address1);
                p.Add("@Address2", user.Address1);
                p.Add("@City", user.City);
                p.Add("@State", user.State);
                p.Add("@Zipcode", user.Zipcode);
                p.Add("@UserID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spUserRegistration", p, commandType: CommandType.StoredProcedure);

                user.UserID = p.Get<int>("@UserID");

                return user;
            }
        }

        public void UserRegistration2(string firstName, string lastName, string emailAddress, string password, string phoneNumber, string address1, string address2, string city, string state, string zipcode)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LawDevDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                //TODO
                List<User> user = new List<User>();

                user.Add(new User { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", user);
            }
        }


    }
}
