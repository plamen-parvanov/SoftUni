namespace _05.Parking_Validation
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dictionaries
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var userAndNumber = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();

                ExecuteCommands(inputLine, userAndNumber);

            }

            foreach (var user in userAndNumber)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }

        public static void ExecuteCommands(string[] inputLine,
            Dictionary<string, string> userAndNumber)
        {
            var command = inputLine[0];
            var user = inputLine[1];

            switch (command)
            {
                case "register":
                    var number = inputLine[2];

                        if (userAndNumber.ContainsKey(user))
                        {
                            Console.WriteLine(
                                $"ERROR: already registered with plate number {userAndNumber[user]}");
                        }
                        else if (!CheckIsLicenseValid(number))
                        {
                            Console.WriteLine($"ERROR: invalid license plate {number}");
                        }
                        else if (userAndNumber.Values.Contains(number))
                        {
                            Console.WriteLine(
                                $"ERROR: license plate {number} is busy");
                        }
                        else
                        {
                            userAndNumber.Add(user, number);
                            Console.WriteLine(
                                $"{user} registered {number} successfully");
                        }
                    break;


                case "unregister":
                    if (userAndNumber.ContainsKey(user))
                    {
                        Console.WriteLine($"user {user} unregistered successfully");
                        userAndNumber.Remove(user);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }

                    break;
            }

        }

        public static bool CheckIsLicenseValid(string number)
        {

            if (number.Length == 8)
            {
                if (number[0].Equals(number.ToUpper()[0]) &&
                   number[1].Equals(number.ToUpper()[1]) &&
                   number[6].Equals(number.ToUpper()[6]) &&
                   number[7].Equals(number.ToUpper()[7]) &&
                   (number[2] >= '0' && number[2] <= '9') &&
                   (number[3] >= '0' && number[3] <= '9') &&
                   (number[4] >= '0' && number[4] <= '9') &&
                   (number[5] >= '0' && number[5] <= '9'))
                {
                    return true;
                }
            }

            return false;

        }
    }
}