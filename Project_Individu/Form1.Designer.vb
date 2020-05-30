<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_as
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
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_pembeli = New System.Windows.Forms.Button()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(155, 181)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(103, 35)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "Exit"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_pembeli
        '
        Me.btn_pembeli.Location = New System.Drawing.Point(155, 68)
        Me.btn_pembeli.Name = "btn_pembeli"
        Me.btn_pembeli.Size = New System.Drawing.Size(103, 35)
        Me.btn_pembeli.TabIndex = 1
        Me.btn_pembeli.Text = "Pembeli"
        Me.btn_pembeli.UseVisualStyleBackColor = True
        '
        'btn_admin
        '
        Me.btn_admin.Location = New System.Drawing.Point(155, 125)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(103, 35)
        Me.btn_admin.TabIndex = 2
        Me.btn_admin.Text = "Admin"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(32, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 227)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login As"
        '
        'frm_login_as
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.btn_pembeli)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_login_as"
        Me.Text = "Toko Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_close As Button
    Friend WithEvents btn_pembeli As Button
    Friend WithEvents btn_admin As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
