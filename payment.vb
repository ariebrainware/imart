Imports System.Data.Odbc
Public Class payment
    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ValueTextBox_TextChanged(sender As Object, e As EventArgs) Handles ValueTextBox.TextChanged
        ChangeTextBox.Text = Format(Val(Val(ValueTextBox.Text) - Val(totalPayment)), "Rp ###,###,###")
    End Sub

    Private Sub CheckoutButton_Click(sender As Object, e As EventArgs) Handles CheckoutButton.Click
        Dim invoiceNumber As String
        For Each row As DataGridViewRow In sales.CartDataGridView.Rows
            invoiceNumber = row.Cells(0).Value
            updateItemStock(invoiceNumber)
        Next

        'Set temp as archieve record instead delete it
        dbconnection()
        command = "UPDATE temp SET is_archieve='true', updated_at=NOW() WHERE updated_at=''"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        conn.Close()
        sales.showData()

        If MessageBox.Show("Item Checkout Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            sales.clearField()
        End If
    End Sub

    Sub updateItemStock(invoiceNumber As String)
        'Set item.stock - temp.qty
        dbconnection()
        command = "UPDATE item SET stock=stock-(SELECT qty FROM temp WHERE temp.is_archieve='false' AND invoice_number='" & invoiceNumber & "' AND updated_at=''), updated_at=NOW() WHERE id='" & invoiceNumber & "'"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub payment_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sales.Show()
        Me.Dispose()
    End Sub
End Class