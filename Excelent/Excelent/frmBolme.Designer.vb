<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBolme
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBolme))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKlasor = New System.Windows.Forms.Label()
        Me.txtKlasor = New System.Windows.Forms.TextBox()
        Me.txtBaslikSatir = New System.Windows.Forms.TextBox()
        Me.lblBaslikSatir = New System.Windows.Forms.Label()
        Me.lblPrivateSign = New System.Windows.Forms.Label()
        Me.txtPrivateSign = New System.Windows.Forms.TextBox()
        Me.txtBoslukConvert = New System.Windows.Forms.TextBox()
        Me.lblBoslukConvert = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAyracIsaret = New System.Windows.Forms.ComboBox()
        Me.lblAyracAciklama = New System.Windows.Forms.Label()
        Me.grpKaynak = New System.Windows.Forms.GroupBox()
        Me.rbKaynakUniqWB = New System.Windows.Forms.RadioButton()
        Me.rbKaynakActiveSheet = New System.Windows.Forms.RadioButton()
        Me.cbKacKolonaGore = New System.Windows.Forms.ComboBox()
        Me.lblKacKolonaGore = New System.Windows.Forms.Label()
        Me.lblAyracIsaret = New System.Windows.Forms.Label()
        Me.grpDosyaFormat = New System.Windows.Forms.GroupBox()
        Me.rbFormatPDF = New System.Windows.Forms.RadioButton()
        Me.rbFormatXl = New System.Windows.Forms.RadioButton()
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.rbLytNo = New System.Windows.Forms.RadioButton()
        Me.rbLytLand = New System.Windows.Forms.RadioButton()
        Me.rbLytPrt = New System.Windows.Forms.RadioButton()
        Me.btnDevam = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpKaynak.SuspendLayout()
        Me.grpDosyaFormat.SuspendLayout()
        Me.grpLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UYARI:Hangi alana göre bölecekseniz o alan ilk sütunda olmalı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.ImageKey = "(none)"
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'lblKlasor
        '
        Me.lblKlasor.AutoSize = True
        Me.lblKlasor.Location = New System.Drawing.Point(21, 22)
        Me.lblKlasor.Name = "lblKlasor"
        Me.lblKlasor.Size = New System.Drawing.Size(68, 13)
        Me.lblKlasor.TabIndex = 2
        Me.lblKlasor.Text = "Kayıt Klasörü"
        '
        'txtKlasor
        '
        Me.txtKlasor.ForeColor = System.Drawing.Color.Red
        Me.txtKlasor.Location = New System.Drawing.Point(116, 19)
        Me.txtKlasor.Name = "txtKlasor"
        Me.txtKlasor.Size = New System.Drawing.Size(148, 20)
        Me.txtKlasor.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtKlasor, "Bölünen dosyaların nereye kaydedilmesini istiyorsanız onu belirtiniz.")
        '
        'txtBaslikSatir
        '
        Me.txtBaslikSatir.Location = New System.Drawing.Point(116, 47)
        Me.txtBaslikSatir.Name = "txtBaslikSatir"
        Me.txtBaslikSatir.Size = New System.Drawing.Size(51, 20)
        Me.txtBaslikSatir.TabIndex = 4
        Me.txtBaslikSatir.Text = "1"
        Me.ToolTip1.SetToolTip(Me.txtBaslikSatir, "Kaç satır başlığınızı olduğunu yazın.")
        '
        'lblBaslikSatir
        '
        Me.lblBaslikSatir.AutoSize = True
        Me.lblBaslikSatir.Location = New System.Drawing.Point(21, 48)
        Me.lblBaslikSatir.Name = "lblBaslikSatir"
        Me.lblBaslikSatir.Size = New System.Drawing.Size(89, 13)
        Me.lblBaslikSatir.TabIndex = 5
        Me.lblBaslikSatir.Text = "Başlık Satır Adedi"
        '
        'lblPrivateSign
        '
        Me.lblPrivateSign.AutoSize = True
        Me.lblPrivateSign.Location = New System.Drawing.Point(21, 77)
        Me.lblPrivateSign.Name = "lblPrivateSign"
        Me.lblPrivateSign.Size = New System.Drawing.Size(84, 13)
        Me.lblPrivateSign.TabIndex = 6
        Me.lblPrivateSign.Text = "Özel işareti çevir"
        Me.ToolTip1.SetToolTip(Me.lblPrivateSign, "Bölme icra edilecek kolon(lar)da")
        '
        'txtPrivateSign
        '
        Me.txtPrivateSign.Location = New System.Drawing.Point(116, 75)
        Me.txtPrivateSign.Name = "txtPrivateSign"
        Me.txtPrivateSign.Size = New System.Drawing.Size(51, 20)
        Me.txtPrivateSign.TabIndex = 7
        Me.txtPrivateSign.Text = "_"
        Me.ToolTip1.SetToolTip(Me.txtPrivateSign, "Windows kuralları gereğince dosya isimlerinde " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bulunamayan karakterler varsa bun" & _
        "ların hangi karaktere " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "çevrilmesini istiyorsunuz?")
        '
        'txtBoslukConvert
        '
        Me.txtBoslukConvert.Location = New System.Drawing.Point(116, 103)
        Me.txtBoslukConvert.Name = "txtBoslukConvert"
        Me.txtBoslukConvert.Size = New System.Drawing.Size(51, 20)
        Me.txtBoslukConvert.TabIndex = 8
        Me.txtBoslukConvert.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtBoslukConvert, "Kodun doğru çalışması için listede boş hücre bulunmaması" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gerekiyor. Boş hücre va" & _
        "rsa bunlar neye çevrilsin?")
        '
        'lblBoslukConvert
        '
        Me.lblBoslukConvert.AutoSize = True
        Me.lblBoslukConvert.Location = New System.Drawing.Point(22, 106)
        Me.lblBoslukConvert.Name = "lblBoslukConvert"
        Me.lblBoslukConvert.Size = New System.Drawing.Size(88, 13)
        Me.lblBoslukConvert.TabIndex = 9
        Me.lblBoslukConvert.Text = "Boş hücreyi çevir"
        Me.ToolTip1.SetToolTip(Me.lblBoslukConvert, "Başlıktan sonraki ilk")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAyracIsaret)
        Me.GroupBox1.Controls.Add(Me.lblAyracAciklama)
        Me.GroupBox1.Controls.Add(Me.grpKaynak)
        Me.GroupBox1.Controls.Add(Me.cbKacKolonaGore)
        Me.GroupBox1.Controls.Add(Me.lblKacKolonaGore)
        Me.GroupBox1.Controls.Add(Me.lblAyracIsaret)
        Me.GroupBox1.Controls.Add(Me.grpDosyaFormat)
        Me.GroupBox1.Controls.Add(Me.grpLayout)
        Me.GroupBox1.Controls.Add(Me.lblBoslukConvert)
        Me.GroupBox1.Controls.Add(Me.txtBoslukConvert)
        Me.GroupBox1.Controls.Add(Me.txtPrivateSign)
        Me.GroupBox1.Controls.Add(Me.lblPrivateSign)
        Me.GroupBox1.Controls.Add(Me.lblBaslikSatir)
        Me.GroupBox1.Controls.Add(Me.txtBaslikSatir)
        Me.GroupBox1.Controls.Add(Me.txtKlasor)
        Me.GroupBox1.Controls.Add(Me.lblKlasor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 252)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "İşletimParametreleri"
        '
        'cbAyracIsaret
        '
        Me.cbAyracIsaret.FormattingEnabled = True
        Me.cbAyracIsaret.Items.AddRange(New Object() {"-", " - ", "_", " _ "})
        Me.cbAyracIsaret.Location = New System.Drawing.Point(433, 22)
        Me.cbAyracIsaret.Name = "cbAyracIsaret"
        Me.cbAyracIsaret.Size = New System.Drawing.Size(47, 21)
        Me.cbAyracIsaret.TabIndex = 16
        Me.cbAyracIsaret.Text = "-"
        Me.ToolTip1.SetToolTip(Me.cbAyracIsaret, "Bölünen dosyalarda parametrik kısımdan sonra hangi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ayracın kullanılmasını istiyo" & _
        "rsunuz?")
        '
        'lblAyracAciklama
        '
        Me.lblAyracAciklama.AutoSize = True
        Me.lblAyracAciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAyracAciklama.Location = New System.Drawing.Point(285, 35)
        Me.lblAyracAciklama.Name = "lblAyracAciklama"
        Me.lblAyracAciklama.Size = New System.Drawing.Size(185, 12)
        Me.lblAyracAciklama.TabIndex = 20
        Me.lblAyracAciklama.Text = "* Ayrac olarak Tire(-) kullanılacak                       "
        '
        'grpKaynak
        '
        Me.grpKaynak.Controls.Add(Me.rbKaynakUniqWB)
        Me.grpKaynak.Controls.Add(Me.rbKaynakActiveSheet)
        Me.grpKaynak.Location = New System.Drawing.Point(287, 139)
        Me.grpKaynak.Name = "grpKaynak"
        Me.grpKaynak.Size = New System.Drawing.Size(151, 68)
        Me.grpKaynak.TabIndex = 19
        Me.grpKaynak.TabStop = False
        Me.grpKaynak.Text = "Bölüneceklerin Kaynağı"
        Me.ToolTip1.SetToolTip(Me.grpKaynak, resources.GetString("grpKaynak.ToolTip"))
        Me.grpKaynak.UseCompatibleTextRendering = True
        '
        'rbKaynakUniqWB
        '
        Me.rbKaynakUniqWB.AutoSize = True
        Me.rbKaynakUniqWB.Location = New System.Drawing.Point(11, 41)
        Me.rbKaynakUniqWB.Name = "rbKaynakUniqWB"
        Me.rbKaynakUniqWB.Size = New System.Drawing.Size(116, 17)
        Me.rbKaynakUniqWB.TabIndex = 1
        Me.rbKaynakUniqWB.Text = "Ayrı bir dosyadan al"
        Me.ToolTip1.SetToolTip(Me.rbKaynakUniqWB, resources.GetString("rbKaynakUniqWB.ToolTip"))
        Me.rbKaynakUniqWB.UseVisualStyleBackColor = True
        '
        'rbKaynakActiveSheet
        '
        Me.rbKaynakActiveSheet.AutoSize = True
        Me.rbKaynakActiveSheet.Location = New System.Drawing.Point(11, 20)
        Me.rbKaynakActiveSheet.Name = "rbKaynakActiveSheet"
        Me.rbKaynakActiveSheet.Size = New System.Drawing.Size(105, 18)
        Me.rbKaynakActiveSheet.TabIndex = 0
        Me.rbKaynakActiveSheet.Text = "Aktif sayfadan al"
        Me.ToolTip1.SetToolTip(Me.rbKaynakActiveSheet, resources.GetString("rbKaynakActiveSheet.ToolTip"))
        Me.rbKaynakActiveSheet.UseCompatibleTextRendering = True
        Me.rbKaynakActiveSheet.UseVisualStyleBackColor = True
        '
        'cbKacKolonaGore
        '
        Me.cbKacKolonaGore.FormattingEnabled = True
        Me.cbKacKolonaGore.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbKacKolonaGore.Location = New System.Drawing.Point(433, 52)
        Me.cbKacKolonaGore.Name = "cbKacKolonaGore"
        Me.cbKacKolonaGore.Size = New System.Drawing.Size(47, 21)
        Me.cbKacKolonaGore.TabIndex = 18
        Me.cbKacKolonaGore.Text = "2"
        Me.ToolTip1.SetToolTip(Me.cbKacKolonaGore, "Kaç kolona göre bölmek istiyorsunuz?")
        '
        'lblKacKolonaGore
        '
        Me.lblKacKolonaGore.AutoSize = True
        Me.lblKacKolonaGore.Location = New System.Drawing.Point(287, 54)
        Me.lblKacKolonaGore.Name = "lblKacKolonaGore"
        Me.lblKacKolonaGore.Size = New System.Drawing.Size(138, 13)
        Me.lblKacKolonaGore.TabIndex = 17
        Me.lblKacKolonaGore.Text = "Kaç kolona göre bölünecek"
        '
        'lblAyracIsaret
        '
        Me.lblAyracIsaret.AutoSize = True
        Me.lblAyracIsaret.Location = New System.Drawing.Point(287, 21)
        Me.lblAyracIsaret.Name = "lblAyracIsaret"
        Me.lblAyracIsaret.Size = New System.Drawing.Size(68, 13)
        Me.lblAyracIsaret.TabIndex = 15
        Me.lblAyracIsaret.Text = "Dosya ayracı"
        Me.ToolTip1.SetToolTip(Me.lblAyracIsaret, "Dosya isimlerinde kullanılacak ayracı seçin")
        '
        'grpDosyaFormat
        '
        Me.grpDosyaFormat.Controls.Add(Me.rbFormatPDF)
        Me.grpDosyaFormat.Controls.Add(Me.rbFormatXl)
        Me.grpDosyaFormat.Location = New System.Drawing.Point(173, 139)
        Me.grpDosyaFormat.Name = "grpDosyaFormat"
        Me.grpDosyaFormat.Size = New System.Drawing.Size(100, 68)
        Me.grpDosyaFormat.TabIndex = 14
        Me.grpDosyaFormat.TabStop = False
        Me.grpDosyaFormat.Text = "Dosya Formatı"
        Me.ToolTip1.SetToolTip(Me.grpDosyaFormat, "Dosyların Excel dosya olark mı yoksa PDF olark mı bölünmesini istiyorsunuz?")
        '
        'rbFormatPDF
        '
        Me.rbFormatPDF.AutoSize = True
        Me.rbFormatPDF.Location = New System.Drawing.Point(7, 44)
        Me.rbFormatPDF.Name = "rbFormatPDF"
        Me.rbFormatPDF.Size = New System.Drawing.Size(46, 17)
        Me.rbFormatPDF.TabIndex = 1
        Me.rbFormatPDF.Text = "PDF"
        Me.rbFormatPDF.UseVisualStyleBackColor = True
        '
        'rbFormatXl
        '
        Me.rbFormatXl.AutoSize = True
        Me.rbFormatXl.Checked = True
        Me.rbFormatXl.Location = New System.Drawing.Point(7, 20)
        Me.rbFormatXl.Name = "rbFormatXl"
        Me.rbFormatXl.Size = New System.Drawing.Size(51, 17)
        Me.rbFormatXl.TabIndex = 0
        Me.rbFormatXl.TabStop = True
        Me.rbFormatXl.Text = "Excel"
        Me.rbFormatXl.UseVisualStyleBackColor = True
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.rbLytNo)
        Me.grpLayout.Controls.Add(Me.rbLytLand)
        Me.grpLayout.Controls.Add(Me.rbLytPrt)
        Me.grpLayout.Location = New System.Drawing.Point(25, 139)
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.Size = New System.Drawing.Size(135, 93)
        Me.grpLayout.TabIndex = 13
        Me.grpLayout.TabStop = False
        Me.grpLayout.Text = "1e1 Ayar ve Layout"
        Me.ToolTip1.SetToolTip(Me.grpLayout, "Bölünen dosyalarda printer için sayfa ayarı yapılacak mı")
        '
        'rbLytNo
        '
        Me.rbLytNo.AutoSize = True
        Me.rbLytNo.Checked = True
        Me.rbLytNo.Location = New System.Drawing.Point(6, 19)
        Me.rbLytNo.Name = "rbLytNo"
        Me.rbLytNo.Size = New System.Drawing.Size(49, 17)
        Me.rbLytNo.TabIndex = 10
        Me.rbLytNo.TabStop = True
        Me.rbLytNo.Text = "Hayır"
        Me.rbLytNo.UseVisualStyleBackColor = True
        '
        'rbLytLand
        '
        Me.rbLytLand.AutoSize = True
        Me.rbLytLand.Location = New System.Drawing.Point(6, 65)
        Me.rbLytLand.Name = "rbLytLand"
        Me.rbLytLand.Size = New System.Drawing.Size(118, 17)
        Me.rbLytLand.TabIndex = 12
        Me.rbLytLand.Text = "Evet ve Landscape"
        Me.rbLytLand.UseVisualStyleBackColor = True
        '
        'rbLytPrt
        '
        Me.rbLytPrt.AutoSize = True
        Me.rbLytPrt.Location = New System.Drawing.Point(6, 42)
        Me.rbLytPrt.Name = "rbLytPrt"
        Me.rbLytPrt.Size = New System.Drawing.Size(98, 17)
        Me.rbLytPrt.TabIndex = 11
        Me.rbLytPrt.Text = "Evet ve Portrait"
        Me.rbLytPrt.UseVisualStyleBackColor = True
        '
        'btnDevam
        '
        Me.btnDevam.Location = New System.Drawing.Point(314, 399)
        Me.btnDevam.Name = "btnDevam"
        Me.btnDevam.Size = New System.Drawing.Size(75, 23)
        Me.btnDevam.TabIndex = 11
        Me.btnDevam.Text = "Başla"
        Me.btnDevam.UseVisualStyleBackColor = True
        '
        'btnIptal
        '
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.Location = New System.Drawing.Point(395, 399)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(75, 23)
        Me.btnIptal.TabIndex = 12
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'frmBolme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 437)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnDevam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBolme"
        Me.Text = "Bölme - Uyarı ve Ayarlar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpKaynak.ResumeLayout(False)
        Me.grpKaynak.PerformLayout()
        Me.grpDosyaFormat.ResumeLayout(False)
        Me.grpDosyaFormat.PerformLayout()
        Me.grpLayout.ResumeLayout(False)
        Me.grpLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKlasor As System.Windows.Forms.Label
    Friend WithEvents txtKlasor As System.Windows.Forms.TextBox
    Friend WithEvents txtBaslikSatir As System.Windows.Forms.TextBox
    Friend WithEvents lblBaslikSatir As System.Windows.Forms.Label
    Friend WithEvents lblPrivateSign As System.Windows.Forms.Label
    Friend WithEvents txtPrivateSign As System.Windows.Forms.TextBox
    Friend WithEvents txtBoslukConvert As System.Windows.Forms.TextBox
    Friend WithEvents lblBoslukConvert As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDevam As System.Windows.Forms.Button
    Friend WithEvents btnIptal As System.Windows.Forms.Button
    Friend WithEvents grpDosyaFormat As System.Windows.Forms.GroupBox
    Friend WithEvents rbFormatPDF As System.Windows.Forms.RadioButton
    Friend WithEvents rbFormatXl As System.Windows.Forms.RadioButton
    Friend WithEvents grpLayout As System.Windows.Forms.GroupBox
    Friend WithEvents rbLytNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbLytLand As System.Windows.Forms.RadioButton
    Friend WithEvents rbLytPrt As System.Windows.Forms.RadioButton
    Friend WithEvents lblAyracIsaret As System.Windows.Forms.Label
    Friend WithEvents cbAyracIsaret As System.Windows.Forms.ComboBox
    Friend WithEvents cbKacKolonaGore As System.Windows.Forms.ComboBox
    Friend WithEvents lblKacKolonaGore As System.Windows.Forms.Label
    Friend WithEvents grpKaynak As System.Windows.Forms.GroupBox
    Friend WithEvents rbKaynakUniqWB As System.Windows.Forms.RadioButton
    Friend WithEvents rbKaynakActiveSheet As System.Windows.Forms.RadioButton
    Friend WithEvents lblAyracAciklama As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
