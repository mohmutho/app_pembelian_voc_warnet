Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public str As String
    Public adapt As OleDbDataAdapter
    Public datset As DataSet
    Sub koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Project_individu.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
