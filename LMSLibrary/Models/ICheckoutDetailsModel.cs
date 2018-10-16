using System.Collections.Generic;

namespace LMSLibrary.Models
{
    interface ICheckoutDetailsModel
    {
        List<IItemModel> CheckedOutItems { get; set; }
        int CheckoutDetailsID { get; set; }
    }
}