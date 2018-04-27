namespace _15.Count_of_Capital_Letters_in_Array
{

    using System;

    public class Problem15
    {

        public static void Main()
        {
            var input = Console.ReadLine();

            var strArr = InitializeStrArr(input);

            var cntr = 0;

            foreach (var str in strArr)
            {
                if (str.Length == 1 && str[0] >= 'A' && str[0] <= 'Z')
                {
                    cntr++;
                }
            }

            Console.WriteLine(cntr);
        }

        public static string[] InitializeStrArr(string input)
        {
            var strArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return strArr;
        }
    }
}
