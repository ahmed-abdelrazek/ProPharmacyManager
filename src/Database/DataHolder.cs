// <copyright>
//     Copyright (C) 2013 ShababConquer Blog.
//     This program is free software; you can redistribute it and/or modify 
//     it under the terms of the GNU General Public License version 2 as 
//     published by the Free Software Foundation.
// 
//     This program is distributed in the hope that it will be useful, but 
//     WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//     or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License 
//     for more details.
// 
//     You should have received a copy of the GNU General Public License along 
//     with this program; if not, write to the Free Software Foundation, Inc., 
//     51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
namespace ProPharmacyManager.Database
{
    public static class DataHolder
    {
        private static string MySqlUsername, MySqlPassword, MySqlDatabase, MySqlHost;
        private static string ConnectionString;
        public static void CreateConnection(string user, string password, string database, string host)
        {
            MySqlUsername = user;
            MySqlHost = host;
            MySqlPassword = password;
            MySqlDatabase = database;
            ConnectionString = "Server=" + MySqlHost + ";Database='" + MySqlDatabase + "';Username='" + MySqlUsername + "';Password='" + MySqlPassword + "';Pooling=true; Max Pool Size = 160000; Min Pool Size = 0;CHARSET=utf8";
        }
        public static void CreateConnection(string user, string password, string host)
        {
            MySqlUsername = user;
            MySqlHost = host;
            MySqlPassword = password;
            ConnectionString = "Server=" + MySqlHost + ";Username='" + MySqlUsername + "';Password='" + MySqlPassword + "';Pooling=true; Max Pool Size = 160000; Min Pool Size = 0;CHARSET=utf8";
        }
        public static MySql.Data.MySqlClient.MySqlConnection MySqlConnection
        {
            get
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = ConnectionString;
                return conn;
            }
        }
    }
}
