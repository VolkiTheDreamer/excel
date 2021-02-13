namespace BusinessGlossaryControls
{
    partial class frmFuzzy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsBaseActiveWb = new System.Windows.Forms.CheckBox();
            this.chkIsCompareActiveWB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBaseKolon = new System.Windows.Forms.TextBox();
            this.txtBaseSheet = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCompareKolon = new System.Windows.Forms.TextBox();
            this.txtCompareSheet = new System.Windows.Forms.TextBox();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.txtEsik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbloutputbilgi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baz dosya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Karşılaştırma dosyası";
            // 
            // chkIsBaseActiveWb
            // 
            this.chkIsBaseActiveWb.AutoSize = true;
            this.chkIsBaseActiveWb.Location = new System.Drawing.Point(168, 30);
            this.chkIsBaseActiveWb.Name = "chkIsBaseActiveWb";
            this.chkIsBaseActiveWb.Size = new System.Drawing.Size(80, 17);
            this.chkIsBaseActiveWb.TabIndex = 2;
            this.chkIsBaseActiveWb.Text = "Aktif Dosya";
            this.chkIsBaseActiveWb.UseVisualStyleBackColor = true;
            this.chkIsBaseActiveWb.CheckedChanged += new System.EventHandler(this.chkIsBaseActiveWb_CheckedChanged);
            // 
            // chkIsCompareActiveWB
            // 
            this.chkIsCompareActiveWB.AutoSize = true;
            this.chkIsCompareActiveWB.Checked = true;
            this.chkIsCompareActiveWB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsCompareActiveWB.Location = new System.Drawing.Point(168, 82);
            this.chkIsCompareActiveWB.Name = "chkIsCompareActiveWB";
            this.chkIsCompareActiveWB.Size = new System.Drawing.Size(80, 17);
            this.chkIsCompareActiveWB.TabIndex = 3;
            this.chkIsCompareActiveWB.Text = "Aktif Dosya";
            this.chkIsCompareActiveWB.UseVisualStyleBackColor = true;
            this.chkIsCompareActiveWB.CheckedChanged += new System.EventHandler(this.chkIsCompareActiveWB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBaseKolon);
            this.panel1.Controls.Add(this.txtBaseSheet);
            this.panel1.Controls.Add(this.txtBase);
            this.panel1.Location = new System.Drawing.Point(265, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 33);
            this.panel1.TabIndex = 4;
            // 
            // txtBaseKolon
            // 
            this.txtBaseKolon.Location = new System.Drawing.Point(673, 5);
            this.txtBaseKolon.Name = "txtBaseKolon";
            this.txtBaseKolon.Size = new System.Drawing.Size(54, 20);
            this.txtBaseKolon.TabIndex = 2;
            this.txtBaseKolon.Text = "3";
            // 
            // txtBaseSheet
            // 
            this.txtBaseSheet.Location = new System.Drawing.Point(518, 4);
            this.txtBaseSheet.Name = "txtBaseSheet";
            this.txtBaseSheet.Size = new System.Drawing.Size(142, 20);
            this.txtBaseSheet.TabIndex = 1;
            this.txtBaseSheet.Text = "Terimler";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(4, 4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(505, 20);
            this.txtBase.TabIndex = 0;
            this.txtBase.Text = "C:\\falanca\\terimler.xlsx";
            this.txtBase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBase_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCompareKolon);
            this.panel2.Controls.Add(this.txtCompareSheet);
            this.panel2.Controls.Add(this.txtCompare);
            this.panel2.Location = new System.Drawing.Point(265, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 34);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // txtCompareKolon
            // 
            this.txtCompareKolon.Location = new System.Drawing.Point(671, 11);
            this.txtCompareKolon.Name = "txtCompareKolon";
            this.txtCompareKolon.Size = new System.Drawing.Size(54, 20);
            this.txtCompareKolon.TabIndex = 2;
            // 
            // txtCompareSheet
            // 
            this.txtCompareSheet.Location = new System.Drawing.Point(516, 10);
            this.txtCompareSheet.Name = "txtCompareSheet";
            this.txtCompareSheet.Size = new System.Drawing.Size(142, 20);
            this.txtCompareSheet.TabIndex = 1;
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(2, 10);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(505, 20);
            this.txtCompare.TabIndex = 0;
            this.txtCompare.Text = "Karşılaştırılacak dosyayı seçmek için çifttıkalyın";
            this.txtCompare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCompare_MouseDoubleClick);
            // 
            // txtEsik
            // 
            this.txtEsik.Location = new System.Drawing.Point(177, 135);
            this.txtEsik.Name = "txtEsik";
            this.txtEsik.Size = new System.Drawing.Size(100, 20);
            this.txtEsik.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eşif değer";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aktif Dosyada",
            "Yeni Dosyada"});
            this.comboBox1.Location = new System.Drawing.Point(177, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hedef dosya adı";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(142, 12);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(449, 20);
            this.txtOutput.TabIndex = 11;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(177, 268);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Çalıştır";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbloutputbilgi
            // 
            this.lbloutputbilgi.AutoSize = true;
            this.lbloutputbilgi.Location = new System.Drawing.Point(315, 177);
            this.lbloutputbilgi.Name = "lbloutputbilgi";
            this.lbloutputbilgi.Size = new System.Drawing.Size(302, 13);
            this.lbloutputbilgi.TabIndex = 13;
            this.lbloutputbilgi.Text = "Dosya geçici olarak kapatılacak ve kapatılırken kaydedeilecek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(1000den fazla olmasın, sadece yeniler için çaklıştır mümkünse)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtOutput);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(26, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 49);
            this.panel3.TabIndex = 15;
            this.panel3.Visible = false;
            // 
            // frmFuzzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 341);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbloutputbilgi);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEsik);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkIsCompareActiveWB);
            this.Controls.Add(this.chkIsBaseActiveWb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFuzzy";
            this.Text = "frmFuzzy";
            this.Load += new System.EventHandler(this.frmFuzzy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsBaseActiveWb;
        private System.Windows.Forms.CheckBox chkIsCompareActiveWB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBaseKolon;
        private System.Windows.Forms.TextBox txtBaseSheet;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCompareKolon;
        private System.Windows.Forms.TextBox txtCompareSheet;
        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.TextBox txtEsik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lbloutputbilgi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
    }
}