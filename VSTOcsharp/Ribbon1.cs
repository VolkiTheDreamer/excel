using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Deployment.Application;

namespace VSTOcsharp
{
    public partial class Ribbon1
    {
        public MyUserControl myusercontrol1; //taskpane için
        public Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane; //taskpane için

        public Excel.Application app;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
            button20.Image = Properties.Resources._0.ToBitmap();
            this.label1.Label = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook wb = Globals.ThisAddIn.Application.Workbooks.Add();

        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            MyStatik.app.Workbooks.Open(@"E:\OneDrive\Uygulama Geliştirme\web sitelerim\Yeni Efendi\Ornek_dosyalar\CF.xlsx");
            Excel.Worksheet ws = MyStatik.app.Worksheets[1];
            MessageBox.Show(ws.Name);
            MessageBox.Show(MyStatik.app.Worksheets[1].Name);
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            //Excel.Range hucre = MyStatik.app.ActiveCell;
            //double deger = hucre.Value2;
            //MessageBox.Show(hucre.Address + " adresindeki hucrenin değeri:" + deger.ToString());

            try
            {
                Excel.Range hucre = MyStatik.app.Selection; //castinge gerek yok, çünkü zaten değişkenin tipini belirtiyoruz
                int deger = (int)(hucre.Value2); //double'dan integera dönüşüm
                MessageBox.Show(hucre.Address + " adresindeki hucrenin değeri:" + deger.ToString());
                //değişken atamasız durum
                MessageBox.Show(MyStatik.app.Selection.Value2.ToString()); //casting yapmadığımız için intellisense çıkmaz
                MessageBox.Show(((Excel.Range)MyStatik.app.Selection).Value2.ToString()); //intellisense çıkar                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seçili bir hücre yok, lütfen bir hücre seçip tekrar deneyin.");
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233088)
                {
                    MessageBox.Show("Şuan nümerik değeri olan bir hücrede bulunmuyorsunuz.");
                    MessageBox.Show(String.Format("HRresult:{0},\n\nMesaj:{1}", ex.HResult.ToString(), ex.Message));
                }
                else
                {
                    MessageBox.Show(String.Format("HRresult:{0},\n\nMesaj:{1}", ex.HResult.ToString(), ex.Message));
                }
            }
        }

        private void button6_Click(object sender, RibbonControlEventArgs e)
        {
            //çeşitli range işleri
            Excel.Worksheet ws = MyStatik.app.Worksheets[1];
            Excel.Range r = MyStatik.app.ActiveCell;
            MessageBox.Show(r.Offset[1, 0].Address);
            MessageBox.Show(((Excel.Range)MyStatik.app.Cells[1, 1]).Value); //intellisensli 
        }

        private void group2_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            frmSetting1 f = new frmSetting1();
            f.Show();
        }

        private void button13_Click(object sender, RibbonControlEventArgs e)
        {
            string adres = @"E:\OneDrive\Dökümanlar\bütçem.xlsx";
            MyStatik.app.Workbooks.Open(adres);
        }

        private void button14_Click(object sender, RibbonControlEventArgs e)
        {
            //            
        }

        private void gallery1_Click(object sender, RibbonControlEventArgs e)
        {
            switch (this.gallery1.SelectedItemIndex)
            {
                case 0:
                    MessageBox.Show("ilk item seçildi");
                    break;
                case 1:
                    MessageBox.Show("ikinci item sçeildi");
                    break;
                default:
                    MessageBox.Show("Buraya gelmemeli");
                    break;
            }
        }

        private void splitButton1_Click(object sender, RibbonControlEventArgs e)
        {
            //split1in default butonu            
        }


        private void button26_Click(object sender, RibbonControlEventArgs e)
        {
            //splitin içindeki ilk buton
        }

        private void button30_Click(object sender, RibbonControlEventArgs e)
        {
            this.myusercontrol1 = new MyUserControl();
            this.myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(this.myusercontrol1, "İlk Task Pane");
            this.myCustomTaskPane.Visible = true;
            this.myCustomTaskPane.Width = 200;
        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)           
        {
            Globals.Ribbons.Ribbon1.tab3.Visible = toggleButton1.Checked; //ribbonu görünür kılıyoruz           
            if (toggleButton1.Checked)
            {
                Globals.Ribbons.Ribbon1.RibbonUI.ActivateTab("tab3");//sonra da aktif hale getiriyoruz            
            }            
        }
    }
}
