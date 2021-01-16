'Option Explicit On
'Option Compare Text
'Option Strict Off
''Imports Excel = Microsoft.Office.Interop.Excel
''Imports OFC = Microsoft.Office.Interop
'Imports System
'Imports System.Runtime.InteropServices
'Imports WIN32 = Microsoft.Win32
'<Guid("EB56B059-322B-4216-AB4A-8AE957770951")>
'<ClassInterface(ClassInterfaceType.AutoDual), ComVisible(True)>
'Public Class Fonksiyonlar
'    Public Function superconcatvsto(Hucre_grubu As Excel.Range, isaret As String)
'        '.NETte automation addinlerde description ve category oluyor, uzun b yöntemi var gibi
'        'veya Excel.DNA gibi araçlarda olabiliyor
'        'try cath yap
'        Dim x As String
'        Dim k As Excel.Range
'        x = ""
'        For Each k In Hucre_grubu
'            If CStr(k.Value2) <> "" Then
'                x = x & k.Value & isaret
'            End If
'        Next k

'        superconcatvsto = Mid(x, 1, Len(x) - 1)
'    End Function
'#Region " Setup "
'    Public Sub New()

'    End Sub

'    <ComRegisterFunctionAttribute()>
'    Public Shared Sub RegisterFunction(ByVal type As Type)

'        WIN32.Registry.ClassesRoot.CreateSubKey(GetSubKeyName(type, "Programmable"))

'        Dim key As WIN32.RegistryKey =
'    WIN32.Registry.ClassesRoot.OpenSubKey(GetSubKeyName(type, "InprocServer32"), True)

'        key.SetValue("", System.Environment.SystemDirectory & "\mscoree.dll",
'            WIN32.RegistryValueKind.[String])
'    End Sub

'    <ComUnregisterFunctionAttribute()>
'    Public Shared Sub UnregisterFunction(ByVal type As Type)

'        WIN32.Registry.ClassesRoot.DeleteSubKey(GetSubKeyName(type, "Programmable"), False)

'    End Sub

'    Private Shared Function GetSubKeyName(ByVal type As Type,
'        ByVal subKeyName As String) As String

'        Dim s As New System.Text.StringBuilder()

'        s.Append("CLSID\{")
'        s.Append(type.GUID.ToString().ToUpper())
'        s.Append("}\")
'        s.Append(subKeyName)

'        Return s.ToString()
'    End Function

'#End Region

'End Class
