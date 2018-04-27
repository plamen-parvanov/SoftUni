using System;


namespace bonusPoints
{
    class bonusPoints
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var number = double.Parse(Console.ReadLine());
            var bonusPoints = 0d;
           

            if (number % 2 == 0)
                bonusPoints += 1;

            if ((number + 5) % 10 == 0)
                bonusPoints = bonusPoints + 2;


            if (number <= 100)
                bonusPoints = bonusPoints + 5;

            else
            
                if (number < 1000)
                    bonusPoints = bonusPoints + number * 20 / 100;

                else 
                    bonusPoints = bonusPoints + number * 10 / 100;

            var sum = number + bonusPoints;

            Console.WriteLine("bonus score: " + bonusPoints);
            Console.WriteLine("Total score: " + sum); 
        }
    }
}
