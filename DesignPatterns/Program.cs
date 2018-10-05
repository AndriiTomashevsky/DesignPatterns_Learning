using System;

namespace DesignPatterns
{
    abstract class Beverage
    {
        protected string description;
        public string GetDescription() { return description; }
        public abstract float Cost();
    }

    class HouseBlend : Beverage
    {
        public HouseBlend() { description = "HouseBlend"; }
        public override float Cost() { throw new NotImplementedException(); }
    }
    class DarkRoast : Beverage
    {
        public DarkRoast() { description = "DarkRoast"; }
        public override float Cost() { throw new NotImplementedException(); }
    }
    class Decaf : Beverage
    {
        public Decaf() { description = "Decaf"; }
        public override float Cost() { throw new NotImplementedException(); }
    }
    class Espresso : Beverage
    {
        public Espresso() { description = "Espresso"; }
        public override float Cost() { throw new NotImplementedException(); }
    }
    class HouseBlendWithSteamedMilkandMocha : Beverage
    {
        public HouseBlendWithSteamedMilkandMocha() { description = "HouseBlendWithSteamedMilkandMocha"; }
        public override float Cost() { throw new NotImplementedException(); }
    }
    class DarkRoastWithSteamedMilkandCaramel : Beverage
    {
        public DarkRoastWithSteamedMilkandCaramel() { description = "DarkRoastWithSteamedMilkandCaramel"; }
        public override float Cost() { throw new NotImplementedException(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
