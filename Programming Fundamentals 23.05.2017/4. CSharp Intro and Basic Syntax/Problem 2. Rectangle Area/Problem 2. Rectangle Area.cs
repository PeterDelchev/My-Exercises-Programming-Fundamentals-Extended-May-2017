using System;


namespace Problem_2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var rectangleArea = width * height;

            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
