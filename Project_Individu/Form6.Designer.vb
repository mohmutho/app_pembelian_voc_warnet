<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_daftar
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
        Me.dgv_tampil_barang = New System.Windows.Forms.DataGridView()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.dgv_tampil_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_tampil_barang
        '
        Me.dgv_tampil_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil_barang.Location = New System.Drawing.Point(13, 13)
        Me.dgv_tampil_barang.Name = "dgv_tampil_barang"
        Me.dgv_tampil_barang.RowTemplate.Height = 24
        Me.dgv_tampil_barang.Size = New System.Drawing.Size(537, 567)
        Me.dgv_tampil_barang.TabIndex = 0
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(224, 587)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(108, 30)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 625)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.dgv_tampil_barang)
        Me.Name = "frm_daftar"
        Me.Text = "Daftar Barang"
        CType(Me.dgv_tampil_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_tampil_barang As DataGridView
    Friend WithEvents btn_exit As Button
End Class
