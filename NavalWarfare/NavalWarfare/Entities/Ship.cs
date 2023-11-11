namespace NavalWarfare.Entities;

public class Ship
{
    public static int Id;
    public int Skin = 1;
    public static int Skin2 = 1;
    public int XPos;
    public int YPos;
    public int Lenght;
    public int Height;

    public Ship(int id, int x,int y, int lenght, int height)
    {
        Id = id;
        XPos = x;
        YPos = y;
        Lenght = lenght;
        Height = height;
    }
    public Ship(int x,int y, int lenght, int height)
    {
        XPos = x;
        YPos = y;
        Lenght = lenght;
        Height = height;
    }
}