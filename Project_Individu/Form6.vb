Imports System.Data.OleDb
Public Class frm_daftar
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        da = New OleDbDataAdapter("Select * from Data_Barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Data_Admin")
        dgv_tampil_barang.DataSource = (ds.Tables("Data_Admin"))
    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_pembeli.Show()
        Me.Hide()
    End Sub
End Class