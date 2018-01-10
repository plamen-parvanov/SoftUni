namespace _15.Calculator
{

    using System;


    public class Problem15
    {

        public static void Main()
        {

            var firstOperand = int.Parse(Console.ReadLine());
            var operatoR = Console.ReadLine();
            var secondOperand = int.Parse(Console.ReadLine());
            var result = 0;

            switch (operatoR)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;

                case "-":
                    result = firstOperand - secondOperand;
                    break;

                case "*":
                    result = firstOperand * secondOperand;
                    break;

                case "/":
                    result = firstOperand / secondOperand;
                    break;
            }

            Console.WriteLine($"{firstOperand} {operatoR} {secondOperand} = {result}");
        }
    }
}
