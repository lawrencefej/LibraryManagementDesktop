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
        public List<UserModel> Login2(string emailAddress, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<UserModel>("spUserLogin2 @EmailAddress, @Password", new { EmailAddress = emailAddress, Password = password }).ToList();
                return output;
            }
        }
        /// <summary>
        /// inserts the user into the databse using the parameters provided
        /// </summary>
        /// <param name="user"></param>
        /// <returns>returns a list of type User</returns>
        public UserModel UserRegistration(UserModel user)
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

        public List<UserModel> SearchUsers(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<UserModel>("spUsersViewSearch @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public List<MediaModel> SearchMedia(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<MediaModel>("spMediaViewSearch @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public List<UserModel> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<UserModel>("spGetUsers").ToList();

                return output;
            }
        }

        public MediaModel AddMedia(MediaModel media)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Title", media.Title);
                p.Add("@Director", media.Director);
                p.Add("@Description", media.Description);
                p.Add("@Year", media.Year);
                p.Add("@Quantity", media.Quantity);
                p.Add("@Location", media.Location);
                p.Add("@BookID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spAddMedia", p, commandType: CommandType.StoredProcedure);

                media.MediaID = p.Get<int>("@BookID");

                return media;
            }
        }

        public MediaModel EditMedia(MediaModel media)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@MediaID", media.MediaID);
                p.Add("@Title", media.Title);
                p.Add("@Director", media.Director);
                p.Add("@Description", media.Description);
                p.Add("@Year", media.Year);
                p.Add("@Quantity", media.Quantity);
                p.Add("@Location", media.Location);

                connection.Execute("spEditMedia", p, commandType: CommandType.StoredProcedure);

                //media.MediaID = p.Get<int>("@BookID");

                return media;
            }
        }

        public MediaModel DeleteMedia(MediaModel media)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@MediaID", media.MediaID);
                //p.Add("@BookID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spDeleteMedia", p, commandType: CommandType.StoredProcedure);

                //media.MediaID = p.Get<int>("@BookID");

                return media;
            }
        }

        public CheckoutModel Checkout(CheckoutModel checkout, UserModel user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                UserModel userID = new UserModel();
                var p = new DynamicParameters();
                //p.Add("@Title", media.Title);
                //p.Add("@Director", media.Director);
                //p.Add("@Description", media.Description);
                //p.Add("@Year", media.Year);
                //p.Add("@Quantity", media.Quantity);
                //p.Add("@Location", media.Location);
                //p.Add("@BookID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                //connection.Execute("spAddMedia", p, commandType: CommandType.StoredProcedure);

                //media.MediaID = p.Get<int>("@BookID");

                p.Add("@UserID", user.UserID);
                //p.Add("@ItemID", checkout.ItemID);

                connection.Execute("spIssueItem", p, commandType: CommandType.StoredProcedure);
                return checkout;
            }
        }
    }
}
