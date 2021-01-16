Public Class frmBatchMailFirstForm
    Public devam As Boolean
    Public dosya As String = ""
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.btnExcel.Enabled = False
            Me.btnDevam.Enabled = True
        Else
            Me.btnExcel.Enabled = True
            Me.btnDevam.Enabled = False
        End If
    End Sub
    Private Sub btnDevam_Click(sender As Object, e As EventArgs) Handles btnDevam.Click, btnIptal.Click
        Me.Close()
        If sender Is btnDevam Then
            devam = True
        Else
            devam = False
        End If
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim wb As Excel.Workbook

        wb = app.Workbooks.Add()
        dosya = wb.Name

        app.Range("a1").Select()
        app.ActiveCell.FormulaR1C1 = "To"
        app.Range("B1").Select()
        app.ActiveCell.FormulaR1C1 = "cc"
        app.Range("C1").Select()
        app.ActiveCell.FormulaR1C1 = "bcc"
        app.Range("D1").Select()
        app.ActiveCell.FormulaR1C1 = "şube kodu"
        app.Range("E1").Select()
        app.ActiveCell.FormulaR1C1 = "bölge kodu"
        app.Range("F1").Select()
        CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken1"
        app.Range("G1").Select()
        CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken2"
        app.Range("H1").Select()
        CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken3"
        app.Range("I1").Select()
        CType(app.Selection, Excel.Range).FormulaR1C1 = "Değişken4"
        app.Range("j1").Select()
        CType(app.Selection, Excel.Range).FormulaR1C1 = "Açıklama"
        app.Range("A1:j1").Select()
        With CType(app.Selection, Excel.Range).Interior
            .Pattern = Excel.XlPattern.xlPatternSolid
            .PatternColorIndex = Excel.XlPattern.xlPatternAutomatic
            .Color = 255
            .TintAndShade = 0
            .PatternTintAndShade = 0
        End With
        With CType(app.Selection, Excel.Range).Font
            .ThemeColor = Excel.XlThemeColor.xlThemeColorDark1
            .TintAndShade = 0
        End With
        CType(app.Columns("A:j"), Excel.Range).Select()
        CType(app.Selection, Excel.Range).ColumnWidth = 9.57
        CType(app.Columns("k:k"), Excel.Range).Select()
        app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlToRight)).Select()
        CType(app.Selection, Excel.Range).EntireColumn.Hidden = True
        app.Range("A2").Select()

        MsgBox("Şimdi tabloyu hazırlayın ve tekrar çalıştırın")
        Me.Close()
        devam = False
    End Sub

End Class