Imports System.Data.Odbc

Public Class itemdetail
    Public selectedItemID As String
    Dim selectedCategoryID As String
    Dim adminID As Integer
    Dim dt As New DataTable
    Sub clearField()
        BarcodeTextBox.Text = ""
        NameTextBox.Text = ""
        UnitTextBox.Text = ""
        CategoryComboBox.Text = ""
        PriceTextBox.Text = ""
        StockTextBox.Text = ""
    End Sub
    Sub LoadCategory()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM category", conn)
        da.Fill(dt)
        CategoryComboBox.DataSource = dt
        CategoryComboBox.DisplayMember = "category"
        CategoryComboBox.ValueMember = "name"
        conn.Close()
    End Sub
    Function validateIfExist(setfield As Boolean) As Boolean
        dbconnection()
        command = "SELECT * FROM item WHERE barcode='" & BarcodeTextBox.Text & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        If setfield = True Then
            If reader.HasRows Then
                BarcodeTextBox.Text = reader.Item("barcode")
                NameTextBox.Text = reader.Item("name")
                UnitTextBox.Text = reader.Item("unit")
                category = reader.Item("category")
                PriceTextBox.Text = reader.Item("price")
                StockTextBox.Text = reader.Item("stock")
                Return True
            Else
                Return False
            End If
        End If
        conn.Close()
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim id As String
        'Handle update item detail
        If SaveButton.Text = "Update" Then
            dbconnection()
            command = "SELECT * FROM category WHERE name='" & CategoryComboBox.Text & "'"
            query = New OdbcCommand(command, conn)
            reader = query.ExecuteReader()
            If reader.HasRows Then
                selectedCategoryID = reader.Item("id")
            End If
            conn.Close()

            dbconnection()
            command = "UPDATE item SET barcode='" & BarcodeTextBox.Text & "', name='" & NameTextBox.Text & "',unit='" & UnitTextBox.Text & "',category_id='" & selectedCategoryID & "',price='" & PriceTextBox.Text & "',stock='" & StockTextBox.Text & "',date_input='" & DateInputDateTimePicker.Value & "', updated_at='" & Now & "' WHERE id='" & selectedItemID & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Item information updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                item.showData()
            End If
            conn.Close()
            Return
        End If

        dbconnection()
        command = "SELECT * FROM category WHERE name='" & CategoryComboBox.Text & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        If reader.HasRows Then
            selectedItemID = reader.Item("id")
        Else
        End If
        conn.Close()

        dbconnection()
        command = "SELECT * FROM admin WHERE username='" & username & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        If reader.HasRows Then
            adminID = reader.Item("id")
        Else
        End If
        conn.Close()

        id = generateInvoiceNumber()
        dbconnection()
        command = "INSERT INTO item (id,barcode,name,unit,category_id,price,stock,date_input,updated_at,admin_id) VALUES('" & id & "','" & BarcodeTextBox.Text & "','" & NameTextBox.Text & "','" & UnitTextBox.Text & "','" & selectedItemID & "','" & PriceTextBox.Text & "','" & StockTextBox.Text & "','" & Now & "','" & Now & "','" & adminID & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()

        If MessageBox.Show("Item Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            item.showData()
        End If
        conn.Close()
    End Sub

    Private Sub itemdetail_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        item.Show()
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim exist = validateIfExist(True)
                If exist Then
                    MessageBox.Show("Item based on this barcode already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveButton.Enabled = False
                End If
        End Select
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        clearField()
        Me.Dispose()
        item.Show()
    End Sub

    Private Sub itemdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
    End Sub
End Class