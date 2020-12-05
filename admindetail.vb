Imports System.Data.Odbc
Public Class admindetail
    Dim level As String
    Sub clearField()
        NameTextBox.Text = ""
        UsernameTextBox.Text = ""
        AdminRadioButton.Checked = True
        PasswordTextBox.Text = ""
        ConfirmPasswordTextBox.Text = ""
        ValidatedMark.Hide()
    End Sub
    Function validateIfExist(setfield As Boolean) As Boolean
        dbconnection()
        command = "SELECT * FROM admin WHERE username='" & UsernameTextBox.Text & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        If setfield = True Then
            If reader.HasRows Then
                UsernameTextBox.Text = reader.Item("username")
                level = reader.Item("level")
                If level = "cashier" Then
                    CashierRadioButton.Checked = True
                Else
                    AdminRadioButton.Checked = True
                End If
                PasswordTextBox.Text = reader.Item("password")
                PasswordTextBox.PasswordChar = "#"
                Return True
            Else
                Return False
            End If
        End If
        conn.Close()
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Handle update admin detail
        If SaveButton.Text = "Update" Then
            dbconnection()
            If CashierRadioButton.Checked = True Then
                level = "cashier"
            Else
                level = "admin"
            End If
            command = "UPDATE admin SET name='" & NameTextBox.Text & "', 
level='" & level & "',password=SHA2('" & PasswordTextBox.Text & "',512) WHERE is_active='true' AND username='" & UsernameTextBox.Text & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Admin information updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                admin.showData()
            End If
            conn.Close()
            Return
        End If

        dbconnection()
        If CashierRadioButton.Checked = True Then
            level = "cashier"
        Else
            level = "admin"
        End If

        command = "INSERT INTO admin (id,name,username,password,level) VALUES(0,'" & NameTextBox.Text & "','" & UsernameTextBox.Text & "',SHA2('" & PasswordTextBox.Text & "',512),'" & level & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()

        If MessageBox.Show("Admin Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            admin.showData()
        End If
    End Sub

    Private Sub addadmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        admin.Show()
    End Sub

    Private Sub UsernameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim exist = validateIfExist(True)
                If exist Then
                    MessageBox.Show("Admin based on this admin id already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveButton.Enabled = False
                End If
        End Select
    End Sub
    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        If ConfirmPasswordTextBox.Text = PasswordTextBox.Text Then
            ValidatedMark.Show()
        Else
            ValidatedMark.Hide()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        clearField()
        Me.Dispose()
        admin.Show()
    End Sub

    Private Sub addadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearField()
    End Sub
End Class