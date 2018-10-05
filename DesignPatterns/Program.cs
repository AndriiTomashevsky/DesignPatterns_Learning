using DesignPatterns.Condiments;
using System;

namespace DesignPatterns
{
    abstract class Beverage
    {
        protected string description = "Unknow Beverage";
        public virtual string GetDescription() { return description; }
        public abstract double Cost();

        public Size Size { get; set; }
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
            Beverage beverage = new Soy(new Espresso());
            beverage.Size = Size.TALL;
            Console.WriteLine($"{beverage.GetDescription()}, ${beverage.Cost()}");

            Beverage beverage2 = new Soy(new Decaf());
            beverage2.Size = Size.VENTI;
            Console.WriteLine($"{beverage2.GetDescription()}, ${beverage2.Cost()}");

            Console.ReadKey();
        }
    }
}
