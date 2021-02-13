using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using VolkansUtility;
using System.Text.RegularExpressions;

namespace BusinessGlossaryControls
{
    delegate int Fuzzymetods(string s1, string s2);
    public partial class frmFuzzy : Form
    {
        public frmFuzzy()
        {
            InitializeComponent();
        }

        public Excel.Application app = Globals.ThisAddIn.Application;

        private void frmFuzzy_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0; //ilk eleman seçili gelsin
        }

        private void chkIsBaseActiveWb_CheckedChanged(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.chkIsBaseActiveWb.Visible;
        }

        private void chkIsCompareActiveWB_CheckedChanged(object sender, EventArgs e)
        {
            this.panel2.Visible = !this.chkIsCompareActiveWB.Visible;
        }

        private void txtBase_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            this.txtBase.Text = fd.FileName;
        }

        private void txtCompare_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            this.txtCompare.Text = fd.FileName;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex==-0)
            {
                this.panel1.Visible = false;
                this.lbloutputbilgi.Visible = true;
            }
            else
            {
                this.panel1.Visible = true;
                this.lbloutputbilgi.Visible = false;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<string, string, int> _wbws = null; //_ işareti de değişken isimlerinde kullanılabiliyor
                Tuple<string, string, int> _wbws_compare = null;
                var awb = this.app.ActiveWorkbook;
                if (!awb.Name.Contains("xls")) //yeni yaratılan Book1 tarzı bir dosyas ise geçici kaydetcez
                    awb.Save(); //burda kullanıcıya konum sorar
                var aws = (Excel.Worksheet)this.app.ActiveSheet; //casting yapıyoruz

                if (this.chkIsBaseActiveWb.Checked)
                {
                    Excel.Range col;
                    try
                    {
                        col = awb.Application.InputBox("terimlerin olduğu konlonu seçiniz", Type: 8);
                    }
                    catch (Exception) //seçim yapılmazsa
                    {
                        return;
                    }
                    _wbws = Tuple.Create(awb.FullName, aws.Name, col.Column - 1);
                }
                else
                {
                    _wbws = Tuple.Create(this.txtBase.Text, this.txtBaseSheet.Text, int.Parse(this.txtBaseKolon.Text) - 1);
                }

                if (this.chkIsCompareActiveWB.Checked && !this.chkIsBaseActiveWb.Checked)
                {
                    Excel.Range col;
                    try
                    {
                        col = awb.Application.InputBox("terimlerin olduğu konlonu seçiniz", Type: 8);
                    }
                    catch (Exception) //seçim yapılmazsa
                    {
                        return;
                    }
                    _wbws_compare = Tuple.Create(awb.FullName, aws.Name, col.Column - 1);
                }
                else if (this.chkIsCompareActiveWB.Checked && this.chkIsBaseActiveWb.Checked)
                {
                    _wbws_compare = _wbws;
                }
                else
                {
                    _wbws_compare = Tuple.Create(this.txtCompare.Text, this.txtCompareSheet.Text, int.Parse(this.txtCompareKolon.Text) - 1);
                }

                int _esik = int.Parse(this.txtEsik.Text);
                string _hedef;
                if (this.comboBox1.SelectedIndex == 0)
                    _hedef = awb.FullName;
                else
                    _hedef = System.IO.Path.GetDirectoryName(awb.FullName) + "\\" + this.txtOutput.Text + ".xlsx";

                bool _isSameFile = false; //kendisiyle karşılaştırılacaksa boşluna işlem yapmasın diye. aşağıda kullanıcaz
                if ((this.chkIsBaseActiveWb.Checked && this.chkIsCompareActiveWB.Checked) || (this.txtBase.Text == this.txtCompare.Text))
                    _isSameFile = true;

                voltran(false, false, false);
                MessageBox.Show("Partial olanlada 100 olanlara bak");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voltran(true, true, true);
            }

            void voltran(bool screenupdating, bool eneableevents, bool displayalertes)
            {
                Globals.ThisAddIn.Application.ScreenUpdating = screenupdating;
                Globals.ThisAddIn.Application.EnableEvents = eneableevents;
                Globals.ThisAddIn.Application.DisplayAlerts = displayalertes
            }

            void fuzzyBbul(Tuple<string,string,int> wbws, Tuple<string,string,int> wbws_comp, int esik, string hedef, bool isSamefile)
            {
                string dosya = @"jargon söszlüğü";

                //sol-sağ ikilisinde içinde şunlar olan karşılaştırmalar yapılmayacak, skor hesplaanmayacak, yani "benzer değil" denecek
                DataTable d1 = ExcelRW.ReadFromExcelIntoDTWithExcelReader(dosya, "exceptionlar");
                DataTable dx = ConvertToLowercase(d1); //tüm içerik lowercase yapılıyor
                var exceptionList = dx.DatatabletoLookup<string, string>(0, 1);

                //jargon listesi: bunlar hem soldalkinde hem sağdakinde replace edilecek. lowercase olarak okunacak
                DataTable d2 = ExcelRW.ReadFromExcelIntoDTWithExcelReader(dosya, "jargon");
                DataTable dj = ConvertToLowercase(d2);
                var jargonDict = dj.DatatableToListOfTuples<string,string,string>(0,1,2);

                //solda(rg1) ....lı, sağda(rg2) ....sız gibi olanlar elensin(keza tersi de), bunlara da "benzer değil" denecek
                ///alttaki soruya bak
                Regex rg1 = new Regex(@"l[ıiuü]\)|l[ıiuü]\s"); //ör:kartlı müşteri adedi--->ikisine gerek var mı?, sadece ilki?
                Regex rg2 = new Regex(@"s.z\)|s.z\s");//keza bunda da???
                //burda benzer bir yapı olan-olmayan, ikilisi için de yapılabilir ama biz basitlik adına eklemiyoruz

                //şunlar çin kelime kökü alma işlemi yapılacak
                Regex rg3 = new Regex(@"l.ş.n"); //ör:aktifleşen

                //ilk terim listesini okuyoruz
                var terimler = new List<string>();
                if (this.chkIsBaseActiveWb.Checked)
                {
                    Excel.Range bas = this.app.Cells[2, wbws.Item3 + 1];
                    Excel.Range alan = this.app.Range[bas, bas.End[Excel.XlDirection.xlDown]];
                    terimler = Conversion.rangeToList(alan, true, true).Select(x => x.ToLower()).ToList();
                }
                else
                {
                    DataTable d3 = ExcelRW.ReadFromExcelIntoDTWithExcelReader(wbws.Item1, wbws.Item2);
                    DataTable dt1 = ConvertToLowercase(d3);
                    terimler = dt1.DatatableKolonToList<string>(wbws.Item3).Distinct().ToList(); //nolur nolmaz distincleştirelim
                }

                var tTemp = PreprocessList(terimler);

                //ikinci terim listesini alalım
                var comparison = new List<string>();
                if (isSamefile)
                    comparison = terimler.ToList();
                else
                {
                    if (this.chkIsCompareActiveWB.Checked)
                    {
                        Excel.Range bas = this.app.Cells[2, wbws_comp.Item3 + 1];
                        Excel.Range alan = this.app.Range[bas, bas.End[Excel.XlDirection.xlDown]];
                        comparison = Conversion.rangeToList(alan, true, true).Select(x => x.ToLower()).ToList();
                    }
                    else
                    {
                        DataTable d4 = ExcelRW.ReadFromExcelIntoDTWithOledDB(wbws_comp.Item1, wbws_comp.Item2);
                        DataTable dt2 = ConvertToLowercase(d4);
                        comparison = dt2.DatatableKolonToList<string>(wbws_comp.Item3).Distinct().ToList();
                    }
                }
                var cTemp = PreprocessList(comparison);

                //jargon/sinonim renaming işlemi
                ///BURADA KLADOIM



                //*****************yardımcı fonksiyonlar**************************
                DataTable ConvertToLowercase(DataTable d)
                {
                    foreach (DataColumn dc in d.Columns)
                    {
                        foreach (DataRow dr in d.Rows)
                        {
                            try
                            {
                                dr[dc] = dr[dc].ToString().ToLower();
                            }
                            catch (Exception)
                            {
                                //boş olanlar için
                            }
                        }
                    }
                    return d;
                }

                //sırayla ounctutation&sayılar->boşulk dönüştürme, trimleme ve kök bulma
                List<string> PreprocessList(List<string> terimler)
                {
                    throw new NotImplementedException();
                }
            }


           
        }

        
    }
}
