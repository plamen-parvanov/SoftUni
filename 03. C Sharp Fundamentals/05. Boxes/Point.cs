using System;

public class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static double CalculateDistance(Point point1, Point point2)
    {
        var x1 = point1.X;
        var x2 = point2.X;
        var y1 = point1.Y;
        var y2 = point2.Y;

        //sqrt ot (x1 - x2)^2 + (y1 - y2)^2 
        var result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        return result;
    }

    public double X
    {
        get { return this.x; }
    }
    public double Y
    {
        get { return this.y; }
    }
}

