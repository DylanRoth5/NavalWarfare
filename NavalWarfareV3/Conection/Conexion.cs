﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace NavalWarfareV3.Conection
{
    internal class Conexion
    {
        public static string cadena = "Data Source=NavalWarfareDatabase.s3db";

        private static SQLiteConnection connection = new SQLiteConnection(cadena);

        public static void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        //constructor de la variable connection  
        public static SQLiteConnection Connection
        {
            set
            {
                connection = value;
            }
            get
            {
                return connection;
            }
        }
    }
}
