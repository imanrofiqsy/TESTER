Imports System.Threading
Imports System.Data.SqlClient
Imports System.IO
Imports ControlBPM
Public Class frmMain
    Dim Modbus = New Modbus()
    Dim Multimeter = New Multimeter()
    Dim Laser = New CyklopLaser()
    Dim ThreadLoadFrm As Thread
    Dim ThreadST2 As Thread
    Dim ThreadST3 As Thread
    Dim ThreadST4 As Thread
    Dim ThreadST5 As Thread

    Dim AssyBuff As String
    Dim ManualState As Boolean
    Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim projectFolder As String = fullPath.Replace("\TESTER\bin\Debug\", "").Replace("\TESTER\bin\Release\", "")
    Dim iniPath As String = projectFolder + "\Config\Config.INI"
    Dim alarmFileName As String = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
    Dim logFileName As String = $"Log_{Date.Now.ToString("yyyyMMdd")}.csv"

    Dim delay As Integer = 0
    Dim EmgState As Integer = 0
    Dim delayScroll As Integer = 0
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initLoadingBar()

        If Not Directory.Exists(projectFolder + "/Log") Then
            MsgBox("Log folder not found!", MsgBoxStyle.SystemModal, "On Top")
            End
        End If

        If Not Directory.Exists(projectFolder + "/Alarm") Then
            MsgBox("Alarm folder not found!", MsgBoxStyle.SystemModal, "On Top")
            End
        End If

        With Config
            .addressPlc = ReadINI(iniPath, "PLC", "IP")
            .portPlc = ReadINI(iniPath, "PLC", "Port")
            .addressLaser = ReadINI(iniPath, "LASER", "IP")
            .portLaser = ReadINI(iniPath, "LASER", "Port")
            .dbHostName = ReadINI(iniPath, "DATABASE", "Hostname")
            .dbUsername = ReadINI(iniPath, "DATABASE", "Username")
            .dbPassword = ReadINI(iniPath, "DATABASE", "Password")
            .dbDatabase = ReadINI(iniPath, "DATABASE", "Database")
            .instrumentBaud = ReadINI(iniPath, "INSTRUMENT", "Baudrate")
            .instrumentName = ReadINI(iniPath, "INSTRUMENT", "Name")
            .instrumentPort = ReadINI(iniPath, "INSTRUMENT", "Port")
            .ResistanceOffset = Double.Parse(ReadINI(iniPath, "INSTRUMENT", "Offset"))
            .sequenceCounter = ReadINI(iniPath, "STATUS", "SequenceCounter")

            ChromaComm.BaudRate = .instrumentBaud
            ChromaComm.PortName = .instrumentPort

            txtIP_PLC.Text = .addressPlc
            txtPort_PLC.Text = .portPlc
            txtIP_laser.Text = .addressLaser
            txtPort_laser.Text = .portLaser
            txt_hostname.Text = .dbHostName
            txt_username.Text = .dbUsername
            txt_password.Text = .dbPassword
            txt_database.Text = .dbDatabase
            txt_name_multi.Text = .instrumentName
            txt_port_multi.Text = .instrumentPort
            txt_baud_multi.Text = .instrumentBaud
            txt_offset_multi.Text = .ResistanceOffset

            CNT_ST2 = CInt(.sequenceCounter)
            CNT_ST4 = CInt(.sequenceCounter)
            CNT_ST5 = CInt(.sequenceCounter)
        End With

        btn_connect_plc.PerformClick()
        Hide()
        UpdateLoadingBar(20, "Connecting to PLC...")
        Thread.Sleep(500)

        Try
            If Not Modbus.ReadData(REGISTER_TYPE, 100200) = 2 Then
                MsgBox("Cannot establish connection to PLC!", MsgBoxStyle.SystemModal, "On Top")
                End
            End If
        Catch ex As Exception
            MsgBox("Cannot establish connection to PLC!", MsgBoxStyle.SystemModal, "On Top")
            End
        End Try

        ShowPanelGeneral("home")
        ShowButtonSTN(0)
        ShowPanelManual("None")
        UpdateLoadingBar(40, "Connecting to Chroma...")

        Try
            ChromaComm.Open()
            btn_open_multi.Text = "Close Port"
            connect_multi_ind.BackColor = Color.Lime
        Catch ex As Exception
            MsgBox("Error. " + ex.Message, MsgBoxStyle.SystemModal, "On Top")
            connect_multi_ind.BackColor = Color.Red
            End
        End Try

        ''init chroma
        ChromaComm.Write("*IDN?" & vbCrLf)
        Thread.Sleep(100)
        If Not strChromaRaw = Config.instrumentName Then
            MsgBox("Cannot establish connection to chroma!", MsgBoxStyle.SystemModal, "On Top")
            End
        End If

        Thread.Sleep(200)

        UpdateLoadingBar(60, "Connecting to Laser...")
        Try
            If Not Laser.is_connected() Then
                Laser.Connect()
                btn_connect_laser.Text = "Disconnect"
                connect_laser_ind.BackColor = Color.Lime
            End If
        Catch ex As Exception
            MsgBox("Cannot establish connection to Laser! " + ex.Message, MsgBoxStyle.SystemModal, "On Top")
            End
        End Try

        If Not initCyklop() Then
            MsgBox("Cannot establish connection to Laser! ", MsgBoxStyle.SystemModal, "On Top")
            End
        End If

        Thread.Sleep(200)

        'BarcodeComm.Open()
        ThreadST2 = New Thread(AddressOf ST2_Thread)
        ThreadST2.Start()
        ThreadST3 = New Thread(AddressOf ST3_Thread)
        ThreadST3.Start()
        ThreadST4 = New Thread(AddressOf ST4_Thread)
        ThreadST4.Start()
        ThreadST5 = New Thread(AddressOf ST5_Thread)
        ThreadST5.Start()
        Status.Enabled = True
        UpdateLoadingBar(80, "Creating Multithreading...")
        Thread.Sleep(500)

        GetPCStatus("OPEN") 'Software is open

        UpdateLoadingBar(100, "Load App GUI...")
        Thread.Sleep(500)
        CloseLoadForm()
        Cursor = Cursors.Default
        frmLogin.TopMost = True
        frmLogin.ShowDialog()
        GetUserLevel()
        Show()
    End Sub
    Private Function initCyklop() As Boolean
        Laser.GetMarkStatus
        Thread.Sleep(100)
        If Laser.ReadData("2") Then
            Return True
        End If
        Return False
    End Function
    Private Function initChroma() As Boolean
        If Not Set_chroma("*IDN?", Config.instrumentName) Then
            Return False
            Exit Function
        End If
        strChromaRaw = ""
        Return True
    End Function
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
            Thread.Sleep(100)
        Loop
    End Sub
    Private Sub CloseLoadForm()
        ThreadLoadFrm.Abort()
    End Sub
    Private Sub GetPCStatus(state As String)
        If Status.Enabled = True And Not MODBUS_ERR Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(PC_STATUS, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 15 Then
                    If state = "OPEN" Then
                        temp(i) = 1
                        ind_software_open.BackColor = Color.Lime
                    End If
                ElseIf i = 14 Then
                    If state = "RUN" Then
                        temp(i) = 1
                        temp(15) = 1
                        ind_software_run.BackColor = Color.Lime
                    Else
                        temp(i) = 0
                        ind_software_run.BackColor = Color.Red
                    End If
                ElseIf i = 13 Then
                    If state = "STOP" Then
                        temp(i) = 1
                        temp(15) = 1
                        ind_software_stop.BackColor = Color.Lime
                    Else
                        temp(i) = 0
                        ind_software_stop.BackColor = Color.Red
                    End If
                ElseIf i = 12 Then
                    If state = "EMPTYING" Then
                        temp(i) = 1
                        temp(15) = 1
                    Else
                        temp(i) = 0
                    End If
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_PC_STATUS, integerValue_)
        End If
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

        With Config
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav1"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_2, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav2"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_3, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav3"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_4, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav4"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_5, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav5"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_6, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav6"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST3, ReadINI(iniPath, "CALIBRATION", "Posst3"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_SET_VEL_ST3, ReadINI(iniPath, "CALIBRATION", "Velst3"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST4, ReadINI(iniPath, "CALIBRATION", "Posst4"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_SET_VEL_ST4, ReadINI(iniPath, "CALIBRATION", "Velst4"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_1, ReadINI(iniPath, "CALIBRATION", "P0st4Cav1"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_2, ReadINI(iniPath, "CALIBRATION", "P0st4Cav2"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_3, ReadINI(iniPath, "CALIBRATION", "P0st4Cav3"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_4, ReadINI(iniPath, "CALIBRATION", "P0st4Cav4"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_5, ReadINI(iniPath, "CALIBRATION", "P0st4Cav5"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_6, ReadINI(iniPath, "CALIBRATION", "P0st4Cav6"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_1, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav1"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_2, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav2"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_3, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav3"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_4, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav4"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_5, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav5"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_6, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav6"))

            txt_st2_cal_val_1.Text = ReadINI(iniPath, "CALIBRATION", "HeidenhainCav1")
            txt_st2_cal_val_2.Text = ReadINI(iniPath, "CALIBRATION", "HeidenhainCav2")
            txt_st2_cal_val_3.Text = ReadINI(iniPath, "CALIBRATION", "HeidenhainCav3")
            txt_st2_cal_val_4.Text = ReadINI(iniPath, "CALIBRATION", "HeidenhainCav4")
            txt_st2_cal_val_5.Text = ReadINI(iniPath, "CALIBRATION", "HeidenhainCav5")
            txt_st2_cal_val_6.Text = ReadINI(iniPath, "CALIBRATION", "HeidenhainCav6")
            txt_st3_set_pos.Text = ReadINI(iniPath, "CALIBRATION", "Posst3")
            txt_st3_set_vel.Text = ReadINI(iniPath, "CALIBRATION", "Velst3")
            txt_st4_set_pos.Text = ReadINI(iniPath, "CALIBRATION", "Posst4")
            txt_st4_set_vel.Text = ReadINI(iniPath, "CALIBRATION", "Velst4")
            txt_st4_cal_val_p0_1.Text = ReadINI(iniPath, "CALIBRATION", "P0st4Cav1")
            txt_st4_cal_val_p0_2.Text = ReadINI(iniPath, "CALIBRATION", "P0st4Cav2")
            txt_st4_cal_val_p0_3.Text = ReadINI(iniPath, "CALIBRATION", "P0st4Cav3")
            txt_st4_cal_val_p0_4.Text = ReadINI(iniPath, "CALIBRATION", "P0st4Cav4")
            txt_st4_cal_val_p0_5.Text = ReadINI(iniPath, "CALIBRATION", "P0st4Cav5")
            txt_st4_cal_val_p0_6.Text = ReadINI(iniPath, "CALIBRATION", "P0st4Cav6")
            txt_st4_cal_val_gt2_1.Text = ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav1")
            txt_st4_cal_val_gt2_2.Text = ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav2")
            txt_st4_cal_val_gt2_3.Text = ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav3")
            txt_st4_cal_val_gt2_4.Text = ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav4")
            txt_st4_cal_val_gt2_5.Text = ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav5")
            txt_st4_cal_val_gt2_6.Text = ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav6")
        End With
        ShowPanelGeneral("manual")
        ShowPanelManual("STN1")
        btn_stop.PerformClick()
    End Sub
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        ShowPanelGeneral("setting")
    End Sub
    Private Sub btn_calib_Click(sender As Object, e As EventArgs) Handles btn_calib.Click
        ShowPanelGeneral("calib")
    End Sub
    Private Sub btn_monitoring_Click(sender As Object, e As EventArgs) Handles btn_monitoring.Click
        ShowPanelGeneral("monitoring")
    End Sub
    Private Sub btn_alarm_Click(sender As Object, e As EventArgs) Handles btn_alarm.Click
        ShowPanelGeneral("alarm")
        delayScroll = 10
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

        If mode = "calib" Then
            CALIBRATION = True
            pnl_calibration.Visible = True
            dgv_calibration.Rows.Clear()
            dgv_calibration.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
            dgv_calibration.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14)
        Else
            CALIBRATION = False
            pnl_calibration.Visible = False
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
                connect_plc_ind.BackColor = Color.Lime
                ModbusRW.Enabled = True
                MODBUS_ERR = False
            End If
        ElseIf btn_connect_plc.Text = "Disconnect" Then
            If Modbus.ClosePort() Then
                btn_connect_plc.Text = "Connect"
                connect_plc_ind.BackColor = Color.Red
                ind_plc_status.BackColor = Color.Red
                ModbusRW.Enabled = False
            End If
        End If
    End Sub

    Private Sub btn_connect_laser_Click(sender As Object, e As EventArgs) Handles btn_connect_laser.Click
        If btn_connect_laser.Text = "Connect" Then
            If Not Laser.is_connected Then
                Laser.Connect
                btn_connect_laser.Text = "Disconnect"
                connect_laser_ind.BackColor = Color.Lime
            End If
        ElseIf btn_connect_laser.Text = "Disconnect" Then
            If Laser.is_connected Then
                Laser.Disconnect
                btn_connect_laser.Text = "Connect"
                connect_laser_ind.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub btn_connect_multi_Click(sender As Object, e As EventArgs) Handles btn_open_multi.Click
        If btn_open_multi.Text = "Open Port" Then
            Try
                ChromaComm.Open()
                btn_open_multi.Text = "Close Port"
                connect_multi_ind.BackColor = Color.Lime
            Catch ex As Exception
                MsgBox("Error. " + ex.Message)
                connect_multi_ind.BackColor = Color.Red
            End Try
        ElseIf btn_open_multi.Text = "Close Port" Then
            Try
                ChromaComm.Close()
                btn_open_multi.Text = "Open Port"
                connect_multi_ind.BackColor = Color.Red
            Catch ex As Exception
                MsgBox("Error. " + ex.Message)
                connect_multi_ind.BackColor = Color.Red
            End Try

        End If
    End Sub
    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        If cbo_data_type.Text = "FLOAT" Then
            txtValue.Text = Modbus.ReadDataFloat(REGISTER_TYPE, txtAddress.Text)
        ElseIf cbo_data_type.Text = "INT 16" Then
            txtValue.Text = Modbus.ReadData(REGISTER_TYPE, txtAddress.Text)
        ElseIf cbo_data_type.Text = "INT 32" Then
            txtValue.Text = Modbus.ReadDataDword(REGISTER_TYPE, txtAddress.Text)
        End If
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        If cbo_data_type.Text = "FLOAT" Then
            Modbus.WriteDataFloat(REGISTER_TYPE, Val(txtAddress.Text), Single.Parse(txtValue.Text))
        ElseIf cbo_data_type.Text = "INT" Then
            Modbus.WriteData(REGISTER_TYPE, Val(txtAddress.Text), txtValue.Text)
        ElseIf cbo_data_type.Text = "DWORD" Then
            Modbus.WriteDataDword(REGISTER_TYPE, Val(txtAddress.Text), txtValue.Text)
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
    Private Sub btn_stn5_screw_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_screw_fw.Click
        If btn_stn5_screw_bw.Text = "Is Backward" Then
            btn_stn5_screw_bw.PerformClick()
        End If

        If btn_stn5_screw_fw.Text = "Forward" Then
            STN5_SCREW = FORWARD
            btn_stn5_screw_fw.Image = My.Resources.button_white
            btn_stn5_screw_fw.Text = "Is Forward"
        ElseIf btn_stn5_screw_fw.Text = "Is Forward" Then
            STN5_SCREW = IDLE
            btn_stn5_screw_fw.Image = My.Resources.button_silver
            btn_stn5_screw_fw.Text = "Forward"
        End If
    End Sub
    Private Sub btn_stn5_screw_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_screw_bw.Click
        If btn_stn5_screw_fw.Text = "Is Forward" Then
            btn_stn5_screw_fw.PerformClick()
        End If

        If btn_stn5_screw_bw.Text = "Backward" Then
            STN5_SCREW = BACKWARD
            btn_stn5_screw_bw.Image = My.Resources.button_white
            btn_stn5_screw_bw.Text = "Is Backward"
        ElseIf btn_stn5_screw_bw.Text = "Is Backward" Then
            STN5_SCREW = IDLE
            btn_stn5_screw_bw.Image = My.Resources.button_silver
            btn_stn5_screw_bw.Text = "Backward"
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
        lbl_fpy.Text = Math.Round(Double.Parse(Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_FPY)), 2).ToString + " %"
        lbl_oee.Text = Math.Round(Double.Parse(Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_OEE)), 2).ToString + " %"

        ST_COMM2 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM2)
        ST_COMM4 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM4)
        ST_COMM5 = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_COMM5)

        With Result
            .MEASUREMENT = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST2_MEASUREMENT)
            .TRAVEL_P2 = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_P2_TRAVEL)
            .TRAVEL_P3 = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_P3_TRAVEL)
            .ACTUATION_POS = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_ACTUATION_POS)
            .DIFF_STR = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_DIFF_STR_RESULT)
            .T1 = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_T1)
            .T2 = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ST4_T2)
            .COT = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_COT)
            .UNSCREW_STATUS = Modbus.ReadData(REGISTER_TYPE, ADDR_UNSCREW_STATUS)
        End With

        'Alarm General
        ALARM_GENERAL = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_GENERAL)
        ReadAlarm(ALARM_GENERAL)
        ALARM_STN1 = Modbus.ReadData(REGISTER_TYPE, ADDR_ALARM_STN1)
        ReadAlarmStn1(ALARM_STN1)
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

        'Station Downgrade Status
        STATION_STATUS = Modbus.ReadData(REGISTER_TYPE, ADDR_ST_DOWNGRADE)
        ReadStationStatus(STATION_STATUS)

        'Check PLC
        PLC_READY = Modbus.ReadData(REGISTER_TYPE, ADDR_PLC_READY)
        If PLC_READY Then
            ind_plc_status.BackColor = Color.Lime
        Else
            ind_plc_status.BackColor = Color.Red
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

        'PC STATUS
        PC_STATUS = Modbus.ReadData(REGISTER_TYPE, ADDR_PC_STATUS)

        If pnl_home.Visible = False And pnl_setting.Visible = False And pnl_alarm.Visible = False And pnl_multi.Visible = False Then
            LASER_ST6 = Modbus.ReadData(REGISTER_TYPE, ADDR_LASER_ST6)
            ReadLaserST6(LASER_ST6)
            ' Servo
            SERVO_ST4 = Modbus.ReadData(REGISTER_TYPE, ADDR_SERVO_ST4)
            ReadServoST4(SERVO_ST4)
            SERVO_ST3 = Modbus.ReadData(REGISTER_TYPE, ADDR_SERVO_ST3)
            ReadServoST3(SERVO_ST3)
            HEIDENHAIN = Modbus.ReadData(REGISTER_TYPE, ADDR_HEIDENHAIN)
            ReadHeidenhain(HEIDENHAIN)
            MANUAL_OPERATION = Modbus.ReadData(REGISTER_TYPE, ADDR_MANUAL_OPERATION)
            ReadManualOperation(MANUAL_OPERATION)
            txt_st4_act_pos.Text = Modbus.ReadDataDword(REGISTER_TYPE, ADDR_ACT_POS_ST4)
            txt_st4_act_vel.Text = Modbus.ReadData(REGISTER_TYPE, ADDR_ACT_VEL_ST4)
            txt_st3_act_pos.Text = Modbus.ReadDataDword(REGISTER_TYPE, ADDR_ACT_POS_ST3)
            txt_st3_act_vel.Text = Modbus.ReadData(REGISTER_TYPE, ADDR_ACT_VEL_ST3)
            txt_st2_act_mea.Text = Modbus.ReadDataDword(REGISTER_TYPE, ADDR_ACT_MEA_ST2)
            txt_st2_punch_count.Text = Modbus.ReadData(REGISTER_TYPE, ADDR_PUNCH_COUNTER_ST2)
            txt_st4_analog_data.Text = Modbus.ReadData(REGISTER_TYPE, ADDR_ANALOG_DATA_ST2)
            txt_st4_actu_pos.Text = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_ACTUATION_POS_ST4)
            txt_st4_diff_str.Text = Modbus.ReadDataFloat(REGISTER_TYPE, ADDR_DIFF_STR_ST4)


            ' STN 1
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN1) = FORWARD Then
                stn1_cyl1_max.Image = My.Resources.led_green_on
                mon_stn1_cyl1_max.Image = My.Resources.led_green_on
            Else
                stn1_cyl1_max.Image = My.Resources.led_red_on
                mon_stn1_cyl1_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN1) = BACKWARD Then
                stn1_cyl1_min.Image = My.Resources.led_green_on
                mon_stn1_cyl1_min.Image = My.Resources.led_green_on
            Else
                stn1_cyl1_min.Image = My.Resources.led_red_on
                mon_stn1_cyl1_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN2) = FORWARD Then
                stn1_cyl2_max.Image = My.Resources.led_green_on
                mon_stn1_cyl2_max.Image = My.Resources.led_green_on
            Else
                stn1_cyl2_max.Image = My.Resources.led_red_on
                mon_stn1_cyl2_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN2) = BACKWARD Then
                stn1_cyl2_min.Image = My.Resources.led_green_on
                mon_stn1_cyl2_min.Image = My.Resources.led_green_on
            Else
                stn1_cyl2_min.Image = My.Resources.led_red_on
                mon_stn1_cyl2_min.Image = My.Resources.led_green_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN3) = FORWARD Then
                stn1_cyl3_max.Image = My.Resources.led_green_on
            Else
                stn1_cyl3_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN3) = BACKWARD Then
                stn1_cyl3_min.Image = My.Resources.led_green_on
                mon_stn1_cyl3_min.Image = My.Resources.led_green_on
            Else
                stn1_cyl3_min.Image = My.Resources.led_red_on
                mon_stn1_cyl3_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN4) = FORWARD Then
                stn1_cyl4_max.Image = My.Resources.led_green_on
                mon_stn1_cyl4_max.Image = My.Resources.led_green_on
            Else
                stn1_cyl4_max.Image = My.Resources.led_red_on
                mon_stn1_cyl4_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_SEN4) = BACKWARD Then
                stn1_cyl4_min.Image = My.Resources.led_green_on
                mon_stn1_cyl4_min.Image = My.Resources.led_green_on
            Else
                stn1_cyl4_min.Image = My.Resources.led_red_on
                mon_stn1_cyl4_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL1) = FORWARD Then
                mon_stn1_cyl1_fw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl1_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL1) = BACKWARD Then
                mon_stn1_cyl1_bw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl1_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL2) = FORWARD Then
                mon_stn1_cyl2_fw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl2_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL2) = BACKWARD Then
                mon_stn1_cyl2_bw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl2_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL3) = FORWARD Then
                mon_stn1_cyl3_fw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl3_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL3) = BACKWARD Then
                mon_stn1_cyl3_bw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl3_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL4) = FORWARD Then
                mon_stn1_cyl4_fw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl4_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN1_CYL4) = BACKWARD Then
                mon_stn1_cyl4_bw.Image = My.Resources.led_green_on
            Else
                mon_stn1_cyl4_bw.Image = My.Resources.led_red_on
            End If

            ' STN 2
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN1) = FORWARD Then
                stn2_cyl1_max.Image = My.Resources.led_green_on
                mon_stn2_cyl1_max.Image = My.Resources.led_green_on
            Else
                stn2_cyl1_max.Image = My.Resources.led_red_on
                mon_stn2_cyl1_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN1) = BACKWARD Then
                stn2_cyl1_min.Image = My.Resources.led_green_on
                mon_stn2_cyl1_min.Image = My.Resources.led_green_on
            Else
                stn2_cyl1_min.Image = My.Resources.led_red_on
                mon_stn2_cyl1_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN2) = FORWARD Then
                stn2_cyl2_max.Image = My.Resources.led_green_on
                mon_stn2_cyl2_max.Image = My.Resources.led_green_on
            Else
                stn2_cyl2_max.Image = My.Resources.led_red_on
                mon_stn2_cyl2_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN2) = BACKWARD Then
                stn2_cyl2_min.Image = My.Resources.led_green_on
                mon_stn2_cyl2_min.Image = My.Resources.led_green_on
            Else
                stn2_cyl2_min.Image = My.Resources.led_red_on
                mon_stn2_cyl2_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN3) = FORWARD Then
                stn2_cyl3_max.Image = My.Resources.led_green_on
                mon_stn2_cyl3_max.Image = My.Resources.led_green_on
            Else
                stn2_cyl3_max.Image = My.Resources.led_red_on
                mon_stn2_cyl3_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN3) = BACKWARD Then
                stn2_cyl3_min.Image = My.Resources.led_green_on
                mon_stn2_cyl3_min.Image = My.Resources.led_green_on
            Else
                stn2_cyl3_min.Image = My.Resources.led_red_on
                mon_stn2_cyl3_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN4) = FORWARD Then
                stn2_cyl4_max.Image = My.Resources.led_green_on
                mon_stn2_cyl4_max.Image = My.Resources.led_green_on
            Else
                stn2_cyl4_max.Image = My.Resources.led_red_on
                mon_stn2_cyl4_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_SEN4) = BACKWARD Then
                stn2_cyl4_min.Image = My.Resources.led_green_on
                mon_stn2_cyl4_min.Image = My.Resources.led_green_on
            Else
                stn2_cyl4_min.Image = My.Resources.led_red_on
                mon_stn2_cyl4_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL1) = FORWARD Then
                mon_stn2_cyl1_fw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl1_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL1) = BACKWARD Then
                mon_stn2_cyl1_bw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl1_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL2) = FORWARD Then
                mon_stn2_cyl2_fw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl2_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL2) = BACKWARD Then
                mon_stn2_cyl2_bw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl2_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL3) = FORWARD Then
                mon_stn2_cyl3_fw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl3_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL3) = BACKWARD Then
                mon_stn2_cyl3_bw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl3_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL4) = FORWARD Then
                mon_stn2_cyl4_fw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl4_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN2_CYL4) = BACKWARD Then
                mon_stn2_cyl4_bw.Image = My.Resources.led_green_on
            Else
                mon_stn2_cyl4_bw.Image = My.Resources.led_red_on
            End If

            ' STN 3
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN1) = FORWARD Then
                stn3_cyl1_max.Image = My.Resources.led_green_on
                mon_stn3_cyl1_max.Image = My.Resources.led_green_on
            Else
                stn3_cyl1_max.Image = My.Resources.led_red_on
                mon_stn3_cyl1_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN1) = BACKWARD Then
                stn3_cyl1_min.Image = My.Resources.led_green_on
                mon_stn3_cyl1_min.Image = My.Resources.led_green_on
            Else
                stn3_cyl1_min.Image = My.Resources.led_red_on
                mon_stn3_cyl1_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN2) = FORWARD Then
                stn3_cyl2_max.Image = My.Resources.led_green_on
                mon_stn3_cyl2_max.Image = My.Resources.led_green_on
            Else
                stn3_cyl2_max.Image = My.Resources.led_red_on
                mon_stn3_cyl2_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN2) = BACKWARD Then
                stn3_cyl2_min.Image = My.Resources.led_green_on
                mon_stn3_cyl2_min.Image = My.Resources.led_green_on
            Else
                stn3_cyl2_min.Image = My.Resources.led_red_on
                mon_stn3_cyl2_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN3) = FORWARD Then
                stn3_cyl3_max.Image = My.Resources.led_green_on
                mon_stn3_cyl3_max.Image = My.Resources.led_green_on
            Else
                stn3_cyl3_max.Image = My.Resources.led_red_on
                mon_stn3_cyl3_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN3) = BACKWARD Then
                stn3_cyl3_min.Image = My.Resources.led_green_on
                mon_stn3_cyl3_min.Image = My.Resources.led_green_on
            Else
                stn3_cyl3_min.Image = My.Resources.led_red_on
                mon_stn3_cyl3_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN4) = FORWARD Then
                stn3_cyl4_max.Image = My.Resources.led_green_on
                mon_stn3_cyl4_max.Image = My.Resources.led_green_on
            Else
                stn3_cyl4_max.Image = My.Resources.led_red_on
                mon_stn3_cyl4_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_SEN4) = BACKWARD Then
                stn3_cyl4_min.Image = My.Resources.led_green_on
                mon_stn3_cyl4_min.Image = My.Resources.led_green_on
            Else
                stn3_cyl4_min.Image = My.Resources.led_red_on
                mon_stn3_cyl4_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL1) = FORWARD Then
                mon_stn3_cyl1_fw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl1_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL1) = BACKWARD Then
                mon_stn3_cyl1_bw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl1_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL2) = FORWARD Then
                mon_stn3_cyl2_fw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl2_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL2) = BACKWARD Then
                mon_stn3_cyl2_bw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl2_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL3) = FORWARD Then
                mon_stn3_cyl3_fw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl3_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL3) = BACKWARD Then
                mon_stn3_cyl3_bw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl3_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL4) = FORWARD Then
                mon_stn3_cyl4_fw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl4_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN3_CYL4) = BACKWARD Then
                mon_stn3_cyl4_bw.Image = My.Resources.led_green_on
            Else
                mon_stn3_cyl4_bw.Image = My.Resources.led_red_on
            End If

            ' STN 4
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN1) = FORWARD Then
                stn4_cyl1_max.Image = My.Resources.led_green_on
                mon_stn4_cyl1_max.Image = My.Resources.led_green_on
            Else
                stn4_cyl1_max.Image = My.Resources.led_red_on
                mon_stn4_cyl1_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN1) = BACKWARD Then
                stn4_cyl1_min.Image = My.Resources.led_green_on
                mon_stn4_cyl1_min.Image = My.Resources.led_green_on
            Else
                stn4_cyl1_min.Image = My.Resources.led_red_on
                mon_stn4_cyl1_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN2) = FORWARD Then
                stn4_cyl2_max.Image = My.Resources.led_green_on
                mon_stn4_cyl2_max.Image = My.Resources.led_green_on
            Else
                stn4_cyl2_max.Image = My.Resources.led_red_on
                mon_stn4_cyl2_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN2) = BACKWARD Then
                stn4_cyl2_min.Image = My.Resources.led_green_on
                mon_stn4_cyl2_min.Image = My.Resources.led_green_on
            Else
                stn4_cyl2_min.Image = My.Resources.led_red_on
                mon_stn4_cyl2_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN3) = FORWARD Then
                stn4_cyl3_max.Image = My.Resources.led_green_on
                mon_stn4_cyl3_max.Image = My.Resources.led_green_on
            Else
                stn4_cyl3_max.Image = My.Resources.led_red_on
                mon_stn4_cyl3_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN3) = BACKWARD Then
                stn4_cyl3_min.Image = My.Resources.led_green_on
                mon_stn4_cyl3_min.Image = My.Resources.led_green_on
            Else
                stn4_cyl3_min.Image = My.Resources.led_red_on
                mon_stn4_cyl3_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN4) = FORWARD Then
                stn4_cyl4_max.Image = My.Resources.led_green_on
                mon_stn4_cyl4_max.Image = My.Resources.led_green_on
            Else
                stn4_cyl4_max.Image = My.Resources.led_red_on
                mon_stn4_cyl4_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_SEN4) = BACKWARD Then
                stn4_cyl4_min.Image = My.Resources.led_green_on
                mon_stn4_cyl4_min.Image = My.Resources.led_green_on
            Else
                stn4_cyl4_min.Image = My.Resources.led_red_on
                mon_stn4_cyl4_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL1) = FORWARD Then
                mon_stn4_cyl1_fw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl1_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL1) = BACKWARD Then
                mon_stn4_cyl1_bw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl1_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL2) = FORWARD Then
                mon_stn4_cyl2_fw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl2_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL2) = BACKWARD Then
                mon_stn4_cyl2_bw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl2_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL3) = FORWARD Then
                mon_stn4_cyl3_fw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl3_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL3) = BACKWARD Then
                mon_stn4_cyl3_bw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl3_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL4) = FORWARD Then
                mon_stn4_cyl4_fw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl4_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN4_CYL4) = BACKWARD Then
                mon_stn4_cyl4_bw.Image = My.Resources.led_green_on
            Else
                mon_stn4_cyl4_bw.Image = My.Resources.led_red_on
            End If

            ' STN 5
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN1) = FORWARD Then
                stn5_cyl1_max.Image = My.Resources.led_green_on
                mon_stn5_cyl1_max.Image = My.Resources.led_green_on
            Else
                stn5_cyl1_max.Image = My.Resources.led_red_on
                mon_stn5_cyl1_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN1) = BACKWARD Then
                stn5_cyl1_min.Image = My.Resources.led_green_on
                mon_stn5_cyl1_min.Image = My.Resources.led_green_on
            Else
                stn5_cyl1_min.Image = My.Resources.led_red_on
                mon_stn5_cyl1_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN2) = FORWARD Then
                stn5_cyl2_max.Image = My.Resources.led_green_on
                mon_stn5_cyl2_max.Image = My.Resources.led_green_on
            Else
                stn5_cyl2_max.Image = My.Resources.led_red_on
                mon_stn5_cyl2_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN2) = BACKWARD Then
                stn5_cyl2_min.Image = My.Resources.led_green_on
                mon_stn5_cyl2_min.Image = My.Resources.led_green_on
            Else
                stn5_cyl2_min.Image = My.Resources.led_red_on
                mon_stn5_cyl2_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN3) = FORWARD Then
                stn5_cyl3_max.Image = My.Resources.led_green_on
                mon_stn5_cyl3_max.Image = My.Resources.led_green_on
            Else
                stn5_cyl3_max.Image = My.Resources.led_red_on
                mon_stn5_cyl3_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN3) = BACKWARD Then
                stn5_cyl3_min.Image = My.Resources.led_green_on
                mon_stn5_cyl3_min.Image = My.Resources.led_green_on
            Else
                stn5_cyl3_min.Image = My.Resources.led_red_on
                mon_stn5_cyl3_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN4) = FORWARD Then
                stn5_cyl4_max.Image = My.Resources.led_green_on
                mon_stn5_cyl4_max.Image = My.Resources.led_green_on
            Else
                stn5_cyl4_max.Image = My.Resources.led_red_on
                mon_stn5_cyl4_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_SEN4) = BACKWARD Then
                stn5_cyl4_min.Image = My.Resources.led_green_on
                mon_stn5_cyl4_min.Image = My.Resources.led_green_on
            Else
                stn5_cyl4_min.Image = My.Resources.led_red_on
                mon_stn5_cyl4_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL1) = FORWARD Then
                mon_stn5_cyl1_fw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl1_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL1) = BACKWARD Then
                mon_stn5_cyl1_bw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl1_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL2) = FORWARD Then
                mon_stn5_cyl2_fw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl2_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL2) = BACKWARD Then
                mon_stn5_cyl2_bw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl2_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL3) = FORWARD Then
                mon_stn5_cyl3_fw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl3_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL3) = BACKWARD Then
                mon_stn5_cyl3_bw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl3_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL4) = FORWARD Then
                mon_stn5_cyl4_fw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl4_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN5_CYL4) = BACKWARD Then
                mon_stn5_cyl4_bw.Image = My.Resources.led_green_on
            Else
                mon_stn5_cyl4_bw.Image = My.Resources.led_red_on
            End If

            ' STN 6
            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN1) = FORWARD Then
                stn6_cyl1_max.Image = My.Resources.led_green_on
                mon_stn6_cyl1_max.Image = My.Resources.led_green_on
            Else
                stn6_cyl1_max.Image = My.Resources.led_red_on
                mon_stn6_cyl1_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN1) = BACKWARD Then
                stn6_cyl1_min.Image = My.Resources.led_green_on
                mon_stn6_cyl1_min.Image = My.Resources.led_green_on
            Else
                stn6_cyl1_min.Image = My.Resources.led_red_on
                mon_stn6_cyl1_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN2) = FORWARD Then
                stn6_cyl2_max.Image = My.Resources.led_green_on
                mon_stn6_cyl2_max.Image = My.Resources.led_green_on
            Else
                stn6_cyl2_max.Image = My.Resources.led_red_on
                mon_stn6_cyl2_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN2) = BACKWARD Then
                stn6_cyl2_min.Image = My.Resources.led_green_on
                mon_stn6_cyl2_min.Image = My.Resources.led_green_on
            Else
                stn6_cyl2_min.Image = My.Resources.led_red_on
                mon_stn6_cyl2_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN3) = FORWARD Then
                stn6_cyl3_max.Image = My.Resources.led_green_on
                mon_stn6_cyl3_max.Image = My.Resources.led_green_on
            Else
                stn6_cyl3_max.Image = My.Resources.led_red_on
                mon_stn6_cyl3_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN3) = BACKWARD Then
                stn6_cyl3_min.Image = My.Resources.led_green_on
                mon_stn6_cyl3_min.Image = My.Resources.led_green_on
            Else
                stn6_cyl3_min.Image = My.Resources.led_red_on
                mon_stn6_cyl3_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN4) = FORWARD Then
                stn6_cyl4_max.Image = My.Resources.led_green_on
                mon_stn6_cyl4_max.Image = My.Resources.led_green_on
            Else
                stn6_cyl4_max.Image = My.Resources.led_red_on
                mon_stn6_cyl4_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN4) = BACKWARD Then
                stn6_cyl4_min.Image = My.Resources.led_green_on
                mon_stn6_cyl4_min.Image = My.Resources.led_green_on
            Else
                stn6_cyl4_min.Image = My.Resources.led_red_on
                mon_stn6_cyl4_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN5) = FORWARD Then
                stn6_cyl5_max.Image = My.Resources.led_green_on
                mon_stn6_cyl5_max.Image = My.Resources.led_green_on
            Else
                stn6_cyl5_max.Image = My.Resources.led_red_on
                mon_stn6_cyl5_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN5) = BACKWARD Then
                stn6_cyl5_min.Image = My.Resources.led_green_on
                mon_stn6_cyl5_min.Image = My.Resources.led_green_on
            Else
                stn6_cyl5_min.Image = My.Resources.led_red_on
                mon_stn6_cyl5_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN6) = FORWARD Then
                stn6_cyl6_max.Image = My.Resources.led_green_on
                mon_stn6_cyl6_max.Image = My.Resources.led_green_on
            Else
                stn6_cyl6_max.Image = My.Resources.led_red_on
                mon_stn6_cyl6_max.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_SEN6) = BACKWARD Then
                stn6_cyl6_min.Image = My.Resources.led_green_on
                mon_stn6_cyl6_min.Image = My.Resources.led_green_on
            Else
                stn6_cyl6_min.Image = My.Resources.led_red_on
                mon_stn6_cyl6_min.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL1) = FORWARD Then
                mon_stn6_cyl1_fw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl1_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL1) = BACKWARD Then
                mon_stn6_cyl1_bw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl1_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL2) = FORWARD Then
                mon_stn6_cyl2_fw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl2_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL2) = BACKWARD Then
                mon_stn6_cyl2_bw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl2_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL3) = FORWARD Then
                mon_stn6_cyl3_fw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl3_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL3) = BACKWARD Then
                mon_stn6_cyl3_bw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl3_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL4) = FORWARD Then
                mon_stn6_cyl4_fw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl4_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL4) = BACKWARD Then
                mon_stn6_cyl4_bw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl4_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL5) = FORWARD Then
                mon_stn6_cyl5_fw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl5_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL5) = BACKWARD Then
                mon_stn6_cyl5_bw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl5_bw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL6) = FORWARD Then
                mon_stn6_cyl6_fw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl6_fw.Image = My.Resources.led_red_on
            End If

            If Modbus.ReadData(REGISTER_TYPE, ADDR_STN6_CYL6) = BACKWARD Then
                mon_stn6_cyl6_bw.Image = My.Resources.led_green_on
            Else
                mon_stn6_cyl6_bw.Image = My.Resources.led_red_on
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
    Private Sub ModbusWriterComm(output As Integer, address As Integer)
        Modbus.WriteData(REGISTER_TYPE, address, output)
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

        If STN5_SCREW <> LAST_STN5_SCREW Then
            ModbusWriter(STN5_SCREW, ADDR_STN5_SCREW)
            LAST_STN5_SCREW = STN5_SCREW
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
        If (txt_ref.Text = "" Or txt_ope_id.Text = "" Or txt_po_num.Text = "") Then
            MsgBox("Please Scan Barcode!")
            Exit Sub
        End If

        GetPCStatus("RUN")

        With Config
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav1"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_2, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav2"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_3, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav3"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_4, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav4"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_5, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav5"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_6, ReadINI(iniPath, "CALIBRATION", "HeidenhainCav6"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST3, ReadINI(iniPath, "CALIBRATION", "Posst3"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_SET_VEL_ST3, ReadINI(iniPath, "CALIBRATION", "Velst3"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST4, ReadINI(iniPath, "CALIBRATION", "Posst4"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_SET_VEL_ST4, ReadINI(iniPath, "CALIBRATION", "Velst4"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_1, ReadINI(iniPath, "CALIBRATION", "P0st4Cav1"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_2, ReadINI(iniPath, "CALIBRATION", "P0st4Cav2"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_3, ReadINI(iniPath, "CALIBRATION", "P0st4Cav3"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_4, ReadINI(iniPath, "CALIBRATION", "P0st4Cav4"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_5, ReadINI(iniPath, "CALIBRATION", "P0st4Cav5"))
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_6, ReadINI(iniPath, "CALIBRATION", "P0st4Cav6"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_1, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav1"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_2, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav2"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_3, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav3"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_4, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav4"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_5, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav5"))
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_6, ReadINI(iniPath, "CALIBRATION", "Gt2st4Cav6"))
        End With

        btn_run.Enabled = False
        btn_stop.Enabled = True
        IS_RUN = True
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        GetPCStatus("STOP")
        btn_run.Enabled = True
        btn_stop.Enabled = False
        IS_RUN = False
    End Sub

    'Read Alarm
    Dim alarm_text_general(10) As String
    Dim last_alarm_general(10) As String
    Private Sub ReadAlarm(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [General] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            alarm_text_general(0) = "Door Lock 1 Open"
            ind_door_lock_1.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(0)
        Else
            alarm_text_general(0) = "Door Lock 1 Close"
            ind_door_lock_1.BackColor = Color.Red
        End If

        If binaryString(14) = "1" Then
            alarm_text_general(1) = "Door Lock 2 Open"
            ind_door_lock_2.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(1)
        Else
            alarm_text_general(1) = "Door Lock 2 Close"
            ind_door_lock_2.BackColor = Color.Red
        End If

        If binaryString(13) = "1" Then
            alarm_text_general(2) = "Door Lock 3 Open"
            ind_door_lock_3.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(2)
        Else
            alarm_text_general(2) = "Door Lock 3 Close"
            ind_door_lock_3.BackColor = Color.Red
        End If

        If binaryString(12) = "1" Then
            alarm_text_general(3) = "Door Lock 4 Open"
            ind_door_lock_4.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(3)
        Else
            alarm_text_general(3) = "Door Lock 4 Close"
            ind_door_lock_4.BackColor = Color.Red
        End If

        If binaryString(11) = "1" Then
            alarm_text_general(4) = "Door Lock 5 Open"
            ind_door_lock_5.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(4)
        Else
            alarm_text_general(4) = "Door Lock 5 Close"
            ind_door_lock_5.BackColor = Color.Red
        End If

        If binaryString(10) = "1" Then
            alarm_text_general(5) = "Door Lock 6 Open"
            ind_door_lock_6.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(5)
        Else
            alarm_text_general(5) = "Door Lock 6 Close"
            ind_door_lock_6.BackColor = Color.Red
        End If

        If binaryString(9) = "1" Then
            alarm_text_general(6) = "Altivar NOK"
            ind_altivar_fault.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(6)
        Else
            alarm_text_general(6) = "Altivar OK"
            ind_altivar_fault.BackColor = Color.Red
        End If

        If binaryString(8) = "1" Then
            alarm_text_general(7) = "Air Presence OK"
            ind_air_presence.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(7)
        Else
            alarm_text_general(7) = "Air Presence NOK"
            ind_air_presence.BackColor = Color.Red
        End If

        If binaryString(7) = "1" Then
            alarm_text_general(8) = "Emergency Button Is Pressed"
            ind_emg_button.BackColor = Color.Lime
            txt_alarm_copy.Text = "Alarm : " + alarm_text_general(8)
        Else
            alarm_text_general(8) = "Emergency Button Is Released"
            ind_emg_button.BackColor = Color.Red
        End If

        If binaryString(6) = "1" Then
            CURTAIN = True
            alarm_text_general(9) = "Safety Curtain NOK"
            ind_safety_curtain.BackColor = Color.Lime
            'txt_alarm_copy.Text = "Alarm : " + alarm_text_general(9)
        Else
            CURTAIN = False
            alarm_text_general(9) = "Safety Curtain OK"
            ind_safety_curtain.BackColor = Color.Red
        End If

        For i As Integer = 0 To alarm_text_general.Length - 1
            If last_alarm_general(i) <> alarm_text_general(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_general(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_general(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_general(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_general(i) = alarm_text_general(i)
            End If
        Next

    End Sub
    Dim alarm_text_stn1(1) As String
    Dim last_alarm_stn1(1) As String
    Private Sub ReadAlarmStn1(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ST-2] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v101_descrepancy.BackColor = Color.Lime
            alarm_text_stn1(0) = "V101 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn1(0)
        Else
            ind_v101_descrepancy.BackColor = Color.Red
            alarm_text_stn1(0) = "V101 Descrepancy Not Detected"
        End If

        For i As Integer = 0 To alarm_text_stn1.Length - 1
            If last_alarm_stn1(i) <> alarm_text_stn1(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_stn1(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_stn1(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_stn1(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_stn1(i) = alarm_text_stn1(i)
            End If
        Next
    End Sub
    Dim alarm_text_stn2(3) As String
    Dim last_alarm_stn2(3) As String
    Private Sub ReadAlarmStn2(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ST-2] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v201_descrepancy.BackColor = Color.Lime
            alarm_text_stn2(0) = "V201 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn2(0)
        Else
            ind_v201_descrepancy.BackColor = Color.Red
            alarm_text_stn2(0) = "V201 Descrepancy Not Detected"
        End If

        If binaryString(14) = "1" Then
            ind_v202_descrepancy.BackColor = Color.Lime
            alarm_text_stn2(1) = "V202 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn2(1)
        Else
            ind_v202_descrepancy.BackColor = Color.Red
            alarm_text_stn2(1) = "V202 Descrepancy Not Detected"
        End If

        If binaryString(13) = "1" Then
            ind_v203_descrepancy.BackColor = Color.Lime
            alarm_text_stn2(2) = "V203 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn2(2)
        Else
            ind_v203_descrepancy.BackColor = Color.Red
            alarm_text_stn2(2) = "V203 Descrepancy Not Detected"
        End If

        For i As Integer = 0 To alarm_text_stn2.Length - 1
            If last_alarm_stn2(i) <> alarm_text_stn2(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_stn2(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_stn2(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_stn2(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_stn2(i) = alarm_text_stn2(i)
            End If
        Next
    End Sub
    Dim alarm_text_stn3(4) As String
    Dim last_alarm_stn3(4) As String
    Private Sub ReadAlarmStn3(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ST-3] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v301_descrepancy.BackColor = Color.Lime
            alarm_text_stn3(0) = "V301 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn3(0)
        Else
            ind_v301_descrepancy.BackColor = Color.Red
            alarm_text_stn3(0) = "V301 Descrepancy Not Detected"
        End If

        If binaryString(14) = "1" Then
            ind_v302_descrepancy.BackColor = Color.Lime
            alarm_text_stn3(1) = "V302 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn3(1)
        Else
            ind_v302_descrepancy.BackColor = Color.Red
            alarm_text_stn3(1) = "V302 Descrepancy Not Detected"
        End If

        If binaryString(13) = "1" Then
            ind_conn_servo_st3.BackColor = Color.Lime
            alarm_text_stn3(2) = "Servo Not Online Communication Invalid"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn3(2)
        Else
            ind_conn_servo_st3.BackColor = Color.Red
            alarm_text_stn3(2) = "Servo Online Communication Valid"
        End If

        If binaryString(12) = "1" Then
            ind_pos_servo_st3.BackColor = Color.Lime
            alarm_text_stn3(3) = "Servo Error Please Reset & Homing the Servo"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn3(3)
        Else
            ind_pos_servo_st3.BackColor = Color.Red
            alarm_text_stn3(3) = "Servo Position OK"
        End If

        For i As Integer = 0 To alarm_text_stn3.Length - 1
            If last_alarm_stn3(i) <> alarm_text_stn3(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_stn3(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_stn3(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_stn3(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_stn3(i) = alarm_text_stn3(i)
            End If
        Next
    End Sub
    Dim alarm_text_stn4(4) As String
    Dim last_alarm_stn4(4) As String
    Private Sub ReadAlarmStn4(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ST-4] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v401_descrepancy.BackColor = Color.Lime
            alarm_text_stn4(0) = "V401 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn4(0)
        Else
            ind_v401_descrepancy.BackColor = Color.Red
            alarm_text_stn4(0) = "V401 Descrepancy Not Detected"
        End If

        If binaryString(14) = "1" Then
            ind_v402_descrepancy.BackColor = Color.Lime
            alarm_text_stn4(1) = "V402 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn4(1)
        Else
            ind_v402_descrepancy.BackColor = Color.Red
            alarm_text_stn4(1) = "V402 Descrepancy Not Detected"
        End If

        If binaryString(13) = "1" Then
            ind_conn_servo_st4.BackColor = Color.Lime
            alarm_text_stn4(2) = "Servo Not Online Communication Invalid"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn4(2)
        Else
            ind_conn_servo_st4.BackColor = Color.Red
            alarm_text_stn4(2) = "Servo Online Communication Valid"
        End If

        If binaryString(12) = "1" Then
            ind_pos_servo_st4.BackColor = Color.Lime
            alarm_text_stn4(3) = "Servo Error Please Reset & Homing the Servo"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn4(3)
        Else
            ind_pos_servo_st4.BackColor = Color.Red
            alarm_text_stn4(3) = "Servo Position OK"
        End If

        For i As Integer = 0 To alarm_text_stn4.Length - 1
            If last_alarm_stn4(i) <> alarm_text_stn4(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_stn4(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_stn4(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_stn4(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_stn4(i) = alarm_text_stn4(i)
            End If
        Next
    End Sub
    Dim alarm_text_stn5(4) As String
    Dim last_alarm_stn5(4) As String
    Private Sub ReadAlarmStn5(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ST-5] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v501_descrepancy.BackColor = Color.Lime
            alarm_text_stn5(0) = "V501 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn5(0)
        Else
            ind_v501_descrepancy.BackColor = Color.Red
            alarm_text_stn5(0) = "V501 Descrepancy Not Detected"
        End If

        If binaryString(14) = "1" Then
            ind_v502_descrepancy.BackColor = Color.Lime
            alarm_text_stn5(1) = "V502 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn5(1)
        Else
            ind_v502_descrepancy.BackColor = Color.Red
            alarm_text_stn5(1) = "V501 Descrepancy Not Detected"
        End If

        If binaryString(13) = "1" Then
            ind_v503_descrepancy.BackColor = Color.Lime
            alarm_text_stn5(2) = "V503 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn5(2)
        Else
            ind_v503_descrepancy.BackColor = Color.Red
            alarm_text_stn5(2) = "V503 Descrepancy Not Detected"
        End If

        If binaryString(12) = "1" Then
            ind_v504_descrepancy.BackColor = Color.Lime
            alarm_text_stn5(3) = "V504 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn5(3)
        Else
            ind_v504_descrepancy.BackColor = Color.Red
            alarm_text_stn5(3) = "V504 Descrepancy Not Detected"
        End If

        For i As Integer = 0 To alarm_text_stn5.Length - 1
            If last_alarm_stn5(i) <> alarm_text_stn5(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_stn5(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_stn5(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_stn5(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_stn5(i) = alarm_text_stn5(i)
            End If
        Next
    End Sub
    Dim alarm_text_stn6(7) As String
    Dim last_alarm_stn6(7) As String
    Private Sub ReadAlarmStn6(decimalNumber As Integer)
        Dim timestamp As String = Now.ToString("yyyy-MM-dd HH:mm:ss") + " [ST-6] "
        Dim binaryString As String = Convert.ToString(decimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_v601_descrepancy.BackColor = Color.Lime
            alarm_text_stn6(0) = "V601 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(0)
        Else
            ind_v601_descrepancy.BackColor = Color.Red
            alarm_text_stn6(0) = "V601 Descrepancy Not Detected"
        End If

        If binaryString(14) = "1" Then
            ind_v602_descrepancy.BackColor = Color.Lime
            alarm_text_stn6(1) = "V602 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(1)
        Else
            ind_v602_descrepancy.BackColor = Color.Red
            alarm_text_stn6(1) = "V602 Descrepancy Not Detected"
        End If

        If binaryString(13) = "1" Then
            ind_v603_descrepancy.BackColor = Color.Lime
            alarm_text_stn6(2) = "V603 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(2)
        Else
            ind_v603_descrepancy.BackColor = Color.Red
            alarm_text_stn6(2) = "V603 Descrepancy Not Detected"
        End If

        If binaryString(12) = "1" Then
            ind_v604_descrepancy.BackColor = Color.Lime
            alarm_text_stn6(3) = "V604 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(3)
        Else
            ind_v604_descrepancy.BackColor = Color.Red
            alarm_text_stn6(3) = "V604 Descrepancy Not Detected"
        End If

        If binaryString(11) = "1" Then
            ind_v605_descrepancy.BackColor = Color.Lime
            alarm_text_stn6(4) = "V605 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(4)
        Else
            ind_v605_descrepancy.BackColor = Color.Red
            alarm_text_stn6(4) = "V605 Descrepancy Not Detected"
        End If

        If binaryString(10) = "1" Then
            ind_v606_descrepancy.BackColor = Color.Lime
            alarm_text_stn6(5) = "V606 Descrepancy Detected"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(5)
        Else
            ind_v606_descrepancy.BackColor = Color.Red
            alarm_text_stn6(5) = "V606 Descrepancy Not Detected"
        End If

        If binaryString(9) = "1" Then
            ind_laser_err_emg.BackColor = Color.Lime
            alarm_text_stn6(6) = "ST6 Laser Error / Emergency Please Check Laser Communication"
            txt_alarm_copy.Text = "Alarm : " + alarm_text_stn6(6)
        Else
            ind_laser_err_emg.BackColor = Color.Red
            alarm_text_stn6(6) = "ST6 Laser OK"
        End If

        For i As Integer = 0 To alarm_text_stn6.Length - 1
            If last_alarm_stn6(i) <> alarm_text_stn6(i) Then
                alarmFileName = $"Alarm_{Date.Now.ToString("yyyyMMdd")}.txt"
                Dim strFile As String = projectFolder & "\Alarm\" & alarmFileName
                Dim fileExists As Boolean = File.Exists(strFile)
                If File.Exists(strFile) Then
                    ' If the file exists, append the log entry
                    Using sw As New StreamWriter(strFile, True)
                        sw.WriteLine(timestamp + alarm_text_stn6(i))
                    End Using
                Else
                    ' If the file does not exist, create it and write the log entry
                    Using sw As New StreamWriter(strFile)
                        sw.WriteLine(timestamp + alarm_text_stn6(i))
                    End Using
                End If
                txt_alarm.Text = txt_alarm.Text + timestamp + alarm_text_stn6(i) + vbCrLf
                txt_alarm.SelectionStart = txt_alarm.Text.Length
                txt_alarm.ScrollToCaret()
                last_alarm_stn6(i) = alarm_text_stn6(i)
            End If
        Next
    End Sub

    Private Sub ReadStationStatus(DecimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(DecimalNumber, 2).PadLeft(16, "0"c)

        If binaryString(15) = "1" Then
            ind_stn_1.BackColor = Color.Red
        Else
            ind_stn_1.BackColor = Color.Lime
        End If

        If binaryString(14) = "1" Then
            ind_stn_2.BackColor = Color.Red
        Else
            ind_stn_2.BackColor = Color.Lime
        End If

        If binaryString(13) = "1" Then
            ind_stn_3.BackColor = Color.Red
        Else
            ind_stn_3.BackColor = Color.Lime
        End If

        If binaryString(12) = "1" Then
            ind_stn_4.BackColor = Color.Red
        Else
            ind_stn_4.BackColor = Color.Lime
        End If

        If binaryString(11) = "1" Then
            ind_stn_5.BackColor = Color.Red
        Else
            ind_stn_5.BackColor = Color.Lime
        End If

        If binaryString(10) = "1" Then
            ind_stn_6.BackColor = Color.Red
        Else
            ind_stn_6.BackColor = Color.Lime
        End If
    End Sub
    Private Sub ReadLaserST6(DecimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(DecimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(14) = "1" Then
            stn6_laser_ready.Image = My.Resources.led_green_on
        Else
            stn6_laser_ready.Image = My.Resources.led_red_on
        End If

        If binaryString(13) = "1" Then
            stn6_laser_finish.Image = My.Resources.led_green_on
        Else
            stn6_laser_finish.Image = My.Resources.led_red_on
        End If

        If binaryString(12) = "1" Then
            stn6_laser_interlock.Image = My.Resources.led_green_on
        Else
            stn6_laser_interlock.Image = My.Resources.led_red_on
        End If
    End Sub
    Private Sub ReadServoST4(DecimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(DecimalNumber, 2).PadLeft(16, "0"c)
        Dim binaryStringExtend As String = Convert.ToString(MANUAL_OPERATION, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_st4_servo_enabled.Image = My.Resources.led_green_on
        Else
            ind_st4_servo_enabled.Image = My.Resources.led_red_on
        End If

        If binaryString(14) = "1" Then
            ind_st4_servo_error.Image = My.Resources.led_green_on
        Else
            ind_st4_servo_error.Image = My.Resources.led_red_on
        End If

        If binaryString(13) = "1" Then
            ind_st4_home_busy.Image = My.Resources.led_green_on
        Else
            ind_st4_home_busy.Image = My.Resources.led_red_on
        End If

        If binaryString(12) = "1" Then
            ind_st4_servo_busy.Image = My.Resources.led_green_on
        Else
            ind_st4_servo_busy.Image = My.Resources.led_red_on
        End If

        If binaryString(11) = "1" Then
            ind_st4_standstill.Image = My.Resources.led_green_on
        Else
            ind_st4_standstill.Image = My.Resources.led_red_on
        End If

        If binaryString(10) = "1" Then
            ind_st4_stopping.Image = My.Resources.led_green_on
        Else
            ind_st4_stopping.Image = My.Resources.led_red_on
        End If

        If binaryString(9) = "1" Then
            ind_st4_continuous_motion.Image = My.Resources.led_green_on
        Else
            ind_st4_continuous_motion.Image = My.Resources.led_red_on
        End If

        If binaryStringExtend(6) = "1" Then
            ind_st4_discrete_motion.Image = My.Resources.led_green_on
        Else
            ind_st4_discrete_motion.Image = My.Resources.led_red_on
        End If


    End Sub

    Private Sub ReadServoST3(DecimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(DecimalNumber, 2).PadLeft(16, "0"c)
        Dim binaryStringExtend As String = Convert.ToString(MANUAL_OPERATION, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_st3_servo_enabled.Image = My.Resources.led_green_on
        Else
            ind_st3_servo_enabled.Image = My.Resources.led_red_on
        End If

        If binaryString(14) = "1" Then
            ind_st3_servo_error.Image = My.Resources.led_green_on
        Else
            ind_st3_servo_error.Image = My.Resources.led_red_on
        End If

        If binaryString(13) = "1" Then
            ind_st3_home_busy.Image = My.Resources.led_green_on
        Else
            ind_st3_home_busy.Image = My.Resources.led_red_on
        End If

        If binaryString(12) = "1" Then
            ind_st3_servo_busy.Image = My.Resources.led_green_on
        Else
            ind_st3_servo_busy.Image = My.Resources.led_red_on
        End If

        If binaryString(11) = "1" Then
            ind_st3_standstill.Image = My.Resources.led_green_on
        Else
            ind_st3_standstill.Image = My.Resources.led_red_on
        End If

        If binaryString(10) = "1" Then
            ind_st3_stopping.Image = My.Resources.led_green_on
        Else
            ind_st3_stopping.Image = My.Resources.led_red_on
        End If

        If binaryString(9) = "1" Then
            ind_st3_continuous_motion.Image = My.Resources.led_green_on
        Else
            ind_st3_continuous_motion.Image = My.Resources.led_red_on
        End If

        If binaryStringExtend(5) = "1" Then
            ind_st3_discrete_motion.Image = My.Resources.led_green_on
        Else
            ind_st3_discrete_motion.Image = My.Resources.led_red_on
        End If
    End Sub
    Private Sub ReadHeidenhain(DecimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(DecimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_st2_heidenhain_valid.Image = My.Resources.led_green_on
        Else
            ind_st2_heidenhain_valid.Image = My.Resources.led_red_on
        End If

        If binaryString(14) = "1" Then
            ind_st2_heidenhain_error.Image = My.Resources.led_green_on
        Else
            ind_st2_heidenhain_error.Image = My.Resources.led_red_on
        End If

        If binaryString(13) = "1" Then
            ind_st2_motor_status.Image = My.Resources.led_green_on
        Else
            ind_st2_motor_status.Image = My.Resources.led_red_on
        End If
    End Sub
    Private Sub ReadManualOperation(DecimalNumber As Integer)
        Dim binaryString As String = Convert.ToString(DecimalNumber, 2).PadLeft(16, "0"c)
        If binaryString(15) = "1" Then
            ind_altivar_status.Image = My.Resources.led_green_on
        Else
            ind_altivar_status.Image = My.Resources.led_red_on
        End If

        If binaryString(14) = "1" Then
            ind_cycle_status.Image = My.Resources.led_green_on
        Else
            ind_cycle_status.Image = My.Resources.led_red_on
        End If

        If binaryString(12) = "1" Then
            ind_safety_st1.Image = My.Resources.led_green_on
        Else
            ind_safety_st1.Image = My.Resources.led_red_on
        End If

        If binaryString(11) = "1" Then
            ind_safety_st2.Image = My.Resources.led_green_on
        Else
            ind_safety_st2.Image = My.Resources.led_red_on
        End If

        If binaryString(10) = "1" Then
            ind_safety_st3.Image = My.Resources.led_green_on
        Else
            ind_safety_st3.Image = My.Resources.led_red_on
        End If

        If binaryString(9) = "1" Then
            ind_safety_st4.Image = My.Resources.led_green_on
        Else
            ind_safety_st4.Image = My.Resources.led_red_on
        End If

        If binaryString(8) = "1" Then
            ind_safety_st5.Image = My.Resources.led_green_on
        Else
            ind_safety_st5.Image = My.Resources.led_red_on
        End If

        If binaryString(7) = "1" Then
            ind_safety_st6.Image = My.Resources.led_green_on
        Else
            ind_safety_st6.Image = My.Resources.led_red_on
        End If
    End Sub
    Dim delayLaser As Integer = 0
    Dim DGV_Temp As New DataGridView
    Public Sub Save_Datalog()
        Try
            DateTimePickerStartDate.Value = Now.Today
            DateTimePickerEndDate.Value = Now.Today
            Dim range1 As String = DateTimePickerStartDate.Value.ToString("yyyy-MM-dd 00:00:00")
            Dim range2 As String = DateTimePickerEndDate.Value.ToString("yyyy-MM-dd 23:59:59")

            Call KoneksiDB.koneksi_db()
            ' Try
            Dim sc As New SqlCommand("SELECT * FROM tb_data WHERE [Date Time] BETWEEN '" + range1 + "' AND '" + range2 + "' ORDER BY [Sequence Number] ASC", KoneksiDB.koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            DataGridView1.ClearSelection()

            logFileName = $"Log_{Date.Now.ToString("yyyyMMdd")}.csv"
            Dim strFile As String = projectFolder & "\Log\" & logFileName
            Dim fileExists As Boolean = File.Exists(strFile)

            If DataGridView1.RowCount > 0 Then
                Dim value As String = ""
                Dim dr As New DataGridViewRow()

                Dim swOut As StreamWriter = File.CreateText(strFile)

                'write header rows to csv
                For i As Integer = 0 To DataGridView1.Columns.Count - 1
                    If i > 0 Then
                        swOut.Write(";")
                    End If
                    swOut.Write(DataGridView1.Columns(i).HeaderText)
                Next

                swOut.WriteLine()

                'write DataGridView rows to csv
                For j As Integer = 0 To DataGridView1.Rows.Count - 1
                    If j > 0 Then
                        swOut.WriteLine()
                    End If

                    dr = DataGridView1.Rows(j)

                    For i As Integer = 0 To DataGridView1.Columns.Count - 1
                        If i > 0 Then
                            swOut.Write(";")
                        End If
                        If IsDBNull(dr.Cells(i).Value) Then
                            value = "0"
                        Else
                            value = CStr(dr.Cells(i).Value)
                        End If
                        swOut.Write(value)
                    Next
                Next
                swOut.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim previousDay As Integer = Now.Day
    Private Sub Status_Tick(sender As Object, e As EventArgs) Handles Status.Tick
        Select Case SCAN_MODE
            Case 0
                'txt_ref.Select()
                If txt_ref.Text <> "" Then
                    Call KoneksiDB.koneksi_db()

                    Dim sc As New SqlCommand("SELECT * FROM tb_reference WHERE [References]='" & txt_ref.Text & "'", KoneksiDB.koneksi)
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
                    Dim sc As New SqlCommand("SELECT * FROM tb_reference WHERE [References]='" & txt_ref.Text & "'", KoneksiDB.koneksi)
                    Dim rd As SqlDataReader = sc.ExecuteReader
                    rd.Read()

                    lbl_act_val.Text = rd.Item("Act Val")
                    lbl_act_val_tol.Text = rd.Item("Act Val Tolerance")
                    lbl_dif_str.Text = rd.Item("Dif Str")
                    lbl_dif_str_tol.Text = rd.Item("Dif Str Tolerance")
                    lbl_beating_times.Text = rd.Item("Beating Times")
                    lbl_cfg_1st.Text = rd.Item("Config 1st Contact")
                    lbl_cfg_2nd.Text = rd.Item("Config 2nd Contact")
                    lbl_unscrew_process.Text = rd.Item("Unscrewing Process")
                    lbl_laser_datecode.Text = rd.Item("Laser Datecode")
                    lbl_laser_template.Text = rd.Item("Laser Template")

                    'write to plc
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_ACT_VAL, Single.Parse(lbl_act_val.Text.Replace(",", ".")))
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_ACT_VAL_TOL, Single.Parse(lbl_act_val_tol.Text.Replace(",", ".")))
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_DIF_STR, Single.Parse(lbl_dif_str.Text.Replace(",", ".")))
                    Modbus.WriteDataFloat(REGISTER_TYPE, ADDR_DIF_STR_TOL, Single.Parse(lbl_dif_str_tol.Text.Replace(",", ".")))
                    Modbus.WriteData(REGISTER_TYPE, ADDR_BEATING_TIMES, lbl_beating_times.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_CFG_FIRST_CONTACT, lbl_cfg_1st.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_CFG_SECOND_CONTACT, lbl_cfg_2nd.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_UNSCREWING_PROCESS, lbl_unscrew_process.Text)
                    Modbus.WriteData(REGISTER_TYPE, ADDR_LASER_DATE_CODE, lbl_laser_datecode.Text)

                    Select Case LASER_STATE
                        Case 0
                            Laser.GetMarkStatus
                            If Laser.ReadData("2") Then
                                LASER_STATE += 1
                            End If
                        Case 1
                            Laser.SetMarkingTemplate(rd.Item("Laser Template"))
                            If Laser.ReadData("Ok") Then
                                LASER_STATE += 1
                            End If
                        Case 2
                            SCAN_MODE = 3
                    End Select

                    'SCAN_MODE = 3
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
            If EmgState = 0 Then
                status_bar.Image = My.Resources.GUI___statusBar3
                lbl_auto_man.BackColor = Color.FromArgb(236, 28, 36)
                lbl_run_state.BackColor = Color.FromArgb(236, 28, 36)
                lbl_curr_time.BackColor = Color.FromArgb(236, 28, 36)
                lbl_date.BackColor = Color.FromArgb(236, 28, 36)
                EmgState = 1
            Else
                status_bar.Image = My.Resources.GUI___SignUpButtonOn40
                lbl_auto_man.BackColor = Color.DarkGray
                lbl_run_state.BackColor = Color.DarkGray
                lbl_curr_time.BackColor = Color.DarkGray
                lbl_date.BackColor = Color.DarkGray
                EmgState = 0
            End If
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
                If CURTAIN Then
                    lbl_op_ins.Text = "Can't start process, safety curtain is activated!"
                Else
                    lbl_op_ins.Text = "You're All Set!" + vbCrLf
                    If RUNNING_STATE = 1 Then
                        lbl_op_ins.Text = lbl_op_ins.Text + "Trigger to start process"
                        txt_alarm_copy.Text = "Alarm : . . ."
                    ElseIf RUNNING_STATE = 2 Then
                        lbl_op_ins.Text = lbl_op_ins.Text + "Machine in stop mode"

                    ElseIf RUNNING_STATE = 3 Then
                        If lbl_run_state.Text = "EMERGENCY" Then
                            lbl_op_ins.Text = lbl_op_ins.Text + "Machine in emergency mode"
                        Else
                            lbl_op_ins.Text = lbl_op_ins.Text + "Machine in initialize mode"
                            Action_ST2 = 1
                            Action_ST3 = 1
                            Action_ST4 = 1
                            Action_ST5 = 1
                            ClearProductionData()
                        End If
                    ElseIf RUNNING_STATE = 4 Then
                        lbl_op_ins.Text = lbl_op_ins.Text + "Machine in emptying process"
                    End If
                End If
            End If
        Else
            lbl_op_ins.Text = "Modbus Error, Please Check Modbus Connection!"
            ind_plc_status.BackColor = Color.Red
        End If

        'Dim currentDay As Integer = Now.Day

        'If currentDay <> previousDay Then
        '    Save_Datalog()
        '    previousDay = currentDay
        'End If

        If delayScroll > 0 Then
            delayScroll -= 1
            txt_alarm.SelectionStart = txt_alarm.Text.Length
            txt_alarm.ScrollToCaret()
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

                              Dim sc As New SqlCommand("SELECT * FROM tb_reference WHERE [References]='" & txt_ref.Text & "'", KoneksiDB.koneksi)
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
                              Dim sc As New SqlCommand("SELECT * FROM tb_reference WHERE [References]='" & txt_ref.Text & "'", KoneksiDB.koneksi)
                              Dim rd As SqlDataReader = sc.ExecuteReader
                              rd.Read()

                              lbl_act_val.Text = rd.Item("[Act Val]")
                              lbl_act_val_tol.Text = rd.Item("[Act Val Tolerance]")
                              lbl_dif_str.Text = rd.Item("[Dif Str]")
                              lbl_dif_str_tol.Text = rd.Item("[Dif Str Tolerance]")
                              lbl_beating_times.Text = rd.Item("[Beating Times]")
                              lbl_cfg_1st.Text = rd.Item("[Config 1st Contact]")
                              lbl_cfg_2nd.Text = rd.Item("[Config 2nd Contact]")
                              lbl_unscrew_process.Text = rd.Item("[Unscrewing Process]")
                              lbl_laser_datecode.Text = rd.Item("[Laser Datecode]")
                              lbl_laser_template.Text = rd.Item("[Laser Template]")

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
        Dim sc As New SqlCommand("SELECT * FROM tb_data WHERE [References]='" & txt_ref.Text & "'", KoneksiDB.koneksi)
        Dim rd As SqlDataReader = sc.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Return False
            Exit Function
        End If
        If rd.Item("[Operator ID]") <> txt_ope_id.Text Then
            Return True
        End If
        'Console.WriteLine(rd.Item("[Operator ID]"))
        Return False
    End Function
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        SCAN_MODE = 0
        LASER_STATE = 0
        txt_ref.Text = ""
        txt_ope_id.Text = ""
        txt_po_num.Text = ""
    End Sub
    Public Sub ClearProductionData()
        lbl_st2_meas.Text = ""
        lbl_st4NC_res.Text = ""
        lbl_st4NO_res.Text = ""
        lbl_st4_actu_pos.Text = ""
        lbl_st4_p2.Text = ""
        lbl_st4_p3.Text = ""
        lbl_diff_result.Text = ""
        lbl_status.Text = ""
        lbl_unscrew_status.Text = ""

        lbl_st2_meas_1.Text = ""
        lbl_st4NC_res_1.Text = ""
        lbl_st4NO_res_1.Text = ""
        lbl_st4_actu_pos_1.Text = ""
        lbl_st4_p2_1.Text = ""
        lbl_st4_p3_1.Text = ""
        lbl_diff_result_1.Text = ""
        lbl_status_1.Text = ""
        lbl_unscrew_status_1.Text = ""

        lbl_st2_meas_2.Text = ""
        lbl_st4NC_res_2.Text = ""
        lbl_st4NO_res_2.Text = ""
        lbl_st4_actu_pos_2.Text = ""
        lbl_st4_p2_2.Text = ""
        lbl_st4_p3_2.Text = ""
        lbl_diff_result_2.Text = ""
        lbl_status_2.Text = ""
        lbl_unscrew_status_2.Text = ""

        lbl_st2_meas_3.Text = ""
        lbl_st4NC_res_3.Text = ""
        lbl_st4NO_res_3.Text = ""
        lbl_st4_actu_pos_3.Text = ""
        lbl_st4_p2_3.Text = ""
        lbl_st4_p3_3.Text = ""
        lbl_diff_result_3.Text = ""
        lbl_status_3.Text = ""
        lbl_unscrew_status_3.Text = ""

        lbl_st2_meas_4.Text = ""
        lbl_st4NC_res_4.Text = ""
        lbl_st4NO_res_4.Text = ""
        lbl_st4_actu_pos_4.Text = ""
        lbl_st4_p2_4.Text = ""
        lbl_st4_p3_4.Text = ""
        lbl_diff_result_4.Text = ""
        lbl_status_4.Text = ""
        lbl_unscrew_status_4.Text = ""

        lbl_st2_meas_5.Text = ""
        lbl_st4NC_res_5.Text = ""
        lbl_st4NO_res_5.Text = ""
        lbl_st4_actu_pos_5.Text = ""
        lbl_st4_p2_5.Text = ""
        lbl_st4_p3_5.Text = ""
        lbl_diff_result_5.Text = ""
        lbl_status_5.Text = ""
        lbl_unscrew_status_5.Text = ""
    End Sub
    Dim Action_ST2 As Integer = 1
    Dim Finish6Product As Boolean = False
    Private Sub ST2_Thread()
        Do
            If SCAN_MODE = 3 Or CALIBRATION Then
                Dim binaryString As String = Convert.ToString(ST_COMM2, 2).PadLeft(16, "0"c)
                If binaryString(13) = "1" Then
                    Me.Invoke(Sub()
                                  Dim CurrentCavity As Integer = Modbus.ReadData(REGISTER_TYPE, 48236)
                                  txt_curr_cav_st2.Text = CurrentCavity
                                  Select Case CurrentCavity
                                      Case 1
                                          If txt_st2_act_mea.Text <> "" Then
                                              txt_st2_cal_val_1.Text = txt_st2_act_mea.Text
                                              WriteINI(iniPath, "CALIBRATION", "P0st4Cav1", txt_st2_cal_val_1.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_1.Text)
                                          End If
                                      Case 2
                                          If txt_st2_act_mea.Text <> "" Then
                                              txt_st2_cal_val_2.Text = txt_st2_act_mea.Text
                                              WriteINI(iniPath, "CALIBRATION", "P0st4Cav2", txt_st2_cal_val_2.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CAL_VAL_ST2_2, txt_st2_cal_val_2.Text)
                                          End If
                                      Case 3
                                          If txt_st2_act_mea.Text <> "" Then
                                              txt_st2_cal_val_3.Text = txt_st2_act_mea.Text
                                              WriteINI(iniPath, "CALIBRATION", "P0st4Cav3", txt_st2_cal_val_3.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CAL_VAL_ST2_3, txt_st2_cal_val_3.Text)
                                          End If
                                      Case 4
                                          If txt_st2_act_mea.Text <> "" Then
                                              txt_st2_cal_val_4.Text = txt_st2_act_mea.Text
                                              WriteINI(iniPath, "CALIBRATION", "P0st4Cav4", txt_st2_cal_val_4.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CAL_VAL_ST2_4, txt_st2_cal_val_4.Text)
                                          End If
                                      Case 5
                                          If txt_st2_act_mea.Text <> "" Then
                                              txt_st2_cal_val_5.Text = txt_st2_act_mea.Text
                                              WriteINI(iniPath, "CALIBRATION", "P0st4Cav5", txt_st2_cal_val_5.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CAL_VAL_ST2_5, txt_st2_cal_val_5.Text)
                                          End If
                                      Case 6
                                          If txt_st2_act_mea.Text <> "" Then
                                              txt_st2_cal_val_6.Text = txt_st2_act_mea.Text
                                              WriteINI(iniPath, "CALIBRATION", "P0st4Cav6", txt_st2_cal_val_6.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CAL_VAL_ST2_6, txt_st2_cal_val_6.Text)
                                          End If
                                  End Select
                              End Sub)
                End If
                If binaryString(14) = "0" And binaryString(15) = "1" Then
                    If Not CALIBRATION Then
                        Me.Invoke(Sub()
                                      txt_msg.Text = txt_msg.Text + "Start recording ST2 (Measuring)..." & vbCrLf
                                      CNT_ST2 = CNT_ST2 + 1
                                      Dim st2_result As String = Result.MEASUREMENT

                                      Select Case Action_ST2
                                          Case 1
                                              'lbl_item_1.Text = CNT_ST2
                                              lbl_st2_meas.Text = st2_result
                                              If Finish6Product Then
                                                  lbl_st4NC_res.Text = ""
                                                  lbl_st4NO_res.Text = ""
                                                  lbl_st4_actu_pos.Text = ""
                                                  lbl_st4_p2.Text = ""
                                                  lbl_st4_p3.Text = ""
                                                  lbl_diff_result.Text = ""
                                                  lbl_status.Text = ""
                                                  lbl_unscrew_status.Text = ""
                                              End If
                                              Action_ST2 += 1
                                          Case 2
                                              'lbl_item_2.Text = CNT_ST2
                                              lbl_st2_meas_1.Text = st2_result
                                              If Finish6Product Then
                                                  lbl_st4NC_res_1.Text = ""
                                                  lbl_st4NO_res_1.Text = ""
                                                  lbl_st4_actu_pos_1.Text = ""
                                                  lbl_st4_p2_1.Text = ""
                                                  lbl_st4_p3_1.Text = ""
                                                  lbl_diff_result_1.Text = ""
                                                  lbl_status_1.Text = ""
                                                  lbl_unscrew_status_1.Text = ""
                                              End If
                                              Action_ST2 += 1
                                          Case 3
                                              'lbl_item_3.Text = CNT_ST2
                                              lbl_st2_meas_2.Text = st2_result
                                              If Finish6Product Then
                                                  lbl_st4NC_res_2.Text = ""
                                                  lbl_st4NO_res_2.Text = ""
                                                  lbl_st4_actu_pos_2.Text = ""
                                                  lbl_st4_p2_2.Text = ""
                                                  lbl_st4_p3_2.Text = ""
                                                  lbl_diff_result_2.Text = ""
                                                  lbl_status_2.Text = ""
                                                  lbl_unscrew_status_2.Text = ""
                                              End If
                                              Action_ST2 += 1
                                          Case 4
                                              'lbl_item_4.Text = CNT_ST2
                                              lbl_st2_meas_3.Text = st2_result
                                              If Finish6Product Then
                                                  lbl_st4NC_res_3.Text = ""
                                                  lbl_st4NO_res_3.Text = ""
                                                  lbl_st4_actu_pos_3.Text = ""
                                                  lbl_st4_p2_3.Text = ""
                                                  lbl_st4_p3_3.Text = ""
                                                  lbl_diff_result_3.Text = ""
                                                  lbl_status_3.Text = ""
                                                  lbl_unscrew_status_3.Text = ""
                                              End If
                                              Action_ST2 += 1
                                          Case 5
                                              'lbl_item_5.Text = CNT_ST2
                                              lbl_st2_meas_4.Text = st2_result
                                              If Finish6Product Then
                                                  lbl_st4NC_res_4.Text = ""
                                                  lbl_st4NO_res_4.Text = ""
                                                  lbl_st4_actu_pos_4.Text = ""
                                                  lbl_st4_p2_4.Text = ""
                                                  lbl_st4_p3_4.Text = ""
                                                  lbl_diff_result_4.Text = ""
                                                  lbl_status_4.Text = ""
                                                  lbl_unscrew_status_4.Text = ""
                                              End If
                                              Action_ST2 += 1
                                          Case 6
                                              'lbl_item_6.Text = CNT_ST2
                                              lbl_st2_meas_5.Text = st2_result
                                              If Finish6Product Then
                                                  lbl_st4NC_res_5.Text = ""
                                                  lbl_st4NO_res_5.Text = ""
                                                  lbl_st4_actu_pos_5.Text = ""
                                                  lbl_st4_p2_5.Text = ""
                                                  lbl_st4_p3_5.Text = ""
                                                  lbl_diff_result_5.Text = ""
                                                  lbl_status_5.Text = ""
                                                  lbl_unscrew_status_5.Text = ""
                                              End If
                                              Finish6Product = True
                                              Action_ST2 = 1
                                      End Select

                                      Call KoneksiDB.koneksi_db()
                                      Dim sc As New SqlCommand("INSERT INTO tb_data ([Sequence Number], [References], [Operator ID], [Product Order], Measurement, [Date Time]) VALUES('" & CNT_ST2.ToString & "', '" & txt_ref.Text & "', '" & txt_ope_id.Text & "', '" & txt_po_num.Text & "', '" & st2_result & "', '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')", KoneksiDB.koneksi)
                                      Dim adapter As New SqlDataAdapter(sc)
                                      adapter.SelectCommand.ExecuteNonQuery()
                                      WriteINI(iniPath, "STATUS", "SequenceCounter", CNT_ST2)

                                      txt_msg.Text = txt_msg.Text + "Finish recording ST2 Result = " + st2_result & vbCrLf
                                      Dim temp(16) As Integer
                                      Dim temp_str As String
                                      Dim binaryString_ As String = Convert.ToString(ST_COMM2, 2).PadLeft(16, "0"c)
                                      For i As Integer = 0 To binaryString_.Length - 1
                                          If i = 15 Then
                                              temp(i) = 0
                                          ElseIf i = 14 Then
                                              temp(i) = 1
                                          Else
                                              If binaryString_(i) = "1" Then
                                                  temp(i) = 1
                                              Else
                                                  temp(i) = 0
                                              End If
                                          End If
                                          temp_str = temp_str + temp(i).ToString
                                      Next

                                      Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

                                      Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM2, integerValue_)
                                      lbl_cnt_st2.Text = CNT_ST2
                                      Save_Datalog()
                                  End Sub)

                    End If
                End If
            End If
            Thread.Sleep(150)
        Loop

    End Sub
    Dim Action_ST3 As Integer = 1
    Private Sub ST3_Thread()
        Do
            If SCAN_MODE = 3 Or CALIBRATION Then
                Dim binaryString As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)

                If binaryString(14) = "0" And binaryString(15) = "1" Then
                    'Console.WriteLine("0001")
                    If Not CALIBRATION Then

                    Else

                    End If
                ElseIf binaryString(6) = "0" And binaryString(7) = "1" Then
                    If Not CALIBRATION Then
                        Me.Invoke(Sub()
                                      If is_measuring_nc = False Then
                                          Reset_resistance()
                                          is_measuring_nc = True
                                      Else
                                          Dim resistance_state_off As String = Chroma_resistance()
                                          If resistance_state_off <> "waiting" Then
                                              Dim numericValue As Double = Double.Parse(resistance_state_off) + Config.ResistanceOffset
                                              Select Case Action_ST3
                                                  Case 1
                                                      lbl_st4NC_res.Text = numericValue.ToString
                                                  Case 2
                                                      lbl_st4NC_res_1.Text = numericValue.ToString
                                                  Case 3
                                                      lbl_st4NC_res_2.Text = numericValue.ToString
                                                  Case 4
                                                      lbl_st4NC_res_3.Text = numericValue.ToString
                                                  Case 5
                                                      lbl_st4NC_res_4.Text = numericValue.ToString
                                                  Case 6
                                                      lbl_st4NC_res_5.Text = numericValue.ToString
                                              End Select

                                              Call KoneksiDB.koneksi_db()
                                              Dim sc As New SqlCommand("UPDATE tb_data SET [State Off Resistance] = '" & resistance_state_off & "' WHERE [Sequence Number] = '" & CNT_ST4.ToString & "'", KoneksiDB.koneksi)
                                              Dim adapter As New SqlDataAdapter(sc)
                                              adapter.SelectCommand.ExecuteNonQuery()
                                              Dim temp(16) As Integer
                                              Dim temp_str As String
                                              Dim binaryString_ As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
                                              For i As Integer = 0 To binaryString_.Length - 1
                                                  If i = 6 Then
                                                      temp(i) = 1
                                                  Else
                                                      If binaryString_(i) = "1" Then
                                                          temp(i) = 1
                                                      Else
                                                          temp(i) = 0
                                                      End If
                                                  End If
                                                  temp_str = temp_str + temp(i).ToString
                                              Next

                                              Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

                                              Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM4, integerValue_)
                                              is_measuring_nc = False
                                              txt_msg.Text = txt_msg.Text + "Resistance OFF = " + resistance_state_off & vbCrLf
                                              Save_Datalog()
                                          End If
                                      End If
                                  End Sub)

                    End If
                ElseIf binaryString(4) = "0" And binaryString(5) = "1" Then
                    If Not CALIBRATION Then
                        Me.Invoke(Sub()
                                      If is_measuring_no = False Then
                                          Reset_resistance()
                                          is_measuring_no = True
                                      Else
                                          Dim resistance_state_on As String = Chroma_resistance()

                                          If resistance_state_on <> "waiting" Then
                                              Dim numericValue As Double = Double.Parse(resistance_state_on) + Config.ResistanceOffset
                                              Select Case Action_ST3
                                                  Case 1
                                                      lbl_st4NO_res.Text = numericValue.ToString
                                                      Action_ST3 += 1
                                                  Case 2
                                                      lbl_st4NO_res_1.Text = numericValue.ToString
                                                      Action_ST3 += 1
                                                  Case 3
                                                      lbl_st4NO_res_2.Text = numericValue.ToString
                                                      Action_ST3 += 1
                                                  Case 4
                                                      lbl_st4NO_res_3.Text = numericValue.ToString
                                                      Action_ST3 += 1
                                                  Case 5
                                                      lbl_st4NO_res_4.Text = numericValue.ToString
                                                      Action_ST3 += 1
                                                  Case 6
                                                      lbl_st4NO_res_5.Text = numericValue.ToString
                                                      Action_ST3 = 1
                                              End Select

                                              Call KoneksiDB.koneksi_db()
                                              Dim sc As New SqlCommand("UPDATE tb_data SET [State On Resistance] = '" & resistance_state_on & "' WHERE [Sequence Number] = '" & CNT_ST4.ToString & "'", KoneksiDB.koneksi)
                                              Dim adapter As New SqlDataAdapter(sc)
                                              adapter.SelectCommand.ExecuteNonQuery()
                                              Dim temp(16) As Integer
                                              Dim temp_str As String
                                              Dim binaryString_ As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
                                              For i As Integer = 0 To binaryString_.Length - 1
                                                  If i = 4 Then
                                                      temp(i) = 1
                                                  Else
                                                      If binaryString_(i) = "1" Then
                                                          temp(i) = 1
                                                      Else
                                                          temp(i) = 0
                                                      End If
                                                  End If
                                                  temp_str = temp_str + temp(i).ToString
                                              Next

                                              Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

                                              Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM4, integerValue_)
                                              is_measuring_no = False
                                              txt_msg.Text = txt_msg.Text + "Resistance ON = " + resistance_state_on & vbCrLf
                                              Save_Datalog()
                                          End If
                                      End If

                                  End Sub)
                    End If
                End If
            End If
            Thread.Sleep(150)
        Loop

    End Sub
    Dim Action_ST4 As Integer = 1
    Dim is_measuring_nc As Boolean = False
    Dim is_measuring_no As Boolean = False
    Private Sub ST4_Thread()
        Do
            If SCAN_MODE = 3 Or CALIBRATION Then
                Dim binaryString As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)

                If binaryString(11) = "1" Then
                    ' save
                    Me.Invoke(Sub()
                                  If txt_st4_analog_data.Text <> "" Then
                                      Dim CurrentCavity As Integer = Modbus.ReadData(REGISTER_TYPE, 48224)
                                      txt_curr_cav_st4.Text = CurrentCavity
                                      Select Case CurrentCavity
                                          Case 1
                                              txt_st4_cal_val_gt2_1.Text = Val(txt_st4_analog_data.Text) + Val(txt_offset_gt.Text)
                                              WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav1", txt_st4_cal_val_gt2_1.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_1, txt_st4_cal_val_gt2_1.Text)
                                          Case 2
                                              txt_st4_cal_val_gt2_2.Text = txt_st4_analog_data.Text + Val(txt_offset_gt.Text)
                                              WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav2", txt_st4_cal_val_gt2_2.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_2, txt_st4_cal_val_gt2_2.Text)
                                          Case 3
                                              txt_st4_cal_val_gt2_3.Text = txt_st4_analog_data.Text + Val(txt_offset_gt.Text)
                                              WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav3", txt_st4_cal_val_gt2_3.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_3, txt_st4_cal_val_gt2_3.Text)
                                          Case 4
                                              txt_st4_cal_val_gt2_4.Text = txt_st4_analog_data.Text + Val(txt_offset_gt.Text)
                                              WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav4", txt_st4_cal_val_gt2_4.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_4, txt_st4_cal_val_gt2_4.Text)
                                          Case 5
                                              txt_st4_cal_val_gt2_5.Text = txt_st4_analog_data.Text + Val(txt_offset_gt.Text)
                                              WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav5", txt_st4_cal_val_gt2_5.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_5, txt_st4_cal_val_gt2_5.Text)
                                          Case 6
                                              txt_st4_cal_val_gt2_6.Text = txt_st4_analog_data.Text + Val(txt_offset_gt.Text)
                                              WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav6", txt_st4_cal_val_gt2_6.Text)
                                              Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_6, txt_st4_cal_val_gt2_6.Text)
                                      End Select
                                  End If
                                  If txt_st4_act_pos.Text <> "" Then
                                      txt_st4_cal_val_p0_1.Text = txt_st4_act_pos.Text
                                      txt_st4_cal_val_p0_2.Text = txt_st4_act_pos.Text
                                      txt_st4_cal_val_p0_3.Text = txt_st4_act_pos.Text
                                      txt_st4_cal_val_p0_4.Text = txt_st4_act_pos.Text
                                      txt_st4_cal_val_p0_5.Text = txt_st4_act_pos.Text
                                      txt_st4_cal_val_p0_6.Text = txt_st4_act_pos.Text
                                      WriteINI(iniPath, "CALIBRATION", "P0st4Cav1", txt_st4_cal_val_p0_1.Text)
                                      WriteINI(iniPath, "CALIBRATION", "P0st4Cav2", txt_st4_cal_val_p0_2.Text)
                                      WriteINI(iniPath, "CALIBRATION", "P0st4Cav3", txt_st4_cal_val_p0_3.Text)
                                      WriteINI(iniPath, "CALIBRATION", "P0st4Cav4", txt_st4_cal_val_p0_4.Text)
                                      WriteINI(iniPath, "CALIBRATION", "P0st4Cav5", txt_st4_cal_val_p0_5.Text)
                                      WriteINI(iniPath, "CALIBRATION", "P0st4Cav6", txt_st4_cal_val_p0_6.Text)
                                      Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_1, txt_st4_cal_val_p0_1.Text)
                                      Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_2, txt_st4_cal_val_p0_2.Text)
                                      Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_3, txt_st4_cal_val_p0_3.Text)
                                      Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_4, txt_st4_cal_val_p0_4.Text)
                                      Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_5, txt_st4_cal_val_p0_5.Text)
                                      Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_6, txt_st4_cal_val_p0_6.Text)
                                  End If
                              End Sub)
                End If

                If binaryString(14) = "0" And binaryString(15) = "1" Then
                    'Console.WriteLine("0001")
                    If Not CALIBRATION Then
                        Me.Invoke(Sub()
                                      txt_msg.Text = txt_msg.Text + "Start recording ST4..." & vbCrLf
                                      CNT_ST4 = CNT_ST4 + 1
                                      Dim st4_p2_result As String
                                      Dim st4_p3_result As String
                                      Dim actuation_pos_result As String
                                      Dim diff_result_result As String
                                      Dim st4_t1_result As String
                                      Dim st4_t2_result As String
                                      Dim cot_result As String

                                      With Result
                                          st4_p2_result = .TRAVEL_P2
                                          st4_p3_result = .TRAVEL_P3
                                          actuation_pos_result = .ACTUATION_POS
                                          diff_result_result = .DIFF_STR
                                          st4_t1_result = .T1
                                          st4_t2_result = .T2
                                          cot_result = .COT
                                      End With


                                      Select Case Action_ST4
                                          Case 1
                                              lbl_st4_p2.Text = st4_p2_result
                                              lbl_st4_p3.Text = st4_p3_result
                                              lbl_st4_actu_pos.Text = actuation_pos_result
                                              lbl_diff_result.Text = diff_result_result
                                              lbl_st4_t1.Text = st4_t1_result
                                              lbl_st4_t2.Text = st4_t2_result
                                              lbl_cot.Text = cot_result
                                              Action_ST4 += 1
                                          Case 2
                                              lbl_st4_p2_1.Text = st4_p2_result
                                              lbl_st4_p3_1.Text = st4_p3_result
                                              lbl_st4_actu_pos_1.Text = actuation_pos_result
                                              lbl_diff_result_1.Text = diff_result_result
                                              lbl_st4_t1_1.Text = st4_t1_result
                                              lbl_st4_t2_1.Text = st4_t2_result
                                              lbl_cot_1.Text = cot_result
                                              Action_ST4 += 1
                                          Case 3
                                              lbl_st4_p2_2.Text = st4_p2_result
                                              lbl_st4_p3_2.Text = st4_p3_result
                                              lbl_st4_actu_pos_2.Text = actuation_pos_result
                                              lbl_diff_result_2.Text = diff_result_result
                                              lbl_st4_t1_2.Text = st4_t1_result
                                              lbl_st4_t2_2.Text = st4_t2_result
                                              lbl_cot_2.Text = cot_result
                                              Action_ST4 += 1
                                          Case 4
                                              lbl_st4_p2_3.Text = st4_p2_result
                                              lbl_st4_p3_3.Text = st4_p3_result
                                              lbl_st4_actu_pos_3.Text = actuation_pos_result
                                              lbl_diff_result_3.Text = diff_result_result
                                              lbl_st4_t1_3.Text = st4_t1_result
                                              lbl_st4_t2_3.Text = st4_t2_result
                                              lbl_cot_3.Text = cot_result
                                              Action_ST4 += 1
                                          Case 5
                                              lbl_st4_p2_4.Text = st4_p2_result
                                              lbl_st4_p3_4.Text = st4_p3_result
                                              lbl_st4_actu_pos_4.Text = actuation_pos_result
                                              lbl_diff_result_4.Text = diff_result_result
                                              lbl_st4_t1_4.Text = st4_t1_result
                                              lbl_st4_t2_4.Text = st4_t2_result
                                              lbl_cot_4.Text = cot_result
                                              Action_ST4 += 1
                                          Case 6
                                              lbl_st4_p2_5.Text = st4_p2_result
                                              lbl_st4_p3_5.Text = st4_p3_result
                                              lbl_st4_actu_pos_5.Text = actuation_pos_result
                                              lbl_diff_result_5.Text = diff_result_result
                                              lbl_st4_t1_5.Text = st4_t1_result
                                              lbl_st4_t2_5.Text = st4_t2_result
                                              lbl_cot_5.Text = cot_result
                                              Action_ST4 = 1
                                      End Select

                                      Call KoneksiDB.koneksi_db()
                                      Dim sc As New SqlCommand("UPDATE tb_data SET [Travel P2] = '" & st4_p2_result & "', [Travel P3] = '" & st4_p3_result & "', [Dif Str] = '" & diff_result_result & "', [Actuation Pos] = '" & actuation_pos_result & "' WHERE [Sequence Number] = '" & CNT_ST4.ToString & "'", KoneksiDB.koneksi)
                                      Dim adapter As New SqlDataAdapter(sc)
                                      adapter.SelectCommand.ExecuteNonQuery()

                                      txt_msg.Text = txt_msg.Text + "Finish recording ST4 Result = " & vbCrLf
                                      txt_msg.Text = txt_msg.Text + "P2 = " + st4_p2_result & vbCrLf
                                      txt_msg.Text = txt_msg.Text + "P3 = " + st4_p3_result & vbCrLf
                                      txt_msg.Text = txt_msg.Text + "Diff = " + diff_result_result & vbCrLf
                                      txt_msg.Text = txt_msg.Text + "T1 = " + st4_t1_result & vbCrLf
                                      txt_msg.Text = txt_msg.Text + "T2 = " + st4_t2_result & vbCrLf
                                      txt_msg.Text = txt_msg.Text + "COT = " + cot_result & vbCrLf
                                      Dim temp(16) As Integer
                                      Dim temp_str As String
                                      Dim binaryString_ As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
                                      For i As Integer = 0 To binaryString_.Length - 1
                                          If i = 14 Then
                                              temp(i) = 1
                                          Else
                                              If binaryString_(i) = "1" Then
                                                  temp(i) = 1
                                              Else
                                                  temp(i) = 0
                                              End If
                                          End If
                                          temp_str = temp_str + temp(i).ToString
                                      Next

                                      Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

                                      Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM4, integerValue_)
                                      lbl_cnt_st4.Text = CNT_ST4
                                      Save_Datalog()
                                  End Sub)

                    End If
                ElseIf binaryString(6) = "0" And binaryString(7) = "1" Then
                    If Not CALIBRATION Then


                    End If
                ElseIf binaryString(4) = "0" And binaryString(5) = "1" Then
                    If Not CALIBRATION Then


                    End If
                End If
            End If
            Thread.Sleep(150)
        Loop

    End Sub
    Dim Action_ST5 As Integer = 1
    Private Sub ST5_Thread()
        Do
            If SCAN_MODE = 3 Or CALIBRATION Then
                Dim binaryString As String = Convert.ToString(ST_COMM5, 2).PadLeft(16, "0"c)
                If binaryString(14) = "0" And binaryString(15) = "1" Then
                    Me.Invoke(Sub()
                                  txt_msg.Text = txt_msg.Text + "Start recording ST5 (Unscrewing)..." & vbCrLf
                                  CNT_ST5 = CNT_ST5 + 1
                                  Dim unscrew_status_result As String = Result.UNSCREW_STATUS

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
                                  Dim sc As New SqlCommand("UPDATE tb_data SET [Unscrew Status] = '" & unscrew_status_result & "' WHERE [Sequence Number] = '" & CNT_ST5.ToString & "'", KoneksiDB.koneksi)
                                  Dim adapter As New SqlDataAdapter(sc)
                                  adapter.SelectCommand.ExecuteNonQuery()

                                  txt_msg.Text = txt_msg.Text + "Finish recording ST5 Result = " + unscrew_status_result & vbCrLf
                                  Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM5, 3)
                                  lbl_cnt_st5.Text = CNT_ST5
                                  Save_Datalog()
                              End Sub)
                End If
            End If
            Thread.Sleep(150)
        Loop

    End Sub
    Private Sub btn_clear_database_Click(sender As Object, e As EventArgs) Handles btn_clear_database.Click
        Call KoneksiDB.koneksi_db()
        Dim sc As New SqlCommand("DELETE from tb_data;", KoneksiDB.koneksi)
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
        lbl_st4NC_res.Text = "..."
        lbl_st4_p2.Text = "..."
        lbl_st4_p3.Text = "..."
        lbl_diff_result.Text = "..."
        lbl_st4_t1.Text = "..."
        lbl_st4_t2.Text = "..."
        lbl_cot.Text = "..."
    End Sub
    Private Sub GetUserLevel()
        If USER_LEVEL = 1 Then
            lbl_user.Text = "ADM"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
            btn_st4_cal.Enabled = True
            btn_st2_preset_heidenhain.Enabled = True
            btn_st2_set_cal_val.Enabled = True
            btn_ref.Enabled = True
            btn_alarm.Enabled = True
            btn_multimeter.Enabled = True
            btn_log.Enabled = True
        ElseIf USER_LEVEL = 2 Then
            lbl_user.Text = "ENG"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
            btn_st4_cal.Enabled = False
            btn_st2_preset_heidenhain.Enabled = False
            btn_st2_set_cal_val.Enabled = False
            btn_ref.Enabled = True
            btn_alarm.Enabled = True
            btn_multimeter.Enabled = True
            btn_log.Enabled = True
        ElseIf USER_LEVEL = 3 Then
            lbl_user.Text = "OPE"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
            btn_st4_cal.Enabled = False
            btn_st2_preset_heidenhain.Enabled = False
            btn_st2_set_cal_val.Enabled = False
            btn_ref.Enabled = False
            btn_alarm.Enabled = False
            btn_multimeter.Enabled = False
            btn_log.Enabled = False
        ElseIf USER_LEVEL = 4 Then
            lbl_user.Text = "QUA"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
            btn_st4_cal.Enabled = True
            btn_st2_preset_heidenhain.Enabled = True
            btn_st2_set_cal_val.Enabled = True
            btn_ref.Enabled = False
            btn_alarm.Enabled = False
            btn_multimeter.Enabled = False
            btn_log.Enabled = False
        End If
    End Sub
    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        'Hide()
        frmLogin.ShowDialog()
        GetUserLevel()
    End Sub
    'panel multi
    Private Sub btn_read_ch_1_Click(sender As Object, e As EventArgs) Handles btn_read_ch_1.Click
        txt_ch_1.Text = Chroma_resistance()
    End Sub
    ' panel references
    Private Sub LoadTbRef()
        Call KoneksiDB.koneksi_db()
        Try
            Dim sc As New SqlCommand("SELECT * FROM tb_reference order by [References] asc", KoneksiDB.koneksi)
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
            Dim sc As New SqlCommand("INSERT INTO tb_reference ([References], [Act Val], [Act Val Tolerance], [Dif Str], [Dif Str Tolerance], [Beating Times], [Config 1st Contact], [Config 2nd Contact], [Unscrewing Process], [Laser Datecode], [Laser Template]) VALUES('" & txt_ref_pnl.Text & "', '" & txt_act_val_pnl.Text & "', '" & txt_act_val_tol_pnl.Text & "', '" & txt_dif_str_pnl.Text & "', '" & txt_dif_str_tol_pnl.Text & "', '" & txt_beating_times_pnl.Text & "', '" & txt_cfg_1st_pnl.Text & "', '" & txt_cfg_2nd_pnl.Text & "', '" & txt_unscrew_pnl.Text & "', '" & txt_laser_datecode_pnl.Text & "', '" & txt_laser_template_pnl.Text & "')", KoneksiDB.koneksi)
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
            Dim sc As New SqlCommand("DELETE from tb_reference where [References] = '" & txt_ref_pnl.Text & "'", KoneksiDB.koneksi)
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
            Dim sc As New SqlCommand("UPDATE tb_reference SET [Act Val] = '" & txt_act_val_pnl.Text & "', [Act Val Tolerance] = '" & txt_act_val_tol_pnl.Text & "', [Dif Str] = '" & txt_dif_str_pnl.Text & "', [Dif Str Tolerance] = '" & txt_dif_str_tol_pnl.Text & "', [Beating Times] = '" & txt_beating_times_pnl.Text & "', [Config 1st Contact] = '" & txt_cfg_1st_pnl.Text & "', [Config 2nd Contact] = '" & txt_cfg_2nd_pnl.Text & "', [Unscrewing Process] = '" & txt_unscrew_pnl.Text & "', [Laser Datecode] = '" & txt_laser_datecode_pnl.Text & "', [Laser Template] = '" & txt_laser_template_pnl.Text & "' WHERE [References] = '" & txt_ref_pnl.Text & "'", KoneksiDB.koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub
    Dim bin_val(6) As Integer
    Dim bin_val_(7) As Integer
    Dim bin_str As String
    Dim bin_str_ As String
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply_station.Click
        If cb_downgrade_1.Text = "Disable" Then
            bin_val(0) = 1
        Else
            bin_val(0) = 0
        End If

        If cb_downgrade_2.Text = "Disable" Then
            bin_val(1) = 1
        Else
            bin_val(1) = 0
        End If

        If cb_downgrade_3.Text = "Disable" Then
            bin_val(2) = 1
        Else
            bin_val(2) = 0
        End If

        If cb_downgrade_4.Text = "Disable" Then
            bin_val(3) = 1
        Else
            bin_val(3) = 0
        End If

        If cb_downgrade_5.Text = "Disable" Then
            bin_val(4) = 1
        Else
            bin_val(4) = 0
        End If

        If cb_downgrade_6.Text = "Disable" Then
            bin_val(5) = 1
        Else
            bin_val(5) = 0
        End If

        If st2_measuring.Checked = False Then
            bin_val_(0) = 1
        Else
            bin_val_(0) = 0
        End If

        If st2_beating.Checked = False Then
            bin_val_(1) = 1
        Else
            bin_val_(1) = 0
        End If

        If st3_adjustment.Checked = False Then
            bin_val_(2) = 1
        Else
            bin_val_(2) = 0
        End If

        If CheckBox2.Checked = False Then
            bin_val_(3) = 1
        Else
            bin_val_(3) = 0
        End If

        If st4_cot.Checked = False Then
            bin_val_(4) = 1
        Else
            bin_val_(4) = 0
        End If

        If st4_resistance.Checked = False Then
            bin_val_(5) = 1
        Else
            bin_val_(5) = 0
        End If

        If st6_laser.Checked = False Then
            bin_val_(6) = 1
        Else
            bin_val_(6) = 0
        End If

        bin_str = bin_val(5).ToString + bin_val(4).ToString + bin_val(3).ToString + bin_val(2).ToString + bin_val(1).ToString + bin_val(0).ToString
        bin_str_ = bin_val_(6).ToString + bin_val_(5).ToString + bin_val_(4).ToString + bin_val_(3).ToString + bin_val_(2).ToString + bin_val_(1).ToString + bin_val_(0).ToString

        Dim integerValue As Integer = Convert.ToInt32(bin_str, 2)
        Dim integerValue_ As Integer = Convert.ToInt32(bin_str_, 2)

        Modbus.WriteData(REGISTER_TYPE, ADDR_ST_DOWNGRADE, integerValue)
        Modbus.WriteData(REGISTER_TYPE, ADDR_ST_DOWNGRADE_SUB, integerValue_)

        RTB_CFG.AppendText(Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Change Station Downgrade Configuration Success" + Environment.NewLine)
        RTB_CFG.ScrollToCaret()
    End Sub

    Private Sub cb_downgrade_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_downgrade_3.SelectedIndexChanged
        If cb_downgrade_3.Text = "Enable" Then
            st3_adjustment.Checked = True
            CheckBox2.Checked = True
        Else
            st3_adjustment.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub cb_downgrade_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_downgrade_4.SelectedIndexChanged
        If cb_downgrade_4.Text = "Enable" Then
            st4_cot.Checked = True
            st4_resistance.Checked = True
        Else
            st4_cot.Checked = False
            st4_resistance.Checked = False
        End If
    End Sub

    Private Sub cb_downgrade_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_downgrade_2.SelectedIndexChanged
        If cb_downgrade_2.Text = "Enable" Then
            st2_beating.Checked = True
            st2_measuring.Checked = True
        Else
            st2_beating.Checked = False
            st2_measuring.Checked = False
        End If
    End Sub
    Private Sub cb_downgrade_6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_downgrade_6.SelectedIndexChanged
        If cb_downgrade_6.Text = "Enable" Then
            st6_laser.Checked = True
        Else
            st6_laser.Checked = False
        End If
    End Sub
    Dim strChromaRaw As String
    Private Sub ChromaComm_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles ChromaComm.DataReceived
        strChromaRaw = ChromaComm.ReadLine
        Me.Invoke(Sub()
                      txt_respond_multi.Text = strChromaRaw
                  End Sub)
    End Sub

    Private Sub btn_send_multi_Click(sender As Object, e As EventArgs) Handles btn_send_multi.Click
        ChromaComm.Write(txt_cmd_multi.Text + vbCrLf)
    End Sub

    Public Function Set_chroma(Command As String, Reply As String) As Boolean
        Dim Retry As Integer
        Dim Timeout As Double

Retry:
        Timeout = 0
        ChromaComm.Write(Command & vbCrLf)
        If Reply <> "" Then
            Do While strChromaRaw <> Reply
                Timeout = Timeout + 1
                If Timeout > 60000 Then
                    Retry = Retry + 1
                    If Retry > 4 Then
                        Return False
                        Exit Function
                    Else
                        GoTo Retry
                    End If
                End If
                'System.Windows.Forms.Application.DoEvents()
            Loop
        End If
        Return True
    End Function
    Private Sub Reset_resistance()
        strChromaRaw = ""
        delay = 0
    End Sub
    Private Function Chroma_resistance() As String
        Dim data_fix As String = "waiting"
        If delay = 0 Then
            ChromaComm.Write("TRIG:SOUR INT" + vbCrLf)
            Thread.Sleep(3000)
            ChromaComm.Write("TRIG:SOUR MAN" + vbCrLf)
            Thread.Sleep(500)
            ChromaComm.Write("READ?" + vbCrLf)
            delay = 1
        ElseIf delay >= 10 Then
            Console.WriteLine(strChromaRaw)
            If strChromaRaw.Length >= 12 Then
                data_fix = strChromaRaw
            Else
                data_fix = "waiting"
            End If
        Else
            delay += 1
        End If

        Return data_fix
    End Function

    Private Sub btn_apply_multi_Click(sender As Object, e As EventArgs) Handles btn_apply_multi.Click
        WriteINI(iniPath, "INSTRUMENT", "Name", txt_name_multi.Text)
        WriteINI(iniPath, "INSTRUMENT", "Port", txt_port_multi.Text)
        WriteINI(iniPath, "INSTRUMENT", "Baudrate", txt_baud_multi.Text)
        WriteINI(iniPath, "INSTRUMENT", "Offset", txt_offset_multi.Text)
        RTB_CFG.AppendText(Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Save Instrument Configuration Success" + Environment.NewLine)
        RTB_CFG.ScrollToCaret()
    End Sub

    Private Sub btn_apply_database_Click(sender As Object, e As EventArgs) Handles btn_apply_database.Click
        WriteINI(iniPath, "DATABASE", "Hostname", txt_hostname.Text)
        WriteINI(iniPath, "DATABASE", "Username", txt_username.Text)
        WriteINI(iniPath, "DATABASE", "Password", txt_password.Text)
        WriteINI(iniPath, "DATABASE", "Database", txt_database.Text)
        RTB_CFG.AppendText(Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Save Database Configuration Success" + Environment.NewLine)
        RTB_CFG.ScrollToCaret()
    End Sub

    Private Sub btn_save_plc_Click(sender As Object, e As EventArgs) Handles btn_save_plc.Click
        WriteINI(iniPath, "PLC", "IP", txtIP_PLC.Text)
        WriteINI(iniPath, "PLC", "Port", txtPort_PLC.Text)
        RTB_CFG.AppendText(Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Save PLC Configuration Success" + Environment.NewLine)
        RTB_CFG.ScrollToCaret()
    End Sub
    Private Sub btn_save_laser_Click(sender As Object, e As EventArgs) Handles btn_save_laser.Click
        WriteINI(iniPath, "LASER", "IP", txtIP_laser.Text)
        WriteINI(iniPath, "LASER", "Port", txtPort_laser.Text)
        RTB_CFG.AppendText(Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Save Laser Configuration Success" + Environment.NewLine)
        RTB_CFG.ScrollToCaret()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Cursor = Cursors.WaitCursor
            If ChromaComm.IsOpen Then
                ChromaComm.Close()
            End If
            If ThreadST2.IsAlive Then
                ThreadST2.Abort()
            End If
            If ThreadST3.IsAlive Then
                ThreadST3.Abort()
            End If
            If ThreadST4.IsAlive Then
                ThreadST4.Abort()
            End If
            If ThreadST5.IsAlive Then
                ThreadST5.Abort()
            End If
            If Laser.is_connected Then
                Laser.Disconnect
            End If
        Catch ex As Exception

        End Try

        Thread.Sleep(100)
    End Sub

    Private Sub btn_send_laser_Click(sender As Object, e As EventArgs) Handles btn_send_laser.Click
        If Laser.write_data(txtCommand_laser.Text) Then
            'Console.WriteLine(Laser.read_data)
        End If
    End Sub

    Private Sub dgv_ref_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ref.CellDoubleClick
        Try
            Call KoneksiDB.koneksi_db()
            Dim sc As New SqlCommand("SELECT * FROM tb_reference WHERE [References]='" & dgv_ref.CurrentCell.Value & "'", KoneksiDB.koneksi)
            Dim rd As SqlDataReader = sc.ExecuteReader
            rd.Read()

            txt_ref_pnl.Text = dgv_ref.CurrentCell.Value
            txt_act_val_pnl.Text = rd.Item("Act Val")
            txt_act_val_tol_pnl.Text = rd.Item("Act Val Tolerance")
            txt_dif_str_pnl.Text = rd.Item("Dif Str")
            txt_dif_str_tol_pnl.Text = rd.Item("Dif Str Tolerance")
            txt_beating_times_pnl.Text = rd.Item("Beating Times")
            txt_cfg_1st_pnl.Text = rd.Item("Config 1st Contact")
            txt_cfg_2nd_pnl.Text = rd.Item("Config 2nd Contact")
            txt_unscrew_pnl.Text = rd.Item("Unscrewing Process")
            txt_laser_datecode_pnl.Text = rd.Item("Laser Datecode")
            txt_laser_template_pnl.Text = rd.Item("Laser Template")
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub
    Private Sub btn_st5_servo_enable_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_servo_reset_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_servo_stop_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_homing_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_move_pos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grp_plc_Enter(sender As Object, e As EventArgs) Handles grp_plc.Enter
        If gb_laser.Visible = True Then
            gb_laser.Visible = False
        Else
            gb_laser.Visible = True
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_jog_cw_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_jog_ccw_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_st5_servo_enable_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If
    End Sub

    Private Sub btn_st5_servo_enable_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_servo_reset_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 7 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_servo_reset_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 7 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_servo_stop_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 6 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_servo_stop_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 6 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_homing_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_homing_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_move_pos_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_move_pos_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            'Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST5, Single.Parse(txt_st5_set_pos.Text))

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_move_vel_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_move_vel_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            'Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_VEL_ST5, Single.Parse(txt_st5_set_vel.Text))

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_jog_cw_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_jog_cw_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_jog_ccw_MouseDown(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 1 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub

    Private Sub btn_st5_jog_ccw_MouseUp(sender As Object, e As MouseEventArgs)
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST5, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 1 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST5, integerValue_)
        End If

    End Sub
    Private Sub btn_st4_save_data_Click(sender As Object, e As EventArgs) Handles btn_st4_save_data.Click
        If txt_st4_cal_val_gt2_1.Text <> "" And txt_st4_cal_val_gt2_2.Text <> "" And txt_st4_cal_val_gt2_3.Text <> "" And txt_st4_cal_val_gt2_4.Text <> "" And txt_st4_cal_val_gt2_5.Text <> "" And txt_st4_cal_val_gt2_6.Text <> "" Then

        End If
    End Sub

    Private Sub txt_st4_set_pos_Click(sender As Object, e As EventArgs) Handles txt_st4_set_pos.Click
        If txt_st4_set_pos.Text <> "" And IsNumeric(txt_st4_set_pos.Text) Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST4, txt_st4_set_pos.Text)
        End If
    End Sub

    Private Sub txt_st4_set_vel_Click(sender As Object, e As EventArgs) Handles txt_st4_set_vel.Click
        If txt_st4_set_vel.Text <> "" And IsNumeric(txt_st4_set_vel.Text) Then
            Modbus.WriteData(REGISTER_TYPE, ADDR_SET_VEL_ST4, txt_st4_set_vel.Text)
        End If
    End Sub

    Private Sub btn_st4_servo_enable_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_servo_enable.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If
    End Sub

    Private Sub btn_st4_servo_enable_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_servo_enable.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_servo_reset_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_servo_reset.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 7 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_servo_reset_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_servo_reset.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 7 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_servo_stop_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_servo_stop.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 6 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_servo_stop_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_servo_stop.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 6 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_homing_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_homing.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_homing_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_homing.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_move_pos_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_move_pos.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_move_pos_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_move_pos.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            'Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST4, Single.Parse(txt_st5_set_pos.Text))

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_move_vel_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_move_vel.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_move_vel_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_move_vel.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            'Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_VEL_ST4, Single.Parse(txt_st5_set_vel.Text))

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_jog_cw_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_jog_cw.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_jog_cw_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_jog_cw.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_jog_ccw_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_jog_ccw.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 1 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_jog_ccw_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_jog_ccw.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 1 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST4, integerValue_)
        End If

    End Sub

    Private Sub btn_st4_man_trig_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_man_trig.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next
            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st4_man_trig_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_man_trig.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next
            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st4_cal_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_cal.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st4_cal_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_cal.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next
            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    '' dari sini
    Private Sub btn_st3_save_data_Click(sender As Object, e As EventArgs) Handles btn_st3_save_data.Click
        If txt_st3_set_pos.Text <> "" And IsNumeric(txt_st3_set_pos.Text) Then
            WriteINI(iniPath, "CALIBRATION", "Posst3", txt_st3_set_pos.Text)
        End If

        If txt_st3_set_vel.Text <> "" And IsNumeric(txt_st3_set_vel.Text) Then
            WriteINI(iniPath, "CALIBRATION", "Velst3", txt_st3_set_vel.Text)
        End If
    End Sub

    Private Sub txt_st3_set_pos_Click(sender As Object, e As EventArgs) Handles txt_st3_set_pos.Click
        If txt_st3_set_pos.Text <> "" And IsNumeric(txt_st3_set_pos.Text) Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST3, txt_st3_set_pos.Text)
        End If
    End Sub

    Private Sub txt_st3_set_vel_Click(sender As Object, e As EventArgs) Handles txt_st3_set_vel.Click
        If txt_st3_set_vel.Text <> "" And IsNumeric(txt_st3_set_vel.Text) Then
            Modbus.WriteData(REGISTER_TYPE, ADDR_SET_VEL_ST3, txt_st3_set_vel.Text)
        End If
    End Sub

    Private Sub btn_st3_servo_enable_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_servo_enable.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If
    End Sub

    Private Sub btn_st3_servo_enable_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_servo_enable.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_servo_reset_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_servo_reset.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 7 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_servo_reset_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_servo_reset.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 7 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_servo_stop_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_servo_stop.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 6 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_servo_stop_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_servo_stop.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 6 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_homing_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_homing.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_homing_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_homing.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_move_pos_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_move_pos.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_move_pos_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_move_pos.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            'Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_POS_ST4, Single.Parse(txt_st5_set_pos.Text))

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_move_vel_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_move_vel.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_move_vel_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_move_vel.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 3 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            'Modbus.WriteDataDword(REGISTER_TYPE, ADDR_SET_VEL_ST4, Single.Parse(txt_st5_set_vel.Text))

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_jog_cw_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_jog_cw.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_jog_cw_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_jog_cw.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 2 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_jog_ccw_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st3_jog_ccw.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 1 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st3_jog_ccw_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st3_jog_ccw.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(SERVO_ST3, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 1 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_SERVO_ST3, integerValue_)
        End If

    End Sub

    Private Sub btn_st2_enable_heidenhain_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st2_enable_heidenhain.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 10 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_enable_heidenhain_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st2_enable_heidenhain.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 10 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_preset_heidenhain_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st2_preset_heidenhain.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 9 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_preset_heidenhain_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st2_preset_heidenhain.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 9 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_set_cal_val_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st2_set_cal_val.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_set_cal_val_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st2_set_cal_val.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 8 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)

            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub
    Private Sub txt_st2_punch_cycle_TextChanged(sender As Object, e As EventArgs) Handles txt_st2_punch_cycle.TextChanged
        If txt_st2_punch_cycle.Text <> "" And Val(txt_st2_punch_cycle.Text) > 0 Then
            Modbus.WriteData(REGISTER_TYPE, ADDR_PUNCH_CYCLE_ST2, txt_st2_punch_cycle.Text)
        End If
    End Sub
    Private Sub btn_st2_start_punch_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st2_start_punch.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next
            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_start_punch_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st2_start_punch.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 5 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_stop_punch_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st2_stop_punch.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next
            Console.WriteLine(temp_str)
            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_stop_punch_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st2_stop_punch.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(HEIDENHAIN, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 4 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_HEIDENHAIN, integerValue_)
        End If
    End Sub

    Private Sub btn_trig_turn_table_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_trig_turn_table.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(MANUAL_OPERATION, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 13 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_MANUAL_OPERATION, integerValue_)
        End If
    End Sub

    Private Sub btn_trig_turn_table_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_trig_turn_table.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(MANUAL_OPERATION, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 13 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_MANUAL_OPERATION, integerValue_)
        End If
    End Sub
    Private Sub btn_stn6_laser_start_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_stn6_laser_start.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(LASER_ST6, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 15 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_LASER_ST6, integerValue_)
        End If
    End Sub

    Private Sub btn_stn6_laser_start_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_stn6_laser_start.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(LASER_ST6, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 15 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_LASER_ST6, integerValue_)
        End If
    End Sub
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Cursor = Cursors.WaitCursor
        If rbBydate.Checked Then
            Try
                Dim range1 As String = DateTimePickerStartDate.Value.ToString("yyyy-MM-dd 00:00:00")
                Dim range2 As String = DateTimePickerEndDate.Value.ToString("yyyy-MM-dd 23:59:59")

                Call KoneksiDB.koneksi_db()
                ' Try
                Dim sc As New SqlCommand("SELECT * FROM tb_data WHERE [Date Time] BETWEEN '" + range1 + "' AND '" + range2 + "' ORDER BY [Sequence Number] ASC", KoneksiDB.koneksi)
                Dim adapter As New SqlDataAdapter(sc)
                Dim ds As New DataSet

                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)

                DataGridView1.ClearSelection()
                RTB_LOG.SelectionColor = Color.Black
                RTB_LOG.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[NOTICE] Data search was successful" + Environment.NewLine)
                RTB_LOG.ScrollToCaret()
            Catch ex As Exception
                RTB_LOG.SelectionColor = Color.Red
                RTB_LOG.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[ERROR] Database not found!, " + ex.Message + Environment.NewLine)
                RTB_LOG.ScrollToCaret()
            End Try
        ElseIf rbByREF.Checked Then
            Try
                Call KoneksiDB.koneksi_db()
                ' Try
                Dim sc As New SqlCommand("SELECT * FROM tb_data WHERE [References] = '" + tbSearchREF.Text + "' ORDER BY [Sequence Number] ASC", KoneksiDB.koneksi)
                Dim adapter As New SqlDataAdapter(sc)
                Dim ds As New DataSet

                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)

                DataGridView1.ClearSelection()
                RTB_LOG.SelectionColor = Color.Black
                RTB_LOG.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[NOTICE] Data search was successful" + Environment.NewLine)
                RTB_LOG.ScrollToCaret()
            Catch ex As Exception
                RTB_LOG.SelectionColor = Color.Red
                RTB_LOG.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[ERROR] Database not found!" + Environment.NewLine)
                RTB_LOG.ScrollToCaret()
            End Try
        End If
        Cursor = Cursors.Default
    End Sub
    Dim _SaveFileDialog As New SaveFileDialog
    Private Sub btn_fileLocation_Click_1(sender As Object, e As EventArgs) Handles btn_fileLocation.Click
        _SaveFileDialog.Filter = "CSV Files|*.csv"
        _SaveFileDialog.Title = "Export-csv"
        If _SaveFileDialog.ShowDialog = DialogResult.OK Then
            txtFileLocation.Text = _SaveFileDialog.FileName
        End If
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        If txtFileLocation.Text <> "" Then
            If DataGridView1.RowCount > 0 Then
                Dim value As String = ""
                Dim dr As New DataGridViewRow()

                Dim swOut As StreamWriter = File.CreateText(_SaveFileDialog.FileName)

                'write header rows to csv
                For i As Integer = 0 To DataGridView1.Columns.Count - 1
                    If i > 0 Then
                        swOut.Write(";")
                    End If
                    swOut.Write(DataGridView1.Columns(i).HeaderText)
                Next

                swOut.WriteLine()

                'write DataGridView rows to csv
                ProgressBarExport.Minimum = 0
                ProgressBarExport.Maximum = DataGridView1.Rows.Count - 1
                For j As Integer = 0 To DataGridView1.Rows.Count - 1
                    If j > 0 Then
                        swOut.WriteLine()
                    End If

                    dr = DataGridView1.Rows(j)

                    For i As Integer = 0 To DataGridView1.Columns.Count - 1
                        If i > 0 Then
                            swOut.Write(";")
                        End If
                        If IsDBNull(dr.Cells(i).Value) Then
                            value = "0"
                        Else
                            value = CStr(dr.Cells(i).Value)
                        End If
                        swOut.Write(value)
                    Next
                    ProgressBarExport.Value = j
                Next

                If ProgressBarExport.Value >= ProgressBarExport.Maximum Then
                    RTB_LOG.SelectionColor = Color.Black
                    RTB_LOG.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[NOTICE] Data was successfully exported to csv" + Environment.NewLine)
                    RTB_LOG.ScrollToCaret()
                End If

                swOut.Close()
            End If
        End If
    End Sub

    Private Sub txt_st4_cal_val_p0_1_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_p0_1.Click, txt_curr_cav_st4.Click
        txt_st4_cal_val_p0_1.Text = txt_st4_act_pos.Text
        If txt_st4_cal_val_p0_1.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "P0st4Cav1", txt_st4_cal_val_p0_1.Text)
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_1, txt_st4_cal_val_p0_1.Text)
        End If


    End Sub
    Private Sub txt_st4_cal_val_p0_2_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_p0_2.Click
        txt_st4_cal_val_p0_2.Text = txt_st4_act_pos.Text
        If txt_st4_cal_val_p0_2.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "P0st4Cav2", txt_st4_cal_val_p0_2.Text)
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_2, txt_st4_cal_val_p0_2.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_p0_3_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_p0_3.Click
        txt_st4_cal_val_p0_3.Text = txt_st4_act_pos.Text
        If txt_st4_cal_val_p0_3.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "P0st4Cav3", txt_st4_cal_val_p0_3.Text)
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_3, txt_st4_cal_val_p0_3.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_p0_4_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_p0_4.Click
        txt_st4_cal_val_p0_4.Text = txt_st4_act_pos.Text
        If txt_st4_cal_val_p0_4.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "P0st4Cav4", txt_st4_cal_val_p0_4.Text)
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_4, txt_st4_cal_val_p0_4.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_p0_5_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_p0_5.Click
        txt_st4_cal_val_p0_5.Text = txt_st4_act_pos.Text
        If txt_st4_cal_val_p0_5.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "P0st4Cav5", txt_st4_cal_val_p0_5.Text)
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_5, txt_st4_cal_val_p0_5.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_p0_6_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_p0_6.Click
        txt_st4_cal_val_p0_6.Text = txt_st4_act_pos.Text
        If txt_st4_cal_val_p0_6.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "P0st4Cav6", txt_st4_cal_val_p0_6.Text)
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CALIB_VALUE_P0_ST4_6, txt_st4_cal_val_p0_6.Text)
        End If
    End Sub

    Private Sub txt_st4_cal_val_gt2_1_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_gt2_1.Click
        txt_st4_cal_val_gt2_1.Text = txt_st4_analog_data.Text
        If txt_st4_cal_val_gt2_1.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav1", txt_st4_cal_val_gt2_1.Text)
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_1, txt_st4_cal_val_gt2_1.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_gt2_2_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_gt2_2.Click
        txt_st4_cal_val_gt2_2.Text = txt_st4_analog_data.Text
        If txt_st4_cal_val_gt2_2.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav2", txt_st4_cal_val_gt2_2.Text)
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_2, txt_st4_cal_val_gt2_2.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_gt2_3_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_gt2_3.Click
        txt_st4_cal_val_gt2_3.Text = txt_st4_analog_data.Text
        If txt_st4_cal_val_gt2_3.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav3", txt_st4_cal_val_gt2_3.Text)
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_3, txt_st4_cal_val_gt2_3.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_gt2_4_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_gt2_4.Click
        txt_st4_cal_val_gt2_4.Text = txt_st4_analog_data.Text
        If txt_st4_cal_val_gt2_4.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav4", txt_st4_cal_val_gt2_4.Text)
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_4, txt_st4_cal_val_gt2_4.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_gt2_5_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_gt2_5.Click
        txt_st4_cal_val_gt2_5.Text = txt_st4_analog_data.Text
        If txt_st4_cal_val_gt2_5.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav5", txt_st4_cal_val_gt2_5.Text)
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_5, txt_st4_cal_val_gt2_5.Text)
        End If
    End Sub
    Private Sub txt_st4_cal_val_gt2_6_Click(sender As Object, e As EventArgs) Handles txt_st4_cal_val_gt2_6.Click
        txt_st4_cal_val_gt2_6.Text = txt_st4_analog_data.Text
        If txt_st4_cal_val_gt2_6.Text <> "" Then
            WriteINI(iniPath, "CALIBRATION", "Gt2st4Cav6", txt_st4_cal_val_gt2_6.Text)
            Modbus.WriteData(REGISTER_TYPE, ADDR_CALIB_VALUE_GT2_ST4_6, txt_st4_cal_val_gt2_6.Text)
        End If
    End Sub
    Private Sub txt_st2_cal_val_1_Click(sender As Object, e As EventArgs) Handles txt_st2_cal_val_1.Click, txt_curr_cav_st2.Click
        txt_st2_cal_val_1.Text = txt_st2_act_mea.Text
        If txt_st2_cal_val_1.Text <> "" Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_1.Text)
            WriteINI(iniPath, "CALIBRATION", "HeidenhainCav1", txt_st2_cal_val_1.Text)
        End If
    End Sub
    Private Sub txt_st2_cal_val_2_Click(sender As Object, e As EventArgs) Handles txt_st2_cal_val_2.Click
        txt_st2_cal_val_2.Text = txt_st2_act_mea.Text
        If txt_st2_cal_val_2.Text <> "" Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_2.Text)
            WriteINI(iniPath, "CALIBRATION", "HeidenhainCav2", txt_st2_cal_val_2.Text)
        End If
    End Sub
    Private Sub txt_st2_cal_val_3_Click(sender As Object, e As EventArgs) Handles txt_st2_cal_val_3.Click
        txt_st2_cal_val_3.Text = txt_st2_act_mea.Text
        If txt_st2_cal_val_3.Text <> "" Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_3.Text)
            WriteINI(iniPath, "CALIBRATION", "HeidenhainCav3", txt_st2_cal_val_3.Text)
        End If
    End Sub
    Private Sub txt_st2_cal_val_4_Click(sender As Object, e As EventArgs) Handles txt_st2_cal_val_4.Click
        txt_st2_cal_val_4.Text = txt_st2_act_mea.Text
        If txt_st2_cal_val_4.Text <> "" Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_4.Text)
            WriteINI(iniPath, "CALIBRATION", "HeidenhainCav4", txt_st2_cal_val_4.Text)
        End If
    End Sub
    Private Sub txt_st2_cal_val_5_Click(sender As Object, e As EventArgs) Handles txt_st2_cal_val_5.Click
        txt_st2_cal_val_5.Text = txt_st2_act_mea.Text
        If txt_st2_cal_val_5.Text <> "" Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_5.Text)
            WriteINI(iniPath, "CALIBRATION", "HeidenhainCav5", txt_st2_cal_val_5.Text)
        End If
    End Sub
    Private Sub txt_st2_cal_val_6_Click(sender As Object, e As EventArgs) Handles txt_st2_cal_val_6.Click
        txt_st2_cal_val_6.Text = txt_st2_act_mea.Text
        If txt_st2_cal_val_6.Text <> "" Then
            Modbus.WriteDataDword(REGISTER_TYPE, ADDR_CAL_VAL_ST2_1, txt_st2_cal_val_6.Text)
            WriteINI(iniPath, "CALIBRATION", "HeidenhainCav6", txt_st2_cal_val_6.Text)
        End If
    End Sub

    Private Sub btn_st4_auto_calibration_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st4_auto_calibration.MouseDown
        If Status.Enabled = True Then
            txt_st4_actu_pos.Text = "0"
            txt_st4_diff_str.Text = "0"
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 10 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM4, integerValue_)
        End If
    End Sub

    Private Sub btn_st4_auto_calibration_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st4_auto_calibration.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(ST_COMM4, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 10 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM4, integerValue_)
        End If
    End Sub

    Private Sub btn_empty_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_empty.MouseDown
        Modbus.WriteData(REGISTER_TYPE, ADDR_EMPTY_PROCCESS, 1)
    End Sub

    Private Sub btn_empty_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_empty.MouseUp
        Modbus.WriteData(REGISTER_TYPE, ADDR_EMPTY_PROCCESS, 0)
    End Sub

    Private Sub btn_st2_auto_caib_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_st2_auto_caib.MouseDown
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(ST_COMM2, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 12 Then
                    temp(i) = 1
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM2, integerValue_)
        End If
    End Sub

    Private Sub btn_st2_auto_caib_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_st2_auto_caib.MouseUp
        If Status.Enabled = True Then
            Dim temp(16) As Integer
            Dim temp_str As String
            Dim binaryString As String = Convert.ToString(ST_COMM2, 2).PadLeft(16, "0"c)
            For i As Integer = 0 To binaryString.Length - 1
                If i = 12 Then
                    temp(i) = 0
                Else
                    If binaryString(i) = "1" Then
                        temp(i) = 1
                    Else
                        temp(i) = 0
                    End If
                End If
                temp_str = temp_str + temp(i).ToString
            Next

            Dim integerValue_ As Integer = Convert.ToInt32(temp_str.ToString, 2)
            Modbus.WriteData(REGISTER_TYPE, ADDR_ST_COMM2, integerValue_)
        End If
    End Sub
End Class