<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubelerPersonel
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
        Me.lblSubePath = New System.Windows.Forms.Label()
        Me.lblPersonelPath = New System.Windows.Forms.Label()
        Me.txtSubelerPath = New System.Windows.Forms.TextBox()
        Me.txtPersonelPath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSubePath
        '
        Me.lblSubePath.AutoSize = True
        Me.lblSubePath.Location = New System.Drawing.Point(13, 38)
        Me.lblSubePath.Name = "lblSubePath"
        Me.lblSubePath.Size = New System.Drawing.Size(249, 26)
        Me.lblSubePath.TabIndex = 0
        Me.lblSubePath.Text = "Şubeler dosyasının adresi ve adı(dosya adı [] içinde)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ör:C:\Excelent\[Şubeler.xl" & _
    "sx]"
        '
        'lblPersonelPath
        '
        Me.lblPersonelPath.AutoSize = True
        Me.lblPersonelPath.Location = New System.Drawing.Point(13, 71)
        Me.lblPersonelPath.Name = "lblPersonelPath"
        Me.lblPersonelPath.Size = New System.Drawing.Size(254, 26)
        Me.lblPersonelPath.TabIndex = 1
        Me.lblPersonelPath.Text = "Personel dosyasının adresi ve adı(dosya adı [] içinde)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Ör:C:\Excelent\[Personel" & _
    " Bilgisi].xlsx)"
        '
        'txtSubelerPath
        '
        Me.txtSubelerPath.ForeColor = System.Drawing.Color.Red
        Me.txtSubelerPath.Location = New System.Drawing.Point(274, 44)
        Me.txtSubelerPath.Name = "txtSubelerPath"
        Me.txtSubelerPath.Size = New System.Drawing.Size(300, 20)
        Me.txtSubelerPath.TabIndex = 2
        '
        'txtPersonelPath
        '
        Me.txtPersonelPath.ForeColor = System.Drawing.Color.Red
        Me.txtPersonelPath.Location = New System.Drawing.Point(274, 77)
        Me.txtPersonelPath.Name = "txtPersonelPath"
        Me.txtPersonelPath.Size = New System.Drawing.Size(300, 20)
        Me.txtPersonelPath.TabIndex = 3
        '
        'frmSubelerPersonel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 141)
        Me.Controls.Add(Me.txtPersonelPath)
        Me.Controls.Add(Me.txtSubelerPath)
        Me.Controls.Add(Me.lblPersonelPath)
        Me.Controls.Add(Me.lblSubePath)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubelerPersonel"
        Me.Text = "Şube ve Personel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubePath As System.Windows.Forms.Label
    Friend WithEvents lblPersonelPath As System.Windows.Forms.Label
    Friend WithEvents txtSubelerPath As System.Windows.Forms.TextBox
    Friend WithEvents txtPersonelPath As System.Windows.Forms.TextBox
End Class
