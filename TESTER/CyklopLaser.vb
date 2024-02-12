Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Public Class CyklopLaser
    Dim client As TcpClient
    Dim connected As Boolean
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
        dataTX = Encoding.ASCII.GetBytes(cmd + Environment.NewLine)
        Try
            Dim stream As NetworkStream = client.GetStream()
            client.GetStream.Write(dataTX, 0, dataTX.Length)
            'Dim writer As New StreamWriter(stream, Encoding.UTF8) With {.AutoFlush = True}
            'writer.Write(cmd)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ReadData() As String
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim reader As New StreamReader(stream, Encoding.UTF8)
            Dim data As New StringBuilder()

            While stream.DataAvailable
                data.Append(Convert.ToChar(reader.Read()))
            End While

            Return data.ToString()
        Catch ex As Exception
            Return "None"
        End Try
    End Function

End Class
