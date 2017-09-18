using System;


namespace Problem_11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            var number = 0;

            while (check == false)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else check = true;
            }

            Console.WriteLine("The number is: {0}", Math.Abs(number));
        }
    }
}
