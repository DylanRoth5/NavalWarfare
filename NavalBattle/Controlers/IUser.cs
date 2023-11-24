using System.Data.SQLite;
using NavalBattle.Entities;
using NavalWarfareV3.Conection;

namespace NavalWarfareV3.Controllers;

internal class IUser
{
    public static List<User> getAll()
    {
        var list = new List<User>();
        var cmd = new SQLiteCommand("select Id, Nick, Name, Password from User");
        cmd.Connection = Conexion.Connection;
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var item = new User
            {
                Id = (int)(long)reader["Id"],
                Nick = reader["Nick"].ToString()!,
                Name = reader["Name"].ToString()!,
                Password = reader["Password"].ToString()!
            };
            list.Add(item);
        }
        return list;
    }
    public static void save(User item)
    {
        var cmd = new SQLiteCommand("insert into User(Nick, Name, Password) values(@Nick, @Name, @Password)");
        cmd.Parameters.Add(new SQLiteParameter("@Nick", item.Nick));
        cmd.Parameters.Add(new SQLiteParameter("@Name", item.Name));
        cmd.Parameters.Add(new SQLiteParameter("@Password", item.Password));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }

    public static void delete(User item)
    {
        var cmd = new SQLiteCommand("delete from User where Id = @Id");
        cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }
    public static void update(User item)
    {
        var cmd = new SQLiteCommand("UPDATE Contacts SET Nick = @Nick, Name = @Name, Password = @Password WHERE Id = @Id");
        cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        cmd.Parameters.Add(new SQLiteParameter("@Nick", item.Nick));
        cmd.Parameters.Add(new SQLiteParameter("@Name", item.Name));
        cmd.Parameters.Add(new SQLiteParameter("@Password", item.Password));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }
}