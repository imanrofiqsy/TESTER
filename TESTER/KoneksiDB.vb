Imports System.Data.SqlClient
Module KoneksiDB
    Public koneksi As SqlConnection
    Public Sub koneksi_db()
        Try
            'Dim database As String = "Data Source=WTID10321122000\SQLEXPRESS;
            'initial catalog=TESE;
            'integrated security=true"
            Dim database As String = "Data Source=DESKTOP-R3AJPOP\SQLEXPRESS01;
            initial catalog=TESE;
            integrated security=true"

            koneksi = New SqlConnection(database)
            If koneksi.State = ConnectionState.Closed Then koneksi.Open() Else koneksi.Close()
        Catch ex As Exception
            MsgBox("Database Connection Error -> " + ex.Message)
        End Try
    End Sub
End Module
