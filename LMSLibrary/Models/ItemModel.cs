using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class ItemModel : IItemModel
    {
        /// <summary>
        /// Represents the id of this Item.
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// Represents the title of this Item.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Represents the release year of this Item.
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// Represents the creator name of this Item.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Represents the description of this Item.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Represents the location of this of one Item.
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Represents the quantity of this Item.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Represents the stock amount of this Item.
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Represents the date this Item was added.
        /// </summary>
        public string DateAdded { get; }
        /// <summary>
        /// Represents the item type id.
        /// </summary>
        public string ItemTypeName { get; set; }
        /// <summary>
        /// Represents the category id.
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Represents the ISBN of this Item.
        /// </summary>
        public string ISBN { get; set; }
        public int CategoryID { get; set; }
        //public int CategoryID { set; }
        public int ItemTypeID { get; set; }

        public string Cart
        {
            get
            {
                return $"{Title}     {Year}";
            }
        }

        public string Items
        {
            get
            {
                return $"{Title}     {Year}    {Author}";
            }
        }

    }
}
