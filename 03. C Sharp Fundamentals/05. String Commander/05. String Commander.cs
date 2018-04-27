namespace _05.String_Commander
{
    using System;
    using System.Text;

    public class Problem05
    {
        public static void Main()
        {
            var str = Console.ReadLine();

            str = Manipulate(str);

            Console.WriteLine(str);
        }

        public static string Manipulate(string str)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                str = ExecuteCommand(inputLine, str);
            }

            return str;
        }

        public static string ExecuteCommand(string input, string result)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = arr[0];

            switch (command)
            {
                case "Left":
                    var countLeft = int.Parse(arr[1]);
                    result = MoveLeft(countLeft, result);
                    break;
                case "Right":
                    var countRight = int.Parse(arr[1]);
                    result = MoveRight(countRight, result);
                    break;
                case "Insert":
                    var index = int.Parse(arr[1]);
                    var str = arr[2];
                    result = Insert(str, index, result);
                    break;
                case "Delete":
                    var startIndex = int.Parse(arr[1]);
                    var endIndex = int.Parse(arr[2]);
                    result = Delete(result, startIndex, endIndex);
                    break;
            }

            return result;
        }

        public static string MoveLeft(int count, string result)
        {
            var sb = new StringBuilder(result);

            for (int i = 0; i < count % result.Length; i++)
            {
                sb.Remove(0, 1);
                sb.Append(result[i]);
            }
            
            return sb.ToString();
        }

        public static string MoveRight(int count, string result)
        {
            var sb = new StringBuilder(result);

            for (int i = 0; i < count % result.Length; i++)
            {
                sb.Remove(result.Length - 1, 1);
                sb.Insert(0, result[result.Length - 1 - i]);
            }

            return sb.ToString();
        }

        public static string Insert(string str, int index, string result)
        {
            var sb = new StringBuilder(result);
            sb.Insert(index, str);
            return sb.ToString();
        }

        public static string Delete(string result, int start, int end)
        {
            var sb = new StringBuilder(result);
            sb.Remove(start, end - start + 1);

            return sb.ToString();
        }
    }
}
