using System.Collections.Generic;

namespace LMSLibrary.Models
{
    public interface ICheckoutModel
    {
        
        string ActReturnDate { get; set; }
        string CheckoutDate { get; set; }
        int CheckoutID { get; set; }
        string ExpReturnDate { get; set; }
        List<ItemModel> Items { get; set; }
    }
}