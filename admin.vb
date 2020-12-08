Imports System.Data.Odbc
Public Class admin
    Dim selectedAdminID, level As String
    Dim DGVResetPasswordColumnButton As New DataGridViewButtonColumn
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM admin", conn)
        ds = New DataSet
        da.Fill(ds, "admin")
        AdminDataGridView.DataSource = ds.Tables("admin")
        conn.Close()
    End Sub
    Sub DGVButton()
        DGVDeleteColumnButton.Name = "DGVDeleteColumnButton"
        DGVDeleteColumnButton.HeaderText = ""
        DGVDeleteColumnButton.FlatStyle = FlatStyle.Popup
        DGVDeleteColumnButton.DefaultCellStyle.ForeColor = Color.Red
        DGVDeleteColumnButton.Text = "Delete"
        DGVDeleteColumnButton.Width = 50
        DGVDeleteColumnButton.UseColumnTextForButtonValue = True
        AdminDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        AdminDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetDGVHeader()
        AdminDataGridView.Columns(0).HeaderText = "ID"
        AdminDataGridView.Columns(1).HeaderText = "Name"
        AdminDataGridView.Columns(2).HeaderText = "Username"
        AdminDataGridView.Columns(3).HeaderText = "Password"
        AdminDataGridView.Columns(4).HeaderText = "Level"
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete admin with username '" & param & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dbconnection()
            command = "DELETE FROM admin WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Admin Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                showData()
            End If
        End If
        conn.Close()
    End Sub
    Sub UpdateRecord(param As String)
        admindetail.Show()
        admindetail.Text = "Edit Admin Information"
        admindetail.SaveButton.Text = "Update"
        admindetail.PasswordLabel.Text = "New Password"
        admindetail.UsernameTextBox.Enabled = False

        'Load employee old data
        dbconnection()
        command = "SELECT * FROM admin WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                admindetail.NameTextBox.Text = reader.Item("name")
                admindetail.UsernameTextBox.Text = reader.Item("username")
                admindetail.PasswordTextBox.Text = reader.Item("password")
                level = reader.Item("level")
                If level = "cashier" Then
                    admindetail.CashierRadioButton.Checked = True
                Else
                    admindetail.AdminRadioButton.Checked = True
                End If
            End If
        End While
        conn.Close()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text = "" Then
            Timer.Enabled = True
        Else
            Timer.Enabled = False
        End If

        dbconnection()
        command = "SELECT * FROM admin WHERE name LIKE '%' '" & SearchTextBox.Text & "' '%' OR username LIKE '%' '" & SearchTextBox.Text & "' '%' OR id LIKE '%' '" & SearchTextBox.Text & "'"
        da = New OdbcDataAdapter(command, conn)
        ds = New DataSet
        da.Fill(ds, "admin")
        AdminDataGridView.DataSource = ds.Tables("admin")
        If AdminDataGridView.RowCount > 0 Then
            Dim row As Integer
            With AdminDataGridView
                row = .CurrentRow.Index
                selectedAdminID = .Item(0, row).Value
            End With
        End If
        conn.Close()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        DGVButton()
        SetDGVHeader()
    End Sub

    Private Sub AddAdminButton_Click(sender As Object, e As EventArgs) Handles AddAdminButton.Click
        admindetail.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        main.Show()
        Me.Dispose()
    End Sub

    Private Sub admin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        main.Show()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        AdminDataGridView.Columns.Clear()
        showData()
        SetDGVHeader()
        DGVButton()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub AdminDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminDataGridView.CellClick
        If AdminDataGridView.RowCount > 0 Then
            Dim row As Integer
            With AdminDataGridView
                row = .CurrentRow.Index
                selectedAdminID = .Item(0, row).Value

                If e.ColumnIndex = 6 Then
                    DeleteRecord(selectedAdminID)
                ElseIf e.ColumnIndex = 7 Then
                    UpdateRecord(selectedAdminID)
                End If
            End With
        End If
    End Sub
End Class