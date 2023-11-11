namespace NavalWarfare.Entities;

public class Map
{
    public static int Id;
    public static int Water = 0;
    public int[,] Matrix;
    public int Size;

    public Map(int id,int size)
    {
        Id = id;
        Size = size;
        Matrix = new int[Size, Size];
    }
    public Map(int size)
    {
        Size = size;
        Matrix = new int[Size, Size];
    }
}