<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class item
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.ItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(482, 11)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 14
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AddItemButton
        '
        Me.AddItemButton.Location = New System.Drawing.Point(390, 12)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(86, 23)
        Me.AddItemButton.TabIndex = 13
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Find by Name/Item ID"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(128, 14)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(256, 20)
        Me.SearchTextBox.TabIndex = 11
        '
        'ItemDataGridView
        '
        Me.ItemDataGridView.AllowUserToAddRows = False
        Me.ItemDataGridView.AllowUserToDeleteRows = False
        Me.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDataGridView.Location = New System.Drawing.Point(14, 41)
        Me.ItemDataGridView.Name = "ItemDataGridView"
        Me.ItemDataGridView.ReadOnly = True
        Me.ItemDataGridView.Size = New System.Drawing.Size(1177, 399)
        Me.ItemDataGridView.TabIndex = 10
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 2000
        '
        'item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ItemDataGridView)
        Me.MaximizeBox = False
        Me.Name = "item"
        Me.Text = "Item"
        CType(Me.ItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents AddItemButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ItemDataGridView As DataGridView
    Friend WithEvents Timer As Timer
End Class
