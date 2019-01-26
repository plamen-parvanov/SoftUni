namespace _02.PointInRectangle.Units
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.ToplLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public Point ToplLeft { get; private set; }

        public Point BottomRight { get; private set; }

        public bool Contains(Point point)
        {
            var horizontal = point.PointX >= this.ToplLeft.PointX &&
                             point.PointX <= this.BottomRight.PointX;

            var vertical = point.PointY <= this.ToplLeft.PointY &&
                           point.PointY >= this.BottomRight.PointY;

            return horizontal && vertical;
        }
    }
}
