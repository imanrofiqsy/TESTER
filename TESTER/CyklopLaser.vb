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
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim writer As New StreamWriter(Stream, Encoding.UTF8) With {.AutoFlush = True}
            writer.Write(cmd)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function read_data() As String
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim reader As New StreamReader(stream, Encoding.UTF8)
            Return reader.Read
        Catch ex As Exception
            Return "None"
        End Try
    End Function
    Sub Main()
        Try
            ' Specify the server IP address and port number
            Dim serverIP As String = Config.addressLaser
            Dim port As Integer = Config.portLaser

            ' Create a TcpClient object and connect to the server
            client = New TcpClient(serverIP, port)


            ' Get the network stream for reading and writing
            Dim stream As NetworkStream = client.GetStream()

            ' Send a message to the server
            Dim message As String = "Hello from the client!"
            Dim data As Byte() = Encoding.ASCII.GetBytes(message)
            stream.Write(data, 0, data.Length)
            Console.WriteLine("Sent to server: {0}", message)

            ' Receive the response from the server
            data = New Byte(1024) {}
            Dim bytesRead As Integer = stream.Read(data, 0, data.Length)
            Dim receivedMessage As String = Encoding.ASCII.GetString(data, 0, bytesRead)
            Console.WriteLine("Received from server: {0}", receivedMessage)

            ' Close the connection
            client.Close()
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Class
