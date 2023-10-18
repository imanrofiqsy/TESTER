﻿Imports System.Data.SqlClient
Module KoneksiDB
    Public Function Database() As String
        Dim db As String = "Data Source=WTID10321122000\SQLEXPRESS;
            initial catalog=TESE;
            Persist Security Info=True;
            Connect Timeout=15000;
            Max Pool Size=15000;
            Pooling=True"
        Return db
    End Function
    Public Function bacaData(query As String) As DataSet
        Try
            Dim konek As New SqlConnection(Database)
            Dim sc As New SqlCommand(query, konek)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            If konek.State = ConnectionState.Closed Then konek.Open()

            adapter.Fill(ds)
            'koneksi.Close()
            Return ds
        Catch ex As Exception
            MsgBox("Database connection Error! " + ex.Message)
        End Try
    End Function
End Module
