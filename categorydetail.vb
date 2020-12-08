Imports System.Data.Odbc
Public Class categorydetail
    Sub clearField()
        CategoryIDTextBox.Text = ""
        CategoryNameTextBox.Text = ""
        CategoryIDTextBox.Hide()
        CategoryIDLabel.Hide()
    End Sub
    Private Sub categorydetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearField()
    End Sub

    Private Sub CategoryIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryIDTextBox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles CategoryIDLabel.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Handle update category detail
        If SaveButton.Text = "Update" Then
            dbconnection()
            command = "UPDATE category SET name='" & CategoryNameTextBox.Text & "' WHERE id='" & CategoryIDTextBox.Text & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Category information updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                category.showData()
            End If
            conn.Close()
            Return
        End If

        dbconnection()
        command = "INSERT INTO category (id,name) VALUES(0,'" & CategoryNameTextBox.Text & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()

        If MessageBox.Show("Category Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            category.showData()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        clearField()
        Me.Dispose()
        category.Show()
    End Sub
End Class