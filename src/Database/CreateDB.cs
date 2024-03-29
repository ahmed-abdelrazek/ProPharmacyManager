﻿// <copyright>
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
using MySql.Data.MySqlClient;

namespace ProPharmacyManager.Database
{
    public class CreateDB
    {
        /// <summary> 
        /// The database name that app create at first run
        /// </summary> 
        /// <param name="dbname">Database name</param> 
        public static void Createdb(string dbname)
        {
            string db1 = "CREATE DATABASE IF NOT EXISTS `" + dbname + "`;";
            using (var conn = DataHolder.MySqlConnection)
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    string db = QueryExpress.ExecuteScalarStr(cmd, db1);
                    if (string.IsNullOrEmpty(db))
                    {
                        return;
                    }
                    conn.Close();
                }
            }
        }
        /// <summary> 
        /// when user change the database name from setting
        /// </summary> 
        /// <param name="odbname">old Database name</param> 
        /// <param name="ndbname">new Database name</param> 
        public static void Createdb(string odbname, string ndbname)
        {
            string db1 = "DROP DATABASE IF EXISTS `" + odbname + "`;CREATE DATABASE IF NOT EXISTS `" + ndbname + "`;";
            using (var conn = DataHolder.MySqlConnection)
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    string db = QueryExpress.ExecuteScalarStr(cmd, db1);
                    if (string.IsNullOrEmpty(db))
                    {
                        return;
                    }
                    conn.Close();
                }
            }
        }
        /// <summary> 
        /// create tables if they don't exist at first run
        /// </summary> 
        public static void CreateTables()
        {
            const string accountst =
                "CREATE TABLE IF NOT EXISTS `accounts` (`Username` varchar(16) NOT NULL,`Password` text NOT NULL,`State` tinyint(5) unsigned NOT NULL,`Phone` varchar(100) DEFAULT NULL,`LastCheck` bigint(255) unsigned DEFAULT NULL,PRIMARY KEY (`Username`)) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
            const string bills =
                "CREATE TABLE IF NOT EXISTS `bills` (`ID` int(20) NOT NULL AUTO_INCREMENT,`Name` varchar(100) DEFAULT NULL,`User` varchar(100) DEFAULT NULL,`Medic` text,`BillDate` varchar(100) DEFAULT NULL,PRIMARY KEY (`ID`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;";
            const string logs =
                "CREATE TABLE IF NOT EXISTS `logs` (`Account` varchar(255) NOT NULL,`LoginDate` varchar(30) NOT NULL,`LogoutDate` varchar(30) DEFAULT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
            const string medics =
                "CREATE TABLE IF NOT EXISTS `medics` (`Name` varchar(50) NOT NULL,`Substance` varchar(50) NOT NULL,`Expiry` varchar(10) NOT NULL DEFAULT '0',`Type` tinyint(5) unsigned NOT NULL DEFAULT '0',`Note` varchar(500) DEFAULT NULL,`Count` bigint(18) NOT NULL DEFAULT '0',`Price` varchar(18) NOT NULL DEFAULT '0',PRIMARY KEY (`Name`)) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
            const string medlog =
                "CREATE TABLE IF NOT EXISTS `medlog` (`Name` varchar(50) NOT NULL,`SellDate` varchar(20) NOT NULL DEFAULT '0',`Total` decimal(15,0) NOT NULL DEFAULT '0',`Cost` varchar(15) NOT NULL DEFAULT '0') ENGINE=InnoDB DEFAULT CHARSET=utf8;";
            using (var conn = DataHolder.MySqlConnection)
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    QueryExpress.ExecuteScalarStr(cmd, accountst + bills + logs + medics + medlog);
                    conn.Close();
                }
            }
        }
        /// <summary> 
        /// upgrade tables after make changes to them
        /// </summary> 
        public static void UpgradeTables()
        {
            const string accountst = "ALTER TABLE `accounts` CHANGE `Password` `Password` TEXT CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL; ";
            using (var conn = DataHolder.MySqlConnection)
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    QueryExpress.ExecuteScalarStr(cmd, accountst);
                    conn.Close();
                }
            }
        }
    }
}