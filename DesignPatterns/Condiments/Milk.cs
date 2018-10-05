﻿namespace DesignPatterns.Condiments
{
    class Milk : CondimentDecorator
    {
        Beverage beverage;

        public Milk(Beverage b)
        {
            beverage = b;
        }

        public override double Cost()
        {
            double cost = beverage.Cost() + 0.10;

            if (Size == Size.TALL)
            {
                cost += 0.10;
            }
            else if (Size == Size.GRANDE)
            {
                cost += 0.15;

            }
            else if (Size == Size.VENTI)
            {
                cost += 0.2;
            }

            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk, " + Size;
        }
    }
}