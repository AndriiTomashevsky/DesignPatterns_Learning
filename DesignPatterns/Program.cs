using DesignPatterns.Condiments;
using System;

namespace DesignPatterns
{
    abstract class Beverage
    {
        protected string description = "Unknow Beverage";
        public virtual string GetDescription() { return description; }
        public abstract double Cost();
    }

    class HouseBlend : Beverage
    {
        public HouseBlend() { description = "HouseBlend"; }
        public override double Cost() { return 0.89; }
    }
    class DarkRoast : Beverage
    {
        public DarkRoast() { description = "DarkRoast"; }
        public override double Cost() { return 0.99; }
    }
    class Decaf : Beverage
    {
        public Decaf() { description = "Decaf"; }
        public override double Cost() { return 1.05; }
    }
    class Espresso : Beverage
    {
        public Espresso() { description = "Espresso"; }
        public override double Cost() { return 1.99; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()}, ${beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()}, ${beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()}, ${beverage3.Cost()}");

            Console.ReadKey();
        }
    }
}
