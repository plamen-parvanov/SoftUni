namespace _04.Photo_Gallery
{

    using System;


    public class Problem04
    {
        public static void Main()
        {

            var photoNum = short.Parse(Console.ReadLine());
            var day = byte.Parse(Console.ReadLine());
            var month = byte.Parse(Console.ReadLine());
            var year = short.Parse(Console.ReadLine());
            var hours = byte.Parse(Console.ReadLine());
            var mins = byte.Parse(Console.ReadLine());
            var sizeInBytes = int.Parse(Console.ReadLine());
            var width = short.Parse(Console.ReadLine());
            var height = short.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNum:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{mins:d2}");

            PrintSize(sizeInBytes);

            Console.WriteLine($"Resolution: {width}x{height} ({GetOrientation(width, height)})");



        }

        public static void PrintSize(int sizeInBytes)
        {
            if (sizeInBytes < 1000)
            {
                Console.WriteLine($"Size: {sizeInBytes}B");
            }
            else if (sizeInBytes < 1000000)
            {
                var size = sizeInBytes / 1000d;
                Console.WriteLine($"Size: {size}KB");
            }
            else
            {
                var size = sizeInBytes / 1000000d;
                Console.WriteLine($"Size: {size}MB");

            }

        }

        public static string GetOrientation(short w, short h)
        {
            var orientation = "square";

            if (w > h)
            {
                orientation = "landscape";
            }
            else if (w < h)
            {
                orientation = "portrait";
            }

            return orientation;
        }
    }
}
