<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categorydetail
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryIDLabel = New System.Windows.Forms.Label()
        Me.CategoryNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(206, 117)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 47
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(93, 117)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 46
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(149, 18)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(42, 20)
        Me.CategoryIDTextBox.TabIndex = 40
        '
        'CategoryIDLabel
        '
        Me.CategoryIDLabel.AutoSize = True
        Me.CategoryIDLabel.Location = New System.Drawing.Point(56, 25)
        Me.CategoryIDLabel.Name = "CategoryIDLabel"
        Me.CategoryIDLabel.Size = New System.Drawing.Size(18, 13)
        Me.CategoryIDLabel.TabIndex = 48
        Me.CategoryIDLabel.Text = "ID"
        '
        'CategoryNameTextBox
        '
        Me.CategoryNameTextBox.Location = New System.Drawing.Point(149, 55)
        Me.CategoryNameTextBox.Name = "CategoryNameTextBox"
        Me.CategoryNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CategoryNameTextBox.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Category Name"
        '
        'categorydetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 183)
        Me.Controls.Add(Me.CategoryNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.Controls.Add(Me.CategoryIDLabel)
        Me.MaximizeBox = False
        Me.Name = "categorydetail"
        Me.Text = "Category Detail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CategoryIDTextBox As TextBox
    Friend WithEvents CategoryIDLabel As Label
    Friend WithEvents CategoryNameTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
