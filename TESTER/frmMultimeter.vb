Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class frmMultimeter
    Dim tcpClient As New TcpClient
    Dim ipAddress As IPAddress
    Private Sub SendCommand(command As String)
        If (tcpClient.Connected) Then
            Dim writer As NetworkStream = tcpClient.GetStream()
            Dim outputStream As Byte() = Encoding.ASCII.GetBytes(command + "$")
            'Dim outputStream As Byte() = System.Text.Encoding.ASCII.GetBytes(command)
            writer.Write(outputStream, 0, outputStream.Length)
            writer.Flush()
        End If
    End Sub
    Private Function GetReply() As String
        Dim reply As String = ""
        If tcpClient.Connected Then
            Dim networkStream As NetworkStream = tcpClient.GetStream()
            Dim inStream(tcpClient.ReceiveBufferSize) As Byte
            networkStream.Read(inStream, 0, inStream.Length)
            reply = System.Text.Encoding.ASCII.GetString(inStream)
            reply = reply.Substring(0, reply.IndexOf(Environment.NewLine))
        End If
        Return reply
    End Function
    Private Sub OpenChannel(channel As Integer)
        Dim command As String = "ROUT:OPEN (@" + channel.ToString() + ")" + System.Environment.NewLine
        SendCommand(command)
    End Sub
    Private Sub CloseChannel(channel As Integer)
        Dim command As String = "ROUT:CLOS (@" + channel.ToString() + ")" + System.Environment.NewLine
        SendCommand(command)
    End Sub
    Private Function MeasureResistance() As Double
        Dim command As String = "MEAS?" + System.Environment.NewLine
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
    Private Sub btn_read_ch_1_Click(sender As Object, e As EventArgs) Handles btn_read_ch_1.Click
        OpenChannel(102)
        CloseChannel(101)
        Dim productRes As Double = MeasureResistance()
        txt_ch_1.Text = productRes.ToString
        txt_ch_2.Text = ""
    End Sub
    Private Sub btn_read_ch_2_Click(sender As Object, e As EventArgs) Handles btn_read_ch_2.Click
        OpenChannel(101)
        CloseChannel(102)
        Dim productRes As Double = MeasureResistance()
        txt_ch_2.Text = productRes.ToString
        txt_ch_1.Text = ""
    End Sub
End Class