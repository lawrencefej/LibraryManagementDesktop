using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    class CheckoutDetailsModel : ICheckoutDetailsModel
    {
        public int CheckoutDetailsID { get; set; }

        public List<IItemModel> CheckedOutItems { get; set; } = new List<IItemModel>();


    }
}
