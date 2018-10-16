using LMSLibrary.DataAccess;
using LMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitialiazeConnections(DatabaseType database)
        {
            switch (database)
            {
                case DatabaseType.SqlServer:
                    ItemSQLConnections sql = new ItemSQLConnections();
                    Connection = sql;
                    break;
                case DatabaseType.Mysql:
                    break;
                default:
                    break;
            }
        }

        public static IItemModel itemModel()
        {
            return new ItemModel();
        }

        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        //public static IDataConnection SQLConnection()
        //{
        //    return new ItemSQLConnections();
        //}

        public static IMemberModel Member()
        {
            return new MemberModel();
        }
    }
}
