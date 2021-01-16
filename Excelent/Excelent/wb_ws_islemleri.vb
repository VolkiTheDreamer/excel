Module wb_ws_islemleri
#Region "ws_islem"
    Sub ws_print_names()
        Try
            app.Sheets.Add(Before:=app.Sheets(1))
            For i As Integer = 2 To app.Sheets.Count
                CType(app.Cells(i - 1, 1), Excel.Range).Value = CType(app.Sheets(i), Excel.Worksheet).Name
            Next i
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub ws_sort_alfabetik()

        Try
            Dim xResult As MsgBoxResult

            xResult = MsgBox("Alfabetik mi sıralanacak?" & Chr(10) & "Z'den A'ya sıralamak için No diyin ", vbYesNoCancel + vbQuestion + vbDefaultButton1)
            For i = 1 To app.Sheets.Count
                For j As Integer = 1 To app.Sheets.Count - 1
                    If xResult = vbYes Then
                        If UCase$(app.Sheets(j).Name) > UCase$(app.Sheets(j + 1).Name) Then
                            app.Sheets(j).Move(after:=app.Sheets(j + 1))
                        End If
                    ElseIf xResult = vbNo Then
                        If UCase$(app.Sheets(j).Name) < UCase$(app.Sheets(j + 1).Name) Then
                            app.Sheets(j).Move(after:=app.Sheets(j + 1))
                        End If
                    End If
                Next
            Next
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub ws_tumunu_protect()
        Try

            Dim pwd1 As String, pwd2 As String
            pwd1 = InputBox("Şifreyi girin")
            If pwd1 = "" Then Exit Sub
            pwd2 = InputBox("Şifreyi tekrar girin")

            If pwd2 = "" Then Exit Sub

            'iki şifre aynı mı
            If InStr(1, pwd2, pwd1, 0) = 0 Or _
            InStr(1, pwd1, pwd2, 0) = 0 Then
                MsgBox("Şifreler farklı, tekrar deneyin.")
                Exit Sub
            End If

            For Each ws As Excel.Worksheet In app.Worksheets
                ws.Protect(Password:=pwd1)
            Next

            MsgBox("Tüm sayfalara protection konuldu.")

        Catch e As Exception
            MsgBox(e.Message)
        End Try

    End Sub
    Sub ws_tumunu_unprotect()
        Try
            Dim pwd1 As String
            pwd1 = InputBox("Şifreyi gir")

            If pwd1 = "" Then Exit Sub
            For Each ws In app.Worksheets
                ws.Unprotect(Password:=pwd1)
            Next
            MsgBox("Tüm sayfalardan protection kaldırıldı.")

        Catch e As Exception
            MsgBox("Birşeyler ters gitti. Muhtemelen yanlış şifre girdiniz. Tekrar deneyin.")
            MsgBox(e.Message)
        End Try
    End Sub
    Sub ws_ilki_disindakiler_hide()
        Try
            app.Sheets(1).Visible = True 'belki ilik sayfa ilk bşata kapalıdır, önce onu açalım

            For i = 2 To app.Sheets.Count
                app.Sheets(i).Visible = False
            Next i
            'app.Sheets(1).Select()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub ws_tümsayfalar_unhide()
        Try
            For i = 1 To app.Sheets.Count
                app.Sheets(i).Visible = True
            Next i
            app.Sheets(1).Select()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
#End Region

