Module diger

    Public Sub BOSLUKSIL()


        'ilk = Application.InputBox("İLK HUCREYİ SEÇ", Type:=8)
        'SON = Application.InputBox("SON HUCREYİ SEÇ", Type:=8)

        'ustsatir = ilk.Row
        'altsatir = SON.Row


        'For i = ustsatir To altsatir
        '    If IsEmpty(Cells(i, 1)) = True Then
        '        Rows(i).Delete()
        '        altsatir = altsatir - 1
        '        i = i - 1
        '    End If

        '    If i = altsatir Then Exit Sub
        'Next i
        'Range("A1").Activate()

    End Sub
    Sub tersfiltre()
        ''excel 2007de buna pek gerek kalmadı gibi
        'filtre = ActiveCell.Value
        'filtreici = "<>" & filtre
        'Sütun = ActiveCell.Column
        'Selection.AutoFilter(Field:=Sütun, Criteria1:=filtreici, Operator _
        '    :=xlAnd)
        'Range("a1").Select()
    End Sub
    Sub noktalıvirgül()

        '        cevap = MsgBox("en tepedeki hücredesin dimi", vbYesNo)
        '        If cevap = 6 Then ' YES DEMEK OLUYO

        '            GoTo devamet
        '        Else
        '            MsgBox "o zaman oraya git öyle çalıştır"
        '            Exit Sub
        '        End If

        'devamet:

        '        x = InputBox("';' mü olsun, yoksa ',' mü?")

        '        Application.CutCopyMode = False
        '        Selection.Copy()
        '        ActiveCell.Offset(0, 1).Select()
        '        ActiveSheet.Paste()
        '        ActiveCell.Offset(1, 0).Select()
        '        Select Case x
        '            Case ";"
        '                Selection.FormulaR1C1 = "=RC[-1]&"";""&R[-1]C"
        '            Case ","
        '                Selection.FormulaR1C1 = "=RC[-1]&"",""&R[-1]C"
        '        End Select
        '        Selection.AutoFill Destination:=Range(Selection, Selection.Offset(0, -1).End(xlDown).Offset(0, 1))
        '        Selection.End(xlDown).Select()
        '        Selection.Copy()
        '        Selection.PasteSpecial(Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        '            :=False, Transpose:=False)
        '        Range(Selection.Offset(-1, 0), Selection.Offset(-1, 0).End(xlUp)).Select()
        '        Selection.ClearContents()
        '        ActiveCell.End(xlDown).Select()

    End Sub
    Sub secimi_carp()
        '        Bi menü olsun:Seçimi Çarp
        '        X2()
        '        X10()
        '        X100()
        '        X1000()
        '        Değer giricem(InputBox)
        'Undo(önce diziiye ata, geri lamak isterse bu diziiyi deploy et)

    End Sub
End Module
