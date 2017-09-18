using System;


namespace Problem_12.Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
