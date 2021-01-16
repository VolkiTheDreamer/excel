using ExcelDna.Integration;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using ExcelDna.ComInterop;

public static class MyDNA
{
    
    [ExcelFunction(Description = "ilk basit fonksiyonum", Category = "XLL Functions")]
    public static string MerhabaXLL()
    {        
        return "Merhaba XLL dünyası";
        
    }


    [ExcelFunction(Description = "Bir metinde kaç kelime olduğunu sayar", Category = "XLL Functions")]
    public static int KacKelimeXLL(
        [ExcelArgument(Name = "rng",Description = "Kelime sayısı yazdırılacak olan metin")] object[,] rng, 
        [ExcelArgument(Name = "ayrac", Description = "Hangi ayraçla bölünecek, default olarak boşluktur")] [Optional] object ayrac
        )
    {
        char ayrac2;
        if (ayrac is ExcelMissing)
            ayrac2 = ' ';
        else
            ayrac2 = System.Convert.ToChar(ayrac);
        string icerik = rng[0, 0].ToString();
        return icerik.Split(ayrac2).Length; 
    }

    public static double dnaSumEvenNumbers2D(object[,] arg)
    {
        double sum=0;
        int rows;
        int cols;

        rows = arg.GetLength(0);
        cols = arg.GetLength(1);

        for (int i = 0; i <= rows - 1; i++)
        {
            for (int j = 0; j <= cols - 1; j++)
            {
                object val = arg[i, j];
                if (!(val is ExcelEmpty) && (double)val % 2 == 0) //boş olup olmadığını da kontrol etmekte fayda var, yoksa hata alırız 
                    sum += (double)val;
            }
        }

        return sum;
    }

    [ExcelFunction(IsMacroType = true)]
    public static double GetArkarenk([ExcelArgument(AllowReference=true)] object hucre)
    {
        ExcelReference rng = (ExcelReference)hucre;
        Excel.Range refrng = ReferenceToRange(rng);
        return refrng.Interior.Color;
    }

    [ExcelFunction(IsMacroType = true)]
    public static long HucreAdet([ExcelArgument(AllowReference = true)] object alan)
    {   
        ExcelReference rng = (ExcelReference)alan;
        Excel.Range refrng = ReferenceToRange(rng);
        return refrng.Cells.Count;
    }

    //yardımcı fonkisyon
    private static Excel.Range ReferenceToRange(ExcelReference xlRef)
    {    
        Excel.Application app = (Excel.Application)ExcelDnaUtil.Application;//Application nesnesine erişimi böyle sağlarız                
        //dynamic app = ExcelDnaUtil.Application; //Interop referansı eklemeden böyle de yapabilrdik ama intellinseten yararlanamayız
        string strAddress = XlCall.Excel(XlCall.xlfReftext, xlRef, true).ToString();
        return app.Range[strAddress];
    }


}