using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTOcsharp
{
    public partial class frmSetting1 : Form
    {
        public frmSetting1()
        {
            InitializeComponent();
        }

        private void frmSetting1_Load(object sender, EventArgs e)
        {
            this.txtKlasor.Text = Properties.Settings.Default.Anaklasor;
            this.txtSheetAded.Text = Properties.Settings.Default.YeniWbSheetAdedi.ToString();
            this.renkliTextBox1.Controls[0].Text= Properties.Settings.Default.Anaklasor;
        }

        private void frmSetting1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Anaklasor = this.txtKlasor.Text;
            Properties.Settings.Default.YeniWbSheetAdedi = int.Parse(this.txtSheetAded.Text);//parsing, string bir ifadeden sayısal metin çıkarma işlemidir
            Properties.Settings.Default.Anaklasor=this.renkliTextBox1.Controls[0].Text;
            Properties.Settings.Default.Save(); //bunu yazmazsak ayarlar kaydolmaz
        }
    }
}
