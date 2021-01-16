Imports System.Windows.Forms
Imports Microsoft.Office.Tools.Ribbon
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Ribbon1
    'Public app As Excel.Application-->Buna grek yok, zira genelmodül içinde tanımladığımızı kullanacağız
    Public myusercontrol1 As MyUserControl 'taskpane için
    Public myCustomTaskPane As Microsoft.Office.Tools.CustomTaskPane

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        button20.Image = My.Resources._0.ToBitmap()
    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        Dim frm1 As New Form1
        frm1.Show()
    End Sub
    Private Sub button2_Click_1(sender As Object, e As RibbonControlEventArgs) Handles button2.Click
        'burdan itibaren c#taki ribbon gruplarını olduğu gibi copy-paste yaptığım için control isimleri küçük harfle başlıyor,keza event-handler isimleri de
        Dim wb As Excel.Workbook = app.Workbooks.Add()
    End Sub

    Private Sub button4_Click_1(sender As Object, e As RibbonControlEventArgs) Handles button4.Click
        app.Workbooks.Open("E:\OneDrive\Uygulama Geliştirme\web sitelerim\Yeni Efendi\Ornek_dosyalar\CF.xlsx")
        Dim ws As Excel.Worksheet = app.Worksheets(1)
        MessageBox.Show(ws.Name)
        MessageBox.Show(app.Worksheets(1).Name)
    End Sub

    Private Sub button5_Click(sender As Object, e As RibbonControlEventArgs) Handles button5.Click
        Try
            Dim hucre As Excel.Range = app.Selection
            Dim deger As Double = hucre.Value2
            MsgBox(hucre.Address + " adresindeki hucrenin değeri:" + deger.ToString()) 'Eski MsgBox, çok kullanmamak gerek
            MessageBox.Show(app.Selection.Value2.ToString()) 'casting yapmadığımız için intellisense çıkmaz
            MessageBox.Show(DirectCast(app.Selection, Excel.Range).Value2.ToString()) 'intellisense çıkar    
        Catch ex As NullReferenceException
            MessageBox.Show("Seçili bir hücre yok, lütfen bir hücre seçip tekrar deneyin.")
        Catch ex As Exception
            If ex.HResult = -2146233088 Then
                MessageBox.Show("Şuan nümerik değeri olan bir hücrede bulunmuyorsunuz.")
                MessageBox.Show(String.Format("HRresult:{0},\n\nMesaj:{1}", ex.HResult.ToString(), ex.Message))
            Else
                MessageBox.Show(String.Format("HRresult:{0},\n\nMesaj:{1}", ex.HResult.ToString(), ex.Message))
            End If
        End Try
    End Sub

    Private Sub button6_Click(sender As Object, e As RibbonControlEventArgs) Handles button6.Click
        'çeşitli range işleri
        Dim ws As Excel.Worksheet = app.Worksheets(1)
        Dim r As Excel.Range = app.ActiveCell
        MessageBox.Show(r.Offset(1, 0).Address)
        MessageBox.Show(DirectCast(app.Cells(1, 1), Excel.Range).Value) 'intellisensli 
    End Sub

    Private Sub group2_DialogLauncherClick(sender As Object, e As RibbonControlEventArgs) Handles group2.DialogLauncherClick
        Dim f As frmSetting1 = New frmSetting1()
        f.Show()
    End Sub

    Private Sub button13_Click(sender As Object, e As RibbonControlEventArgs) Handles button13.Click
        Dim adres As String = "E:\OneDrive\Dökümanlar\bütçem.xlsx"
        app.Workbooks.Open(adres)
    End Sub

    Private Sub button14_Click(sender As Object, e As RibbonControlEventArgs) Handles button14.Click
        '
    End Sub

    Private Sub gallery1_Click(sender As Object, e As RibbonControlEventArgs) Handles gallery1.Click
        Select Case Me.gallery1.SelectedItemIndex
            Case 0
                MessageBox.Show("ilk item seçildi")
            Case 1
                MessageBox.Show("ikinci item sçeildi")
            Case Else
                MessageBox.Show("Buraya gelmemeli")
        End Select
    End Sub

    Private Sub splitButton1_Click(sender As Object, e As RibbonControlEventArgs) Handles splitButton1.Click
        'split1in default butonu            
    End Sub

    Private Sub button26_Click(sender As Object, e As RibbonControlEventArgs) Handles button26.Click
        'splitin içindeki ilk buton
    End Sub

    Private Sub button30_Click(sender As Object, e As RibbonControlEventArgs) Handles button30.Click
        Me.myusercontrol1 = New MyUserControl()
        Me.myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(Me.myusercontrol1, "İlk Task Pane")
        Me.myCustomTaskPane.Visible = True
        Me.myCustomTaskPane.Width = 200
    End Sub

    Private Sub toggleButton1_Click(sender As Object, e As RibbonControlEventArgs) Handles toggleButton1.Click
        Globals.Ribbons.Ribbon1.Tab3.Visible = toggleButton1.Checked  'ribbonu görünür kılıyoruz           
        If toggleButton1.Checked Then
            Globals.Ribbons.Ribbon1.RibbonUI.ActivateTab("Tab3") 'sonra da aktif hale getiriyoruz            
        End If
    End Sub
End Class
