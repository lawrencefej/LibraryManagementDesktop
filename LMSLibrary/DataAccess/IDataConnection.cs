using System.Collections.Generic;
using LMSLibrary.Models;

namespace LMSLibrary.DataAccess
{
    public interface IDataConnection
    {
        List<MemberModel> GetMembers();

        MemberModel GetMembers(int ID);

        List<MemberModel> GetMembers(string search);

        List<ItemModel> GetItems(string search);

        void AddItem(IItemModel item);

        void DeleteItem(IItemModel item);

        void EditItem(IItemModel item);

       

        List<ItemModel> GetItemType();

        List<ItemModel> GetCategory();

        //List<MemberModel> GetMembers(string search);

        void IssueItem(CheckoutModel checkoutModel, IMemberModel memberModel);

        List<ItemModel> GetItem();

        

        List<CheckoutModel> GetMemberCheckoutHistory(int memberID);

        //List<CheckoutDetailsModel> GetCheckoutDetails(List<CheckoutModel> checkoutModels);
    }
}