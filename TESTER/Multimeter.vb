Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Multimeter
    Dim tcpClient As New TcpClient
    Dim ipAddress As IPAddress
    Dim thread As Thread = New Thread(AddressOf ReplyThread)

    Dim reply As String = ""
    Public Function Connect(ip As String, port As String) As Boolean
        Try
            ipAddress = IPAddress.Parse(ip)
            tcpClient.Connect(ipAddress, port)
            thread.Start()
            Return True
        Catch ex As Exception
            MsgBox("Multimeter connect error : " + ex.ToString())
            Return False
        End Try
    End Function
    Public Function Close() As Boolean
        Try
            tcpClient.Close()
            Return True
        Catch ex As Exception
            MsgBox("Multimeter close error : " + ex.ToString())
            Return False
        End Try
    End Function
    Public Sub SendCommand(command As String)
        If (tcpClient.Connected) Then
            Dim writer As NetworkStream = tcpClient.GetStream()
            Dim outputStream As Byte() = Encoding.ASCII.GetBytes(command + "$")
            'Dim outputStream As Byte() = System.Text.Encoding.ASCII.GetBytes(command)
            writer.Write(outputStream, 0, outputStream.Length)
            writer.Flush()
        End If
    End Sub
    Public Function GetReply() As String
        Dim temp As String = ""
        If tcpClient.Connected Then
            temp = reply
        End If
        Return reply
    End Function
    Private Sub ReplyThread()
        While True
            Try
                If tcpClient.Connected Then
                    Dim networkStream As NetworkStream = tcpClient.GetStream()
                    Dim inStream(tcpClient.ReceiveBufferSize) As Byte
                    networkStream.Read(inStream, 0, inStream.Length)
                    reply = System.Text.Encoding.ASCII.GetString(inStream)
                    reply = reply.Substring(0, reply.IndexOf("$"))
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Thread.Sleep(100)
        End While
    End Sub
    Public Sub OpenChannel(channel As Integer)
        Dim command As String = "ROUT:OPEN (@" + channel.ToString() + ")" + System.Environment.NewLine
        SendCommand(command)
    End Sub
    Public Sub CloseChannel(channel As Integer)
        Dim command As String = "ROUT:CLOS (@" + channel.ToString() + ")" + System.Environment.NewLine
        SendCommand(command)
    End Sub
    Public Function MeasureResistance() As Double
        Dim command As String = "MEAS?" + System.Environment.NewLine
        'Console.WriteLine(command)
        SendCommand(command)
        Dim reply As String = GetReply()
        Dim value As Double
        Try
            value = Double.Parse(reply)
        Catch ex As Exception
            value = 0.0
        End Try
        Return value
    End Function
    Public Function GetDeviceInfo() As String
        Dim command As String = "*IDN?" + System.Environment.NewLine
        SendCommand(command)
        Return GetReply()
    End Function
    Public Sub SetResitanceMode()
        Dim command As String = "SENS:FUNC 'RES', (@101, 102, 103)" + System.Environment.NewLine
        SendCommand(command)
    End Sub
End Class
