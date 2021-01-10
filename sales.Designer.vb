<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DiscountValueLabel = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SubTotalValueLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.CurrentStockTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.InvoiceItemComboBox = New System.Windows.Forms.ComboBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.QtyDetailTextBox = New System.Windows.Forms.TextBox()
        Me.PriceDetailTextBox = New System.Windows.Forms.TextBox()
        Me.UnitDetailTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AddToCartButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalValueLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NameDetailTextBox = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CartDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox3.Controls.Add(Me.PaymentButton)
        Me.GroupBox3.Controls.Add(Me.NewButton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 557)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(981, 74)
        Me.GroupBox3.TabIndex = 51
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
        'PaymentButton
        '
        Me.PaymentButton.Enabled = False
        Me.PaymentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentButton.Location = New System.Drawing.Point(114, 19)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(101, 37)
        Me.PaymentButton.TabIndex = 29
        Me.PaymentButton.Text = "Payment"
        Me.PaymentButton.UseVisualStyleBackColor = True
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
        Me.SubTotalTextBox.Location = New System.Drawing.Point(797, 31)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(166, 20)
        Me.SubTotalTextBox.TabIndex = 38
        '
        'QtyDetailTextBox
        '
        Me.QtyDetailTextBox.Enabled = False
        Me.QtyDetailTextBox.Location = New System.Drawing.Point(740, 31)
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
        Me.Label11.Location = New System.Drawing.Point(739, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Qty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(794, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Sub Total"
        '
        'AddToCartButton
        '
        Me.AddToCartButton.Enabled = False
        Me.AddToCartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddToCartButton.Location = New System.Drawing.Point(434, 74)
        Me.AddToCartButton.Name = "AddToCartButton"
        Me.AddToCartButton.Size = New System.Drawing.Size(100, 31)
        Me.AddToCartButton.TabIndex = 28
        Me.AddToCartButton.Text = "Add to Cart"
        Me.AddToCartButton.UseVisualStyleBackColor = True
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(639, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 31)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Total"
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
        'TotalValueLabel
        '
        Me.TotalValueLabel.AutoSize = True
        Me.TotalValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalValueLabel.Location = New System.Drawing.Point(720, 9)
        Me.TotalValueLabel.Name = "TotalValueLabel"
        Me.TotalValueLabel.Size = New System.Drawing.Size(0, 31)
        Me.TotalValueLabel.TabIndex = 54
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
        Me.GroupBox1.Controls.Add(Me.AddToCartButton)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 111)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'NameDetailTextBox
        '
        Me.NameDetailTextBox.Enabled = False
        Me.NameDetailTextBox.Location = New System.Drawing.Point(201, 32)
        Me.NameDetailTextBox.Name = "NameDetailTextBox"
        Me.NameDetailTextBox.Size = New System.Drawing.Size(268, 20)
        Me.NameDetailTextBox.TabIndex = 34
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-190, -47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Find by Name/Item ID"
        '
        'CartDataGridView
        '
        Me.CartDataGridView.AllowUserToAddRows = False
        Me.CartDataGridView.AllowUserToDeleteRows = False
        Me.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartDataGridView.Location = New System.Drawing.Point(12, 174)
        Me.CartDataGridView.Name = "CartDataGridView"
        Me.CartDataGridView.ReadOnly = True
        Me.CartDataGridView.Size = New System.Drawing.Size(981, 377)
        Me.CartDataGridView.TabIndex = 48
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 643)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TotalValueLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CartDataGridView)
        Me.Name = "sales"
        Me.Text = "Sales"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents DiscountValueLabel As Label
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents SubTotalValueLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PaymentButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents CurrentStockTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents InvoiceItemComboBox As ComboBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents QtyDetailTextBox As TextBox
    Friend WithEvents PriceDetailTextBox As TextBox
    Friend WithEvents UnitDetailTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AddToCartButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TotalValueLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents CartDataGridView As DataGridView
    Friend WithEvents NameDetailTextBox As TextBox
End Class
