using System;


namespace Problem_6.Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            var priceTicket = 1;

            switch (day)
            {
                case "weekday":
                    if (0 <= age && age <= 18) priceTicket = 12;
                    else if(18 < age && age <= 64) priceTicket = 18;
                    else if (64 < age && age <= 122) priceTicket = 12;
                    break;
                case "weekend":
                    if (0 <= age && age <= 18) priceTicket = 15;
                    else if (18 < age && age <= 64) priceTicket = 20;
                    else if (64 < age && age <= 122) priceTicket = 15;
                    break;
                case "holiday":
                    if (0 <= age && age <= 18) priceTicket = 5;
                    else if (18 < age && age <= 64) priceTicket = 12;
                    else if (64 < age && age <= 122) priceTicket = 10;
                    break;

                default:
                    break;
            }

            if (0 <= age && age <= 122)   Console.WriteLine(priceTicket+"$");
            else Console.WriteLine("Error!");
        }
    }
}
