Imports System.Data.Odbc
Public Class LoginForm
    Dim check, conf As String
    Function ClearField()
        UsernameTextBox.Text = ""
        UsernameTextBox.Focus()
        PasswordTextBox.Text = ""
    End Function
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        dbconnection()
        ' Set encryption configuration
        check = "SELECT * FROM admin WHERE username='" & UsernameTextBox.Text & "' AND password=SHA2('" & PasswordTextBox.Text & "',512) AND is_active='true';"
        'check = "SELECT * FROM admin WHERE username='" & UsernameTextBox.Text & "' AND password='" & PasswordTextBox.Text & "'"
        query = New OdbcCommand(check, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                username = UsernameTextBox.Text
                level = reader.Item("level")
                If MessageBox.Show("Success Login", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                    main.Show()
                    Me.Hide()
                End If
            End If
            Return
        End While
        MessageBox.Show("Failed Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class
