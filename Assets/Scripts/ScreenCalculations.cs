using UnityEngine;

public static class ScreenCalculations
{
    public static WorldBorders GetScreenToWorldPositions()
    {
        var upperRightScreen = new Vector3(Screen.width, Screen.height, 0);
        var lowerLeftScreen = new Vector3(0, 0, 0);

        Vector2 upperRight = Camera.main.ScreenToWorldPoint(upperRightScreen);
        Vector2 lowerLeft = Camera.main.ScreenToWorldPoint(lowerLeftScreen);

        WorldBorders result = new WorldBorders(lowerLeft.x, lowerLeft.y, upperRight.x, upperRight.y);

        return result;
    }
}

public struct WorldBorders
{
    public readonly float minX;
    public readonly float minY;
    public readonly float maxX;
    public readonly float maxY;

    public WorldBorders(float minX, float minY, float maxX, float maxY)
    {
        this.minX = minX;
        this.minY = minY;
        this.maxX = maxX;
        this.maxY = maxY;
    }
}
