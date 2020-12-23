namespace SocialnetworkApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FirebirdSql.Data.FirebirdClient;
    using System.Data;

    class DB
    {
        private readonly string path;
        private FbConnection connection;
        private readonly FbConnectionStringBuilder connectionString;
        private bool isOpen;
        public DB(string _path)
        {
            path = _path;
            connectionString = new FbConnectionStringBuilder();
            isOpen = false;
        }
        ~DB()
        {
            connection.Close();
            connection.Dispose();
        }
        private void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            /*Команды обработки*/
        }
        public int Connect()
        {
            if (!isOpen)
            {
                connectionString.DataSource = "localhost";
                connectionString.Database = path;
                connectionString.UserID = "SYSDBA";
                connectionString.Password = "masterkey";
                connectionString.Role = "";
                connectionString.Dialect = 3;
                connectionString.Charset = "WIN1251";
                connection = new FbConnection(connectionString.ToString());
                connection.StateChange += new StateChangeEventHandler(
                    Connection_StateChange);
                connection.Open();
                isOpen = true;
            }
            else
            {
                return -1;
            }
            return 0;
        }
        public List<string> Query(string _text)
        {
            string sqlCommand = _text;
            FbCommand command = new FbCommand(sqlCommand, connection);
            FbDataReader reader = command.ExecuteReader();
            List<string> res = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            command.Dispose();
            return res;
        }
        private string GetCommand(string _table, List<string> _attributes, List<string> _values)
        {
            string o = "insert into ";
            o += _table;
            o += " (";
            int i = 0;
            string a;
            while (i <= _attributes.Count - 1)
            {
                a = _attributes[i];
                if (a == "NULL")
                {
                    o += "NULL";
                }
                else
                {
                    o += a;
                }
                if (i != _attributes.Count - 1)
                {
                    o += ", ";
                }
                i++;
            }
            o += ") values (";
            i = 0;
            string v;
            while (i <= _values.Count - 1)
            {
                v = _values[i];
                if (v == "NULL")
                {
                    o += "NULL";
                }
                else
                {
                    o += "'";
                    o += v;
                    o += "'";
                }
                if (i != _values.Count - 1)
                {
                    o += ", ";
                }
                i++;
            }
            o += ")";
            return o;
        }
        public int Insert(string _table, List<string> _attributes, List<string> _values)
        {
            int o = -1;
            string sqlCommand = GetCommand(_table, _attributes, _values);
            sqlCommand += ";";
            FbCommand command = new FbCommand(sqlCommand, connection);
            FbTransaction transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            o = command.ExecuteNonQuery();
            transaction.Commit();
            command.Dispose();
            return o;
        }
        public string GetIdInsert(string _table, List<string> _attributes, List<string> _values, string _returning)
        {
            string o = "";
            string sqlCommand = GetCommand(_table, _attributes, _values);
            sqlCommand += " returning " + _returning + ";";
            FbCommand command = new FbCommand(sqlCommand, connection);
            FbTransaction transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            FbDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                o += reader.GetInt32(0).ToString();
            }
            transaction.Dispose();
            //transaction.Commit();
            command.Dispose();
            return o;
        }
    }
}
