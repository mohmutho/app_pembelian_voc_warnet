Imports System.Data.OleDb
Public Class frm_pembeli
    Private Sub LoginAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginAdminToolStripMenuItem.Click
        frm_login.Show()
        Me.Hide()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frm_login_as.Show()
        Me.Hide()
    End Sub
    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Dim tampung As MsgBoxResult
        tampung = MsgBox("Apakah Anda Yakin Ingin Keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan")
        If tampung = MsgBoxResult.Yes Then
            frm_login_as.Show()
            Me.Hide()
        End If
    End Sub
    Sub Kosong()
        txt_nama.Text = ""
        cmb_pembelian.Text = ""
        txt_jumlah.Text = ""
        lbl_harga.Text = ""
    End Sub
    Private Sub frm_pembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        adapt = New OleDbDataAdapter("Select * from Data_Barang", conn)
        datset = New DataSet
        datset.Clear()
        adapt.Fill(datset, "Data_Barang")
        cmd = New OleDbCommand("select * FROM Data_Barang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmb_pembelian.Items.Add(dr.Item(0))
        Loop
        lbl_pembelian.Text = ""
        conn.Close()
        Dim pool As String = “0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ”
        Dim count = 0
        lbl_kode.Text = ""
        Dim cc As New Random
        Dim strpos = ""
        While count <= 5
            strpos = cc.Next(0, pool.Length)
            lbl_kode.Text = lbl_kode.Text & pool(strpos)
            count = count + 1
        End While
    End Sub
    Sub Simpan()
        Try
            Call koneksi()
            Dim str As String
            Dim bayar As String
            bayar = "Belum Dibayar"
            str = "Insert into Data_Admin values ('" & lbl_kode.Text & "','" & txt_nama.Text & "','" & cmb_pembelian.Text & "','" & Val(txt_jumlah.Text) & "','" & Val(lbl_harga.Text) & "','" & bayar & "')" 'artinya simpan ke tabel Barang diDatabase'
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Silahkan Melakukan Pembayaran dikasir dengan kode " & lbl_kode.Text & vbNewLine)
        Catch ex As Exception
            MessageBox.Show("Silahkan Isi Ulang Data")
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub txt_jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_nama.Text = "" Or cmb_pembelian.Text = "" Or txt_jumlah.Text = "" Then
            MessageBox.Show("Semua Data Wajib Diisi")
            Call Kosong()
            Exit Sub
        End If
        Call Simpan()
        frm_pembeli_Load(sender, e)
        Call Kosong()
    End Sub
    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        frm_daftar.Show()
    End Sub
    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged
        Call koneksi()
        Dim str As String
        Dim harga, x, y As Double
        str = "Select * From Data_Barang Where ID_Barang = '" & cmb_pembelian.Text & "'"
        cmd = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read
        If cmb_pembelian.Text = "S10" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S20" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S50" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S100" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S150" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S200" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S300" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "S500" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U20" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U35" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U50" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U75" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "U100" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M20" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M50" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M75" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M100" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "M200" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L20" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L35" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L50" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L75" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L100" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L150" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
                End If
            End If
        ElseIf cmb_pembelian.Text = "L200" Then
            If txt_jumlah.Text = "" Then
                lbl_harga.Text = ""
            Else
                x = Val(txt_jumlah.Text)
                If dr.HasRows Then
                    y = Val(dr.Item("Harga"))
                    harga = x * y
                    lbl_harga.Text = harga
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
End Class