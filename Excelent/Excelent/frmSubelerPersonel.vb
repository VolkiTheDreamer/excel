Imports System.Windows.Forms
Public Class frmSubelerPersonel
    Public sbPath As String
    Public prsPath As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'setting işini loaddan çıkardım, buraya aldım, çünkü ana modülde direkt formun örneği yaratılır yaratılmaz
        'bu en alttaki değer aama işini yapmam lazım, yoksa loada gelmeden önce burası çalıştığı için, boş atamış oluyordum
        'bu şekidle uğrşamk yerine bölme formunda olduğu gibi Başlat/Devam gibi bi buton kouyp onunu click eventine
        'de koyabilirdim ama bi de sub new pratiği yapmış olalım dedim. bildiğin gibi new constructerı
        'başlangıç değerleri atamak için ideal
        txtsbper = New TextBox() {txtPersonelPath, txtSubelerPath}

        With My.Settings
            If .txtSubePers Is Nothing Then .txtSubePers = New System.Collections.Specialized.StringCollection
            For i = 0 To txtsbper.Length - 1
                If .txtSubePers.Count <= i Then .txtSubePers.Add("")
                txtsbper(i).Text = .txtSubePers(i)
            Next
        End With

        sbPath = Me.txtSubelerPath.Text
        prsPath = Me.txtPersonelPath.Text

    End Sub
    'bu form dialoglaunchte açılır
    Dim txtsbper() As TextBox 'bu satır ve aşağısı dosya isimlerini store etmek için kullanılr
    Private Sub frmSubelerPersonel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtsbper = New TextBox() {txtPersonelPath, txtSubelerPath}

        'With My.Settings
        '    If .txtSubePers Is Nothing Then .txtSubePers = New System.Collections.Specialized.StringCollection
        '    For i = 0 To txtsbper.Length - 1
        '        If .txtSubePers.Count <= i Then .txtSubePers.Add("")
        '        txtsbper(i).Text = .txtSubePers(i)
        '    Next
        'End With

    End Sub
    Private Sub frmSubelerPersonel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i = 0 To txtsbper.Length - 1
            My.Settings.txtSubePers(i) = txtsbper(i).Text
        Next
        My.Settings.Save()
    End Sub
End Class