﻿Public Class main
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.Show()
        LoginForm.ClearField()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        employee.Show()
        Me.Hide()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusStrip.Text = "Selamat Datang: " & username
    End Sub

    Private Sub main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        LoginForm.Show()
        LoginForm.ClearField()
    End Sub
End Class