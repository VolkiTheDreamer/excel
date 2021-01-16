Imports outlook = Microsoft.Office.Interop.Outlook

Module batchmail
    Sub batchmailgonder()

        'early ise 2007yi ekle or late binding yap
        'resolve, ve ; olanlarda splitli,

        Dim outApp As outlook.Application
        'Dim outApp As Object
        Dim outMail As outlook.MailItem
        'Dim outMail As Object
        Dim outlooktip As String
        Dim ek As String


        Try

            Dim ff As New frmBatchMailFirstForm
            ff.ShowDialog()

            If ff.dosya.Length > 0 Then app.Workbooks(ff.dosya).Activate() 'işe ayramıyo, kritk dğeil ama bi çare bul
            If ff.devam = False Then Exit Sub

            Dim fm As New frmBatchMail
bastan:
            fm.ShowDialog()

            If fm.devammi = 0 Then 'itale basıldıysa

                Exit Sub 'formda iptale basıldıysa
                
            End If

            app_aksiyon(app, "Giriş")

            'early binding ise burası
            If Process.GetProcessesByName("OUTLOOK").Count() > 0 Then
                'MsgBox("şuanda" & Process.GetProcessesByName("OUTLOOK").Count() & "adet outllok running")
                outlooktip = "varolan"
                outApp = DirectCast(Marshal.GetActiveObject("Outlook.Application"), outlook.Application)
            Else
                'MsgBox("yeni outllok nesnesi yaratıyroum")
                outlooktip = "yeni"
                outApp = New outlook.Application
            End If


            'late binding ise burası yeterli, burda marshala falan gerek yok
            'outApp = CreateObject("Outlook.Application")


            app.Range("a2").Select()
