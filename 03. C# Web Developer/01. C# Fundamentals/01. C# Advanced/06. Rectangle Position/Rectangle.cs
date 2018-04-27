public class Rectangle
{
    private Point leftBottom;
    private Point leftTop;
    private Point rightBottom;
    private Point rightTop;

    public Rectangle(Point leftBottom, Point leftTop, Point rightBottom, Point rightTop)
    {
        this.leftBottom = leftBottom;
        this.leftTop = leftTop;
        this.rightBottom = rightBottom;
        this.rightTop = rightTop;
    }

    public Point LeftBottom
    {
        get { return this.leftBottom; }
    }
    public Point LeftTop
    {
        get { return this.leftTop; }
    }
    public Point RightBottom
    {
        get { return this.rightBottom; }
    }
    public Point RightTop
    {
        get { return this.rightTop; }
    }
}
