namespace NavalWarfare2._0.Entities;

public class Missile
{
    public static int Id;
    public const int Hit = 2;
    public const int Sunk = 3;
    public static int XPos;
    public static int YPos;

    public Missile(int id, int x, int y)
    {
        Id = id;
        XPos = x;
        YPos = y;
    }

    public Missile(int x, int y)
    {
        XPos = x;
        YPos = y;
    }
}