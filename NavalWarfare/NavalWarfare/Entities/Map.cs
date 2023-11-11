using System.Drawing;
using static System.ConsoleColor;
using static NavalWarfare.HelperSeal.Tools;

namespace NavalWarfare.Entities;

public class Map
{
    public int Id;
    public readonly static int Spot = 0;
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