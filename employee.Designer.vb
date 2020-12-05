<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
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
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(12, 39)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(832, 399)
        Me.EmployeeDataGridView.TabIndex = 0
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(130, 12)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(256, 20)
        Me.SearchTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Find by Name/Emp. ID"
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Location = New System.Drawing.Point(392, 10)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(86, 23)
        Me.AddEmployeeButton.TabIndex = 3
        Me.AddEmployeeButton.Text = "Add Employee"
        Me.AddEmployeeButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(484, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 2000
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AddEmployeeButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.MaximizeBox = False
        Me.Name = "employee"
        Me.Text = "Employee"
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeDataGridView As DataGridView
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddEmployeeButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Timer As Timer
End Class
