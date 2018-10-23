using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class CheckoutDetailsModel : ICheckoutDetailsModel
    {

        public int CheckoutDetailsID { get; set; }

        public List<IItemModel> CheckedOutItems { get; set; } = new List<IItemModel>();

        public CheckoutModel checkoutModel { get; set; }

        public ItemModel ItemModel { get; set; }

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{checkoutModel.CheckoutID} {ItemModel.Title} {checkoutModel.CheckoutDate} {checkoutModel.ExpReturnDate} {checkoutModel.ActReturnDate} {checkoutModel.itemModel.Title}";
        //    }
        //}


    }
}
