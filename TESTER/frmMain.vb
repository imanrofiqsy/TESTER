Imports System.Threading
Imports System.Data.SqlClient
Public Class frmMain
    Dim Modbus = New Modbus()
    Dim Multimeter = New Multimeter()
    Dim ThreadLoadFrm As Thread

    Dim AssyBuff As String
    Dim ManualState As Boolean
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initLoadingBar()
        btn_connect_plc.PerformClick()
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
                Modbus.WriteData(REGISTER_TYPE, ADDR_PC_STATUS, 1)
                ind_software_open.BackColor = Color.Red
                ind_software_run.BackColor = Color.DarkRed
                ind_software_stop.BackColor = Color.DarkRed
            Case 110
                Modbus.WriteData(REGISTER_TYPE, ADDR_PC_STATUS, 3)
                ind_software_open.BackColor = Color.Red
                ind_software_run.BackColor = Color.Red
                ind_software_stop.BackColor = Color.DarkRed
            Case 101
                Modbus.WriteData(REGISTER_TYPE, ADDR_PC_STATUS, 5)
                ind_software_open.BackColor = Color.Red
                ind_software_run.BackColor = Color.DarkRed
                ind_software_stop.BackColor = Color.Red
        End Select
    End Sub
    Private Sub dateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lbl_date.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    'Button General
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        ShowPanelGeneral("home")
    End Sub
    Private Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click
        If lbl_auto_man.Text <> "MANUAL" Then
            MsgBox("Make Sure The Machine Is In Manual Mode", vbCritical)
            Exit Sub
        End If
        ShowPanelGeneral("manual")
        btn_stop.PerformClick()
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
    Private Sub btn_multimeter_Click(sender As Object, e As EventArgs) Handles btn_multimeter.Click
        ShowPanelGeneral("multi")
    End Sub
    Private Sub btn_laser_Click(sender As Object, e As EventArgs) Handles btn_laser.Click
        ShowPanelGeneral("laser")
    End Sub
    Private Sub btn_ref_Click(sender As Object, e As EventArgs) Handles btn_ref.Click
        dgv_ref.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10)
        dgv_ref.DefaultCellStyle.Font = New Font("Arial", 10)
        ShowPanelGeneral("ref")
        LoadTbRef()
    End Sub
    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10)
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
        ShowPanelGeneral("log")
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

        If mode = "multi" Then
            pnl_multi.Visible = True
        Else
            pnl_multi.Visible = False
        End If

        If mode = "laser" Then
            pnl_laser.Visible = True
        Else
            pnl_laser.Visible = False
        End If

        If mode = "ref" Then
            pnl_ref.Visible = True
        Else
            pnl_ref.Visible = False
        End If

        If mode = "log" Then
            pnl_log.Visible = True
        Else
            pnl_log.Visible = False
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
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect_plc.Click
        If btn_connect_plc.Text = "Connect" Then
            If Modbus.OpenPort(txtIP_PLC.Text, txtPort_PLC.Text) Then
                btn_connect_plc.Text = "Disconnect"
                connect_plc_ind.Image = My.Resources.led_green_on
                ModbusRW.Enabled = True
                MODBUS_ERR = False
            End If
        ElseIf btn_connect_plc.Text = "Disconnect" Then
            If Modbus.ClosePort() Then
                btn_connect_plc.Text = "Connect"
                connect_plc_ind.Image = My.Resources.led_red_off
                ind_plc_status.BackColor = Color.DarkRed
                ModbusRW.Enabled = False
            End If
        End If
    End Sub

    Private Sub btn_connect_multi_Click(sender As Object, e As EventArgs) Handles btn_connect_multi.Click
        If btn_connect_multi.Text = "Connect" Then
            If Multimeter.Connect(txtIP_multi.Text, txtPort_multi.Text) Then
                btn_connect_multi.Text = "Disconnect"
                connect_multi_ind.Image = My.Resources.led_green_on
            End If
        ElseIf btn_connect_multi.Text = "Disconnect" Then
            If Multimeter.Close() Then
                btn_connect_multi.Text = "Connect"
                connect_multi_ind.Image = My.Resources.led_red_on
            End If
        End If
    End Sub
    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        If cbo_data_type.Text = "FLOAT" Then
            txtValue.Text = Modbus.ReadDataFloat(REGISTER_TYPE, txtAddress.Text)
        ElseIf cbo_data_type.Text = "INT" Then
            txtValue.Text = Modbus.ReadData(REGISTER_TYPE, txtAddress.Text)
        End If
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        If cbo_data_type.Text = "FLOAT" Then
            Modbus.WriteDataFloat(REGISTER_TYPE, Val(txtAddress.Text), Single.Parse(txtValue.Text))
        ElseIf cbo_data_type.Text = "INT" Then
            Modbus.WriteData(REGISTER_TYPE, Val(txtAddress.Text), txtValue.Text)
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
        Dim fpy_number As Double = 0
        Dim oee_number As Double = 0
        lbl_pass.Text = Modbus.ReadData(REGISTER_TYPE, ADDR_PASS)
        lbl_fail.Text = Modbus.ReadData(REGISTER_TYPE, ADDR_FAIL)
        lbl_fpy.Text = Math.Round(Double.Parse(Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_FPY)), 1).ToString + " %"
        lbl_oee.Text = Math.Round(Double.Parse(Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_OEE)), 1).ToString + " %"

        'Alarm General
        ALARM_GENERAL = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_GENERAL)
        ReadAlarm(ALARM_GENERAL)
        ALARM_STN2 = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_STN2)
        ReadAlarmStn2(ALARM_STN2)
        ALARM_STN3 = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_STN3)
        ReadAlarmStn3(ALARM_STN3)
        ALARM_STN4 = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_STN4)
        ReadAlarmStn4(ALARM_STN4)
        ALARM_STN5 = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_STN5)
        ReadAlarmStn5(ALARM_STN5)
        ALARM_STN6 = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_STN6)
        ReadAlarmStn6(ALARM_STN6)

        'Check PLC
        PLC_READY = Modbus.ReadData(REGISTER_TYPE, ADDR_PLC_READY)
        If PLC_READY Then
            ind_plc_status.BackColor = Color.Red
        Else
            ind_plc_status.BackColor = Color.DarkRed
        End If

        'running state
        RUNNING_STATE = Modbus.ReadData(REGISTER_TYPE, ADDR_RUNNING_STATE)
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
        RUNNING_MODE = Modbus.ReadData(REGISTER_TYPE, ADDR_RUNNING_MODE)
        Select Case RUNNING_MODE
            Case 0
                lbl_auto_man.Text = "..."
            Case 1
                lbl_auto_man.Text = "AUTO"
            Case 2
                lbl_auto_man.Text = "MANUAL"
        End Select

        If pnl_home.Visible = False And pnl_setting.Visible = False And pnl_alarm.Visible = False Then
            ' STN 1
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN1) = FORWARD Then
                stn1_cyl1_max.Image = My.Resources.led_red_on
                mon_stn1_cyl1_max.Image = My.Resources.led_red_on
            Else
                stn1_cyl1_max.Image = My.Resources.led_red_off
                mon_stn1_cyl1_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN1) = BACKWARD Then
                stn1_cyl1_min.Image = My.Resources.led_red_on
                mon_stn1_cyl1_min.Image = My.Resources.led_red_on
            Else
                stn1_cyl1_min.Image = My.Resources.led_red_off
                mon_stn1_cyl1_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN2) = FORWARD Then
                stn1_cyl2_max.Image = My.Resources.led_red_on
                mon_stn1_cyl2_max.Image = My.Resources.led_red_on
            Else
                stn1_cyl2_max.Image = My.Resources.led_red_off
                mon_stn1_cyl2_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN2) = BACKWARD Then
                stn1_cyl2_min.Image = My.Resources.led_red_on
                mon_stn1_cyl2_min.Image = My.Resources.led_red_on
            Else
                stn1_cyl2_min.Image = My.Resources.led_red_off
                mon_stn1_cyl2_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN3) = FORWARD Then
                stn1_cyl3_max.Image = My.Resources.led_red_on
            Else
                stn1_cyl3_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN3) = BACKWARD Then
                stn1_cyl3_min.Image = My.Resources.led_red_on
                mon_stn1_cyl3_min.Image = My.Resources.led_red_on
            Else
                stn1_cyl3_min.Image = My.Resources.led_red_off
                mon_stn1_cyl3_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN4) = FORWARD Then
                stn1_cyl4_max.Image = My.Resources.led_red_on
                mon_stn1_cyl4_max.Image = My.Resources.led_red_on
            Else
                stn1_cyl4_max.Image = My.Resources.led_red_off
                mon_stn1_cyl4_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN4) = BACKWARD Then
                stn1_cyl4_min.Image = My.Resources.led_red_on
                mon_stn1_cyl4_min.Image = My.Resources.led_red_on
            Else
                stn1_cyl4_min.Image = My.Resources.led_red_off
                mon_stn1_cyl4_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL1) = FORWARD Then
                mon_stn1_cyl1_fw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl1_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL1) = BACKWARD Then
                mon_stn1_cyl1_bw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl1_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL2) = FORWARD Then
                mon_stn1_cyl2_fw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl2_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL2) = BACKWARD Then
                mon_stn1_cyl2_bw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl2_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL3) = FORWARD Then
                mon_stn1_cyl3_fw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl3_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL3) = BACKWARD Then
                mon_stn1_cyl3_bw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl3_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL4) = FORWARD Then
                mon_stn1_cyl4_fw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl4_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL4) = BACKWARD Then
                mon_stn1_cyl4_bw.Image = My.Resources.led_red_on
            Else
                mon_stn1_cyl4_bw.Image = My.Resources.led_red_off
            End If

            ' STN 2
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN1) = FORWARD Then
                stn2_cyl1_max.Image = My.Resources.led_red_on
                mon_stn2_cyl1_max.Image = My.Resources.led_red_on
            Else
                stn2_cyl1_max.Image = My.Resources.led_red_off
                mon_stn2_cyl1_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN1) = BACKWARD Then
                stn2_cyl1_min.Image = My.Resources.led_red_on
                mon_stn2_cyl1_min.Image = My.Resources.led_red_on
            Else
                stn2_cyl1_min.Image = My.Resources.led_red_off
                mon_stn2_cyl1_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN2) = FORWARD Then
                stn2_cyl2_max.Image = My.Resources.led_red_on
                mon_stn2_cyl2_max.Image = My.Resources.led_red_on
            Else
                stn2_cyl2_max.Image = My.Resources.led_red_off
                mon_stn2_cyl2_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN2) = BACKWARD Then
                stn2_cyl2_min.Image = My.Resources.led_red_on
                mon_stn2_cyl2_min.Image = My.Resources.led_red_on
            Else
                stn2_cyl2_min.Image = My.Resources.led_red_off
                mon_stn2_cyl2_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN3) = FORWARD Then
                stn2_cyl3_max.Image = My.Resources.led_red_on
                mon_stn2_cyl3_max.Image = My.Resources.led_red_on
            Else
                stn2_cyl3_max.Image = My.Resources.led_red_off
                mon_stn2_cyl3_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN3) = BACKWARD Then
                stn2_cyl3_min.Image = My.Resources.led_red_on
                mon_stn2_cyl3_min.Image = My.Resources.led_red_on
            Else
                stn2_cyl3_min.Image = My.Resources.led_red_off
                mon_stn2_cyl3_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN4) = FORWARD Then
                stn2_cyl4_max.Image = My.Resources.led_red_on
                mon_stn2_cyl4_max.Image = My.Resources.led_red_on
            Else
                stn2_cyl4_max.Image = My.Resources.led_red_off
                mon_stn2_cyl4_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN4) = BACKWARD Then
                stn2_cyl4_min.Image = My.Resources.led_red_on
                mon_stn2_cyl4_min.Image = My.Resources.led_red_on
            Else
                stn2_cyl4_min.Image = My.Resources.led_red_off
                mon_stn2_cyl4_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL1) = FORWARD Then
                mon_stn2_cyl1_fw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl1_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL1) = BACKWARD Then
                mon_stn2_cyl1_bw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl1_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL2) = FORWARD Then
                mon_stn2_cyl2_fw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl2_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL2) = BACKWARD Then
                mon_stn2_cyl2_bw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl2_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL3) = FORWARD Then
                mon_stn2_cyl3_fw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl3_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL3) = BACKWARD Then
                mon_stn2_cyl3_bw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl3_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL4) = FORWARD Then
                mon_stn2_cyl4_fw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl4_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL4) = BACKWARD Then
                mon_stn2_cyl4_bw.Image = My.Resources.led_red_on
            Else
                mon_stn2_cyl4_bw.Image = My.Resources.led_red_off
            End If

            ' STN 3
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN1) = FORWARD Then
                stn3_cyl1_max.Image = My.Resources.led_red_on
                mon_stn3_cyl1_max.Image = My.Resources.led_red_on
            Else
                stn3_cyl1_max.Image = My.Resources.led_red_off
                mon_stn3_cyl1_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN1) = BACKWARD Then
                stn3_cyl1_min.Image = My.Resources.led_red_on
                mon_stn3_cyl1_min.Image = My.Resources.led_red_on
            Else
                stn3_cyl1_min.Image = My.Resources.led_red_off
                mon_stn3_cyl1_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN2) = FORWARD Then
                stn3_cyl2_max.Image = My.Resources.led_red_on
                mon_stn3_cyl2_max.Image = My.Resources.led_red_on
            Else
                stn3_cyl2_max.Image = My.Resources.led_red_off
                mon_stn3_cyl2_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN2) = BACKWARD Then
                stn3_cyl2_min.Image = My.Resources.led_red_on
                mon_stn3_cyl2_min.Image = My.Resources.led_red_on
            Else
                stn3_cyl2_min.Image = My.Resources.led_red_off
                mon_stn3_cyl2_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN3) = FORWARD Then
                stn3_cyl3_max.Image = My.Resources.led_red_on
                mon_stn3_cyl3_max.Image = My.Resources.led_red_on
            Else
                stn3_cyl3_max.Image = My.Resources.led_red_off
                mon_stn3_cyl3_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN3) = BACKWARD Then
                stn3_cyl3_min.Image = My.Resources.led_red_on
                mon_stn3_cyl3_min.Image = My.Resources.led_red_on
            Else
                stn3_cyl3_min.Image = My.Resources.led_red_off
                mon_stn3_cyl3_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN4) = FORWARD Then
                stn3_cyl4_max.Image = My.Resources.led_red_on
                mon_stn3_cyl4_max.Image = My.Resources.led_red_on
            Else
                stn3_cyl4_max.Image = My.Resources.led_red_off
                mon_stn3_cyl4_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN4) = BACKWARD Then
                stn3_cyl4_min.Image = My.Resources.led_red_on
                mon_stn3_cyl4_min.Image = My.Resources.led_red_on
            Else
                stn3_cyl4_min.Image = My.Resources.led_red_off
                mon_stn3_cyl4_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL1) = FORWARD Then
                mon_stn3_cyl1_fw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl1_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL1) = BACKWARD Then
                mon_stn3_cyl1_bw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl1_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL2) = FORWARD Then
                mon_stn3_cyl2_fw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl2_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL2) = BACKWARD Then
                mon_stn3_cyl2_bw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl2_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL3) = FORWARD Then
                mon_stn3_cyl3_fw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl3_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL3) = BACKWARD Then
                mon_stn3_cyl3_bw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl3_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL4) = FORWARD Then
                mon_stn3_cyl4_fw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl4_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL4) = BACKWARD Then
                mon_stn3_cyl4_bw.Image = My.Resources.led_red_on
            Else
                mon_stn3_cyl4_bw.Image = My.Resources.led_red_off
            End If

            ' STN 4
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN1) = FORWARD Then
                stn4_cyl1_max.Image = My.Resources.led_red_on
                mon_stn4_cyl1_max.Image = My.Resources.led_red_on
            Else
                stn4_cyl1_max.Image = My.Resources.led_red_off
                mon_stn4_cyl1_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN1) = BACKWARD Then
                stn4_cyl1_min.Image = My.Resources.led_red_on
                mon_stn4_cyl1_min.Image = My.Resources.led_red_on
            Else
                stn4_cyl1_min.Image = My.Resources.led_red_off
                mon_stn4_cyl1_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN2) = FORWARD Then
                stn4_cyl2_max.Image = My.Resources.led_red_on
                mon_stn4_cyl2_max.Image = My.Resources.led_red_on
            Else
                stn4_cyl2_max.Image = My.Resources.led_red_off
                mon_stn4_cyl2_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN2) = BACKWARD Then
                stn4_cyl2_min.Image = My.Resources.led_red_on
                mon_stn4_cyl2_min.Image = My.Resources.led_red_on
            Else
                stn4_cyl2_min.Image = My.Resources.led_red_off
                mon_stn4_cyl2_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN3) = FORWARD Then
                stn4_cyl3_max.Image = My.Resources.led_red_on
                mon_stn4_cyl3_max.Image = My.Resources.led_red_on
            Else
                stn4_cyl3_max.Image = My.Resources.led_red_off
                mon_stn4_cyl3_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN3) = BACKWARD Then
                stn4_cyl3_min.Image = My.Resources.led_red_on
                mon_stn4_cyl3_min.Image = My.Resources.led_red_on
            Else
                stn4_cyl3_min.Image = My.Resources.led_red_off
                mon_stn4_cyl3_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN4) = FORWARD Then
                stn4_cyl4_max.Image = My.Resources.led_red_on
                mon_stn4_cyl4_max.Image = My.Resources.led_red_on
            Else
                stn4_cyl4_max.Image = My.Resources.led_red_off
                mon_stn4_cyl4_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN4) = BACKWARD Then
                stn4_cyl4_min.Image = My.Resources.led_red_on
                mon_stn4_cyl4_min.Image = My.Resources.led_red_on
            Else
                stn4_cyl4_min.Image = My.Resources.led_red_off
                mon_stn4_cyl4_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL1) = FORWARD Then
                mon_stn4_cyl1_fw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl1_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL1) = BACKWARD Then
                mon_stn4_cyl1_bw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl1_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL2) = FORWARD Then
                mon_stn4_cyl2_fw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl2_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL2) = BACKWARD Then
                mon_stn4_cyl2_bw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl2_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL3) = FORWARD Then
                mon_stn4_cyl3_fw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl3_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL3) = BACKWARD Then
                mon_stn4_cyl3_bw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl3_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL4) = FORWARD Then
                mon_stn4_cyl4_fw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl4_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL4) = BACKWARD Then
                mon_stn4_cyl4_bw.Image = My.Resources.led_red_on
            Else
                mon_stn4_cyl4_bw.Image = My.Resources.led_red_off
            End If

            ' STN 5
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN1) = FORWARD Then
                stn5_cyl1_max.Image = My.Resources.led_red_on
                mon_stn5_cyl1_max.Image = My.Resources.led_red_on
            Else
                stn5_cyl1_max.Image = My.Resources.led_red_off
                mon_stn5_cyl1_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN1) = BACKWARD Then
                stn5_cyl1_min.Image = My.Resources.led_red_on
                mon_stn5_cyl1_min.Image = My.Resources.led_red_on
            Else
                stn5_cyl1_min.Image = My.Resources.led_red_off
                mon_stn5_cyl1_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN2) = FORWARD Then
                stn5_cyl2_max.Image = My.Resources.led_red_on
                mon_stn5_cyl2_max.Image = My.Resources.led_red_on
            Else
                stn5_cyl2_max.Image = My.Resources.led_red_off
                mon_stn5_cyl2_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN2) = BACKWARD Then
                stn5_cyl2_min.Image = My.Resources.led_red_on
                mon_stn5_cyl2_min.Image = My.Resources.led_red_on
            Else
                stn5_cyl2_min.Image = My.Resources.led_red_off
                mon_stn5_cyl2_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN3) = FORWARD Then
                stn5_cyl3_max.Image = My.Resources.led_red_on
                mon_stn5_cyl3_max.Image = My.Resources.led_red_on
            Else
                stn5_cyl3_max.Image = My.Resources.led_red_off
                mon_stn5_cyl3_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN3) = BACKWARD Then
                stn5_cyl3_min.Image = My.Resources.led_red_on
                mon_stn5_cyl3_min.Image = My.Resources.led_red_on
            Else
                stn5_cyl3_min.Image = My.Resources.led_red_off
                mon_stn5_cyl3_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN4) = FORWARD Then
                stn5_cyl4_max.Image = My.Resources.led_red_on
                mon_stn5_cyl4_max.Image = My.Resources.led_red_on
            Else
                stn5_cyl4_max.Image = My.Resources.led_red_off
                mon_stn5_cyl4_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN4) = BACKWARD Then
                stn5_cyl4_min.Image = My.Resources.led_red_on
                mon_stn5_cyl4_min.Image = My.Resources.led_red_on
            Else
                stn5_cyl4_min.Image = My.Resources.led_red_off
                mon_stn5_cyl4_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL1) = FORWARD Then
                mon_stn5_cyl1_fw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl1_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL1) = BACKWARD Then
                mon_stn5_cyl1_bw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl1_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL2) = FORWARD Then
                mon_stn5_cyl2_fw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl2_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL2) = BACKWARD Then
                mon_stn5_cyl2_bw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl2_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL3) = FORWARD Then
                mon_stn5_cyl3_fw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl3_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL3) = BACKWARD Then
                mon_stn5_cyl3_bw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl3_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL4) = FORWARD Then
                mon_stn5_cyl4_fw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl4_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL4) = BACKWARD Then
                mon_stn5_cyl4_bw.Image = My.Resources.led_red_on
            Else
                mon_stn5_cyl4_bw.Image = My.Resources.led_red_off
            End If

            ' STN 6
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN1) = FORWARD Then
                stn6_cyl1_max.Image = My.Resources.led_red_on
                mon_stn6_cyl1_max.Image = My.Resources.led_red_on
            Else
                stn6_cyl1_max.Image = My.Resources.led_red_off
                mon_stn6_cyl1_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN1) = BACKWARD Then
                stn6_cyl1_min.Image = My.Resources.led_red_on
                mon_stn6_cyl1_min.Image = My.Resources.led_red_on
            Else
                stn6_cyl1_min.Image = My.Resources.led_red_off
                mon_stn6_cyl1_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN2) = FORWARD Then
                stn6_cyl2_max.Image = My.Resources.led_red_on
                mon_stn6_cyl2_max.Image = My.Resources.led_red_on
            Else
                stn6_cyl2_max.Image = My.Resources.led_red_off
                mon_stn6_cyl2_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN2) = BACKWARD Then
                stn6_cyl2_min.Image = My.Resources.led_red_on
                mon_stn6_cyl2_min.Image = My.Resources.led_red_on
            Else
                stn6_cyl2_min.Image = My.Resources.led_red_off
                mon_stn6_cyl2_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN3) = FORWARD Then
                stn6_cyl3_max.Image = My.Resources.led_red_on
                mon_stn6_cyl3_max.Image = My.Resources.led_red_on
            Else
                stn6_cyl3_max.Image = My.Resources.led_red_off
                mon_stn6_cyl3_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN3) = BACKWARD Then
                stn6_cyl3_min.Image = My.Resources.led_red_on
                mon_stn6_cyl3_min.Image = My.Resources.led_red_on
            Else
                stn6_cyl3_min.Image = My.Resources.led_red_off
                mon_stn6_cyl3_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN4) = FORWARD Then
                stn6_cyl4_max.Image = My.Resources.led_red_on
                mon_stn6_cyl4_max.Image = My.Resources.led_red_on
            Else
                stn6_cyl4_max.Image = My.Resources.led_red_off
                mon_stn6_cyl4_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN4) = BACKWARD Then
                stn6_cyl4_min.Image = My.Resources.led_red_on
                mon_stn6_cyl4_min.Image = My.Resources.led_red_on
            Else
                stn6_cyl4_min.Image = My.Resources.led_red_off
                mon_stn6_cyl4_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN5) = FORWARD Then
                stn6_cyl5_max.Image = My.Resources.led_red_on
                mon_stn6_cyl5_max.Image = My.Resources.led_red_on
            Else
                stn6_cyl5_max.Image = My.Resources.led_red_off
                mon_stn6_cyl5_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN5) = BACKWARD Then
                stn6_cyl5_min.Image = My.Resources.led_red_on
                mon_stn6_cyl5_min.Image = My.Resources.led_red_on
            Else
                stn6_cyl5_min.Image = My.Resources.led_red_off
                mon_stn6_cyl5_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN6) = FORWARD Then
                stn6_cyl6_max.Image = My.Resources.led_red_on
                mon_stn6_cyl6_max.Image = My.Resources.led_red_on
            Else
                stn6_cyl6_max.Image = My.Resources.led_red_off
                mon_stn6_cyl6_max.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN6) = BACKWARD Then
                stn6_cyl6_min.Image = My.Resources.led_red_on
                mon_stn6_cyl6_min.Image = My.Resources.led_red_on
            Else
                stn6_cyl6_min.Image = My.Resources.led_red_off
                mon_stn6_cyl6_min.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL1) = FORWARD Then
                mon_stn6_cyl1_fw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl1_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL1) = BACKWARD Then
                mon_stn6_cyl1_bw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl1_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL2) = FORWARD Then
                mon_stn6_cyl2_fw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl2_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL2) = BACKWARD Then
                mon_stn6_cyl2_bw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl2_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL3) = FORWARD Then
                mon_stn6_cyl3_fw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl3_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL3) = BACKWARD Then
                mon_stn6_cyl3_bw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl3_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL4) = FORWARD Then
                mon_stn6_cyl4_fw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl4_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL4) = BACKWARD Then
                mon_stn6_cyl4_bw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl4_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL5) = FORWARD Then
                mon_stn6_cyl5_fw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl5_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL5) = BACKWARD Then
                mon_stn6_cyl5_bw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl5_bw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL6) = FORWARD Then
                mon_stn6_cyl6_fw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl6_fw.Image = My.Resources.led_red_off
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL6) = BACKWARD Then
                mon_stn6_cyl6_bw.Image = My.Resources.led_red_on
            Else
                mon_stn6_cyl6_bw.Image = My.Resources.led_red_off
            End If
        End If
    End Sub
    Private Sub ModbusWriter(output As Integer, address As Integer)
        If output = FORWARD Then
            Modbus.WriteData(REGISTER_TYPE, address, FORWARD)
        ElseIf output = BACKWARD Then
            Modbus.WriteData(REGISTER_TYPE, address, BACKWARD)
        Else
            Modbus.WriteData(REGISTER_TYPE, address, IDLE)
        End If
    End Sub
    Private Sub PlcWriting()
        'STN1
        If STN1_CYL1 <> LAST_STN1_CYL1 Then
            ModbusWriter(STN1_CYL1, ADDR_STN1_CYL1)
            LAST_STN1_CYL1 = STN1_CYL1
        End If

        If STN1_CYL2 <> LAST_STN1_CYL2 Then
            ModbusWriter(STN1_CYL2, ADDR_STN1_CYL2)
            LAST_STN1_CYL2 = STN1_CYL2
        End If

        If STN1_CYL3 <> LAST_STN1_CYL3 Then
            ModbusWriter(STN1_CYL3, ADDR_STN1_CYL3)
            LAST_STN1_CYL3 = STN1_CYL3
        End If

        If STN1_CYL4 <> LAST_STN1_CYL4 Then
            ModbusWriter(STN1_CYL4, ADDR_STN1_CYL4)
            LAST_STN1_CYL4 = STN1_CYL4
        End If

        'STN2
        If STN2_CYL1 <> LAST_STN2_CYL1 Then
            ModbusWriter(STN2_CYL1, ADDR_STN2_CYL1)
            LAST_STN2_CYL1 = STN2_CYL1
        End If

        If STN2_CYL2 <> LAST_STN2_CYL2 Then
            ModbusWriter(STN2_CYL2, ADDR_STN2_CYL2)
            LAST_STN2_CYL2 = STN2_CYL2
        End If

        If STN2_CYL3 <> LAST_STN2_CYL3 Then
            ModbusWriter(STN2_CYL3, ADDR_STN2_CYL3)
            LAST_STN2_CYL3 = STN2_CYL3
        End If

        If STN2_CYL4 <> LAST_STN2_CYL4 Then
            ModbusWriter(STN2_CYL4, ADDR_STN2_CYL4)
            LAST_STN2_CYL4 = STN2_CYL4
        End If

        'STN3
        If STN3_CYL1 <> LAST_STN3_CYL1 Then
            ModbusWriter(STN3_CYL1, ADDR_STN3_CYL1)
            LAST_STN3_CYL1 = STN3_CYL1
        End If

        If STN3_CYL2 <> LAST_STN3_CYL2 Then
            ModbusWriter(STN3_CYL2, ADDR_STN3_CYL2)
            LAST_STN3_CYL2 = STN3_CYL2
        End If

        If STN3_CYL3 <> LAST_STN3_CYL3 Then
            ModbusWriter(STN3_CYL3, ADDR_STN3_CYL3)
            LAST_STN3_CYL3 = STN3_CYL3
        End If

        If STN3_CYL4 <> LAST_STN3_CYL4 Then
            ModbusWriter(STN3_CYL4, ADDR_STN3_CYL4)
            LAST_STN3_CYL4 = STN3_CYL4
        End If

        'STN4
        If STN4_CYL1 <> LAST_STN4_CYL1 Then
            ModbusWriter(STN4_CYL1, ADDR_STN4_CYL1)
            LAST_STN4_CYL1 = STN4_CYL1
        End If

        If STN4_CYL2 <> LAST_STN4_CYL2 Then
            ModbusWriter(STN4_CYL2, ADDR_STN4_CYL2)
            LAST_STN4_CYL2 = STN4_CYL2
        End If

        If STN4_CYL3 <> LAST_STN4_CYL3 Then
            ModbusWriter(STN4_CYL3, ADDR_STN4_CYL3)
            LAST_STN4_CYL3 = STN4_CYL3
        End If

        If STN4_CYL4 <> LAST_STN4_CYL4 Then
            ModbusWriter(STN4_CYL4, ADDR_STN4_CYL4)
            LAST_STN4_CYL4 = STN4_CYL4
        End If

        'STN5
        If STN5_CYL1 <> LAST_STN5_CYL1 Then
            ModbusWriter(STN5_CYL1, ADDR_STN5_CYL1)
            LAST_STN5_CYL1 = STN5_CYL1
        End If

        If STN5_CYL2 <> LAST_STN5_CYL2 Then
            ModbusWriter(STN5_CYL2, ADDR_STN5_CYL2)
            LAST_STN5_CYL2 = STN5_CYL2
        End If

        If STN5_CYL3 <> LAST_STN5_CYL3 Then
            ModbusWriter(STN5_CYL3, ADDR_STN5_CYL3)
            LAST_STN5_CYL3 = STN5_CYL3
        End If

        If STN5_CYL4 <> LAST_STN5_CYL4 Then
            ModbusWriter(STN5_CYL4, ADDR_STN5_CYL4)
            LAST_STN5_CYL4 = STN5_CYL4
        End If

        'STN6
        If STN6_CYL1 <> LAST_STN6_CYL1 Then
            ModbusWriter(STN6_CYL1, ADDR_STN6_CYL1)
            LAST_STN6_CYL1 = STN6_CYL1
        End If

        If STN6_CYL2 <> LAST_STN6_CYL2 Then
            ModbusWriter(STN6_CYL2, ADDR_STN6_CYL2)
            LAST_STN6_CYL2 = STN6_CYL2
        End If

        If STN6_CYL3 <> LAST_STN6_CYL3 Then
            ModbusWriter(STN6_CYL3, ADDR_STN6_CYL3)
            LAST_STN6_CYL3 = STN6_CYL3
        End If

        If STN6_CYL4 <> LAST_STN6_CYL4 Then
            ModbusWriter(STN6_CYL4, ADDR_STN6_CYL4)
            LAST_STN6_CYL4 = STN6_CYL4
        End If

        If STN6_CYL5 <> LAST_STN6_CYL5 Then
            ModbusWriter(STN6_CYL5, ADDR_STN6_CYL5)
            LAST_STN6_CYL5 = STN6_CYL5
        End If

        If STN6_CYL6 <> LAST_STN6_CYL6 Then
            ModbusWriter(STN6_CYL6, ADDR_STN6_CYL6)
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
        If txt_ref.Text = "" Or txt_ope_id.Text = "" Or txt_po_num.Text = "" Then
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
            ind_door_lock_1.BackColor = Color.Red
        Else
            ind_door_lock_1.BackColor = Color.DarkRed
        End If

        If binaryString(14) = "1" Then
            ind_door_lock_2.BackColor = Color.Red
        Else
            ind_door_lock_2.BackColor = Color.DarkRed
        End If

        If binaryString(13) = "1" Then
            ind_door_lock_3.BackColor = Color.Red
        Else
            ind_door_lock_3.BackColor = Color.DarkRed
        End If

        If binaryString(12) = "1" Then
            ind_door_lock_4.BackColor = Color.Red
        Else
            ind_door_lock_4.BackColor = Color.DarkRed
        End If

        If binaryString(11) = "1" Then
            ind_door_lock_5.BackColor = Color.Red
        Else
            ind_door_lock_5.BackColor = Color.DarkRed
        End If

        If binaryString(10) = "1" Then
            ind_door_lock_6.BackColor = Color.Red
        Else
            ind_door_lock_6.BackColor = Color.DarkRed
        End If

        If binaryString(9) = "1" Then
            ind_altivar_fault.BackColor = Color.Red
        Else
            ind_altivar_fault.BackColor = Color.DarkRed
        End If

        If binaryString(8) = "1" Then
            ind_air_presence.BackColor = Color.Red
        Else
            ind_air_presence.BackColor = Color.DarkRed
        End If

        If binaryString(7) = "1" Then
            ind_emg_button.BackColor = Color.Red
        Else
            ind_emg_button.BackColor = Color.DarkRed
        End If
    End Sub
    Private Sub ReadAlarmStn2(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v201_descrepancy.BackColor = Color.Red
        Else
            ind_v201_descrepancy.BackColor = Color.DarkRed
        End If

        If binaryString(14) = "1" Then
            ind_v202_descrepancy.BackColor = Color.Red
        Else
            ind_v202_descrepancy.BackColor = Color.DarkRed
        End If
    End Sub
    Private Sub ReadAlarmStn3(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v301_descrepancy.BackColor = Color.Red
        Else
            ind_v301_descrepancy.BackColor = Color.DarkRed
        End If

        If binaryString(14) = "1" Then
            ind_v302_descrepancy.BackColor = Color.Red
        Else
            ind_v302_descrepancy.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub ReadAlarmStn4(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v401_descrepancy.BackColor = Color.Red
        Else
            ind_v401_descrepancy.BackColor = Color.DarkRed
        End If

        If binaryString(14) = "1" Then
            ind_v402_descrepancy.BackColor = Color.Red
        Else
            ind_v402_descrepancy.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub ReadAlarmStn5(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v501_descrepancy.BackColor = Color.Red
        Else
            ind_v501_descrepancy.BackColor = Color.DarkRed
        End If

        If binaryString(14) = "1" Then
            ind_v502_descrepancy.BackColor = Color.Red
        Else
            ind_v502_descrepancy.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub ReadAlarmStn6(decimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v601_descrepancy.BackColor = Color.Red
        Else
            ind_v601_descrepancy.BackColor = Color.DarkRed
        End If

        If binaryString(14) = "1" Then
            ind_v602_descrepancy.BackColor = Color.Red
        Else
            ind_v602_descrepancy.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub Status_Tick(sender As Object, e As EventArgs) Handles Status.Tick

        Select Case SCAN_MODE
            Case 0
                'txt_ref.Select()
                If txt_ref.Text <> "" Then
                    Call KoneksiDB.koneksi_db()

                    Dim sc As New SqlCommand("SELECT * FROM ProductDatabase WHERE Reff='" & txt_ref.Text & "'", KoneksiDB.koneksi)
                    Dim rd As SqlDataReader = sc.ExecuteReader
                    rd.Read()
                    If Not rd.HasRows Then
                        txt_msg.Text = "Invalid Reference"
                        txt_ref.Text = ""
                        Exit Sub
                    End If

                    SCAN_MODE = 1
                End If
            Case 1
                'txt_ope_id.Select()
                If txt_ope_id.Text <> "" Then
                    SCAN_MODE = 2
                End If
            Case 2
                'txt_po_num.Select()
                If txt_po_num.Text <> "" Then
                    'Insert data to database
                    Call KoneksiDB.koneksi_db()
                    Dim sc As New SqlCommand("SELECT * FROM ProductDatabase WHERE Reff='" & txt_ref.Text & "'", KoneksiDB.koneksi)
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
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_ACT_VAL, Single.Parse(lbl_act_val.Text))
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_ACT_VAL_TOL, Single.Parse(lbl_act_val_tol.Text))
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_DIF_STR, Single.Parse(lbl_dif_str.Text))
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_DIF_STR_TOL, Single.Parse(lbl_dif_str_tol.Text))
                    Modbus.WriteData(REGISTER_TYPE, ADDR_BEATING_TIMES, lbl_beating_times.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_CFG_FIRST_CONTACT, lbl_cfg_1st.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_CFG_SECOND_CONTACT, lbl_cfg_2nd.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_UNSCREWING_PROCESS, lbl_unscrew_process.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_LASER_DATE_CODE, lbl_laser_datecode.Text)
                    SCAN_MODE = 3
                End If
        End Select
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

        If Not MODBUS_ERR Then
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
        Else
            lbl_op_ins.Text = "Modbus Error, Please Check Modbus Connection!"
            ind_plc_status.BackColor = Color.DarkRed
        End If

    End Sub
    Private Sub BarcodeComm_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles BarcodeComm.DataReceived
        If SCAN_MODE = 0 Then
            'scanning References
            AssyBuff = BarcodeComm.ReadExisting()
            If InStr(1, AssyBuff, vbCrLf) <> 0 Then
                Me.Invoke(Sub()
                              AssyBuff = Mid(AssyBuff, 1, InStr(1, AssyBuff, vbCr) - 1)
                              txt_ref.Text = AssyBuff

                              Call KoneksiDB.koneksi_db()

                              Dim sc As New SqlCommand("SELECT * FROM ProductDatabase WHERE Reff='" & txt_ref.Text & "'", KoneksiDB.koneksi)
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
                              txt_ope_id.Text = AssyBuff

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
                              txt_po_num.Text = AssyBuff

                              'Insert data to database
                              Call KoneksiDB.koneksi_db()
                              Dim sc As New SqlCommand("SELECT * FROM ProductDatabase WHERE Reff='" & txt_ref.Text & "'", KoneksiDB.koneksi)
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
                              Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_ACT_VAL, Single.Parse(Val(lbl_act_val.Text)))
                              Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_ACT_VAL_TOL, Single.Parse(Val(lbl_act_val_tol.Text)))
                              Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_DIF_STR, Single.Parse(Val(lbl_dif_str.Text)))
                              Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_DIF_STR_TOL, Single.Parse(Val(lbl_dif_str_tol.Text)))
                              Modbus.WriteData(REGISTER_TYPE, ADDR_BEATING_TIMES, lbl_beating_times.Text)
                              Modbus.WriteData(REGISTER_TYPE, ADDR_CFG_FIRST_CONTACT, lbl_cfg_1st.Text)
                              Modbus.WriteData(REGISTER_TYPE, ADDR_CFG_SECOND_CONTACT, lbl_cfg_2nd.Text)
                              Modbus.WriteData(REGISTER_TYPE, ADDR_UNSCREWING_PROCESS, lbl_unscrew_process.Text)
                              Modbus.WriteData(REGISTER_TYPE, ADDR_LASER_DATE_CODE, lbl_laser_datecode.Text)

                              AssyBuff = ""
                              SCAN_MODE = 3
                          End Sub)
            End If
        End If
    End Sub
    Private Function CheckDuplicate() As Boolean
        Dim sc As New SqlCommand("SELECT * FROM Production_Data WHERE Reff='" & txt_ref.Text & "'", KoneksiDB.koneksi)
        Dim rd As SqlDataReader = sc.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Return False
            Exit Function
        End If
        If rd.Item("OperatorID") <> txt_ope_id.Text Then
            Return True
        End If
        Console.WriteLine(rd.Item("OperatorID"))
        Return False
    End Function
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        SCAN_MODE = 0
        txt_ref.Text = ""
        txt_ope_id.Text = ""
        txt_po_num.Text = ""
    End Sub
    Dim Action_ST2 As Integer = 1
    Private Sub ST2_Tick(sender As Object, e As EventArgs) Handles ST2.Tick
        If SCAN_MODE = 3 Then
            ST_COMM2 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM2)
            Dim binaryString As String = Convert.ToString(ST_COMM2, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                Me.Invoke(Sub()
                              txt_msg.Text = txt_msg.Text + "Start recording ST2 (Measuring)..." & vbCrLf
                              CNT_ST2 = CNT_ST2 + 1
                              Dim st2_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST2_MEASUREMENT)

                              Select Case Action_ST2
                                  Case 1
                                      lbl_item_1.Text = CNT_ST2
                                      lbl_st2_meas.Text = st2_result
                                      lbl_st3_res.Text = ""
                                      lbl_st4_p2.Text = ""
                                      lbl_st4_p3.Text = ""
                                      lbl_st4_t1.Text = ""
                                      lbl_st4_t2.Text = ""
                                      lbl_diff_result.Text = ""
                                      lbl_cot.Text = ""
                                      lbl_unscrew_status.Text = ""
                                      Action_ST2 += 1
                                  Case 2
                                      lbl_item_2.Text = CNT_ST2
                                      lbl_st2_meas_1.Text = st2_result
                                      lbl_st3_res_1.Text = ""
                                      lbl_st4_p2_1.Text = ""
                                      lbl_st4_p3_1.Text = ""
                                      lbl_st4_t1_1.Text = ""
                                      lbl_st4_t2_1.Text = ""
                                      lbl_diff_result_1.Text = ""
                                      lbl_cot_1.Text = ""
                                      lbl_unscrew_status_1.Text = ""
                                      Action_ST2 += 1
                                  Case 3
                                      lbl_item_3.Text = CNT_ST2
                                      lbl_st2_meas_2.Text = st2_result
                                      lbl_st3_res_2.Text = ""
                                      lbl_st4_p2_2.Text = ""
                                      lbl_st4_p3_2.Text = ""
                                      lbl_st4_t1_2.Text = ""
                                      lbl_st4_t2_2.Text = ""
                                      lbl_diff_result_2.Text = ""
                                      lbl_cot_2.Text = ""
                                      lbl_unscrew_status_2.Text = ""
                                      Action_ST2 += 1
                                  Case 4
                                      lbl_item_4.Text = CNT_ST2
                                      lbl_st2_meas_3.Text = st2_result
                                      lbl_st3_res_3.Text = ""
                                      lbl_st4_p2_3.Text = ""
                                      lbl_st4_p3_3.Text = ""
                                      lbl_st4_t1_3.Text = ""
                                      lbl_st4_t2_3.Text = ""
                                      lbl_diff_result_3.Text = ""
                                      lbl_cot_3.Text = ""
                                      lbl_unscrew_status_3.Text = ""
                                      Action_ST2 += 1
                                  Case 5
                                      lbl_item_5.Text = CNT_ST2
                                      lbl_st2_meas_4.Text = st2_result
                                      lbl_st3_res_4.Text = ""
                                      lbl_st4_p2_4.Text = ""
                                      lbl_st4_p3_4.Text = ""
                                      lbl_st4_t1_4.Text = ""
                                      lbl_st4_t2_4.Text = ""
                                      lbl_diff_result_4.Text = ""
                                      lbl_cot_4.Text = ""
                                      lbl_unscrew_status_4.Text = ""
                                      Action_ST2 += 1
                                  Case 6
                                      lbl_item_6.Text = CNT_ST2
                                      lbl_st2_meas_5.Text = st2_result
                                      lbl_st3_res_5.Text = ""
                                      lbl_st4_p2_5.Text = ""
                                      lbl_st4_p3_5.Text = ""
                                      lbl_st4_t1_5.Text = ""
                                      lbl_st4_t2_5.Text = ""
                                      lbl_diff_result_5.Text = ""
                                      lbl_cot_5.Text = ""
                                      lbl_unscrew_status_5.Text = ""
                                      Action_ST2 = 1
                              End Select

                              Call KoneksiDB.koneksi_db()
                              Dim sc As New SqlCommand("INSERT INTO Production_Data (No, Reff, OperatorID, ProductOrderNo, Measurement, DateTime) VALUES('" & CNT_ST2.ToString & "', '" & txt_ref.Text & "', '" & txt_ope_id.Text & "', '" & txt_po_num.Text & "', '" & st2_result & "', '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')", KoneksiDB.koneksi)
                              Dim adapter As New SqlDataAdapter(sc)
                              adapter.SelectCommand.ExecuteNonQuery()

                              txt_msg.Text = txt_msg.Text + "Finish recording ST2 Result = " + st2_result & vbCrLf
                              Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM2, 3)
                              lbl_cnt_st2.Text = CNT_ST2
                          End Sub)
            End If
        End If
    End Sub
    Dim Action_ST3 As Integer = 1
    Private Sub ST3_Tick(sender As Object, e As EventArgs) Handles ST3.Tick
        If SCAN_MODE = 3 Then
            ST_COMM3 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM3)
            Dim binaryString As String = Convert.ToString(ST_COMM3, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                Me.Invoke(Sub()
                              txt_msg.Text = txt_msg.Text + "Start recording ST3 (Resistance)..." & vbCrLf
                              CNT_ST3 = CNT_ST3 + 1
                              '======================== program baca resistant ========================
                              Dim Value As Decimal = Rnd()
                              Dim st3_result As String = Value.ToString

                              Select Case Action_ST3
                                  Case 1
                                      lbl_st3_res.Text = st3_result
                                      Action_ST3 += 1
                                  Case 2
                                      lbl_st3_res_1.Text = st3_result
                                      Action_ST3 += 1
                                  Case 3
                                      lbl_st3_res_2.Text = st3_result
                                      Action_ST3 += 1
                                  Case 4
                                      lbl_st3_res_3.Text = st3_result
                                      Action_ST3 += 1
                                  Case 5
                                      lbl_st3_res_4.Text = st3_result
                                      Action_ST3 += 1
                                  Case 6
                                      lbl_st3_res_5.Text = st3_result
                                      Action_ST3 = 1
                              End Select

                              Call KoneksiDB.koneksi_db()
                              Dim sc As New SqlCommand("UPDATE Production_Data SET Resistance = '" & st3_result & "' WHERE No = '" & CNT_ST3.ToString & "'", KoneksiDB.koneksi)
                              Dim adapter As New SqlDataAdapter(sc)
                              adapter.SelectCommand.ExecuteNonQuery()

                              txt_msg.Text = txt_msg.Text + "Finish recording ST3 Result = " + st3_result & vbCrLf
                              Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM3, 7) ' dummy
                              lbl_cnt_st3.Text = CNT_ST3
                          End Sub)
            End If
        End If
    End Sub
    Dim Action_ST4 As Integer = 1
    Private Sub ST4_Tick(sender As Object, e As EventArgs) Handles ST4.Tick
        If SCAN_MODE = 3 Then
            ST_COMM4 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM4)
            Dim binaryString As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                Me.Invoke(Sub()
                              txt_msg.Text = txt_msg.Text + "Start recording ST4..." & vbCrLf
                              CNT_ST4 = CNT_ST4 + 1
                              Dim st4_p2_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_P2_TRAVEL)
                              Dim st4_p3_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_P3_TRAVEL)
                              Dim diff_result_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_DIFF_STR_RESULT)
                              Dim st4_t1_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_T1)
                              Dim st4_t2_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_T2)
                              Dim cot_result As String = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_COT)

                              Select Case Action_ST4
                                  Case 1
                                      lbl_st4_p2.Text = st4_p2_result
                                      lbl_st4_p3.Text = st4_p3_result
                                      lbl_diff_result.Text = diff_result_result
                                      lbl_st4_t1.Text = st4_t1_result
                                      lbl_st4_t2.Text = st4_t2_result
                                      lbl_cot.Text = cot_result
                                      Action_ST4 += 1
                                  Case 2
                                      lbl_st4_p2_1.Text = st4_p2_result
                                      lbl_st4_p3_1.Text = st4_p3_result
                                      lbl_diff_result_1.Text = diff_result_result
                                      lbl_st4_t1_1.Text = st4_t1_result
                                      lbl_st4_t2_1.Text = st4_t2_result
                                      lbl_cot_1.Text = cot_result
                                      Action_ST4 += 1
                                  Case 3
                                      lbl_st4_p2_2.Text = st4_p2_result
                                      lbl_st4_p3_2.Text = st4_p3_result
                                      lbl_diff_result_2.Text = diff_result_result
                                      lbl_st4_t1_2.Text = st4_t1_result
                                      lbl_st4_t2_2.Text = st4_t2_result
                                      lbl_cot_2.Text = cot_result
                                      Action_ST4 += 1
                                  Case 4
                                      lbl_st4_p2_3.Text = st4_p2_result
                                      lbl_st4_p3_3.Text = st4_p3_result
                                      lbl_diff_result_3.Text = diff_result_result
                                      lbl_st4_t1_3.Text = st4_t1_result
                                      lbl_st4_t2_3.Text = st4_t2_result
                                      lbl_cot_3.Text = cot_result
                                      Action_ST4 += 1
                                  Case 5
                                      lbl_st4_p2_4.Text = st4_p2_result
                                      lbl_st4_p3_4.Text = st4_p3_result
                                      lbl_diff_result_4.Text = diff_result_result
                                      lbl_st4_t1_4.Text = st4_t1_result
                                      lbl_st4_t2_4.Text = st4_t2_result
                                      lbl_cot_4.Text = cot_result
                                      Action_ST4 += 1
                                  Case 6
                                      lbl_st4_p2_5.Text = st4_p2_result
                                      lbl_st4_p3_5.Text = st4_p3_result
                                      lbl_diff_result_5.Text = diff_result_result
                                      lbl_st4_t1_5.Text = st4_t1_result
                                      lbl_st4_t2_5.Text = st4_t2_result
                                      lbl_cot_5.Text = cot_result
                                      Action_ST4 = 1
                              End Select

                              Call KoneksiDB.koneksi_db()
                              Dim sc As New SqlCommand("UPDATE Production_Data SET TravelP2 = '" & st4_p2_result & "', TravelP3 = '" & st4_p3_result & "', Difference = '" & diff_result_result & "', ST4T1 = '" & st4_t1_result & "', ST4T2 = '" & st4_t2_result & "', COT = '" & cot_result & "' WHERE No = '" & CNT_ST4.ToString & "'", KoneksiDB.koneksi)
                              Dim adapter As New SqlDataAdapter(sc)
                              adapter.SelectCommand.ExecuteNonQuery()

                              txt_msg.Text = txt_msg.Text + "Finish recording ST4 Result = " & vbCrLf
                              txt_msg.Text = txt_msg.Text + "P2 = " + st4_p2_result & vbCrLf
                              txt_msg.Text = txt_msg.Text + "P3 = " + st4_p3_result & vbCrLf
                              txt_msg.Text = txt_msg.Text + "Diff = " + diff_result_result & vbCrLf
                              txt_msg.Text = txt_msg.Text + "T1 = " + st4_t1_result & vbCrLf
                              txt_msg.Text = txt_msg.Text + "T2 = " + st4_t2_result & vbCrLf
                              txt_msg.Text = txt_msg.Text + "COT = " + cot_result & vbCrLf
                              Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM4, 3)
                              lbl_cnt_st4.Text = CNT_ST4
                          End Sub)
            End If
        End If
    End Sub
    Dim Action_ST5 As Integer = 1
    Private Sub ST5_Tick(sender As Object, e As EventArgs) Handles ST5.Tick
        If SCAN_MODE = 3 Then
            ST_COMM5 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM5)
            Dim binaryString As String = Convert.ToString(ST_COMM5, 2).PadLeft(16, "0"c)
            If binaryString(15) = "1" And binaryString(14) = "0" Then
                Me.Invoke(Sub()
                              txt_msg.Text = txt_msg.Text + "Start recording ST5 (Unscrewing)..." & vbCrLf
                              CNT_ST5 = CNT_ST5 + 1
                              Dim unscrew_status_result As String = Modbus.ReadData(REGISTER_TYPE, ADDR_UNSCREW_STATUS)

                              Select Case Action_ST5
                                  Case 1
                                      lbl_unscrew_status.Text = unscrew_status_result
                                      Action_ST5 += 1
                                  Case 2
                                      lbl_unscrew_status_1.Text = unscrew_status_result
                                      Action_ST5 += 1
                                  Case 3
                                      lbl_unscrew_status_2.Text = unscrew_status_result
                                      Action_ST5 += 1
                                  Case 4
                                      lbl_unscrew_status_3.Text = unscrew_status_result
                                      Action_ST5 += 1
                                  Case 5
                                      lbl_unscrew_status_4.Text = unscrew_status_result
                                      Action_ST5 += 1
                                  Case 6
                                      lbl_unscrew_status_5.Text = unscrew_status_result
                                      Action_ST5 = 1
                              End Select

                              Call KoneksiDB.koneksi_db()
                              Dim sc As New SqlCommand("UPDATE Production_Data SET UnscrewStatus = '" & unscrew_status_result & "' WHERE No = '" & CNT_ST5.ToString & "'", KoneksiDB.koneksi)
                              Dim adapter As New SqlDataAdapter(sc)
                              adapter.SelectCommand.ExecuteNonQuery()

                              txt_msg.Text = txt_msg.Text + "Finish recording ST5 Result = " + unscrew_status_result & vbCrLf
                              Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM5, 3)
                              lbl_cnt_st5.Text = CNT_ST5
                          End Sub)
            End If
        End If
    End Sub

    Private Sub btn_clear_database_Click(sender As Object, e As EventArgs) Handles btn_clear_database.Click
        Call KoneksiDB.koneksi_db()
        Dim sc As New SqlCommand("DELETE from Production_Data;", KoneksiDB.koneksi)
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

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        'Hide()
        frmLogin.ShowDialog()
        If USER_LEVEL = 1 Then
            lbl_user.Text = "ADM"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
        ElseIf USER_LEVEL = 2 Then
            lbl_user.Text = "ENG"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
        ElseIf USER_LEVEL = 3 Then
            lbl_user.Text = "OPE"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
        End If
    End Sub
    'panel multi
    Private Sub btn_read_ch_1_Click(sender As Object, e As EventArgs) Handles btn_read_ch_1.Click
        Multimeter.OpenChannel(102)
        Multimeter.CloseChannel(101)
        Thread.Sleep(10)
        Dim productRes As Double = Multimeter.MeasureResistance()
        txt_ch_1.Text = productRes.ToString
        txt_ch_2.Text = ""
    End Sub

    Private Sub btn_read_ch_2_Click(sender As Object, e As EventArgs) Handles btn_read_ch_2.Click
        Multimeter.OpenChannel(101)
        Multimeter.CloseChannel(102)
        Thread.Sleep(10)
        Dim productRes As Double = Multimeter.MeasureResistance()
        txt_ch_2.Text = productRes.ToString
        txt_ch_1.Text = ""
    End Sub
    ' panel references
    Private Sub LoadTbRef()
        Call KoneksiDB.koneksi_db()
        Try
            Dim sc As New SqlCommand("SELECT * FROM ProductDatabase order by Reff asc", KoneksiDB.koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            dgv_ref.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss => ") + "Error: Database not found!")
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_ref_pnl.Text = "" And txt_act_val_pnl.Text = "" And txt_act_val_tol_pnl.Text = "" And txt_dif_str_pnl.Text = "" And txt_dif_str_tol_pnl.Text = "" And txt_beating_times_pnl.Text = "" And txt_cfg_1st_pnl.Text = "" And txt_cfg_2nd_pnl.Text = "" And txt_unscrew_pnl.Text = "" And txt_laser_datecode_pnl.Text = "" And txt_laser_template_pnl.Text = "" Then
            MsgBox("Please Fill All Field!")
            Exit Sub
        Else
            Call KoneksiDB.koneksi_db()
            Dim sc As New SqlCommand("INSERT INTO ProductDatabase (Reff, ActVal, ActValTol, DifStr, DifStrTol, BeatingTimes, FirstContact, SecondContact, UnscrewingProcess, LaserDateCode, LaserTemplate) VALUES('" & txt_ref_pnl.Text & "', '" & txt_act_val_pnl.Text & "', '" & txt_act_val_tol_pnl.Text & "', '" & txt_dif_str_pnl.Text & "', '" & txt_dif_str_tol_pnl.Text & "', '" & txt_beating_times_pnl.Text & "', '" & txt_cfg_1st_pnl.Text & "', '" & txt_cfg_2nd_pnl.Text & "', '" & txt_unscrew_pnl.Text & "', '" & txt_laser_datecode_pnl.Text & "', '" & txt_laser_template_pnl.Text & "')", KoneksiDB.koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_ref_pnl.Text = "" Then
            MsgBox("Please Fill Product References")
            Exit Sub
        Else
            Call KoneksiDB.koneksi_db()
            Dim sc As New SqlCommand("DELETE from ProductDatabase where Reff = '" & txt_ref_pnl.Text & "'", KoneksiDB.koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_ref_pnl.Text = "" Then
            MsgBox("Please Fill Product References")
            Exit Sub
        Else
            Call KoneksiDB.koneksi_db()
            Dim sc As New SqlCommand("UPDATE ProductDatabase SET ActVal = '" & txt_act_val_pnl.Text & "', ActValTol = '" & txt_act_val_tol_pnl.Text & "', DifStr = '" & txt_dif_str_pnl.Text & "', DifStrTol = '" & txt_dif_str_tol_pnl.Text & "', BeatingTimes = '" & txt_beating_times_pnl.Text & "', FirstContact = '" & txt_cfg_1st_pnl.Text & "', SecondContact = '" & txt_cfg_2nd_pnl.Text & "', UnscrewingProcess = '" & txt_unscrew_pnl.Text & "', LaserDatecode = '" & txt_laser_datecode_pnl.Text & "', LaserTemplate = '" & txt_laser_template_pnl.Text & "'", KoneksiDB.koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub
    ' panel log
    Private Sub btn_search_other_Click(sender As Object, e As EventArgs) Handles btn_search_other.Click
        Select Case cb_search_opt.Text
            Case "References"
                Me.Invoke(Sub()
                              txt_log.Text = "Searching Database....." + vbCrLf
                              Call KoneksiDB.koneksi_db()
                              Try
                                  Dim sc As New SqlCommand("SELECT * FROM Production_Data where Reff = '" & txt_find_other.Text & "' ORDER BY No ASC", KoneksiDB.koneksi)
                                  Dim adapter As New SqlDataAdapter(sc)
                                  Dim ds As New DataSet

                                  adapter.Fill(ds)
                                  DataGridView1.DataSource = ds.Tables(0)
                              Catch ex As Exception
                                  txt_log.Text = txt_log.Text + "Error: Database not found!" + vbCrLf
                              End Try
                              txt_log.Text = txt_log.Text + "Done Searching Database....." + vbCrLf
                          End Sub)
            Case "PO Number"
                Me.Invoke(Sub()
                              txt_log.Text = "Searching Database....." + vbCrLf
                              Call KoneksiDB.koneksi_db()
                              Try
                                  Dim sc As New SqlCommand("SELECT * FROM Production_Data where ProductOrderNo = '" & txt_find_other.Text & "' ORDER BY No ASC", KoneksiDB.koneksi)
                                  Dim adapter As New SqlDataAdapter(sc)
                                  Dim ds As New DataSet

                                  adapter.Fill(ds)
                                  DataGridView1.DataSource = ds.Tables(0)
                              Catch ex As Exception
                                  txt_log.Text = txt_log.Text + "Error: Database not found!" + vbCrLf
                              End Try
                              txt_log.Text = txt_log.Text + "Done Searching Database....." + vbCrLf
                          End Sub)
            Case "Operator ID"
                Me.Invoke(Sub()
                              txt_log.Text = "Searching Database....." + vbCrLf
                              Call KoneksiDB.koneksi_db()
                              Try
                                  Dim sc As New SqlCommand("SELECT * FROM Production_Data where OperatorID = '" & txt_find_other.Text & "' ORDER BY No ASC", KoneksiDB.koneksi)
                                  Dim adapter As New SqlDataAdapter(sc)
                                  Dim ds As New DataSet

                                  adapter.Fill(ds)
                                  DataGridView1.DataSource = ds.Tables(0)
                              Catch ex As Exception
                                  txt_log.Text = txt_log.Text + "Error: Database not found!" + vbCrLf
                              End Try
                              txt_log.Text = txt_log.Text + "Done Searching Database....." + vbCrLf
                          End Sub)
        End Select
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Me.Invoke(Sub()
                      Try
                          txt_log.Text = "Searching Database....." + vbCrLf
                          Dim range1 As String = DateTimePickerStartDate.Value.ToString("yyyy-MM-dd 00:00:00")
                          Dim range2 As String = DateTimePickerEndDate.Value.ToString("yyyy-MM-dd 23:59:59")

                          Call KoneksiDB.koneksi_db()
                          ' Try
                          Dim sc As New SqlCommand("SELECT * FROM Production_Data WHERE DateTime BETWEEN '" + range1 + "' AND '" + range2 + "' ORDER BY No ASC", KoneksiDB.koneksi)
                          Dim adapter As New SqlDataAdapter(sc)
                          Dim ds As New DataSet

                          adapter.Fill(ds)
                          DataGridView1.DataSource = ds.Tables(0)
                      Catch ex As Exception
                          txt_log.Text = txt_log.Text + "Error: Database not found!" + vbCrLf
                      End Try
                      txt_log.Text = txt_log.Text + "Done Searching Database....." + vbCrLf
                  End Sub)
    End Sub

    Private Sub btn_empty_Click(sender As Object, e As EventArgs) Handles btn_empty.Click
        Dim empty_process As String = Modbus.ReadData(REGISTER_TYPE, ADDR_EMPTY_PROCCESS)

        If Val(empty_process) <> 2 And Val(empty_process) <> 4 And Val(empty_process) <> 1 Then
            Modbus.WriteData(REGISTER_TYPE, ADDR_EMPTY_PROCCESS, 1)
        ElseIf Val(empty_process) = 2 Then
            MsgBox("Please Wait Until Emptying Process Is Finish")
        ElseIf Val(empty_process) = 1 Then
            MsgBox("Emptying In Process")
        End If
    End Sub
End Class