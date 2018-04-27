using System;


namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = firstNum; j <= lastNum; j++)
                {
                    if (counter == stopNum)
                    {
                        break;  // break ne me li izkarva samo ot vutre6niqt cikul, t.e. eto ....
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    counter++;
                }
                // ...TUK   i posle pak se vurti vun6niqt cikul?
            }
            
        }
    }
}
