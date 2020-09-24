using System;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle : This principle states that, if S is a subtype of T, then objects of type T should be replaced with the objects of type S.");
            Console.WriteLine("The father is a teacher whereas his son is a doctor. So here, in this case, the son can’t simply replace his father even though both belong to the same family.");
            Console.WriteLine("Using Liscov it should be possible");

            Fruits orange = new Orange();
            Console.WriteLine(orange.GetColor());
            Fruits apple = new Apple();
            Console.WriteLine(apple.GetColor());
            Console.ReadLine();
        }
    }
  public  abstract class Fruits
    {
        public abstract string GetColor();
    }

    public class Orange : Fruits
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
    public class Apple : Fruits
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
}
