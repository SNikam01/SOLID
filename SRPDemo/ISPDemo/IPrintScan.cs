using System;
using System.Collections.Generic;
using System.Text;

namespace ISPDemo
{
   public interface IPrintScan
    {
        bool PrintData(string Content);
        bool ScanData(string Content);
    }

    public interface IFaxData
    {
        bool FaxData(string Content);
      
    }

    public interface IDuplexPrint
    {
        bool PrintDuplex(string Content);

    }
}
