﻿Imports System.Runtime.InteropServices

Public Class frmShadowMain
    Private Sub frmShadowMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(pref_color)
        doChange_Height()
        doChange_Opacity()
        doChange_BackColor()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrTopMost.Tick
        Me.TopMost = True
    End Sub
End Class