using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class User
    {
        /// <summary>
        /// Represents the id of one user.
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Represents the first name of this user.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of this user.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email of this user.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the password of this user.
        /// </summary>
        /// 
        public string Password { get; set; }
        /// <summary>
        /// Represents phone number of this user.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Represents address line 1 of this user.
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// Represents address line 2 of this user.
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// Represents the city of this user.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Represents the state of this user.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Represents the zipcode of this user.
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// Represents the status of this user.
        /// </summary>
        public int Status { get; set; }

    }
}
