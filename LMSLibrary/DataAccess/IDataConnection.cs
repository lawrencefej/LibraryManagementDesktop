using System.Collections.Generic;
using LMSLibrary.Models;

namespace LMSLibrary.DataAccess
{
    public interface IDataConnection
    {
        void AddItem(IItemModel item);

        void DeleteItem(IItemModel item);

        void EditItem(IItemModel item);

        List<ItemModel> GetItems(string search);

        List<ItemModel> GetItemType();

        List<ItemModel> GetCategory();

        List<MemberModel> GetMembers(string search);

        void IssueItem(CheckoutModel checkoutModel, IMemberModel memberModel);

        List<ItemModel> GetItem();

        List<MemberModel> GetMembers();

        List<ICheckoutModel> GetMemberCheckoutHistory(IMemberModel member);
    }
}