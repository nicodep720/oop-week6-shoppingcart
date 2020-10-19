using System;

namespace AppleOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit(0.6);
            Fruit orange = new Fruit(0.25);
            apple.Price = 0.6;
            orange.Price = 0.25;
            Fruit[] basquet= { apple, apple, orange, apple };
            double price = 0;
            foreach (Fruit fruit in basquet) price += fruit.Price;
            Console.WriteLine(price);
            Console.ReadKey();
        }
    }
}
