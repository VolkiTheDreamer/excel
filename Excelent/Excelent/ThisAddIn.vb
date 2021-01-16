Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        'RegisterComserver()
        'Call xlam_yukle()
        If System.DateTime.Today > CDate("31.12.2020") Then
            MsgBox("Excelent add-inin süresi dolmuş, lütfen yeni versiyon için www.excelinefendisi.com adresine gidin. Excelent'ı artık kullanmak istemiyorsanız, diğer Programlarda olduğu gibi Program Ekle/Kaldır menüsünden kaldırabilirsiniz.")
            Globals.Ribbons.rbExcelent.Dispose()
        End If

    End Sub
    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub
    Private Sub RegisterComserver()
        Try
            Dim strAddinName As String = "Excelent.Fonksiyonlar"

            app.AddIns.Add(Filename:=strAddinName)
            app.AddIns(strAddinName).Installed = True

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub xlam_yukle()
        Try
            If app.AddIns("Efendi").Installed = False Then
                Dim xaddin As Excel.AddIn
                xaddin = app.AddIns.Add(Filename:="C:\Users\Volkan\OneDrive\0-uygulama örneklerim\Visual Studio\Visual Studio 2013\Projects\vbnet\VSTO\Excelent\Efendi.xla")
                'xaddin = app.AddIns.Add(Filename:="\Efendi.xla")
                xaddin.Installed = True
                MsgBox("selam")
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
