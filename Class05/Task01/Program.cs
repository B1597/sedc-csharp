using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            //3 DAYS FROM NOW
            DateTime threeDaysFromNow = currentDate.AddDays(3);
            Console.WriteLine(threeDaysFromNow);

            // 1 MONTH FROM NOW
            DateTime monthFromNow = currentDate.AddMonths(1);
            Console.WriteLine(monthFromNow);

            //MONTH AND 3 DAYS FROM NOW
            DateTime monthAndThreeDays = monthFromNow.AddDays(3);
            Console.WriteLine(monthAndThreeDays);

            //1 YEAR AND 2 MONTHS AGO FROM TODAY
            DateTime twoMonthsAgo = currentDate.AddMonths(-2);
            DateTime yearAgo = twoMonthsAgo.AddYears(-1);
            Console.WriteLine(yearAgo);

            //CURRENT MONTH
            int currentMonth = currentDate.Month;
            string monthName = currentDate.ToString("MMMM");

            Console.WriteLine(currentMonth);
            Console.WriteLine(monthName);

            //CURRENT YEAR
            int currentYear = currentDate.Year;
            Console.WriteLine(currentYear);         

            Console.ReadLine();
        }
    }
}
