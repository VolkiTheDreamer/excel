Imports Outlook = Microsoft.Office.Interop.Outlook
Public Class frmBatchMail
    Public konu As String
    Public govde As String
    Public devammi As Byte
    Public mailbutunluk As Boolean
    'Dim excelsablondone As Boolean = False
    Private Sub btnOnizle_Click(sender As Object, e As EventArgs) Handles btnOnizle.Click, btnGonder.Click, btnIptal.Click
        If sender Is btnIptal Then
            devammi = 0
            Me.Close()
        Else
            '            If Me.chkExcelSblon.Checked = True Then GoTo atla
            '            If excelsablondone = False Then
            '                MsgBox("Uygun formattaki Excel Şablonu oluşturmadan devam edemezsiniz")
            '                Exit Sub
            '            End If
            'atla:
            If sender Is btnGonder Then
                devammi = 1
                Me.Hide()
            Else 'önizleme
                devammi = 2
                Me.Hide()
            End If

            konu = Me.txtKonu.Text
            Windows.Forms.Clipboard.Clear()

            mailbutunluk = True
            If Me.rbButunlukStandart.Checked = True Then
                'govde = Me.rchtextBody.Rtf
                'mailbutunluk = True
                Me.rchtextBody.SelectAll()
                Me.rchtextBody.Copy()
            Else 'yani parametrik seçildiyse
                mailbutunluk = False
                'anamodülde ele alıcaz, çünkü excelle birleştirmek gerekiyor
            End If

        End If

    End Sub
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.rchtextBody.SelectionFont = FontDialog1.Font
        End If
    End Sub
    Private Sub RenkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenkToolStripMenuItem.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.rchtextBody.SelectionColor = ColorDialog1.Color
            'parametrikler için de yap
        End If
    End Sub
    Private Sub BulletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulletToolStripMenuItem.Click
        Me.rchtextBody.SelectionBullet = True
    End Sub
    Private Sub rbButunlukStandart_CheckedChanged(sender As Object, e As EventArgs) Handles rbButunlukStandart.CheckedChanged, rbButunlukParametrik.CheckedChanged
        If Me.rbButunlukStandart.Checked = True Then
            Me.rchtextBody.Visible = True
            Me.grpParametrik.Visible = False
            Me.mnMetinFormatlayıcıToolStripMenuItem.Enabled = True
        ElseIf Me.rbButunlukParametrik.Checked = True Then
            MsgBox("Parçalı mail gönderimi bir sonraki güncellemede aktif olacaktr")
            Me.rbButunlukStandart.Checked = True

            'aşağıaki kısım 2.fazda
            'Me.grpParametrik.Visible = True
            'Me.rchtextBody.Visible = False
            'Me.mnMetinFormatlayıcıToolStripMenuItem.Enabled = False
        End If
    End Sub
    'Private Sub btnExcelYap_Click(sender As Object, e As EventArgs) Handles btnExcelYap.Click
    '    excelsablondone = True 'gönder veya önzimlemye tıkladıgında izi nversin diye, excel olumadıys izin vermiyoruz
    '    'If Me.mailbutunluk = True Then
    '    Call excel_ready()
    '    'Else
    '    'Call excelready_parametrik()
    '    'End If

    '    'Me.ShowDialog()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'şimdilik tüm pat gelsin ama bi süre sonra sade safefilename gelsin, klasörü de diziye atasın
            lbSoloEk.Items.Add(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbSoloEk.Items.Clear()
    End Sub

    'Private Sub chkExcelSblon_CheckedChanged(sender As Object, e As EventArgs) Handles chkExcelSblon.CheckedChanged
    '    If Me.chkExcelSblon.Checked = True Then
    '        Me.btnExcelYap.Enabled = False
    '        excelsablondone = True
    '    Else
    '        Me.btnExcelYap.Enabled = True
    '        excelsablondone = False
    '    End If
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            'şimdilik tüm pat gelsin ama bi süre sonra sade safefilename gelsin, klasörü de diziye atasın
            txtEkKlasor.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub chkEkDurum_CheckedChanged(sender As Object, e As EventArgs) Handles chkEkDurum.CheckedChanged
        If Me.chkEkDurum.Checked = True Then
            Me.grpEk.Visible = True
        Else
            Me.grpEk.Visible = False
        End If
    End Sub
    Private Sub rbFromOther_CheckedChanged(sender As Object, e As EventArgs) Handles rbFromOther.CheckedChanged
        If Me.rbFromOther.Checked = True Then
            Me.txtFrom.Enabled = True
        Else
            Me.txtFrom.Enabled = False
        End If
    End Sub
    Private Sub rbToUnits_CheckedChanged(sender As Object, e As EventArgs) Handles rbToUnits.CheckedChanged
        If Me.rbToUnits.Checked = True Then
            Me.txtToOnek.Enabled = True
            Me.txtToDomain.Enabled = True
        Else
            Me.txtToOnek.Enabled = False
            Me.txtToDomain.Enabled = False
        End If
    End Sub

End Class