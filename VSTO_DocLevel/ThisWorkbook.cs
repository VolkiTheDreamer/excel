using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace VSTO_DocLevel
{
    public partial class ThisWorkbook
    {
        private MyUsercontrol uc;

        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            //MessageBox.Show("Merhaba Doc Level");
            uc = new MyUsercontrol();            
            this.ActionsPane.Controls.Add(uc);
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
