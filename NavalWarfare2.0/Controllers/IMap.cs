using NavalWarfareV2.Entities;

namespace NavalWarfareV2.Controllers;

internal interface IMap
{
    public static Map CleanMap(Map map)
    {
        for (var i = 0; i < map.Size; i++)
        for (var j = 0; j < map.Size; j++)
            map.Matrix[i, j] = Map.Water;
        return map;
    }

    public static bool isBombed(int x, int y, Map map)
    {
        return map.Matrix[x, y] == Missile.Hit || map.Matrix[x, y] == Missile.Sunk;
    }

    public static bool isOccupied(int x, int y, int length, bool horizontal, Map map)
    {
        for (var i = 0; i < length; i++)
            if (horizontal)
            {
                if (x > map.Size - length)
                    return true;
                if (map.Matrix[x + i, y] == Ship.Here)
                    return true;
            }
            else
            {
                if (y > map.Size - length)
                    return true;
                if (map.Matrix[x, y + i] == Ship.Here) return true;
            }

        return false;
    }

    public static Map placeShip(int x, int y, int lenght, bool horizontal, Map map)
    {
        if (horizontal)
            for (var i = 0; i <= map.Size - lenght; i++)
            for (var j = 0; j <= map.Size; j++)
            {
                if (x != i || y != j) continue;
                for (var k = 0; k < lenght; k++) map.Matrix[i + k, j] = Ship.Here;
            }
        else
            for (var i = 0; i <= map.Size; i++)
            for (var j = 0; j <= map.Size - lenght; j++)
            {
                if (x != i || y != j) continue;
                for (var k = 0; k < lenght; k++) map.Matrix[i, j + k] = Ship.Here;
            }

        return map;
    }

    public static Map LaunchMisile(int x, int y, Map map)
    {
        if (map.Matrix[x, y] == Ship.Here)
            map.Matrix[x, y] = Missile.Hit;
        else map.Matrix[x, y] = Missile.Sunk;
        return map;
    }

    public static bool HasShips(Map map)
    {
        for (var i = 0; i < map.Size; i++)
        for (var j = 0; j < map.Size; j++)
            if (map.Matrix[i, j] == Ship.Here)
                return true;
        return false;
    }
}