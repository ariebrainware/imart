Imports System.Data.Odbc
Public Class Settings
    Dim clicked As Boolean = False
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Hide()
        ConfirmPasswordTextBox.Hide()
        ValidatedMark.Hide()

        dbconnection()
        command = "SELECT * FROM admin WHERE username='" & username & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                UsernameTextBox.Text = reader.Item("username")
                CurrentPasswordTextBox.Text = reader.Item("password")
            End If
        End While
        conn.Close()
    End Sub
    Function DecodePassword(pass As String)

    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ShowPasswordButton.Click
        If clicked = False Then
            CurrentPasswordTextBox.PasswordChar = ""
            DecodePassword(CurrentPasswordTextBox.Text)
            clicked = True
        Else
            CurrentPasswordTextBox.PasswordChar = "#"
            clicked = False
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If NewPasswordTextBox.Text.Length < 6 Then
            If MessageBox.Show("Use at least 6 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                NewPasswordTextBox.Focus()
            End If
            Return
        End If

        If NewPasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            dbconnection()
            command = "UPDATE admin SET password=SHA2('" & NewPasswordTextBox.Text & "',512) WHERE username='" & UsernameTextBox.Text & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Password updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                CurrentPasswordTextBox.Text = NewPasswordTextBox.Text
                NewPasswordTextBox.Text = ""
                ConfirmPasswordTextBox.Text = ""
                Label3.Hide()
                ConfirmPasswordTextBox.Hide()
                ValidatedMark.Hide()
            End If
            conn.Close()
        End If
    End Sub

    Private Sub NewPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles NewPasswordTextBox.TextChanged


        Label3.Show()
        ConfirmPasswordTextBox.Show()
    End Sub

    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        If ConfirmPasswordTextBox.Text = NewPasswordTextBox.Text Then
            ValidatedMark.Show()
        Else
            ValidatedMark.Hide()
        End If
    End Sub
End Class