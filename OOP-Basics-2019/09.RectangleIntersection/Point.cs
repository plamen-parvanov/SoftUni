namespace DefiningClasses
{
    public class Point
    {
        public double PointX { get; private set; }

        public double PointY { get; private set; }

        public Point(double pointX, double pointY)
        {
            this.PointX = pointX;
            this.PointY = pointY;
        }
    }
}
