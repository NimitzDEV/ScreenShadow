
Public Class frmMain
    Public canBeClose As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmShadowMain.Show()
        GroupBox1.Enabled = True
        btnHide.Enabled = True
        btnStart.Enabled = False
        canBeClose = -1
        'Me.TopMost = True
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        Dim initialStyles As Integer = GetWindowLong(frmShadowMain.Handle, GWL_EXSTYLE)
        Dim newStyles As Integer = initialStyles Or WS_EX_TRANSPARENT
        SetWindowLong(frmShadowMain.Handle, GWL_EXSTYLE, newStyles)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        frmShadowMain.Visible = False
        btnHide.Enabled = False
        btnStart.Enabled = True
        GroupBox1.Enabled = False
        canBeClose = 0
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = canBeClose
        Me.Visible = False
        If pref_enhance Then frmShadowMain.tmrTopMost.Enabled = True
        mdNI.BalloonTipText = "单击显示/隐藏主界面" & vbCrLf & "右键可以弹出菜单"
        mdNI.BalloonTipTitle = Me.Text
        mdNI.ShowBalloonTip(5000)
        SaveSettings()
    End Sub
  
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadSettings()
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        pbColor.BackColor = Color.FromArgb(pref_color)
        tbTrans.Value = pref_percent
        mdNI.Icon = Me.Icon
        cbCover.Checked = pref_covertaskbar
        cbEnhance.Checked = pref_enhance
    End Sub

    Private Sub tbTrans_Scroll(sender As Object, e As EventArgs) Handles tbTrans.Scroll
        pref_percent = tbTrans.Value
        doChange_Opacity()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        cdBG.Color = pbColor.BackColor
        'cdBG.SolidColorOnly = True
        Me.TopMost = True
        cdBG.ShowDialog()
        Me.TopMost = False
        pbColor.BackColor = cdBG.Color
        pref_color = pbColor.BackColor.ToArgb
        doChange_BackColor()
    End Sub

    Private Sub mdNI_MouseClick(sender As Object, e As MouseEventArgs) Handles mdNI.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Visible = Not Me.Visible
            If pref_enhance Then
                frmShadowMain.tmrTopMost.Enabled = Not Me.Visible
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            cmsRight.Show(New Point(MousePosition.X - cmsRight.Width / 2, MousePosition.Y), ToolStripDropDownDirection.Default)
        End If
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        canBeClose = 0
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmUpdate.ShowDialog()
        frmUpdate.Dispose()
    End Sub

    Private Sub llbOfficialSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbOfficialSite.LinkClicked
        Process.Start("http://ndev.cu.cc")
    End Sub

    Private Sub llbAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbAbout.LinkClicked
        frmAbout.ShowDialog()
        frmAbout.Dispose()
    End Sub

    Private Sub cbCover_CheckedChanged(sender As Object, e As EventArgs) Handles cbCover.CheckedChanged
        pref_covertaskbar = cbCover.Checked
        doChange_Height()
    End Sub

    Private Sub 显示隐藏界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示隐藏界面ToolStripMenuItem.Click
        Me.Visible = Not Me.Visible
        If pref_enhance Then
            frmShadowMain.tmrTopMost.Enabled = Not Me.Visible
        End If
    End Sub

    Private Sub cbEnhance_Click(sender As Object, e As EventArgs) Handles cbEnhance.Click
        If cbEnhance.Checked = True Then
            MsgBox("增强模式已开启，关闭本窗口将开始生效。本窗口打开时将临时失效。", MsgBoxStyle.OkOnly, "使用提示")
            'cbEnhance.Checked = False
            pref_enhance = True
            Exit Sub
        Else
            'cbEnhance.Checked = True
            pref_enhance = False
        End If
    End Sub
End Class
