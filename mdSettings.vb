Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdSettings
    Public pref_percent As Integer = 50
    Public pref_color As Integer = Color.Black.ToArgb
    Public pref_covertaskbar As Boolean = False
    Public pref_enhance As Boolean = False
    Public folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\屏幕遮罩\"
    '====
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), folderPath & "\config.ini")
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, folderPath & "\config.ini")
    End Function
    Public Sub ReadSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        If FileExists(folderPath & "config.ini") = False Then Exit Sub
        pref_percent = GetINI("pref", "tp", pref_percent)
        pref_color = GetINI("pref", "color", pref_color)
        pref_covertaskbar = GetINI("pref", "ctb", pref_covertaskbar)
        pref_enhance = GetINI("pref", "enh", pref_enhance)
    End Sub
    Public Sub SaveSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        WriteINI("pref", "tp", pref_percent)
        WriteINI("pref", "color", pref_color)
        WriteINI("pref", "ctb", pref_covertaskbar)
        WriteINI("pref", "enh", pref_enhance)
    End Sub
End Module

