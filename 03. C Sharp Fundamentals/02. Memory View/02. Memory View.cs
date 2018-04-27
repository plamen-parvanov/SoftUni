namespace _02._Memory_View
{
    using System;
    using System.Text;

    public class Problem02
    {
        public static void Main()
        {
            var input = ReadInput();

            ConvertToString(input);

        }

        private static void ConvertToString(string input)
        {
            var arr = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length - 3; i++)
            {
                if (StringStarts(arr, i))
                {
                    PrintConverted(arr, i);
                }
            }
        }

        private static void PrintConverted(string[] arr, int i)
        {
            var length = int.Parse(arr[i + 4]);

            var sb = new StringBuilder();

            for (int j = 0; j < length; j++)
            {
                var curr = (char)int.Parse(arr[i + j + 6]);
                sb.Append(curr);
            }

            Console.WriteLine(sb.ToString());
        }

        private static bool StringStarts(string[] arr, int i)
        {
            var a=  arr[i] == "32656" && arr[i + 1] == "19759" && arr[i + 2] == "32763";
            return a;
        }

        private static string ReadInput()
        {
            var sb = new StringBuilder();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Visual Studio crash")
                {
                    break;
                }

                sb.Append(inputLine + " ");
            }

            return sb.ToString();
        }
    }
}
