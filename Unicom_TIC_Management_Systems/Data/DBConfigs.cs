using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_Systems.Data
{
    internal class DBConfigs
    {

        private static string connectionString = "Data Source = Z:\\C#\\Unicom_TIC_Management_Systems\\Unicom_TIC_Management_Systems\\UnicomDB.db; Version=3 ";
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }







    }
}
