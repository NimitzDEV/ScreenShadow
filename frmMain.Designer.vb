<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTrans = New System.Windows.Forms.TrackBar()
        Me.pbColor = New System.Windows.Forms.PictureBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCover = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cdBG = New System.Windows.Forms.ColorDialog()
        Me.mdNI = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsRight = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.显示隐藏界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.llbOfficialSite = New System.Windows.Forms.LinkLabel()
        Me.llbAbout = New System.Windows.Forms.LinkLabel()
        Me.cbEnhance = New System.Windows.Forms.CheckBox()
        CType(Me.tbTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.cmsRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(179, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "开启"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Enabled = False
        Me.btnHide.Location = New System.Drawing.Point(254, 4)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 1
        Me.btnHide.Text = "关闭"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "背景颜色调节"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "请先将屏幕亮度降到最低~"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "亮度调节"
        '
        'tbTrans
        '
        Me.tbTrans.Location = New System.Drawing.Point(98, 41)
        Me.tbTrans.Maximum = 100
        Me.tbTrans.Name = "tbTrans"
        Me.tbTrans.Size = New System.Drawing.Size(200, 45)
        Me.tbTrans.TabIndex = 6
        Me.tbTrans.Value = 50
        '
        'pbColor
        '
        Me.pbColor.BackColor = System.Drawing.Color.Black
        Me.pbColor.Location = New System.Drawing.Point(34, 41)
        Me.pbColor.Name = "pbColor"
        Me.pbColor.Size = New System.Drawing.Size(24, 24)
        Me.pbColor.TabIndex = 7
        Me.pbColor.TabStop = False
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(8, 71)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 8
        Me.btnChange.Text = "更改"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEnhance)
        Me.GroupBox1.Controls.Add(Me.cbCover)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnChange)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pbColor)
        Me.GroupBox1.Controls.Add(Me.tbTrans)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(14, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 125)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "外观选项"
        '
        'cbCover
        '
        Me.cbCover.AutoSize = True
        Me.cbCover.Location = New System.Drawing.Point(220, 103)
        Me.cbCover.Name = "cbCover"
        Me.cbCover.Size = New System.Drawing.Size(84, 16)
        Me.cbCover.TabIndex = 10
        Me.cbCover.Text = "覆盖状态栏"
        Me.cbCover.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "黑色的背景色才能起到亮度调节的效果"
        '
        'mdNI
        '
        Me.mdNI.Text = "屏幕遮罩"
        Me.mdNI.Visible = True
        '
        'cmsRight
        '
        Me.cmsRight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit, Me.ToolStripMenuItem1, Me.显示隐藏界面ToolStripMenuItem})
        Me.cmsRight.Name = "cmsRight"
        Me.cmsRight.Size = New System.Drawing.Size(154, 54)
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(153, 22)
        Me.tsmiExit.Text = "完全退出"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 6)
        '
        '显示隐藏界面ToolStripMenuItem
        '
        Me.显示隐藏界面ToolStripMenuItem.Name = "显示隐藏界面ToolStripMenuItem"
        Me.显示隐藏界面ToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.显示隐藏界面ToolStripMenuItem.Text = "显示/隐藏界面"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(14, 167)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "查找新版本"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'llbOfficialSite
        '
        Me.llbOfficialSite.AutoSize = True
        Me.llbOfficialSite.Location = New System.Drawing.Point(276, 172)
        Me.llbOfficialSite.Name = "llbOfficialSite"
        Me.llbOfficialSite.Size = New System.Drawing.Size(53, 12)
        Me.llbOfficialSite.TabIndex = 11
        Me.llbOfficialSite.TabStop = True
        Me.llbOfficialSite.Text = "访问官网"
        '
        'llbAbout
        '
        Me.llbAbout.AutoSize = True
        Me.llbAbout.Location = New System.Drawing.Point(241, 172)
        Me.llbAbout.Name = "llbAbout"
        Me.llbAbout.Size = New System.Drawing.Size(29, 12)
        Me.llbAbout.TabIndex = 12
        Me.llbAbout.TabStop = True
        Me.llbAbout.Text = "关于"
        '
        'cbEnhance
        '
        Me.cbEnhance.AutoSize = True
        Me.cbEnhance.Location = New System.Drawing.Point(142, 103)
        Me.cbEnhance.Name = "cbEnhance"
        Me.cbEnhance.Size = New System.Drawing.Size(72, 16)
        Me.cbEnhance.TabIndex = 13
        Me.cbEnhance.Text = "增强模式"
        Me.cbEnhance.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 197)
        Me.Controls.Add(Me.llbAbout)
        Me.Controls.Add(Me.llbOfficialSite)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "c"
        CType(Me.tbTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cmsRight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbTrans As System.Windows.Forms.TrackBar
    Friend WithEvents pbColor As System.Windows.Forms.PictureBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cdBG As System.Windows.Forms.ColorDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mdNI As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsRight As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents llbOfficialSite As System.Windows.Forms.LinkLabel
    Friend WithEvents llbAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents cbCover As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 显示隐藏界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbEnhance As System.Windows.Forms.CheckBox

End Class
