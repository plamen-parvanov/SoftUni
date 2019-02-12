using System;

namespace _01.ClassBox
{
    public class Box
    {
        private double length;

        private double width;

        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                CheckValidSide(value, nameof(this.Length));

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                CheckValidSide(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                CheckValidSide(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            var surfaceArea = 2 * this.length * this.width
                            + 2 * this.length * this.height
                            + 2 * this.width * this.height;

            return surfaceArea;
        }

        public double CalculateLateralSurfaceArea()
        {
            var lateralSurfaceArea = 2 * this.length * this.height
                                   + 2 * this.width * this.height;

            return lateralSurfaceArea;
        }

        public double CalculateVolume()
        {
            var volume = this.length * this.width * this.height;

            return volume;
        }

        private static void CheckValidSide(double side, string name)
        {
            if (side <= 0)
            {
                throw new ArgumentException(
                    string.Format(Error.InvalidArgument, name));
            }
        }
    }
}
