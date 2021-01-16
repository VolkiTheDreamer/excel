using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace VSTOcsharp
{
    static class MyStatik
    {
        public static Excel.Application app = Globals.ThisAddIn.Application;
    }
}
