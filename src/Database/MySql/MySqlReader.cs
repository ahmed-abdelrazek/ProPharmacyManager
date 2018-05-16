using System;
using System.Data;
using MySql.Data.MySqlClient;
using PharmacyProManager;
using System.Windows.Forms;

namespace PharmacyPRO.Database
{
    public class MySqlReader
    {
         //private MySqlDataReader Reader = null;
        //  const string Table = "table";
        private MySql.Data.MySqlClient.MySqlConnection _conn = DataHolder.MySqlConnection;
        private DataRow _datarow;
        private DataSet _dataset;
        private int _row;
        const string Table = "table";

        public MySqlReader(MySqlCommand command)
        {
            if (command.Type == MySqlCommandType.SELECT)
            {
                TryFill(command);
            }
        }
        private MySql.Data.MySqlClient.MySqlConnection SelectConnection()
        {
            return DataHolder.MySqlConnection;
        }
        private string _lasterror = null;
        public string LastError
        {
            get
            {
                return _lasterror;
            }
            set
            {
                _lasterror = value;
            }
        }
        private void TryFill(MySqlCommand command)
        {
            MySql.Data.MySqlClient.MySqlConnection connection = SelectConnection();
            MySqlDataAdapter DataAdapter = null;
            if (connection.State == ConnectionState.Open)
            {
                while (_dataset == null && (_lasterror == null || _lasterror.Contains("connection")))
                {
                    if (_lasterror != null && _lasterror.Contains("connection"))
                        connection = SelectConnection();
                    DataAdapter = new MySqlDataAdapter(command.Command, connection);
                    _dataset = new DataSet();
                    try
                    {
                        DataAdapter.Fill(_dataset, Table);
                    }
                    catch (MySql.Data.MySqlClient.MySqlException e)
                    {
                        _lasterror = e.ToString().ToLower();
                        _dataset = null;
                        continue;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        break;
                    }
                    _row = 0;
                }
            }
            using (MySql.Data.MySqlClient.MySqlConnection conn = SelectConnection())
            {
                conn.Open();
                DataAdapter = new MySqlDataAdapter(command.Command, connection);
                _dataset = new DataSet();
                try
                {
                    DataAdapter.Fill(_dataset, Table);
                }
                catch (MySql.Data.MySqlClient.MySqlException e)
                {
                    _lasterror = e.ToString().ToLower();
                    _dataset = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                _row = 0;
                conn.Close();
            }
        }
        public bool Read()
        {
            if (_dataset.Tables[Table].Rows.Count > _row)
            {
                _datarow = _dataset.Tables[Table].Rows[_row];
                _row++;
                return true;
            }
            _row++;
            return false;
        }
        public void Dispose()
        {
            if (_conn.State != ConnectionState.Closed)
                _conn.Close();
            _conn.Dispose();
            //Reader = null;
            _conn = null;
        }
        public void Close()
        {
            // Reader.Close();
            //SqlConnection.ClearAllPools();
        }
        public sbyte ReadSByte(string columnName)
        {
            sbyte result = 0;
            //    try
            //    {
            sbyte.TryParse(_datarow[columnName].ToString(), out result);
            //    }
            //    catch { }
            return result;
        }
        public byte ReadByte(string columnName)
        {
            byte result = 0;
            //   try
            //   {
            byte.TryParse(_datarow[columnName].ToString(), out result);
            //   }
            //    catch { }
            return result;
        }
        public short ReadInt16(string columnName)
        {
            short result = 0;
            //  try
            //  {
            short.TryParse(_datarow[columnName].ToString(), out result);
            //   }
            //   catch { }
            return result;
        }
        public ushort ReadUInt16(string columnName)
        {
            ushort result = 0;
            //  try
            //  {
            ushort.TryParse(_datarow[columnName].ToString(), out result);
            //  }
            //   catch { }
            return result;
        }
        public int ReadInt32(string columnName)
        {
            int result = 0;
            //  try
            //  {
            int.TryParse(_datarow[columnName].ToString(), out result);
            //  }
            //  catch { }
            return result;
        }
        public uint ReadUInt32(string columnName)
        {
            uint result = 0;
            // try
            // {
            uint.TryParse(_datarow[columnName].ToString(), out result);
            //  }
            //  catch { }
            return result;
        }
        public long ReadInt64(string columnName)
        {
            long result = 0;
            //  try
            //  {
            long.TryParse(_datarow[columnName].ToString(), out result);
            //  }
            //  catch { }
            return result;
        }
        public ulong ReadUInt64(string columnName)
        {
            ulong result = 0;
            // try
            // {
            ulong.TryParse(_datarow[columnName].ToString(), out result);
            // }
            // catch { }
            return result;
        }
        public string ReadString(string columnName)
        {
            string result = "";
            // try
            // {
            result = _datarow[columnName].ToString();
            // }
            // catch { }
            return result;
        }
        public bool ReadBoolean(string columnName)
        {
            bool result = false;
            // try
            // {
            string str = _datarow[columnName].ToString();
            if (str[0] == '1') return true;
            if (str[0] == '0') return false;

            bool.TryParse(_datarow[columnName].ToString(), out result);
            // }
            //  catch 
            //  {
            //      byte value = 0;
            //      try
            //      {
            //          byte.TryParse(_datarow[columnName].ToString(), out value);
            //      }
            //      catch { }
            //      result = value == 0 ? false : true; 
            //  }
            return result;
        }

    }
}