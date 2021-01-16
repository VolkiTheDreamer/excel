using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTOcsharp
{
    public partial class MyUserControl : UserControl
    {
        public Microsoft.Office.Interop.Excel.Application app = Globals.ThisAddIn.Application;
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void MyUserControl_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add(1);
            this.comboBox1.Items.Add(2);
            this.comboBox1.SelectedIndex = 0; //ilk değeri seçiyoruz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.ActiveCell.Value = this.comboBox1.SelectedItem.ToString();
        }
    }
}
