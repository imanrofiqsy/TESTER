Imports System.Threading
Public Class frmMain
    Dim Modbus = New Modbus()
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_connect.PerformClick()
        GetPCStatus(100) 'Software is open
        ShowPanelGeneral("home")
        ShowButtonSTN(0)
        ShowPanelManual("None")

        GetPCStatus(110)
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
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click, btn_clear.Click
        ShowPanelGeneral("setting")
    End Sub
    Private Sub btn_monitoring_Click(sender As Object, e As EventArgs) Handles btn_monitoring.Click
    End Sub

    'Show Panel General
    Private Sub ShowPanelGeneral(mode As String)
        ShowPanelManual("None")

        If mode = "home" Then
            pnl_home.Visible = True
        Else
            pnl_home.Visible = False
        End If

        If mode = "manual" Then
            ShowButtonSTN(1)
        Else
            ShowButtonSTN(0)
        End If

        If mode = "setting" Then
            pnl_setting.Visible = True
        Else
            pnl_setting.Visible = False
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
                ModbusRW.Enabled = False
            End If
        End If
    End Sub
    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        txtValue.Text = ReadFromModbus(REGISTER_TYPE, txtAddress.Text)
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        WriteToModbus(REGISTER_TYPE, txtAddress.Text, txtValue.Text)
    End Sub

    'Show Panel Manual
    Private Sub ShowPanelManual(mode As String)
        If mode = "STN1" Then
            pnl_man_stn1.Visible = True
        Else
            pnl_man_stn1.Visible = False
        End If

        If mode = "STN2" Then
            pnl_man_stn2.Visible = True
        Else
            pnl_man_stn2.Visible = False
        End If

        If mode = "STN3" Then
            pnl_man_stn3.Visible = True
        Else
            pnl_man_stn3.Visible = False
        End If

        If mode = "STN4" Then
            pnl_man_stn4.Visible = True
        Else
            pnl_man_stn4.Visible = False
        End If

        If mode = "STN5" Then
            pnl_man_stn5.Visible = True
        Else
            pnl_man_stn5.Visible = False
        End If

        If mode = "STN6" Then
            pnl_man_stn6.Visible = True
        Else
            pnl_man_stn6.Visible = False
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
    Private Sub WriteToModbus(RegType As Integer, Address As Integer, Value As Integer)
        Try
            Modbus.WriteData(RegType, Address, Value)
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
    Private Sub PlcReading()
        'Alarm General
        ALARM_GENERAL = ReadFromModbus(REGISTER_TYPE, ADDR_ALARM_GENERAL)
        ReadAlarm(ALARM_GENERAL)

        'Check PLC
        If ReadFromModbus(REGISTER_TYPE, ADDR_PLC_READY) = PLC_READY Then
            ind_plc_status.BackColor = Color.Lime
        Else
            ind_plc_status.BackColor = Color.Red
        End If

        'running state
        RUNNING_STATE = ReadFromModbus(REGISTER_TYPE, ADDR_RUNNING_STATE)
        Select Case RUNNING_STATE
            Case 0
                lbl_running_state.Text = "..."
            Case 1
                lbl_running_state.Text = "Running"
            Case 2
                lbl_running_state.Text = "Stopping"
            Case 3
                lbl_running_state.Text = "Initialized"
            Case 4
                lbl_running_state.Text = "Emptying"
            Case 5
                lbl_running_state.Text = "Emergency"
        End Select
        lbl_run_state.Text = lbl_running_state.Text.ToUpper

        'runnning Mode
        RUNNING_MODE = ReadFromModbus(REGISTER_TYPE, ADDR_RUNNING_MODE)
        Select Case RUNNING_MODE
            Case 1
                ind_auto_mode.BackColor = Color.Lime
                ind_manual_mode.BackColor = Color.Red
                lbl_auto_man.Text = "AUTO"
            Case 2
                ind_auto_mode.BackColor = Color.Red
                ind_manual_mode.BackColor = Color.Lime
                lbl_auto_man.Text = "MANUAL"
        End Select

        ' STN 1
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN1) = FORWARD Then
            stn1_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN1) = BACKWARD Then
            stn1_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN2) = FORWARD Then
            stn1_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN2) = BACKWARD Then
            stn1_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN3) = FORWARD Then
            stn1_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN3) = BACKWARD Then
            stn1_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN4) = FORWARD Then
            stn1_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn1_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN1_SEN4) = BACKWARD Then
            stn1_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn1_cyl4_min.Image = My.Resources.led_red_off
        End If

        ' STN 2
        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN1) = FORWARD Then
            stn2_cyl1_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl1_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN1) = BACKWARD Then
            stn2_cyl1_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl1_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN2) = FORWARD Then
            stn2_cyl2_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl2_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN2) = BACKWARD Then
            stn2_cyl2_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl2_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN3) = FORWARD Then
            stn2_cyl3_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl3_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN3) = BACKWARD Then
            stn2_cyl3_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl3_min.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN4) = FORWARD Then
            stn2_cyl4_max.Image = My.Resources.led_red_on
        Else
            stn2_cyl4_max.Image = My.Resources.led_red_off
        End If

        If ReadFromModbus(REGISTER_TYPE, ADDR_STN2_SEN4) = BACKWARD Then
            stn2_cyl4_min.Image = My.Resources.led_red_on
        Else
            stn2_cyl4_min.Image = My.Resources.led_red_off
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
    End Sub

    'Loop ReadWrite
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ModbusRW.Tick
        PlcWriting()
        PlcReading()
    End Sub

    Private Sub btn_run_Click(sender As Object, e As EventArgs) Handles btn_run.Click
        GetPCStatus(110)
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        GetPCStatus(101)
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
End Class
