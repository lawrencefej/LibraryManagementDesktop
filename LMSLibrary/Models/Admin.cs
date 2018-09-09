using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Admin
    {
        /// <summary>
        /// Reperesents the ID of one admin.
        /// </summary>
        public int AdminID { get; }
        /// <summary>
        /// Represents the first name of one admin.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of one admin.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Represents the date one admin was added.
        /// </summary>
        public string DateAdded { get; }
        /// <summary>
        /// Represents the status id of one admin.
        /// </summary>
        public int StatusID { get; set; }
    }
}
