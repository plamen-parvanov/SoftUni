namespace ConsoleApp5
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var sb = new StringBuilder();

            AddingInSb(sb);

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void AddingInSb(StringBuilder sb)
        {
            sb.AppendLine("Ima promqna - referenten tip!!!");
        }
    }
}
