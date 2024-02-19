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
    Dim dataRX(1024) As Byte
    Dim data As String
    Public Function ReadData(compare As String) As Boolean
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim reader As New StreamReader(stream, Encoding.UTF8)

            While (stream.DataAvailable)
                stream.Read(dataRX, 0, dataRX.Length)
                data = Encoding.ASCII.GetString(dataRX).Replace(vbNullChar, "")
            End While

            If data IsNot Nothing Then
                Dim split_val As String() = data.Split(";;")

                For Each word As String In split_val
                    Console.WriteLine(word + " " + compare)
                    If word = compare Then
                        Return True
                    End If
                Next
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub GetMarkStatus()
        If Not is_writing() Then
            write_data("GetMarkStatus;;")
        End If
    End Sub
    Public Sub SetMarkingTemplate(template As String)
        If Not is_writing() Then
            write_data("SwitchDoc," + template + ";;")
        End If
    End Sub
    Public Sub StartMark()
        If Not is_writing() Then
            write_data("StartMark;;")
        End If
    End Sub
End Class
