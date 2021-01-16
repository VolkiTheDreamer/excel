Module windowsisleri
#Region "File folder"
    Sub FolderdakiDosyalar()

        Dim objFSO As Object
        Dim objFolder As Object
        Dim objFile As Object
        Dim ws As Worksheet

        objFSO = CreateObject("Scripting.FileSystemObject")
        ws = CType(app.Worksheets, Excel.Sheets).Add

        'Get the folder object associated with the directory
        objFolder = objFSO.GetFolder("C:\")
        ws.Cells(1, 1).Value = "The files found in " & objFolder.Name & "are:"

        'Loop through the Files collection
        For Each objFile In objFolder.Files
            ws.Cells(ws.UsedRange.Rows.Count + 1, 1).Value = objFile.Name
        Next

        'Clean up!
        objFolder = Nothing
        objFile = Nothing
        objFSO = Nothing

    End Sub
    Sub FolderdakiFolderlar()
        Dim objFSO As Object
        Dim objFolder As Object
        Dim objSubFolder As Object
        Dim i As Integer

        'Create an instance of the FileSystemObject
        objFSO = CreateObject("Scripting.FileSystemObject")
        'Get the folder object
        objFolder = objFSO.GetFolder("c:\")
        i = 1
        'loops through each file in the directory and prints their names and path
        For Each objSubFolder In objFolder.subfolders
            'print folder name
            CType(app.Cells(i + 1, 1), Excel.Range).Value2 = objSubFolder.Name
            'print folder path
            CType(app.Cells(i + 1, 2), Excel.Range).Value2 = objSubFolder.Path
            i = i + 1
        Next objSubFolder
    End Sub
    Sub klsordeki_dosya_isimleri()
        'test etmedim henüz
        'kalösür inputboxla sorsun
        app.Range("a1").Select()
        For Each dosya In My.Computer.FileSystem.GetFiles("C:\")
            app.Range("a1").Value = dosya
            CType(app.ActiveCell, Excel.Range).Offset(1, 0).Select()
        Next

    End Sub
#End Region
#Region "Diger"
    Sub connection_bilgi()

    End Sub
    Sub ip_adres()

    End Sub
#End Region
End Module
