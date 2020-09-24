using System;

namespace ISPDemo
{
    class Program 
    {
        static void Main()
        {
            HPPrinter hpPrinter = new HPPrinter();
            JETPrinter jetPrinter = new JETPrinter();
            Console.WriteLine("Interface Segregation Principle : Clients should not be forced to implement any methods they don’t use.");
            Console.WriteLine("Rather than one fat interface, numerous little interfaces are preferred based on groups of methods with each interface serving one submodule.");

            Console.WriteLine("==============================");
            Console.WriteLine("You can see HP Printer Support all 3 Interfaces : IPrintScan, IFaxData, IDuplexPrint");
            hpPrinter.PrintData("Print Content");
            hpPrinter.ScanData("Scan Content");
            hpPrinter.FaxData("Fax Content");
            hpPrinter.PrintDuplex("Print Duplix Content");

            Console.WriteLine("==============================");
            Console.WriteLine("You can see JET Printer Support only 1 Interfaces : IPrintScan");
            jetPrinter.PrintData("Print Content");
            jetPrinter.ScanData("Scan Content");
           
            Console.ReadLine();
        }

    }

}
