Imports System.Data.Odbc
Public Class sales
    Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Integer)
    Dim check As String
    Dim net, discount As Integer
    Sub DGVButton()
        DGVDeleteColumnButton.Name = "DGVDeleteColumnButton"
        DGVDeleteColumnButton.HeaderText = ""
        DGVDeleteColumnButton.FlatStyle = FlatStyle.Popup
        DGVDeleteColumnButton.DefaultCellStyle.ForeColor = Color.Red
        DGVDeleteColumnButton.Text = "Delete"
        DGVDeleteColumnButton.Width = 50
        DGVDeleteColumnButton.UseColumnTextForButtonValue = True
        CartDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        CartDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetSalesItemDGVHeader()
        CartDataGridView.Columns(0).HeaderText = "Invoice Number"
        CartDataGridView.Columns(1).HeaderText = "Name"
        CartDataGridView.Columns(2).HeaderText = "Unit"
        CartDataGridView.Columns(3).HeaderText = "Price"
        CartDataGridView.Columns(4).HeaderText = "Discount"
        CartDataGridView.Columns(5).HeaderText = "Net"
        CartDataGridView.Columns(6).HeaderText = "Quantity"
        CartDataGridView.Columns(7).HeaderText = "SubTotal"
        CartDataGridView.Columns(1).Width = 150
    End Sub
    Sub enableInput()
        QtyDetailTextBox.Enabled = True
        SubTotalTextBox.Enabled = True
        AddToCartButton.Enabled = True
    End Sub
    Sub disableInput()
        NameDetailTextBox.Enabled = False
        UnitDetailTextBox.Enabled = False
        PriceDetailTextBox.Enabled = False
        QtyDetailTextBox.Enabled = False
        SubTotalTextBox.Enabled = False
        AddToCartButton.Enabled = False
    End Sub
    Sub clearField()
        QtyDetailTextBox.Text = ""
        SubTotalTextBox.Text = ""
        SubTotalValueLabel.Text = ""
        TotalValueLabel.Text = ""
        DiscountValueLabel.Text = ""
        DiscountTextBox.Text = ""
    End Sub
    Sub calculateTotal(subtotal As String)
        discount = Val(DiscountTextBox.Text)
        SubTotalValueLabel.Text = Format(Val(subtotal), "Rp ###,###,###")
        DiscountValueLabel.Text = Format(Val(DiscountTextBox.Text) / 100 * Val(subtotal), "Rp #,###,###,###")
        If discount >= 0 Then
            net = Val(subtotal) - discount / 100 * Val(subtotal)
        Else
            net = Val(subtotal)
        End If
        TotalValueLabel.Text = Format(net, "Rp #,###,###,###")
    End Sub
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM temp WHERE is_archieve='false'", conn)
        ds = New DataSet
        da.Fill(ds, "temp")
        CartDataGridView.DataSource = ds.Tables("temp")
        conn.Close()
    End Sub
    Sub showDataSQL(sql As String)
        dbconnection()
        da = New OdbcDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "data")
        CartDataGridView.DataSource = ds.Tables("data")
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        enableInput()
        showDataSQL("SELECT temp.invoice_number, item.name, item.unit, temp.price, temp.discount, temp.net,temp.qty, temp.price * temp.qty AS subtotal FROM temp JOIN item on temp.invoice_number=item.id WHERE item.admin_id='" & loginEntitityID & "' AND temp.is_archieve='false'")
        SetSalesItemDGVHeader()
        Timer.Enabled = False
        PaymentButton.Enabled = True
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
        SetSalesItemDGVHeader()
    End Sub

    Private Sub restock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        main.Show()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        showData()
        SetSalesItemDGVHeader()
        disableInput()
        clearField()
        PaymentButton.Enabled = False
    End Sub

    Private Sub QtyDetailTextBox_TextChanged(sender As Object, e As EventArgs) Handles QtyDetailTextBox.TextChanged
        SubTotalTextBox.Text = Val(PriceDetailTextBox.Text) * Val(QtyDetailTextBox.Text)
    End Sub


    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles AddToCartButton.Click
        dbconnection()
        If QtyDetailTextBox.Text = "" And SubTotalTextBox.Text = "" Then
            MessageBox.Show("Please provide the quantity to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearField()
            QtyDetailTextBox.Focus()
            Return
        End If

        calculateTotal(SubTotalTextBox.Text)
        command = "INSERT INTO temp (id,qty,price,invoice_number,discount,net,is_archieve,updated_at) VALUES('0','" & QtyDetailTextBox.Text & "','" & PriceDetailTextBox.Text & "','" & InvoiceItemComboBox.Text & "','" & Val(DiscountTextBox.Text) & "','" & net & "','false','')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        If MessageBox.Show("Item added to Cart", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
        End If
        showDataSQL("SELECT temp.invoice_number, item.name, item.unit, temp.price, temp.discount, temp.net, temp.qty, temp.price * temp.qty AS subtotal FROM temp JOIN item on temp.invoice_number=item.id WHERE item.admin_id='" & loginEntitityID & "' AND temp.is_archieve='false'")
        SetSalesItemDGVHeader()
        conn.Close()
    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged
        calculateTotal(SubTotalTextBox.Text)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        CartDataGridView.Columns.Clear()
        showData()
        SetSalesItemDGVHeader()
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
    Sub addSalesDetail(invoiceNumber As String)
        dbconnection()
        command = "INSERT INTO sales_detail (id,invoice_number,item_id,qty,price) SELECT '0',invoice_number,invoice_number,qty,price FROM temp WHERE invoice_number='" & invoiceNumber & "' AND is_archieve='false' AND updated_at=''"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub PaymentButton_Click(sender As Object, e As EventArgs) Handles PaymentButton.Click
        If MessageBox.Show("Proceed to payment?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'TODO: handle payment form
            payment.Show()

            'Insert sales
            dbconnection()
            command = "INSERT INTO sales (id,invoice_number,date,discount,gross,net,admin_id) SELECT '0',invoice_number,NOW(),discount,price*qty,net,'" & loginEntitityID & "' FROM temp WHERE is_archieve='false'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            conn.Close()

            'Insert sales_detail
            Dim invoiceNumber As String
            For Each row As DataGridViewRow In CartDataGridView.Rows
                invoiceNumber = row.Cells(0).Value
                addSalesDetail(invoiceNumber)
            Next

            ' Calculate total from cart
            dbconnection()
            check = "SELECT SUM(temp.net) AS total FROM temp WHERE is_archieve='false' AND updated_at=''"
            query = New OdbcCommand(check, conn)
            reader = query.ExecuteReader()
            If reader.HasRows Then
                totalPayment = reader.Item("total")
                payment.TotalTextBox.Text = Format(Val(totalPayment), "Rp ###,###,###")
            Else
                MessageBox.Show("Cart is empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            payment.Show()
        End If
    End Sub
End Class