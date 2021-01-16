namespace VSTO_DigerOffice
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnTekRelease = this.Factory.CreateRibbonButton();
            this.btnLoopRelease = this.Factory.CreateRibbonButton();
            this.btnFinalRelease = this.Factory.CreateRibbonButton();
            this.btnGC = this.Factory.CreateRibbonButton();
            this.btnTwoDotIhlal = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.btnAccess = this.Factory.CreateRibbonButton();
            this.btnExcelOledb = this.Factory.CreateRibbonButton();
            this.btnExcelReader = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "MSOffice";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnTekRelease);
            this.group1.Items.Add(this.btnLoopRelease);
            this.group1.Items.Add(this.btnFinalRelease);
            this.group1.Items.Add(this.btnGC);
            this.group1.Items.Add(this.btnTwoDotIhlal);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.btnAccess);
            this.group1.Items.Add(this.btnExcelOledb);
            this.group1.Items.Add(this.btnExcelReader);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // btnTekRelease
            // 
            this.btnTekRelease.Label = "Mail1-Tek Release";
            this.btnTekRelease.Name = "btnTekRelease";
            this.btnTekRelease.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTekRelease_Click);
            // 
            // btnLoopRelease
            // 
            this.btnLoopRelease.Label = "Mail2-LoopRelease";
            this.btnLoopRelease.Name = "btnLoopRelease";
            this.btnLoopRelease.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLoopRelease_Click);
            // 
            // btnFinalRelease
            // 
            this.btnFinalRelease.Label = "Mail3-FinalRelease";
            this.btnFinalRelease.Name = "btnFinalRelease";
            this.btnFinalRelease.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnFinalRelease_Click);
            // 
            // btnGC
            // 
            this.btnGC.Label = "Mail4-GC";
            this.btnGC.Name = "btnGC";
            this.btnGC.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGC_Click);
            // 
            // btnTwoDotIhlal
            // 
            this.btnTwoDotIhlal.Label = "Mail-Two Dot ihlali";
            this.btnTwoDotIhlal.Name = "btnTwoDotIhlal";
            this.btnTwoDotIhlal.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTwoDotIhlal_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // btnAccess
            // 
            this.btnAccess.Label = "Access\'ten veri al";
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAccess_Click);
            // 
            // btnExcelOledb
            // 
            this.btnExcelOledb.Label = "Excelden veri çek-OleDb";
            this.btnExcelOledb.Name = "btnExcelOledb";
            this.btnExcelOledb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExcelOledb_Click);
            // 
            // btnExcelReader
            // 
            this.btnExcelReader.Label = "Excelden veri çek-ExcelReader";
            this.btnExcelReader.Name = "btnExcelReader";
            this.btnExcelReader.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExcelReader_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTekRelease;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAccess;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLoopRelease;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnFinalRelease;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGC;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTwoDotIhlal;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExcelOledb;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExcelReader;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
