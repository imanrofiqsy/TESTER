Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Public Class CyklopLaser
    Dim client As TcpClient
    Dim connected As Boolean
    Dim writeTrig As Boolean
    Public Function is_writing() As Boolean
        If writeTrig Then
            writeTrig = False
            Return True
        End If
        Return False
    End Function
    Public Sub Connect()
        ' Specify the server IP address and port number
        Dim serverIP As String = Config.addressLaser
        Dim port As Integer = Config.portLaser

        ' Create a TcpClient object and connect to the server
        client = New TcpClient(serverIP, port)
        connected = True
    End Sub
    Public Sub Disconnect()
        client.Close()
        connected = False
    End Sub
    Public Function is_connected() As Boolean
        Return connected
    End Function
    Public Function write_data(cmd As String) As Boolean
        Dim dataTX() As Byte
        dataTX = Encoding.ASCII.GetBytes(cmd)
        Try
            Dim stream As NetworkStream = client.GetStream()
            stream.Write(dataTX, 0, dataTX.Length)
            stream.Flush()
            'Dim writer As New StreamWriter(stream, Encoding.UTF8) With {.AutoFlush = True}
            'writer.Write(cmd)
            writeTrig = True
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ReadData() As String
        Try
            Dim dataRX(1024) As Byte
            Dim stream As NetworkStream = client.GetStream()
            Dim reader As New StreamReader(stream, Encoding.UTF8)
            Dim data As String

            While (stream.DataAvailable)
                stream.Read(dataRX, 0, dataRX.Length)
                data = Encoding.ASCII.GetString(dataRX)
            End While

            Return data
        Catch ex As Exception
            Return "None"
        End Try
    End Function
End Class
