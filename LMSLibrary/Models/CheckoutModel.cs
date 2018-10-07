using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class CheckoutModel
    {
        /// <summary>
        /// Represents the id of the item that is checked out.
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// Represents The list of books in the cart.
        /// </summary>
        public List<Book> Books { get; set; } = new List<Book>();
        /// <summary>
        /// Represents the list of media in the cart.
        /// </summary>
        public List<MediaModel> Medias { get; set; } = new List<MediaModel>();
        /// <summary>
        /// Represents the checkout date of the session.
        /// </summary>
        public string CheckoutDate { get; set; }
        /// <summary>
        /// Represents the calculated expected return date of the items borrowed.
        /// </summary>
        public string ExpReturnDate { get; set; }
        /// <summary>
        /// Represents the actual datye the books were returned.
        /// </summary>
        public string ActReturnDate { get; set; }
    }
}
