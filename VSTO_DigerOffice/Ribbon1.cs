using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using outlook = Microsoft.Office.Interop.Outlook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data;
using VolkansUtility;
using Microsoft.VisualBasic;//Inoutbox kullanabilmek için ekledik. c#'ta bu yok

namespace VSTO_DigerOffice
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        
        private void btnTekRelease_Click(object sender, RibbonControlEventArgs e)
        {
            ///Tek release yapıyoruz. Two dot prensibine uyuyoruz. Birden fazla referans bulunmadığı için sıkıntı yaşamıyoruz
            try
            {
                outlook.Application oApp;
                outlook.MailItem oMail;
                Outlooktip ot;
                if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                {
                    ot = Outlooktip.Varolan;
                    oApp = (outlook.Application)Marshal.GetActiveObject("Outlook.Application");
                }
                else
                {
                    ot = Outlooktip.Yeni;
                    oApp = new outlook.Application();
                }
                oMail = oApp.CreateItem(outlook.OlItemType.olMailItem);  
                //two dot prensibini ihlal etmeden iki ayrı değişken oluşturuyoruz
                outlook.Recipients receivers = oMail.Recipients; 
                outlook.Recipient receiver = receivers.Add("volkan.yurtseven@hotmail.com");
                receiver.Type = (int)outlook.OlMailRecipientType.olCC;

                oMail.To = "mvolkanyurtseven@gmail.com";
                oMail.Subject = "VSTO-Tek Release";
                oMail.Body = "Bu bir deneme mailidir";
                oMail.Send();
                System.Windows.Forms.MessageBox.Show("İşlem tamam");

                //Releasing objects                                 
                Marshal.ReleaseComObject(receiver);
                receiver = null;
                Marshal.ReleaseComObject(receivers);
                receivers = null;
                Marshal.ReleaseComObject(oMail);
                oMail = null;

                if (ot == Outlooktip.Varolan)
                {
                    //Burda program açık kalmalı, o yüzden Quit metodu yok. Marshal.Release de yapmıyoruz,zira program hala açık
                    oApp = null;
                }
                else
                {
                    oApp.Quit();
                    Marshal.ReleaseComObject(oApp);
                    oApp = null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
               

        private void btnLoopRelease_Click(object sender, RibbonControlEventArgs e)
        {
            ///Bunda bir loop ile ilgili objeye referans kalmayana kadar loop içine release yapıyoruz, two dot prensibine uyulduğu sürece yine sıkıntı yaşamadık

            try
            {                
                outlook.Application oApp;
                outlook.MailItem oMail;
                Outlooktip ot;
                if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                {
                    ot = Outlooktip.Varolan;
                    oApp = (outlook.Application)Marshal.GetActiveObject("Outlook.Application");
                }
                else
                {
                    ot = Outlooktip.Yeni;
                    oApp = new outlook.Application();
                }
                oMail = oApp.CreateItem(outlook.OlItemType.olMailItem);
                outlook.Recipients receivers = oMail.Recipients;
                outlook.Recipient receiver = receivers.Add("volkan.yurtseven@hotmail.com");
                receiver.Type = (int)outlook.OlMailRecipientType.olCC;

                oMail.To = "mvolkanyurtseven@gmail.com";
                oMail.Subject = "VSTO-Loop Release";
                oMail.Body = "Bu bir deneme mailidir";
                oMail.Send();
                System.Windows.Forms.MessageBox.Show("İşlem tamam");

                //Releasing objects                     
                //burda ayrıca null yapmıyoruz, zira ReleaseWithOrder içinde bunu yapıyoruz                
                ReleaseWithOrder(receiver, "receiver");
                ReleaseWithOrder(receivers, "receivers");
                ReleaseWithOrder(oMail, "oMail");

                if (ot == Outlooktip.Varolan)
                {
                    oApp = null;
                }
                else
                {
                    oApp.Quit();
                    ReleaseWithOrder(oApp,"oApp");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ReleaseWithOrder(object o,string ad)
        {
            try
            {
                //while (Marshal.ReleaseComObject(o)>0) { }; //normalde bu satır yeterli, ben test amaçlı aşağıdaki bloğu oluşturdum
                int cnt = Marshal.ReleaseComObject(o);
                while (cnt > 0)
                {
                    //buraya hiç girmedi, o yüzden çoklu referans durumunu hiç simüle edememiş oldum. Bu durumda ilk yöntemle bu yöntem arasında fark bulunmuyor
                    Trace.WriteLine(ad + " nesnesi için " + cnt.ToString() + ". release");
                    cnt =Marshal.ReleaseComObject(o);
                }
            }
            catch
            {
                //
            }
            finally
            {
                o = null;
            }
        }

        private void btnFinalRelease_Click(object sender, RibbonControlEventArgs e)
        {
            ///Bunda Final Release yapıyoruz. two dot prensibine uyulduğu ve başka add-in kullanımı ile outlook erişmi yoksa bu da sıkıntı yaratmaz.

            try
            {
                outlook.Application oApp;
                outlook.MailItem oMail;
                Outlooktip ot;
                if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                {
                    ot = Outlooktip.Varolan;
                    oApp = (outlook.Application)Marshal.GetActiveObject("Outlook.Application");
                }
                else
                {
                    ot = Outlooktip.Yeni;
                    oApp = new outlook.Application();
                }
                oMail = oApp.CreateItem(outlook.OlItemType.olMailItem);
                outlook.Recipients receivers = oMail.Recipients;
                outlook.Recipient receiver = receivers.Add("volkan.yurtseven@hotmail.com");
                receiver.Type = (int)outlook.OlMailRecipientType.olCC;

                
                oMail.To = "mvolkanyurtseven@gmail.com";
                oMail.Subject = "VSTO-FinalRelease";
                oMail.Body = "Bu bir deneme mailidir";
                oMail.Send();
                System.Windows.Forms.MessageBox.Show("İşlem tamam");

                //Releasing objects                     
                Marshal.FinalReleaseComObject(receiver);
                receiver = null;
                Marshal.FinalReleaseComObject(receivers);
                receivers = null;
                Marshal.FinalReleaseComObject(oMail);
                oMail = null;

                if (ot == Outlooktip.Varolan)
                {
                    oApp = null;
                }
                else
                {
                    oApp.Quit();
                    Marshal.FinalReleaseComObject(oApp);
                    oApp = null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnGC_Click(object sender, RibbonControlEventArgs e)
        {
            ///GC ile - Sadece Release modda işe yarar. two dot prensibine uymasak bile işe yarar. Debug modda test etmyeceksek en kısa ve temiz çözüm budur.

            DebugGC();//Debug moddayken uyarı versin diye bu metodu oluşturdum

            try
            {
                outlook.Application oApp;
                outlook.MailItem oMail;
                Outlooktip ot;
                if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                {
                    ot = Outlooktip.Varolan;
                    oApp = (outlook.Application)Marshal.GetActiveObject("Outlook.Application");
                }
                else
                {
                    ot = Outlooktip.Yeni;
                    oApp = new outlook.Application();
                }

                oMail = oApp.CreateItem(outlook.OlItemType.olMailItem);
                //two dot prensibine uymayalım, yani aradaki recipients değişkenini yaratmıyorum, yine de sorun olmayacak
                outlook.Recipient receiver = oMail.Recipients.Add("volkan.yurtseven@hotmail.com"); //iki noktaya(two dot) dikkat edin. zincirleme nesne kullanımı yapıyoruz, arada gizli olan bir Recipients nesnesi de yaratılmış durumda
                receiver.Type = (int)outlook.OlMailRecipientType.olCC;                             

                oMail.To = "mvolkanyurtseven@gmail.com";
                oMail.Subject = "VSTO-GC";
                oMail.Body = "Bu bir deneme mailidir";
                oMail.Send();
                System.Windows.Forms.MessageBox.Show("İşlem tamam");

                //Releasing objects
                receiver = null;
                oMail = null;

                if (ot == Outlooktip.Varolan)
                {
                    oApp = null;
                }
                else
                {
                    oApp.Quit();//başta veya sonda olması farketmiyor
                    oApp = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();//Genelde bu gerekli değil ama biz garantiye alalım

                    //the first time you call the methods we only release objects that we are not referencing with our own variables. The second time the two methods are called is because the RCW for each COM object needs to run a finalizer that actually fully removes the COM Object from memory
                    GC.Collect();//Çoğu yerde ikinci kullanımı gösterilmemiş, ancak bu ikili kullanım özellikle VSTO çalışmalarında gerekli diyorlar, VSTO dışında bir projede gerekli değilmiş.
                    GC.WaitForPendingFinalizers();
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        [DebuggerStepThrough()]
        private void DebugGC()
        {
            System.Windows.Forms.MessageBox.Show("Şuan debug moddasın, task managerdan manuel kill et, yoksa sonraki erişimlerde hata alacaksın");
        }

        private void btnTwoDotIhlal_Click(object sender, RibbonControlEventArgs e)
        {
            ///two dot prensibini ihlal edeceğiz, LoopRelease ile yapacağız ama FinalRelease ile yapsaydık da değişmeyecekti, çünkü two dot ihlali iki yöntemi de affetmiyor. o yüzden hala arkada yaşamaya davem edecek
            try
            {
                outlook.Application oApp;
                outlook.MailItem oMail;
                Outlooktip ot;
                if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                {
                    ot = Outlooktip.Varolan;
                    oApp = (outlook.Application)Marshal.GetActiveObject("Outlook.Application");
                }
                else
                {
                    ot = Outlooktip.Yeni;
                    oApp = new outlook.Application();
                }
                oMail = oApp.CreateItem(outlook.OlItemType.olMailItem);
                outlook.Recipient receiver = oMail.Recipients.Add("volkan.yurtseven@hotmail.com"); //two dot
                receiver.Type = (int)outlook.OlMailRecipientType.olCC;

                var act = oMail.Actions;//omail için başka bi referans                

                oMail.To = "mvolkanyurtseven@gmail.com";
                oMail.Subject = "VSTO-Release ama two dot ihlali";
                oMail.Body = "Bu bir deneme mailidir";
                oMail.Send();
                System.Windows.Forms.MessageBox.Show("İşlem tamam");


                //Releasing objects                     
                ReleaseWithOrder(act, "receiver");
                ReleaseWithOrder(receiver, "receiver");
                ReleaseWithOrder(oMail, "oMail");                

                if (ot == Outlooktip.Varolan)
                {
                    oApp = null;
                }
                else
                {
                    oApp.Quit();                    
                    ReleaseWithOrder(oApp, "oApp");
                    oApp = null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private enum Outlooktip
        {
            Varolan,
            Yeni
        }
        

  
        private void btnAccess_Click(object sender, RibbonControlEventArgs e)
        {
            //datayı okuma
            string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\OneDrive\Uygulama Geliştirme\web sitelerim\Yeni Efendi\Ornek_dosyalar\Makrolar\BölgeŞubeRakamları.accdb;Persist Security Info=False;";            
            OleDbConnection conn = new OleDbConnection(constr);
            OleDbCommand cmd = new OleDbCommand("Select * from bölgerakam where Bölge='Bölge1' and Ürün='Ürün1'", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //excele yazma
            ExcelRW.WriteDataTableContentToActiveWBWithInterop(dt, ExcelRW.TargetLocation.ActiveCell);            
        }

        private void btnExcelOledb_Click(object sender, RibbonControlEventArgs e)
        {
            //okuma
            string file = @"E:\OneDrive\Uygulama Geliştirme\web sitelerim\Yeni Efendi\Ornek_dosyalar\pivotdata.xlsx";
            DataTable dt = ExcelRW.ReadFromExcelIntoDTWithOledDB(file, "select Kalem, Sum(Rakam) from [Sheet1$] Group by Kalem");
            //yazma
            ExcelRW.WriteDataTableContentToActiveWBWithInterop(dt, ExcelRW.TargetLocation.ActiveCell);
        }

        private void btnExcelReader_Click(object sender, RibbonControlEventArgs e)
        {
            //okuma
            string cevap = Interaction.InputBox("Seçim yapın:1,2");
            string file = @"E:\OneDrive\Uygulama Geliştirme\web sitelerim\Yeni Efendi\Ornek_dosyalar\pivotdata.xlsx";
            DataTable dt;
            if (cevap == "1")
            {
                dt = ExcelRW.ReadFromExcelIntoDTWithExcelReader(file, cevap.ConvertIoInt());//extension metod
            }
            else
            {
                dt = ExcelRW.ReadFromExcelIntoDTWithExcelReader(file, "Tarihsel Data", "Ürün='Ürün1'", new string[] { "Bölge Kodu", "Ay", "Aylık Gerç" });
            }
            //yazma
            ExcelRW.WriteDataTableContentToActiveWBWithInterop(dt, ExcelRW.TargetLocation.ActiveCell);
        }
    }
}
