<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin
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
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_tampil = New System.Windows.Forms.DataGridView()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.cmb_pembelian = New System.Windows.Forms.ComboBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.rdb_dibayar = New System.Windows.Forms.RadioButton()
        Me.rdb_belum = New System.Windows.Forms.RadioButton()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_pembelian = New System.Windows.Forms.Label()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.GrupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(149, 17)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(253, 22)
        Me.txt_kode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Pembeli :"
        '
        'dgv_tampil
        '
        Me.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil.Location = New System.Drawing.Point(12, 274)
        Me.dgv_tampil.Name = "dgv_tampil"
        Me.dgv_tampil.RowTemplate.Height = 24
        Me.dgv_tampil.Size = New System.Drawing.Size(895, 258)
        Me.dgv_tampil.TabIndex = 2
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(625, 17)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(253, 22)
        Me.txt_nama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(483, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pembeli :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kode Barang :"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(625, 123)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(253, 22)
        Me.txt_jumlah.TabIndex = 7
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(625, 163)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(253, 22)
        Me.txt_total.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jumlah Pembelian :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Harga :"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(15, 53)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(100, 33)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(302, 53)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(100, 33)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(157, 144)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(140, 36)
        Me.btn_close.TabIndex = 13
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'cmb_pembelian
        '
        Me.cmb_pembelian.FormattingEnabled = True
        Me.cmb_pembelian.Location = New System.Drawing.Point(625, 53)
        Me.cmb_pembelian.Name = "cmb_pembelian"
        Me.cmb_pembelian.Size = New System.Drawing.Size(253, 24)
        Me.cmb_pembelian.TabIndex = 15
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(159, 53)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(100, 33)
        Me.btn_simpan.TabIndex = 16
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'rdb_dibayar
        '
        Me.rdb_dibayar.AutoSize = True
        Me.rdb_dibayar.Location = New System.Drawing.Point(124, 101)
        Me.rdb_dibayar.Name = "rdb_dibayar"
        Me.rdb_dibayar.Size = New System.Drawing.Size(78, 21)
        Me.rdb_dibayar.TabIndex = 17
        Me.rdb_dibayar.TabStop = True
        Me.rdb_dibayar.Text = "Dibayar"
        Me.rdb_dibayar.UseVisualStyleBackColor = True
        '
        'rdb_belum
        '
        Me.rdb_belum.AutoSize = True
        Me.rdb_belum.Location = New System.Drawing.Point(271, 101)
        Me.rdb_belum.Name = "rdb_belum"
        Me.rdb_belum.Size = New System.Drawing.Size(121, 21)
        Me.rdb_belum.TabIndex = 18
        Me.rdb_belum.TabStop = True
        Me.rdb_belum.Text = "Belum Dibayar"
        Me.rdb_belum.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(410, 12)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(69, 33)
        Me.btn_new.TabIndex = 19
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(483, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Pembelian :"
        '
        'lbl_pembelian
        '
        Me.lbl_pembelian.AutoSize = True
        Me.lbl_pembelian.Location = New System.Drawing.Point(623, 91)
        Me.lbl_pembelian.Name = "lbl_pembelian"
        Me.lbl_pembelian.Size = New System.Drawing.Size(0, 17)
        Me.lbl_pembelian.TabIndex = 21
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(82, 208)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(137, 35)
        Me.btn_cetak.TabIndex = 22
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(256, 208)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(136, 34)
        Me.btn_browse.TabIndex = 23
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(626, 234)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(252, 22)
        Me.txt_location.TabIndex = 24
        '
        'txt_judul
        '
        Me.txt_judul.Location = New System.Drawing.Point(626, 201)
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.Size = New System.Drawing.Size(252, 22)
        Me.txt_judul.TabIndex = 25
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(483, 204)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(50, 17)
        Me.lbl_title.TabIndex = 26
        Me.lbl_title.Text = "Judul :"
        '
        'lbl_location
        '
        Me.lbl_location.AutoSize = True
        Me.lbl_location.Location = New System.Drawing.Point(483, 237)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(70, 17)
        Me.lbl_location.TabIndex = 27
        Me.lbl_location.Text = "Location :"
        '
        'GrupBox1
        '
        Me.GrupBox1.Location = New System.Drawing.Point(3, 186)
        Me.GrupBox1.Name = "GrupBox1"
        Me.GrupBox1.Size = New System.Drawing.Size(913, 350)
        Me.GrupBox1.TabIndex = 28
        Me.GrupBox1.TabStop = False
        Me.GrupBox1.Text = "Export To PDF"
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 544)
        Me.Controls.Add(Me.lbl_location)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_judul)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.lbl_pembelian)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.rdb_belum)
        Me.Controls.Add(Me.rdb_dibayar)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.cmb_pembelian)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_jumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.dgv_tampil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.GrupBox1)
        Me.Name = "frm_admin"
        Me.Text = "Admin"
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_kode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_tampil As DataGridView
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents cmb_pembelian As ComboBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents rdb_dibayar As RadioButton
    Friend WithEvents rdb_belum As RadioButton
    Friend WithEvents btn_new As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_pembelian As Label
    Friend WithEvents btn_cetak As Button
    Friend WithEvents btn_browse As Button
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_judul As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_location As Label
    Friend WithEvents GrupBox1 As GroupBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
