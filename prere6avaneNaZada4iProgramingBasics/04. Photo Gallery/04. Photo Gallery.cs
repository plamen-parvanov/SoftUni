using System;


namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            decimal sizeInBytes = decimal.Parse(Console.ReadLine());
            int width =int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}",
                day, month, year, hours, minutes);

            string sizeType = "B";
                 
            if (sizeInBytes >= 1000000)
            {
                sizeInBytes /= 1000000;
                sizeType = "MB"; 
            }
            else if (sizeInBytes >= 1000)
            {
                sizeInBytes /= 1000;
                sizeType = "KB";
            }

            Console.WriteLine("Size: {0}{1}", sizeInBytes, sizeType);

            string orientation = "portrait";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width == height)
            {
                orientation = "square";
            }

            Console.WriteLine("Resolution: {0}x{1} ({2})",
                width, height, orientation);

                   
        }
    }
}
