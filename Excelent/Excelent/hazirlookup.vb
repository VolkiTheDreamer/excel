Module hazirlookup
    'TODO:jenerik hle getrelim. şuan adet yazdırmak ve diğer loouplar birbirinin aynı mantıgı olmasıana ragemne yönmte bütünlüğü yok
    'İlgli dosya açıksa tekrar açmaya çalışmasın
    'adet yazdırmalarda miy tipine göre rakam girdirtirken diğerlerinin her biri için ayrı makro var
    'Dim app As Excel.Application = Globals.ThisAddIn.Application
    'nufus kayıt örnegi
#Region "fiili ve norm yazma"
    Sub fiiliyaz()
        'perdosya seilmediyse uyarı versin
        'poers dosyası açıksa tekrar açmasın, dipslayalert varken belki sorun olmaz, bak bakalım
        Dim fp As New frmSubelerPersonel
        Dim persDosyaPath As String = fp.prsPath
        Dim persDosyaPathNoKoseli As String = persDosyaPath.Replace("[", "").Replace("]", "")
        Dim aktifWB, lookupDosya As Excel.Workbook
        Dim kolonRef, miyTip As Integer
        Dim altSinir As Excel.Range

        Try
            'ilk try bloğunda dosya set edilmiş mi ona bakıyoruz. nasıl anlaşılıyor, dosyayı açdiyoruz
            'hata varsa bu kesin dosya adıyla ilgilidir, o yüzdecathc blogunda direkt bu mesjaı veriyroz
            'app_aksiyon(app, "Giriş")

            aktifWB = app.ActiveWorkbook
            app.Workbooks.Open(Filename:=persDosyaPathNoKoseli)
            lookupDosya = app.ActiveWorkbook
            Try
                aktifWB.Activate()

                Dim lkpHucre As Excel.Range

bastan:
                lkpHucre = CType(app.InputBox("Lookup yapacağınız hücreyi seçin", [Default]:="A2", Type:=8), Excel.Range)
                ' MsgBox(lkpHucre.Address)

                'If lkpHucre.Address = "A2" Then
                '    lookupDosya.Close()
                '    MsgBox("escape basıldı, şimdi kapancak")
                '    Exit Sub
                'End If

                'If IsNothing(System.Convert.ToBoolean(lkpHucre)) Then Exit Sub
                'If IsNothing(lkpHucre) Then Exit Sub
                'If lkpHucre.Cells.Count = 0 Then Exit Sub
                'If lkpHucre Is Nothing Then Exit Sub
                'If lkpHucre.Value2 Is Nothing Then Exit Sub
                'If IsNothing(lkpHucre.Value2) Then Exit Sub
                If CStr(lkpHucre.Value2) = "" Then
                    MsgBox("Değer içermeyen bir hücre seçtiniz, tekrar deneyiniz")
                    GoTo bastan
                End If


                'bu kısma çok gerk yok gibi, zaten offset ile altSinir bulup en alta gitmesini engelliyorum.
                'If app.Intersect(app.ActiveCell, app.Range(lkpHucre.CurrentRegion.Offset(0, -1), lkpHucre.CurrentRegion.Offset(0, 1))) Is Nothing Then
                '    MsgBox("Seçtiğiniz hücre aktif hücrenin komşuluğunda değil, tekrar deneyiniz")
                '    GoTo bastan
                'End If


                kolonRef = lkpHucre.Column - app.ActiveCell.Column

                miyTip = CInt(InputBox("Miy tipini seçin:" & vbCrLf & "BMIY için 7," & vbCrLf & "BBY için 13," & vbCrLf & "BBMIY için 8," & vbCrLf & "KOBIMIY için 6," & vbCrLf & "TMIY için 5" & vbCrLf & "Toplam MIY için 9" & vbCrLf & "Gişeci için 11"))

                CType(app.Selection, Excel.Range).FormulaR1C1 = "=VLOOKUP(RC[" & kolonRef & "],'" & persDosyaPath & "Personel Adet'!C2:C50," & miyTip & ",0)"


                altSinir = app.ActiveCell.Offset(0, kolonRef).End(Excel.XlDirection.xlDown).Offset(0, -kolonRef)
                'eğer tek satırlık bir lookup yapılcaksa kontrol yapalım ki en aşağı kadar indirmesin
                If CStr(lkpHucre.Offset(1, 0).Value2) = "" Then
                    app.ActiveCell.Select()
                Else
                    CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), altSinir))
                    app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
                End If

                CType(app.Selection, Excel.Range).Copy()
                CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
                                :=False, Transpose:=False)


                lookupDosya.Close(SaveChanges:=False)
            Catch
                'MsgBox(e.Message)
                MsgBox("Ya birşey ters gitti ya da işlemden vazgeçtiniz")
            End Try
        Catch
            MsgBox("Personel dosyası set edilmemiş veya yanlış set edilmiş. Kontrol edip tekrar deneyiniz")
        Finally
            If Not lookupDosya Is Nothing Then lookupDosya.Close()
        End Try
    End Sub
    Sub normyaz()

        Dim fp As New frmSubelerPersonel
        Dim persDosyaPath As String = fp.prsPath
        Dim persDosyaPathNoKoseli As String = persDosyaPath.Replace("[", "").Replace("]", "")
        Dim aktifWB, lookupDosya As Excel.Workbook
        Dim kolonRef, miyTip As Integer
        Dim altSinir As Excel.Range

        Try

            aktifWB = app.ActiveWorkbook
            app.Workbooks.Open(Filename:=persDosyaPathNoKoseli)

            lookupDosya = app.ActiveWorkbook
            aktifWB.Activate()

            Dim lkpHucre As Excel.Range
