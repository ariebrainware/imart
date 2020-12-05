<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admindetail
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CashierRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdminRadioButton = New System.Windows.Forms.RadioButton()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValidatedMark = New System.Windows.Forms.PictureBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ValidatedMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(218, 204)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(75, 204)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CashierRadioButton
        '
        Me.CashierRadioButton.AutoSize = True
        Me.CashierRadioButton.Location = New System.Drawing.Point(209, 149)
        Me.CashierRadioButton.Name = "CashierRadioButton"
        Me.CashierRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.CashierRadioButton.TabIndex = 5
        Me.CashierRadioButton.TabStop = True
        Me.CashierRadioButton.Text = "Cashier"
        Me.CashierRadioButton.UseVisualStyleBackColor = True
        '
        'AdminRadioButton
        '
        Me.AdminRadioButton.AutoSize = True
        Me.AdminRadioButton.Location = New System.Drawing.Point(113, 149)
        Me.AdminRadioButton.Name = "AdminRadioButton"
        Me.AdminRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.AdminRadioButton.TabIndex = 4
        Me.AdminRadioButton.TabStop = True
        Me.AdminRadioButton.Text = "Admin"
        Me.AdminRadioButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(114, 74)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 2
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(114, 12)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(21, 81)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 21
        Me.PasswordLabel.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Username"
        '
        'ValidatedMark
        '
        Me.ValidatedMark.Image = Global.iMart.My.Resources.Resources.checklist_24px
        Me.ValidatedMark.Location = New System.Drawing.Point(320, 110)
        Me.ValidatedMark.Name = "ValidatedMark"
        Me.ValidatedMark.Size = New System.Drawing.Size(28, 20)
        Me.ValidatedMark.TabIndex = 37
        Me.ValidatedMark.TabStop = False
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(114, 110)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ConfirmPasswordTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Confirm Password"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(114, 42)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Name"
        '
        'admindetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 277)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ValidatedMark)
        Me.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CashierRadioButton)
        Me.Controls.Add(Me.AdminRadioButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "admindetail"
        Me.Text = "Add Admin"
        CType(Me.ValidatedMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CashierRadioButton As RadioButton
    Friend WithEvents AdminRadioButton As RadioButton
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ValidatedMark As PictureBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label5 As Label
End Class
