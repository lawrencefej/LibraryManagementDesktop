using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Book
    {
        /// <summary>
        /// Reperesents the ID of one book.
        /// </summary>
        public int BookID { get; set; }
        /// <summary>
        /// Reperesents the title of one book.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Reperesents the Author of one book.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Reperesents the year this book was published.
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// Represents the ISBN of this book.
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// Represents the description of this book.
        /// </summary>
        //public string Description { get; set; }
        /// <summary>
        /// Represents the date this book was added.
        /// </summary>
        public string DateAdded { get; }
        /// <summary>
        /// Represents the location of this book.
        /// </summary>
        //public string Location { get; set; }
        /// <summary>
        /// Represents the quantity of this book.
        /// </summary>
        public int Quantity { get; set; }
    }
}
