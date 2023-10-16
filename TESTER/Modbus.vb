Imports EasyModbus
Public Class Modbus
    Dim modbusClient As ModbusClient
    Dim ReadValue As String
    Public Function OpenPort(IP As String, PORT As String) As Boolean
        Try
            modbusClient = New ModbusClient(IP, Val(PORT))
            modbusClient.Connect()
            Return True
        Catch ex As Exception
            MsgBox("Modbus Error Connect! " & ex.Message)
            End
        End Try
    End Function
    Public Function ClosePort() As Boolean
        Try
            modbusClient.Disconnect()
            Return True
        Catch ex As Exception
            MsgBox("Modbus Error Disconnect! " & ex.Message)
            End
        End Try
    End Function
    Private Sub ReadHelper(Address As String, RegType As Integer)
        Dim StartAddress As Integer = Val(Address)
        Select Case RegType
            Case 0
                Dim ReadValues() As Boolean = modbusClient.ReadCoils(StartAddress, 1)
                ReadValue = ReadValues(0)
            Case 1
                If StartAddress > 10000 Then StartAddress = StartAddress - 10001
                Dim ReadValues() As Boolean = modbusClient.ReadDiscreteInputs(StartAddress, 1)
                ReadValue = ReadValues(0)
            Case 2
                If StartAddress > 30000 Then StartAddress = StartAddress - 30001
                Dim ReadValues() As Integer = modbusClient.ReadInputRegisters(StartAddress, 1)
                ReadValue = ReadValues(0)
            Case 3
                If StartAddress > 40000 Then StartAddress = StartAddress - 40001
                Dim ReadValues() As Integer = modbusClient.ReadHoldingRegisters(StartAddress, 1)
                ReadValue = ReadValues(0)
        End Select
    End Sub
    Public Function ReadData(RegType As String, Address As Integer) As Integer
        Try
            ReadHelper(Address, RegType)
        Catch ex As Exception
            MsgBox("Modbus Error Read! " & ex.Message)
        End Try
        Return CInt(ReadValue)
    End Function
    Private Sub WriteHelper(RegType As Integer, Value As Integer, StartAddress As Integer)
        Select Case RegType
            Case 0
                Dim WriteVals(0) As Boolean
                WriteVals(0) = Value
                modbusClient.WriteMultipleCoils(StartAddress, WriteVals)
            Case 1
                    '
            Case 2
                    '
            Case 3
                If StartAddress > 40000 Then StartAddress = StartAddress - 40001
                Dim WriteVals(0) As Integer
                WriteVals(0) = Value
                modbusClient.WriteMultipleRegisters(StartAddress, WriteVals)
        End Select
    End Sub
    Public Sub WriteData(RegType As Integer, StartAddress As Integer, Value As Integer)
        Try
            WriteHelper(RegType, Value, StartAddress)
        Catch ex As Exception
            MsgBox("Modbus Error Write! " & ex.Message)
        End Try
    End Sub
End Class
