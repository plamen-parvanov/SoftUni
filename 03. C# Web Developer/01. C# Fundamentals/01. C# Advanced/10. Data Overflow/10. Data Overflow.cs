namespace _10.Data_Overflow
{

    using System;


    public class Problem10
    {

        public static void Main()
        {
           
            var firstNum = ulong.Parse(Console.ReadLine());
            var secondNum = ulong.Parse(Console.ReadLine());

            var smallerNum = firstNum;
            var biggerNum = secondNum;

            if (firstNum > secondNum)
            {
                biggerNum = firstNum;
                smallerNum = secondNum;
            }

            var smallerType = GetType(smallerNum);
            var biggerType = GetType(biggerNum);

            var overflows = Math.Round(biggerNum / GetSmallerMaxValue(smallerType));

            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{biggerNum} can overflow {smallerType} {overflows} times");
        }

        public static string GetType(ulong num)
        {
            // byte, ushort, uint, ulong

            var type = string.Empty;

            if (num < Math.Pow(2, 8))
            {
                type = "byte";
            }
            else if (num < Math.Pow(2, 16))
            {
                type = "ushort";
            }
            else if (num < Math.Pow(2, 32))
            {
                type = "uint";
            }
            else 
            {
                type = "ulong";
            }

            return type;
        }

        public static double GetSmallerMaxValue(string type)
        {
            var maxValue = ulong.MaxValue;

            switch (type)
            {
                case "byte":
                    maxValue = byte.MaxValue;
                    break;

                case "ushort":
                    maxValue = ushort.MaxValue;
                    break;

                case "uint":
                    maxValue = uint.MaxValue;
                    break;         
            }

            return maxValue;

        }
    }
}
