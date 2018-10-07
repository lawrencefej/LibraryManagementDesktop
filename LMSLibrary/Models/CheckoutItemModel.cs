using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    class CheckoutItemModel
    {
        /// <summary>
        /// Represents the date this item was checked out.
        /// </summary>
        public string Checkoutdate { get; set; }
        /// <summary>
        /// Represents the expected return date for this item.
        /// </summary>
        public string ExpReturnDate { get; set; }
        /// <summary>
        /// Represents the actual return date for this item.
        /// </summary>
        public string ActReturnDate { get; set; }
        /// <summary>
        /// Represents the id of the item that is checked out.
        /// </summary>
        public int ItemID { get; set; }
    }
}
