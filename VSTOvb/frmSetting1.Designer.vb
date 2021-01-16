<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting1
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtSheetAded = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtKlasor = New System.Windows.Forms.TextBox()
        Me.RenkliTextBox1 = New VSTOvb.RenkliTextBox()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(100, 150)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "renkli kutu"
        '
        'txtSheetAded
        '
        Me.txtSheetAded.Location = New System.Drawing.Point(202, 77)
        Me.txtSheetAded.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSheetAded.Name = "txtSheetAded"
        Me.txtSheetAded.Size = New System.Drawing.Size(44, 20)
        Me.txtSheetAded.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(101, 81)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 13)
        Me.label2.TabIndex = 8
        Me.label2.Text = "yeni sheet adedi"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(99, 49)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "ana klasör"
        '
        'txtKlasor
        '
        Me.txtKlasor.Location = New System.Drawing.Point(171, 49)
        Me.txtKlasor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKlasor.Name = "txtKlasor"
        Me.txtKlasor.Size = New System.Drawing.Size(368, 20)
        Me.txtKlasor.TabIndex = 6
        '
        'RenkliTextBox1
        '
        Me.RenkliTextBox1.Location = New System.Drawing.Point(171, 124)
        Me.RenkliTextBox1.Name = "RenkliTextBox1"
        Me.RenkliTextBox1.Size = New System.Drawing.Size(145, 68)
        Me.RenkliTextBox1.TabIndex = 11
        '
        'frmSetting1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RenkliTextBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtSheetAded)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtKlasor)
        Me.Name = "frmSetting1"
        Me.Text = "frmSetting1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Windows.Forms.Label
    Private WithEvents txtSheetAded As Windows.Forms.TextBox
    Private WithEvents label2 As Windows.Forms.Label
    Private WithEvents label1 As Windows.Forms.Label
    Private WithEvents txtKlasor As Windows.Forms.TextBox
    Friend WithEvents RenkliTextBox1 As RenkliTextBox
End Class
