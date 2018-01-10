namespace _05.Word_in_Plural
{

    using System;


    public class Problem05
    {

        public static void Main()
        {

            var noun = Console.ReadLine();

            var nounInPlural = string.Empty;

            if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") 
                || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                nounInPlural = noun + "es";
            }
            else if (noun.EndsWith("y"))
            {
                nounInPlural = noun.Remove(noun.Length - 1, 1) + "ies";
            }
            else
            {
                nounInPlural = noun + "s";
            }

            Console.WriteLine(nounInPlural);
        }
    }
}
