using System;
using System.Collections.Generic;
using System.Text;

namespace ISPDemo
{
    class JETPrinter: IPrintScan
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

    }
}
