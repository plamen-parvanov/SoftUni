namespace _04.Hotel
{

    using System;


    public class Problem04
    {

        public static void Main()
        {

            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studio = 0d;
            var doubleRoom = 0d;
            var suite = 0d;

            switch (month)
            {
                case "May":
                case "October":
                    studio = nightsCount > 7 ? 47.5 : 50;
                    doubleRoom = 65;
                    suite = 75;
                    break;

                case "June":
                case "September":
                    studio = 60;
                    doubleRoom = nightsCount > 14 ? 64.8 : 72;
                    suite = 82;
                    break;

                case "July":
                case "August":
                case "December":
                    studio = 68;
                    doubleRoom = 77;
                    suite = nightsCount > 14 ? 89 * 0.85 : 89;
                    break;
            }

            var studioBill = studio * nightsCount;
            var doubleBill = doubleRoom * nightsCount;
            var suiteBill = suite * nightsCount;

            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                studioBill -= studio;
            }

            Console.WriteLine($"Studio: {studioBill:f2} lv.");
            Console.WriteLine($"Double: {doubleBill:f2} lv.");
            Console.WriteLine($"Suite: {suiteBill:f2} lv.");

        }
    }
}
