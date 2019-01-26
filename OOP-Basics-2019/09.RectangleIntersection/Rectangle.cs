namespace DefiningClasses
{
   public class Rectangle
    {
        private double width;
        private double height;
        private Point topLeftCorner;

        public Rectangle(string id, double width, double height, Point topLeftCorner)
        {
            this.Id = id;
            this.width = width;
            this.height = height;
            this.topLeftCorner = topLeftCorner;
        }

        public string Id { get; private set; }

        public bool IsRectangleIntersectWith(Rectangle rectagle)
        {
            var vertical =
                rectagle.topLeftCorner.PointY - rectagle.height <= this.topLeftCorner.PointY &&
                rectagle.topLeftCorner.PointY >= this.topLeftCorner.PointY - this.height;

            var horisontal =
                rectagle.topLeftCorner.PointX + rectagle.width >= this.topLeftCorner.PointX &&
                rectagle.topLeftCorner.PointX <= this.topLeftCorner.PointX + this.width;

            return vertical && horisontal;
        }
    }
}
