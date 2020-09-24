using System;
using System.Collections.Generic;
using System.Text;

namespace ISPDemo
{
    class HPPrinter : IPrintScan, IFaxData, IDuplexPrint
    {

        public bool PrintData(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }

        public bool ScanData(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }

        public bool FaxData(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }

        public bool PrintDuplex(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }
    }
}
