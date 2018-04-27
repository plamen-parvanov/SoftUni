namespace _18.Ballistics_Training
{

    using System;

    public class Problem18
    {

        public static void Main()
        {
            var coordinatesOfPlane = InitializeCoordinatesArr();

            var commands = InitializeCommandsArr();

            var shootingCoordinates = ShootingAt(commands);

            Console.WriteLine("firing at [{0}, {1}]",
                shootingCoordinates[0], shootingCoordinates[1]);

            if (coordinatesOfPlane[0] == shootingCoordinates[0] &&
                coordinatesOfPlane[1] == shootingCoordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }

        public static int[] InitializeCoordinatesArr()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            return arr;
        }

        public static string[] InitializeCommandsArr()
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return arr;
        }

        public static int[] ShootingAt(string[] commands)
        {
            int[] arr = { 0 , 0 };
            // x = arr[0]  y = arr[1]

            for (int i = 0; i < commands.Length; i +=2)
            {
                var command = commands[i];
                var manipilator = int.Parse(commands[i + 1]);

                switch (command)
                {
                    case "right":
                        arr[0] += manipilator;
                        break;
                    case "left":
                        arr[0] -= manipilator;
                        break;
                    case "up":
                        arr[1] += manipilator;
                        break;
                    case "down":
                        arr[1] -= manipilator;
                        break;
                }
            }

            return arr;
        }
    }
}
