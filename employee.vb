Imports System.Data.Odbc
Public Class employee
    Dim selectedEmployeeID As String
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

    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub AddEmployeeButton_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        addemployee.Show()
        Me.Hide()
    End Sub
End Class