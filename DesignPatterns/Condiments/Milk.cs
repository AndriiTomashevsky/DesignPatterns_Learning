namespace DesignPatterns.Condiments
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
            return beverage.Cost() + 0.10;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
