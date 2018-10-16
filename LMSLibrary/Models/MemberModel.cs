using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class MemberModel : IMemberModel
    {
        /// <summary>
        /// Represents the id of this member.
        /// </summary>
        public int MemberID { get; set; }
        /// <summary>
        /// Represents the first name of this member.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of this member.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email of this member.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the password of this member.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Represents phone number of this member.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Represents address of this member.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Represents the city of this member.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Represents the state of this member.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Represents the zipcode of this member.
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// Represents the date registered of this member.
        /// </summary>
        public string DateRegistered { get; set; }
        /// <summary>
        /// Represents the status of this user.
        /// </summary>
        public String StatusName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
