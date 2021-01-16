namespace VSTOcsharp
{
    partial class frmSetting1
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
            this.txtKlasor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSheetAded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.renkliTextBox1 = new VSTOcsharp.RenkliTextBox();
            this.SuspendLayout();
            // 
            // txtKlasor
            // 
            this.txtKlasor.Location = new System.Drawing.Point(124, 31);
            this.txtKlasor.Name = "txtKlasor";
            this.txtKlasor.Size = new System.Drawing.Size(489, 22);
            this.txtKlasor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ana klasör";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "yeni sheet adedi";
            // 
            // txtSheetAded
            // 
            this.txtSheetAded.Location = new System.Drawing.Point(166, 65);
            this.txtSheetAded.Name = "txtSheetAded";
            this.txtSheetAded.Size = new System.Drawing.Size(57, 22);
            this.txtSheetAded.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "renkli kutu";
            // 
            // renkliTextBox1
            // 
            this.renkliTextBox1.Location = new System.Drawing.Point(138, 118);
            this.renkliTextBox1.Name = "renkliTextBox1";
            this.renkliTextBox1.Size = new System.Drawing.Size(475, 81);
            this.renkliTextBox1.TabIndex = 4;
            // 
            // frmSetting1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.renkliTextBox1);
            this.Controls.Add(this.txtSheetAded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKlasor);
            this.Name = "frmSetting1";
            this.Text = "frmSetting1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting1_FormClosing);
            this.Load += new System.EventHandler(this.frmSetting1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKlasor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSheetAded;
        private RenkliTextBox renkliTextBox1;
        private System.Windows.Forms.Label label3;
    }
}