Imports System.Data.Odbc
Public Class supplierdetail
    Sub clearField()
        NameTextBox.Text=""
        AddressTextBox.Text = ""
        PhoneTextBox.Text = ""
        SupplierIDTextBox.Hide()
        SupplierIDLabel.Hide()
    End Sub
    Private Sub categorydetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearField()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Handle update supplier detail
        If SaveButton.Text = "Update" Then
            dbconnection()
            command = "UPDATE supplier SET name='" & NameTextBox.Text & "',address='" & AddressTextBox.Text & "',phone='" & PhoneTextBox.Text & "' WHERE id='" & SupplierIDTextBox.Text & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Supplier information updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                supplier.showData()
            End If
            conn.Close()
            Return
        End If

        dbconnection()
        command = "INSERT INTO supplier (id,name,address,phone) VALUES(0,'" & NameTextBox.Text & "','" & AddressTextBox.Text & "','" & PhoneTextBox.Text & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()

        If MessageBox.Show("Supplier Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            supplier.showData()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        clearField()
        Me.Dispose()
        supplier.Show()
    End Sub

    Private Sub supplierdetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        supplier.Show()
    End Sub
End Class