using System.Collections.Generic;

namespace LMSLibrary.Models
{
    public interface ICheckoutModel
    {
        List<ItemModel> Items { get; set; }
        string ActReturnDate { get; set; }
        string CheckoutDate { get; set; }
        int CheckoutID { get; set; }
        string ExpReturnDate { get; set; }
    }
}