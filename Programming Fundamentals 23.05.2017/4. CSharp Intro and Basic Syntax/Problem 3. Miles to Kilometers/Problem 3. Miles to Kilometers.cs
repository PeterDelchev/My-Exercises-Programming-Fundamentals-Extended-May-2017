using System;


namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            var kilometers = miles * 1.60934;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
