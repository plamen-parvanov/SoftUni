using System;


namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main()
        {
            string nounInput = Console.ReadLine();
            string nounPlural = string.Empty;

            if (nounInput.EndsWith("y"))
            {
                nounInput = nounInput.Remove(nounInput.Length - 1);
                nounPlural = nounInput + "ies";
            }
            else if (nounInput.EndsWith("o") || nounInput.EndsWith("ch") || nounInput.EndsWith("s") 
                || nounInput.EndsWith("sh") || nounInput.EndsWith("x") || nounInput.EndsWith("z"))
            {
                nounPlural = nounInput + "es";
            }
            else
            {
                nounPlural = nounInput + "s";
            }

            Console.WriteLine(nounPlural);
        }
    }
}
