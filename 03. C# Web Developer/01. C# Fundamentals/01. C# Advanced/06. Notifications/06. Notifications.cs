namespace _06.Notifications
{

    using System;

    public class Problem06
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var result = Console.ReadLine();

                if (result == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();

                    ShowSuccess(operation, message);
                }
                else if (result == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());

                    ShowError(operation, code);
                }
            }
        }

        public static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed { operation}.");
            Console.WriteLine($"==============================");
            Console.WriteLine($"Message: { message}.");
        }

        public static void ShowError(string operation, int code)
        {
            var reason = "Invalid Client Data";

            if (code < 0 )
            {
                reason = "Internal System Failure";
            }

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine($"==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }


    }
}
