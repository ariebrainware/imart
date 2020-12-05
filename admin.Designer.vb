<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.AddAdminButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(501, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 9
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AddAdminButton
        '
        Me.AddAdminButton.Location = New System.Drawing.Point(409, 10)
        Me.AddAdminButton.Name = "AddAdminButton"
        Me.AddAdminButton.Size = New System.Drawing.Size(86, 23)
        Me.AddAdminButton.TabIndex = 8
        Me.AddAdminButton.Text = "Add Admin"
        Me.AddAdminButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Find by Username/Adm. ID"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(147, 12)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(256, 20)
        Me.SearchTextBox.TabIndex = 6
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.AllowUserToAddRows = False
        Me.AdminDataGridView.AllowUserToDeleteRows = False
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGridView.Location = New System.Drawing.Point(9, 39)
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.ReadOnly = True
        Me.AdminDataGridView.Size = New System.Drawing.Size(776, 399)
        Me.AdminDataGridView.TabIndex = 5
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 2000
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AddAdminButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.AdminDataGridView)
        Me.MaximizeBox = False
        Me.Name = "admin"
        Me.Text = "Admin"
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents AddAdminButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents AdminDataGridView As DataGridView
    Friend WithEvents Timer As Timer
End Class
