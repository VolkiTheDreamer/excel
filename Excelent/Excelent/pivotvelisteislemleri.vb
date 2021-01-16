Module pivotvelisteislemleri
    '    Dim app As Excel.Application = Globals.ThisAddIn.Application
    Sub yanyanayaz()
        Try

            Dim yeniTabloKonum, aktifhucre As Excel.Range
            Dim anaKolon, yanaYazilacakinKolonu, fark As Integer
            yeniTabloKonum = CType(app.InputBox("Yeni liste nereye yazılacak?", Type:=8), Excel.Range)
            anaKolon = CType(app.InputBox("Ana değişken kriterinin olduğu sütundan bir hücre seçin", Type:=8), Excel.Range).Column
            yanaYazilacakinKolonu = CType(app.InputBox("Hangi değişkenlerin yanyana yazılmasını istiyorsanız o sütundan bir hücre seçin.", Type:=8), Excel.Range).Column

            app_aksiyon(app, "Giriş")

            fark = yanaYazilacakinKolonu - anaKolon '2 sütun arasında kaç sütun fark var

            Dim k As Integer = 0
            CType(app.Cells(2, anaKolon), Excel.Range).Select()

            Do
                Dim i As Integer = 1

                Do
                    aktifhucre = app.ActiveCell
                    yeniTabloKonum.Offset(k, 0).Value2 = aktifhucre.Value2
                    yeniTabloKonum.Offset(k, 0).Offset(0, i).Value2 = aktifhucre.Offset(0, fark).Value2
                    aktifhucre.Offset(1, 0).Select()
                    i = i + 1

                Loop Until CStr(aktifhucre.Value2) <> CStr(aktifhucre.Offset(1, 0).Value2)

                k = k + 1

            Loop Until CStr(app.ActiveCell.Value2) = ""
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    Sub listeyi_ayrıayrı_altaltayaz()
        'indirectli olaya hazır hale getirme makrosu
        Try

            Dim baslangic, altliste, baslik, nerdeydim As Excel.Range
            Dim kac As Integer
            Dim blg As String

            'bunları sorarken cancel dyiince sorun oluyor
            baslangic = CType(app.InputBox("Nihai liste nereye yazılacaksa orayı seçin. Solunda en az bir boş kolon olsun, ve 1.satırda olsun.", Type:=8), Excel.Range)
            baslik = CType(app.InputBox("Başlık haline getirilecek sütunu seçin", Type:=8), Excel.Range)
            altliste = CType(app.InputBox("Liste haline getirilecek sütunu seçin", Type:=8), Excel.Range)

            app_aksiyon(app, "Giriş")

            app.CutCopyMode = CType(False, Excel.XlCutCopyMode)
            baslik.Select()
            CType(app.Selection, Excel.Range).Copy()

            'önce başlık halledelim
            baslangic.Offset(0, -1).Select()
            CType(app.ActiveSheet, Excel.Worksheet).Paste()
            app.CutCopyMode = CType(False, Excel.XlCutCopyMode)
            app.Selection.RemoveDuplicates(Columns:=1, Header:=Excel.XlYesNoGuess.xlYes)
            kac = app.ActiveCell.End(Excel.XlDirection.xlDown).Row - 1 '-1'in sebebi bi de başlık olması, onu altta sildiriyom ama şimdi var

            'başlık olackaları trasnpose
            app.ActiveCell.End(Excel.XlDirection.xlUp).Select()
            CType(app.Selection, Excel.Range).Delete(Shift:=Excel.XlDeleteShiftDirection.xlShiftUp)
            app.Range(app.ActiveCell, app.ActiveCell.End(Excel.XlDirection.xlDown)).Select()
            CType(app.Selection, Excel.Range).Copy()
            app.ActiveCell.Offset(0, 1).Select()
            CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks:=False, Transpose:=True)
            app.ActiveCell.Offset(0, -1).EntireColumn.ClearContents()

            'listeyi oulturalım
            For i As Integer = 1 To kac

                blg = CStr(app.ActiveCell.Text)
                nerdeydim = app.ActiveCell

                app.Range("A1").Select()
                app.CutCopyMode = CType(False, Excel.XlCutCopyMode)
                'CType(app.Selection, Excel.Range).AutoFilter()
                'CType(app.ActiveSheet, Excel.Worksheet).Range("$A$1").CurrentRegion.AutoFilter(Field:=1, Criteria1:="=" & blg & "", Operator:=Excel.XlAutoFilterOperator.xlAnd)
                app.Range("$A$1").CurrentRegion.AutoFilter(Field:=1, Criteria1:="=" & blg & "", Operator:=Excel.XlAutoFilterOperator.xlAnd)
                'app.Range("$A$1").CurrentRegion.Select()
                'CType(app.Selection, Excel.Range).AutoFilter(Field:=1, Criteria1:="Marmara", Operator:=Excel.XlAutoFilterOperator.xlAnd)

                altliste.End(Excel.XlDirection.xlUp).Select()
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
                CType(app.Selection, Excel.Range).SpecialCells(Excel.XlCellType.xlCellTypeVisible).Select()
                CType(app.Selection, Excel.Range).Copy()
                nerdeydim.Offset(1, 0).Select()
                CType(app.ActiveSheet, Excel.Worksheet).Paste()
                app.CutCopyMode = CType(False, Excel.XlCutCopyMode)
                nerdeydim.Offset(0, 1).Select()
            Next i

            app.ActiveSheet.ShowAllData()

            app.Range(baslangic.Offset(1, 0), baslangic.Offset(1, 0).End(Excel.XlDirection.xlToRight)).Select()
            CType(app.Selection, Excel.Range).Delete(Shift:=Excel.XlDeleteShiftDirection.xlShiftUp)

            app.Range("$A$1").Select()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try
    End Sub
    Sub coklu_rank()
        'şimdilik iki kolona göre, ilerde çoklu olsun
        Try

            Dim kriter, rakam, kritersıra As Excel.Range

            kriter = CType(app.InputBox("Hangi sütun ana değişkenlerinizi içeriyorsa oradan bir hücre seçin.", Type:=8), Excel.Range)
            rakam = CType(app.InputBox("Rakamların olduğu sütundan bir hücre seçin.", Type:=8), Excel.Range)
            kritersıra = CType(app.InputBox("sırano nereye yazılacak", Type:=8), Excel.Range)

            app_aksiyon(app, "Giriş")

            kriter.CurrentRegion.Sort(Key1:=kriter, Order1:=Excel.XlSortOrder.xlAscending, Key2:=rakam _
            , Order2:=Excel.XlSortOrder.xlDescending, Header:=Excel.XlYesNoGuess.xlGuess, OrderCustom:=1, MatchCase _
            :=False, Orientation:=Excel.XlSortOrientation.xlSortColumns, DataOption1:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption2:=Excel.XlSortDataOption.xlSortNormal)

            CType(app.Cells(2, kriter.Column), Excel.Range).Select()

            Do
                Dim i As Integer = 1

                Do While CStr(app.ActiveCell.Value2) = CStr(app.ActiveCell.Offset(1, 0).Value2)
                    CType(app.Cells(app.ActiveCell.Row, kritersıra.Column), Excel.Range).Value2 = i

                    If CStr(CType(app.Cells(app.ActiveCell.Row, rakam.Column), Excel.Range).Value2) = CStr(CType(app.Cells(app.ActiveCell.Offset(1, 0).Row, rakam.Column), Excel.Range).Value2) Then
                        i = i
                    Else
                        i = i + 1
                    End If
                    app.ActiveCell.Offset(1, 0).Select()
                Loop

                CType(app.Cells(app.ActiveCell.Row, kritersıra.Column), Excel.Range).Value2 = i
                app.ActiveCell.Offset(1, 0).Select()

            Loop While CStr(app.ActiveCell.Value2) <> ""

            kritersıra.Value = "Sıra"

            app.Range("A1").Select()

        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    Sub pivottaotofill()
        'pivottan kurtulmadıysa uyarı ver, veya sorsun pivottan kurtarcam, ok mi diye

        Try

            Dim kolonlar, basla As Excel.Range
            Dim k, enalt As Integer
            kolonlar = CType(app.InputBox("kolonları seç", Type:=8), Excel.Range)

            basla = CType(app.InputBox("Kaçıncı satırdan işlee başlanacaksa ordan bi hücreyi seçin.", Type:=8), Excel.Range)

            app_aksiyon(app, "Giriş")

            enalt = basla.Row + basla.CurrentRegion.Rows.Count

            basla.Select()
            k = kolonlar.Columns.Count - 1

            Do
                basla.Offset(0, k).Select()
                Do
                    app.ActiveCell.Offset(1, 0).Select()
                    If CStr(app.ActiveCell.Value2) = "" Then 'burda normalde if isempty(...)=true vardı
                        app.ActiveCell.Value2 = app.ActiveCell.Offset(-1, 0).Value2
                    End If

                Loop Until app.ActiveCell.Row = enalt
                k = k - 1
            Loop Until k < 0

        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    Sub ters_pivot()

        Try

            Dim d1, d2, s As Excel.Range

            d1 = CType(app.InputBox("Pivotlu bölgenin ilk sütunundan bir hücre seçin.", Type:=8), Excel.Range)
            'önce varsa tüm boşluları 0 yapalım, dialoglauncher yap ilerde, boşlukları napcağını seçsin

            app_aksiyon(app, "Giriş")

            d1.CurrentRegion.Replace(What:="", Replacement:="0", LookAt:=Excel.XlLookAt.xlPart, _
            SearchOrder:=Excel.XlSearchOrder.xlByRows, MatchCase:=False, SearchFormat:=False, _
            ReplaceFormat:=False)

            d2 = d1.End(Excel.XlDirection.xlToRight)
            s = d1.Offset(0, -1)
            d1.EntireColumn.Insert(Shift:=Excel.XlInsertShiftDirection.xlShiftToRight, CopyOrigin:=Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)


            'altsatır = Range("a1").End(xlDown).Row - 1


            Dim kaç As Integer = d2.Column - d1.Column

            Dim ad As String = app.Cells(1, d1.Column).Value
            CType(app.Cells(2, d1.Column - 1), Excel.Range).Select()
            app.Selection.Value = ad
            app.Selection.AutoFill(Destination:=app.Range(app.Selection, app.Selection.Offset(0, 1).End(Excel.XlDirection.xlDown).Offset(0, -1)), Type:=Excel.XlAutoFillType.xlFillCopy)



            app.Range(app.Cells(2, 1), app.Range("a1").End(Excel.XlDirection.xlDown).Offset(0, s.Column - 1)).Select()
            app.Selection.Copy()
            'sabit alna yapıştırma
            For i = 1 To kaç
                app.Range("a1").End(Excel.XlDirection.xlDown).Offset(1, 0).Select()
                app.ActiveSheet.Paste()
            Next i

            'data yapıtırma ve başlık yazıdrma
            For i = 1 To kaç
                app.Range(app.Cells(2, d1.Column + i), app.Cells(2, d1.Column + i).End(Excel.XlDirection.xlDown)).Select()
                app.Selection.Copy()
                app.Cells(2, d1.Column).End(Excel.XlDirection.xlDown).Offset(1, 0).Select()
                app.ActiveSheet.Paste()

                ad = app.Cells(1, d1.Column + i).Value
                app.Cells(2, d1.Column - 1).End(Excel.XlDirection.xlDown).Offset(1, 0).Select()
                app.Selection.Value = ad
                app.Selection.AutoFill(Destination:=app.Range(app.Selection, app.Selection.Offset(0, 1).End(Excel.XlDirection.xlDown).Offset(0, -1)), Type:=Excel.XlAutoFillType.xlFillCopy)

                'uzat ilgil eyre kadar
            Next i

            For i = d1.Column + 1 To d2.Column
                app.Columns(i).Select()
                app.Selection.ClearContents()
            Next i

            app.Cells(1, d1.Column).Value = "Rakam"
            app.Cells(1, d1.Column - 1).Value = "Kalem"
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub

End Module
