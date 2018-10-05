namespace DesignPatterns.Condiments
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage b)
        {
            beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
