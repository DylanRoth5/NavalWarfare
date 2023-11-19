using System.Data.SQLite;

namespace NavalWarfareV3.Conection
{
    class Conexion
    {
        private const string Cadena = "Data Source=Navy.db";

        public static void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }

        //constructor de la variable connection  
        private static SQLiteConnection Connection { get; } = new (Cadena);
    }

}
