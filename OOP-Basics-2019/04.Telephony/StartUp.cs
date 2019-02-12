namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var calls = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var sites = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var smartPhone = new Smartphone(calls, sites);

            Console.WriteLine(smartPhone.Calling());

            Console.WriteLine(smartPhone.Browsing());
        }
    }
}
