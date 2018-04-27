namespace _01.Count_Working_Days
{
    using System;
    using System.Globalization;


    public class ObjectsAndClasses
    {

        public static void Main()
        {
            var startDate = ParseDateTime(Console.ReadLine());
            var endDate = ParseDateTime(Console.ReadLine());

            var hollydays = AddHollydaysInArr();
            var workDaysCounter = 0;

            for (var i = startDate; i <= endDate; i= i.AddDays(1))
            {
                bool isWeekend = i.DayOfWeek.Equals(DayOfWeek.Saturday) 
                    || i.DayOfWeek.Equals(DayOfWeek.Sunday);
                bool isHollyday = CheckForNationalHollydays(i, hollydays);
                
                if(!isWeekend && !isHollyday)
                {
                    workDaysCounter++;  
                }
            }

            Console.WriteLine(workDaysCounter);


        }

        public static DateTime ParseDateTime(string dateAsString)
        {
            var date = DateTime.ParseExact(dateAsString,
                "dd-MM-yyyy", CultureInfo.InvariantCulture);

            return date;
        }

        public static DateTime[] AddHollydaysInArr()
        {
            var newYear = ParseDateFormatddMM("01-01");
            var LiberationDay = ParseDateFormatddMM("03-03");
            var WorkersDay = ParseDateFormatddMM("01-05");
            var SaintGeorgesDay = ParseDateFormatddMM("06-05");
            var SaintsCyrilAndMethodiusDay = ParseDateFormatddMM("24-05");
            var UnificationDay = ParseDateFormatddMM("06-09");
            var IndependenceDay = ParseDateFormatddMM("22-09");
            var NationalAwakeningDay = ParseDateFormatddMM("01-11");
            var Xmas1 = ParseDateFormatddMM("24-12");
            var Xmas2 = ParseDateFormatddMM("25-12");
            var Xmas3 = ParseDateFormatddMM("26-12");

            var AddHollydaysInArr = new DateTime[11];
            AddHollydaysInArr[0] = newYear;
            AddHollydaysInArr[1] = LiberationDay;
            AddHollydaysInArr[2] = WorkersDay;
            AddHollydaysInArr[3] = SaintGeorgesDay;
            AddHollydaysInArr[4] = SaintsCyrilAndMethodiusDay;
            AddHollydaysInArr[5] = UnificationDay;
            AddHollydaysInArr[6] = IndependenceDay;
            AddHollydaysInArr[7] = NationalAwakeningDay;
            AddHollydaysInArr[8] = Xmas1;
            AddHollydaysInArr[9] = Xmas2;
            AddHollydaysInArr[10] = Xmas3;

            return AddHollydaysInArr;
        }

        public static DateTime ParseDateFormatddMM(string dateStr)
        {
            var date = DateTime.ParseExact(dateStr, "dd-MM", CultureInfo.InvariantCulture);
            return date;


        }

        public static bool CheckForNationalHollydays(DateTime date, DateTime[] hollydays)
        {
            for (int i = 0; i < hollydays.Length; i++)
            {
                if (hollydays[i].DayOfYear.Equals(date.DayOfYear))
                {
                    return true;
                }
            }

            return false;


        }
    }
}
