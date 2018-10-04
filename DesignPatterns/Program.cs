using System;
using System.Collections.Generic;

//                                  FIRST DESIGN PRINCIPLE

//Identify the aspects of your application that vary and separate them from what stays the
//same.
//                                  SECOND DESIGN PRINCIPLE

//Program to an interface, not an implementation.
namespace DesignPatterns
{
    public interface IFlyBehavior { void Fly(); }
    public interface IQuackBehavior { void Quack(); }

    class FlyWithWings : IFlyBehavior { public void Fly() { Console.WriteLine("I'm flying!"); } }
    class FlyNoWay : IFlyBehavior { public void Fly() { Console.WriteLine("I can't fly"); } }

    class QuackClass : IQuackBehavior { public void Quack() { Console.WriteLine("Quack"); } }
    class Squeak : IQuackBehavior { public void Quack() { Console.WriteLine("Squeak"); } }
    class MuteQuack : IQuackBehavior { public void Quack() { Console.WriteLine("<< Silence >>"); } }

    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim() { Console.WriteLine("All ducks float, even decoys!"); }
        public abstract void Display();
    }

    public class MallardDuck : Duck
    {
        public override void Display() { }
        public MallardDuck()
        {
            quackBehavior = new QuackClass();
            flyBehavior = new FlyWithWings();
        }
    }

    public class ReadheadDuck : Duck
    {
        public override void Display() { }
        public ReadheadDuck()
        {
            quackBehavior = new QuackClass();
            flyBehavior = new FlyWithWings();
        }
    }

    public class RubberDuck : Duck
    {
        public override void Display() { }
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
    }
    public class DecoyDuck : Duck
    {
        public override void Display() { }
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.ReadKey();
        }
    }
}
