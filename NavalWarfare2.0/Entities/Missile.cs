namespace NavalWarfareV2.Entities;

public class Missile
{
    public static int Id;
    public static int Hit = 2;
    public static int Sunk = 3;
    public static int XPos;
    public static int YPos;

    public Missile(int id, int x,int y )
    {
        Id = id;
        XPos = x;
        YPos = y;
    }
    public Missile(int x,int y)
    {
        XPos = x;
        YPos = y;
    }
}