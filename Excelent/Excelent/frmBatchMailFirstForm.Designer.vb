<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchMailFirstForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnDevam = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ww = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cblg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cd1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cd2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cd3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cd4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(12, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Aşağıdaki formatta listem var"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Enabled = False
        Me.btnExcel.Location = New System.Drawing.Point(176, 13)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(127, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel Şablonu oluştur"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnDevam
        '
        Me.btnDevam.Location = New System.Drawing.Point(584, 129)
        Me.btnDevam.Name = "btnDevam"
        Me.btnDevam.Size = New System.Drawing.Size(90, 34)
        Me.btnDevam.TabIndex = 2
        Me.btnDevam.Text = "Devam"
        Me.btnDevam.UseVisualStyleBackColor = True
        '
        'btnIptal
        '
        Me.btnIptal.Location = New System.Drawing.Point(681, 129)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(87, 34)
        Me.btnIptal.TabIndex = 3
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ww, Me.ccc, Me.cbcc, Me.csb, Me.cblg, Me.cd1, Me.cd2, Me.cd3, Me.cd4, Me.cack})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(741, 45)
        Me.DataGridView1.TabIndex = 4
        '
        'ww
        '
        Me.ww.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ww.HeaderText = "To"
        Me.ww.Name = "ww"
        Me.ww.ReadOnly = True
        Me.ww.Width = 43
        '
        'ccc
        '
        Me.ccc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ccc.HeaderText = "CC"
        Me.ccc.Name = "ccc"
        Me.ccc.ReadOnly = True
        Me.ccc.Width = 44
        '
        'cbcc
        '
        Me.cbcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cbcc.HeaderText = "BCC"
        Me.cbcc.Name = "cbcc"
        Me.cbcc.ReadOnly = True
        Me.cbcc.Width = 51
        '
        'csb
        '
        Me.csb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.csb.HeaderText = "Şube kodu"
        Me.csb.Name = "csb"
        Me.csb.ReadOnly = True
        Me.csb.Width = 82
        '
        'cblg
        '
        Me.cblg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cblg.HeaderText = "Bölge kodu"
        Me.cblg.Name = "cblg"
        Me.cblg.ReadOnly = True
        Me.cblg.Width = 84
        '
        'cd1
        '
        Me.cd1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cd1.HeaderText = "Değişken1"
        Me.cd1.Name = "cd1"
        Me.cd1.ReadOnly = True
        Me.cd1.Width = 81
        '
        'cd2
        '
        Me.cd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cd2.HeaderText = "Değişken2"
        Me.cd2.Name = "cd2"
        Me.cd2.ReadOnly = True
        Me.cd2.Width = 81
        '
        'cd3
        '
        Me.cd3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cd3.HeaderText = "Değişken3"
        Me.cd3.Name = "cd3"
        Me.cd3.ReadOnly = True
        Me.cd3.Width = 81
        '
        'cd4
        '
        Me.cd4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cd4.HeaderText = "Değişken4"
        Me.cd4.Name = "cd4"
        Me.cd4.ReadOnly = True
        Me.cd4.Width = 81
        '
        'cack
        '
        Me.cack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.cack.HeaderText = "Açıklama"
        Me.cack.Name = "cack"
        Me.cack.ReadOnly = True
        Me.cack.Width = 73
        '
        'frmBatchMailFirstForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 175)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnDevam)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "frmBatchMailFirstForm"
        Me.Text = "Mail Gönderimi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnDevam As System.Windows.Forms.Button
    Friend WithEvents btnIptal As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ww As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbcc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents csb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cblg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cack As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
