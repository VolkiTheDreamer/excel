using System.Data;
using System.Runtime.InteropServices;
using VolkansUtility;

[ComVisible(true)]
public interface IVBAClass
{
    void ExceldenOkuveAktiveCelleYaz(string dosya, string sayfa);
}

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
public class VBAClass : IVBAClass
{    
    public void ExceldenOkuveAktiveCelleYaz(string dosya, string sayfa)
    {
        DataTable dt = ExcelRW.ReadFromExcelIntoDTWithExcelReader(dosya, sayfa);
        ExcelRW.WriteDataTableContentToActiveWBWithInterop(dt, ExcelRW.TargetLocation.ActiveCell);
    }
}