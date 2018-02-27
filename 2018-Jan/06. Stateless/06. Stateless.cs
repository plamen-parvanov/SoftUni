namespace _06.Stateless
{
    using System;
    using System.Text;

    public class Problem06
    {
        public static string result;

        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "collapse")
                {
                    break;
                }

                result = input;
                var fiction = Console.ReadLine();

                Execute(fiction);

                PrintResult();

            }
        }

        public static void Execute(string fiction)
        {
            var sb = new StringBuilder(result);
            var fic = new StringBuilder(fiction);

            while (fic.Length > 0)
            {
                sb.Replace(fic.ToString(), "");
                fic.Remove(0, 1);

                if (fic.Length > 0)
                {
                    fic.Remove(fic.Length - 1, 1);
                }           
            }

            result = sb.ToString().Trim();
        }

        public static void PrintResult()
        {
            if (result.Length == 0)
            {
                Console.WriteLine("(void)");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
