Imports System.Data.Odbc
Public Class employee
    Dim selectedEmployeeID, gender As String
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM employee", conn)
        ds = New DataSet
        da.Fill(ds, "employee")
        EmployeeDataGridView.DataSource = ds.Tables("employee")
        conn.Close()
    End Sub
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        dbconnection()
        command = "SELECT * FROM employee WHERE name LIKE '%' '" & SearchTextBox.Text & "' '%' OR id LIKE '%' '" & SearchTextBox.Text & "'"
        da = New OdbcDataAdapter(command, conn)
        ds = New DataSet
        da.Fill(ds, "employee")
        EmployeeDataGridView.DataSource = ds.Tables("employee")
        If EmployeeDataGridView.RowCount > 0 Then
            Dim row As Integer
            With EmployeeDataGridView
                row = .CurrentRow.Index
                selectedEmployeeID = .Item(0, row).Value
            End With
        End If
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
        EmployeeDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        EmployeeDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetDGVHeader()
        EmployeeDataGridView.Columns(0).HeaderText = "ID"
        EmployeeDataGridView.Columns(1).HeaderText = "Name"
        EmployeeDataGridView.Columns(2).HeaderText = "Gender"
        EmployeeDataGridView.Columns(3).HeaderText = "Place of Birth"
        EmployeeDataGridView.Columns(4).HeaderText = "Date of Birth"
        EmployeeDataGridView.Columns(5).HeaderText = "Phone"
        EmployeeDataGridView.Columns(6).HeaderText = "Address"
    End Sub
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        DGVButton()
        SetDGVHeader()
    End Sub

    Private Sub AddEmployeeButton_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        employeedetail.Show()
        employeedetail.Text = "Add Employee"
        Me.Hide()
    End Sub

    Private Sub employee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main.Show()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        main.Show()
        Me.Dispose()
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete employee with id '" & param & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dbconnection()
            command = "DELETE FROM employee WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Employee Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                showData()
            End If
        End If
        conn.Close()
    End Sub
    Sub UpdateRecord(param As String)
        employeedetail.Show()
        employeedetail.Text = "Edit Employee Information"
        employeedetail.SaveButton.Text = "Update"
        employeedetail.EmployeeIDTextBox.Enabled = False

        'Load employee old data
        dbconnection()
        command = "SELECT * FROM employee WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                employeedetail.EmployeeIDTextBox.Text = reader.Item("id")
                employeedetail.NameTextBox.Text = reader.Item("name")
                gender = reader.Item("gender")
                If gender = "female" Then
                    employeedetail.FemaleRadioButton.Checked = True
                Else
                    employeedetail.MaleRadioButton.Checked = True
                End If
                employeedetail.PlaceOfBirthTextBox.Text = reader.Item("place_of_birth")
                employeedetail.DateOfBirthDateTimePicker.Value = reader.Item("date_of_birth")
                employeedetail.PhoneTextBox.Text = reader.Item("phone")
                employeedetail.AddressTextBox.Text = reader.Item("address")
            End If
        End While
        conn.Close()
    End Sub
    Private Sub EmployeeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        If EmployeeDataGridView.RowCount > 0 Then
            Dim row As Integer
            With EmployeeDataGridView
                row = .CurrentRow.Index
                selectedEmployeeID = .Item(0, row).Value

                If e.ColumnIndex = 7 Then
                    DeleteRecord(selectedEmployeeID)
                ElseIf e.ColumnIndex = 8 Then
                    UpdateRecord(selectedEmployeeID)
                End If

            End With
        End If
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        EmployeeDataGridView.Columns.Clear()
        showData()
        SetDGVHeader()
        DGVButton()
    End Sub
End Class