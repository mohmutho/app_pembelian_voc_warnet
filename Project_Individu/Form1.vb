Public Class frm_login_as
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim tampung As MsgBoxResult
        tampung = MsgBox("Apakah Anda Yakin Ingin Keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan")
        If tampung = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        frm_login.Show()
        Me.Hide()
    End Sub
    Private Sub btn_pembeli_Click(sender As Object, e As EventArgs) Handles btn_pembeli.Click
        frm_pembeli.Show()
        Me.Hide()
    End Sub
End Class
