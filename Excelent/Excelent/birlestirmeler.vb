Imports System.Windows.Forms

Module birlestirmeler
    '  Dim app As Excel.Application = Globals.ThisAddIn.Application
    Sub sheetleri_birlestir()
        'TODO:işimdilik tek satır başlık
        Try


            Dim soru As MsgBoxResult
            soru = MsgBox("Tüm sayfaların aynı formatta olması lazım." & vbCrLf & "Devam edilsin mi?", MsgBoxStyle.YesNo)
            If soru = MsgBoxResult.No Then Exit Sub

            Dim anadosya As Excel.Workbook

            anadosya = app.ActiveWorkbook

            app_aksiyon(app, "Giriş")

            app.Sheets.Select()
            CType(app.Sheets(1), Excel.Worksheet).Activate()


            CType(app.Columns("A:A"), Excel.Range).Select()
            CType(app.Selection, Excel.Range).Insert(Shift:=Excel.XlInsertShiftDirection.xlShiftToRight, CopyOrigin:=Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)

            app.Range("A1").Select()
            CType(app.Selection, Excel.Range).FormulaR1C1 = "Kalem"
            With CType(app.Selection, Excel.Range).Characters(Start:=1, Length:=5).Font
                .Name = "Arial"
                .FontStyle = "Bold" 'türkçe mi
                .Size = 9
                .Strikethrough = False
                .Superscript = False
                .Subscript = False
                .OutlineFont = False
                .Shadow = False
                .Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone
                .TintAndShade = 0
                .ThemeFont = Excel.XlThemeFont.xlThemeFontNone
            End With
            app.Range("A2").Select()

            For i = 1 To app.Sheets.Count
                CType(app.Sheets(i), Excel.Worksheet).Select()
                CType(app.Selection, Excel.Range).FormulaR1C1 = CType(app.ActiveSheet, Excel.Worksheet).Name
                app.Range("A3").FormulaR1C1 = CType(app.ActiveSheet, Excel.Worksheet).Name 'niye a3e de yazıyorum çünkü, rakamla bitenlerde artırarak gidiyor
                app.Range("a2:a3").Select()
                CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).Offset(0, 1).End(Excel.XlDirection.xlDown).Offset(0, -1)))
            Next i


            CType(app.Sheets(1), Excel.Worksheet).Select()
            app.Sheets.Add()
            CType(app.Sheets(1), Excel.Worksheet).Name = "Toplu"

            CType(app.Sheets(2), Excel.Worksheet).Select() 'herhangi bir sayfadan başlık alıcaz, 2 olup olmaması önemli değil
            CType(app.Rows("1:1"), Excel.Range).Select()
            CType(app.Selection, Excel.Range).Copy()
            CType(app.Sheets(1), Excel.Worksheet).Select()
            app.Range("A1").Select()
            CType(app.ActiveSheet, Excel.Worksheet).Paste()



            For k = 1 To app.Sheets.Count - 1
                CType(app.Sheets(k + 1), Excel.Worksheet).Select()
                app.Range("A2").Select()
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlToRight)).Select()
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
                app.CutCopyMode = CType(False, Excel.XlCutCopyMode)
                CType(app.Selection, Excel.Range).Copy()
                CType(app.Sheets(1), Excel.Worksheet).Select()


                If CDbl(app.Version) < 12 Then 'excel 2003 veya önceisyse
                    app.Range("a65000").End(Excel.XlDirection.xlUp).Offset(1, 0).Select()
                Else
                    Select Case anadosya.FileFormat
                        Case Excel.XlFileFormat.xlExcel8 ' xlexcel8=56 olur ki, 2007 ve sorasındaki enumlardır, 
                            'xlworkbooknormal=-4143 ise 2003 ve öncesinden anlaılıdır, ama biz zaten versiyon
                            'ile onu ele aldık, o yüzden gerek kalmadı
                            'xlexcel8 ile xls dosyasıı olup olmadıgna bakıyoruz
                            app.Range("a65000").End(Excel.XlDirection.xlUp).Offset(1, 0).Select()
                        Case Else
                            'Case 50(xlExcel12), 51(xlOpenXMLWorkbook), 52(xlOpenXMLWorkbookMacroEnabled)
                            'sırayla xlsb, xlsx veya xlsm ise
                            app.Range("a1048000").End(Excel.XlDirection.xlUp).Offset(1, 0).Select()
                    End Select
                End If

                CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
            :=False, Transpose:=False)
            Next k
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    Sub wb_birlestir()
        'IO, filesystem
        'FORMLA BAŞLAT, SORSUN BAŞLIK OLCAK MI DİYE, BAŞLIK OLCAKSA SADECE İLK DOSYADA BAŞLIK ALSIN
        'FORM ÜZERİNDEN DOSYAYI BROWSE ETSİN
        Dim klasor As String
        Dim birlesikDizi As New Collection
        Dim dialog As New FolderBrowserDialog()
        Try

            'dialog.RootFolder = Environment.SpecialFolder.Desktop
            'dialog.SelectedPath = "C:\"
            dialog.Description = "Select Application Configeration Files Path"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                klasor = dialog.SelectedPath
            End If

            app_aksiyon(app, "Giriş")

            'ilgili dosyaları bir diziye aktarıyoruz
            For Each dosya As String In My.Computer.FileSystem.GetFiles(klasor)
                'MsgBox(klasor)
                'MsgBox(dosya)
                birlesikDizi.Add(dosya)
            Next dosya

            app.Workbooks.Add()
            Dim toplu As Excel.Workbook = app.ActiveWorkbook
            app.Workbooks.Open(birlesikDizi.Item(1)) 'geçci olarak dosyalardan birini açıyoz, sayfa sayısını saydırıyoz, topluya eksik sayfa kadar sayfa ekliyoruz
            Dim scount As Integer = app.ActiveWorkbook.Sheets.Count
            app.ActiveWorkbook.Close(SaveChanges:=False) 'geçici dosyay kapıyoruz
            'eksik sayfa varsa tamalıyoruz
            Do While toplu.Sheets.Count < scount
                toplu.Sheets.Add()
            Loop


            Dim eleman As Excel.Workbook
            Dim sayfa As String

            For Each dsy As String In birlesikDizi
                app.Workbooks.Open(dsy)
                eleman = app.ActiveWorkbook

                For i As Integer = 1 To scount

                    CType(eleman.Sheets(i), Excel.Worksheet).Select()
                    sayfa = CType(app.ActiveSheet, Excel.Worksheet).Name
                    app.Range("a1").CurrentRegion.Copy()
                    toplu.Activate()
                    CType(toplu.Sheets(i), Excel.Worksheet).Select()
                    CType(app.ActiveSheet, Excel.Worksheet).Paste()
                    app.ActiveCell.End(Excel.XlDirection.xlDown).Offset(1, 0).Select()
                    CType(app.ActiveSheet, Excel.Worksheet).Name = sayfa
                    eleman.Activate()
                Next i

                eleman.Close(SaveChanges:=False) 'gerekirse bunları diziye e loopa kyup öyle topluca kapa
            Next dsy

        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try
        ''if secim=true then a=1 else a=sheets.coun
        'Do
        '    For i As Integer = 1 To a
        '        Workbooks.open(dizim(1))
        '        activesheet.select()
        '        toplu.Activate()
        '    Next i
        'loop Until 'sona gelnee

        '        Belik bi de sheet sayısını eşilteyene kadar sheets.add gerekir



        'bölge = Array(dosyaları seçtrip önceden diziye ata)

        '        Path = "……"

        '        Workbooks.Open Filename:=Path & "Bölgelerden gelen toplu.xls"
        '        toplu = ActiveWorkbook

        '        For k = 0 To 19

        '            Workbooks.Open Filename:=Path & bölge(k)
        '            blg = ActiveWorkbook


        '            For i = 1 To Sheets.Count

        '                toplu.Activate()
        '                Sheets(i).Select()
        '                blg.Activate()
        '                Sheets(i).Select()
        '                Range("a2").Select()
        '                Range(Selection, Selection.End(xlToRight).End(xlDown)).Select()
        '                Selection.Copy()
        '                toplu.Activate()
        '                Range("a65000").End(xlUp).Offset(1, 0).Select()
        '                ActiveSheet.Paste()

        '            Next i
        '            Application.DisplayClipboardWindow = False
        '            Application.DisplayAlerts = False 'clipbord sormasın diye
        '            blg.Close savechanges:=False
        '            Application.DisplayAlerts = True 'tekrar eski haline geitmrke için
        '        Next k

        '    End Sub



    End Sub
End Module
