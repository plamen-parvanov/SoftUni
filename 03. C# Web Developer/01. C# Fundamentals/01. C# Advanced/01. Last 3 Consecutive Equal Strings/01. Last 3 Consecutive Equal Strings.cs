namespace _01.Last_3_Consecutive_Equal_Strings
{

    using System;


    public class Problem01
    {

        public static void Main()
        {
            var strArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var cntr = 1;
            var lastStr = string.Empty;

            for (int i = strArr.Length - 1; i >= 0; i--)
            {
                var currStr = strArr[i];

                if (currStr == lastStr)
                {
                    cntr++;
                }
                else
                {
                    cntr = 1;
                }

                if (cntr == 3)
                {
                    Console.WriteLine("{0} {0} {0}", currStr);
                    break;
                }

                lastStr = currStr;
            }

        }
    }
}
