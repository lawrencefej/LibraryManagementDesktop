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
                var output = connection.Query<User>("spUserLogin2 @EmailAddress, @Password", new { EmailAddress = emailAddress, Password = password }).ToList();
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

        //public List<User> Login(string emailAddress, string password)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
        //    {
        //        User user = new User();
                
        //        var p = new DynamicParameters();
        //        p.Add("@EmailAddress", user.EmailAddress);
        //        p.Add("@Password", user.Password);

        //        //var output = connection.Query<User>("spUserLogin2", p, commandType: CommandType.StoredProcedure).ToList();
        //        var output = connection.Query("spUserLogin2", p, commandType: CommandType.StoredProcedure).ToList();

        //        var a = user.EmailAddress;
        //        var b = user.Password;
        //        var c = user.StatusID;

        //        return output;
        //    }
        //}
    }
}
