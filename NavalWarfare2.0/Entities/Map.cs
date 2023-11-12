namespace NavalWarfare2._0.Entities;

public class Map
{
    public static int Id;
    public const int Water = 0;
    public int[,] Matrix;
    public int Size;

    public Map(int id, int size)
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