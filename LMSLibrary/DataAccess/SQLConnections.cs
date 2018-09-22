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
        /// <summary>
        /// inserts the user into the databse using the parameters provided
        /// </summary>
        /// <param name="user"></param>
        /// <returns>returns a list of type User</returns>
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
        /// <summary>
        /// Retrieves all the books in the database
        /// </summary>
        /// <returns>Returns a list of type book</returns>
        public List<Book> GetBooks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<Book>("spGetBooks").ToList();

                return output;
            }
        }

        public List<Book> SearchBooks(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<Book>("spBookViewSearch @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public Book AddBook(Book book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Title", book.Title);
                p.Add("@Author", book.Author);
                p.Add("@ISBN", book.ISBN);
                p.Add("@Quantity", book.Quantity);
                p.Add("@Year", book.Year);
                p.Add("@BookID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spAddBook", p, commandType: CommandType.StoredProcedure);

                book.BookID = p.Get<int>("@BookID");

                return book;
            }
        }

        public List<User> SearchUsers(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<User>("spUsersViewSearch @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public List<Media> SearchMedia(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<Media>("spMediaViewSearch @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public List<User> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<User>("spGetUsers").ToList();

                return output;
            }
        }
    }
}
