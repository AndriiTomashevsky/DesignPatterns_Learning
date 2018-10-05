namespace DesignPatterns.Condiments
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage b)
        {
            beverage = b;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
