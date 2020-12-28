Imports System.Data.Odbc
Public Class item
    Dim selectedItemID,selectedCategoryID, level As String
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM item", conn)
        ds = New DataSet
        da.Fill(ds, "item")
        ItemDataGridView.DataSource = ds.Tables("item")
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
        ItemDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        ItemDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetDGVHeader()
        ItemDataGridView.Columns(0).HeaderText = "ID"
        ItemDataGridView.Columns(1).HeaderText = "Barcode"
        ItemDataGridView.Columns(2).HeaderText = "Name"
        ItemDataGridView.Columns(3).HeaderText = "Unit"
        ItemDataGridView.Columns(4).HeaderText = "Category"
        ItemDataGridView.Columns(5).HeaderText = "Price"
        ItemDataGridView.Columns(6).HeaderText = "Stock"
        ItemDataGridView.Columns(7).HeaderText = "Date Input"
        ItemDataGridView.Columns(8).HeaderText = "Updated At"
        ItemDataGridView.Columns(9).HeaderText = "Admin ID"
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete item with ID '" & param & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dbconnection()
            command = "DELETE FROM item WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Item Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                showData()
            End If
        End If
        conn.Close()
    End Sub
    Sub UpdateRecord(param As String)
        Dim command2 As String
        Dim query2 As OdbcCommand
        Dim reader2 As OdbcDataReader

        itemdetail.Show()
        itemdetail.Text = "Edit Item Information"
        itemdetail.SaveButton.Text = "Update"
        itemdetail.selectedItemID = param
        itemdetail.DateInputLabel.Visible = True
        itemdetail.DateInputDateTimePicker.Visible = True

        'Load item old data
        dbconnection()
        command = "SELECT * FROM item WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                itemdetail.BarcodeTextBox.Text = reader.Item("barcode")
                itemdetail.NameTextBox.Text = reader.Item("name")
                itemdetail.UnitTextBox.Text = reader.Item("unit")
                selectedCategoryID = reader.Item("category_id")
                command2 = "SELECT * FROM category WHERE id='" & selectedCategoryID & "'"
                query2 = New OdbcCommand(command2, conn)
                reader2 = query2.ExecuteReader()
                If reader2.HasRows Then
                    itemdetail.CategoryComboBox.Text = reader2.Item("name")
                End If
                itemdetail.PriceTextBox.Text = reader.Item("price")
                itemdetail.StockTextBox.Text = reader.Item("stock")
                itemdetail.DateInputDateTimePicker.Text = reader.Item("date_input")
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
        command = "SELECT * FROM item WHERE id LIKE '%' '" & SearchTextBox.Text & "' '%' OR name LIKE '%' '" & SearchTextBox.Text & "' '%'"
        da = New OdbcDataAdapter(command, conn)
        ds = New DataSet
        da.Fill(ds, "item")
        ItemDataGridView.DataSource = ds.Tables("item")
        If ItemDataGridView.RowCount > 0 Then
            Dim row As Integer
            With ItemDataGridView
                row = .CurrentRow.Index
                selectedItemID = .Item(0, row).Value
            End With
        End If
        conn.Close()
    End Sub

    Private Sub item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        DGVButton()
        SetDGVHeader()
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        itemdetail.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        main.Show()
        Me.Dispose()
    End Sub

    Private Sub item_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        main.Show()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ItemDataGridView.Columns.Clear()
        showData()
        SetDGVHeader()
        DGVButton()
    End Sub
    Private Sub ItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDataGridView.CellClick
        If ItemDataGridView.RowCount > 0 Then
            Dim row As Integer
            With ItemDataGridView
                row = .CurrentRow.Index
                selectedItemID = .Item(0, row).Value

                If e.ColumnIndex = 10 Then
                    DeleteRecord(selectedItemID)
                ElseIf e.ColumnIndex = 11 Then
                    UpdateRecord(selectedItemID)
                End If
            End With
        End If
    End Sub
End Class