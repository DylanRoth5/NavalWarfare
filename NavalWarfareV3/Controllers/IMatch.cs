using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;
using NavalBattle.Entities;
using NavalWarfareV3.Conection;

namespace NavalBattle.Controlers;

public interface IMatch
{
    public static List<Match> getAll()
    {
        var list = new List<Match>();
        var cmd = new SQLiteCommand("select Id, EnemyMapId, PlayerMapId, PlayerId, Finished from Match");
        cmd.Connection = Conexion.Connection;
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var item = new Match
            {
                Id = (int)(long)reader["Id"],
                EnemyMap = IMap.getAll().Where(map => map.Id == (int)(long)reader["EnemyMapId"]) as Map,
                PlayerMap = IMap.getAll().Where(map => map.Id == (int)(long)reader["PlayerMapId"]) as Map,
                Player = IUser.getAll().Where(user => user.Id == (int)(long)reader["UserId"]) as User,
                Finished = Convert.ToBoolean(reader["Finished"].ToString())
            };
            list.Add(item);
        }
        return list;
    }
    public static void save(Match item)
    {
        var cmd = new SQLiteCommand("insert into Match(EnemyMapId, PlayerMapId, PlayerId, Finished) values(@EnemyMapId, @PlayerMapId, @UserId, @Finished)");
        cmd.Parameters.Add(new SQLiteParameter("@EnemyMapId", item.EnemyMap!.Id));
        cmd.Parameters.Add(new SQLiteParameter("@PlayerMapId", item.PlayerMap!.Id));
        cmd.Parameters.Add(new SQLiteParameter("@UserId", item.Player!.Id));
        cmd.Parameters.Add(new SQLiteParameter("@Finished", item.Finished));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }

    public static void delete(Match item)
    {
        var cmd = new SQLiteCommand("delete from Match where Id = @Id");
        cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }
    public static void update(Match item)
    {
        var cmd = new SQLiteCommand("UPDATE Match SET EnemyMapId = @EnemyMapId, PlayerMapId = @PlayerMapId, PlayerId = @UserId, Finished = @Finished WHERE Id = @Id");
        cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        cmd.Parameters.Add(new SQLiteParameter("@EnemyMapId", item.EnemyMap!.Id));
        cmd.Parameters.Add(new SQLiteParameter("@PlayerMapId", item.PlayerMap!.Id));
        cmd.Parameters.Add(new SQLiteParameter("@UserId", item.Player!.Id));
        cmd.Parameters.Add(new SQLiteParameter("@Finished", item.Finished));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }
}