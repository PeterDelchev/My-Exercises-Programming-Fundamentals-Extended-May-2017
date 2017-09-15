using System;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());

            double energy = energyPer100ml * volume / 100.00;
            double sugar = sugarPer100ml * volume / 100.00;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
