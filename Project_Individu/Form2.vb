Imports System.Data.OleDb
Public Class frm_login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Call koneksi()
        Dim str As String
        str = "Select * from Login where  ID = '" & txt_username.Text & "' and Password = '" & txt_password.Text & "'"
        cmd = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MessageBox.Show("Login Berhasil")
            Me.Hide()
            frm_loading.Show()
        End If
        If Not dr.HasRows Then
            MessageBox.Show("Login Gagal")
        End If
    End Sub
    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        frm_login_as.Show()
        Me.Hide()
    End Sub
End Class