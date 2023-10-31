﻿Imports System.Threading
Imports System.Data.SqlClient
Public Class frmMain
    Dim Modbus = New Modbus()
    Dim ThreadLoadFrm As Thread

    Dim AssyBuff As String
    Dim ManualState As Boolean
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initLoadingBar()
        btn_connect.PerformClick()
        Hide()
        UpdateLoadingBar(20, "Connecting to PLC...")
        Thread.Sleep(500)

        GetPCStatus(100) 'Software is open
        ShowPanelGeneral("home")
        ShowButtonSTN(0)
        ShowPanelManual("None")
        UpdateLoadingBar(40, "Loading...")
        Thread.Sleep(500)

        'BarcodeComm.Open()
        ST2.Enabled = True
        ST3.Enabled = True
        ST4.Enabled = True
        ST5.Enabled = True
        Status.Enabled = True
        UpdateLoadingBar(60, "Creating Multithreading...")
        Thread.Sleep(500)

        UpdateLoadingBar(100, "Load App GUI")
        Thread.Sleep(500)
        CloseLoadForm()
        Show()
    End Sub
    'Loading Bar
    Private Sub initLoadingBar()
        ThreadLoadFrm = New Thread(New ThreadStart(AddressOf ProcessLoad))
        ThreadLoadFrm.Start()
    End Sub
    Private Sub UpdateLoadingBar(value As Integer, msg As String)
        LOAD_VAL = value
        LOAD_MSG = msg
    End Sub
    Private Sub ProcessLoad()
        Do
            frmLoadingBar.ShowDialog()
        Loop
    End Sub

    Private Sub CloseLoadForm()
        ThreadLoadFrm.Abort()
    End Sub

    Private Sub GetPCStatus(state As Integer)
        Select Case state
            Case 100
                WriteToModbus(REGISTER_TYPE, ADDR_PC_STATUS, 1)
                ind_software_open.BackColor = Color.Lime
                ind_software_run.BackColor = Color.Red
                ind_software_stop.BackColor = Color.Red
            Case 110
                WriteToModbus(REGISTER_TYPE, ADDR_PC_STATUS, 3)
                ind_software_open.BackColor = Color.Lime
                ind_software_run.BackColor = Color.Lime
                ind_software_stop.BackColor = Color.Red
            Case 101
                WriteToModbus(REGISTER_TYPE, ADDR_PC_STATUS, 5)
                ind_software_open.BackColor = Color.Lime
                ind_software_run.BackColor = Color.Red
                ind_software_stop.BackColor = Color.Lime
        End Select
    End Sub
    Private Sub dateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lbl_date.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    'Button General
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        ShowPanelGeneral("home")
        GetPCStatus(110)
    End Sub
    Private Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click
        ShowPanelGeneral("manual")
        GetPCStatus(101)
    End Sub
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        ShowPanelGeneral("setting")
    End Sub
    Private Sub btn_monitoring_Click(sender As Object, e As EventArgs) Handles btn_monitoring.Click
        ShowPanelGeneral("monitoring")
    End Sub
    Private Sub btn_alarm_Click(sender As Object, e As EventArgs) Handles btn_alarm.Click
        ShowPanelGeneral("alarm")
    End Sub

    'Show Panel General
    Private Sub ShowPanelGeneral(mode As String)
        ShowPanelManual("None")

        If mode = "home" Then
            pnl_home.Visible = True
        Else
            pnl_home.Visible = False
        End If

        If mode = "monitoring" Or mode = "manual" Then
            ShowButtonSTN(1)
            If mode = "manual" Then
                ManualState = True
            Else
                ManualState = False
            End If
        Else
            ShowButtonSTN(0)
        End If

        If mode = "setting" Then
            pnl_setting.Visible = True
        Else
            pnl_setting.Visible = False
        End If

        If mode = "alarm" Then
            pnl_alarm.Visible = True
        Else
            pnl_alarm.Visible = False
        End If
    End Sub

    'Show Button STN
    Private Sub ShowButtonSTN(mode As Integer)
        If mode = 1 Then
            btn_stn1.Enabled = True
            btn_stn2.Enabled = True
            btn_stn3.Enabled = True
            btn_stn4.Enabled = True
            btn_stn5.Enabled = True
            btn_stn6.Enabled = True
        Else
            btn_stn1.Enabled = False
            btn_stn2.Enabled = False
            btn_stn3.Enabled = False
            btn_stn4.Enabled = False
            btn_stn5.Enabled = False
            btn_stn6.Enabled = False
        End If
    End Sub

    'Panel Setting
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        If btn_connect.Text = "Connect" Then
            If Modbus.OpenPort(txtIP.Text, txtPort.Text) Then
                btn_connect.Text = "Disconnect"
                connect_ind.Image = My.Resources.led_green_on
                ModbusRW.Enabled = True
            End If
        ElseIf btn_connect.Text = "Disconnect" Then
            If Modbus.ClosePort() Then
                btn_connect.Text = "Connect"
                connect_ind.Image = My.Resources.led_red_on
                ind_plc_status.BackColor = Color.Red
                ModbusRW.Enabled = False
            End If
        End If
    End Sub
    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        If cbo_data_type.Text = "FLOAT" Then
            txtValue.Text = ReadFromModbusFloat(REGISTER_TYPE, txtAddress.Text)
        ElseIf cbo_data_type.Text = "INT" Then
            txtValue.Text = ReadFromModbus(REGISTER_TYPE, txtAddress.Text)
        End If
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        If cbo_data_type.Text = "FLOAT" Then
            WriteToModbusFloat(REGISTER_TYPE, Val(txtAddress.Text), Single.Parse(txtValue.Text))
        ElseIf cbo_data_type.Text = "INT" Then
            WriteToModbus(REGISTER_TYPE, Val(txtAddress.Text), txtValue.Text)
        End If
    End Sub

    'Show Panel Manual
    Private Sub ShowPanelManual(mode As String)
        If mode = "STN1" Then
            If ManualState Then
                pnl_man_stn1.Visible = True
            Else
                pnl_mon_stn1.Visible = True
            End If
        Else
            pnl_man_stn1.Visible = False
            pnl_mon_stn1.Visible = False
        End If

        If mode = "STN2" Then
            If ManualState Then
                pnl_man_stn2.Visible = True
            Else
                pnl_mon_stn2.Visible = True
            End If
        Else
            pnl_man_stn2.Visible = False
            pnl_mon_stn2.Visible = False
        End If

        If mode = "STN3" Then
            If ManualState Then
                pnl_man_stn3.Visible = True
            Else
                pnl_mon_stn3.Visible = True
            End If
        Else
            pnl_man_stn3.Visible = False
            pnl_mon_stn3.Visible = False
        End If

        If mode = "STN4" Then
            If ManualState Then
                pnl_man_stn4.Visible = True
            Else
                pnl_mon_stn4.Visible = True
            End If
        Else
            pnl_man_stn4.Visible = False
            pnl_mon_stn4.Visible = False
        End If

        If mode = "STN5" Then
            If ManualState Then
                pnl_man_stn5.Visible = True
            Else
                pnl_mon_stn5.Visible = True
            End If
        Else
            pnl_man_stn5.Visible = False
            pnl_mon_stn5.Visible = False
        End If

        If mode = "STN6" Then
            If ManualState Then
                pnl_man_stn6.Visible = True
            Else
                pnl_mon_stn6.Visible = True
            End If
        Else
            pnl_man_stn6.Visible = False
            pnl_mon_stn6.Visible = False
        End If
    End Sub

    'pnl_manual
    Private Sub btn_stn1_Click(sender As Object, e As EventArgs) Handles btn_stn1.Click
        ShowPanelManual("STN1")
    End Sub

    Private Sub btn_stn2_Click(sender As Object, e As EventArgs) Handles btn_stn2.Click
        ShowPanelManual("STN2")
    End Sub

    Private Sub btn_stn3_Click(sender As Object, e As EventArgs) Handles btn_stn3.Click
        ShowPanelManual("STN3")
    End Sub

    Private Sub btn_stn4_Click(sender As Object, e As EventArgs) Handles btn_stn4.Click
        ShowPanelManual("STN4")
    End Sub

    Private Sub btn_stn5_Click(sender As Object, e As EventArgs) Handles btn_stn5.Click
        ShowPanelManual("STN5")
    End Sub

    Private Sub btn_stn6_Click(sender As Object, e As EventArgs) Handles btn_stn6.Click
        ShowPanelManual("STN6")
    End Sub

    'Modbus Read Write
    Private Sub WriteToModbus(RegType As Integer, Address As Integer, Value As String)
        Try
            Modbus.WriteData(RegType, Address, Value)
        Catch ex As Exception
            MsgBox("Modbus Error Write! " & ex.Message)
        End Try
    End Sub

    Private Sub WriteToModbusFloat(RegType As Integer, Address As Integer, Value As String)
        Try
            Modbus.WriteDataFloat(RegType, Address, Single.Parse(Value))
        Catch ex As Exception
            MsgBox("Modbus Error Write! " & ex.Message)
        End Try
    End Sub

    Private Function ReadFromModbus(RegType As Integer, Address As Integer) As Integer
        Dim temp As Integer
        Try
            temp = Modbus.ReadData(RegType, Address)
            Return temp
        Catch ex As Exception
            MsgBox("Modbus Error Read! " & ex.Message)
            End
        End Try
    End Function
    Private Function ReadFromModbusFloat(RegType As Integer, Address As Integer) As String
        Dim temp As String
        Try
            temp = Modbus.ReadDataFloat(RegType, Address)
            Return temp
        Catch ex As Exception
            MsgBox("Modbus Error Read! " & ex.Message)
            End
        End Try
    End Function

    'Button Manual Station 'button manual stn1
    Private Sub btn_stn1_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl1_fw.Click
        If btn_stn1_cyl1_bw.Text = "Is Backward" Then
            btn_stn1_cyl1_bw.PerformClick()
        End If

        If btn_stn1_cyl1_fw.Text = "Forward" Then
            STN1_CYL1 = FORWARD
            btn_stn1_cyl1_fw.Image = My.Resources.button_white
            btn_stn1_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn1_cyl1_fw.Text = "Is Forward" Then
            STN1_CYL1 = IDLE
            btn_stn1_cyl1_fw.Image = My.Resources.button_silver
            btn_stn1_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn1_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl1_bw.Click
        If btn_stn1_cyl1_fw.Text = "Is Forward" Then
            btn_stn1_cyl1_fw.PerformClick()
        End If

        If btn_stn1_cyl1_bw.Text = "Backward" Then
            STN1_CYL1 = BACKWARD
            btn_stn1_cyl1_bw.Image = My.Resources.button_white
            btn_stn1_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn1_cyl1_bw.Text = "Is Backward" Then
            STN1_CYL1 = IDLE
            btn_stn1_cyl1_bw.Image = My.Resources.button_silver
            btn_stn1_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn1_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl2_fw.Click
        If btn_stn1_cyl2_bw.Text = "Is Backward" Then
            btn_stn1_cyl2_bw.PerformClick()
        End If

        If btn_stn1_cyl2_fw.Text = "Forward" Then
            STN1_CYL2 = FORWARD
            btn_stn1_cyl2_fw.Image = My.Resources.button_white
            btn_stn1_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn1_cyl2_fw.Text = "Is Forward" Then
            STN1_CYL2 = IDLE
            btn_stn1_cyl2_fw.Image = My.Resources.button_silver
            btn_stn1_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn1_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl2_bw.Click
        If btn_stn1_cyl2_fw.Text = "Is Forward" Then
            btn_stn1_cyl2_fw.PerformClick()
        End If

        If btn_stn1_cyl2_bw.Text = "Backward" Then
            STN1_CYL2 = BACKWARD
            btn_stn1_cyl2_bw.Image = My.Resources.button_white
            btn_stn1_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn1_cyl2_bw.Text = "Is Backward" Then
            STN1_CYL2 = IDLE
            btn_stn1_cyl2_bw.Image = My.Resources.button_silver
            btn_stn1_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn1_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl3_fw.Click
        If btn_stn1_cyl3_bw.Text = "Is Backward" Then
            btn_stn1_cyl3_bw.PerformClick()
        End If

        If btn_stn1_cyl3_fw.Text = "Forward" Then
            STN1_CYL3 = FORWARD
            btn_stn1_cyl3_fw.Image = My.Resources.button_white
            btn_stn1_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn1_cyl3_fw.Text = "Is Forward" Then
            STN1_CYL3 = IDLE
            btn_stn1_cyl3_fw.Image = My.Resources.button_silver
            btn_stn1_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn1_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl3_bw.Click
        If btn_stn1_cyl3_fw.Text = "Is Forward" Then
            btn_stn1_cyl3_fw.PerformClick()
        End If

        If btn_stn1_cyl3_bw.Text = "Backward" Then
            STN1_CYL3 = BACKWARD
            btn_stn1_cyl3_bw.Image = My.Resources.button_white
            btn_stn1_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn1_cyl3_bw.Text = "Is Backward" Then
            STN1_CYL3 = IDLE
            btn_stn1_cyl3_bw.Image = My.Resources.button_silver
            btn_stn1_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn1_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl4_fw.Click
        If btn_stn1_cyl4_bw.Text = "Is Backward" Then
            btn_stn1_cyl4_bw.PerformClick()
        End If

        If btn_stn1_cyl4_fw.Text = "Forward" Then
            STN1_CYL4 = FORWARD
            btn_stn1_cyl4_fw.Image = My.Resources.button_white
            btn_stn1_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn1_cyl4_fw.Text = "Is Forward" Then
            STN1_CYL4 = IDLE
            btn_stn1_cyl4_fw.Image = My.Resources.button_silver
            btn_stn1_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn1_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl4_bw.Click
        If btn_stn1_cyl4_fw.Text = "Is Forward" Then
            btn_stn1_cyl4_fw.PerformClick()
        End If

        If btn_stn1_cyl4_bw.Text = "Backward" Then
            STN1_CYL4 = BACKWARD
            btn_stn1_cyl4_bw.Image = My.Resources.button_white
            btn_stn1_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn1_cyl4_bw.Text = "Is Backward" Then
            STN1_CYL4 = IDLE
            btn_stn1_cyl4_bw.Image = My.Resources.button_silver
            btn_stn1_cyl4_bw.Text = "Backward"
        End If
    End Sub

    'button manual stn2
    Private Sub btn_stn2_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl1_fw.Click
        If btn_stn2_cyl1_bw.Text = "Is Backward" Then
            btn_stn2_cyl1_bw.PerformClick()
        End If

        If btn_stn2_cyl1_fw.Text = "Forward" Then
            STN2_CYL1 = FORWARD
            btn_stn2_cyl1_fw.Image = My.Resources.button_white
            btn_stn2_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn2_cyl1_fw.Text = "Is Forward" Then
            STN2_CYL1 = IDLE
            btn_stn2_cyl1_fw.Image = My.Resources.button_silver
            btn_stn2_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn2_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl1_bw.Click
        If btn_stn2_cyl1_fw.Text = "Is Forward" Then
            btn_stn2_cyl1_fw.PerformClick()
        End If

        If btn_stn2_cyl1_bw.Text = "Backward" Then
            STN2_CYL1 = BACKWARD
            btn_stn2_cyl1_bw.Image = My.Resources.button_white
            btn_stn2_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn2_cyl1_bw.Text = "Is Backward" Then
            STN2_CYL1 = IDLE
            btn_stn2_cyl1_bw.Image = My.Resources.button_silver
            btn_stn2_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn2_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl2_fw.Click
        If btn_stn2_cyl2_bw.Text = "Is Backward" Then
            btn_stn2_cyl2_bw.PerformClick()
        End If

        If btn_stn2_cyl2_fw.Text = "Forward" Then
            STN2_CYL2 = FORWARD
            btn_stn2_cyl2_fw.Image = My.Resources.button_white
            btn_stn2_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn2_cyl2_fw.Text = "Is Forward" Then
            STN2_CYL2 = IDLE
            btn_stn2_cyl2_fw.Image = My.Resources.button_silver
            btn_stn2_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn2_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl2_bw.Click
        If btn_stn2_cyl2_fw.Text = "Is Forward" Then
            btn_stn2_cyl2_fw.PerformClick()
        End If

        If btn_stn2_cyl2_bw.Text = "Backward" Then
            STN2_CYL2 = BACKWARD
            btn_stn2_cyl2_bw.Image = My.Resources.button_white
            btn_stn2_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn2_cyl2_bw.Text = "Is Backward" Then
            STN2_CYL2 = IDLE
            btn_stn2_cyl2_bw.Image = My.Resources.button_silver
            btn_stn2_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn2_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl3_fw.Click
        If btn_stn2_cyl3_bw.Text = "Is Backward" Then
            btn_stn2_cyl3_bw.PerformClick()
        End If

        If btn_stn2_cyl3_fw.Text = "Forward" Then
            STN2_CYL3 = FORWARD
            btn_stn2_cyl3_fw.Image = My.Resources.button_white
            btn_stn2_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn2_cyl3_fw.Text = "Is Forward" Then
            STN2_CYL3 = IDLE
            btn_stn2_cyl3_fw.Image = My.Resources.button_silver
            btn_stn2_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn2_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl3_bw.Click
        If btn_stn2_cyl3_fw.Text = "Is Forward" Then
            btn_stn2_cyl3_fw.PerformClick()
        End If

        If btn_stn2_cyl3_bw.Text = "Backward" Then
            STN2_CYL3 = BACKWARD
            btn_stn2_cyl3_bw.Image = My.Resources.button_white
            btn_stn2_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn2_cyl3_bw.Text = "Is Backward" Then
            STN2_CYL3 = IDLE
            btn_stn2_cyl3_bw.Image = My.Resources.button_silver
            btn_stn2_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn2_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl4_fw.Click
        If btn_stn2_cyl4_bw.Text = "Is Backward" Then
            btn_stn2_cyl4_bw.PerformClick()
        End If

        If btn_stn2_cyl4_fw.Text = "Forward" Then
            STN2_CYL4 = FORWARD
            btn_stn2_cyl4_fw.Image = My.Resources.button_white
            btn_stn2_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn2_cyl4_fw.Text = "Is Forward" Then
            STN2_CYL4 = IDLE
            btn_stn2_cyl4_fw.Image = My.Resources.button_silver
            btn_stn2_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn2_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn2_cyl4_bw.Click
        If btn_stn2_cyl4_fw.Text = "Is Forward" Then
            btn_stn2_cyl4_fw.PerformClick()
        End If

        If btn_stn2_cyl4_bw.Text = "Backward" Then
            STN2_CYL4 = BACKWARD
            btn_stn2_cyl4_bw.Image = My.Resources.button_white
            btn_stn2_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn2_cyl4_bw.Text = "Is Backward" Then
            STN2_CYL4 = IDLE
            btn_stn2_cyl4_bw.Image = My.Resources.button_silver
            btn_stn2_cyl4_bw.Text = "Backward"
        End If
    End Sub

    'button manual stn3
    Private Sub btn_stn3_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl1_fw.Click
        If btn_stn3_cyl1_bw.Text = "Is Backward" Then
            btn_stn3_cyl1_bw.PerformClick()
        End If

        If btn_stn3_cyl1_fw.Text = "Forward" Then
            STN3_CYL1 = FORWARD
            btn_stn3_cyl1_fw.Image = My.Resources.button_white
            btn_stn3_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl1_fw.Text = "Is Forward" Then
            STN3_CYL1 = IDLE
            btn_stn3_cyl1_fw.Image = My.Resources.button_silver
            btn_stn3_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl1_bw.Click
        If btn_stn3_cyl1_fw.Text = "Is Forward" Then
            btn_stn3_cyl1_fw.PerformClick()
        End If

        If btn_stn3_cyl1_bw.Text = "Backward" Then
            STN3_CYL1 = BACKWARD
            btn_stn3_cyl1_bw.Image = My.Resources.button_white
            btn_stn3_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl1_bw.Text = "Is Backward" Then
            STN3_CYL1 = IDLE
            btn_stn3_cyl1_bw.Image = My.Resources.button_silver
            btn_stn3_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn3_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl2_fw.Click
        If btn_stn3_cyl2_bw.Text = "Is Backward" Then
            btn_stn3_cyl2_bw.PerformClick()
        End If

        If btn_stn3_cyl2_fw.Text = "Forward" Then
            STN3_CYL2 = FORWARD
            btn_stn3_cyl2_fw.Image = My.Resources.button_white
            btn_stn3_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl2_fw.Text = "Is Forward" Then
            STN3_CYL2 = IDLE
            btn_stn3_cyl2_fw.Image = My.Resources.button_silver
            btn_stn3_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl2_bw.Click
        If btn_stn3_cyl2_fw.Text = "Is Forward" Then
            btn_stn3_cyl2_fw.PerformClick()
        End If

        If btn_stn3_cyl2_bw.Text = "Backward" Then
            STN3_CYL2 = BACKWARD
            btn_stn3_cyl2_bw.Image = My.Resources.button_white
            btn_stn3_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl2_bw.Text = "Is Backward" Then
            STN3_CYL2 = IDLE
            btn_stn3_cyl2_bw.Image = My.Resources.button_silver
            btn_stn3_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn3_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl3_fw.Click
        If btn_stn3_cyl3_bw.Text = "Is Backward" Then
            btn_stn3_cyl3_bw.PerformClick()
        End If

        If btn_stn3_cyl3_fw.Text = "Forward" Then
            STN3_CYL3 = FORWARD
            btn_stn3_cyl3_fw.Image = My.Resources.button_white
            btn_stn3_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl3_fw.Text = "Is Forward" Then
            STN3_CYL3 = IDLE
            btn_stn3_cyl3_fw.Image = My.Resources.button_silver
            btn_stn3_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl3_bw.Click
        If btn_stn3_cyl3_fw.Text = "Is Forward" Then
            btn_stn3_cyl3_fw.PerformClick()
        End If

        If btn_stn3_cyl3_bw.Text = "Backward" Then
            STN3_CYL3 = BACKWARD
            btn_stn3_cyl3_bw.Image = My.Resources.button_white
            btn_stn3_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl3_bw.Text = "Is Backward" Then
            STN3_CYL3 = IDLE
            btn_stn3_cyl3_bw.Image = My.Resources.button_silver
            btn_stn3_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn3_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl4_fw.Click
        If btn_stn3_cyl4_bw.Text = "Is Backward" Then
            btn_stn3_cyl4_bw.PerformClick()
        End If

        If btn_stn3_cyl4_fw.Text = "Forward" Then
            STN3_CYL4 = FORWARD
            btn_stn3_cyl4_fw.Image = My.Resources.button_white
            btn_stn3_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl4_fw.Text = "Is Forward" Then
            STN3_CYL4 = IDLE
            btn_stn3_cyl4_fw.Image = My.Resources.button_silver
            btn_stn3_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl4_bw.Click
        If btn_stn3_cyl4_fw.Text = "Is Forward" Then
            btn_stn3_cyl4_fw.PerformClick()
        End If

        If btn_stn3_cyl4_bw.Text = "Backward" Then
            STN3_CYL4 = BACKWARD
            btn_stn3_cyl4_bw.Image = My.Resources.button_white
            btn_stn3_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl4_bw.Text = "Is Backward" Then
            STN3_CYL4 = IDLE
            btn_stn3_cyl4_bw.Image = My.Resources.button_silver
            btn_stn3_cyl4_bw.Text = "Backward"
        End If
    End Sub

    'button manual stn4
    Private Sub btn_stn4_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl1_fw.Click
        If btn_stn4_cyl1_bw.Text = "Is Backward" Then
            btn_stn4_cyl1_bw.PerformClick()
        End If

        If btn_stn4_cyl1_fw.Text = "Forward" Then
            STN4_CYL1 = FORWARD
            btn_stn4_cyl1_fw.Image = My.Resources.button_white
            btn_stn4_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn4_cyl1_fw.Text = "Is Forward" Then
            STN4_CYL1 = IDLE
            btn_stn4_cyl1_fw.Image = My.Resources.button_silver
            btn_stn4_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn4_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl1_bw.Click
        If btn_stn4_cyl1_fw.Text = "Is Forward" Then
            btn_stn4_cyl1_fw.PerformClick()
        End If

        If btn_stn4_cyl1_bw.Text = "Backward" Then
            STN4_CYL1 = BACKWARD
            btn_stn4_cyl1_bw.Image = My.Resources.button_white
            btn_stn4_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn4_cyl1_bw.Text = "Is Backward" Then
            STN4_CYL1 = IDLE
            btn_stn4_cyl1_bw.Image = My.Resources.button_silver
            btn_stn4_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn4_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl2_fw.Click
        If btn_stn4_cyl2_bw.Text = "Is Backward" Then
            btn_stn4_cyl2_bw.PerformClick()
        End If

        If btn_stn4_cyl2_fw.Text = "Forward" Then
            STN4_CYL2 = FORWARD
            btn_stn4_cyl2_fw.Image = My.Resources.button_white
            btn_stn4_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn4_cyl2_fw.Text = "Is Forward" Then
            STN4_CYL2 = IDLE
            btn_stn4_cyl2_fw.Image = My.Resources.button_silver
            btn_stn4_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn4_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl2_bw.Click
        If btn_stn4_cyl2_fw.Text = "Is Forward" Then
            btn_stn4_cyl2_fw.PerformClick()
        End If

        If btn_stn4_cyl2_bw.Text = "Backward" Then
            STN4_CYL2 = BACKWARD
            btn_stn4_cyl2_bw.Image = My.Resources.button_white
            btn_stn4_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn4_cyl2_bw.Text = "Is Backward" Then
            STN4_CYL2 = IDLE
            btn_stn4_cyl2_bw.Image = My.Resources.button_silver
            btn_stn4_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn4_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl3_fw.Click
        If btn_stn4_cyl3_bw.Text = "Is Backward" Then
            btn_stn4_cyl3_bw.PerformClick()
        End If

        If btn_stn4_cyl3_fw.Text = "Forward" Then
            STN4_CYL3 = FORWARD
            btn_stn4_cyl3_fw.Image = My.Resources.button_white
            btn_stn4_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn4_cyl3_fw.Text = "Is Forward" Then
            STN4_CYL3 = IDLE
            btn_stn4_cyl3_fw.Image = My.Resources.button_silver
            btn_stn4_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn4_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl3_bw.Click
        If btn_stn4_cyl3_fw.Text = "Is Forward" Then
            btn_stn4_cyl3_fw.PerformClick()
        End If

        If btn_stn4_cyl3_bw.Text = "Backward" Then
            STN4_CYL3 = BACKWARD
            btn_stn4_cyl3_bw.Image = My.Resources.button_white
            btn_stn4_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn4_cyl3_bw.Text = "Is Backward" Then
            STN4_CYL3 = IDLE
            btn_stn4_cyl3_bw.Image = My.Resources.button_silver
            btn_stn4_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn4_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl4_fw.Click
        If btn_stn4_cyl4_bw.Text = "Is Backward" Then
            btn_stn4_cyl4_bw.PerformClick()
        End If

        If btn_stn4_cyl4_fw.Text = "Forward" Then
            STN4_CYL4 = FORWARD
            btn_stn4_cyl4_fw.Image = My.Resources.button_white
            btn_stn4_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn4_cyl4_fw.Text = "Is Forward" Then
            STN4_CYL4 = IDLE
            btn_stn4_cyl4_fw.Image = My.Resources.button_silver
            btn_stn4_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn4_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl4_bw.Click
        If btn_stn4_cyl4_fw.Text = "Is Forward" Then
            btn_stn4_cyl4_fw.PerformClick()
        End If

        If btn_stn4_cyl4_bw.Text = "Backward" Then
            STN4_CYL4 = BACKWARD
            btn_stn4_cyl4_bw.Image = My.Resources.button_white
            btn_stn4_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn4_cyl4_bw.Text = "Is Backward" Then
            STN4_CYL4 = IDLE
            btn_stn4_cyl4_bw.Image = My.Resources.button_silver
            btn_stn4_cyl4_bw.Text = "Backward"
        End If
    End Sub

    'button manual stn5
    Private Sub btn_stn5_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl1_fw.Click
        If btn_stn5_cyl1_bw.Text = "Is Backward" Then
            btn_stn5_cyl1_bw.PerformClick()
        End If

        If btn_stn5_cyl1_fw.Text = "Forward" Then
            STN5_CYL1 = FORWARD
            btn_stn5_cyl1_fw.Image = My.Resources.button_white
            btn_stn5_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl1_fw.Text = "Is Forward" Then
            STN5_CYL1 = IDLE
            btn_stn5_cyl1_fw.Image = My.Resources.button_silver
            btn_stn5_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl1_bw.Click
        If btn_stn5_cyl1_fw.Text = "Is Forward" Then
            btn_stn5_cyl1_fw.PerformClick()
        End If

        If btn_stn5_cyl1_bw.Text = "Backward" Then
            STN5_CYL1 = BACKWARD
            btn_stn5_cyl1_bw.Image = My.Resources.button_white
            btn_stn5_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl1_bw.Text = "Is Backward" Then
            STN5_CYL1 = IDLE
            btn_stn5_cyl1_bw.Image = My.Resources.button_silver
            btn_stn5_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn5_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl2_fw.Click
        If btn_stn5_cyl2_bw.Text = "Is Backward" Then
            btn_stn5_cyl2_bw.PerformClick()
        End If

        If btn_stn5_cyl2_fw.Text = "Forward" Then
            STN5_CYL2 = FORWARD
            btn_stn5_cyl2_fw.Image = My.Resources.button_white
            btn_stn5_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl2_fw.Text = "Is Forward" Then
            STN5_CYL2 = IDLE
            btn_stn5_cyl2_fw.Image = My.Resources.button_silver
            btn_stn5_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl2_bw.Click
        If btn_stn5_cyl2_fw.Text = "Is Forward" Then
            btn_stn5_cyl2_fw.PerformClick()
        End If

        If btn_stn5_cyl2_bw.Text = "Backward" Then
            STN5_CYL2 = BACKWARD
            btn_stn5_cyl2_bw.Image = My.Resources.button_white
            btn_stn5_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl2_bw.Text = "Is Backward" Then
            STN5_CYL2 = IDLE
            btn_stn5_cyl2_bw.Image = My.Resources.button_silver
            btn_stn5_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn5_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl3_fw.Click
        If btn_stn5_cyl3_bw.Text = "Is Backward" Then
            btn_stn5_cyl3_bw.PerformClick()
        End If

        If btn_stn5_cyl3_fw.Text = "Forward" Then
            STN5_CYL3 = FORWARD
            btn_stn5_cyl3_fw.Image = My.Resources.button_white
            btn_stn5_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl3_fw.Text = "Is Forward" Then
            STN5_CYL3 = IDLE
            btn_stn5_cyl3_fw.Image = My.Resources.button_silver
            btn_stn5_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl3_bw.Click
        If btn_stn5_cyl3_fw.Text = "Is Forward" Then
            btn_stn5_cyl3_fw.PerformClick()
        End If

        If btn_stn5_cyl3_bw.Text = "Backward" Then
            STN5_CYL3 = BACKWARD
            btn_stn5_cyl3_bw.Image = My.Resources.button_white
            btn_stn5_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl3_bw.Text = "Is Backward" Then
            STN5_CYL3 = IDLE
            btn_stn5_cyl3_bw.Image = My.Resources.button_silver
            btn_stn5_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn5_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl4_fw.Click
        If btn_stn5_cyl4_bw.Text = "Is Backward" Then
            btn_stn5_cyl4_bw.PerformClick()
        End If

        If btn_stn5_cyl4_fw.Text = "Forward" Then
            STN5_CYL4 = FORWARD
            btn_stn5_cyl4_fw.Image = My.Resources.button_white
            btn_stn5_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl4_fw.Text = "Is Forward" Then
            STN5_CYL4 = IDLE
            btn_stn5_cyl4_fw.Image = My.Resources.button_silver
            btn_stn5_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl4_bw.Click
        If btn_stn5_cyl4_fw.Text = "Is Forward" Then
            btn_stn5_cyl4_fw.PerformClick()
        End If

        If btn_stn5_cyl4_bw.Text = "Backward" Then
            STN5_CYL4 = BACKWARD
            btn_stn5_cyl4_bw.Image = My.Resources.button_white
            btn_stn5_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl4_bw.Text = "Is Backward" Then
            STN5_CYL4 = IDLE
            btn_stn5_cyl4_bw.Image = My.Resources.button_silver
            btn_stn5_cyl4_bw.Text = "Backward"
        End If
    End Sub

    'button manual stn6
    Private Sub btn_stn6_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl1_fw.Click
        If btn_stn6_cyl1_bw.Text = "Is Backward" Then
            btn_stn6_cyl1_bw.PerformClick()
        End If

        If btn_stn6_cyl1_fw.Text = "Forward" Then
            STN6_CYL1 = FORWARD
            btn_stn6_cyl1_fw.Image = My.Resources.button_white
            btn_stn6_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl1_fw.Text = "Is Forward" Then
            STN6_CYL1 = IDLE
            btn_stn6_cyl1_fw.Image = My.Resources.button_silver
            btn_stn6_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl1_bw.Click
        If btn_stn6_cyl1_fw.Text = "Is Forward" Then
            btn_stn6_cyl1_fw.PerformClick()
        End If

        If btn_stn6_cyl1_bw.Text = "Backward" Then
            STN6_CYL1 = BACKWARD
            btn_stn6_cyl1_bw.Image = My.Resources.button_white
            btn_stn6_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl1_bw.Text = "Is Backward" Then
            STN6_CYL1 = IDLE
            btn_stn6_cyl1_bw.Image = My.Resources.button_silver
            btn_stn6_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl2_fw.Click
        If btn_stn6_cyl2_bw.Text = "Is Backward" Then
            btn_stn6_cyl2_bw.PerformClick()
        End If

        If btn_stn6_cyl2_fw.Text = "Forward" Then
            STN6_CYL2 = FORWARD
            btn_stn6_cyl2_fw.Image = My.Resources.button_white
            btn_stn6_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl2_fw.Text = "Is Forward" Then
            STN6_CYL2 = IDLE
            btn_stn6_cyl2_fw.Image = My.Resources.button_silver
            btn_stn6_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl2_bw.Click
        If btn_stn6_cyl2_fw.Text = "Is Forward" Then
            btn_stn6_cyl2_fw.PerformClick()
        End If

        If btn_stn6_cyl2_bw.Text = "Backward" Then
            STN6_CYL2 = BACKWARD
            btn_stn6_cyl2_bw.Image = My.Resources.button_white
            btn_stn6_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl2_bw.Text = "Is Backward" Then
            STN6_CYL2 = IDLE
            btn_stn6_cyl2_bw.Image = My.Resources.button_silver
            btn_stn6_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl3_fw.Click
        If btn_stn6_cyl3_bw.Text = "Is Backward" Then
            btn_stn6_cyl3_bw.PerformClick()
        End If

        If btn_stn6_cyl3_fw.Text = "Forward" Then
            STN6_CYL3 = FORWARD
            btn_stn6_cyl3_fw.Image = My.Resources.button_white
            btn_stn6_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl3_fw.Text = "Is Forward" Then
            STN6_CYL3 = IDLE
            btn_stn6_cyl3_fw.Image = My.Resources.button_silver
            btn_stn6_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl3_bw.Click
        If btn_stn6_cyl3_fw.Text = "Is Forward" Then
            btn_stn6_cyl3_fw.PerformClick()
        End If

        If btn_stn6_cyl3_bw.Text = "Backward" Then
            STN6_CYL3 = BACKWARD
            btn_stn6_cyl3_bw.Image = My.Resources.button_white
            btn_stn6_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl3_bw.Text = "Is Backward" Then
            STN6_CYL3 = IDLE
            btn_stn6_cyl3_bw.Image = My.Resources.button_silver
            btn_stn6_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl4_fw.Click
        If btn_stn6_cyl4_bw.Text = "Is Backward" Then
            btn_stn6_cyl4_bw.PerformClick()
        End If

        If btn_stn6_cyl4_fw.Text = "Forward" Then
            STN6_CYL4 = FORWARD
            btn_stn6_cyl4_fw.Image = My.Resources.button_white
            btn_stn6_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl4_fw.Text = "Is Forward" Then
            STN6_CYL4 = IDLE
            btn_stn6_cyl4_fw.Image = My.Resources.button_silver
            btn_stn6_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl4_bw.Click
        If btn_stn6_cyl4_fw.Text = "Is Forward" Then
            btn_stn6_cyl4_fw.PerformClick()
        End If

        If btn_stn6_cyl4_bw.Text = "Backward" Then
            STN6_CYL4 = BACKWARD
            btn_stn6_cyl4_bw.Image = My.Resources.button_white
            btn_stn6_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl4_bw.Text = "Is Backward" Then
            STN6_CYL4 = IDLE
            btn_stn6_cyl4_bw.Image = My.Resources.button_silver
            btn_stn6_cyl4_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl5_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl5_fw.Click
        If btn_stn6_cyl5_bw.Text = "Is Backward" Then
            btn_stn6_cyl5_bw.PerformClick()
        End If

        If btn_stn6_cyl5_fw.Text = "Forward" Then
            STN6_CYL5 = FORWARD
            btn_stn6_cyl5_fw.Image = My.Resources.button_white
            btn_stn6_cyl5_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl5_fw.Text = "Is Forward" Then
            STN6_CYL5 = IDLE
            btn_stn6_cyl5_fw.Image = My.Resources.button_silver
            btn_stn6_cyl5_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl5_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl5_bw.Click
        If btn_stn6_cyl5_fw.Text = "Is Forward" Then
            btn_stn6_cyl5_fw.PerformClick()
        End If

        If btn_stn6_cyl5_bw.Text = "Backward" Then
            STN6_CYL5 = BACKWARD
            btn_stn6_cyl5_bw.Image = My.Resources.button_white
            btn_stn6_cyl5_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl5_bw.Text = "Is Backward" Then
            STN6_CYL5 = IDLE
            btn_stn6_cyl5_bw.Image = My.Resources.button_silver
            btn_stn6_cyl5_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl6_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl6_fw.Click
        If btn_stn6_cyl6_bw.Text = "Is Backward" Then
            btn_stn6_cyl6_bw.PerformClick()
        End If

        If btn_stn6_cyl6_fw.Text = "Forward" Then
            STN6_CYL6 = FORWARD
            btn_stn6_cyl6_fw.Image = My.Resources.button_white
            btn_stn6_cyl6_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl6_fw.Text = "Is Forward" Then
            STN6_CYL6 = IDLE
            btn_stn6_cyl6_fw.Image = My.Resources.button_silver
            btn_stn6_cyl6_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl6_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl6_bw.Click
        If btn_stn6_cyl6_fw.Text = "Is Forward" Then
            btn_stn6_cyl6_fw.PerformClick()
        End If

        If btn_stn6_cyl6_bw.Text = "Backward" Then
            STN6_CYL6 = BACKWARD
            btn_stn6_cyl6_bw.Image = My.Resources.button_white
            btn_stn6_cyl6_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl6_bw.Text = "Is Backward" Then
            STN6_CYL6 = IDLE
            btn_stn6_cyl6_bw.Image = My.Resources.button_silver
            btn_stn6_cyl6_bw.Text = "Backward"
        End If
    End Sub
    Private Sub PlcReading()
        'Alarm General
        ALARM_GENERAL = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_GENERAL)
        ReadAlarm(ALARM_GENERAL)
        ALARM_STN2 = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_STN2)
        ReadAlarmStn2(ALARM_STN2)
        ALARM_STN3 = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_STN3)
        ReadAlarmStn3(ALARM_STN3)
        ALARM_STN4 = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_STN4)
        ReadAlarmStn4(ALARM_STN4)
        ALARM_STN5 = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_STN5)
        ReadAlarmStn5(ALARM_STN5)
        ALARM_STN6 = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_STN6)
        ReadAlarmStn6(ALARM_STN6)

        'Check PLC
        PLC_READY = ReadFromModbus(REGISTER_TYPE, ADDR_PLC_READY)
        If PLC_READY Then
            ind_plc_status.BackColor = Color.Lime
        Else
            ind_plc_status.BackColor = Color.Red
        End If

        'running state
        RUNNING_STATE = ReadFromModbus(REGISTER_TYPE, ADDR_RUNNING_STATE)
        Select Case RUNNING_STATE
            Case 0
                lbl_run_state.Text = "..."
            Case 1
                lbl_run_state.Text = "RUNNING"
            Case 2
                lbl_run_state.Text = "STOPPING"
            Case 3
                lbl_run_state.Text = "INITIALIZED"
            Case 4
                lbl_run_state.Text = "EMPTYING"
            Case 5
                lbl_run_state.Text = "EMERGENCY"
        End Select

        'runnning Mode
        RUNNING_MODE = ReadFromModbus(REGISTER_TYPE, ADDR_RUNNING_MODE)
        Select Case RUNNING_MODE
            Case 1
                lbl_auto_man.Text = "AUTO"
            Case 2
                lbl_auto_man.Text = "MANUAL"
        End Select

        ' STN 1
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN1) = FORWARD Then
            stn1_cyl1_max.Image = My.Resources.led_red_on
            mon_stn1_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl1_max.Image = My.Resources.led_red_off
            mon_stn1_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN1) = BACKWARD Then
            stn1_cyl1_min.Image = My.Resources.led_red_on
            mon_stn1_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl1_min.Image = My.Resources.led_red_off
            mon_stn1_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN2) = FORWARD Then
            stn1_cyl2_max.Image = My.Resources.led_red_on
            mon_stn1_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl2_max.Image = My.Resources.led_red_off
            mon_stn1_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN2) = BACKWARD Then
            stn1_cyl2_min.Image = My.Resources.led_red_on
            mon_stn1_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl2_min.Image = My.Resources.led_red_off
            mon_stn1_cyl2_min.Image = My.Resources.led_red_on
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN3) = FORWARD Then
            stn1_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN3) = BACKWARD Then
            stn1_cyl3_min.Image = My.Resources.led_red_on
            mon_stn1_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl3_min.Image = My.Resources.led_red_off
            mon_stn1_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN4) = FORWARD Then
            stn1_cyl4_max.Image = My.Resources.led_red_on
            mon_stn1_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl4_max.Image = My.Resources.led_red_off
            mon_stn1_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN4) = BACKWARD Then
            stn1_cyl4_min.Image = My.Resources.led_red_on
            mon_stn1_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl4_min.Image = My.Resources.led_red_off
            mon_stn1_cyl4_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL1) = FORWARD Then
            mon_stn1_cyl1_fw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl1_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL1) = BACKWARD Then
            mon_stn1_cyl1_bw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl1_bw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL2) = FORWARD Then
            mon_stn1_cyl2_fw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl2_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL2) = BACKWARD Then
            mon_stn1_cyl2_bw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl2_bw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL3) = FORWARD Then
            mon_stn1_cyl3_fw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl3_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL3) = BACKWARD Then
            mon_stn1_cyl3_bw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl3_bw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL4) = FORWARD Then
            mon_stn1_cyl4_fw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl4_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_CYL4) = BACKWARD Then
            mon_stn1_cyl4_bw.Image = My.Resources.led_red_on
        Else
            mon_stn1_cyl4_bw.Image = My.Resources.led_red_off
        End If

        ' STN 2
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN1) = FORWARD Then
            stn2_cyl1_max.Image = My.Resources.led_red_on
            mon_stn2_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl1_max.Image = My.Resources.led_red_off
            mon_stn2_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN1) = BACKWARD Then
            stn2_cyl1_min.Image = My.Resources.led_red_on
            mon_stn2_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl1_min.Image = My.Resources.led_red_off
            mon_stn2_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN2) = FORWARD Then
            stn2_cyl2_max.Image = My.Resources.led_red_on
            mon_stn2_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl2_max.Image = My.Resources.led_red_off
            mon_stn2_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN2) = BACKWARD Then
            stn2_cyl2_min.Image = My.Resources.led_red_on
            mon_stn2_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl2_min.Image = My.Resources.led_red_off
            mon_stn2_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN3) = FORWARD Then
            stn2_cyl3_max.Image = My.Resources.led_red_on
            mon_stn2_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl3_max.Image = My.Resources.led_red_off
            mon_stn2_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN3) = BACKWARD Then
            stn2_cyl3_min.Image = My.Resources.led_red_on
            mon_stn2_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl3_min.Image = My.Resources.led_red_off
            mon_stn2_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN4) = FORWARD Then
            stn2_cyl4_max.Image = My.Resources.led_red_on
            mon_stn2_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl4_max.Image = My.Resources.led_red_off
            mon_stn2_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN4) = BACKWARD Then
            stn2_cyl4_min.Image = My.Resources.led_red_on
            mon_stn2_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl4_min.Image = My.Resources.led_red_off
            mon_stn2_cyl4_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL1) = FORWARD Then
            mon_stn2_cyl1_fw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl1_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL1) = BACKWARD Then
            mon_stn2_cyl1_bw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl1_bw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL2) = FORWARD Then
            mon_stn2_cyl2_fw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl2_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL2) = BACKWARD Then
            mon_stn2_cyl2_bw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl2_bw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL3) = FORWARD Then
            mon_stn2_cyl3_fw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl3_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL3) = BACKWARD Then
            mon_stn2_cyl3_bw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl3_bw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL4) = FORWARD Then
            mon_stn2_cyl4_fw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl4_fw.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_CYL4) = BACKWARD Then
            mon_stn2_cyl4_bw.Image = My.Resources.led_red_on
        Else
            mon_stn2_cyl4_bw.Image = My.Resources.led_red_off
        End If

        ' STN 3
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN1) = FORWARD Then
            stn3_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn3_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN1) = BACKWARD Then
            stn3_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn3_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN2) = FORWARD Then
            stn3_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn3_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN2) = BACKWARD Then
            stn3_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn3_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN3) = FORWARD Then
            stn3_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn3_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN3) = BACKWARD Then
            stn3_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn3_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN4) = FORWARD Then
            stn3_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn3_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN3_SEN4) = BACKWARD Then
            stn3_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn3_cyl4_min.Image = My.Resources.led_red_off
        End If

        ' STN 4
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN1) = FORWARD Then
            stn4_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn4_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN1) = BACKWARD Then
            stn4_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn4_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN2) = FORWARD Then
            stn4_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn4_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN2) = BACKWARD Then
            stn4_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn4_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN3) = FORWARD Then
            stn4_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn4_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN3) = BACKWARD Then
            stn4_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn4_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN4) = FORWARD Then
            stn4_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn4_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN4_SEN4) = BACKWARD Then
            stn4_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn4_cyl4_min.Image = My.Resources.led_red_off
        End If

        ' STN 5
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN1) = FORWARD Then
            stn5_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn5_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN1) = BACKWARD Then
            stn5_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn5_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN2) = FORWARD Then
            stn5_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn5_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN2) = BACKWARD Then
            stn5_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn5_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN3) = FORWARD Then
            stn5_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn5_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN3) = BACKWARD Then
            stn5_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn5_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN4) = FORWARD Then
            stn5_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn5_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN5_SEN4) = BACKWARD Then
            stn5_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn5_cyl4_min.Image = My.Resources.led_red_off
        End If

        ' STN 6
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN1) = FORWARD Then
            stn6_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn6_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN1) = BACKWARD Then
            stn6_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn6_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN2) = FORWARD Then
            stn6_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn6_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN2) = BACKWARD Then
            stn6_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn6_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN3) = FORWARD Then
            stn6_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn6_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN3) = BACKWARD Then
            stn6_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn6_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN4) = FORWARD Then
            stn6_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn6_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN4) = BACKWARD Then
            stn6_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn6_cyl4_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN5) = FORWARD Then
            stn6_cyl5_max.Image = My.Resources.led_red_on
        Else
            stn6_cyl5_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN5) = BACKWARD Then
            stn6_cyl5_min.Image = My.Resources.led_red_on
        Else
            stn6_cyl5_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN6) = FORWARD Then
            stn6_cyl6_max.Image = My.Resources.led_red_on
        Else
            stn6_cyl6_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN6_SEN6) = BACKWARD Then
            stn6_cyl6_min.Image = My.Resources.led_red_on
        Else
            stn6_cyl6_min.Image = My.Resources.led_red_off
        End If
    End Sub

    Private Sub PlcWriting()
        'STN1
        If STN1_CYL1 <> LAST_STN1_CYL1 Then
            If STN1_CYL1 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL1, FORWARD)
            ElseIf STN1_CYL1 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL1, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL1, IDLE)
            End If
            LAST_STN1_CYL1 = STN1_CYL1
        End If

        If STN1_CYL2 <> LAST_STN1_CYL2 Then
            If STN1_CYL2 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL2, FORWARD)
            ElseIf STN1_CYL2 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL2, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL2, IDLE)
            End If
            LAST_STN1_CYL2 = STN1_CYL2
        End If

        If STN1_CYL3 <> LAST_STN1_CYL3 Then
            If STN1_CYL3 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL3, FORWARD)
            ElseIf STN1_CYL3 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL3, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL3, IDLE)
            End If
            LAST_STN1_CYL3 = STN1_CYL3
        End If

        If STN1_CYL4 <> LAST_STN1_CYL4 Then
            If STN1_CYL4 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL4, FORWARD)
            ElseIf STN1_CYL4 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL4, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN1_CYL4, IDLE)
            End If
            LAST_STN1_CYL4 = STN1_CYL4
        End If

        'STN2
        If STN2_CYL1 <> LAST_STN2_CYL1 Then
            If STN2_CYL1 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL1, FORWARD)
            ElseIf STN2_CYL1 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL1, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL1, IDLE)
            End If
            LAST_STN2_CYL1 = STN2_CYL1
        End If

        If STN2_CYL2 <> LAST_STN2_CYL2 Then
            If STN2_CYL2 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL2, FORWARD)
            ElseIf STN2_CYL2 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL2, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL2, IDLE)
            End If
            LAST_STN2_CYL2 = STN2_CYL2
        End If

        If STN2_CYL3 <> LAST_STN2_CYL3 Then
            If STN2_CYL3 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL3, FORWARD)
            ElseIf STN2_CYL3 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL3, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL3, IDLE)
            End If
            LAST_STN2_CYL3 = STN2_CYL3
        End If

        If STN2_CYL4 <> LAST_STN2_CYL4 Then
            If STN2_CYL4 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL4, FORWARD)
            ElseIf STN2_CYL4 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL4, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN2_CYL4, IDLE)
            End If
            LAST_STN2_CYL4 = STN2_CYL4
        End If

        'STN3
        If STN3_CYL1 <> LAST_STN3_CYL1 Then
            If STN3_CYL1 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL1, FORWARD)
            ElseIf STN3_CYL1 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL1, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL1, IDLE)
            End If
            LAST_STN3_CYL1 = STN3_CYL1
        End If

        If STN3_CYL2 <> LAST_STN3_CYL2 Then
            If STN3_CYL2 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL2, FORWARD)
            ElseIf STN3_CYL2 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL2, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL2, IDLE)
            End If
            LAST_STN3_CYL2 = STN3_CYL2
        End If

        If STN3_CYL3 <> LAST_STN3_CYL3 Then
            If STN3_CYL3 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL3, FORWARD)
            ElseIf STN3_CYL3 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL3, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL3, IDLE)
            End If
            LAST_STN3_CYL3 = STN3_CYL3
        End If

        If STN3_CYL4 <> LAST_STN3_CYL4 Then
            If STN3_CYL4 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL4, FORWARD)
            ElseIf STN3_CYL4 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL4, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN3_CYL4, IDLE)
            End If
            LAST_STN3_CYL4 = STN3_CYL4
        End If

        'STN4
        If STN4_CYL1 <> LAST_STN4_CYL1 Then
            If STN4_CYL1 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL1, FORWARD)
            ElseIf STN4_CYL1 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL1, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL1, IDLE)
            End If
            LAST_STN4_CYL1 = STN4_CYL1
        End If

        If STN4_CYL2 <> LAST_STN4_CYL2 Then
            If STN4_CYL2 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL2, FORWARD)
            ElseIf STN4_CYL2 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL2, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL2, IDLE)
            End If
            LAST_STN4_CYL2 = STN4_CYL2
        End If

        If STN4_CYL3 <> LAST_STN4_CYL3 Then
            If STN4_CYL3 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL3, FORWARD)
            ElseIf STN4_CYL3 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL3, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL3, IDLE)
            End If
            LAST_STN4_CYL3 = STN4_CYL3
        End If

        If STN4_CYL4 <> LAST_STN4_CYL4 Then
            If STN4_CYL4 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL4, FORWARD)
            ElseIf STN4_CYL4 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL4, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN4_CYL4, IDLE)
            End If
            LAST_STN4_CYL4 = STN4_CYL4
        End If

        'STN5
        If STN5_CYL1 <> LAST_STN5_CYL1 Then
            If STN5_CYL1 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL1, FORWARD)
            ElseIf STN5_CYL1 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL1, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL1, IDLE)
            End If
            LAST_STN5_CYL1 = STN5_CYL1
        End If

        If STN5_CYL2 <> LAST_STN5_CYL2 Then
            If STN5_CYL2 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL2, FORWARD)
            ElseIf STN5_CYL2 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL2, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL2, IDLE)
            End If
            LAST_STN5_CYL2 = STN5_CYL2
        End If

        If STN5_CYL3 <> LAST_STN5_CYL3 Then
            If STN5_CYL3 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL3, FORWARD)
            ElseIf STN5_CYL3 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL3, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL3, IDLE)
            End If
            LAST_STN5_CYL3 = STN5_CYL3
        End If

        If STN5_CYL4 <> LAST_STN5_CYL4 Then
            If STN5_CYL4 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL4, FORWARD)
            ElseIf STN5_CYL4 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL4, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN5_CYL4, IDLE)
            End If
            LAST_STN5_CYL4 = STN5_CYL4
        End If

        'STN6
        If STN6_CYL1 <> LAST_STN6_CYL1 Then
            If STN6_CYL1 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL1, FORWARD)
            ElseIf STN6_CYL1 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL1, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL1, IDLE)
            End If
            LAST_STN6_CYL1 = STN6_CYL1
        End If

        If STN6_CYL2 <> LAST_STN6_CYL2 Then
            If STN6_CYL2 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL2, FORWARD)
            ElseIf STN6_CYL2 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL2, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL2, IDLE)
            End If
            LAST_STN6_CYL2 = STN6_CYL2
        End If

        If STN6_CYL3 <> LAST_STN6_CYL3 Then
            If STN6_CYL3 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL3, FORWARD)
            ElseIf STN6_CYL3 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL3, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL3, IDLE)
            End If
            LAST_STN6_CYL3 = STN6_CYL3
        End If

        If STN6_CYL4 <> LAST_STN6_CYL4 Then
            If STN6_CYL4 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL4, FORWARD)
            ElseIf STN6_CYL4 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL4, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL4, IDLE)
            End If
            LAST_STN6_CYL4 = STN6_CYL4
        End If

        If STN6_CYL5 <> LAST_STN6_CYL5 Then
            If STN6_CYL5 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL5, FORWARD)
            ElseIf STN6_CYL5 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL5, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL5, IDLE)
            End If
            LAST_STN6_CYL5 = STN6_CYL5
        End If

        If STN6_CYL6 <> LAST_STN6_CYL6 Then
            If STN6_CYL6 = FORWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL6, FORWARD)
            ElseIf STN6_CYL6 = BACKWARD Then
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL6, BACKWARD)
            Else
                WriteToModbus(REGISTER_TYPE, ADDR_STN6_CYL6, IDLE)
            End If
            LAST_STN6_CYL6 = STN6_CYL6
        End If
    End Sub

    'Loop ReadWrite
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ModbusRW.Tick
        PlcWriting()
        PlcReading()
    End Sub

    'panel home
    Private Sub btn_run_Click(sender As Object, e As EventArgs) Handles btn_run.Click
        If lbl_ref.Text = "..." Or lbl_ope_id.Text = "..." Or lbl_po_num.Text = "..." Then
            MsgBox("Please Scan Barcode!")
            Exit Sub
        End If
        GetPCStatus(110)
        btn_run.Enabled = False
        btn_stop.Enabled = True
        IS_RUN = True
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        GetPCStatus(101)
        btn_run.Enabled = True
        btn_stop.Enabled = False
        IS_RUN = False
    End Sub

    'Read Alarm
    Private Sub ReadAlarm(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_door_lock_1.BackColor = Color.Lime
        Else
            ind_door_lock_1.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            ind_door_lock_2.BackColor = Color.Lime
        Else
            ind_door_lock_2.BackColor = Color.Red
        End If

        If binaryString(13) = "1" Then
            ind_door_lock_3.BackColor = Color.Lime
        Else
            ind_door_lock_3.BackColor = Color.Red
        End If

        If binaryString(12) = "1" Then
            ind_door_lock_4.BackColor = Color.Lime
        Else
            ind_door_lock_4.BackColor = Color.Red
        End If

        If binaryString(11) = "1" Then
            ind_door_lock_5.BackColor = Color.Lime
        Else
            ind_door_lock_5.BackColor = Color.Red
        End If

        If binaryString(10) = "1" Then
            ind_door_lock_6.BackColor = Color.Lime
        Else
            ind_door_lock_6.BackColor = Color.Red
        End If

        If binaryString(9) = "1" Then
            ind_altivar_fault.BackColor = Color.Lime
        Else
            ind_altivar_fault.BackColor = Color.Red
        End If

        If binaryString(8) = "1" Then
            ind_air_presence.BackColor = Color.Lime
        Else
            ind_air_presence.BackColor = Color.Red
        End If

        If binaryString(7) = "1" Then
            ind_emg_button.BackColor = Color.Lime
        Else
            ind_emg_button.BackColor = Color.Red
        End If
    End Sub
    Private Sub ReadAlarmStn2(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v201_descrepancy.BackColor = Color.Lime
        Else
            ind_v201_descrepancy.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            ind_v202_descrepancy.BackColor = Color.Lime
        Else
            ind_v202_descrepancy.BackColor = Color.Red
        End If
    End Sub
    Private Sub ReadAlarmStn3(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v301_descrepancy.BackColor = Color.Lime
        Else
            ind_v301_descrepancy.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            ind_v302_descrepancy.BackColor = Color.Lime
        Else
            ind_v302_descrepancy.BackColor = Color.Red
        End If
    End Sub

    Private Sub ReadAlarmStn4(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v401_descrepancy.BackColor = Color.Lime
        Else
            ind_v401_descrepancy.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            ind_v402_descrepancy.BackColor = Color.Lime
        Else
            ind_v402_descrepancy.BackColor = Color.Red
        End If
    End Sub

    Private Sub ReadAlarmStn5(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v501_descrepancy.BackColor = Color.Lime
        Else
            ind_v501_descrepancy.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            ind_v502_descrepancy.BackColor = Color.Lime
        Else
            ind_v502_descrepancy.BackColor = Color.Red
        End If
    End Sub

    Private Sub ReadAlarmStn6(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v601_descrepancy.BackColor = Color.Lime
        Else
            ind_v601_descrepancy.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            ind_v602_descrepancy.BackColor = Color.Lime
        Else
            ind_v602_descrepancy.BackColor = Color.Red
        End If
    End Sub

    Private Sub Status_Tick(sender As Object, e As EventArgs) Handles Status.Tick
        'status bar
        If RUNNING_STATE = 1 Then 'running
            status_bar.Image = My.Resources.GUI___statusBar1
            lbl_auto_man.BackColor = Color.FromArgb(50, 173, 60)
            lbl_run_state.BackColor = Color.FromArgb(50, 173, 60)
            lbl_curr_time.BackColor = Color.FromArgb(50, 173, 60)
            lbl_date.BackColor = Color.FromArgb(50, 173, 60)
        ElseIf RUNNING_STATE = 2 Then 'stopping
            status_bar.Image = My.Resources.GUI___statusBar2
            lbl_auto_man.BackColor = Color.FromArgb(255, 202, 24)
            lbl_run_state.BackColor = Color.FromArgb(255, 202, 24)
            lbl_curr_time.BackColor = Color.FromArgb(255, 202, 24)
            lbl_date.BackColor = Color.FromArgb(255, 202, 24)
        ElseIf RUNNING_STATE = 5 Then 'emg
            status_bar.Image = My.Resources.GUI___statusBar3
            lbl_auto_man.BackColor = Color.FromArgb(236, 28, 36)
            lbl_run_state.BackColor = Color.FromArgb(236, 28, 36)
            lbl_curr_time.BackColor = Color.FromArgb(236, 28, 36)
            lbl_date.BackColor = Color.FromArgb(236, 28, 36)
        End If

        'operator instruction msg
        If SCAN_MODE = 0 Then
            lbl_op_ins.Text = "Please Scan Product References.."
        ElseIf SCAN_MODE = 1 Then
            lbl_op_ins.Text = "Please Scan Operator ID.."
        ElseIf SCAN_MODE = 2 Then
            lbl_op_ins.Text = "Please Scan PO Number.."
        Else
            lbl_op_ins.Text = "You're All Set!"
        End If
    End Sub
    Private Sub BarcodeComm_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles BarcodeComm.DataReceived
        If SCAN_MODE = 0 Then
            'scanning References
            AssyBuff = BarcodeComm.ReadExisting()
            If InStr(1, AssyBuff, vbCrLf) <> 0 Then
                Me.Invoke(Sub()
                              AssyBuff = Mid(AssyBuff, 1, InStr(1, AssyBuff, vbCr) - 1)
                              lbl_ref.Text = AssyBuff

                              Call KoneksiDB.koneksi_db()

                              Dim sc As New SqlCommand("SELECT * FROM ProductDatabase WHERE Reff='" & lbl_ref.Text & "'", KoneksiDB.koneksi)
                              Dim rd As SqlDataReader = sc.ExecuteReader
                              rd.Read()
                              If Not rd.HasRows Then
                                  MsgBox("Invalid References!, " + lbl_op_ins.Text)
                                  AssyBuff = ""
                                  Exit Sub
                              End If

                              AssyBuff = ""
                              SCAN_MODE = 1
                          End Sub)
            End If
        ElseIf SCAN_MODE = 1 Then
            'scanning Operator ID
            AssyBuff = BarcodeComm.ReadExisting()
            If InStr(1, AssyBuff, vbCrLf) <> 0 Then
                Me.Invoke(Sub()
                              AssyBuff = Mid(AssyBuff, 1, InStr(1, AssyBuff, vbCr) - 1)
                              lbl_ope_id.Text = AssyBuff

                              AssyBuff = ""
                              SCAN_MODE = 2
                          End Sub)
            End If
        ElseIf SCAN_MODE = 2 Then
            'scanning PO number
            AssyBuff = BarcodeComm.ReadExisting()
            If InStr(1, AssyBuff, vbCrLf) <> 0 Then
                Me.Invoke(Sub()
                              AssyBuff = Mid(AssyBuff, 1, InStr(1, AssyBuff, vbCr) - 1)
                              lbl_po_num.Text = AssyBuff

                              'Insert data to database
                              Call KoneksiDB.koneksi_db()
                              Dim sc As New SqlCommand("SELECT * FROM ProductDatabase WHERE Reff='" & lbl_ref.Text & "'", KoneksiDB.koneksi)
                              Dim rd As SqlDataReader = sc.ExecuteReader
                              rd.Read()

                              lbl_act_val.Text = rd.Item("ActVal")
                              lbl_act_val_tol.Text = rd.Item("ActValTol")
                              lbl_dif_str.Text = rd.Item("DifStr")
                              lbl_dif_str_tol.Text = rd.Item("DifStrTol")
                              lbl_beating_times.Text = rd.Item("BeatingTimes")
                              lbl_cfg_1st.Text = rd.Item("FirstContact")
                              lbl_cfg_2nd.Text = rd.Item("SecondContact")
                              lbl_unscrew_process.Text = rd.Item("UnscrewingProcess")
                              lbl_laser_datecode.Text = rd.Item("LaserDateCode")
                              lbl_laser_template.Text = rd.Item("LaserTemplate")

                              'write to plc
                              WriteToModbusFloat(REGISTER_TYPE, ADDR_ACT_VAL, Single.Parse(lbl_act_val.Text))
                              WriteToModbusFloat(REGISTER_TYPE, ADDR_ACT_VAL_TOL, Single.Parse(lbl_act_val_tol.Text))
                              WriteToModbusFloat(REGISTER_TYPE, ADDR_DIF_STR, Single.Parse(lbl_dif_str.Text))
                              WriteToModbusFloat(REGISTER_TYPE, ADDR_DIF_STR_TOL, Single.Parse(lbl_dif_str_tol.Text))
                              WriteToModbus(REGISTER_TYPE, ADDR_BEATING_TIMES, lbl_beating_times.Text)
                              WriteToModbus(REGISTER_TYPE, ADDR_CFG_FIRST_CONTACT, lbl_cfg_1st.Text)
                              WriteToModbus(REGISTER_TYPE, ADDR_CFG_SECOND_CONTACT, lbl_cfg_2nd.Text)
                              WriteToModbus(REGISTER_TYPE, ADDR_UNSCREWING_PROCESS, lbl_unscrew_process.Text)
                              WriteToModbus(REGISTER_TYPE, ADDR_LASER_DATE_CODE, lbl_laser_datecode.Text)

                              AssyBuff = ""
                              SCAN_MODE = 3
                          End Sub)
            End If
        End If
    End Sub
    Private Function CheckDuplicate() As Boolean
        Dim sc As New SqlCommand("SELECT * FROM ProductionData WHERE Reff='" & lbl_ref.Text & "'", KoneksiDB.koneksi)
        Dim rd As SqlDataReader = sc.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Return False
            Exit Function
        End If
        If rd.Item("OperatorID") <> lbl_ope_id.Text Then
            Return True
        End If
        Console.WriteLine(rd.Item("OperatorID"))
        Return False
    End Function
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        SCAN_MODE = 0
        lbl_ref.Text = "..."
        lbl_ope_id.Text = "..."
        lbl_po_num.Text = "..."
    End Sub

    Private Sub ST2_Tick(sender As Object, e As EventArgs) Handles ST2.Tick
        If SCAN_MODE = 3 Then
            ST_COMM2 = ReadFromModbus(REGISTER_TYPE, ADDR_ST_COMM2)
            Dim binaryString As String = Convert.ToString(ST_COMM2, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                CNT_ST2 = CNT_ST2 + 1
                lbl_st2_meas.Text = ReadFromModbusFloat(REGISTER_TYPE, ADDR_ST2_MEASUREMENT)

                Call KoneksiDB.koneksi_db()
                Dim sc As New SqlCommand("INSERT INTO ProductionData (No, Reff, OperatorID, ProductOrderNo, Measurement) VALUES('" & CNT_ST2.ToString & "', '" & lbl_ref.Text & "', '" & lbl_ope_id.Text & "', '" & lbl_po_num.Text & "', '" & lbl_st2_meas.Text & "')", KoneksiDB.koneksi)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()

                WriteToModbus(REGISTER_TYPE, ADDR_ST_COMM2, 3)
                lbl_cnt_st2.Text = CNT_ST2
            End If
        End If
    End Sub

    Private Sub ST3_Tick(sender As Object, e As EventArgs) Handles ST3.Tick
        If SCAN_MODE = 3 Then
            ST_COMM3 = ReadFromModbus(REGISTER_TYPE, ADDR_ST_COMM3)
            Dim binaryString As String = Convert.ToString(ST_COMM3, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                CNT_ST3 = CNT_ST3 + 1
                '======================== program baca resistant ========================
                Dim Value As Decimal = Rnd()
                lbl_st3_res.Text = Value.ToString

                Call KoneksiDB.koneksi_db()
                Dim sc As New SqlCommand("UPDATE ProductionData SET Resistance = '" & lbl_st3_res.Text & "' WHERE No = '" & CNT_ST3.ToString & "'", KoneksiDB.koneksi)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()

                WriteToModbus(REGISTER_TYPE, ADDR_ST_COMM3, 7) ' dummy
                lbl_cnt_st3.Text = CNT_ST3
            End If
        End If
    End Sub

    Private Sub ST4_Tick(sender As Object, e As EventArgs) Handles ST4.Tick
        If SCAN_MODE = 3 Then
            ST_COMM4 = ReadFromModbus(REGISTER_TYPE, ADDR_ST_COMM4)
            Dim binaryString As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                CNT_ST4 = CNT_ST4 + 1
                lbl_st4_p2.Text = ReadFromModbusFloat(REGISTER_TYPE, ADDR_ST4_P2_TRAVEL)
                lbl_st4_p3.Text = ReadFromModbusFloat(REGISTER_TYPE, ADDR_ST4_P3_TRAVEL)
                lbl_diff_result.Text = ReadFromModbusFloat(REGISTER_TYPE, ADDR_DIFF_STR_RESULT)
                lbl_st4_t1.Text = ReadFromModbus(REGISTER_TYPE, ADDR_ST4_T1)
                lbl_st4_t2.Text = ReadFromModbus(REGISTER_TYPE, ADDR_ST4_T2)
                lbl_cot.Text = ReadFromModbus(REGISTER_TYPE, ADDR_COT)

                Call KoneksiDB.koneksi_db()
                Dim sc As New SqlCommand("UPDATE ProductionData SET TravelP2 = '" & lbl_st4_p2.Text & "', TravelP3 = '" & lbl_st4_p3.Text & "', Difference = '" & lbl_diff_result.Text & "', ST4T1 = '" & lbl_st4_t1.Text & "', ST4T2 = '" & lbl_st4_t2.Text & "', COT = '" & lbl_cot.Text & "' WHERE No = '" & CNT_ST4.ToString & "'", KoneksiDB.koneksi)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()

                WriteToModbus(REGISTER_TYPE, ADDR_ST_COMM4, 3)
                lbl_cnt_st4.Text = CNT_ST4
            End If
        End If
    End Sub

    Private Sub ST5_Tick(sender As Object, e As EventArgs) Handles ST5.Tick
        If SCAN_MODE = 3 Then
            ST_COMM5 = ReadFromModbus(REGISTER_TYPE, ADDR_ST_COMM5)
            Dim binaryString As String = Convert.ToString(ST_COMM5, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                CNT_ST5 = CNT_ST5 + 1
                lbl_unscrew_status.Text = ReadFromModbus(REGISTER_TYPE, ADDR_UNSCREW_STATUS)

                Call KoneksiDB.koneksi_db()
                Dim sc As New SqlCommand("UPDATE ProductionData SET UnscrewStatus = '" & lbl_unscrew_status.Text & "' WHERE No = '" & CNT_ST5.ToString & "'", KoneksiDB.koneksi)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()

                WriteToModbus(REGISTER_TYPE, ADDR_ST_COMM5, 3)
                lbl_cnt_st5.Text = CNT_ST5
            End If
        End If
    End Sub

    Private Sub btn_clear_database_Click(sender As Object, e As EventArgs) Handles btn_clear_database.Click
        Call KoneksiDB.koneksi_db()
        Dim sc As New SqlCommand("DELETE from ProductionData;", KoneksiDB.koneksi)
        Dim adapter As New SqlDataAdapter(sc)
        adapter.SelectCommand.ExecuteNonQuery()

        CNT_ST2 = 0
        CNT_ST3 = 0
        CNT_ST4 = 0
        CNT_ST5 = 0
        lbl_cnt_st2.Text = "..."
        lbl_cnt_st3.Text = "..."
        lbl_cnt_st4.Text = "..."
        lbl_cnt_st5.Text = "..."
        lbl_st2_meas.Text = "..."
        lbl_st3_res.Text = "..."
        lbl_st4_p2.Text = "..."
        lbl_st4_p3.Text = "..."
        lbl_diff_result.Text = "..."
        lbl_st4_t1.Text = "..."
        lbl_st4_t2.Text = "..."
        lbl_cot.Text = "..."
    End Sub
End Class