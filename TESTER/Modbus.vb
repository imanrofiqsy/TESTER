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
            'End
            Return False
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
                If StartAddress > 40000 Then StartAddress = StartAddress - 40000
                Dim ReadValues() As Integer = modbusClient.ReadHoldingRegisters(StartAddress, 1)
                ReadValue = ReadValues(0)
        End Select
    End Sub
    Private Sub ReadHelperFloat(Address As String, RegType As Integer)
        Dim StartAddress As Integer = Val(Address)
        Select Case RegType
            Case 0
                Dim ReadValues() As Boolean = modbusClient.ReadCoils(StartAddress, 2)
                ReadValue = ReadValues(0)
            Case 1
                If StartAddress > 10000 Then StartAddress = StartAddress - 10001
                Dim ReadValues() As Boolean = modbusClient.ReadDiscreteInputs(StartAddress, 2)
                ReadValue = ReadValues(0)
            Case 2
                If StartAddress > 30000 Then StartAddress = StartAddress - 30001
                Dim ReadValues() As Integer = modbusClient.ReadInputRegisters(StartAddress, 2)
                ReadValue = ReadValues(0)
            Case 3
                If StartAddress > 40000 Then StartAddress = StartAddress - 40001
                Dim vals() As Integer = modbusClient.ReadHoldingRegisters(StartAddress, 2)
                ReadValue = ConvertDW2Float(vals(0), vals(1))

        End Select
    End Sub
    Private Function ConvertDW2Float(reg1 As Short, reg2 As Short) As Single
        Dim fval As Single

        Dim intBytes1 As Byte() = BitConverter.GetBytes(reg1)
        If (BitConverter.IsLittleEndian) Then Array.Reverse(intBytes1)
        Dim result1 As Byte() = intBytes1
        Dim intBytes2 As Byte() = BitConverter.GetBytes(reg2)
        If (BitConverter.IsLittleEndian) Then Array.Reverse(intBytes2)
        Dim result2 As Byte() = intBytes2
        Dim _bytes(4) As Byte
        _bytes(0) = intBytes1(1)
        _bytes(1) = intBytes1(0)
        _bytes(2) = intBytes2(1)
        _bytes(3) = intBytes2(0)
        Dim _val As Double = BitConverter.ToSingle(_bytes, 0)
        _val = Math.Round(_val, 2)
        fval = _val

        Return fval
    End Function
    Public Function ReadData(RegType As String, Address As Integer) As Integer
        Try
            ReadHelper(Address, RegType)
        Catch ex As Exception
            MsgBox("Modbus Error Read! " & ex.Message)
        End Try
        Return CInt(ReadValue)
    End Function
    Public Function ReadDataFloat(RegType As String, Address As Integer) As String
        Try
            ReadHelperFloat(Address, RegType)
        Catch ex As Exception
            MsgBox("Modbus Error Read! " & ex.Message)
        End Try
        Return ReadValue
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
                If StartAddress > 40000 Then StartAddress = StartAddress - 40000
                Dim WriteVals(0) As Integer
                WriteVals(0) = Value
                modbusClient.WriteMultipleRegisters(StartAddress, WriteVals)
        End Select
    End Sub
    Private Sub WriteHelperFloat(RegType As Integer, Value As String, StartAddress As Integer)
        Select Case RegType
            Case 3
                If StartAddress > 40000 Then StartAddress = StartAddress - 40000
                modbusClient.WriteMultipleRegisters(StartAddress, ConvertFloat2DW(Value))
        End Select
    End Sub
    Private Function ConvertFloat2DW(fval As Single) As Integer()
        Dim byVals As Byte() = BitConverter.GetBytes(fval)
        If (BitConverter.IsLittleEndian) Then Array.Reverse(byVals)
        Dim bytes1(2) As Byte
        bytes1(0) = byVals(1)
        bytes1(1) = byVals(0)
        Dim int1 As Short = BitConverter.ToInt16(bytes1, 0)
        Dim bytes2(2) As Byte
        bytes2(0) = byVals(3)
        bytes2(1) = byVals(2)
        Dim int2 As Short = BitConverter.ToInt16(bytes2, 0)
        Dim values_(2) As Short
        values_(0) = int2
        values_(1) = int1
        Dim values(2) As Integer
        values(0) = values_(0)
        values(1) = values_(1)
        Return values
    End Function
    Public Sub WriteData(RegType As Integer, StartAddress As Integer, Value As String)
        Try
            WriteHelper(RegType, Value, StartAddress)
        Catch ex As Exception
            MsgBox("Modbus Error Write! " & ex.Message)
        End Try
    End Sub
    Public Sub WriteDataFloat(RegType As Integer, StartAddress As Integer, Value As String)
        Try
            WriteHelperFloat(RegType, Value, StartAddress)
        Catch ex As Exception
            MsgBox("Modbus Error Write! " & ex.Message)
        End Try
    End Sub
End Class
