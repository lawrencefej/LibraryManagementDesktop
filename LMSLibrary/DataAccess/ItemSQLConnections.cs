using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LMSLibrary.Models;

namespace LMSLibrary.DataAccess 
{
    public class ItemSQLConnections : IDataConnection
    {
        DynamicParameters p = new DynamicParameters();

        public List<ItemModel> GetItems(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal("LibraryDB")))
            {
                var output = connection.Query<ItemModel>("spGetItems @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public void AddItem(IItemModel item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal("LibraryDB")))
            {
                //var p = new DynamicParameters();
                p.Add("@Title", item.Title);
                p.Add("@Author", item.Author);
                p.Add("@Description", item.Description);
                p.Add("@Year", item.Year);
                p.Add("@CategoryID", item.CategoryID);
                p.Add("@Quantity", item.Quantity);
                p.Add("@Location", item.Location);
                p.Add("@ISBN", item.ISBN);
                p.Add("@ItemTypeID", item.ItemTypeID);
                p.Add("@ItemID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spAddItem", p, commandType: CommandType.StoredProcedure);

                //item.ItemID = p.Get<int>("@itemID");
            }
        }

        public void EditItem(IItemModel item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal("LibraryDB")))
            {
                //var p = new DynamicParameters();
                p.Add("@ItemID", item.ItemID);
                p.Add("@Title", item.Title);
                p.Add("@Author", item.Author);
                p.Add("@Description", item.Description);
                p.Add("@Year", item.Year);
                p.Add("@CategoryID", item.CategoryID);
                p.Add("@Quantity", item.Quantity);
                p.Add("@Location", item.Location);
                p.Add("@ISBN", item.ISBN);
                p.Add("@ItemTypeID", item.ItemTypeID);
                //p.Add("@ItemID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spEditItem", p, commandType: CommandType.StoredProcedure);

                //item.ItemID = p.Get<int>("@itemID");
            }
        }

        public void DeleteItem(IItemModel item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal("LibraryDB")))
            {
                //var p = new DynamicParameters();
                p.Add("@ItemID", item.ItemID);
                //p.Add("@BookID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spDeleteItem", p, commandType: CommandType.StoredProcedure);

                item.ItemID = p.Get<int>("@BookID");
            }
        }

        public List<ItemModel> GetItemType()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal("LibraryDB")))
            {
                //string readSp = "GetAllAuthors";
                var output = connection.Query<ItemModel>("spGetItemType", commandType: CommandType.StoredProcedure).ToList();
                //throw new NotImplementedException();
                return output;
            }
            
        }

        public List<ItemModel> GetCategory()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal("LibraryDB")))
            {
                //string readSp = "GetAllAuthors";
                var output = connection.Query<ItemModel>("spGetCategory", commandType: CommandType.StoredProcedure).ToList();
                //throw new NotImplementedException();
                return output;
            }
        }
    }
}
