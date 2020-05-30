<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pembeli
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.cmb_pembelian = New System.Windows.Forms.ComboBox()
        Me.lbl_kode = New System.Windows.Forms.Label()
        Me.lbl_harga = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.lbl_pembelian = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(478, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginAdminToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginAdminToolStripMenuItem
        '
        Me.LoginAdminToolStripMenuItem.Name = "LoginAdminToolStripMenuItem"
        Me.LoginAdminToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.LoginAdminToolStripMenuItem.Text = "Login Admin"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Pembelian Anda :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Pembeli :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kode Barang :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jumlah Pembelian :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Harga :"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(177, 91)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(264, 22)
        Me.txt_nama.TabIndex = 12
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(177, 221)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(264, 22)
        Me.txt_jumlah.TabIndex = 14
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(109, 310)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(100, 33)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(256, 310)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(100, 33)
        Me.btn_batal.TabIndex = 18
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'cmb_pembelian
        '
        Me.cmb_pembelian.FormattingEnabled = True
        Me.cmb_pembelian.Location = New System.Drawing.Point(177, 137)
        Me.cmb_pembelian.Name = "cmb_pembelian"
        Me.cmb_pembelian.Size = New System.Drawing.Size(264, 24)
        Me.cmb_pembelian.TabIndex = 19
        '
        'lbl_kode
        '
        Me.lbl_kode.AutoSize = True
        Me.lbl_kode.Location = New System.Drawing.Point(174, 50)
        Me.lbl_kode.Name = "lbl_kode"
        Me.lbl_kode.Size = New System.Drawing.Size(51, 17)
        Me.lbl_kode.TabIndex = 20
        Me.lbl_kode.Text = "Label2"
        '
        'lbl_harga
        '
        Me.lbl_harga.AutoSize = True
        Me.lbl_harga.Location = New System.Drawing.Point(174, 264)
        Me.lbl_harga.Name = "lbl_harga"
        Me.lbl_harga.Size = New System.Drawing.Size(0, 17)
        Me.lbl_harga.TabIndex = 21
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(12, 184)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(82, 17)
        Me.label.TabIndex = 22
        Me.label.Text = "Pembelian :"
        '
        'lbl_pembelian
        '
        Me.lbl_pembelian.AutoSize = True
        Me.lbl_pembelian.Location = New System.Drawing.Point(174, 183)
        Me.lbl_pembelian.Name = "lbl_pembelian"
        Me.lbl_pembelian.Size = New System.Drawing.Size(0, 17)
        Me.lbl_pembelian.TabIndex = 23
        '
        'frm_pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 353)
        Me.Controls.Add(Me.lbl_pembelian)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.lbl_kode)
        Me.Controls.Add(Me.cmb_pembelian)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_jumlah)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_harga)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_pembeli"
        Me.Text = "Pembeli"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents cmb_pembelian As ComboBox
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_kode As Label
    Friend WithEvents lbl_harga As Label
    Friend WithEvents label As Label
    Friend WithEvents lbl_pembelian As Label
End Class
