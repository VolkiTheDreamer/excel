Module casedegisim
    ' Dim app As Excel.Application = Globals.ThisAddIn.Application
    Sub Secilenlerin_tumharfini_buyukyap()
        Dim aktif As Excel.Range
        Dim buyuk As String

        aktif = CType(app.Selection, Excel.Range)

        For Each s As Excel.Range In aktif
            buyuk = StrConv(CStr(s.Value), vbUpperCase) 'hata veriyor bazen, üçü de
            s.Value = buyuk
        Next s
        app.DisplayAlerts = False
        CType(app.Selection, Excel.Range).Replace(What:="ı", Replacement:="I", LookAt:=Excel.XlLookAt.xlPart, _
            SearchOrder:=Excel.XlSearchOrder.xlByRows, MatchCase:=False, SearchFormat:=False, _
            ReplaceFormat:=False)
        app.DisplayAlerts = True
    End Sub
    Sub Secilenlerin_tumharfini_kucukyap()
        Dim aktif As Excel.Range
        Dim kucuk As String

        aktif = CType(app.Selection, Excel.Range)

        For Each s As Excel.Range In aktif
            kucuk = StrConv(CStr(s.Value), vbLowerCase)
            s.Value = kucuk
        Next s

    End Sub
    Sub Secilenlerin_ilkharfini_buyukyap()
        Dim aktif As Excel.Range
        Dim prop As String

        aktif = CType(app.Selection, Excel.Range)

        For Each s As Excel.Range In aktif
            prop = StrConv(CStr(s.Value), vbProperCase)
            s.Value = prop
        Next s

       
    End Sub
End Module
