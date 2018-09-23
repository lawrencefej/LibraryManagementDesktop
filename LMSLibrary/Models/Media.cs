using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Media
    {
        /// <summary>
        /// Represents the id of this media.
        /// </summary>
        public int MediaID { get; set; }
        /// <summary>
        /// Represents the title of this media.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Represents the release year of this media.
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// Represents the director name of this media.
        /// </summary>
        public string Director { get; set; }
        /// <summary>
        /// Represents the description of this media.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Represents the quantity available of this of one media.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Represents the location of this media.
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Represents the date this media was added.
        /// </summary>
        public string DateAdded { get; }
    }
}
