namespace _07.From_Terabytes_to_Bits
{

    using System;


    public class Problem07
    {

        public static void Main()
        {
            // 1 TB = 8 796 093 022 208 bits   ili  (1024 * 1024 * 1024 * 1024 * 8) bits

            var terabites = double.Parse(Console.ReadLine());
            var convertedTBinBits = terabites * 8796093022208;

            Console.WriteLine(convertedTBinBits);


        }
    }
}
