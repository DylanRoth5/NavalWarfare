namespace NavalWarfareV2.Entities;

public class Ship
{
    public static int Id;
    public static int Here = 1;
    public static int XPos;
    public static int YPos;
    public static int Lenght;
    public static int Height;

    public Ship(int id, int x, int y, int lenght, int height)
    {
        Id = id;
        XPos = x;
        YPos = y;
        Lenght = lenght;
        Height = height;
    }

    public Ship(int x, int y, int lenght, int height)
    {
        XPos = x;
        YPos = y;
        Lenght = lenght;
        Height = height;
    }
}