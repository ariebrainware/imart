<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.ShowPasswordButton = New System.Windows.Forms.PictureBox()
        Me.CurrentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ValidatedMark = New System.Windows.Forms.PictureBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.ShowPasswordButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidatedMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowPasswordButton
        '
        Me.ShowPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPasswordButton.Image = Global.iMart.My.Resources.Resources.show_password24px
        Me.ShowPasswordButton.Location = New System.Drawing.Point(266, 70)
        Me.ShowPasswordButton.Name = "ShowPasswordButton"
        Me.ShowPasswordButton.Size = New System.Drawing.Size(24, 24)
        Me.ShowPasswordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ShowPasswordButton.TabIndex = 24
        Me.ShowPasswordButton.TabStop = False
        Me.ShowPasswordButton.Visible = False
        '
        'CurrentPasswordTextBox
        '
        Me.CurrentPasswordTextBox.Enabled = False
        Me.CurrentPasswordTextBox.Location = New System.Drawing.Point(105, 74)
        Me.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox"
        Me.CurrentPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.CurrentPasswordTextBox.ReadOnly = True
        Me.CurrentPasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CurrentPasswordTextBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Current Password"
        '
        'ValidatedMark
        '
        Me.ValidatedMark.Image = Global.iMart.My.Resources.Resources.checklist_24px
        Me.ValidatedMark.Location = New System.Drawing.Point(266, 167)
        Me.ValidatedMark.Name = "ValidatedMark"
        Me.ValidatedMark.Size = New System.Drawing.Size(28, 20)
        Me.ValidatedMark.TabIndex = 22
        Me.ValidatedMark.TabStop = False
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(105, 167)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.ConfirmPasswordTextBox.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Confirm Password"
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(105, 122)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NewPasswordTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "New Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(105, 33)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.UsernameTextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.Location = New System.Drawing.Point(202, 202)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(81, 29)
        Me.CancelButton.TabIndex = 20
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.Location = New System.Drawing.Point(65, 202)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(81, 29)
        Me.UpdateButton.TabIndex = 19
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 265)
        Me.Controls.Add(Me.ShowPasswordButton)
        Me.Controls.Add(Me.CurrentPasswordTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ValidatedMark)
        Me.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.ShowPasswordButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidatedMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowPasswordButton As PictureBox
    Friend WithEvents CurrentPasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ValidatedMark As PictureBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents UpdateButton As Button
End Class
