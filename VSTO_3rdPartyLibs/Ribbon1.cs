using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using VolkansUtility;
using System.Data;
using System.Windows.Forms;

namespace VSTO_3rdPartyLibs
{
    public partial class Ribbon1
    {
        Excel.Application app;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "Hello World!";
                worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
                workbook.SaveAs("HelloWorld_ClosedXML.xlsx");
            }
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook wb = app.Workbooks.Add();
            wb.Worksheets[1].Name = "Sample Sheet"; //sayfa yaratmaay gerek yok, zaten default bir sayfamız var, biz bunun (1den fazla olsa da ilkini) adını değiştiriyoruz
            app.Range["A1"].Value = "Hello World"; //bu ve alttakinde ise worksheet nesnesi üzerinden değil app nesnesi üzerinden erişiyoruz
            app.Range["A2"].Formula = "=MID(A1,7,5)";
            wb.SaveAs("HelloWorld_Interop.xlsx");
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {   
            var wb= new XLWorkbook("MevcutDosya.xlsx");
            var ws = wb.Worksheet(1);
            var alan = ws.Range("B1:D20");
            var rows = alan.Rows(r => r.Cell(3).GetString() == "E"); 
            foreach (var row in rows) 
                row.Delete();
            
            wb.Save();
            System.Windows.Forms.MessageBox.Show("İşlem tamam");
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            //Önce Interop ile başlıyoruz, zira açık olan bi dosyada işlem yapacağız
            Excel.Workbook wb = ExcelRW.GetActiveWorkbook();//VolkansUtility içinde
            string filepath = wb.FullName;
            wb.Save(); wb.Close(); //ClosedXML ile işlem yapabilmek için dosyayı geçici olarak kaydedip kapatıyoruz

            //Şimdi ClosedXML zamanı
            var cxwb = new XLWorkbook(filepath);            
            var ws = cxwb.Worksheet(1);
            var alan = ws.Range("B1:D20");           
            var hucreler = alan.Cells(c => c.DataType == XLDataType.Text);
            hucreler.ToList().ForEach(c => c.Style.Fill.BackgroundColor = XLColor.LightGray);
            cxwb.Save();
            
            //Şimdi tekrar Interop vakti
            app.Workbooks.Open(filepath);
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\OneDrive\Uygulama Geliştirme\web sitelerim\Yeni Efendi\Ornek_dosyalar\Makrolar\BölgeŞubeRakamları.accdb;Persist Security Info=False;";
            string sql = "Select * from şuberakam";
            DataTable dt = SQLRW.ReadFromOleDB(constr,sql);

            long i1 = sw.TimeElapsed(() => ExcelRW.WriteDataTableContentWithClosedXML(dt, "ClosedXML"));
            System.Windows.Forms.MessageBox.Show("ClosedXML ile " + i1.ToString() + " ms sürdü");

            long i2 = sw.TimeElapsed(() => ExcelRW.WriteDataTableContentToActiveWBWithInterop(dt, ExcelRW.TargetLocation.NewSheet));
            MessageBox.Show("Interop ile " + i2.ToString() + " ms sürdü");
                      
            long i3 = sw.TimeElapsed(() => ExcelRW.WriteDataTableContentWithClosedXML(dt, "MevcutDosya.xlsx", true));
            MessageBox.Show("Kapalı dosya ClosedXML ile " + i3.ToString() + " ms sürdü");
        }

        private void button6_Click(object sender, RibbonControlEventArgs e)
        {            
            string dosya = "MevcutDosya.xlsx";
            DataTable dt1 = ExcelRW.ReadFromExcelIntoDTWithExcelReader(dosya, 3, "Ay=1");
            MessageBox.Show(dt1.Rows.Count.ToString());
            
            DataTable dt2= ExcelRW.ReadFromExcelIntoDTWithOledDB(dosya, "Ay=1");
            MessageBox.Show(dt2.Rows.Count.ToString());

        }

        private void button7_Click(object sender, RibbonControlEventArgs e)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "bir");
            dict.Add(2, "iki");
            DataTable dt = dict.DictToDatatable<int, string>();
            ExcelRW.WriteDataTableContentToActiveWBWithInterop(dt, ExcelRW.TargetLocation.ActiveCell);
        }
    }
}
