using System;

namespace OCPDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Open Closed Principle: Software entities should be open to extension but closed to modification");
            Console.WriteLine("CalculateBonus functionality is different for different type employee.");
            Console.WriteLine("Hence we have created Employee Abstract class with CalculateBonus abstract function.");
            Console.WriteLine("Implementation of CalculateBonus method is different asper employee type.");

            Employee Sagar = new PermanantEMployee(1,"Sagar");
            Employee Sandeep = new TempraryEMployee(2, "Sandeep");

            Console.WriteLine(string.Format("Employee {0} Bonus : {1}",Sagar.ToString (),Sagar.CalculateBonus(10000)));
            Console.WriteLine(string.Format("Employee {0} Bonus : {1}", Sandeep.ToString(), Sandeep.CalculateBonus(15000)));

            Console.ReadLine();
        }
    }
}
