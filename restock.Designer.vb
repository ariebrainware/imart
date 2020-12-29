<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class restock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RestockDataGridView = New System.Windows.Forms.DataGridView()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CurrentStockTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.InvoiceItemComboBox = New System.Windows.Forms.ComboBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.QtyDetailTextBox = New System.Windows.Forms.TextBox()
        Me.PriceDetailTextBox = New System.Windows.Forms.TextBox()
        Me.UnitDetailTextBox = New System.Windows.Forms.TextBox()
        Me.NameDetailTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DiscountValueLabel = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SubTotalValueLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.TotalValueLabel = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.RestockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(547, 16)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 19
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-190, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Find by Name/Item ID"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Enabled = False
        Me.PhoneTextBox.Location = New System.Drawing.Point(66, 18)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(256, 20)
        Me.PhoneTextBox.TabIndex = 16
        '
        'RestockDataGridView
        '
        Me.RestockDataGridView.AllowUserToAddRows = False
        Me.RestockDataGridView.AllowUserToDeleteRows = False
        Me.RestockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RestockDataGridView.Location = New System.Drawing.Point(12, 242)
        Me.RestockDataGridView.Name = "RestockDataGridView"
        Me.RestockDataGridView.ReadOnly = True
        Me.RestockDataGridView.Size = New System.Drawing.Size(981, 377)
        Me.RestockDataGridView.TabIndex = 15
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 2000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CurrentStockTextBox)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.InvoiceItemComboBox)
        Me.GroupBox1.Controls.Add(Me.SubTotalTextBox)
        Me.GroupBox1.Controls.Add(Me.QtyDetailTextBox)
        Me.GroupBox1.Controls.Add(Me.PriceDetailTextBox)
        Me.GroupBox1.Controls.Add(Me.UnitDetailTextBox)
        Me.GroupBox1.Controls.Add(Me.NameDetailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.OKButton)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 111)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Restock"
        '
        'CurrentStockTextBox
        '
        Me.CurrentStockTextBox.Enabled = False
        Me.CurrentStockTextBox.Location = New System.Drawing.Point(680, 32)
        Me.CurrentStockTextBox.Name = "CurrentStockTextBox"
        Me.CurrentStockTextBox.Size = New System.Drawing.Size(53, 20)
        Me.CurrentStockTextBox.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(679, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Cur Stock"
        '
        'InvoiceItemComboBox
        '
        Me.InvoiceItemComboBox.FormattingEnabled = True
        Me.InvoiceItemComboBox.Location = New System.Drawing.Point(6, 31)
        Me.InvoiceItemComboBox.Name = "InvoiceItemComboBox"
        Me.InvoiceItemComboBox.Size = New System.Drawing.Size(189, 21)
        Me.InvoiceItemComboBox.TabIndex = 45
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Enabled = False
        Me.SubTotalTextBox.Location = New System.Drawing.Point(737, 77)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(166, 20)
        Me.SubTotalTextBox.TabIndex = 38
        '
        'QtyDetailTextBox
        '
        Me.QtyDetailTextBox.Enabled = False
        Me.QtyDetailTextBox.Location = New System.Drawing.Point(680, 77)
        Me.QtyDetailTextBox.Name = "QtyDetailTextBox"
        Me.QtyDetailTextBox.Size = New System.Drawing.Size(53, 20)
        Me.QtyDetailTextBox.TabIndex = 37
        '
        'PriceDetailTextBox
        '
        Me.PriceDetailTextBox.Enabled = False
        Me.PriceDetailTextBox.Location = New System.Drawing.Point(557, 32)
        Me.PriceDetailTextBox.Name = "PriceDetailTextBox"
        Me.PriceDetailTextBox.Size = New System.Drawing.Size(117, 20)
        Me.PriceDetailTextBox.TabIndex = 36
        '
        'UnitDetailTextBox
        '
        Me.UnitDetailTextBox.Enabled = False
        Me.UnitDetailTextBox.Location = New System.Drawing.Point(475, 32)
        Me.UnitDetailTextBox.Name = "UnitDetailTextBox"
        Me.UnitDetailTextBox.Size = New System.Drawing.Size(76, 20)
        Me.UnitDetailTextBox.TabIndex = 35
        '
        'NameDetailTextBox
        '
        Me.NameDetailTextBox.Enabled = False
        Me.NameDetailTextBox.Location = New System.Drawing.Point(201, 32)
        Me.NameDetailTextBox.Name = "NameDetailTextBox"
        Me.NameDetailTextBox.Size = New System.Drawing.Size(268, 20)
        Me.NameDetailTextBox.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(554, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(679, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Qty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(734, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Sub Total"
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.Location = New System.Drawing.Point(909, 66)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(66, 31)
        Me.OKButton.TabIndex = 28
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(472, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Unit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Invoice"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.SupplierNameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.SupplierIDTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox2.Controls.Add(Me.SearchButton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 96)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Enabled = False
        Me.AddressTextBox.Location = New System.Drawing.Point(66, 63)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(256, 20)
        Me.AddressTextBox.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Supplier Name"
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.Enabled = False
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(435, 63)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(186, 20)
        Me.SupplierNameTextBox.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Supplier ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 24
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(435, 19)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(106, 20)
        Me.SupplierIDTextBox.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Phone"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ClearButton)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.DiscountValueLabel)
        Me.GroupBox3.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.SubTotalValueLabel)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.SaveButton)
        Me.GroupBox3.Controls.Add(Me.NewButton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 625)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(981, 74)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(221, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(101, 37)
        Me.ClearButton.TabIndex = 44
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(815, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 18)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "%"
        '
        'DiscountValueLabel
        '
        Me.DiscountValueLabel.AutoSize = True
        Me.DiscountValueLabel.Location = New System.Drawing.Point(847, 44)
        Me.DiscountValueLabel.Name = "DiscountValueLabel"
        Me.DiscountValueLabel.Size = New System.Drawing.Size(0, 13)
        Me.DiscountValueLabel.TabIndex = 42
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(789, 36)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(20, 20)
        Me.DiscountTextBox.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(734, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Discount"
        '
        'SubTotalValueLabel
        '
        Me.SubTotalValueLabel.AutoSize = True
        Me.SubTotalValueLabel.Location = New System.Drawing.Point(847, 16)
        Me.SubTotalValueLabel.Name = "SubTotalValueLabel"
        Me.SubTotalValueLabel.Size = New System.Drawing.Size(0, 13)
        Me.SubTotalValueLabel.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(734, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Sub Total"
        '
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(114, 19)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(101, 37)
        Me.SaveButton.TabIndex = 29
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(11, 19)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(97, 37)
        Me.NewButton.TabIndex = 28
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'TotalValueLabel
        '
        Me.TotalValueLabel.AutoSize = True
        Me.TotalValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalValueLabel.Location = New System.Drawing.Point(751, 72)
        Me.TotalValueLabel.Name = "TotalValueLabel"
        Me.TotalValueLabel.Size = New System.Drawing.Size(0, 31)
        Me.TotalValueLabel.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(670, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 31)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Total"
        '
        'restock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 711)
        Me.Controls.Add(Me.TotalValueLabel)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RestockDataGridView)
        Me.MaximizeBox = False
        Me.Name = "restock"
        Me.Text = "Restock"
        CType(Me.RestockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RestockDataGridView As DataGridView
    Friend WithEvents Timer As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents QtyDetailTextBox As TextBox
    Friend WithEvents PriceDetailTextBox As TextBox
    Friend WithEvents UnitDetailTextBox As TextBox
    Friend WithEvents NameDetailTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents SubTotalValueLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DiscountValueLabel As Label
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents InvoiceItemComboBox As ComboBox
    Friend WithEvents CurrentStockTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TotalValueLabel As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressTextBox As TextBox
End Class
