Imports System.Windows.Forms
Public Class frmFrequentFile
    'to do:Sık kullanılan Word pdf eklenirse basına rpgoram.exe
    Dim txtFreq() As TextBox 'bu satır ve aşağısı dosya isimlerini store etmek için kullanılr
    Private Sub frmFrequentFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFreq = New TextBox() {txtDosya1, txtDosya2, txtDosya3, txtDosya4, txtDosya5, txtDosya1KisaAd, txtDosya2KisaAd, txtDosya3KisaAd, txtDosya4KisaAd, txtDosya5KisaAd}

        With My.Settings
            If .txtFrequentFile Is Nothing Then .txtFrequentFile = New System.Collections.Specialized.StringCollection
            For i = 0 To txtFreq.Length - 1
                If .txtFrequentFile.Count <= i Then .txtFrequentFile.Add("")
                txtFreq(i).Text = .txtFrequentFile(i)
            Next
        End With

    End Sub
    Private Sub frmFrequentFile_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i = 0 To txtFreq.Length - 1
            My.Settings.txtFrequentFile(i) = txtFreq(i).Text
        Next
        My.Settings.Save()
    End Sub

    Private Sub YeniDüğmeEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniDüğmeEkleToolStripMenuItem.Click
        MsgBox("Şuan aktif değil, ileriki güncellemeleri bekleyin")
    End Sub
End Class

