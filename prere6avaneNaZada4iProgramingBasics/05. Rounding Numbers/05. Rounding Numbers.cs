using System;


namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] inputSplited = input.Split(' ');
            double[] numbresArr = new double[inputSplited.Length];

            CopyInputToNumbersArr(inputSplited, numbresArr);

            PrintRoundedNumber(numbresArr);

        }

        private static void PrintRoundedNumber(double[] numbresArr)
        {
            foreach (var number in numbresArr)
            {
                double roundedNmbr = Math.Truncate(Math.Abs(number) + 0.5);
                if (number < 0)
                {
                    roundedNmbr -= 2 * roundedNmbr;
                }

                Console.WriteLine($"{number} => {roundedNmbr}");
            }
        }

        private static void CopyInputToNumbersArr(string[] inputSplited, double[] numbresArr)
        {
            for (int i = 0; i < numbresArr.Length; i++)
            {
                numbresArr[i] = double.Parse(inputSplited[i]);
            }
        }
    }
}
