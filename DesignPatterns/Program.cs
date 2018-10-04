using System;

namespace DesignPatterns
{
    interface IFlyable { void Fly(); }
    interface IQuackable { void Quack(); }

    public abstract class Duck
    {
        public void Swim() { Console.WriteLine("All ducks float, even decoys!"); }
        public abstract void Display();
    }

    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display() { }
        public void Fly() { }
        public void Quack() { }
    }

    public class ReadheadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display() { }
        public void Fly() { }
        public void Quack() { }
    }

    public class RubberDuck : Duck, IQuackable
    {
        public override void Display() { }
        public void Quack() { }

    }

    public class DecoyDuck : Duck
    {
        public override void Display() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            Duck rubberDuck = new RubberDuck();
            mallardDuck.Quack();
            //rubberDuck.Quack();

            Console.ReadKey();
        }
    }
}
