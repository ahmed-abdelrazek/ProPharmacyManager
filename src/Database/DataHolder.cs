
namespace PharmacyProManager.Database
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
