using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using MyUDFs;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.IO;


namespace VSTO_UDF
{
 

    public partial class ThisAddIn
    {        
        MyFunctions functionsAddinRef = null;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            MyUDFYukle();
            VBA_Addin_Yukle("VBAAddinForVstoUdf.xlam", Properties.Resources.VBAAddinForVstoUdf);
            VBA_Addin_Yukle("VBAAddinForVstoUdf2.xlam", Properties.Resources.VBAAddinForVstoUdf2);
        }

        private void MyUDFYukle()
        {
            try
            {
                functionsAddinRef = new MyFunctions();
                string NAME = functionsAddinRef.GetType().Namespace + "." + functionsAddinRef.GetType().Name;
                string GUID = functionsAddinRef.GetType().GUID.ToString().ToUpper();

                // is the add-in already loaded in Excel, but maybe disabled
                // if this is the case - try to re-enable it
                bool fFound = false;
                foreach (Excel.AddIn a in Application.AddIns)
                {
                    try
                    {
                        if (a.CLSID.Contains(GUID))
                        {
                            fFound = true;
                            if (!a.Installed)
                                a.Installed = true;
                            break;
                        }
                    }
                    catch { }
                }
                System.Windows.Forms.MessageBox.Show("Test1");
                //if we do not see the UDF class in the list of installed addin we need to
                // add it to the collection
                if (!fFound)
                {
                    // first register it
                    System.Windows.Forms.MessageBox.Show("Test2");
                    functionsAddinRef.Register();
                    System.Windows.Forms.MessageBox.Show("Test3");
                    // then install it
                    Excel.Workbook tempwb = this.Application.Workbooks.Add(); //geçici yaratıyoruz, hiç açık dosya yoksa hata alıyoruz çünkü
                    this.Application.AddIns.Add(NAME).Installed = true; //Bunlarda Namespace.Class şekilnde eklemek yeterli
                    tempwb.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void VBA_Addin_Yukle(string vbaAddin, byte[] res)
        {
            //ilk kurulduğunda var mı diye baksın, varsa işaretli mi yani installed mu diye de baksın
            try
            {
                bool isExist = false;
                foreach (Excel.AddIn a in Application.AddIns)
                {
                    if (a.Name == vbaAddin) //listede varsa ve kurulu değilse kur ve çık, kuruluysa bişey yapmadan çık
                    {
                        if (!a.Installed)
                            a.Installed = true;
                        isExist = true;
                        break;
                    }
                }

                if (isExist == false)
                {
                    Excel.Workbook tempwb = this.Application.Workbooks.Add(); //geçici yaratıyoruz, hiç açık dosya yoksa hata alıyoruz çünkü
                    string hedefdosya = "";
                    if (IsDirectoryWritable(Application.UserLibraryPath)) //kullanıcının yazma izni var mı diye kontrol ediyoruz
                        hedefdosya = Application.UserLibraryPath + vbaAddin;
                    else 
                        hedefdosya = Environment.SpecialFolder.LocalApplicationData.ToString() + vbaAddin; //buraya kesin izni vardır
                    
                    File.WriteAllBytes(hedefdosya, res);
                    this.Application.AddIns.Add(hedefdosya).Installed = true; //ekle ve kur tek satırda
                    tempwb.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        
        public bool IsDirectoryWritable(string dirPath, bool throwIfFails = false)
        {
            try
            {
                using (FileStream fs = File.Create(
                    Path.Combine(
                        dirPath,
                        Path.GetRandomFileName()
                    ),
                    1,
                    FileOptions.DeleteOnClose)
                )
                { }
                return true;
            }
            catch
            {
                if (throwIfFails)
                    throw;
                else
                    return false;
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
                

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
