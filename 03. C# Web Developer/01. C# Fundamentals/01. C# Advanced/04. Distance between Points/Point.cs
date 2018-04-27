using System;

class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static double CalculateDistenceBetweenTwoPoints(Point firstPoint, Point secondPoint)
    {         
        var x1 = firstPoint.X;
        var x2 = secondPoint.X;
        var y1 = firstPoint.Y;
        var y2 = secondPoint.Y;

        //sqrt ot (x1 - x2)^2 + (y1 - y2)^2 
        var result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        return result;
    }

    public int X
    {
        get { return this.x; }
    }

    public int Y
    {
        get { return this.y; }
    }
}

