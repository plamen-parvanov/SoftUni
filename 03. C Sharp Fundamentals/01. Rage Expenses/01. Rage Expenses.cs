namespace _01._Rage_Expenses
{
    using System;

    public class Problem01
    {
        public static void Main()
        {
            var gamesLost = int.Parse(Console.ReadLine());
            var headSetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var brokenHeadset = gamesLost / 2;
            var brokenMouse = gamesLost / 3;
            var brokenKeyboard = gamesLost / 6;
            var brokenDisplay = gamesLost / 12;

            var expenses = brokenHeadset * headSetPrice + brokenMouse * mousePrice+ brokenKeyboard * keyboardPrice + brokenDisplay * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

        }
    }
}
