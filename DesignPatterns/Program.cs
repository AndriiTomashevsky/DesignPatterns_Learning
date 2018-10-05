using System;

namespace DesignPatterns
{
    abstract class Beverage
    {
        protected string description;
        public string GetDescription() { return description; }
        public virtual double Cost()
        {
            if (HasMilk()) { condimentCost += 0.10; }
            if (HasSoy()) { condimentCost += 0.15; }
            if (HasMocha()) { condimentCost += 0.20; }
            if (HasWhip()) { condimentCost += 0.10; }
            return condimentCost;
        }

        bool milk, soy, mocha, whip;
        double condimentCost;

        bool HasMilk() { return milk; }
        bool HasSoy() { return soy; }
        bool HasMocha() { return mocha; }
        bool HasWhip() { return whip; }

        public void SetMilk() { milk = true; }
        public void SetSoy() { soy = true; }
        public void SetMocha() { mocha = true; }
        public void SetWhip() { whip = true; }
    }

    class HouseBlend : Beverage
    {
        public HouseBlend() { description = "HouseBlend"; }
        public override double Cost() { throw new NotImplementedException(); }
    }
    class DarkRoast : Beverage
    {
        public DarkRoast() { description = "DarkRoast"; }
        public override double Cost() { throw new NotImplementedException(); }
    }
    class Decaf : Beverage
    {
        public Decaf() { description = "Decaf"; }
        public override double Cost() { throw new NotImplementedException(); }
    }
    class Espresso : Beverage
    {
        public Espresso() { description = "Espresso"; }
        public override double Cost() { throw new NotImplementedException(); }
    }
    class HouseBlendWithSteamedMilkandMocha : Beverage
    {
        public HouseBlendWithSteamedMilkandMocha() { description = "HouseBlendWithSteamedMilkandMocha"; }
        public override double Cost() { throw new NotImplementedException(); }
    }
    class DarkRoastWithSteamedMilkandCaramel : Beverage
    {
        public DarkRoastWithSteamedMilkandCaramel() { description = "DarkRoastWithSteamedMilkandCaramel"; }
        public override double Cost() { throw new NotImplementedException(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
