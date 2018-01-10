namespace _03.Regexmon
{

    using System;
    using System.Text.RegularExpressions;

    public class ExamPartII
    {

        public static void Main()
        {

            var inputLine = Console.ReadLine();
            var firstPattern = @"";
            var secondPattern = @""; 

            while (true)
            {
               
                var regex1 = new Regex(firstPattern);
                var regex2 = new Regex(secondPattern);

                







                if (!regex1.IsMatch(text) && !regex2.IsMatch(text))
                {
                    break;
                }
            }
            

        }
    }
}
