using System;


namespace Problem_3.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalMinutes = hour * 60 + minutes;
            var timeIn30Minutes = totalMinutes + 30;
            var hourIn30Minutes = timeIn30Minutes / 60;
            var minutesIn30Minutes = timeIn30Minutes % 60;

            if (hourIn30Minutes >= 24)
            {
                hourIn30Minutes = 0;
            }
            Console.WriteLine($"{hourIn30Minutes}:{minutesIn30Minutes:d2}");
        }
    }
}
