namespace _17.Altitude
{

    using System;

    public class Problem17
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var altitude = double.Parse(inputArr[0]);
            var gotThrough = true;

            for (int i = 1; i < inputArr.Length; i += 2)
            {
                altitude = ChangeAltitude(inputArr, i, altitude);

                if (altitude < 1)
                {
                    gotThrough = false;
                    break;
                }
            }

            if (gotThrough)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }

            
        }

        public static double ChangeAltitude(string [] arr, int i, double alt)
        {
            var command = arr[i];
            var num = double.Parse(arr[i + 1]);

            if (command == "up")
            {
                alt += num;
            }
            else if (command == "down")
            {
                alt -= num;
            }

            return alt;
        }
    }
}
