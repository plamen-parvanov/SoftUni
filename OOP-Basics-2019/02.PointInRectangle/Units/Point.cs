namespace _02.PointInRectangle.Units
{
    public class Point
    {
        public Point(int pointX, int pointY)
        {
            this.PointX = pointX;
            this.PointY = pointY;
        }

        public int PointX { get; private set; }

        public int PointY { get; private set; }
    }
}
