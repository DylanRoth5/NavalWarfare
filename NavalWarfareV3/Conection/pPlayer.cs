using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavalWarfareV3.Entities;

namespace NavalWarfareV3.Conection
{
    internal class pPlayer
    {
        public static List<Player> GetAll()
        {
            List<Player> players = new List<Player>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT PL_ID, PL_NAME, PL_PASSWORD FROM PLAYER");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Player a = new Player();
                a.Id = obdr.GetInt32(0);
                a.User = obdr.GetString(2);
                a.Password = obdr.GetString(3);


                players.Add(a);
            }
            return players;
        }

        public static Player GetByUsername(string username)
        {
            Player a = new Player();
            SQLiteCommand cmd = new SQLiteCommand("SELECT PL_ID, PL_NAME, PL_PASSWORD FROM PLAYER Where PL_NAME =  @user");
            cmd.Parameters.Add(new SQLiteParameter("@user", username));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {

                a.Id = obdr.GetInt32(0);
                a.User = obdr.GetString(2);
                a.Password = obdr.GetString(3);
            }
            return a;
        }

        public static Player GetById(int id)
        {
            Player a = new Player();
            SQLiteCommand cmd = new SQLiteCommand("SELECT PL_ID, PL_NAME, PL_PASSWORD FROM PLAYER Where PL_ID =  @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {

                a.Id = obdr.GetInt32(0);
                a.User = obdr.GetString(2);
                a.Password = obdr.GetString(3);
            }
            return a;
        }

        public static void Insert(Player u)
        {
            SQLiteCommand cmd = new SQLiteCommand("Insert Into PLAYER(PL_NAME, PL_PASSWORD) VALUES (@user, @password)");
            cmd.Parameters.Add(new SQLiteParameter("@user", u.User));
            cmd.Parameters.Add(new SQLiteParameter("@password", u.Password));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
