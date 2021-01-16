Module dortislem
    Sub dort_islem_yap(ttr As Double, isl As String)


        Dim secim As Excel.Range = app.Selection
        Dim ilkdeger As Object = secim.Value2
        Try
            For Each h As Excel.Range In app.Selection
                Select Case isl
                    Case "*"
                        If IsNumeric(h.Value) Then h.Value2 = Val(h.Value2) * ttr 'h.value2yi val ile sayıya çevircez çünkü value2 obje döndürüyor
                        h.NumberFormat = "#,##0" 'böglesel ayarlara göre değişir mi
                    Case "/"
                        If IsNumeric(h.Value) Then h.Value2 = Val(h.Value2) / ttr 'h.value2yi val ile sayıya çevircez çünkü value2 obje döndürüyor
                    Case "+"
                        If IsNumeric(h.Value) Then h.Value2 = Val(h.Value2) + ttr 'h.value2yi val ile sayıya çevircez çünkü value2 obje döndürüyor
                    Case Else ' yani "-"
                        If IsNumeric(h.Value) Then h.Value2 = Val(h.Value2) - ttr 'h.value2yi val ile sayıya çevircez çünkü value2 obje döndürüyor
                End Select
            Next h

            If MsgBox("İstenmeyen bir sonuç olduysa undo yapılsın mı?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                secim.Value2 = ilkdeger
            End If
        Catch e As Exception
            If Not IsNumeric(ttr) Then
                MsgBox("Tutar olarak sayısal bir değer girin lütfen")
            Else
                MsgBox(e.Message)
            End If

        End Try

    End Sub
End Module
