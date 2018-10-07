using System.Collections.Generic;
using LMSLibrary.Models;

namespace LMSLibrary.DataAccess
{
    public interface IDataConnection
    {
        void AddItem(IItemModel item);

        void DeleteItem(ItemModel item);

        void EditItem(ItemModel item);

        List<ItemModel> GetItems(string search);

        List<ItemModel> GetItemType();

        List<ItemModel> GetCategory();
    }
}