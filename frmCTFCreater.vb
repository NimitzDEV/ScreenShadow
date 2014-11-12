Imports System.Runtime.InteropServices

Module frmCTFCreater
    Public Const GWL_EXSTYLE As Integer = -20
    Public opacityLimiter As Double = 0.85
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function GetWindowLong(ByVal hWnd As IntPtr, _
                                     ByVal nIndex As Integer) As Integer
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function SetWindowLong(ByVal hWnd As IntPtr, _
                                     ByVal nIndex As Integer, _
                                     ByVal dsNewLong As Integer) As Integer
    End Function
    Public Const WS_EX_TRANSPARENT As Integer = &H20

    Public Sub doChange_Opacity()
        frmShadowMain.Opacity = opacityLimiter * (1 - pref_percent / 100)
    End Sub
    Public Sub doChange_BackColor()
        frmShadowMain.BackColor = Color.FromArgb(pref_color)
    End Sub
    Public Sub doChange_Height()
        frmShadowMain.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width, IIf(pref_covertaskbar, Screen.PrimaryScreen.Bounds.Height + Screen.PrimaryScreen.WorkingArea.Height, Screen.PrimaryScreen.WorkingArea.Height))
    End Sub
End Module
