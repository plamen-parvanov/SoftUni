namespace _05.User_Logins
{

    using System;
    using System.Collections.Generic;

    public class Problem05
    {
        public static Dictionary<string, string>dict;

        public static void Main()
        {
            dict = new Dictionary<string, string>();

            AddUserPasswords();

            PrintLogIn();

        }

        public static void AddUserPasswords()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "login")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var userName = arr[0];
                var password = arr[1];

                dict[userName] = password;

            }
        }

        public static void PrintLogIn()
        {
            var unsuccessful = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var username = arr[0];
                var password = arr[1];

                if (!dict.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessful++;
                }
                else if (dict[username] != password)
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessful++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
            }

            Console.WriteLine($"unsuccessful login attempts: {unsuccessful}");
        }
    }
}
