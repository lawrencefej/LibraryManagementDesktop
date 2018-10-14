﻿using System;
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
        private const string db = "LibraryDB";
        DynamicParameters p = new DynamicParameters();

        public List<ItemModel> GetItems(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
            {
                var output = connection.Query<ItemModel>("spGetItems @Search", new { Search = search }).ToList();

                return output;
            }
        }

        //public List<ItemModel> GetItems()
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
        //    {
        //        var output = connection.Query<ItemModel>("spGetItems @Search", new { Search = search }).ToList();

        //        return output;
        //    }
        //}

        public void AddItem(IItemModel item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
            {
                //var p = new DynamicParameters();
                p.Add("@Title", item.Title);
                p.Add("@Author", item.Author);
                p.Add("@Description", item.Description);
                p.Add("@Year", item.Year);
                p.Add("@CategoryID", item.CategoryID);
                p.Add("@Quantity", item.Quantity);
                p.Add("@Stock", item.Stock);
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
            {
                //string readSp = "GetAllAuthors";
                var output = connection.Query<ItemModel>("spGetItemType", commandType: CommandType.StoredProcedure).ToList();
                //throw new NotImplementedException();
                return output;
            }
            
        }

        public List<ItemModel> GetCategory()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
            {
                //string readSp = "GetAllAuthors";
                var output = connection.Query<ItemModel>("spGetCategory", commandType: CommandType.StoredProcedure).ToList();
                //throw new NotImplementedException();
                return output;
            }
        }

        public List<MemberModel> GetMembers(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
            {
                var output = connection.Query<MemberModel>("spGetMembers @Search", new { Search = search }).ToList();

                return output;
            }
        }

        public List<ItemModel> GetItem()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<ItemModel>("spGettest").ToList();

                return output;
            }
        }

        public void IssueItem(CheckoutModel checkoutModel, IMemberModel memberModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(db)))
            {

                p.Add("@MemberID", memberModel.MemberID);
                p.Add("@CheckoutDate", checkoutModel.CheckoutDate);
                p.Add("@ExpReturnDate", checkoutModel.ExpReturnDate);

                p.Add("@CheckoutID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spInsertCheckout", p, commandType: CommandType.StoredProcedure);

                checkoutModel.CheckoutID = p.Get<int>("@CheckoutID");

                foreach (ItemModel itemModel in checkoutModel.Items)
                {
                    var i = new DynamicParameters();
                    i.Add("@CheckoutID", checkoutModel.CheckoutID);
                    i.Add("@ItemID", itemModel.ItemID);

                    connection.Execute("spInsertCheckoutDetails", i, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<MemberModel> GetMembers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LibraryDB")))
            {
                var output = connection.Query<MemberModel>("spGetMembers2").ToList();

                return output;
            }
        }
    }
}
