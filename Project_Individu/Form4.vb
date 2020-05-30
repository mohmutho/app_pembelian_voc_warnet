Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class frm_admin
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim tampung As MsgBoxResult
        tampung = MsgBox("Apakah Anda Yakin Ingin Keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan")
        If tampung = MsgBoxResult.Yes Then
            frm_login_as.Show()
            End
        End If
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim bayar As String
            If rdb_belum.Checked = True Then
                bayar = rdb_belum.Text
            ElseIf rdb_dibayar.Checked = True Then
                bayar = rdb_dibayar.Text
            End If
            Dim str As String
            str = "Update Data_Admin set Nama_Pembeli = '" & txt_nama.Text & "', Kode_Barang = '" & cmb_pembelian.Text & "', Jumlah_Pembelian = '" & CInt(txt_jumlah.Text) & "', Total = '" & CInt(txt_total.Text) & "', Pembayaran = '" & bayar & "' where Kode = '" & txt_kode.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Edit Data Berhasil")
        Catch ex As Exception
            MessageBox.Show("Edit Data Gagal")
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Sub Kosong()
        txt_kode.Text = ""
        txt_nama.Text = ""
        cmb_pembelian.Text = ""
        lbl_pembelian.Text = ""
        txt_jumlah.Text = ""
        txt_total.Text = ""
        rdb_belum.Checked = False
        rdb_dibayar.Checked = False
    End Sub
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        da = New OleDbDataAdapter("Select Kode, Nama_Pembeli, Nama_Barang As Pembelian, Jumlah_Pembelian, Total, Pembayaran from Data_Admin INNER JOIN Data_Barang ON Data_Admin.Kode_Barang = Data_Barang.ID_Barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Data_Admin")
        dgv_tampil.DataSource = (ds.Tables("Data_Admin"))
        dgv_tampil.Refresh()
        adapt = New OleDbDataAdapter("Select * from Data_Barang", conn)
        datset = New DataSet
        datset.Clear()
        adapt.Fill(datset, "Data_Barang")
        cmd = New OleDbCommand("select * FROM Data_Barang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmb_pembelian.Items.Add(dr.Item(0))
        Loop
        conn.Close()
        da.Dispose()
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"
        txt_judul.Text = ""
        txt_location.Text = ""
    End Sub
    Sub hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "Delete * from Data_Admin where Kode = '" & txt_kode.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus")
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Sub Simpan()
        Try
            Call koneksi()
            Dim str As String
            Dim bayar As String
            If rdb_belum.Checked = True Then
                bayar = rdb_belum.Text
            ElseIf rdb_dibayar.Checked = True Then
                bayar = rdb_dibayar.Text
            End If
            str = "Insert into Data_Admin values ('" & txt_kode.Text & "','" & txt_nama.Text & "','" & cmb_pembelian.Text & "','" & CInt(txt_jumlah.Text) & "','" & CInt(txt_total.Text) & "','" & bayar & "')" 'artinya simpan ke tabel Barang diDatabase'
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Simpan")
        Catch ex As Exception
            MessageBox.Show("Data gagal Disimpan")
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub txt_jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim tampung As MsgBoxResult
        tampung = MsgBox("Apakah Data Sudah Benar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan")
        If tampung = MsgBoxResult.Yes Then
            Call Edit()
            frm_admin_Load(sender, e)
            Call Kosong()
        End If
    End Sub
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim tampung As MsgBoxResult
        tampung = MsgBox("Apakah Anda Yakin Data Dihapus", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan")
        If tampung = MsgBoxResult.Yes Then
            Call hapus()
            frm_admin_Load(sender, e)
            Call Kosong()
        End If
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_kode.Text = "" Or txt_nama.Text = "" Or cmb_pembelian.Text = "" Or txt_jumlah.Text = "" Or txt_total.Text = "" Then
            MessageBox.Show("Semua Data Wajib Diisi")
            Call Kosong()
            Exit Sub
        End If
        Call Simpan()
        frm_admin_Load(sender, e)
        Call Kosong()
    End Sub
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim pool As String = “0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ”
        Dim count = 0
        txt_kode.Text = ""
        Dim cc As New Random
        Dim strpos = ""
        While count <= 5
            strpos = cc.Next(0, pool.Length)
            txt_kode.Text = txt_kode.Text & pool(strpos)
            count = count + 1
        End While
    End Sub
    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged
        Call koneksi()
        Dim str As String
        Dim harga, x, y As Double
        str = "Select * From Data_Barang Where ID_Barang = '" & cmb_pembelian.Text & "'"
        cmd = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If cmb_pembelian.Text = "S10" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S20" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S50" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S100" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S150" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S200" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S300" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S500" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U20" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U35" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U50" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U75" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U100" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M20" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M50" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M75" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M100" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M200" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L20" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L35" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L50" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L75" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L100" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L150" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L200" Then
            If txt_jumlah.Text = "" Then
                txt_total.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    txt_total.Text = harga
                End If
            End If
        End If
        conn.Close()
    End Sub
    Private Sub cmb_pembelian_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_pembelian.SelectedValueChanged
        Call koneksi()
        Dim str As String
        str = "Select * from Data_Barang where ID_barang = '" & cmb_pembelian.Text & "'"
        cmd = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lbl_pembelian.Text = dr.Item("Nama_Barang")
        End If
        conn.Close()
    End Sub
    Private Sub dgv_tampil_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_tampil.MouseClick
        Dim data_barang As DataGridViewRow
        Dim bayar As String
        data_barang = dgv_tampil.CurrentRow
        txt_kode.Text = data_barang.Cells(0).Value
        txt_nama.Text = data_barang.Cells(1).Value
        txt_jumlah.Text = data_barang.Cells(3).Value
        txt_total.Text = data_barang.Cells(4).Value
        lbl_pembelian.Text = data_barang.Cells(2).Value
        bayar = data_barang.Cells(5).Value
        If bayar = "Belum Dibayar" Then
            rdb_belum.Checked = True
        ElseIf bayar = "Dibayar" Then
            rdb_dibayar.Checked = True
        End If
    End Sub
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            txt_location.Text = SaveFileDialog1.FileName
        End If
    End Sub
    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        Dim Paragraph As New Paragraph
        Dim pdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
        pdfFile.AddTitle(txt_judul.Text)
        Dim Write As PdfWriter = PdfWriter.GetInstance(pdfFile, New FileStream(txt_location.Text, FileMode.Create))
        pdfFile.Open()
        'declaration Font Type
        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        'insert title into pdf file
        Paragraph = New Paragraph(New Chunk(txt_judul.Text, pTitle))
        Paragraph.Alignment = Element.ALIGN_CENTER
        Paragraph.SpacingAfter = 4.0F
        'set and add page with current settings
        pdfFile.Add(Paragraph)
        'create data into table
        Dim pdfTable As New PdfPTable(dgv_tampil.Columns.Count)
        'setting width table
        pdfTable.TotalWidth = 500.0F
        pdfTable.LockedWidth = True
        Dim widths(0 To dgv_tampil.Columns.Count - 1) As Single
        For i As Integer = 0 To dgv_tampil.Columns.Count - 1
            widths(i) = 1.0F
        Next
        pdfTable.SetWidths(widths)
        pdfTable.HorizontalAlignment = 0
        pdfTable.SpacingBefore = 4.0F
        'declaration pdf Cells
        Dim pdfCell As PdfPCell = New PdfPCell
        'create pdf header
        For i As Integer = 0 To dgv_tampil.Columns.Count - 1
            pdfCell = New PdfPCell(New Phrase(New Chunk(dgv_tampil.Columns(i).HeaderText, pTable)))
            'alignment header table
            pdfCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'add cells into pdf table
            pdfTable.AddCell(pdfCell)
        Next
        'add data into pdf table
        For i As Integer = 0 To dgv_tampil.Rows.Count - 2
            For j As Integer = 0 To dgv_tampil.Columns.Count - 1
                pdfCell = New PdfPCell(New Phrase(dgv_tampil(j, i).Value.ToString(), pTable))
                pdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                pdfTable.AddCell(pdfCell)
            Next
        Next
        'add pdf table into pdf document
        pdfFile.Add(pdfTable)
        pdfFile.Close()
        MessageBox.Show("PDF Format Success Exported !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class