#Region "wb_islem"

    Sub wb_tumunu_saveet()
        Try
            Dim wb As Excel.Workbook

            For Each wb In app.Workbooks
                app.Workbooks(wb.Name).Activate()
                If app.Windows(wb.Name).Visible = True Then 'personal.xlsb ve add-in dosyaları hariç
                    If InStr(wb.Name, ".") = 0 Then 'açıdlığandaberi hiç kaydedilmemiş yani uznatısı olmayan bir dosya ise
                        wb.SaveAs(Filename:=app.DefaultFilePath & "\" & wb.Name & ".xlsx", _
                            FileFormat:=app.DefaultSaveFormat, CreateBackup:=False)
                    Else
                        wb.Save()
                    End If
                End If
            Next wb
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub wb_tumunu_kapat()
        Try
            Dim cevap As MsgBoxResult
            Dim wb As Workbook
            Dim a As Boolean

            cevap = MsgBox("Kapatırken  kaydedelsin mi", vbYesNoCancel)
            If cevap = vbYes Then
                a = True
            ElseIf cevap = vbNo Then
                a = False
            Else
                Exit Sub
            End If

            For Each wb In app.Workbooks
                app.Workbooks(wb.Name).Activate()
                If app.Windows(wb.Name).Visible = True Then 'personal.xlsb ve add-in dosyaları hariç
                    If InStr(wb.Name, ".") = 0 Then 'açıdlığandaberi hiç kaydedilmemiş yani uznatısı olmayan bir dosya ise
                        wb.SaveAs(Filename:=app.DefaultFilePath & "\" & wb.Name & ".xlsx", _
                            FileFormat:=app.DefaultSaveFormat, CreateBackup:=False)
                        app.ActiveWindow.Close()
                    Else
                        wb.Close(SaveChanges:=a)
                    End If
                End If
            Next wb
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub wb_tumunu_printal()
        Try
            Dim wb As Workbook

            For Each wb In app.Workbooks
                If app.Windows(wb.Name).Visible = True Then 'personal.xlsb ve add-in dosyaları hariç
                    app.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, Collate:=True)
                End If
            Next wb
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub wb_tumunu_refresh()
        Try

            For Each wb In app.Workbooks
                If app.Windows(wb.Name).Visible = True Then 'personal.xlsb ve add-in dosyaları hariç

                    For Each cn In wb.Connections
                        'Get current background-refresh value
                        Dim bBackground As Boolean = cn.ODBCConnection.BackgroundQuery
                        'Temporarily disable background-refresh
                        cn.ODBCConnection.BackgroundQuery = False
                        'Refresh this connection
                        cn.Refresh()
                        'Set background-refresh value back to original value
                        cn.ODBCConnection.BackgroundQuery = bBackground
                    Next

                End If
            Next wb

            MsgBox("Tüm dosyalardaki ODBC connectionları refresh edildi.")
            'bi süre sonra ör:5 sn, mesaj gitasin, çünkü bunu kullanan kişi, akşam işten çıakren buna bamsış ve çıkmıştır, sonrasında schedule kodları varsa onlar takılmasın
            'app.Wait(10)
            'app.SendKeys("{ENTER}", 10)
            'System.Windows.Forms.SendKeys.Send("{ENTER}")
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Sub wb_tumunde_conn_sifre_degistir()

        Dim wb As Workbook
        Dim cn As Excel.WorkbookConnection
        Dim eski As String
        Dim yeni As String
        Dim dosyalar As String
        Dim done As Boolean
        Dim dizi As Object

        Try
            eski = InputBox("Eski şifreyi girin")
            If eski = "" Then Exit Sub
            yeni = InputBox("Yeni şifreyi girin")
            If yeni = "" Then Exit Sub


            dosyalar = ""
            done = False
            For Each wb In app.Workbooks
                If app.Windows(wb.Name).Visible = True Then
                    If wb.Connections.Count > 0 Then
                        For Each cn In wb.Connections
                            If InStr(cn.ODBCConnection.Connection, eski) > 0 Then
                                cn.ODBCConnection.Connection = Replace(cn.ODBCConnection.Connection, eski, yeni)
                                done = True
                            End If
                        Next cn
                        If done = True Then dosyalar = wb.Name & ";" & dosyalar
                    End If
                End If
            Next wb

            dizi = Split(dosyalar, ";")
            MsgBox("ODBC bağlantısı olan dosyalardaki şifre değişim işlemi yapıldı." & vbCrLf & "Değişim işlemi olan dosyalar yeni bir workbook içine yazılacak.. ")
            app.Workbooks.Add()

            app.Range("a1").Select()
            For i = 0 To UBound(dizi) - 1
                app.Cells(i + 1, 1).Value2 = dizi(i)
            Next i

            'MsgBox("Şimdi tüm wb'ları save et düğmesin çalıştır")

            Exit Sub

        Catch e As Exception
            MsgBox("Bir hata oluştu, örneğin protectli bir dosyada şifre değiştirmeye çalışıyor olabilirsiniz")
            MsgBox(e.HResult)
        End Try
    End Sub
    Sub pdf_yap()

        '        answer = MsgBox("'C' diskinizde 'pdfyap' isminde bir klaösürünüz var mı?", vbYesNo)
        '        If answer = 6 Then
        '            GoTo ilerle
        '        Else
        '            MsgBox("O ZAMAN O KLASÖRÜ YARATIP TEKRAR ÇALIŞTIR ")
        '            Exit Sub
        '        End If

        'ilerle:

        '        clsm = InputBox("çalışmamın başlığı ne olsun?")

        '        kactane = InputBox("kaç dosya için")

        'basadon:
        '        tip = InputBox("aktif sayfa için 1, tüm dosya için 2 girin")

        '        If tip <> 1 And tip <> 2 Then
        '            MsgBox("sadece 1 veya 2 girin")
        '            GoTo basadon
        '        End If

        '        For i = 1 To kactane

        '            Select Case ActiveWorkbook.FileFormat
        '                Case "-4143", "-4158", 6, 56 'normal xls, txt, csv veya Excel2007deki 97-2003 xls'i mi
        '                    isim = Left(ActiveWorkbook.Name, Len(ActiveWorkbook.Name) - 4)
        '                Case 50, 51, 52 'xlsx, xlsb veya xlsm ise
        '                    isim = Left(ActiveWorkbook.Name, Len(ActiveWorkbook.Name) - 5)
        '                Case Else
        '                    MsgBox("Bu dosya formatı bu makronun çalışması için uygun değil. xls, xlsx, xlsb, xlsm, txt veya csv dosyalarıyla çalışmalısınız")
        '                    Exit Sub
        '            End Select


        '            If tip = 1 Then
        '                ActiveSheet.ExportAsFixedFormat(Type:=xlTypePDF, Filename:= _
        '                    "C:\pdfyap\" & isim & " - " & clsm & ".pdf" _
        '                    , Quality:=xlQualityStandard, IncludeDocProperties:=True, IgnorePrintAreas _
        '                    :=False, OpenAfterPublish:=False) 'buraya kopyalanacak path yazılır
        '                ActiveWindow.Close()


        '            Else 'yani 2yse, 2 dışındakileri başta eledim
        '                ActiveWorkbook.ExportAsFixedFormat(Type:=xlTypePDF, Filename:= _
        '                    "C:\pdfyap\" & isim & " - " & clsm & ".pdf" _
        '                    , Quality:=xlQualityStandard, IncludeDocProperties:=True, IgnorePrintAreas _
        '                    :=False, OpenAfterPublish:=False) 'buraya kopyalanacak path yazılır
        '                ActiveWindow.Close()
        '            End If

        '        Next i
    End Sub
#End Region
End Module