bastan:
            lkpHucre = CType(app.InputBox("Lookup yapacağınız ilk şube kodunun olduğu hücreyi seçin", Type:=8), Excel.Range)

            If CStr(lkpHucre.Value2) = "" Then
                MsgBox("Değer içermeyen bir hücre seçtiniz, tekrar deneyiniz")
                GoTo bastan
            End If

            app_aksiyon(app, "Giriş")

            kolonRef = lkpHucre.Column - app.ActiveCell.Column


            miyTip = CInt(InputBox("Miy tipini seçin:" & vbCrLf & "BMIY için 5," & vbCrLf & "BBMIY için 6," & vbCrLf & "KOBIMIY için 7," & vbCrLf & "Karma TMIY için 4"))
            CType(app.Selection, Excel.Range).FormulaR1C1 = "=VLOOKUP(RC[" & kolonRef & "],'" & persDosyaPath & "NormFlag'!C2:C50," & miyTip & ",0)"


            altSinir = app.ActiveCell.Offset(0, kolonRef).End(Excel.XlDirection.xlDown).Offset(0, -kolonRef)

            'eğer tek satırlık bir lookup yapılcaksa kontrol yapalım ki en aşağı kadar indirmesin
            If CStr(lkpHucre.Offset(1, 0).Value2) = "" Then
                app.ActiveCell.Select()
            Else
                CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), altSinir))
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
            End If
            CType(app.Selection, Excel.Range).Copy()
            CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
                            :=False, Transpose:=False)


            lookupDosya.Close(SaveChanges:=False)
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
#End Region
#Region "bölge kodundan lookup"
    Sub bolgekodundanyaz(lkpkolon As Integer)

        Dim fs As New frmSubelerPersonel
        Dim subeDosyaPath As String = fs.sbPath
        Dim subeDosyaPathNoKoseli As String = subeDosyaPath.Replace("[", "").Replace("]", "")
        Dim aktifWB, lookupDosya As Excel.Workbook
        Dim kolonRef As Integer
        Dim altSinir As Excel.Range

        Try

            aktifWB = app.ActiveWorkbook
            app.Workbooks.Open(Filename:=subeDosyaPathNoKoseli)

            lookupDosya = app.ActiveWorkbook
            aktifWB.Activate()

            Dim lkpHucre As Excel.Range