donguyegir:
            Do While CStr(app.ActiveCell.Value) <> ""
                outMail = outApp.CreateItem(outlook.OlItemType.olMailItem)
                'outMail = outApp.CreateItem(0)

                With outMail
                    If fm.mailbutunluk = True Then
                        '.BodyFormat = outlook.OlBodyFormat.olFormatHTML
                        '.HTMLBody = sRTF_To_HTML(fm.govde)
                        .BodyFormat = outlook.OlBodyFormat.olFormatRichText
                        Dim myNewText As String = Windows.Forms.Clipboard.GetText(Windows.Forms.TextDataFormat.Rtf)
                        Dim myNewRtfBytes() As Byte = Encoding.UTF8.GetBytes(myNewText)
                        '.RTFBody = fm.govde
                        .RTFBody = myNewRtfBytes
                    Else
                        'şmdilik geçici sadece textbozları yzdııom, sonra d1 kolonalrını yazcaz ama hangi sırayla ,textbox ve hucre içi sırası ne olcak?
                        .Body = ParametrikMetinBirlestir()
                        '.HTMLBody = fm.govde
                    End If

                    .Subject = fm.konu
                    'önizlemede onbehalf yapıyor ama sende asınca yapmıyor
                    If fm.rbFromOther.Checked = True Then .SentOnBehalfOfName = fm.txtFrom.Text
                    If fm.rbToTodaki.Checked Then
                        .To = app.ActiveCell.Value2
                    Else
                        .To = fm.txtToOnek.Text + CStr(app.ActiveCell.Offset(0, 3).Value2) + "@" + fm.txtToDomain.Text
                    End If
                    If CStr(app.ActiveCell.Offset(0, 1).Value2) <> "" Then .CC = app.ActiveCell.Offset(0, 1).Value2
                    If CStr(app.ActiveCell.Offset(0, 2).Value2) <> "" Then .BCC = app.ActiveCell.Offset(0, 2).Value2


                    'HEM TEXTBOXLARDA HEM LİSBOXTA BULAMAZSA NAPSIN YOL GÖSTER
                    'YANLIŞ BİR DSOYA ADI GİRİLDEYSE napSIN
                    'boş textbox olmasın

                    'attachment kontrol
                    If fm.chkEkDurum.Checked = True Then
                        Select Case fm.cbEkBelirtec.Text
                            Case "Sicil"
                                ek = app.ActiveCell.Value2
                            Case "Bölge"
                                ek = app.ActiveCell.Offset(0, 4).Value2
                            Case "Şube"
                                ek = app.ActiveCell.Offset(0, 3).Value2
                            Case "Bölge-Şube"
                                ek = app.ActiveCell.Offset(0, 4).Value2 + "-" + app.ActiveCell.Offset(0, 3).Value2
                            Case Else '"Bölge-Şube-Sicil"
                                ek = app.ActiveCell.Offset(0, 4).Value2 + "-" + app.ActiveCell.Offset(0, 3).Value2 + "-" + app.ActiveCell.Value2
                        End Select


                        Dim ekler As New Collection
                        If Not fm.txtEk1.Text = "" Then ekler.Add(fm.txtEkKlasor.Text + "\" + ek + fm.cbEkAyrac1.Text + fm.txtEk1.Text + "." + fm.cbEkUzant1.Text)
                        If Not fm.txtEk2.Text = "" Then ekler.Add(fm.txtEkKlasor.Text + "\" + ek + fm.cbEkAyrac2.Text + fm.txtEk2.Text + "." + fm.cbEkUzant2.Text)
                        If Not fm.txtEk3.Text = "" Then ekler.Add(fm.txtEkKlasor.Text + "\" + ek + fm.cbEkAyrac3.Text + fm.txtEk3.Text + "." + fm.cbEkUzant3.Text)

                        If fm.lbSoloEk.Items.Count > 0 Then
                            For i As Byte = 0 To fm.lbSoloEk.Items.Count - 1
                                ekler.Add(fm.lbSoloEk.Items(i))
                            Next 'i

                            'For i = 1 To ekler.Count
                            '    If ekler(i) <> "" Then
                            '        .Attachments.Add(ekler(i))
                            '    End If
                            'Next i

                            For Each ekcol As String In ekler
                                ' MsgBox(ekcol)
                                .Attachments.Add(ekcol)
                            Next ekcol
                        End If
                    End If

                    If fm.devammi = 1 Then '0'ı başta geçmiştik zaten, 0sa exit dmeiştik,1=gönderse
                        .Send()
                    Else 'yani 2yse yani önizlemyese
                        .Display()
                        Marshal.ReleaseComObject(outMail)
                        outMail = Nothing

                        If outlooktip = "varolan" Then
                            outApp = Nothing
                        Else
                            outApp.Quit()
                            Marshal.ReleaseComObject(outApp)
                            outApp = Nothing
                        End If

                        fm.devammi = 0 'x(close) tuşuna basınca bile hafızada devammı=1 oldugu için önilzmeey basıldlı diyor
                        GoTo bastan
                    End If
                End With
                app.ActiveCell.Offset(0, 9).Value2 = "Mail gönderimi başarılı"
                app.ActiveCell.Offset(1, 0).Select()
                Marshal.ReleaseComObject(outMail)
                outMail = Nothing
            Loop

            If outlooktip = "varolan" Then
                outApp = Nothing
            Else
                outApp.Quit()
                Marshal.ReleaseComObject(outApp)
                outApp = Nothing

                'tüm bu marshallar yerine aşağıdaki gibi de yapabilrsin
                'Dim procs() As Process = Process.GetProcessesByName("OUTLOOK")
                'For Each x As Process In procs
                '    x.Kill()
                'Next x
            End If
            MsgBox("Mail gönderimi tamamlandı")
            'GoTo bastan
        Catch e As Exception
            app.ActiveCell.Offset(0, 9).Value2 = e.Message
            app.ActiveCell.Offset(1, 0).Select()
            Marshal.ReleaseComObject(outMail)
            outMail = Nothing
            GoTo donguyegir
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    'Sub excel_ready()

    '    Dim wb As Excel.Workbook

    '    wb = app.Workbooks.Add()
    '    app.Range("a1").Select()
    '    app.ActiveCell.FormulaR1C1 = "To"
    '    app.Range("B1").Select()
    '    app.ActiveCell.FormulaR1C1 = "cc"
    '    app.Range("C1").Select()
    '    app.ActiveCell.FormulaR1C1 = "bcc"
    '    app.Range("D1").Select()
    '    app.ActiveCell.FormulaR1C1 = "şube kodu"
    '    app.Range("E1").Select()
    '    app.ActiveCell.FormulaR1C1 = "bölge kodu"
    '    app.Range("F1").Select()
    '    CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken1"
    '    app.Range("G1").Select()
    '    CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken2"
    '    app.Range("H1").Select()
    '    CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken3"
    '    app.Range("I1").Select()
    '    CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken4"
    '    app.Range("j1").Select()
    '    CType(app.Selection, Excel.Range).FormulaR1C1 = "Açıklama"
    '    app.Range("A1:j1").Select()
    '    With CType(app.Selection, Excel.Range).Interior
    '        .Pattern = Excel.XlPattern.xlPatternSolid
    '        .PatternColorIndex = Excel.XlPattern.xlPatternAutomatic
    '        .Color = 255
    '        .TintAndShade = 0
    '        .PatternTintAndShade = 0
    '    End With
    '    With CType(app.Selection, Excel.Range).Font
    '        .ThemeColor = Excel.XlThemeColor.xlThemeColorDark1
    '        .TintAndShade = 0
    '    End With
    '    CType(app.Columns("A:j"), Excel.Range).Select()
    '    CType(app.Selection, Excel.Range).ColumnWidth = 9.57
    '    CType(app.Columns("k:k"), Excel.Range).Select()
    '    app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlToRight)).Select()
    '    CType(app.Selection, Excel.Range).EntireColumn.Hidden = True
    '    app.Range("A2").Select()

    'End Sub
    Public Function sRTF_To_HTML(ByVal sRTF As String) As String
        'bulletinlerde sorun
        'Declare a Word Application Object and a Word WdSaveOptions object
        Dim MyWord As Microsoft.Office.Interop.Word.Application
        Dim oDoNotSaveChanges As Object = _
             Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges
        'Declare two strings to handle the data
        Dim sReturnString As String = ""
        Dim sConvertedString As String = ""
        Try
            'Instantiate the Word application,
            'â€˜set visible to false and create a document
            MyWord = CreateObject("Word.application")
            MyWord.Visible = False
            MyWord.Documents.Add()
            'Create a DataObject to hold the Rich Text
            'and copy it to the clipboard
            Dim doRTF As New System.Windows.Forms.DataObject
            doRTF.SetData("Rich Text Format", sRTF)
            Windows.Forms.Clipboard.SetDataObject(doRTF)
            'Paste the contents of the clipboard to the empty,
            'hidden Word Document
            MyWord.Windows(1).Selection.Paste()
            'â€¦then, select the entire contents of the document
            'and copy back to the clipboard
            MyWord.Windows(1).Selection.WholeStory()
            MyWord.Windows(1).Selection.Copy()
            'Now retrieve the HTML property of the DataObject
            'stored on the clipboard
            sConvertedString = _
                 Windows.Forms.Clipboard.GetData(System.Windows.Forms.DataFormats.Html)
            'Remove some leading text that shows up in some instances
            '(like when you insert it into an email in Outlook
            sConvertedString = _
                 sConvertedString.Substring(sConvertedString.IndexOf("<html"))
            'Also remove multiple Ã‚ characters that somehow end up in there
            sConvertedString = sConvertedString.Replace("Ã‚", "")
            sConvertedString = sConvertedString.Replace("Ãœ", "Ü")
            sConvertedString = sConvertedString.Replace("Ã¼", "ü")
            sConvertedString = sConvertedString.Replace("Å", "Ş")
            sConvertedString = sConvertedString.Replace("ÅŸ", "ş")
            sConvertedString = sConvertedString.Replace("Ã§", "ç")
            sConvertedString = sConvertedString.Replace("Ã‡", "Ç")
            sConvertedString = sConvertedString.Replace("Ã–", "Ö")
            sConvertedString = sConvertedString.Replace("Ã¶", "ö")
            sConvertedString = sConvertedString.Replace("Ä°", "İ")
            sConvertedString = sConvertedString.Replace("Ä±", "ı")
            sConvertedString = sConvertedString.Replace("ÄŸ", "ğ")
            sConvertedString = sConvertedString.Replace("Ä", "Ğ")
            'â€¦and you're done.
            sReturnString = sConvertedString
            If Not MyWord Is Nothing Then
                MyWord.Quit(oDoNotSaveChanges)
                MyWord = Nothing
            End If
        Catch ex As Exception
            If Not MyWord Is Nothing Then
                MyWord.Quit(oDoNotSaveChanges)
                MyWord = Nothing
            End If
            MsgBox("Error converting Rich Text to HTML")
        End Try
        Return sReturnString
    End Function
    Public Function ParametrikMetinBirlestir() As String
        Return "merhaba"
    End Function
End Module
