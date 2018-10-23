using System.Collections.Generic;

namespace LMSLibrary.Models
{
    public interface ICheckoutModel
    {
        
        string ActReturnDate { get; set; }
        string CheckoutDate { get; set; }
        int CheckoutID { get; set; }
        string ExpReturnDate { get; set; }
        int ItemCount { get; set; }
        int ItemCountReturned { get; set; }
        string FullName { get; }
        List<ItemModel> Items { get; set; }
    }
}