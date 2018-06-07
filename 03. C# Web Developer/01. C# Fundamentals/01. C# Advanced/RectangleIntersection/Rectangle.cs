public class Rectangle
{
    public string id;
    public double width;
    public double height;
    public Point topLeftPoint;

    public Rectangle(string id, double width, double height,
        double topLeftPointX,double topLeftPointY)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.topLeftPoint = new Point(topLeftPointX, topLeftPointY);
    }

    public bool CheckIfRectanglesIntersect(Rectangle rectangle)
    {
        var x1 = this.topLeftPoint.x;
        var x2 = x1 + this.width;
        var y2 = this.topLeftPoint.y;
        var y1 = y2 - this.height;

        var x3 = rectangle.topLeftPoint.x;
        var x4 = x3 + rectangle.width;
        var y4 = rectangle.topLeftPoint.y;
        var y3 = y4 - rectangle.height;
        
        return (x4 >= x1 && x3 <= x2) && (y4 >= y1 && y3 <= y2);
    }
}
