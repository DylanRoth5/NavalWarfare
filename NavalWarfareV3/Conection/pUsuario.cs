using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Entidades;
using System.Data.SQLite;

namespace NavalWarfareV3.Conection
{
    internal class pUsuario
    {
        public static List<Usuario> GetAll()
        {
            var usuarios = new List<Usuario>();
            var cmd = new SQLiteCommand("SELECT id, username, password, name FROM Users");
            cmd.Connection = Conexion.Connection;
            var obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                var a = new Usuario();
                a.Id = obdr.GetInt32(0);
                a.NombreUsuario = obdr.GetString(1);
                a.Clave = obdr.GetString(2);
                a.Nombre = obdr.GetString(3);


                usuarios.Add(a);
            }
            return usuarios;
        }

        public static Usuario GetById(int id)
        {
            var a = new Usuario();
            var cmd = new SQLiteCommand("SELECT id, username, password, name FROM Users Where id =  @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            var obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                
                a.Id = obdr.GetInt32(0);
                a.NombreUsuario = obdr.GetString(1);
                a.Clave = obdr.GetString(2);
                a.Nombre = obdr.GetString(3);
            }
            return a;
        }

        public static Usuario GetByUsername(string username)
        {
            var a = new Usuario();
            var cmd = new SQLiteCommand("SELECT id, username, password, name FROM Users Where username = @username");
            cmd.Parameters.Add(new SQLiteParameter("@username", username));
            cmd.Connection = Conexion.Connection;
            var obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                a.Id = obdr.GetInt32(0);
                a.NombreUsuario = obdr.GetString(1);
                a.Clave = obdr.GetString(2);
                a.Nombre = obdr.GetString(3);
            }
            return a;
        }

        public static void Insert(Usuario u)
        { 
            var cmd = new SQLiteCommand("Insert Into Users(username, password, name) VALUES (@nombreusuario, @clave, @nombre)");
            cmd.Parameters.Add(new SQLiteParameter("@nombreusuario", u.NombreUsuario));
            cmd.Parameters.Add(new SQLiteParameter("@clave", u.Clave));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", u.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
