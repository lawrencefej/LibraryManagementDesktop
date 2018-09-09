using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Checkout
    {
        /// <summary>
        /// Represents The list of books in the cart.
        /// </summary>
        public List<Book> Books { get; set; } = new List<Book>();
        /// <summary>
        /// Represents the list of media in the cart.
        /// </summary>
        public List<Media> Medias { get; set; } = new List<Media>();
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
