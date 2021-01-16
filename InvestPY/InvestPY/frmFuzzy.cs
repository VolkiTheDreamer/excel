using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InvestPY
{
    public partial class frmFuzzy : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public frmFuzzy()
        {
            InitializeComponent();
        }

        private void frmFuzzy_Load(object sender, EventArgs e)
        {   
            dict.Add("artan", "azalan");
            dict.Add("tl", "yp");
            dict.Add("aktif", "inaktif");

            var result = from d in dict
                         select new { d.Key, d.Value };
            this.dataGridView1.DataSource = result.ToList();//kullanıcıya istisna listesi içeriği hakkında bilgi veriyoruz, istenirse buradan yeni key-value ikililieri de girilecek şekilde ayarlanabilir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pyfile = @"E:\OneDrive\Dökümanlar\GitHub\dotnet\Ugulamalar\InvestPY\vstofuzzy.py";
            string istisnaJson = JsonConvert.SerializeObject(dict).Replace("\"","\\\"");//Dicitionar>Json dönşüm işlemi burada. Jsonda özel anlamı olan " işaretlerini \" şeklinde gönderiyoruz ki bunları gerçek " gibi algılasın
            Process process;
            ProcessStartInfo start = new ProcessStartInfo(this.txtPythonexe.Text); //Filename propertysi yerine direkt yaratım sırasında da parametre verebiliyoruz
            start.Arguments = string.Format("{0} \"{1}\" \"{2}\" {3} \"{4}\" {5}", pyfile, this.txtSource.Text, this.txtKolon.Text, this.txtEsik.Text, this.txtTarget.Text, istisnaJson); //source, kolon ve target kolonlarında boşluk olabilir diye ilave tırnak ekliyoruz
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
                        MessageBox.Show(string.Format("Sonuç:{0}", result));
                    else
                    {
                        MessageBox.Show(string.Format("Sonuç:{0}", stderr));
                    }
                }
            }

        }
    }
}
