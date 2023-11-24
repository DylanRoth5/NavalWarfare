namespace NavalBattle.Entities;

public class Match
{
    public int Id;
    public Map? EnemyMap;
    public Map? PlayerMap;
    public User? Player;
    public bool Finished;
}