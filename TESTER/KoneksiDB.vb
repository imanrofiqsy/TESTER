Imports System.Data.SqlClient
Module KoneksiDB
    Public koneksi As SqlConnection
    Public Sub koneksi_db()
        Try
            Dim database As String
            With Config
                database = "Data Source=" & .dbHostName & "\SQLEXPRESS;
                initial catalog=" & .dbDatabase & ";
                User ID=" & .dbUsername & ";
                Password=" & .dbPassword & ";
                MultipleActiveResultSets=true"
            End With

            koneksi = New SqlConnection(database)
            If koneksi.State = ConnectionState.Closed Then koneksi.Open() Else koneksi.Close()
        Catch ex As Exception
            MsgBox("Database Connection Error -> " + ex.Message)
        End Try
    End Sub
End Module
