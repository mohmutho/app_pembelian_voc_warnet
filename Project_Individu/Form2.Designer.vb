<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(149, 55)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(266, 22)
        Me.txt_username.TabIndex = 2
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(149, 94)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(266, 22)
        Me.txt_password.TabIndex = 3
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(281, 164)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(95, 36)
        Me.btn_batal.TabIndex = 5
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(108, 164)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(95, 36)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 118)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 230)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_login"
        Me.Text = "Login As Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
