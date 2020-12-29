Imports System.Data.Odbc
Public Class restock
    Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Integer)
    Dim check As String
    Dim net As Integer
    Sub DGVButton()
        DGVDeleteColumnButton.Name = "DGVDeleteColumnButton"
        DGVDeleteColumnButton.HeaderText = ""
        DGVDeleteColumnButton.FlatStyle = FlatStyle.Popup
        DGVDeleteColumnButton.DefaultCellStyle.ForeColor = Color.Red
        DGVDeleteColumnButton.Text = "Delete"
        DGVDeleteColumnButton.Width = 50
        DGVDeleteColumnButton.UseColumnTextForButtonValue = True
        RestockDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        RestockDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetRestockDGVHeader()
        RestockDataGridView.Columns(0).HeaderText = "Invoice Number"
        RestockDataGridView.Columns(1).HeaderText = "Restock Date"
        RestockDataGridView.Columns(2).HeaderText = "Supplier ID"
        RestockDataGridView.Columns(3).HeaderText = "Discount"
        RestockDataGridView.Columns(4).HeaderText = "Gross"
        RestockDataGridView.Columns(5).HeaderText = "Net"
        RestockDataGridView.Columns(6).HeaderText = "Admin ID"
        RestockDataGridView.Columns(7).HeaderText = "Created At"

        RestockDataGridView.Columns(1).Width = 150
    End Sub
    Sub SetTemporaryItemDGVHeader()
        RestockDataGridView.Columns(0).HeaderText = "Invoice Number"
        RestockDataGridView.Columns(1).HeaderText = "Name"
        RestockDataGridView.Columns(2).HeaderText = "Unit"
        RestockDataGridView.Columns(3).HeaderText = "Price"
        RestockDataGridView.Columns(4).HeaderText = "Discount"
        RestockDataGridView.Columns(5).HeaderText = "Net"
        RestockDataGridView.Columns(6).HeaderText = "Quantity"
        RestockDataGridView.Columns(7).HeaderText = "SubTotal"
    End Sub
    Sub enableInput()
        QtyDetailTextBox.Enabled = True
        SubTotalTextBox.Enabled = True
        OKButton.Enabled = True
    End Sub
    Sub disableInput()
        NameDetailTextBox.Enabled = False
        UnitDetailTextBox.Enabled = False
        PriceDetailTextBox.Enabled = False
        QtyDetailTextBox.Enabled = False
        SubTotalTextBox.Enabled = False
        OKButton.Enabled = False
    End Sub
    Sub clearField()
        PhoneTextBox.Text = ""
        AddressTextBox.Text = ""
        SupplierIDTextBox.Text = ""
        SupplierNameTextBox.Text = ""

        QtyDetailTextBox.Text = ""
        SubTotalTextBox.Text = ""
        SubTotalValueLabel.Text = ""
        TotalValueLabel.Text = ""
        DiscountValueLabel.Text = ""
        DiscountTextBox.Text = ""
    End Sub
    Sub calculateTotal(subtotal As String)
        SubTotalValueLabel.Text = Format(Val(subtotal), "Rp ###,###,###")
        DiscountValueLabel.Text = Format(Val(DiscountTextBox.Text) / 100 * Val(subtotal), "Rp #,###,###,###")
        net = Val(subtotal) - Val(DiscountTextBox.Text) / 100 * Val(subtotal)
        TotalValueLabel.Text = Format(net, "Rp #,###,###,###")
    End Sub
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM restock WHERE admin_id = '" & loginEntitityID & "'", conn)
        ds = New DataSet
        da.Fill(ds, "restock")
        RestockDataGridView.DataSource = ds.Tables("restock")
        conn.Close()
    End Sub
    Sub showDataSQL(sql As String)
        dbconnection()
        da = New OdbcDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "data")
        RestockDataGridView.DataSource = ds.Tables("data")
        conn.Close()
    End Sub
    Sub searchData()
        dbconnection()
        check = "SELECT * FROM supplier WHERE id='" & SupplierIDTextBox.Text & "'"
        query = New OdbcCommand(check, conn)
        reader = query.ExecuteReader()
        If reader.HasRows Then
            PhoneTextBox.Text = reader.Item("phone")
            AddressTextBox.Text = reader.Item("address")
            SupplierNameTextBox.Text = reader.Item("name")
            MessageBox.Show("Supplier found", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Supplier not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
            Return
        End If
        conn.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SupplierIDTextBox.Text = "" Then
            Timer.Enabled = True
        Else
            Timer.Enabled = False
        End If
        searchData()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        enableInput()
        showDataSQL("SELECT temp.invoice_number, item.name, item.unit, temp.price, temp.discount, temp.net,temp.qty, temp.price * temp.qty AS subtotal FROM temp JOIN item on temp.invoice_number=item.id WHERE item.admin_id='" & loginEntitityID & "' AND temp.is_archieve='false'")
        SetTemporaryItemDGVHeader()
        Timer.Enabled = False
        SaveButton.Enabled = True
    End Sub
    Sub loadInvoiceItem()
        Dim dt As New DataTable
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM item", conn)
        da.Fill(dt)
        InvoiceItemComboBox.DataSource = dt
        InvoiceItemComboBox.DisplayMember = "item"
        InvoiceItemComboBox.ValueMember = "id"
        conn.Close()
    End Sub
    Private Sub restock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        loadInvoiceItem()
        'DGVButton()
        SetRestockDGVHeader()
    End Sub

    Private Sub restock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        main.Show()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        showData()
        SetRestockDGVHeader()
        disableInput()
        clearField()
        SaveButton.Enabled = False
    End Sub

    Private Sub QtyDetailTextBox_TextChanged(sender As Object, e As EventArgs) Handles QtyDetailTextBox.TextChanged
        SubTotalTextBox.Text = Val(PriceDetailTextBox.Text) * Val(QtyDetailTextBox.Text)
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        dbconnection()
        command = "INSERT INTO temp (id,qty,price,invoice_number,discount,net,is_archieve,updated_at) VALUES(0,'" & QtyDetailTextBox.Text & "','" & PriceDetailTextBox.Text & "','" & InvoiceItemComboBox.Text & "','" & DiscountTextBox.Text & "','" & net & "','false','')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        If MessageBox.Show("Item added to Temporary Restock", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
        End If
        showDataSQL("SELECT temp.invoice_number, item.name, item.unit, temp.price, temp.discount, temp.net, temp.qty, temp.price * temp.qty AS subtotal FROM temp JOIN item on temp.invoice_number=item.id WHERE item.admin_id='" & loginEntitityID & "' AND temp.is_archieve='false'")
        SetTemporaryItemDGVHeader()
        conn.Close()
    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged
        calculateTotal(SubTotalTextBox.Text)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        RestockDataGridView.Columns.Clear()
        showData()
        SetRestockDGVHeader()
        'DGVButton()
    End Sub

    Private Sub SubTotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles SubTotalTextBox.TextChanged
        SubTotalValueLabel.Text = Format(Val(SubTotalTextBox.Text), "Rp ###,###,###")
    End Sub
    Private Sub InvoiceItemComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles InvoiceItemComboBox.SelectedValueChanged
        dbconnection()
        check = "SELECT * FROM item WHERE id='" & InvoiceItemComboBox.Text & "' AND admin_id ='" & loginEntitityID & "'"
        query = New OdbcCommand(check, conn)
        reader = query.ExecuteReader()
        If reader.HasRows Then
            NameDetailTextBox.Text = reader.Item("name")
            UnitDetailTextBox.Text = reader.Item("unit")
            PriceDetailTextBox.Text = reader.Item("price")
            CurrentStockTextBox.Text = reader.Item("stock")
        End If
        Return
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If MessageBox.Show("Are you sure you want to save?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If SupplierIDTextBox.Text = "" Then
                MessageBox.Show("Please find and provide supplier first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                'Insert restock
                dbconnection()
                command = "INSERT INTO restock (invoice_number,restock_date,supplier_id,discount,gross,net,admin_id,created_at) SELECT invoice_number,NOW(),'" & SupplierIDTextBox.Text & "',discount,price*qty,net,'" & loginEntitityID & "',NOW() FROM temp WHERE is_archieve='false'"
                query = New OdbcCommand(command, conn)
                query.ExecuteNonQuery()
                If MessageBox.Show("Item Restocked", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                    clearField()
                    item.showData()
                End If
                conn.Close()
            End If

            'Insert restock_detail
            dbconnection()
            command = "INSERT INTO restock_detail (id,invoice_number,item_id,qty,price) SELECT '0',invoice_number,invoice_number,qty,price FROM temp"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            conn.Close()

            'Set temp as archieve record instead delete it
            dbconnection()
            command = "UPDATE temp SET is_archieve='true', updated_at=NOW() WHERE updated_at=''"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            showData()
            conn.Close()
        End If
    End Sub
End Class