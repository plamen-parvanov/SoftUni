using System;


namespace _04.Month_Printer
{
    class Program
    {
        static void Main()
        {
            int monthInNum = int.Parse(Console.ReadLine());
            string month = string.Empty;

            if (monthInNum < 1 || monthInNum > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                switch (monthInNum)
                {
                    case 1:
                        month = "January";
                        break;
                    case 2:
                        month = "Ferbruary";
                        break;
                    case 3:
                        month = "March";
                        break;
                    case 4:
                        month = "April";
                        break;
                    case 5:
                        month = "May";
                        break;
                    case 6:
                        month = "June";
                        break;
                    case 7:
                        month = "July";
                        break;
                    case 8:
                        month = "August";
                        break;
                    case 9:
                        month = "September";
                        break;
                    case 10:
                        month = "October";
                        break;
                    case 11:
                        month = "November";
                        break;
                    case 12:
                        month = "December";
                        break;                  
                }
                Console.WriteLine(month);
            }
        }
    }
}
