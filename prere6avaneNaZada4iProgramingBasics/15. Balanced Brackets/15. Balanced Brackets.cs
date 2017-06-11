using System;


namespace _15.Balanced_Brackets
{
    class BalancedBrackets

    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            int cntr = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "(":
                        cntr++;
                        break;
                    case ")":
                        cntr--;
                        break;
                }

                if (cntr < 0 || cntr > 1)
                {
                    isBalanced = false;
                }
            }
            if (cntr % 2 != 0)
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
