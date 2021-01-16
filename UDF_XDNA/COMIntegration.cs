using ExcelDna.Integration;
using ExcelDna.IntelliSense;
using System.Runtime.InteropServices;

namespace UDF_XDNA
{
    [ComVisible(false)]
    internal class ExcelAddin : IExcelAddIn
    {
        public void AutoOpen()
        {
            IntelliSenseServer.Install();
        }
        public void AutoClose()
        {
            IntelliSenseServer.Uninstall();
        }
    }
}
