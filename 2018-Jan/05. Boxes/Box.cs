public class Box
{
    private Point upperLeft;
    private Point upperRight;
    private Point bottomLeft;
    private Point bottomRight;

    public Box(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
    {
        this.upperLeft = upperLeft;
        this.upperRight = upperRight;
        this.bottomLeft = bottomLeft;
        this.bottomRight = bottomRight;
    }

    public static double CalculatePerimeter(double width, double height)
    {
        return (2 * width + 2 * height);
    }

    public static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    public Point UpperLeft
    {
        get { return this.upperLeft; }
    }
    public Point UpperRight
    {
        get { return this.upperRight; }
    }
    public Point BottomLeft
    {
        get { return this.bottomLeft; }
    }
    public Point BottomRight
    {
        get { return this.bottomRight; }
    }
}

