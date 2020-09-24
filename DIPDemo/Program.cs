using System;

namespace DIPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("high-level modules/classes should not depend on low-level modules/classes.Both should depend upon abstractions.");
            Console.WriteLine("Secondly, abstractions should not depend upon details. Details should depend upon abstractions.");

            Console.ReadLine();
        }
    }
}
