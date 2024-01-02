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
            MODBUS_ERR = True
            'MsgBox("Modbus Error Connect! " & ex.Message)
            'End
            Return False
        End Try
    End Function
    Public Function ClosePort() As Boolean
        Try
            modbusClient.Disconnect()
            Return True
        Catch ex As Exception
            MODBUS_ERR = True
            'MsgBox("Modbus Error Disconnect! " & ex.Message)
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
            ' Code for reading coils
            Case 1
            ' Code for reading discrete inputs
            Case 2
            ' Code for reading input registers
            Case 3
                If StartAddress > 40000 Then StartAddress = StartAddress - 40000
                Dim vals() As Integer = modbusClient.ReadHoldingRegisters(StartAddress, 2)
                'Console.WriteLine(vals(0).ToString + " " + vals(1).ToString)
                ReadValue = ConvertDW2Float(CShort(vals(0)), CShort(vals(1)))
        End Select
    End Sub

    Private Function ConvertDW2Float(reg1 As Short, reg2 As Short) As Single
        Dim bytes(3) As Byte
        Dim intBytes1 As Byte() = BitConverter.GetBytes(reg2)
        Dim intBytes2 As Byte() = BitConverter.GetBytes(reg1)

        ' Assuming Float Swap format (swapping the two 16-bit registers)
        bytes(0) = intBytes2(0)
        bytes(1) = intBytes2(1)
        bytes(2) = intBytes1(0)
        bytes(3) = intBytes1(1)

        Dim result As Single = BitConverter.ToSingle(bytes, 0)
        'Console.WriteLine(result)
        Return result
    End Function


    Public Function ReadData(RegType As String, Address As Integer) As Integer
        Try
            ReadHelper(Address, RegType)
        Catch ex As Exception
            'MsgBox("Modbus Error Read! " & ex.Message)
            MODBUS_ERR = True
            If frmMain.btn_connect_plc.Text = "Disconnect" Then
                frmMain.btn_connect_plc.PerformClick()
            End If
        End Try
        Return CInt(ReadValue)
    End Function
    Public Function ReadDataFloat(RegType As String, Address As Integer) As String
        Try
            ReadHelperFloat(Address, RegType)
        Catch ex As Exception
            'MsgBox("Modbus Error Read! " & ex.Message)
            MODBUS_ERR = True
            If frmMain.btn_connect_plc.Text = "Disconnect" Then
                frmMain.btn_connect_plc.PerformClick()
            End If
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

    Private Sub WriteHelperFloat(RegType As Integer, Value As Single, StartAddress As Integer)
        Select Case RegType
            Case 3
                If StartAddress > 40000 Then StartAddress = StartAddress - 40000
                Dim values() As Integer = ConvertFloat2DW(Value)
                modbusClient.WriteMultipleRegisters(StartAddress, values)
        End Select
    End Sub

    Private Function ConvertFloat2DW(fval As Single) As Integer()
        Dim byVals As Byte() = BitConverter.GetBytes(fval)

        ' Swap the byte order for "Float Swap" format
        Dim bytes(3) As Byte
        bytes(0) = byVals(2)
        bytes(1) = byVals(3)
        bytes(2) = byVals(0)
        bytes(3) = byVals(1)

        ' Convert to Short array for Modbus WriteMultipleRegisters
        Dim values(1) As Short
        values(0) = BitConverter.ToInt16(bytes, 0)
        values(1) = BitConverter.ToInt16(bytes, 2)

        ' Convert to Integer array for Modbus WriteMultipleRegisters
        Dim result(1) As Integer
        result(0) = values(1)
        result(1) = values(0)

        Return result
    End Function


    Public Sub WriteData(RegType As Integer, StartAddress As Integer, Value As String)
        Try
            WriteHelper(RegType, Value, StartAddress)
        Catch ex As Exception
            MODBUS_ERR = True
            'MsgBox("Modbus Error Write! " & ex.Message)
            If frmMain.btn_connect_plc.Text = "Disconnect" Then
                frmMain.btn_connect_plc.PerformClick()
            End If
        End Try
    End Sub
    Public Sub WriteDataFloat(RegType As Integer, StartAddress As Integer, Value As String)
        Try
            WriteHelperFloat(RegType, Value, StartAddress)
        Catch ex As Exception
            MODBUS_ERR = True
            'MsgBox("Modbus Error Write! " & ex.Message)
            If frmMain.btn_connect_plc.Text = "Disconnect" Then
                frmMain.btn_connect_plc.PerformClick()
            End If
        End Try
    End Sub
End Class
