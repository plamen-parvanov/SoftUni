using System;
using System.Numerics;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main()
        {
            checked
            {
                var centuries = byte.Parse(Console.ReadLine());
                var years = (ushort)(centuries * 100);
                var days = (uint)(years * 365.2422);
                var hours = (ulong)(days * 24);
                var minutes = hours * 60;
                var seconds = minutes * 60;
                var milliseconds = seconds * 1000;
                BigInteger microsecods = (BigInteger)(milliseconds * 1000);
                var nanoseconds = microsecods * 1000;

                Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                    centuries, years, days, hours, minutes, seconds, milliseconds, microsecods, nanoseconds);
            }

        }
    }
}
