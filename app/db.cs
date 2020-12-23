﻿namespace SocialnetworkApp
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
        public void Insert(string _table, List<string> _attributes, List<string> _values)
        {
            string sqlCommand = "insert into ";
            sqlCommand += _table;
            sqlCommand += " (";
            int i = 0;
            string a;
            while (i <= _attributes.Count - 1)
            {
                a = _attributes[i];
                if (a == "NULL")
                {
                    sqlCommand += "NULL";
                }
                else
                {
                    sqlCommand += a;
                }
                if (i != _attributes.Count - 1)
                {
                    sqlCommand += ", ";
                }
                i++;
            }
            sqlCommand += ") values (";
            i = 0;
            string v;
            while(i <= _values.Count - 1)
            {
                v = _values[i];
                if (v == "NULL")
                {
                    sqlCommand += "NULL";
                }
                else
                {
                    sqlCommand += "'";
                    sqlCommand += v;
                    sqlCommand += "'";
                }
                if (i != _values.Count - 1)
                {
                    sqlCommand += ", ";
                }
                i++;
            }
            sqlCommand += ");";
            FbCommand command = new FbCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}