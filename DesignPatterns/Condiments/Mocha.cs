namespace DesignPatterns.Condiments
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage b)
        {
            beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