bastan:
            lkpHucre = CType(app.InputBox("Lookup yapacağınız hücreyi seçin", Type:=8), Excel.Range)
            If CStr(lkpHucre.Value2) = "" Then
                MsgBox("Değer içermeyen bir hücre seçtiniz, tekrar deneyiniz")
                GoTo bastan
            End If

            app_aksiyon(app, "Giriş")

            kolonRef = lkpHucre.Column - app.ActiveCell.Column


            CType(app.Selection, Excel.Range).FormulaR1C1 = "=VLOOKUP(RC[" & kolonRef & "],'" & subeDosyaPath & "Bölge Ekip'!C1:C10," & lkpkolon & ",0)"


            altSinir = app.ActiveCell.Offset(0, kolonRef).End(Excel.XlDirection.xlDown).Offset(0, -kolonRef)
            'eğer tek satırlık bir lookup yapılcaksa kontrol yapalım ki en aşağı kadar indirmesin
            If CStr(lkpHucre.Offset(1, 0).Value2) = "" Then
                app.ActiveCell.Select()
            Else
                CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), altSinir))
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
            End If
            CType(app.Selection, Excel.Range).Copy()
            CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
                            :=False, Transpose:=False)


            lookupDosya.Close(SaveChanges:=False)
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
#End Region
#Region "Şube kodundan lookup"
    Sub subekodundansubeselbilgiyaz(lkpkolon As Integer)

        Dim fs As New frmSubelerPersonel
        Dim subeDosyaPath As String = fs.sbPath
        Dim subeDosyaPathNoKoseli As String = subeDosyaPath.Replace("[", "").Replace("]", "")
        Dim aktifWB, lookupDosya As Excel.Workbook
        Dim kolonRef As Integer
        Dim altSinir As Excel.Range

        Try

            aktifWB = app.ActiveWorkbook
            app.Workbooks.Open(Filename:=subeDosyaPathNoKoseli)

            lookupDosya = app.ActiveWorkbook
            aktifWB.Activate()

            Dim lkpHucre As Excel.Range
bastan:
            lkpHucre = CType(app.InputBox("Lookup yapacağınız hücreyi seçin", Type:=8), Excel.Range)
            If CStr(lkpHucre.Value2) = "" Then
                MsgBox("Değer içermeyen bir hücre seçtiniz, tekrar deneyiniz")
                GoTo bastan
            End If

            app_aksiyon(app, "Giriş")

            kolonRef = lkpHucre.Column - app.ActiveCell.Column

            CType(app.Selection, Excel.Range).FormulaR1C1 = "=VLOOKUP(RC[" & kolonRef & "],'" & subeDosyaPath & "Şubeler'!C1:C12," & lkpkolon & ",0)"


            altSinir = app.ActiveCell.Offset(0, kolonRef).End(Excel.XlDirection.xlDown).Offset(0, -kolonRef)
            'eğer tek satırlık bir lookup yapılcaksa kontrol yapalım ki en aşağı kadar indirmesin
            If CStr(lkpHucre.Offset(1, 0).Value2) = "" Then
                app.ActiveCell.Select()
            Else
                CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), altSinir))
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
            End If
            CType(app.Selection, Excel.Range).Copy()
            CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
                            :=False, Transpose:=False)
            If lkpkolon = 7 Then CType(app.Selection, Excel.Range).NumberFormat = "m/d/yyyy"
            If lkpkolon = 11 Then CType(app.Selection, Excel.Range).NumberFormat = "m/d/yyyy"

            lookupDosya.Close(SaveChanges:=False)
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    Sub subekodundanpersonelbilgiyaz(lkpkolon As Integer)

        Dim fp As New frmSubelerPersonel
        Dim persDosyaPath As String = fp.prsPath
        Dim persDosyaPathNoKoseli As String = persDosyaPath.Replace("[", "").Replace("]", "")
        Dim aktifWB, lookupDosya As Excel.Workbook
        Dim kolonRef As Integer
        Dim altSinir As Excel.Range

        Try

            aktifWB = app.ActiveWorkbook
            app.Workbooks.Open(Filename:=persDosyaPathNoKoseli)

            lookupDosya = app.ActiveWorkbook
            aktifWB.Activate()

            Dim lkpHucre As Excel.Range
