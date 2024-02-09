Imports System.Net
Imports System.Net.Sockets
Imports System.Text
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
    Public Function is_connected() As Boolean
        Return connected
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
