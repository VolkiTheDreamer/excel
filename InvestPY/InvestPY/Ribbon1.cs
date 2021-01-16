using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace InvestPY
{
    public partial class Ribbon1
    {
        Process process;
        bool iptal = false;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //ilk değer atamaları
            this.editBox1.Text = DateTime.Today.AddDays(-10).ToString("dd/MM/yyyy").Replace(".", "/");
            this.editBox2.Text = DateTime.Today.ToString("dd/MM/yyyy").Replace(".","/");
            this.editBox3.Text = @"C:\Invest\sonuclar.xlsx"; //bu ve alttaki settings formuna koyarak da yapılabilir, siz böyle deneyin
            this.editBox4.Text = @"C:\Users\volka\AppData\Local\Programs\Python\Python38\python.exe";
        }

        private async void button1_ClickAsync(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.Application.StatusBar = "Lüfen bekleyiniz..."; //daha görünür olması için A1'e de yazdırabiliriz
            iptal = false;
            string mesaj = await fetchdata();
            
            Globals.ThisAddIn.Application.StatusBar = "";

            if (iptal)
            {
                MessageBox.Show("İptal edildi");
            }
            else
            {
                Globals.ThisAddIn.Application.Workbooks.Open(this.editBox3.Text);

                if (mesaj.Length < 100)
                    MessageBox.Show(mesaj);
                else
                {
                    Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets.Add();
                    ws.Name = "Sonuç-Hata mesajı";
                    ws.Cells[1, 1] = mesaj;
                }
            }
        }

        private async Task<string> fetchdata()
        {
            
            string sonuc = await Task.Run(() =>
            {
                string pyfile = @"E:\OneDrive\Dökümanlar\GitHub\dotnet\Ugulamalar\InvestPY\myinvestpy.py";

                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = this.editBox4.Text;
                start.Arguments = pyfile + " " + this.editBox1.Text + " " + this.editBox2.Text + " " + this.editBox3.Text;
                start.UseShellExecute = false;
                start.CreateNoWindow = true;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true; 

                using (process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string stderr = process.StandardError.ReadToEnd(); 
                        string result = reader.ReadToEnd();
                        
                        if (string.IsNullOrEmpty(stderr))
                            return string.Format("Sonuç:{0}", result);
                        else
                            return string.Format("Hata:{0}", stderr);
                    }
                }
            });
            return sonuc;

        }

        private void group1_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.Show();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            process.Kill();
            iptal = true;
            Globals.ThisAddIn.Application.StatusBar = "";            
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start("calc"); //exe uzantısına gerek yok
            Process.Start("notepad.exe", @"E:\OneDrive\Dökümanlar\GitHub\dotnet\Ugulamalar\InvestPY\myinvestpy.py");
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            Process notePad = new Process();
            notePad.StartInfo.FileName = "jupyter";
            notePad.StartInfo.Arguments = "notebook";
            notePad.Start();
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            
            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = "www.excelinefendisi.com";
            start.FileName = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge";           
            int exitCode;

            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();
                exitCode = proc.ExitCode;
                MessageBox.Show(exitCode.ToString()); //sorunsuz ise 0 çıkar
            }
        }

        private void button6_Click(object sender, RibbonControlEventArgs e)
        {
            frmFuzzy f = new frmFuzzy();
            f.Show();
        }
    }
}
