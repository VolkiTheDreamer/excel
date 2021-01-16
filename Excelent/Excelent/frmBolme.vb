Imports System.Windows.Forms

Public Class frmBolme
    Public devammi As Boolean
    Public klasor As String
    Public satirAdet As Byte
    Public ozelKarakterSubsitute As String
    Public boslukSubstitue As String
    Public dosyaAyirmaIsareti As String
    Public dosyaBolmeFormati As Boolean
    Public layoutSecenek As Boolean
    Public kacKolonBolme As Byte
    Private Sub btnDevam_Click(sender As Object, e As EventArgs) Handles btnDevam.Click, btnIptal.Click
        If sender Is btnDevam Then
            'fomrda girikleri şeyler için validation yap, boş olmasın
            devammi = True
            klasor = Me.txtKlasor.Text
            satirAdet = CByte(Me.txtBaslikSatir.Text)
            ozelKarakterSubsitute = Me.txtPrivateSign.Text
            boslukSubstitue = Me.txtBoslukConvert.Text
            dosyaAyirmaIsareti = Me.cbAyracIsaret.Text
            kacKolonBolme = CByte(IIf(String.IsNullOrEmpty(Me.cbKacKolonaGore.Text), 0, Me.cbKacKolonaGore.Text))
            If rbFormatXl.Checked = True Then
                dosyaBolmeFormati = True 'Excel
            Else
                dosyaBolmeFormati = False 'PDF
            End If

            If rbLytNo.Checked = True Then
                layoutSecenek = Nothing
            ElseIf rbLytPrt.Checked = True Then
                layoutSecenek = True 'defaultu portrait oldugu için
            Else
                layoutSecenek = False 'lansccape
            End If


            Do
                Me.Opacity -= 0.000025
                'Me.Location.X = 1 ' bi ra burayı da hallet, form kayarak sağa gitsin
            Loop Until Me.Opacity = 0

            Me.Close()
        Else 'iptale tıklandıysa hiçbişey yapma
            devammi = False
            Me.Close()
        End If
    End Sub
    Private Sub rbKaynakUniqWB_CheckedChanged(sender As Object, e As EventArgs) Handles rbKaynakUniqWB.CheckedChanged
        '    'her check dğeişimden değilde sadece seilcdiğinde. yani seçim kalktıgında çıkmasına gerek yok
        If Me.rbKaynakUniqWB.Checked = True Then
            MsgBox("Yeni bir dosya açtığınızdan, bu dosyaya uniqe değerleri girdiğinizden ve bu dosyanın aktif workbook olduğundan emin olun.")
        End If
    End Sub
    Private Sub cbAyracIsaret_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAyracIsaret.SelectedIndexChanged
        Select Case cbAyracIsaret.Text
            Case "-"
                lblAyracAciklama.Text = "*Ayraç olarak Tire(-) seçtiniz"
            Case " - "
                lblAyracAciklama.Text = "*Ayraç olarak 'Boşluk Tire Boşluk' ( - ) seçtiniz"
            Case "_"
                lblAyracAciklama.Text = "*Ayraç olarak 'AltÇizgi' (_) seçtiniz"
            Case " _ "
                lblAyracAciklama.Text = "*Ayraç olarak 'Boşluk AltÇizgi Boşluk' ( _ ) seçtiniz"
            Case Else
                lblAyracAciklama.Text = "??"
        End Select
    End Sub
    Private Sub cbAyracIsaret_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles cbAyracIsaret.MouseClick
        ''bu olaya neden gerek var. çünkü;listenin manuel girişe kapalı olamsı için drpğdownsytleını dropdownlist
        'yapmak laım. ama böye yapınca da default value atayamıyorum, ki ben - atamak isiyorum
        'o yüzden, normal dropdown yaptım ama tıklanır tıklanmaz da sitilii değiştiriyrum
        cbAyracIsaret.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        cbAyracIsaret.DroppedDown = True 'buna neden gerek var. çünkü, tıklarnı tıklanmaz, geri kapanıyodu, açmak için bunu yapıyoz
    End Sub
    Dim textBoxes() As TextBox 'bu satır ve aşağısı klasör adını sstore etmek için kullanılr
    Private Sub frmBolme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxes = New TextBox() {txtKlasor}

        With My.Settings
            If .TextBoxValues Is Nothing Then .TextBoxValues = New System.Collections.Specialized.StringCollection
            For i = 0 To textBoxes.Length - 1
                If .TextBoxValues.Count <= i Then .TextBoxValues.Add("")
                textBoxes(i).Text = .TextBoxValues(i)
            Next
        End With

    End Sub
    Private Sub frmBolme_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i = 0 To textBoxes.Length - 1
            My.Settings.TextBoxValues(i) = textBoxes(i).Text
        Next
        My.Settings.Save()
    End Sub

    Private Sub txtKlasor_MouseHover(sender As Object, e As EventArgs) Handles txtKlasor.MouseHover
        If Me.txtKlasor.Text = "" Then
            Me.ToolTip1.SetToolTip(Me.txtKlasor, "Bölünecek dosyaların kaydedileceği klasör" & vbCrLf & "adını giriniz. Bundan sonraki açılışlarda bu " & vbCrLf & "bilgi default gelecektir. Siz burayı" & vbCrLf & "değiştirdikçe girdiğiniz klasör default olarak ayarlancaktır.")
        Else
            Me.ToolTip1.SetToolTip(Me.txtKlasor, "Klasör adını kalıcı oarak değiştirmek için " & vbCrLf & "yeni klöasr adını girmeniz yeterlidir.")
        End If
    End Sub

    Private Sub txtKlasor_MouseClick(sender As Object, e As MouseEventArgs) Handles txtKlasor.MouseClick
        If Me.txtKlasor.Text = "" Then
            Me.ToolTip1.SetToolTip(Me.txtKlasor, "Bölünecek dosyaların kaydedileceği klasör" & vbCrLf & "adını giriniz. Bundan sonraki açılışlarda bu " & vbCrLf & "bilgi default gelecektir. Siz burayı" & vbCrLf & "değiştirdikçe girdiğiniz klasör default olarak ayarlancaktır.")
        Else
            Me.ToolTip1.SetToolTip(Me.txtKlasor, "Klasör adını kalıcı oarak değiştirmek için " & vbCrLf & "yeni klöasr adını girmeniz yeterlidir.")
        End If
    End Sub


End Class