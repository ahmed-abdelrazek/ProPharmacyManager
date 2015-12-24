using System.Collections.Generic;
using System.Text;

namespace ProPharmacyManager.Database
{
    public class MySqlCommand
    {
        private MySqlCommandType _type;

        public MySqlCommandType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        protected StringBuilder _command;

        public string Command
        {
            get { return _command.ToString(); }
            set { _command = new StringBuilder(value); }
        }

        private bool firstPart = true;

        private Dictionary<byte, string> Fields;
        private Dictionary<byte, long> longValues;
        private Dictionary<byte, ulong> ulongValues;
        private Dictionary<byte, bool> boolValues;
        private Dictionary<byte, string> stringValues;

        private byte lastpair;
        public MySqlCommand(MySqlCommandType Type)
        {
            this.Type = Type;
            switch (Type)
            {
                case MySqlCommandType.SELECT:
                    {
                        _command = new StringBuilder("SELECT * FROM <R>");
                        break;
                    }
                case MySqlCommandType.UPDATE:
                    {
                        _command = new StringBuilder("UPDATE <R> SET ");
                        break;
                    }
                case MySqlCommandType.INSERT:
                    {
                        Fields = new Dictionary<byte, string>(20);
                        longValues = new Dictionary<byte, long>(20);
                        ulongValues = new Dictionary<byte, ulong>(20);
                        boolValues = new Dictionary<byte, bool>(20);
                        stringValues = new Dictionary<byte, string>(20);
                        lastpair = 0;
                        _command = new StringBuilder("INSERT INTO <R> (<F>) VALUES (<V>)");
                        break;
                    }
                case MySqlCommandType.DELETE:
                    {
                        _command = new StringBuilder("DELETE FROM <R> WHERE <C> = <V>");
                        break;
                    }
                case MySqlCommandType.COUNT:
                    {
                        _command = new StringBuilder("SELECT count(<V>) FROM <R>");
                        break;
                    }
                case MySqlCommandType.CLEAR:
                    {
                        _command = new StringBuilder("DELETE FROM <R>");
                        break;
                    }
            }
        }
        #region Select
        /// <summary> 
        /// select table
        /// </summary> 
        /// <param name="table">table name</param>
        public MySqlCommand Select(string table)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            return this;
        }
        #endregion
        #region Clear
        /// <summary> 
        /// clear table content
        /// </summary> 
        /// <param name="table">table name</param>
        public MySqlCommand Clear(string table)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            return this;
        }
        #endregion
        #region Count
        /// <param name="table">table name</param>
        public MySqlCommand Count(string table)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            return this;
        }
        #endregion
        #region Delete
        /// <summary> 
        /// delete string
        /// </summary> 
        /// <param name="table">table name</param>
        /// <param name="column">column name</param>
        /// <param name="value">string value</param>
        public MySqlCommand Delete(string table, string column, string value)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            _command = _command.Replace("<C>", "`" + column + "`");
            _command = _command.Replace("<V>", "'" + value + "'");
            return this;
        }
        /// <summary> 
        /// delete long
        /// </summary> 
        /// <param name="table">table name</param>
        /// <param name="column">column name</param>
        /// <param name="value">long value</param>
        public MySqlCommand Delete(string table, string column, long value)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            _command = _command.Replace("<C>", "`" + column + "`");
            _command = _command.Replace("<V>", value.ToString());
            return this;
        }
        /// <summary> 
        /// delete ulong
        /// </summary> 
        /// <param name="table">table name</param>
        /// <param name="column">column name</param>
        /// <param name="value">ulong value</param>
        public MySqlCommand Delete(string table, string column, ulong value)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            _command = _command.Replace("<C>", "`" + column + "`");
            _command = _command.Replace("<V>", value.ToString());
            return this;
        }
        /// <summary> 
        /// delete bool
        /// </summary> 
        /// <param name="table">table name</param>
        /// <param name="column">column name</param>
        /// <param name="value">bool value</param>
        public MySqlCommand Delete(string table, string column, bool value)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            _command = _command.Replace("<C>", "`" + column + "`");
            _command = _command.Replace("<V>", (value ? "1" : "0"));
            return this;
        }
        #endregion

        private bool Comma()
        {
            if (firstPart)
            {
                firstPart = false;
                return false;
            }
            string command = _command.ToString();
            if (command[command.Length - 1] == ',' || command[command.Length - 2] == ',' || command[command.Length - 3] == ',')
                return false;
            return true;
        }

        #region Update
        /// <summary> 
        /// update table
        /// </summary> 
        /// <param name="table">table name</param>
        public MySqlCommand Update(string table)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            return this;
        }
        public MySqlCommand Set(string column, long value)
        {
            if (Type == MySqlCommandType.UPDATE)
            {
                if (Comma())
                    _command = _command.Append(",`" + column + "` = " + value.ToString() + " ");
                else
                    _command = _command.Append("`" + column + "` = " + value.ToString() + " ");
            }
            return this;
        }
        public MySqlCommand Set(string column, ulong value)
        {
            if (Type == MySqlCommandType.UPDATE)
            {
                bool comma = false;
                comma = (_command[_command.Length - 1] == ',' || _command[_command.Length - 2] == ',' || _command[_command.Length - 3] == ',') ? false : true;
                if (Comma())
                    _command = _command.Append(",`" + column + "` = " + value.ToString() + " ");
                else
                    _command = _command.Append("`" + column + "` = " + value.ToString() + " ");
            }
            return this;
        }
        public MySqlCommand Set(string column, string value)
        {
            if (Type == MySqlCommandType.UPDATE)
            {
                if (Comma())
                    _command = _command.Append(",`" + column + "` = '" + value + "' ");
                else
                    _command = _command.Append("`" + column + "` = '" + value + "' ");
            }
            return this;
        }
        public MySqlCommand Set(string column, bool value)
        {
            if (Type == MySqlCommandType.UPDATE)
            {
                if (Comma())
                    _command = _command.Append(",`" + column + "` = " + (value ? "1" : "0") + " ");
                else
                    _command = _command.Append("`" + column + "` = " + (value ? "1" : "0") + " ");
            }
            return this;
        }
        #endregion

        #region Insert
        /// <summary> 
        /// add information to tables
        /// </summary> 
        /// <param name="table">table name</param>
        public MySqlCommand Insert(string table)
        {
            _command = _command.Replace("<R>", "`" + table + "`");
            return this;
        }
        /// <summary> 
        /// add long value to a column
        /// </summary> 
        /// <param name="field">column name</param>
        /// <param name="value">long value</param>
        public MySqlCommand Insert(string field, long value)
        {
            Fields.Add(lastpair, field);
            longValues.Add(lastpair, value);
            lastpair++;
            return this;
        }
        /// <summary> 
        /// add ulong value to a column
        /// </summary> 
        /// <param name="field">column name</param>
        /// <param name="value">ulong value</param>
        public MySqlCommand Insert(string field, ulong value)
        {
            Fields.Add(lastpair, field);
            ulongValues.Add(lastpair, value);
            lastpair++;
            return this;
        }
        /// <summary> 
        /// add bool value to a column
        /// </summary> 
        /// <param name="field">column name</param>
        /// <param name="value">bool value</param>
        public MySqlCommand Insert(string field, bool value)
        {
            Fields.Add(lastpair, field);
            boolValues.Add(lastpair, value);
            lastpair++;
            return this;
        }
        /// <summary> 
        /// add string value to a column
        /// </summary> 
        /// <param name="field">column name</param>
        /// <param name="value">string value</param>
        public MySqlCommand Insert(string field, string value)
        {
            Fields.Add(lastpair, field);
            stringValues.Add(lastpair, value);
            lastpair++;
            return this;
        }
        #endregion

        #region Where
        /// <summary> 
        /// compare long between two values column value = new value
        /// </summary> 
        /// <param name="column">column name</param>
        /// <param name="value">long value</param>
        public MySqlCommand Where(string column, long value)
        {
            _command = _command.Append("WHERE `" + column + "` = " + value);
            return this;
        }
        /// <summary> 
        /// compare long between two values column value > new value true else false
        /// </summary> 
        /// <param name="column">column name</param>
        /// <param name="value">long value</param>
        public MySqlCommand Where(string column, long value, bool greater)
        {
            if (greater)
                _command = _command.Append("WHERE `" + column + "` > " + value);
            else
                _command = _command.Append("WHERE `" + column + "` < " + value);
            return this;
        }
        /// <summary> 
        /// compare ulong between two values column value = new value
        /// </summary> 
        /// <param name="column">column name</param>
        /// <param name="value">ulong value</param>
        public MySqlCommand Where(string column, ulong value)
        {
            _command = _command.Append("WHERE `" + column + "` = " + value);
            return this;
        }
        /// <summary> 
        /// compare string between two values column value = new value
        /// </summary> 
        /// <param name="column">column name</param>
        /// <param name="value">string value</param>
        public MySqlCommand Where(string column, string value)
        {
            _command = _command.Append("WHERE `" + column + "` = '" + value + "'");
            return this;
        }
        /// <summary> 
        /// compare bool between two values column value = new value
        /// </summary> 
        /// <param name="column">column name</param>
        /// <param name="value">bool value</param>
        public MySqlCommand Where(string column, bool value)
        {
            _command = _command.Append("WHERE `" + column + "` = " + (value ? "1" : "0"));
            return this;
        }
        #endregion

        
        
        #region And
        public MySqlCommand And(string column, long value)
        {
            _command = _command.Append(" AND `" + column + "` = " + value);
            return this;
        }
        public MySqlCommand And(string column, long value, bool greater)
        {
            if (greater)
                _command = _command.Append("AND `" + column + "` > " + value);
            else
                _command = _command.Append("AND `" + column + "` < " + value);
            return this;
        }
        public MySqlCommand And(string column, ulong value)
        {
            _command = _command.Append(" AND `" + column + "` = " + value);
            return this;
        }
        public MySqlCommand And(string column, string value)
        {
            _command = _command.Append(" AND `" + column + "` = '" + value + "'");
            return this;
        }
        public MySqlCommand And(string column, bool value)
        {
            _command = _command.Append(" AND `" + column + "` = " + (value ? "1" : "0"));
            return this;
        }
        #endregion

        #region Or
        public MySqlCommand Or(string column, long value)
        {
            _command = _command.Append(" Or `" + column + "` = " + value);
            return this;
        }
        public MySqlCommand Or(string column, ulong value)
        {
            _command = _command.Append(" Or `" + column + "` = " + value);
            return this;
        }
        public MySqlCommand Or(string column, string value)
        {
            _command = _command.Append(" Or `" + column + "` = '" + value + "'");
            return this;
        }
        public MySqlCommand Or(string column, bool value)
        {
            _command = _command.Append(" Or `" + column + "` = " + (value ? "1" : "0"));
            return this;
        }
        #endregion

        #region Order
        public MySqlCommand Order(string column)
        {
            _command = _command.Append("ORDER BY " + column + "");
            return this;
        }
        public MySqlCommand Order(string column, bool Desc)
        {
            if (Desc)
                _command = _command.Append("ORDER BY " + column + " DESC");
            else
                _command = _command.Append("ORDER BY " + column + "");
            return this;
        }
        #endregion

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public int Execute()
        {
            if (Type == MySqlCommandType.INSERT)
            {
                string fields = "";
                string values = "";
                byte x;
                for (x = 0; x < lastpair; x++)
                {
                    bool comma = (x + 1) == lastpair ? false : true;
                    #region Fields
                    if (comma)
                        fields += Fields[x] + ",";
                    else
                        fields += Fields[x];
                    #endregion
                    #region Values
                    if (longValues.ContainsKey(x))
                    {
                        if (comma)
                            values += longValues[x].ToString() + ",";
                        else
                            values += longValues[x].ToString();
                    }
                    else if (ulongValues.ContainsKey(x))
                    {
                        if (comma)
                            values += ulongValues[x].ToString()[x] + ",";
                        else
                            values += ulongValues[x].ToString();
                    }
                    else if (boolValues.ContainsKey(x))
                    {
                        if (comma)
                            values += (boolValues[x] ? "1" : "0") + ",";
                        else
                            values += (boolValues[x] ? "1" : "0");
                    }
                    else if (stringValues.ContainsKey(x))
                    {
                        if (comma)
                            values += "'" + stringValues[x] + "'" + ",";
                        else
                            values += "'" + stringValues[x] + "'";
                    }
                    #endregion
                }
                _command = _command.Replace("<F>", fields);
                _command = _command.Replace("<V>", values);
            }
            int res = 0;
            using (var conn = Database.DataHolder.MySqlConnection)
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(this.Command, conn);
                res = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return res;
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public int Execute(MySql.Data.MySqlClient.MySqlConnection conn)
        {
            if (Type == MySqlCommandType.INSERT)
            {
                string fields = "";
                string values = "";
                byte x;
                for (x = 0; x < lastpair; x++)
                {
                    bool comma = (x + 1) == lastpair ? false : true;
                    #region Fields
                    if (comma)
                        fields += Fields[x] + ",";
                    else
                        fields += Fields[x];
                    #endregion
                    #region Values
                    if (longValues.ContainsKey(x))
                    {
                        if (comma)
                            values += longValues[x].ToString() + ",";
                        else
                            values += longValues[x].ToString();
                    }
                    else if (ulongValues.ContainsKey(x))
                    {
                        if (comma)
                            values += ulongValues[x].ToString()[x] + ",";
                        else
                            values += ulongValues[x].ToString();
                    }
                    else if (boolValues.ContainsKey(x))
                    {
                        if (comma)
                            values += (boolValues[x] ? "1" : "0") + ",";
                        else
                            values += (boolValues[x] ? "1" : "0");
                    }
                    else if (stringValues.ContainsKey(x))
                    {
                        if (comma)
                            values += "'" + stringValues[x] + "'" + ",";
                        else
                            values += "'" + stringValues[x] + "'";
                    }
                    #endregion
                }
                _command = _command.Replace("<F>", fields);
                _command = _command.Replace("<V>", values);
            }
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(Command, conn);
            return cmd.ExecuteNonQuery();
        }
    }
    public enum MySqlCommandType
    {
        DELETE, INSERT, SELECT, UPDATE, COUNT, CLEAR
    }

}
