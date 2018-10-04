using System;

namespace DesignPatterns
{
    public abstract class Duck
    {
        public abstract void Display();
        public void Swim() { }
        public virtual void Fly() { }
        public virtual void Quack() { }
    }

    public class MallardDuck : Duck
    {
        public override void Display() { }
    }

    public class ReadheadDuck : Duck
    {
        public override void Display() { }
    }

    public class RubberDuck : Duck
    {
        public override void Display() { }
        public override void Quack() { }
        public override void Fly() { }
    }

    public class DecoyDuck : Duck
    {
        public override void Display() { }
        public override void Quack()
        {
            // override to fo nothing 
        }
        public override void Fly()
        {
            // override to fo nothing
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Quack();

            Duck rubberDuck = new RubberDuck();
            mallardDuck.Quack();

            Console.ReadKey();
        }
    }
}
