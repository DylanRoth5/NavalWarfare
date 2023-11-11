namespace NavalWarfare.Entities;

public class Missile
{
    public static int Id;
    public int Skin = 2;
    public static int Skin2 = 2;
    public int XPos;
    public int YPos;

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