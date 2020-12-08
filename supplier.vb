Imports System.Data.Odbc
Public Class supplier
    Dim selectedSupplierID As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM supplier", conn)
        ds = New DataSet
        da.Fill(ds, "supplier")
        SupplierDataGridView.DataSource = ds.Tables("supplier")
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
        SupplierDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        SupplierDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetDGVHeader()
        SupplierDataGridView.Columns(0).HeaderText = "ID"
        SupplierDataGridView.Columns(1).HeaderText = "Supplier Name"
        SupplierDataGridView.Columns(2).HeaderText = "Address"
        SupplierDataGridView.Columns(3).HeaderText = "Phone"
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete supplier with id '" & param & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dbconnection()
            command = "DELETE FROM supplier WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Supplier Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                showData()
            End If
        End If
        conn.Close()
    End Sub
    Sub UpdateRecord(param As String)
        supplierdetail.Show()
        supplierdetail.Text = "Edit Supplier Information"
        supplierdetail.SaveButton.Text = "Update"

        'Load supplier old data
        dbconnection()
        command = "SELECT * FROM supplier WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                supplierdetail.SupplierIDTextBox.Text = reader.Item("id")
                supplierdetail.NameTextBox.Text = reader.Item("name")
                supplierdetail.AddressTextBox.Text = reader.Item("address")
                supplierdetail.PhoneTextBox.Text = reader.Item("phone")
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
        command = "SELECT * FROM supplier WHERE id LIKE '%' '" & SearchTextBox.Text & "' '%' OR name LIKE '%' '" & SearchTextBox.Text & "' '%'"
        da = New OdbcDataAdapter(command, conn)
        ds = New DataSet
        da.Fill(ds, "supplier")
        SupplierDataGridView.DataSource = ds.Tables("supplier")
        If SupplierDataGridView.RowCount > 0 Then
            Dim row As Integer
            With SupplierDataGridView
                row = .CurrentRow.Index
                selectedSupplierID = .Item(0, row).Value
            End With
        End If
        conn.Close()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        DGVButton()
        SetDGVHeader()
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
        SupplierDataGridView.Columns.Clear()
        showData()
        SetDGVHeader()
        DGVButton()
    End Sub

    Private Sub AddCategoryButton_Click(sender As Object, e As EventArgs) Handles AddSupplierButton.Click
        supplierdetail.Show()
        Me.Hide()
    End Sub

    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDataGridView.CellClick
        If SupplierDataGridView.RowCount > 0 Then
            Dim row As Integer
            With SupplierDataGridView
                row = .CurrentRow.Index
                selectedSupplierID = .Item(0, row).Value

                If e.ColumnIndex = 4 Then
                    DeleteRecord(selectedSupplierID)
                ElseIf e.ColumnIndex = 5 Then
                    UpdateRecord(selectedSupplierID)
                End If
            End With
        End If
    End Sub
End Class