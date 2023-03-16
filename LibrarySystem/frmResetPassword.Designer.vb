<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPassword
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
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnResetPassword
        '
        Me.btnResetPassword.BackColor = System.Drawing.Color.Cyan
        Me.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.Location = New System.Drawing.Point(49, 173)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(193, 40)
        Me.btnResetPassword.TabIndex = 19
        Me.btnResetPassword.Text = "&Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(52, 99)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(190, 24)
        Me.txtConfirmPassword.TabIndex = 17
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(52, 46)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(190, 24)
        Me.txtNewPassword.TabIndex = 15
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.lblConfirmPassword.Location = New System.Drawing.Point(49, 75)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(132, 19)
        Me.lblConfirmPassword.TabIndex = 16
        Me.lblConfirmPassword.Text = "&Confirm Password"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblNewPassword.Location = New System.Drawing.Point(49, 22)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(109, 19)
        Me.lblNewPassword.TabIndex = 14
        Me.lblNewPassword.Text = "&New Password"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.White
        Me.chkShowPassword.Location = New System.Drawing.Point(125, 133)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(123, 22)
        Me.chkShowPassword.TabIndex = 18
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'frmResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(292, 238)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Name = "frmResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnResetPassword As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents chkShowPassword As CheckBox
End Class
