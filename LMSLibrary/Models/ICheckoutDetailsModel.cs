using System.Collections.Generic;

namespace LMSLibrary.Models
{
    public interface ICheckoutDetailsModel
    {
        List<IItemModel> CheckedOutItems { get; set; }
        int CheckoutDetailsID { get; set; }
    }
}