bastan:
            lkpHucre = CType(app.InputBox("Lookup yapacağınız hücreyi seçin", Type:=8), Excel.Range)
            If CStr(lkpHucre.Value2) = "" Then
                MsgBox("Değer içermeyen bir hücre seçtiniz, tekrar deneyiniz")
                GoTo bastan
            End If

            app_aksiyon(app, "Giriş")

            kolonRef = lkpHucre.Column - app.ActiveCell.Column


            CType(app.Selection, Excel.Range).FormulaR1C1 = "=VLOOKUP(RC[" & kolonRef & "],'" & persDosyaPath & "Şube Md'!C3:C6," & lkpkolon & ",0)"


            altSinir = app.ActiveCell.Offset(0, kolonRef).End(Excel.XlDirection.xlDown).Offset(0, -kolonRef)
            'eğer tek satırlık bir lookup yapılcaksa kontrol yapalım ki en aşağı kadar indirmesin
            If lkpHucre.Offset(1, 0).Value2 = "" Then
                app.ActiveCell.Select()
            Else
                CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), altSinir))
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
            End If
            CType(app.Selection, Excel.Range).Copy()
            CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
                            :=False, Transpose:=False)


            lookupDosya.Close(SaveChanges:=False)
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
#End Region
#Region "Sicilden lookup bölgesi"
    Sub sicildenyaz(lkpkolon As Integer)

        Dim fp As New frmSubelerPersonel
        Dim persDosyaPath As String = fp.prsPath
        Dim persDosyaPathNoKoseli As String = persDosyaPath.Replace("[", "").Replace("]", "")
        Dim aktifWB, lookupDosya As Excel.Workbook
        Dim kolonRef As Integer
        Dim altSinir As Excel.Range

        Try

            aktifWB = app.ActiveWorkbook
            app.Workbooks.Open(Filename:=persDosyaPathNoKoseli)

            lookupDosya = app.ActiveWorkbook
            aktifWB.Activate()

            Dim lkpHucre As Excel.Range
bastan:
            lkpHucre = CType(app.InputBox("Lookup yapacağınız hücreyi seçin", Type:=8), Excel.Range)
            If CStr(lkpHucre.Value2) = "" Then
                MsgBox("Değer içermeyen bir hücre seçtiniz, tekrar deneyiniz")
                GoTo bastan
            End If

            app_aksiyon(app, "Giriş")

            kolonRef = lkpHucre.Column - app.ActiveCell.Column


            CType(app.Selection, Excel.Range).FormulaR1C1 = "=VLOOKUP(RC[" & kolonRef & "],'" & persDosyaPath & "Anadata'!C2:C12," & lkpkolon & ",0)"
            altSinir = app.ActiveCell.Offset(0, kolonRef).End(Excel.XlDirection.xlDown).Offset(0, -kolonRef)


            'eğer tek satırlık bir lookup yapılcaksa kontrol yapalım ki en aşağı kadar indirmesin
            If CStr(lkpHucre.Offset(1, 0).Value2) = "" Then
                app.ActiveCell.Select()
            Else
                CType(app.Selection, Excel.Range).AutoFill(Destination:=app.Range(CType(app.Selection, Excel.Range), altSinir))
                app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
            End If

            CType(app.Selection, Excel.Range).Copy()
            CType(app.Selection, Excel.Range).PasteSpecial(Paste:=Excel.XlPasteType.xlPasteValues, Operation:=Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, SkipBlanks _
                            :=False, Transpose:=False)

            If lkpkolon = 10 Then CType(app.Selection, Excel.Range).NumberFormat = "m/d/yyyy"
            If lkpkolon = 11 Then CType(app.Selection, Excel.Range).NumberFormat = "m/d/yyyy"

            lookupDosya.Close(SaveChanges:=False)
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
#End Region

End Module
