Public Class main
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
        StatusStrip.Text = "Selamat Datang: " & username & ", Level: " & level&
        If level = "cashier" Then
            MennuToolStripMenuItem.Enabled = False
            RestockToolStripMenuItem.Enabled = False
            ReportToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        LoginForm.Show()
        LoginForm.ClearField()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem.Click

    End Sub

    Private Sub RestockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestockToolStripMenuItem.Click

    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        category.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        supplier.Show()
        Me.Hide()
    End Sub
End Class
