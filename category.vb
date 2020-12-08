Imports System.Data.Odbc
Public Class category
    Dim selectedCategoryID, level As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM category", conn)
        ds = New DataSet
        da.Fill(ds, "category")
        CategoryDataGridView.DataSource = ds.Tables("category")
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
        CategoryDataGridView.Columns.Add(DGVDeleteColumnButton)

        DGVEditColumnButton.Name = "DGVEditColumnButton"
        DGVEditColumnButton.HeaderText = ""
        DGVEditColumnButton.FlatStyle = FlatStyle.Popup
        DGVEditColumnButton.DefaultCellStyle.ForeColor = Color.DarkGreen
        DGVEditColumnButton.Text = "Edit"
        DGVEditColumnButton.Width = 50
        DGVEditColumnButton.UseColumnTextForButtonValue = True
        CategoryDataGridView.Columns.Add(DGVEditColumnButton)
    End Sub
    Sub SetDGVHeader()
        CategoryDataGridView.Columns(0).HeaderText = "ID"
        CategoryDataGridView.Columns(1).HeaderText = "Category Name"
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete category with id '" & param & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dbconnection()
            command = "DELETE FROM category WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Category Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                showData()
            End If
        End If
        conn.Close()
    End Sub
    Sub UpdateRecord(param As String)
        categorydetail.Show()
        categorydetail.Text = "Edit Category Information"
        categorydetail.SaveButton.Text = "Update"
        categorydetail.CategoryIDTextBox.Enabled = False

        'Load category old data
        dbconnection()
        command = "SELECT * FROM category WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                categorydetail.CategoryIDTextBox.Text = reader.Item("id")
                categorydetail.CategoryNameTextBox.Text = reader.Item("name")
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
        command = "SELECT * FROM category WHERE id LIKE '%' '" & SearchTextBox.Text & "' '%' OR name LIKE '%' '" & SearchTextBox.Text & "' '%'"
        da = New OdbcDataAdapter(command, conn)
        ds = New DataSet
        da.Fill(ds, "category")
        CategoryDataGridView.DataSource = ds.Tables("category")
        If CategoryDataGridView.RowCount > 0 Then
            Dim row As Integer
            With CategoryDataGridView
                row = .CurrentRow.Index
                selectedCategoryID = .Item(0, row).Value
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
        CategoryDataGridView.Columns.Clear()
        showData()
        SetDGVHeader()
        DGVButton()
    End Sub

    Private Sub AddCategoryButton_Click(sender As Object, e As EventArgs) Handles AddCategoryButton.Click
        categorydetail.Show()
        Me.Hide()
    End Sub

    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellClick
        If CategoryDataGridView.RowCount > 0 Then
            Dim row As Integer
            With CategoryDataGridView
                row = .CurrentRow.Index
                selectedCategoryID = .Item(0, row).Value

                If e.ColumnIndex = 2 Then
                    DeleteRecord(selectedCategoryID)
                ElseIf e.ColumnIndex = 3 Then
                    UpdateRecord(selectedCategoryID)
                End If
            End With
        End If
    End Sub
End Class