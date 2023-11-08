<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateTime = New System.Windows.Forms.Timer(Me.components)
        Me.btn_stn6 = New System.Windows.Forms.Button()
        Me.btn_stn5 = New System.Windows.Forms.Button()
        Me.btn_stn4 = New System.Windows.Forms.Button()
        Me.btn_stn3 = New System.Windows.Forms.Button()
        Me.btn_stn2 = New System.Windows.Forms.Button()
        Me.btn_stn1 = New System.Windows.Forms.Button()
        Me.ModbusRW = New System.Windows.Forms.Timer(Me.components)
        Me.Status = New System.Windows.Forms.Timer(Me.components)
        Me.BarcodeComm = New System.IO.Ports.SerialPort(Me.components)
        Me.ST2 = New System.Windows.Forms.Timer(Me.components)
        Me.ST3 = New System.Windows.Forms.Timer(Me.components)
        Me.ST4 = New System.Windows.Forms.Timer(Me.components)
        Me.ST5 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_run_state = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.lbl_auto_man = New System.Windows.Forms.Label()
        Me.status_bar = New System.Windows.Forms.PictureBox()
        Me.btn_ref = New System.Windows.Forms.Button()
        Me.btn_laser = New System.Windows.Forms.Button()
        Me.btn_multimeter = New System.Windows.Forms.Button()
        Me.btn_alarm = New System.Windows.Forms.Button()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_monitoring = New System.Windows.Forms.Button()
        Me.btn_manual = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.pnl_home = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ind_pass_fail = New System.Windows.Forms.PictureBox()
        Me.GroupBox87 = New System.Windows.Forms.GroupBox()
        Me.btn_clear_database = New System.Windows.Forms.Button()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.lbl_cnt_st5 = New System.Windows.Forms.Label()
        Me.lbl_cnt_st4 = New System.Windows.Forms.Label()
        Me.lbl_cnt_st3 = New System.Windows.Forms.Label()
        Me.lbl_cnt_st2 = New System.Windows.Forms.Label()
        Me.GroupBox78 = New System.Windows.Forms.GroupBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.laabel2 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.laabel3 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.laabel1 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status = New System.Windows.Forms.Label()
        Me.lbl_st4_t2 = New System.Windows.Forms.Label()
        Me.lbl_st4_p2 = New System.Windows.Forms.Label()
        Me.lbl_diff_result = New System.Windows.Forms.Label()
        Me.lbl_st2_meas = New System.Windows.Forms.Label()
        Me.lbl_cot = New System.Windows.Forms.Label()
        Me.lbl_st4_t1 = New System.Windows.Forms.Label()
        Me.lbl_st3_res = New System.Windows.Forms.Label()
        Me.lbl_st4_p3 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.GroupBox86 = New System.Windows.Forms.GroupBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.lbl_laser_template = New System.Windows.Forms.Label()
        Me.lbl_unscrew_process = New System.Windows.Forms.Label()
        Me.lbl_dif_str_tol = New System.Windows.Forms.Label()
        Me.lbl_cfg_1st = New System.Windows.Forms.Label()
        Me.lbl_act_val_tol = New System.Windows.Forms.Label()
        Me.lbl_laser_datecode = New System.Windows.Forms.Label()
        Me.lbl_cfg_2nd = New System.Windows.Forms.Label()
        Me.lbl_dif_str = New System.Windows.Forms.Label()
        Me.lbl_beating_times = New System.Windows.Forms.Label()
        Me.lbl_act_val = New System.Windows.Forms.Label()
        Me.GroupBox77 = New System.Windows.Forms.GroupBox()
        Me.ind_software_stop = New System.Windows.Forms.PictureBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.ind_software_run = New System.Windows.Forms.PictureBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.ind_software_open = New System.Windows.Forms.PictureBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_run = New System.Windows.Forms.Button()
        Me.GroupBox80 = New System.Windows.Forms.GroupBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.lbl_po_num = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.lbl_ope_id = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.lbl_ref = New System.Windows.Forms.Label()
        Me.GroupBox76 = New System.Windows.Forms.GroupBox()
        Me.ind_plc_status = New System.Windows.Forms.PictureBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.lbl_cnt = New System.Windows.Forms.Label()
        Me.lbl_op_ins = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.pnl_man_stn6 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox88 = New System.Windows.Forms.GroupBox()
        Me.GroupBox89 = New System.Windows.Forms.GroupBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.stn6_cyl6_min = New System.Windows.Forms.PictureBox()
        Me.stn6_cyl6_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox90 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_cyl6_fw = New System.Windows.Forms.Button()
        Me.btn_stn6_cyl6_bw = New System.Windows.Forms.Button()
        Me.GroupBox73 = New System.Windows.Forms.GroupBox()
        Me.GroupBox74 = New System.Windows.Forms.GroupBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.stn6_cyl5_min = New System.Windows.Forms.PictureBox()
        Me.stn6_cyl5_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox75 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_cyl5_fw = New System.Windows.Forms.Button()
        Me.btn_stn6_cyl5_bw = New System.Windows.Forms.Button()
        Me.GroupBox67 = New System.Windows.Forms.GroupBox()
        Me.GroupBox68 = New System.Windows.Forms.GroupBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.stn6_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.stn6_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox69 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_cyl4_fw = New System.Windows.Forms.Button()
        Me.btn_stn6_cyl4_bw = New System.Windows.Forms.Button()
        Me.GroupBox64 = New System.Windows.Forms.GroupBox()
        Me.GroupBox65 = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.stn6_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.stn6_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox66 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_cyl3_fw = New System.Windows.Forms.Button()
        Me.btn_stn6_cyl3_bw = New System.Windows.Forms.Button()
        Me.GroupBox61 = New System.Windows.Forms.GroupBox()
        Me.GroupBox62 = New System.Windows.Forms.GroupBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.stn6_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.stn6_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox63 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_cyl2_fw = New System.Windows.Forms.Button()
        Me.btn_stn6_cyl2_bw = New System.Windows.Forms.Button()
        Me.GroupBox70 = New System.Windows.Forms.GroupBox()
        Me.GroupBox71 = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.stn6_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.stn6_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox72 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_cyl1_fw = New System.Windows.Forms.Button()
        Me.btn_stn6_cyl1_bw = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox58 = New System.Windows.Forms.GroupBox()
        Me.GroupBox60 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl1_bw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl1_fw = New System.Windows.Forms.Button()
        Me.GroupBox59 = New System.Windows.Forms.GroupBox()
        Me.stn5_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox55 = New System.Windows.Forms.GroupBox()
        Me.GroupBox57 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl3_bw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl3_fw = New System.Windows.Forms.Button()
        Me.GroupBox56 = New System.Windows.Forms.GroupBox()
        Me.stn5_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.GroupBox52 = New System.Windows.Forms.GroupBox()
        Me.GroupBox54 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl2_bw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl2_fw = New System.Windows.Forms.Button()
        Me.GroupBox53 = New System.Windows.Forms.GroupBox()
        Me.stn5_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox49 = New System.Windows.Forms.GroupBox()
        Me.GroupBox51 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl4_bw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl4_fw = New System.Windows.Forms.Button()
        Me.GroupBox50 = New System.Windows.Forms.GroupBox()
        Me.stn5_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.pnl_man_stn5 = New System.Windows.Forms.TabControl()
        Me.pnl_man_stn4 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox37 = New System.Windows.Forms.GroupBox()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.stn4_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.stn4_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox39 = New System.Windows.Forms.GroupBox()
        Me.btn_stn4_cyl4_fw = New System.Windows.Forms.Button()
        Me.btn_stn4_cyl4_bw = New System.Windows.Forms.Button()
        Me.GroupBox43 = New System.Windows.Forms.GroupBox()
        Me.GroupBox44 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.stn4_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.stn4_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox45 = New System.Windows.Forms.GroupBox()
        Me.btn_stn4_cyl3_fw = New System.Windows.Forms.Button()
        Me.btn_stn4_cyl3_bw = New System.Windows.Forms.Button()
        Me.GroupBox46 = New System.Windows.Forms.GroupBox()
        Me.GroupBox47 = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.stn4_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.stn4_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox48 = New System.Windows.Forms.GroupBox()
        Me.btn_stn4_cyl1_fw = New System.Windows.Forms.Button()
        Me.btn_stn4_cyl1_bw = New System.Windows.Forms.Button()
        Me.GroupBox40 = New System.Windows.Forms.GroupBox()
        Me.GroupBox41 = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.stn4_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.stn4_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox42 = New System.Windows.Forms.GroupBox()
        Me.btn_stn4_cyl2_fw = New System.Windows.Forms.Button()
        Me.btn_stn4_cyl2_bw = New System.Windows.Forms.Button()
        Me.pnl_man_stn3 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.stn3_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.stn3_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.btn_stn3_cyl4_fw = New System.Windows.Forms.Button()
        Me.btn_stn3_cyl4_bw = New System.Windows.Forms.Button()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.stn3_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.stn3_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.btn_stn3_cyl2_fw = New System.Windows.Forms.Button()
        Me.btn_stn3_cyl2_bw = New System.Windows.Forms.Button()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.stn3_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.stn3_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.btn_stn3_cyl3_fw = New System.Windows.Forms.Button()
        Me.btn_stn3_cyl3_bw = New System.Windows.Forms.Button()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.stn3_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.stn3_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox36 = New System.Windows.Forms.GroupBox()
        Me.btn_stn3_cyl1_fw = New System.Windows.Forms.Button()
        Me.btn_stn3_cyl1_bw = New System.Windows.Forms.Button()
        Me.pnl_man_stn2 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.stn2_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.stn2_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.btn_stn2_cyl4_fw = New System.Windows.Forms.Button()
        Me.btn_stn2_cyl4_bw = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.stn2_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.stn2_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.btn_stn2_cyl2_fw = New System.Windows.Forms.Button()
        Me.btn_stn2_cyl2_bw = New System.Windows.Forms.Button()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.stn2_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.stn2_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.btn_stn2_cyl3_fw = New System.Windows.Forms.Button()
        Me.btn_stn2_cyl3_bw = New System.Windows.Forms.Button()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.stn2_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.stn2_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.btn_stn2_cyl1_fw = New System.Windows.Forms.Button()
        Me.btn_stn2_cyl1_bw = New System.Windows.Forms.Button()
        Me.pnl_man_stn1 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.stn1_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.stn1_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btn_stn1_cyl4_fw = New System.Windows.Forms.Button()
        Me.btn_stn1_cyl4_bw = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stn1_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.stn1_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_stn1_cyl2_fw = New System.Windows.Forms.Button()
        Me.btn_stn1_cyl2_bw = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.stn1_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.stn1_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btn_stn1_cyl3_fw = New System.Windows.Forms.Button()
        Me.btn_stn1_cyl3_bw = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.stn1_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.stn1_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_stn1_cyl1_fw = New System.Windows.Forms.Button()
        Me.btn_stn1_cyl1_bw = New System.Windows.Forms.Button()
        Me.pnl_setting = New System.Windows.Forms.TabControl()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.GroupBox169 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.connect_multi_ind = New System.Windows.Forms.PictureBox()
        Me.Label226 = New System.Windows.Forms.Label()
        Me.txtIP_multi = New System.Windows.Forms.TextBox()
        Me.btn_check_multi = New System.Windows.Forms.Button()
        Me.btn_connect_multi = New System.Windows.Forms.Button()
        Me.txtPort_multi = New System.Windows.Forms.TextBox()
        Me.grp_plc = New System.Windows.Forms.GroupBox()
        Me.cbo_data_type = New System.Windows.Forms.ComboBox()
        Me.connect_plc_ind = New System.Windows.Forms.PictureBox()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.btn_connect_plc = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.txtPort_PLC = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtIP_PLC = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnl_log = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox174 = New System.Windows.Forms.GroupBox()
        Me.TabControl10 = New System.Windows.Forms.TabControl()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label249 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label250 = New System.Windows.Forms.Label()
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.cb_search_opt = New System.Windows.Forms.ComboBox()
        Me.btn_search_other = New System.Windows.Forms.Button()
        Me.txt_find_other = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnl_ref = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_ref = New System.Windows.Forms.DataGridView()
        Me.GroupBox_Control = New System.Windows.Forms.GroupBox()
        Me.txt_laser_template_pnl = New System.Windows.Forms.TextBox()
        Me.txt_beating_times_pnl = New System.Windows.Forms.TextBox()
        Me.Label247 = New System.Windows.Forms.Label()
        Me.Label237 = New System.Windows.Forms.Label()
        Me.txt_laser_datecode_pnl = New System.Windows.Forms.TextBox()
        Me.txt_dif_str_tol_pnl = New System.Windows.Forms.TextBox()
        Me.Label246 = New System.Windows.Forms.Label()
        Me.Label238 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_unscrew_pnl = New System.Windows.Forms.TextBox()
        Me.txt_dif_str_pnl = New System.Windows.Forms.TextBox()
        Me.txt_cfg_2nd_pnl = New System.Windows.Forms.TextBox()
        Me.txt_act_val_tol_pnl = New System.Windows.Forms.TextBox()
        Me.Label245 = New System.Windows.Forms.Label()
        Me.Label239 = New System.Windows.Forms.Label()
        Me.Label244 = New System.Windows.Forms.Label()
        Me.Label240 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_cfg_1st_pnl = New System.Windows.Forms.TextBox()
        Me.txt_act_val_pnl = New System.Windows.Forms.TextBox()
        Me.Label243 = New System.Windows.Forms.Label()
        Me.txt_ref_pnl = New System.Windows.Forms.TextBox()
        Me.Label241 = New System.Windows.Forms.Label()
        Me.Label242 = New System.Windows.Forms.Label()
        Me.pnl_laser = New System.Windows.Forms.TabControl()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.GroupBox171 = New System.Windows.Forms.GroupBox()
        Me.GroupBox172 = New System.Windows.Forms.GroupBox()
        Me.txt_comm_log = New System.Windows.Forms.TextBox()
        Me.GroupBox173 = New System.Windows.Forms.GroupBox()
        Me.btn_mark_flag = New System.Windows.Forms.Button()
        Me.btn_change_prg = New System.Windows.Forms.Button()
        Me.btn_start_marking = New System.Windows.Forms.Button()
        Me.btn_string_char = New System.Windows.Forms.Button()
        Me.txt_block2 = New System.Windows.Forms.TextBox()
        Me.txt_block1 = New System.Windows.Forms.TextBox()
        Me.txt_block0 = New System.Windows.Forms.TextBox()
        Me.Label232 = New System.Windows.Forms.Label()
        Me.chb_mark_cavity_1 = New System.Windows.Forms.CheckBox()
        Me.Label233 = New System.Windows.Forms.Label()
        Me.cb_prg_num = New System.Windows.Forms.ComboBox()
        Me.Label234 = New System.Windows.Forms.Label()
        Me.Label235 = New System.Windows.Forms.Label()
        Me.pnl_multi = New System.Windows.Forms.TabControl()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.GroupBox170 = New System.Windows.Forms.GroupBox()
        Me.Label229 = New System.Windows.Forms.Label()
        Me.Label230 = New System.Windows.Forms.Label()
        Me.txt_ch_1 = New System.Windows.Forms.TextBox()
        Me.btn_read_ch_2 = New System.Windows.Forms.Button()
        Me.btn_read_ch_1 = New System.Windows.Forms.Button()
        Me.txt_ch_2 = New System.Windows.Forms.TextBox()
        Me.pnl_alarm = New System.Windows.Forms.TabControl()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.GroupBox85 = New System.Windows.Forms.GroupBox()
        Me.ind_v602_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.ind_v601_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.GroupBox83 = New System.Windows.Forms.GroupBox()
        Me.ind_v402_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.ind_v401_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.GroupBox84 = New System.Windows.Forms.GroupBox()
        Me.ind_v502_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.ind_v501_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.GroupBox82 = New System.Windows.Forms.GroupBox()
        Me.ind_v302_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.ind_v301_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.GroupBox81 = New System.Windows.Forms.GroupBox()
        Me.ind_v202_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.ind_v201_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.GroupBox79 = New System.Windows.Forms.GroupBox()
        Me.ind_emg_button = New System.Windows.Forms.PictureBox()
        Me.ind_door_lock_6 = New System.Windows.Forms.PictureBox()
        Me.ind_altivar_fault = New System.Windows.Forms.PictureBox()
        Me.ind_door_lock_4 = New System.Windows.Forms.PictureBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.ind_door_lock_2 = New System.Windows.Forms.PictureBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.ind_air_presence = New System.Windows.Forms.PictureBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.ind_door_lock_5 = New System.Windows.Forms.PictureBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.ind_door_lock_3 = New System.Windows.Forms.PictureBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.ind_door_lock_1 = New System.Windows.Forms.PictureBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.pnl_mon_stn6 = New System.Windows.Forms.TabControl()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.GroupBox151 = New System.Windows.Forms.GroupBox()
        Me.GroupBox152 = New System.Windows.Forms.GroupBox()
        Me.Label201 = New System.Windows.Forms.Label()
        Me.Label202 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl6_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn6_cyl6_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox153 = New System.Windows.Forms.GroupBox()
        Me.Label214 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl6_fw = New System.Windows.Forms.PictureBox()
        Me.Label213 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl6_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox154 = New System.Windows.Forms.GroupBox()
        Me.GroupBox155 = New System.Windows.Forms.GroupBox()
        Me.Label203 = New System.Windows.Forms.Label()
        Me.Label204 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl5_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn6_cyl5_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox156 = New System.Windows.Forms.GroupBox()
        Me.Label225 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl5_fw = New System.Windows.Forms.PictureBox()
        Me.Label224 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl5_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox157 = New System.Windows.Forms.GroupBox()
        Me.GroupBox158 = New System.Windows.Forms.GroupBox()
        Me.Label205 = New System.Windows.Forms.Label()
        Me.Label206 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn6_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox159 = New System.Windows.Forms.GroupBox()
        Me.Label223 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl4_fw = New System.Windows.Forms.PictureBox()
        Me.Label222 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl4_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox160 = New System.Windows.Forms.GroupBox()
        Me.GroupBox161 = New System.Windows.Forms.GroupBox()
        Me.Label207 = New System.Windows.Forms.Label()
        Me.Label208 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn6_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox162 = New System.Windows.Forms.GroupBox()
        Me.Label216 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl3_fw = New System.Windows.Forms.PictureBox()
        Me.Label215 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl3_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox163 = New System.Windows.Forms.GroupBox()
        Me.GroupBox164 = New System.Windows.Forms.GroupBox()
        Me.Label209 = New System.Windows.Forms.Label()
        Me.Label210 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn6_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox165 = New System.Windows.Forms.GroupBox()
        Me.Label219 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl2_fw = New System.Windows.Forms.PictureBox()
        Me.Label218 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl2_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox166 = New System.Windows.Forms.GroupBox()
        Me.GroupBox167 = New System.Windows.Forms.GroupBox()
        Me.Label211 = New System.Windows.Forms.Label()
        Me.Label212 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn6_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox168 = New System.Windows.Forms.GroupBox()
        Me.Label221 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl1_fw = New System.Windows.Forms.PictureBox()
        Me.Label220 = New System.Windows.Forms.Label()
        Me.mon_stn6_cyl1_bw = New System.Windows.Forms.PictureBox()
        Me.pnl_mon_stn5 = New System.Windows.Forms.TabControl()
        Me.TabPage17 = New System.Windows.Forms.TabPage()
        Me.GroupBox139 = New System.Windows.Forms.GroupBox()
        Me.GroupBox140 = New System.Windows.Forms.GroupBox()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn5_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox141 = New System.Windows.Forms.GroupBox()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl4_fw = New System.Windows.Forms.PictureBox()
        Me.Label187 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl4_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox142 = New System.Windows.Forms.GroupBox()
        Me.GroupBox143 = New System.Windows.Forms.GroupBox()
        Me.Label188 = New System.Windows.Forms.Label()
        Me.Label189 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn5_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox144 = New System.Windows.Forms.GroupBox()
        Me.Label190 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl2_fw = New System.Windows.Forms.PictureBox()
        Me.Label191 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl2_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox145 = New System.Windows.Forms.GroupBox()
        Me.GroupBox146 = New System.Windows.Forms.GroupBox()
        Me.Label192 = New System.Windows.Forms.Label()
        Me.Label193 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn5_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox147 = New System.Windows.Forms.GroupBox()
        Me.Label194 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl3_fw = New System.Windows.Forms.PictureBox()
        Me.Label195 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl3_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox148 = New System.Windows.Forms.GroupBox()
        Me.GroupBox149 = New System.Windows.Forms.GroupBox()
        Me.Label196 = New System.Windows.Forms.Label()
        Me.Label197 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn5_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox150 = New System.Windows.Forms.GroupBox()
        Me.Label198 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl1_fw = New System.Windows.Forms.PictureBox()
        Me.Label199 = New System.Windows.Forms.Label()
        Me.mon_stn5_cyl1_bw = New System.Windows.Forms.PictureBox()
        Me.pnl_mon_stn4 = New System.Windows.Forms.TabControl()
        Me.TabPage18 = New System.Windows.Forms.TabPage()
        Me.GroupBox127 = New System.Windows.Forms.GroupBox()
        Me.GroupBox128 = New System.Windows.Forms.GroupBox()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn4_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox129 = New System.Windows.Forms.GroupBox()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl4_fw = New System.Windows.Forms.PictureBox()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl4_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox130 = New System.Windows.Forms.GroupBox()
        Me.GroupBox131 = New System.Windows.Forms.GroupBox()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn4_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox132 = New System.Windows.Forms.GroupBox()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl2_fw = New System.Windows.Forms.PictureBox()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl2_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox133 = New System.Windows.Forms.GroupBox()
        Me.GroupBox134 = New System.Windows.Forms.GroupBox()
        Me.Label175 = New System.Windows.Forms.Label()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn4_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox135 = New System.Windows.Forms.GroupBox()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl3_fw = New System.Windows.Forms.PictureBox()
        Me.Label178 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl3_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox136 = New System.Windows.Forms.GroupBox()
        Me.GroupBox137 = New System.Windows.Forms.GroupBox()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.Label180 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn4_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox138 = New System.Windows.Forms.GroupBox()
        Me.Label181 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl1_fw = New System.Windows.Forms.PictureBox()
        Me.Label182 = New System.Windows.Forms.Label()
        Me.mon_stn4_cyl1_bw = New System.Windows.Forms.PictureBox()
        Me.pnl_mon_stn3 = New System.Windows.Forms.TabControl()
        Me.TabPage19 = New System.Windows.Forms.TabPage()
        Me.GroupBox115 = New System.Windows.Forms.GroupBox()
        Me.GroupBox116 = New System.Windows.Forms.GroupBox()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn3_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox117 = New System.Windows.Forms.GroupBox()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl4_fw = New System.Windows.Forms.PictureBox()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl4_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox118 = New System.Windows.Forms.GroupBox()
        Me.GroupBox119 = New System.Windows.Forms.GroupBox()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn3_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox120 = New System.Windows.Forms.GroupBox()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl2_fw = New System.Windows.Forms.PictureBox()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl2_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox121 = New System.Windows.Forms.GroupBox()
        Me.GroupBox122 = New System.Windows.Forms.GroupBox()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn3_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox123 = New System.Windows.Forms.GroupBox()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl3_fw = New System.Windows.Forms.PictureBox()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl3_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox124 = New System.Windows.Forms.GroupBox()
        Me.GroupBox125 = New System.Windows.Forms.GroupBox()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn3_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox126 = New System.Windows.Forms.GroupBox()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl1_fw = New System.Windows.Forms.PictureBox()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.mon_stn3_cyl1_bw = New System.Windows.Forms.PictureBox()
        Me.pnl_mon_stn2 = New System.Windows.Forms.TabControl()
        Me.TabPage20 = New System.Windows.Forms.TabPage()
        Me.GroupBox103 = New System.Windows.Forms.GroupBox()
        Me.GroupBox104 = New System.Windows.Forms.GroupBox()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn2_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox105 = New System.Windows.Forms.GroupBox()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl4_fw = New System.Windows.Forms.PictureBox()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl4_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox106 = New System.Windows.Forms.GroupBox()
        Me.GroupBox107 = New System.Windows.Forms.GroupBox()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn2_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox108 = New System.Windows.Forms.GroupBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl2_fw = New System.Windows.Forms.PictureBox()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl2_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox109 = New System.Windows.Forms.GroupBox()
        Me.GroupBox110 = New System.Windows.Forms.GroupBox()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn2_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox111 = New System.Windows.Forms.GroupBox()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl3_fw = New System.Windows.Forms.PictureBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl3_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox112 = New System.Windows.Forms.GroupBox()
        Me.GroupBox113 = New System.Windows.Forms.GroupBox()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn2_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox114 = New System.Windows.Forms.GroupBox()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl1_fw = New System.Windows.Forms.PictureBox()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.mon_stn2_cyl1_bw = New System.Windows.Forms.PictureBox()
        Me.pnl_mon_stn1 = New System.Windows.Forms.TabControl()
        Me.TabPage21 = New System.Windows.Forms.TabPage()
        Me.GroupBox97 = New System.Windows.Forms.GroupBox()
        Me.GroupBox98 = New System.Windows.Forms.GroupBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn1_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox99 = New System.Windows.Forms.GroupBox()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl4_fw = New System.Windows.Forms.PictureBox()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl4_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox91 = New System.Windows.Forms.GroupBox()
        Me.GroupBox92 = New System.Windows.Forms.GroupBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn1_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox93 = New System.Windows.Forms.GroupBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl2_fw = New System.Windows.Forms.PictureBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl2_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox94 = New System.Windows.Forms.GroupBox()
        Me.GroupBox95 = New System.Windows.Forms.GroupBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn1_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox96 = New System.Windows.Forms.GroupBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl3_fw = New System.Windows.Forms.PictureBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl3_bw = New System.Windows.Forms.PictureBox()
        Me.GroupBox100 = New System.Windows.Forms.GroupBox()
        Me.GroupBox101 = New System.Windows.Forms.GroupBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.mon_stn1_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox102 = New System.Windows.Forms.GroupBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl1_fw = New System.Windows.Forms.PictureBox()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.mon_stn1_cyl1_bw = New System.Windows.Forms.PictureBox()
        CType(Me.status_bar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_home.SuspendLayout
        Me.TabPage3.SuspendLayout
        CType(Me.ind_pass_fail, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox87.SuspendLayout
        Me.GroupBox78.SuspendLayout
        Me.GroupBox86.SuspendLayout
        Me.GroupBox77.SuspendLayout
        CType(Me.ind_software_stop, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_software_run, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_software_open, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox80.SuspendLayout
        Me.GroupBox76.SuspendLayout
        CType(Me.ind_plc_status, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_man_stn6.SuspendLayout
        Me.TabPage4.SuspendLayout
        Me.GroupBox88.SuspendLayout
        Me.GroupBox89.SuspendLayout
        CType(Me.stn6_cyl6_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_cyl6_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox90.SuspendLayout
        Me.GroupBox73.SuspendLayout
        Me.GroupBox74.SuspendLayout
        CType(Me.stn6_cyl5_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_cyl5_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox75.SuspendLayout
        Me.GroupBox67.SuspendLayout
        Me.GroupBox68.SuspendLayout
        CType(Me.stn6_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox69.SuspendLayout
        Me.GroupBox64.SuspendLayout
        Me.GroupBox65.SuspendLayout
        CType(Me.stn6_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox66.SuspendLayout
        Me.GroupBox61.SuspendLayout
        Me.GroupBox62.SuspendLayout
        CType(Me.stn6_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox63.SuspendLayout
        Me.GroupBox70.SuspendLayout
        Me.GroupBox71.SuspendLayout
        CType(Me.stn6_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox72.SuspendLayout
        Me.TabPage5.SuspendLayout
        Me.GroupBox58.SuspendLayout
        Me.GroupBox60.SuspendLayout
        Me.GroupBox59.SuspendLayout
        CType(Me.stn5_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox55.SuspendLayout
        Me.GroupBox57.SuspendLayout
        Me.GroupBox56.SuspendLayout
        CType(Me.stn5_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox52.SuspendLayout
        Me.GroupBox54.SuspendLayout
        Me.GroupBox53.SuspendLayout
        CType(Me.stn5_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox49.SuspendLayout
        Me.GroupBox51.SuspendLayout
        Me.GroupBox50.SuspendLayout
        CType(Me.stn5_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_man_stn5.SuspendLayout
        Me.pnl_man_stn4.SuspendLayout
        Me.TabPage6.SuspendLayout
        Me.GroupBox37.SuspendLayout
        Me.GroupBox38.SuspendLayout
        CType(Me.stn4_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn4_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox39.SuspendLayout
        Me.GroupBox43.SuspendLayout
        Me.GroupBox44.SuspendLayout
        CType(Me.stn4_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn4_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox45.SuspendLayout
        Me.GroupBox46.SuspendLayout
        Me.GroupBox47.SuspendLayout
        CType(Me.stn4_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn4_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox48.SuspendLayout
        Me.GroupBox40.SuspendLayout
        Me.GroupBox41.SuspendLayout
        CType(Me.stn4_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn4_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox42.SuspendLayout
        Me.pnl_man_stn3.SuspendLayout
        Me.TabPage7.SuspendLayout
        Me.GroupBox25.SuspendLayout
        Me.GroupBox26.SuspendLayout
        CType(Me.stn3_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn3_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox27.SuspendLayout
        Me.GroupBox28.SuspendLayout
        Me.GroupBox29.SuspendLayout
        CType(Me.stn3_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn3_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox30.SuspendLayout
        Me.GroupBox31.SuspendLayout
        Me.GroupBox32.SuspendLayout
        CType(Me.stn3_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn3_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox33.SuspendLayout
        Me.GroupBox34.SuspendLayout
        Me.GroupBox35.SuspendLayout
        CType(Me.stn3_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn3_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox36.SuspendLayout
        Me.pnl_man_stn2.SuspendLayout
        Me.TabPage8.SuspendLayout
        Me.GroupBox13.SuspendLayout
        Me.GroupBox14.SuspendLayout
        CType(Me.stn2_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn2_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox15.SuspendLayout
        Me.GroupBox16.SuspendLayout
        Me.GroupBox17.SuspendLayout
        CType(Me.stn2_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn2_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox18.SuspendLayout
        Me.GroupBox19.SuspendLayout
        Me.GroupBox20.SuspendLayout
        CType(Me.stn2_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn2_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox21.SuspendLayout
        Me.GroupBox22.SuspendLayout
        Me.GroupBox23.SuspendLayout
        CType(Me.stn2_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn2_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox24.SuspendLayout
        Me.pnl_man_stn1.SuspendLayout
        Me.TabPage9.SuspendLayout
        Me.GroupBox10.SuspendLayout
        Me.GroupBox11.SuspendLayout
        CType(Me.stn1_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn1_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox12.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.GroupBox5.SuspendLayout
        CType(Me.stn1_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn1_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox6.SuspendLayout
        Me.GroupBox7.SuspendLayout
        Me.GroupBox8.SuspendLayout
        CType(Me.stn1_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn1_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox9.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.stn1_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn1_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.pnl_setting.SuspendLayout
        Me.TabPage10.SuspendLayout
        Me.GroupBox169.SuspendLayout
        CType(Me.connect_multi_ind, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_plc.SuspendLayout
        CType(Me.connect_plc_ind, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_log.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.GroupBox174.SuspendLayout
        Me.TabControl10.SuspendLayout
        Me.TabPage11.SuspendLayout
        Me.TabPage12.SuspendLayout
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_ref.SuspendLayout
        Me.TabPage2.SuspendLayout
        CType(Me.dgv_ref, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox_Control.SuspendLayout
        Me.pnl_laser.SuspendLayout
        Me.TabPage13.SuspendLayout
        Me.GroupBox171.SuspendLayout
        Me.GroupBox172.SuspendLayout
        Me.GroupBox173.SuspendLayout
        Me.pnl_multi.SuspendLayout
        Me.TabPage14.SuspendLayout
        Me.GroupBox170.SuspendLayout
        Me.pnl_alarm.SuspendLayout
        Me.TabPage15.SuspendLayout
        Me.GroupBox85.SuspendLayout
        CType(Me.ind_v602_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v601_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox83.SuspendLayout
        CType(Me.ind_v402_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v401_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox84.SuspendLayout
        CType(Me.ind_v502_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v501_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox82.SuspendLayout
        CType(Me.ind_v302_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v301_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox81.SuspendLayout
        CType(Me.ind_v202_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v201_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox79.SuspendLayout
        CType(Me.ind_emg_button, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_door_lock_6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_altivar_fault, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_door_lock_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_door_lock_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_air_presence, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_door_lock_5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_door_lock_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_door_lock_1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_mon_stn6.SuspendLayout
        Me.TabPage16.SuspendLayout
        Me.GroupBox151.SuspendLayout
        Me.GroupBox152.SuspendLayout
        CType(Me.mon_stn6_cyl6_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl6_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox153.SuspendLayout
        CType(Me.mon_stn6_cyl6_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl6_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox154.SuspendLayout
        Me.GroupBox155.SuspendLayout
        CType(Me.mon_stn6_cyl5_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl5_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox156.SuspendLayout
        CType(Me.mon_stn6_cyl5_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl5_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox157.SuspendLayout
        Me.GroupBox158.SuspendLayout
        CType(Me.mon_stn6_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox159.SuspendLayout
        CType(Me.mon_stn6_cyl4_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl4_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox160.SuspendLayout
        Me.GroupBox161.SuspendLayout
        CType(Me.mon_stn6_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox162.SuspendLayout
        CType(Me.mon_stn6_cyl3_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl3_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox163.SuspendLayout
        Me.GroupBox164.SuspendLayout
        CType(Me.mon_stn6_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox165.SuspendLayout
        CType(Me.mon_stn6_cyl2_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl2_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox166.SuspendLayout
        Me.GroupBox167.SuspendLayout
        CType(Me.mon_stn6_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox168.SuspendLayout
        CType(Me.mon_stn6_cyl1_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn6_cyl1_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_mon_stn5.SuspendLayout
        Me.TabPage17.SuspendLayout
        Me.GroupBox139.SuspendLayout
        Me.GroupBox140.SuspendLayout
        CType(Me.mon_stn5_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox141.SuspendLayout
        CType(Me.mon_stn5_cyl4_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl4_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox142.SuspendLayout
        Me.GroupBox143.SuspendLayout
        CType(Me.mon_stn5_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox144.SuspendLayout
        CType(Me.mon_stn5_cyl2_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl2_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox145.SuspendLayout
        Me.GroupBox146.SuspendLayout
        CType(Me.mon_stn5_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox147.SuspendLayout
        CType(Me.mon_stn5_cyl3_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl3_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox148.SuspendLayout
        Me.GroupBox149.SuspendLayout
        CType(Me.mon_stn5_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox150.SuspendLayout
        CType(Me.mon_stn5_cyl1_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn5_cyl1_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_mon_stn4.SuspendLayout
        Me.TabPage18.SuspendLayout
        Me.GroupBox127.SuspendLayout
        Me.GroupBox128.SuspendLayout
        CType(Me.mon_stn4_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox129.SuspendLayout
        CType(Me.mon_stn4_cyl4_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl4_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox130.SuspendLayout
        Me.GroupBox131.SuspendLayout
        CType(Me.mon_stn4_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox132.SuspendLayout
        CType(Me.mon_stn4_cyl2_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl2_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox133.SuspendLayout
        Me.GroupBox134.SuspendLayout
        CType(Me.mon_stn4_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox135.SuspendLayout
        CType(Me.mon_stn4_cyl3_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl3_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox136.SuspendLayout
        Me.GroupBox137.SuspendLayout
        CType(Me.mon_stn4_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox138.SuspendLayout
        CType(Me.mon_stn4_cyl1_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn4_cyl1_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_mon_stn3.SuspendLayout
        Me.TabPage19.SuspendLayout
        Me.GroupBox115.SuspendLayout
        Me.GroupBox116.SuspendLayout
        CType(Me.mon_stn3_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox117.SuspendLayout
        CType(Me.mon_stn3_cyl4_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl4_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox118.SuspendLayout
        Me.GroupBox119.SuspendLayout
        CType(Me.mon_stn3_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox120.SuspendLayout
        CType(Me.mon_stn3_cyl2_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl2_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox121.SuspendLayout
        Me.GroupBox122.SuspendLayout
        CType(Me.mon_stn3_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox123.SuspendLayout
        CType(Me.mon_stn3_cyl3_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl3_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox124.SuspendLayout
        Me.GroupBox125.SuspendLayout
        CType(Me.mon_stn3_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox126.SuspendLayout
        CType(Me.mon_stn3_cyl1_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn3_cyl1_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_mon_stn2.SuspendLayout
        Me.TabPage20.SuspendLayout
        Me.GroupBox103.SuspendLayout
        Me.GroupBox104.SuspendLayout
        CType(Me.mon_stn2_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox105.SuspendLayout
        CType(Me.mon_stn2_cyl4_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl4_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox106.SuspendLayout
        Me.GroupBox107.SuspendLayout
        CType(Me.mon_stn2_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox108.SuspendLayout
        CType(Me.mon_stn2_cyl2_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl2_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox109.SuspendLayout
        Me.GroupBox110.SuspendLayout
        CType(Me.mon_stn2_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox111.SuspendLayout
        CType(Me.mon_stn2_cyl3_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl3_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox112.SuspendLayout
        Me.GroupBox113.SuspendLayout
        CType(Me.mon_stn2_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox114.SuspendLayout
        CType(Me.mon_stn2_cyl1_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn2_cyl1_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_mon_stn1.SuspendLayout
        Me.TabPage21.SuspendLayout
        Me.GroupBox97.SuspendLayout
        Me.GroupBox98.SuspendLayout
        CType(Me.mon_stn1_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox99.SuspendLayout
        CType(Me.mon_stn1_cyl4_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl4_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox91.SuspendLayout
        Me.GroupBox92.SuspendLayout
        CType(Me.mon_stn1_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox93.SuspendLayout
        CType(Me.mon_stn1_cyl2_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl2_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox94.SuspendLayout
        Me.GroupBox95.SuspendLayout
        CType(Me.mon_stn1_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox96.SuspendLayout
        CType(Me.mon_stn1_cyl3_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl3_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox100.SuspendLayout
        Me.GroupBox101.SuspendLayout
        CType(Me.mon_stn1_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox102.SuspendLayout
        CType(Me.mon_stn1_cyl1_fw, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mon_stn1_cyl1_bw, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Black
        Me.lbl_user.Location = New System.Drawing.Point(953, 52)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(44, 20)
        Me.lbl_user.TabIndex = 61
        Me.lbl_user.Text = "ENG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(819, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Colaborate With :"
        '
        'dateTime
        '
        Me.dateTime.Enabled = True
        '
        'btn_stn6
        '
        Me.btn_stn6.FlatAppearance.BorderSize = 0
        Me.btn_stn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6.Location = New System.Drawing.Point(937, 452)
        Me.btn_stn6.Name = "btn_stn6"
        Me.btn_stn6.Size = New System.Drawing.Size(60, 60)
        Me.btn_stn6.TabIndex = 66
        Me.btn_stn6.Text = "ST 6"
        Me.btn_stn6.UseVisualStyleBackColor = True
        '
        'btn_stn5
        '
        Me.btn_stn5.FlatAppearance.BorderSize = 0
        Me.btn_stn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5.Location = New System.Drawing.Point(937, 381)
        Me.btn_stn5.Name = "btn_stn5"
        Me.btn_stn5.Size = New System.Drawing.Size(60, 60)
        Me.btn_stn5.TabIndex = 66
        Me.btn_stn5.Text = "ST 5"
        Me.btn_stn5.UseVisualStyleBackColor = True
        '
        'btn_stn4
        '
        Me.btn_stn4.FlatAppearance.BorderSize = 0
        Me.btn_stn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4.Location = New System.Drawing.Point(937, 310)
        Me.btn_stn4.Name = "btn_stn4"
        Me.btn_stn4.Size = New System.Drawing.Size(60, 60)
        Me.btn_stn4.TabIndex = 66
        Me.btn_stn4.Text = "ST 4"
        Me.btn_stn4.UseVisualStyleBackColor = True
        '
        'btn_stn3
        '
        Me.btn_stn3.FlatAppearance.BorderSize = 0
        Me.btn_stn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3.Location = New System.Drawing.Point(937, 239)
        Me.btn_stn3.Name = "btn_stn3"
        Me.btn_stn3.Size = New System.Drawing.Size(60, 60)
        Me.btn_stn3.TabIndex = 66
        Me.btn_stn3.Text = "ST 3"
        Me.btn_stn3.UseVisualStyleBackColor = True
        '
        'btn_stn2
        '
        Me.btn_stn2.FlatAppearance.BorderSize = 0
        Me.btn_stn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2.Location = New System.Drawing.Point(937, 168)
        Me.btn_stn2.Name = "btn_stn2"
        Me.btn_stn2.Size = New System.Drawing.Size(60, 60)
        Me.btn_stn2.TabIndex = 66
        Me.btn_stn2.Text = "ST 2"
        Me.btn_stn2.UseVisualStyleBackColor = True
        '
        'btn_stn1
        '
        Me.btn_stn1.FlatAppearance.BorderSize = 0
        Me.btn_stn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1.Location = New System.Drawing.Point(937, 97)
        Me.btn_stn1.Name = "btn_stn1"
        Me.btn_stn1.Size = New System.Drawing.Size(60, 60)
        Me.btn_stn1.TabIndex = 66
        Me.btn_stn1.Text = "ST 1"
        Me.btn_stn1.UseVisualStyleBackColor = True
        '
        'ModbusRW
        '
        '
        'Status
        '
        '
        'BarcodeComm
        '
        Me.BarcodeComm.PortName = "COM7"
        '
        'ST2
        '
        '
        'ST3
        '
        '
        'ST4
        '
        '
        'ST5
        '
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(644, 48)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(122, 25)
        Me.lbl_date.TabIndex = 87
        Me.lbl_date.Text = "00-00-0000"
        '
        'lbl_run_state
        '
        Me.lbl_run_state.AutoSize = True
        Me.lbl_run_state.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_run_state.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_run_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_run_state.ForeColor = System.Drawing.Color.White
        Me.lbl_run_state.Location = New System.Drawing.Point(240, 48)
        Me.lbl_run_state.Name = "lbl_run_state"
        Me.lbl_run_state.Size = New System.Drawing.Size(112, 25)
        Me.lbl_run_state.TabIndex = 88
        Me.lbl_run_state.Text = "STOPPED"
        '
        'lbl_curr_time
        '
        Me.lbl_curr_time.AutoSize = True
        Me.lbl_curr_time.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_curr_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_curr_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curr_time.ForeColor = System.Drawing.Color.White
        Me.lbl_curr_time.Location = New System.Drawing.Point(670, 9)
        Me.lbl_curr_time.Name = "lbl_curr_time"
        Me.lbl_curr_time.Size = New System.Drawing.Size(96, 25)
        Me.lbl_curr_time.TabIndex = 89
        Me.lbl_curr_time.Text = "12:00:00"
        '
        'lbl_auto_man
        '
        Me.lbl_auto_man.AutoSize = True
        Me.lbl_auto_man.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_auto_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_auto_man.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_auto_man.ForeColor = System.Drawing.Color.White
        Me.lbl_auto_man.Location = New System.Drawing.Point(240, 9)
        Me.lbl_auto_man.Name = "lbl_auto_man"
        Me.lbl_auto_man.Size = New System.Drawing.Size(100, 25)
        Me.lbl_auto_man.TabIndex = 90
        Me.lbl_auto_man.Text = "MANUAL"
        '
        'status_bar
        '
        Me.status_bar.BackColor = System.Drawing.SystemColors.Control
        Me.status_bar.Image = Global.TESTER.My.Resources.Resources.GUI___SignUpButtonOn40
        Me.status_bar.Location = New System.Drawing.Point(234, 2)
        Me.status_bar.Name = "status_bar"
        Me.status_bar.Size = New System.Drawing.Size(541, 79)
        Me.status_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.status_bar.TabIndex = 86
        Me.status_bar.TabStop = False
        '
        'btn_ref
        '
        Me.btn_ref.FlatAppearance.BorderSize = 0
        Me.btn_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ref.Image = Global.TESTER.My.Resources.Resources.imgonline_com_ua_ReplaceColor_xBihTEFLjatznSmQ
        Me.btn_ref.Location = New System.Drawing.Point(13, 556)
        Me.btn_ref.Name = "btn_ref"
        Me.btn_ref.Size = New System.Drawing.Size(60, 60)
        Me.btn_ref.TabIndex = 69
        Me.btn_ref.UseVisualStyleBackColor = True
        '
        'btn_laser
        '
        Me.btn_laser.FlatAppearance.BorderSize = 0
        Me.btn_laser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_laser.Image = Global.TESTER.My.Resources.Resources.image__4__removebg_preview_modified1
        Me.btn_laser.Location = New System.Drawing.Point(12, 490)
        Me.btn_laser.Name = "btn_laser"
        Me.btn_laser.Size = New System.Drawing.Size(60, 60)
        Me.btn_laser.TabIndex = 69
        Me.btn_laser.UseVisualStyleBackColor = True
        '
        'btn_multimeter
        '
        Me.btn_multimeter.FlatAppearance.BorderSize = 0
        Me.btn_multimeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multimeter.Image = Global.TESTER.My.Resources.Resources.multimeter_new
        Me.btn_multimeter.Location = New System.Drawing.Point(12, 424)
        Me.btn_multimeter.Name = "btn_multimeter"
        Me.btn_multimeter.Size = New System.Drawing.Size(60, 60)
        Me.btn_multimeter.TabIndex = 69
        Me.btn_multimeter.UseVisualStyleBackColor = True
        '
        'btn_alarm
        '
        Me.btn_alarm.FlatAppearance.BorderSize = 0
        Me.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alarm.Image = Global.TESTER.My.Resources.Resources.alarm_56
        Me.btn_alarm.Location = New System.Drawing.Point(13, 358)
        Me.btn_alarm.Name = "btn_alarm"
        Me.btn_alarm.Size = New System.Drawing.Size(60, 60)
        Me.btn_alarm.TabIndex = 69
        Me.btn_alarm.UseVisualStyleBackColor = True
        '
        'btn_setting
        '
        Me.btn_setting.FlatAppearance.BorderSize = 0
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Image = Global.TESTER.My.Resources.Resources.setting
        Me.btn_setting.Location = New System.Drawing.Point(13, 292)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(60, 60)
        Me.btn_setting.TabIndex = 69
        Me.btn_setting.UseVisualStyleBackColor = True
        '
        'btn_monitoring
        '
        Me.btn_monitoring.FlatAppearance.BorderSize = 0
        Me.btn_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_monitoring.Image = Global.TESTER.My.Resources.Resources.monitoring
        Me.btn_monitoring.Location = New System.Drawing.Point(13, 226)
        Me.btn_monitoring.Name = "btn_monitoring"
        Me.btn_monitoring.Size = New System.Drawing.Size(60, 60)
        Me.btn_monitoring.TabIndex = 68
        Me.btn_monitoring.UseVisualStyleBackColor = True
        '
        'btn_manual
        '
        Me.btn_manual.FlatAppearance.BorderSize = 0
        Me.btn_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manual.Image = Global.TESTER.My.Resources.Resources.manual
        Me.btn_manual.Location = New System.Drawing.Point(13, 160)
        Me.btn_manual.Name = "btn_manual"
        Me.btn_manual.Size = New System.Drawing.Size(60, 60)
        Me.btn_manual.TabIndex = 67
        Me.btn_manual.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Image = Global.TESTER.My.Resources.Resources.home
        Me.btn_home.Location = New System.Drawing.Point(13, 94)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(60, 60)
        Me.btn_home.TabIndex = 66
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_user
        '
        Me.btn_user.FlatAppearance.BorderSize = 0
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_user.Image = Global.TESTER.My.Resources.Resources.a_secured_2_30x30
        Me.btn_user.Location = New System.Drawing.Point(953, 9)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(41, 38)
        Me.btn_user.TabIndex = 65
        Me.btn_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(822, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TESTER.My.Resources.Resources.telemecanique_sensors_logo_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'btn_log
        '
        Me.btn_log.FlatAppearance.BorderSize = 0
        Me.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log.Image = Global.TESTER.My.Resources.Resources.imgonline_com_ua_ReplaceColor_PlA00UlE53dEW3J
        Me.btn_log.Location = New System.Drawing.Point(12, 622)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(60, 60)
        Me.btn_log.TabIndex = 69
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'pnl_home
        '
        Me.pnl_home.Controls.Add(Me.TabPage3)
        Me.pnl_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_home.Location = New System.Drawing.Point(78, 97)
        Me.pnl_home.Name = "pnl_home"
        Me.pnl_home.SelectedIndex = 0
        Me.pnl_home.Size = New System.Drawing.Size(853, 558)
        Me.pnl_home.TabIndex = 95
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ind_pass_fail)
        Me.TabPage3.Controls.Add(Me.GroupBox87)
        Me.TabPage3.Controls.Add(Me.GroupBox78)
        Me.TabPage3.Controls.Add(Me.GroupBox86)
        Me.TabPage3.Controls.Add(Me.GroupBox77)
        Me.TabPage3.Controls.Add(Me.GroupBox80)
        Me.TabPage3.Controls.Add(Me.GroupBox76)
        Me.TabPage3.Controls.Add(Me.lbl_cnt)
        Me.TabPage3.Controls.Add(Me.lbl_op_ins)
        Me.TabPage3.Controls.Add(Me.Label86)
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(845, 516)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Home"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ind_pass_fail
        '
        Me.ind_pass_fail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_pass_fail.Location = New System.Drawing.Point(680, 63)
        Me.ind_pass_fail.Name = "ind_pass_fail"
        Me.ind_pass_fail.Size = New System.Drawing.Size(85, 85)
        Me.ind_pass_fail.TabIndex = 57
        Me.ind_pass_fail.TabStop = False
        '
        'GroupBox87
        '
        Me.GroupBox87.Controls.Add(Me.btn_clear_database)
        Me.GroupBox87.Controls.Add(Me.Label105)
        Me.GroupBox87.Controls.Add(Me.Label103)
        Me.GroupBox87.Controls.Add(Me.Label98)
        Me.GroupBox87.Controls.Add(Me.Label115)
        Me.GroupBox87.Controls.Add(Me.lbl_cnt_st5)
        Me.GroupBox87.Controls.Add(Me.lbl_cnt_st4)
        Me.GroupBox87.Controls.Add(Me.lbl_cnt_st3)
        Me.GroupBox87.Controls.Add(Me.lbl_cnt_st2)
        Me.GroupBox87.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox87.Location = New System.Drawing.Point(308, 441)
        Me.GroupBox87.Name = "GroupBox87"
        Me.GroupBox87.Size = New System.Drawing.Size(460, 61)
        Me.GroupBox87.TabIndex = 51
        Me.GroupBox87.TabStop = False
        Me.GroupBox87.Text = "Station Counter :"
        Me.GroupBox87.Visible = False
        '
        'btn_clear_database
        '
        Me.btn_clear_database.FlatAppearance.BorderSize = 0
        Me.btn_clear_database.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_database.Location = New System.Drawing.Point(342, 23)
        Me.btn_clear_database.Name = "btn_clear_database"
        Me.btn_clear_database.Size = New System.Drawing.Size(102, 27)
        Me.btn_clear_database.TabIndex = 66
        Me.btn_clear_database.Text = "Clear DB"
        Me.btn_clear_database.UseVisualStyleBackColor = True
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(254, 30)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(38, 20)
        Me.Label105.TabIndex = 36
        Me.Label105.Text = "ST5"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(173, 30)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(38, 20)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "ST4"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(88, 30)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(38, 20)
        Me.Label98.TabIndex = 36
        Me.Label98.Text = "ST3"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(10, 30)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(38, 20)
        Me.Label115.TabIndex = 36
        Me.Label115.Text = "ST2"
        '
        'lbl_cnt_st5
        '
        Me.lbl_cnt_st5.BackColor = System.Drawing.Color.White
        Me.lbl_cnt_st5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cnt_st5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnt_st5.Location = New System.Drawing.Point(295, 31)
        Me.lbl_cnt_st5.Name = "lbl_cnt_st5"
        Me.lbl_cnt_st5.Size = New System.Drawing.Size(22, 20)
        Me.lbl_cnt_st5.TabIndex = 37
        Me.lbl_cnt_st5.Text = "..."
        '
        'lbl_cnt_st4
        '
        Me.lbl_cnt_st4.BackColor = System.Drawing.Color.White
        Me.lbl_cnt_st4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cnt_st4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnt_st4.Location = New System.Drawing.Point(214, 31)
        Me.lbl_cnt_st4.Name = "lbl_cnt_st4"
        Me.lbl_cnt_st4.Size = New System.Drawing.Size(22, 20)
        Me.lbl_cnt_st4.TabIndex = 37
        Me.lbl_cnt_st4.Text = "..."
        '
        'lbl_cnt_st3
        '
        Me.lbl_cnt_st3.BackColor = System.Drawing.Color.White
        Me.lbl_cnt_st3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cnt_st3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnt_st3.Location = New System.Drawing.Point(129, 31)
        Me.lbl_cnt_st3.Name = "lbl_cnt_st3"
        Me.lbl_cnt_st3.Size = New System.Drawing.Size(22, 20)
        Me.lbl_cnt_st3.TabIndex = 37
        Me.lbl_cnt_st3.Text = "..."
        '
        'lbl_cnt_st2
        '
        Me.lbl_cnt_st2.BackColor = System.Drawing.Color.White
        Me.lbl_cnt_st2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cnt_st2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnt_st2.Location = New System.Drawing.Point(51, 31)
        Me.lbl_cnt_st2.Name = "lbl_cnt_st2"
        Me.lbl_cnt_st2.Size = New System.Drawing.Size(22, 20)
        Me.lbl_cnt_st2.TabIndex = 37
        Me.lbl_cnt_st2.Text = "..."
        '
        'GroupBox78
        '
        Me.GroupBox78.Controls.Add(Me.Label68)
        Me.GroupBox78.Controls.Add(Me.Label81)
        Me.GroupBox78.Controls.Add(Me.Label84)
        Me.GroupBox78.Controls.Add(Me.laabel2)
        Me.GroupBox78.Controls.Add(Me.Label116)
        Me.GroupBox78.Controls.Add(Me.Label117)
        Me.GroupBox78.Controls.Add(Me.laabel3)
        Me.GroupBox78.Controls.Add(Me.Label119)
        Me.GroupBox78.Controls.Add(Me.laabel1)
        Me.GroupBox78.Controls.Add(Me.Label121)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_t2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas)
        Me.GroupBox78.Controls.Add(Me.lbl_cot)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_t1)
        Me.GroupBox78.Controls.Add(Me.lbl_st3_res)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3)
        Me.GroupBox78.Controls.Add(Me.lbl_status)
        Me.GroupBox78.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox78.Location = New System.Drawing.Point(553, 157)
        Me.GroupBox78.Name = "GroupBox78"
        Me.GroupBox78.Size = New System.Drawing.Size(215, 278)
        Me.GroupBox78.TabIndex = 52
        Me.GroupBox78.TabStop = False
        Me.GroupBox78.Text = "Production Data :"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(6, 249)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(144, 18)
        Me.Label68.TabIndex = 36
        Me.Label68.Text = "ST5 Unscrew Status"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(6, 201)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(56, 18)
        Me.Label81.TabIndex = 36
        Me.Label81.Text = "ST4 T2"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(6, 108)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(105, 18)
        Me.Label84.TabIndex = 36
        Me.Label84.Text = "ST4 P2 Travel "
        '
        'laabel2
        '
        Me.laabel2.AutoSize = True
        Me.laabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laabel2.Location = New System.Drawing.Point(6, 154)
        Me.laabel2.Name = "laabel2"
        Me.laabel2.Size = New System.Drawing.Size(99, 18)
        Me.laabel2.TabIndex = 36
        Me.laabel2.Text = "Diff Str Result"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(6, 61)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(130, 18)
        Me.Label116.TabIndex = 36
        Me.Label116.Text = "ST2 Measurement"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(6, 225)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(93, 18)
        Me.Label117.TabIndex = 36
        Me.Label117.Text = "COT (T2-T1)"
        '
        'laabel3
        '
        Me.laabel3.AutoSize = True
        Me.laabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laabel3.Location = New System.Drawing.Point(6, 177)
        Me.laabel3.Name = "laabel3"
        Me.laabel3.Size = New System.Drawing.Size(56, 18)
        Me.laabel3.TabIndex = 36
        Me.laabel3.Text = "ST4 T1"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(6, 84)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(113, 18)
        Me.Label119.TabIndex = 36
        Me.Label119.Text = "ST3 Resistance"
        '
        'laabel1
        '
        Me.laabel1.AutoSize = True
        Me.laabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laabel1.Location = New System.Drawing.Point(6, 130)
        Me.laabel1.Name = "laabel1"
        Me.laabel1.Size = New System.Drawing.Size(101, 18)
        Me.laabel1.TabIndex = 36
        Me.laabel1.Text = "ST4 P3 Travel"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(6, 37)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(115, 18)
        Me.Label121.TabIndex = 36
        Me.Label121.Text = "Status Pass/Fail"
        '
        'lbl_unscrew_status
        '
        Me.lbl_unscrew_status.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status.Location = New System.Drawing.Point(153, 247)
        Me.lbl_unscrew_status.Name = "lbl_unscrew_status"
        Me.lbl_unscrew_status.Size = New System.Drawing.Size(53, 20)
        Me.lbl_unscrew_status.TabIndex = 37
        Me.lbl_unscrew_status.Text = "..."
        '
        'lbl_st4_t2
        '
        Me.lbl_st4_t2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2.Location = New System.Drawing.Point(153, 199)
        Me.lbl_st4_t2.Name = "lbl_st4_t2"
        Me.lbl_st4_t2.Size = New System.Drawing.Size(53, 20)
        Me.lbl_st4_t2.TabIndex = 37
        Me.lbl_st4_t2.Text = "..."
        '
        'lbl_st4_p2
        '
        Me.lbl_st4_p2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2.Location = New System.Drawing.Point(153, 106)
        Me.lbl_st4_p2.Name = "lbl_st4_p2"
        Me.lbl_st4_p2.Size = New System.Drawing.Size(53, 20)
        Me.lbl_st4_p2.TabIndex = 37
        Me.lbl_st4_p2.Text = "..."
        '
        'lbl_diff_result
        '
        Me.lbl_diff_result.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result.Location = New System.Drawing.Point(153, 152)
        Me.lbl_diff_result.Name = "lbl_diff_result"
        Me.lbl_diff_result.Size = New System.Drawing.Size(53, 20)
        Me.lbl_diff_result.TabIndex = 37
        Me.lbl_diff_result.Text = "..."
        '
        'lbl_st2_meas
        '
        Me.lbl_st2_meas.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas.Location = New System.Drawing.Point(153, 59)
        Me.lbl_st2_meas.Name = "lbl_st2_meas"
        Me.lbl_st2_meas.Size = New System.Drawing.Size(53, 20)
        Me.lbl_st2_meas.TabIndex = 37
        Me.lbl_st2_meas.Text = "..."
        '
        'lbl_cot
        '
        Me.lbl_cot.BackColor = System.Drawing.Color.White
        Me.lbl_cot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot.Location = New System.Drawing.Point(153, 223)
        Me.lbl_cot.Name = "lbl_cot"
        Me.lbl_cot.Size = New System.Drawing.Size(53, 20)
        Me.lbl_cot.TabIndex = 37
        Me.lbl_cot.Text = "..."
        '
        'lbl_st4_t1
        '
        Me.lbl_st4_t1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1.Location = New System.Drawing.Point(153, 175)
        Me.lbl_st4_t1.Name = "lbl_st4_t1"
        Me.lbl_st4_t1.Size = New System.Drawing.Size(53, 20)
        Me.lbl_st4_t1.TabIndex = 37
        Me.lbl_st4_t1.Text = "..."
        '
        'lbl_st3_res
        '
        Me.lbl_st3_res.BackColor = System.Drawing.Color.White
        Me.lbl_st3_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st3_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st3_res.Location = New System.Drawing.Point(153, 82)
        Me.lbl_st3_res.Name = "lbl_st3_res"
        Me.lbl_st3_res.Size = New System.Drawing.Size(53, 20)
        Me.lbl_st3_res.TabIndex = 37
        Me.lbl_st3_res.Text = "..."
        '
        'lbl_st4_p3
        '
        Me.lbl_st4_p3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3.Location = New System.Drawing.Point(153, 128)
        Me.lbl_st4_p3.Name = "lbl_st4_p3"
        Me.lbl_st4_p3.Size = New System.Drawing.Size(53, 20)
        Me.lbl_st4_p3.TabIndex = 37
        Me.lbl_st4_p3.Text = "..."
        '
        'lbl_status
        '
        Me.lbl_status.BackColor = System.Drawing.Color.White
        Me.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(153, 35)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(53, 20)
        Me.lbl_status.TabIndex = 37
        Me.lbl_status.Text = "..."
        '
        'GroupBox86
        '
        Me.GroupBox86.Controls.Add(Me.Label114)
        Me.GroupBox86.Controls.Add(Me.Label110)
        Me.GroupBox86.Controls.Add(Me.Label102)
        Me.GroupBox86.Controls.Add(Me.Label109)
        Me.GroupBox86.Controls.Add(Me.Label82)
        Me.GroupBox86.Controls.Add(Me.Label113)
        Me.GroupBox86.Controls.Add(Me.Label108)
        Me.GroupBox86.Controls.Add(Me.Label101)
        Me.GroupBox86.Controls.Add(Me.Label107)
        Me.GroupBox86.Controls.Add(Me.Label99)
        Me.GroupBox86.Controls.Add(Me.lbl_laser_template)
        Me.GroupBox86.Controls.Add(Me.lbl_unscrew_process)
        Me.GroupBox86.Controls.Add(Me.lbl_dif_str_tol)
        Me.GroupBox86.Controls.Add(Me.lbl_cfg_1st)
        Me.GroupBox86.Controls.Add(Me.lbl_act_val_tol)
        Me.GroupBox86.Controls.Add(Me.lbl_laser_datecode)
        Me.GroupBox86.Controls.Add(Me.lbl_cfg_2nd)
        Me.GroupBox86.Controls.Add(Me.lbl_dif_str)
        Me.GroupBox86.Controls.Add(Me.lbl_beating_times)
        Me.GroupBox86.Controls.Add(Me.lbl_act_val)
        Me.GroupBox86.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox86.Location = New System.Drawing.Point(308, 159)
        Me.GroupBox86.Name = "GroupBox86"
        Me.GroupBox86.Size = New System.Drawing.Size(215, 278)
        Me.GroupBox86.TabIndex = 53
        Me.GroupBox86.TabStop = False
        Me.GroupBox86.Text = "Product Database :"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(6, 249)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(110, 18)
        Me.Label114.TabIndex = 36
        Me.Label114.Text = "Laser Template"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(6, 201)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(146, 18)
        Me.Label110.TabIndex = 36
        Me.Label110.Text = "Unscrewing Process"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(6, 108)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(119, 18)
        Me.Label102.TabIndex = 36
        Me.Label102.Text = "Dif Str Tolerance"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(6, 154)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(131, 18)
        Me.Label109.TabIndex = 36
        Me.Label109.Text = "Config 1st Contact"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(6, 61)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(123, 18)
        Me.Label82.TabIndex = 36
        Me.Label82.Text = "Act Val Tolerance"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(6, 225)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(113, 18)
        Me.Label113.TabIndex = 36
        Me.Label113.Text = "Laser Datecode"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(6, 177)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(135, 18)
        Me.Label108.TabIndex = 36
        Me.Label108.Text = "Config 2nd Contact"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(6, 84)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(49, 18)
        Me.Label101.TabIndex = 36
        Me.Label101.Text = "Dif Str"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(6, 130)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(102, 18)
        Me.Label107.TabIndex = 36
        Me.Label107.Text = "Beating Times"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(6, 37)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(57, 18)
        Me.Label99.TabIndex = 36
        Me.Label99.Text = "Act Val "
        '
        'lbl_laser_template
        '
        Me.lbl_laser_template.BackColor = System.Drawing.Color.White
        Me.lbl_laser_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_laser_template.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_laser_template.Location = New System.Drawing.Point(153, 247)
        Me.lbl_laser_template.Name = "lbl_laser_template"
        Me.lbl_laser_template.Size = New System.Drawing.Size(53, 20)
        Me.lbl_laser_template.TabIndex = 37
        Me.lbl_laser_template.Text = "..."
        '
        'lbl_unscrew_process
        '
        Me.lbl_unscrew_process.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_process.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_process.Location = New System.Drawing.Point(153, 199)
        Me.lbl_unscrew_process.Name = "lbl_unscrew_process"
        Me.lbl_unscrew_process.Size = New System.Drawing.Size(53, 20)
        Me.lbl_unscrew_process.TabIndex = 37
        Me.lbl_unscrew_process.Text = "..."
        '
        'lbl_dif_str_tol
        '
        Me.lbl_dif_str_tol.BackColor = System.Drawing.Color.White
        Me.lbl_dif_str_tol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dif_str_tol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dif_str_tol.Location = New System.Drawing.Point(153, 106)
        Me.lbl_dif_str_tol.Name = "lbl_dif_str_tol"
        Me.lbl_dif_str_tol.Size = New System.Drawing.Size(53, 20)
        Me.lbl_dif_str_tol.TabIndex = 37
        Me.lbl_dif_str_tol.Text = "..."
        '
        'lbl_cfg_1st
        '
        Me.lbl_cfg_1st.BackColor = System.Drawing.Color.White
        Me.lbl_cfg_1st.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cfg_1st.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cfg_1st.Location = New System.Drawing.Point(153, 152)
        Me.lbl_cfg_1st.Name = "lbl_cfg_1st"
        Me.lbl_cfg_1st.Size = New System.Drawing.Size(53, 20)
        Me.lbl_cfg_1st.TabIndex = 37
        Me.lbl_cfg_1st.Text = "..."
        '
        'lbl_act_val_tol
        '
        Me.lbl_act_val_tol.BackColor = System.Drawing.Color.White
        Me.lbl_act_val_tol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_act_val_tol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_act_val_tol.Location = New System.Drawing.Point(153, 59)
        Me.lbl_act_val_tol.Name = "lbl_act_val_tol"
        Me.lbl_act_val_tol.Size = New System.Drawing.Size(53, 20)
        Me.lbl_act_val_tol.TabIndex = 37
        Me.lbl_act_val_tol.Text = "..."
        '
        'lbl_laser_datecode
        '
        Me.lbl_laser_datecode.BackColor = System.Drawing.Color.White
        Me.lbl_laser_datecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_laser_datecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_laser_datecode.Location = New System.Drawing.Point(153, 223)
        Me.lbl_laser_datecode.Name = "lbl_laser_datecode"
        Me.lbl_laser_datecode.Size = New System.Drawing.Size(53, 20)
        Me.lbl_laser_datecode.TabIndex = 37
        Me.lbl_laser_datecode.Text = "..."
        '
        'lbl_cfg_2nd
        '
        Me.lbl_cfg_2nd.BackColor = System.Drawing.Color.White
        Me.lbl_cfg_2nd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cfg_2nd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cfg_2nd.Location = New System.Drawing.Point(153, 175)
        Me.lbl_cfg_2nd.Name = "lbl_cfg_2nd"
        Me.lbl_cfg_2nd.Size = New System.Drawing.Size(53, 20)
        Me.lbl_cfg_2nd.TabIndex = 37
        Me.lbl_cfg_2nd.Text = "..."
        '
        'lbl_dif_str
        '
        Me.lbl_dif_str.BackColor = System.Drawing.Color.White
        Me.lbl_dif_str.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dif_str.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dif_str.Location = New System.Drawing.Point(153, 82)
        Me.lbl_dif_str.Name = "lbl_dif_str"
        Me.lbl_dif_str.Size = New System.Drawing.Size(53, 20)
        Me.lbl_dif_str.TabIndex = 37
        Me.lbl_dif_str.Text = "..."
        '
        'lbl_beating_times
        '
        Me.lbl_beating_times.BackColor = System.Drawing.Color.White
        Me.lbl_beating_times.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_beating_times.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_beating_times.Location = New System.Drawing.Point(153, 128)
        Me.lbl_beating_times.Name = "lbl_beating_times"
        Me.lbl_beating_times.Size = New System.Drawing.Size(53, 20)
        Me.lbl_beating_times.TabIndex = 37
        Me.lbl_beating_times.Text = "..."
        '
        'lbl_act_val
        '
        Me.lbl_act_val.BackColor = System.Drawing.Color.White
        Me.lbl_act_val.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_act_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_act_val.Location = New System.Drawing.Point(153, 35)
        Me.lbl_act_val.Name = "lbl_act_val"
        Me.lbl_act_val.Size = New System.Drawing.Size(53, 20)
        Me.lbl_act_val.TabIndex = 37
        Me.lbl_act_val.Text = "..."
        '
        'GroupBox77
        '
        Me.GroupBox77.Controls.Add(Me.ind_software_stop)
        Me.GroupBox77.Controls.Add(Me.Label67)
        Me.GroupBox77.Controls.Add(Me.ind_software_run)
        Me.GroupBox77.Controls.Add(Me.Label66)
        Me.GroupBox77.Controls.Add(Me.ind_software_open)
        Me.GroupBox77.Controls.Add(Me.Label65)
        Me.GroupBox77.Controls.Add(Me.btn_stop)
        Me.GroupBox77.Controls.Add(Me.btn_run)
        Me.GroupBox77.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox77.Location = New System.Drawing.Point(76, 297)
        Me.GroupBox77.Name = "GroupBox77"
        Me.GroupBox77.Size = New System.Drawing.Size(200, 140)
        Me.GroupBox77.TabIndex = 54
        Me.GroupBox77.TabStop = False
        Me.GroupBox77.Text = "PC Status"
        '
        'ind_software_stop
        '
        Me.ind_software_stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_software_stop.Location = New System.Drawing.Point(16, 72)
        Me.ind_software_stop.Name = "ind_software_stop"
        Me.ind_software_stop.Size = New System.Drawing.Size(15, 15)
        Me.ind_software_stop.TabIndex = 33
        Me.ind_software_stop.TabStop = False
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(37, 69)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(111, 20)
        Me.Label67.TabIndex = 31
        Me.Label67.Text = "Software Stop"
        '
        'ind_software_run
        '
        Me.ind_software_run.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_software_run.Location = New System.Drawing.Point(16, 51)
        Me.ind_software_run.Name = "ind_software_run"
        Me.ind_software_run.Size = New System.Drawing.Size(15, 15)
        Me.ind_software_run.TabIndex = 33
        Me.ind_software_run.TabStop = False
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(37, 48)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(114, 19)
        Me.Label66.TabIndex = 31
        Me.Label66.Text = "Software Run"
        '
        'ind_software_open
        '
        Me.ind_software_open.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_software_open.Location = New System.Drawing.Point(16, 30)
        Me.ind_software_open.Name = "ind_software_open"
        Me.ind_software_open.Size = New System.Drawing.Size(15, 15)
        Me.ind_software_open.TabIndex = 33
        Me.ind_software_open.TabStop = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(37, 27)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(116, 20)
        Me.Label65.TabIndex = 31
        Me.Label65.Text = "Software Open"
        '
        'btn_stop
        '
        Me.btn_stop.FlatAppearance.BorderSize = 0
        Me.btn_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stop.Location = New System.Drawing.Point(104, 95)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(84, 33)
        Me.btn_stop.TabIndex = 66
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_run
        '
        Me.btn_run.FlatAppearance.BorderSize = 0
        Me.btn_run.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_run.Location = New System.Drawing.Point(16, 95)
        Me.btn_run.Name = "btn_run"
        Me.btn_run.Size = New System.Drawing.Size(82, 33)
        Me.btn_run.TabIndex = 66
        Me.btn_run.Text = "Run "
        Me.btn_run.UseVisualStyleBackColor = True
        '
        'GroupBox80
        '
        Me.GroupBox80.Controls.Add(Me.Label85)
        Me.GroupBox80.Controls.Add(Me.lbl_po_num)
        Me.GroupBox80.Controls.Add(Me.Label83)
        Me.GroupBox80.Controls.Add(Me.lbl_ope_id)
        Me.GroupBox80.Controls.Add(Me.btn_clear)
        Me.GroupBox80.Controls.Add(Me.Label80)
        Me.GroupBox80.Controls.Add(Me.lbl_ref)
        Me.GroupBox80.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox80.Location = New System.Drawing.Point(76, 34)
        Me.GroupBox80.Name = "GroupBox80"
        Me.GroupBox80.Size = New System.Drawing.Size(200, 257)
        Me.GroupBox80.TabIndex = 55
        Me.GroupBox80.TabStop = False
        Me.GroupBox80.Text = "Product Information"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(6, 130)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(99, 20)
        Me.Label85.TabIndex = 31
        Me.Label85.Text = "PO Number :"
        '
        'lbl_po_num
        '
        Me.lbl_po_num.BackColor = System.Drawing.Color.White
        Me.lbl_po_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_po_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_po_num.Location = New System.Drawing.Point(10, 151)
        Me.lbl_po_num.Name = "lbl_po_num"
        Me.lbl_po_num.Size = New System.Drawing.Size(170, 25)
        Me.lbl_po_num.TabIndex = 31
        Me.lbl_po_num.Text = "..."
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(6, 78)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(101, 20)
        Me.Label83.TabIndex = 31
        Me.Label83.Text = "Operator ID :"
        '
        'lbl_ope_id
        '
        Me.lbl_ope_id.BackColor = System.Drawing.Color.White
        Me.lbl_ope_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ope_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ope_id.Location = New System.Drawing.Point(10, 99)
        Me.lbl_ope_id.Name = "lbl_ope_id"
        Me.lbl_ope_id.Size = New System.Drawing.Size(170, 25)
        Me.lbl_ope_id.TabIndex = 31
        Me.lbl_ope_id.Text = "..."
        '
        'btn_clear
        '
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Image = Global.TESTER.My.Resources.Resources.Clear
        Me.btn_clear.Location = New System.Drawing.Point(120, 179)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 60)
        Me.btn_clear.TabIndex = 69
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(6, 27)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(100, 20)
        Me.Label80.TabIndex = 31
        Me.Label80.Text = "References :"
        '
        'lbl_ref
        '
        Me.lbl_ref.BackColor = System.Drawing.Color.White
        Me.lbl_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ref.Location = New System.Drawing.Point(10, 48)
        Me.lbl_ref.Name = "lbl_ref"
        Me.lbl_ref.Size = New System.Drawing.Size(170, 25)
        Me.lbl_ref.TabIndex = 31
        Me.lbl_ref.Text = "..."
        '
        'GroupBox76
        '
        Me.GroupBox76.Controls.Add(Me.ind_plc_status)
        Me.GroupBox76.Controls.Add(Me.Label64)
        Me.GroupBox76.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox76.Location = New System.Drawing.Point(76, 441)
        Me.GroupBox76.Name = "GroupBox76"
        Me.GroupBox76.Size = New System.Drawing.Size(200, 61)
        Me.GroupBox76.TabIndex = 56
        Me.GroupBox76.TabStop = False
        Me.GroupBox76.Text = "PLC Status"
        '
        'ind_plc_status
        '
        Me.ind_plc_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_plc_status.Location = New System.Drawing.Point(16, 30)
        Me.ind_plc_status.Name = "ind_plc_status"
        Me.ind_plc_status.Size = New System.Drawing.Size(15, 15)
        Me.ind_plc_status.TabIndex = 33
        Me.ind_plc_status.TabStop = False
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(37, 27)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(89, 20)
        Me.Label64.TabIndex = 31
        Me.Label64.Text = "PLC Ready"
        '
        'lbl_cnt
        '
        Me.lbl_cnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 56.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnt.ForeColor = System.Drawing.Color.Black
        Me.lbl_cnt.Location = New System.Drawing.Point(553, 64)
        Me.lbl_cnt.Name = "lbl_cnt"
        Me.lbl_cnt.Size = New System.Drawing.Size(85, 85)
        Me.lbl_cnt.TabIndex = 48
        Me.lbl_cnt.Text = "0"
        Me.lbl_cnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_op_ins
        '
        Me.lbl_op_ins.BackColor = System.Drawing.Color.Silver
        Me.lbl_op_ins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_op_ins.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op_ins.ForeColor = System.Drawing.Color.Black
        Me.lbl_op_ins.Location = New System.Drawing.Point(308, 63)
        Me.lbl_op_ins.Name = "lbl_op_ins"
        Me.lbl_op_ins.Size = New System.Drawing.Size(216, 85)
        Me.lbl_op_ins.TabIndex = 49
        Me.lbl_op_ins.Text = "Please Scan Product References.."
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(305, 34)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(193, 24)
        Me.Label86.TabIndex = 50
        Me.Label86.Text = "Operator Instructions :"
        '
        'pnl_man_stn6
        '
        Me.pnl_man_stn6.Controls.Add(Me.TabPage4)
        Me.pnl_man_stn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn6.Location = New System.Drawing.Point(78, 97)
        Me.pnl_man_stn6.Name = "pnl_man_stn6"
        Me.pnl_man_stn6.SelectedIndex = 0
        Me.pnl_man_stn6.Size = New System.Drawing.Size(852, 558)
        Me.pnl_man_stn6.TabIndex = 96
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox88)
        Me.TabPage4.Controls.Add(Me.GroupBox73)
        Me.TabPage4.Controls.Add(Me.GroupBox67)
        Me.TabPage4.Controls.Add(Me.GroupBox64)
        Me.TabPage4.Controls.Add(Me.GroupBox61)
        Me.TabPage4.Controls.Add(Me.GroupBox70)
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(844, 516)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Station 6"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox88
        '
        Me.GroupBox88.AutoSize = True
        Me.GroupBox88.Controls.Add(Me.GroupBox89)
        Me.GroupBox88.Controls.Add(Me.GroupBox90)
        Me.GroupBox88.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox88.Location = New System.Drawing.Point(566, 270)
        Me.GroupBox88.Name = "GroupBox88"
        Me.GroupBox88.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox88.TabIndex = 39
        Me.GroupBox88.TabStop = False
        Me.GroupBox88.Text = "V606"
        Me.GroupBox88.Visible = False
        '
        'GroupBox89
        '
        Me.GroupBox89.Controls.Add(Me.Label97)
        Me.GroupBox89.Controls.Add(Me.Label100)
        Me.GroupBox89.Controls.Add(Me.stn6_cyl6_min)
        Me.GroupBox89.Controls.Add(Me.stn6_cyl6_max)
        Me.GroupBox89.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox89.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox89.Name = "GroupBox89"
        Me.GroupBox89.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox89.TabIndex = 3
        Me.GroupBox89.TabStop = False
        Me.GroupBox89.Text = "Sensor"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(6, 147)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(69, 18)
        Me.Label97.TabIndex = 1
        Me.Label97.Text = "Minimum"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(6, 72)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(73, 18)
        Me.Label100.TabIndex = 1
        Me.Label100.Text = "Maximum"
        '
        'stn6_cyl6_min
        '
        Me.stn6_cyl6_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl6_min.Location = New System.Drawing.Point(6, 106)
        Me.stn6_cyl6_min.Name = "stn6_cyl6_min"
        Me.stn6_cyl6_min.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl6_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl6_min.TabIndex = 0
        Me.stn6_cyl6_min.TabStop = False
        '
        'stn6_cyl6_max
        '
        Me.stn6_cyl6_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl6_max.Location = New System.Drawing.Point(6, 30)
        Me.stn6_cyl6_max.Name = "stn6_cyl6_max"
        Me.stn6_cyl6_max.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl6_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl6_max.TabIndex = 0
        Me.stn6_cyl6_max.TabStop = False
        '
        'GroupBox90
        '
        Me.GroupBox90.Controls.Add(Me.btn_stn6_cyl6_fw)
        Me.GroupBox90.Controls.Add(Me.btn_stn6_cyl6_bw)
        Me.GroupBox90.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox90.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox90.Name = "GroupBox90"
        Me.GroupBox90.Size = New System.Drawing.Size(88, 170)
        Me.GroupBox90.TabIndex = 3
        Me.GroupBox90.TabStop = False
        Me.GroupBox90.Text = "Button"
        '
        'btn_stn6_cyl6_fw
        '
        Me.btn_stn6_cyl6_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl6_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl6_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl6_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl6_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl6_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl6_fw.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_cyl6_fw.Name = "btn_stn6_cyl6_fw"
        Me.btn_stn6_cyl6_fw.Size = New System.Drawing.Size(102, 81)
        Me.btn_stn6_cyl6_fw.TabIndex = 2
        Me.btn_stn6_cyl6_fw.Text = "Forward"
        Me.btn_stn6_cyl6_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl6_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl6_fw.UseVisualStyleBackColor = False
        '
        'btn_stn6_cyl6_bw
        '
        Me.btn_stn6_cyl6_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl6_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl6_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl6_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl6_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl6_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl6_bw.Location = New System.Drawing.Point(-8, 95)
        Me.btn_stn6_cyl6_bw.Name = "btn_stn6_cyl6_bw"
        Me.btn_stn6_cyl6_bw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn6_cyl6_bw.TabIndex = 2
        Me.btn_stn6_cyl6_bw.Text = "Backward"
        Me.btn_stn6_cyl6_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl6_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl6_bw.UseVisualStyleBackColor = False
        '
        'GroupBox73
        '
        Me.GroupBox73.AutoSize = True
        Me.GroupBox73.Controls.Add(Me.GroupBox74)
        Me.GroupBox73.Controls.Add(Me.GroupBox75)
        Me.GroupBox73.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox73.Location = New System.Drawing.Point(315, 270)
        Me.GroupBox73.Name = "GroupBox73"
        Me.GroupBox73.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox73.TabIndex = 40
        Me.GroupBox73.TabStop = False
        Me.GroupBox73.Text = "V605"
        '
        'GroupBox74
        '
        Me.GroupBox74.Controls.Add(Me.Label61)
        Me.GroupBox74.Controls.Add(Me.Label62)
        Me.GroupBox74.Controls.Add(Me.stn6_cyl5_min)
        Me.GroupBox74.Controls.Add(Me.stn6_cyl5_max)
        Me.GroupBox74.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox74.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox74.Name = "GroupBox74"
        Me.GroupBox74.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox74.TabIndex = 3
        Me.GroupBox74.TabStop = False
        Me.GroupBox74.Text = "Sensor"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(6, 148)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(69, 18)
        Me.Label61.TabIndex = 1
        Me.Label61.Text = "Minimum"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(6, 72)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(73, 18)
        Me.Label62.TabIndex = 1
        Me.Label62.Text = "Maximum"
        '
        'stn6_cyl5_min
        '
        Me.stn6_cyl5_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl5_min.Location = New System.Drawing.Point(6, 106)
        Me.stn6_cyl5_min.Name = "stn6_cyl5_min"
        Me.stn6_cyl5_min.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl5_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl5_min.TabIndex = 0
        Me.stn6_cyl5_min.TabStop = False
        '
        'stn6_cyl5_max
        '
        Me.stn6_cyl5_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl5_max.Location = New System.Drawing.Point(6, 30)
        Me.stn6_cyl5_max.Name = "stn6_cyl5_max"
        Me.stn6_cyl5_max.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl5_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl5_max.TabIndex = 0
        Me.stn6_cyl5_max.TabStop = False
        '
        'GroupBox75
        '
        Me.GroupBox75.Controls.Add(Me.btn_stn6_cyl5_fw)
        Me.GroupBox75.Controls.Add(Me.btn_stn6_cyl5_bw)
        Me.GroupBox75.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox75.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox75.Name = "GroupBox75"
        Me.GroupBox75.Size = New System.Drawing.Size(88, 170)
        Me.GroupBox75.TabIndex = 3
        Me.GroupBox75.TabStop = False
        Me.GroupBox75.Text = "Button"
        '
        'btn_stn6_cyl5_fw
        '
        Me.btn_stn6_cyl5_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl5_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl5_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl5_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl5_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl5_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl5_fw.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_cyl5_fw.Name = "btn_stn6_cyl5_fw"
        Me.btn_stn6_cyl5_fw.Size = New System.Drawing.Size(102, 81)
        Me.btn_stn6_cyl5_fw.TabIndex = 2
        Me.btn_stn6_cyl5_fw.Text = "Forward"
        Me.btn_stn6_cyl5_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl5_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl5_fw.UseVisualStyleBackColor = False
        '
        'btn_stn6_cyl5_bw
        '
        Me.btn_stn6_cyl5_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl5_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl5_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl5_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl5_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl5_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl5_bw.Location = New System.Drawing.Point(-8, 95)
        Me.btn_stn6_cyl5_bw.Name = "btn_stn6_cyl5_bw"
        Me.btn_stn6_cyl5_bw.Size = New System.Drawing.Size(102, 77)
        Me.btn_stn6_cyl5_bw.TabIndex = 2
        Me.btn_stn6_cyl5_bw.Text = "Backward"
        Me.btn_stn6_cyl5_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl5_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl5_bw.UseVisualStyleBackColor = False
        '
        'GroupBox67
        '
        Me.GroupBox67.AutoSize = True
        Me.GroupBox67.Controls.Add(Me.GroupBox68)
        Me.GroupBox67.Controls.Add(Me.GroupBox69)
        Me.GroupBox67.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox67.Location = New System.Drawing.Point(64, 270)
        Me.GroupBox67.Name = "GroupBox67"
        Me.GroupBox67.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox67.TabIndex = 41
        Me.GroupBox67.TabStop = False
        Me.GroupBox67.Text = "V604"
        '
        'GroupBox68
        '
        Me.GroupBox68.Controls.Add(Me.Label56)
        Me.GroupBox68.Controls.Add(Me.Label57)
        Me.GroupBox68.Controls.Add(Me.stn6_cyl4_min)
        Me.GroupBox68.Controls.Add(Me.stn6_cyl4_max)
        Me.GroupBox68.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox68.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox68.Name = "GroupBox68"
        Me.GroupBox68.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox68.TabIndex = 3
        Me.GroupBox68.TabStop = False
        Me.GroupBox68.Text = "Sensor"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(6, 148)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(69, 18)
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "Minimum"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(6, 71)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(73, 18)
        Me.Label57.TabIndex = 1
        Me.Label57.Text = "Maximum"
        '
        'stn6_cyl4_min
        '
        Me.stn6_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl4_min.Location = New System.Drawing.Point(6, 106)
        Me.stn6_cyl4_min.Name = "stn6_cyl4_min"
        Me.stn6_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl4_min.TabIndex = 0
        Me.stn6_cyl4_min.TabStop = False
        '
        'stn6_cyl4_max
        '
        Me.stn6_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl4_max.Location = New System.Drawing.Point(6, 30)
        Me.stn6_cyl4_max.Name = "stn6_cyl4_max"
        Me.stn6_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl4_max.TabIndex = 0
        Me.stn6_cyl4_max.TabStop = False
        '
        'GroupBox69
        '
        Me.GroupBox69.Controls.Add(Me.btn_stn6_cyl4_fw)
        Me.GroupBox69.Controls.Add(Me.btn_stn6_cyl4_bw)
        Me.GroupBox69.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox69.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox69.Name = "GroupBox69"
        Me.GroupBox69.Size = New System.Drawing.Size(88, 170)
        Me.GroupBox69.TabIndex = 3
        Me.GroupBox69.TabStop = False
        Me.GroupBox69.Text = "Button"
        '
        'btn_stn6_cyl4_fw
        '
        Me.btn_stn6_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl4_fw.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_cyl4_fw.Name = "btn_stn6_cyl4_fw"
        Me.btn_stn6_cyl4_fw.Size = New System.Drawing.Size(102, 78)
        Me.btn_stn6_cyl4_fw.TabIndex = 2
        Me.btn_stn6_cyl4_fw.Text = "Forward"
        Me.btn_stn6_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl4_fw.UseVisualStyleBackColor = False
        '
        'btn_stn6_cyl4_bw
        '
        Me.btn_stn6_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl4_bw.Location = New System.Drawing.Point(-8, 95)
        Me.btn_stn6_cyl4_bw.Name = "btn_stn6_cyl4_bw"
        Me.btn_stn6_cyl4_bw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn6_cyl4_bw.TabIndex = 2
        Me.btn_stn6_cyl4_bw.Text = "Backward"
        Me.btn_stn6_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl4_bw.UseVisualStyleBackColor = False
        '
        'GroupBox64
        '
        Me.GroupBox64.AutoSize = True
        Me.GroupBox64.Controls.Add(Me.GroupBox65)
        Me.GroupBox64.Controls.Add(Me.GroupBox66)
        Me.GroupBox64.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox64.Location = New System.Drawing.Point(566, 26)
        Me.GroupBox64.Name = "GroupBox64"
        Me.GroupBox64.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox64.TabIndex = 42
        Me.GroupBox64.TabStop = False
        Me.GroupBox64.Text = "V603"
        '
        'GroupBox65
        '
        Me.GroupBox65.Controls.Add(Me.Label54)
        Me.GroupBox65.Controls.Add(Me.Label55)
        Me.GroupBox65.Controls.Add(Me.stn6_cyl3_min)
        Me.GroupBox65.Controls.Add(Me.stn6_cyl3_max)
        Me.GroupBox65.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox65.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox65.Name = "GroupBox65"
        Me.GroupBox65.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox65.TabIndex = 3
        Me.GroupBox65.TabStop = False
        Me.GroupBox65.Text = "Sensor"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(6, 148)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(69, 18)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Minimum"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(6, 73)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(73, 18)
        Me.Label55.TabIndex = 1
        Me.Label55.Text = "Maximum"
        '
        'stn6_cyl3_min
        '
        Me.stn6_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl3_min.Location = New System.Drawing.Point(6, 106)
        Me.stn6_cyl3_min.Name = "stn6_cyl3_min"
        Me.stn6_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl3_min.TabIndex = 0
        Me.stn6_cyl3_min.TabStop = False
        '
        'stn6_cyl3_max
        '
        Me.stn6_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl3_max.Location = New System.Drawing.Point(6, 30)
        Me.stn6_cyl3_max.Name = "stn6_cyl3_max"
        Me.stn6_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl3_max.TabIndex = 0
        Me.stn6_cyl3_max.TabStop = False
        '
        'GroupBox66
        '
        Me.GroupBox66.Controls.Add(Me.btn_stn6_cyl3_fw)
        Me.GroupBox66.Controls.Add(Me.btn_stn6_cyl3_bw)
        Me.GroupBox66.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox66.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox66.Name = "GroupBox66"
        Me.GroupBox66.Size = New System.Drawing.Size(88, 170)
        Me.GroupBox66.TabIndex = 3
        Me.GroupBox66.TabStop = False
        Me.GroupBox66.Text = "Button"
        '
        'btn_stn6_cyl3_fw
        '
        Me.btn_stn6_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl3_fw.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_cyl3_fw.Name = "btn_stn6_cyl3_fw"
        Me.btn_stn6_cyl3_fw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn6_cyl3_fw.TabIndex = 2
        Me.btn_stn6_cyl3_fw.Text = "Forward"
        Me.btn_stn6_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl3_fw.UseVisualStyleBackColor = False
        '
        'btn_stn6_cyl3_bw
        '
        Me.btn_stn6_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl3_bw.Location = New System.Drawing.Point(-8, 95)
        Me.btn_stn6_cyl3_bw.Name = "btn_stn6_cyl3_bw"
        Me.btn_stn6_cyl3_bw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn6_cyl3_bw.TabIndex = 2
        Me.btn_stn6_cyl3_bw.Text = "Backward"
        Me.btn_stn6_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl3_bw.UseVisualStyleBackColor = False
        '
        'GroupBox61
        '
        Me.GroupBox61.AutoSize = True
        Me.GroupBox61.Controls.Add(Me.GroupBox62)
        Me.GroupBox61.Controls.Add(Me.GroupBox63)
        Me.GroupBox61.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox61.Location = New System.Drawing.Point(315, 26)
        Me.GroupBox61.Name = "GroupBox61"
        Me.GroupBox61.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox61.TabIndex = 43
        Me.GroupBox61.TabStop = False
        Me.GroupBox61.Text = "V602"
        '
        'GroupBox62
        '
        Me.GroupBox62.Controls.Add(Me.Label52)
        Me.GroupBox62.Controls.Add(Me.Label53)
        Me.GroupBox62.Controls.Add(Me.stn6_cyl2_min)
        Me.GroupBox62.Controls.Add(Me.stn6_cyl2_max)
        Me.GroupBox62.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox62.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox62.Name = "GroupBox62"
        Me.GroupBox62.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox62.TabIndex = 3
        Me.GroupBox62.TabStop = False
        Me.GroupBox62.Text = "Sensor"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(6, 149)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(69, 18)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "Minimum"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(6, 72)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(73, 18)
        Me.Label53.TabIndex = 1
        Me.Label53.Text = "Maximum"
        '
        'stn6_cyl2_min
        '
        Me.stn6_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl2_min.Location = New System.Drawing.Point(6, 106)
        Me.stn6_cyl2_min.Name = "stn6_cyl2_min"
        Me.stn6_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl2_min.TabIndex = 0
        Me.stn6_cyl2_min.TabStop = False
        '
        'stn6_cyl2_max
        '
        Me.stn6_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl2_max.Location = New System.Drawing.Point(6, 30)
        Me.stn6_cyl2_max.Name = "stn6_cyl2_max"
        Me.stn6_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl2_max.TabIndex = 0
        Me.stn6_cyl2_max.TabStop = False
        '
        'GroupBox63
        '
        Me.GroupBox63.Controls.Add(Me.btn_stn6_cyl2_fw)
        Me.GroupBox63.Controls.Add(Me.btn_stn6_cyl2_bw)
        Me.GroupBox63.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox63.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox63.Name = "GroupBox63"
        Me.GroupBox63.Size = New System.Drawing.Size(88, 170)
        Me.GroupBox63.TabIndex = 3
        Me.GroupBox63.TabStop = False
        Me.GroupBox63.Text = "Button"
        '
        'btn_stn6_cyl2_fw
        '
        Me.btn_stn6_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl2_fw.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_cyl2_fw.Name = "btn_stn6_cyl2_fw"
        Me.btn_stn6_cyl2_fw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn6_cyl2_fw.TabIndex = 2
        Me.btn_stn6_cyl2_fw.Text = "Forward"
        Me.btn_stn6_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl2_fw.UseVisualStyleBackColor = False
        '
        'btn_stn6_cyl2_bw
        '
        Me.btn_stn6_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl2_bw.Location = New System.Drawing.Point(-8, 95)
        Me.btn_stn6_cyl2_bw.Name = "btn_stn6_cyl2_bw"
        Me.btn_stn6_cyl2_bw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn6_cyl2_bw.TabIndex = 2
        Me.btn_stn6_cyl2_bw.Text = "Backward"
        Me.btn_stn6_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl2_bw.UseVisualStyleBackColor = False
        '
        'GroupBox70
        '
        Me.GroupBox70.AutoSize = True
        Me.GroupBox70.Controls.Add(Me.GroupBox71)
        Me.GroupBox70.Controls.Add(Me.GroupBox72)
        Me.GroupBox70.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox70.Location = New System.Drawing.Point(64, 26)
        Me.GroupBox70.Name = "GroupBox70"
        Me.GroupBox70.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox70.TabIndex = 44
        Me.GroupBox70.TabStop = False
        Me.GroupBox70.Text = "V601"
        '
        'GroupBox71
        '
        Me.GroupBox71.Controls.Add(Me.Label58)
        Me.GroupBox71.Controls.Add(Me.Label59)
        Me.GroupBox71.Controls.Add(Me.stn6_cyl1_min)
        Me.GroupBox71.Controls.Add(Me.stn6_cyl1_max)
        Me.GroupBox71.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox71.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox71.Name = "GroupBox71"
        Me.GroupBox71.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox71.TabIndex = 3
        Me.GroupBox71.TabStop = False
        Me.GroupBox71.Text = "Sensor"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(6, 147)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(69, 18)
        Me.Label58.TabIndex = 1
        Me.Label58.Text = "Minimum"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(6, 72)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(73, 18)
        Me.Label59.TabIndex = 1
        Me.Label59.Text = "Maximum"
        '
        'stn6_cyl1_min
        '
        Me.stn6_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl1_min.Location = New System.Drawing.Point(6, 106)
        Me.stn6_cyl1_min.Name = "stn6_cyl1_min"
        Me.stn6_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl1_min.TabIndex = 0
        Me.stn6_cyl1_min.TabStop = False
        '
        'stn6_cyl1_max
        '
        Me.stn6_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_cyl1_max.Location = New System.Drawing.Point(6, 30)
        Me.stn6_cyl1_max.Name = "stn6_cyl1_max"
        Me.stn6_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.stn6_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_cyl1_max.TabIndex = 0
        Me.stn6_cyl1_max.TabStop = False
        '
        'GroupBox72
        '
        Me.GroupBox72.Controls.Add(Me.btn_stn6_cyl1_fw)
        Me.GroupBox72.Controls.Add(Me.btn_stn6_cyl1_bw)
        Me.GroupBox72.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox72.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox72.Name = "GroupBox72"
        Me.GroupBox72.Size = New System.Drawing.Size(88, 170)
        Me.GroupBox72.TabIndex = 3
        Me.GroupBox72.TabStop = False
        Me.GroupBox72.Text = "Button"
        '
        'btn_stn6_cyl1_fw
        '
        Me.btn_stn6_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl1_fw.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_cyl1_fw.Name = "btn_stn6_cyl1_fw"
        Me.btn_stn6_cyl1_fw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn6_cyl1_fw.TabIndex = 2
        Me.btn_stn6_cyl1_fw.Text = "Forward"
        Me.btn_stn6_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl1_fw.UseVisualStyleBackColor = False
        '
        'btn_stn6_cyl1_bw
        '
        Me.btn_stn6_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn6_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_cyl1_bw.Location = New System.Drawing.Point(-8, 95)
        Me.btn_stn6_cyl1_bw.Name = "btn_stn6_cyl1_bw"
        Me.btn_stn6_cyl1_bw.Size = New System.Drawing.Size(102, 74)
        Me.btn_stn6_cyl1_bw.TabIndex = 2
        Me.btn_stn6_cyl1_bw.Text = "Backward"
        Me.btn_stn6_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_cyl1_bw.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox49)
        Me.TabPage5.Controls.Add(Me.GroupBox52)
        Me.TabPage5.Controls.Add(Me.GroupBox55)
        Me.TabPage5.Controls.Add(Me.GroupBox58)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(845, 516)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Station 5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox58
        '
        Me.GroupBox58.AutoSize = True
        Me.GroupBox58.Controls.Add(Me.GroupBox59)
        Me.GroupBox58.Controls.Add(Me.GroupBox60)
        Me.GroupBox58.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox58.Location = New System.Drawing.Point(94, 28)
        Me.GroupBox58.Name = "GroupBox58"
        Me.GroupBox58.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox58.TabIndex = 37
        Me.GroupBox58.TabStop = False
        Me.GroupBox58.Text = "V501"
        '
        'GroupBox60
        '
        Me.GroupBox60.Controls.Add(Me.btn_stn5_cyl1_fw)
        Me.GroupBox60.Controls.Add(Me.btn_stn5_cyl1_bw)
        Me.GroupBox60.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox60.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox60.Name = "GroupBox60"
        Me.GroupBox60.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox60.TabIndex = 3
        Me.GroupBox60.TabStop = False
        Me.GroupBox60.Text = "Button"
        '
        'btn_stn5_cyl1_bw
        '
        Me.btn_stn5_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl1_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn5_cyl1_bw.Name = "btn_stn5_cyl1_bw"
        Me.btn_stn5_cyl1_bw.Size = New System.Drawing.Size(102, 86)
        Me.btn_stn5_cyl1_bw.TabIndex = 2
        Me.btn_stn5_cyl1_bw.Text = "Backward"
        Me.btn_stn5_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl1_bw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl1_fw
        '
        Me.btn_stn5_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl1_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn5_cyl1_fw.Name = "btn_stn5_cyl1_fw"
        Me.btn_stn5_cyl1_fw.Size = New System.Drawing.Size(102, 74)
        Me.btn_stn5_cyl1_fw.TabIndex = 2
        Me.btn_stn5_cyl1_fw.Text = "Forward"
        Me.btn_stn5_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl1_fw.UseVisualStyleBackColor = False
        '
        'GroupBox59
        '
        Me.GroupBox59.Controls.Add(Me.Label49)
        Me.GroupBox59.Controls.Add(Me.Label50)
        Me.GroupBox59.Controls.Add(Me.stn5_cyl1_min)
        Me.GroupBox59.Controls.Add(Me.stn5_cyl1_max)
        Me.GroupBox59.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox59.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox59.Name = "GroupBox59"
        Me.GroupBox59.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox59.TabIndex = 3
        Me.GroupBox59.TabStop = False
        Me.GroupBox59.Text = "Sensor"
        '
        'stn5_cyl1_max
        '
        Me.stn5_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl1_max.Name = "stn5_cyl1_max"
        Me.stn5_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl1_max.TabIndex = 0
        Me.stn5_cyl1_max.TabStop = False
        '
        'stn5_cyl1_min
        '
        Me.stn5_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl1_min.Name = "stn5_cyl1_min"
        Me.stn5_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl1_min.TabIndex = 0
        Me.stn5_cyl1_min.TabStop = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(23, 71)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(73, 18)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Maximum"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(23, 144)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 18)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Minimum"
        '
        'GroupBox55
        '
        Me.GroupBox55.AutoSize = True
        Me.GroupBox55.Controls.Add(Me.GroupBox56)
        Me.GroupBox55.Controls.Add(Me.GroupBox57)
        Me.GroupBox55.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox55.Location = New System.Drawing.Point(94, 270)
        Me.GroupBox55.Name = "GroupBox55"
        Me.GroupBox55.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox55.TabIndex = 36
        Me.GroupBox55.TabStop = False
        Me.GroupBox55.Text = "V503"
        '
        'GroupBox57
        '
        Me.GroupBox57.Controls.Add(Me.btn_stn5_cyl3_fw)
        Me.GroupBox57.Controls.Add(Me.btn_stn5_cyl3_bw)
        Me.GroupBox57.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox57.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox57.Name = "GroupBox57"
        Me.GroupBox57.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox57.TabIndex = 3
        Me.GroupBox57.TabStop = False
        Me.GroupBox57.Text = "Button"
        '
        'btn_stn5_cyl3_bw
        '
        Me.btn_stn5_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl3_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn5_cyl3_bw.Name = "btn_stn5_cyl3_bw"
        Me.btn_stn5_cyl3_bw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn5_cyl3_bw.TabIndex = 2
        Me.btn_stn5_cyl3_bw.Text = "Backward"
        Me.btn_stn5_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl3_bw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl3_fw
        '
        Me.btn_stn5_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl3_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn5_cyl3_fw.Name = "btn_stn5_cyl3_fw"
        Me.btn_stn5_cyl3_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_cyl3_fw.TabIndex = 2
        Me.btn_stn5_cyl3_fw.Text = "Forward"
        Me.btn_stn5_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl3_fw.UseVisualStyleBackColor = False
        '
        'GroupBox56
        '
        Me.GroupBox56.Controls.Add(Me.Label47)
        Me.GroupBox56.Controls.Add(Me.Label48)
        Me.GroupBox56.Controls.Add(Me.stn5_cyl3_min)
        Me.GroupBox56.Controls.Add(Me.stn5_cyl3_max)
        Me.GroupBox56.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox56.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox56.Name = "GroupBox56"
        Me.GroupBox56.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox56.TabIndex = 3
        Me.GroupBox56.TabStop = False
        Me.GroupBox56.Text = "Sensor"
        '
        'stn5_cyl3_max
        '
        Me.stn5_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl3_max.Name = "stn5_cyl3_max"
        Me.stn5_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl3_max.TabIndex = 0
        Me.stn5_cyl3_max.TabStop = False
        '
        'stn5_cyl3_min
        '
        Me.stn5_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl3_min.Name = "stn5_cyl3_min"
        Me.stn5_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl3_min.TabIndex = 0
        Me.stn5_cyl3_min.TabStop = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(19, 71)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(73, 18)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "Maximum"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(20, 149)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(69, 18)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Minimum"
        '
        'GroupBox52
        '
        Me.GroupBox52.AutoSize = True
        Me.GroupBox52.Controls.Add(Me.GroupBox53)
        Me.GroupBox52.Controls.Add(Me.GroupBox54)
        Me.GroupBox52.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox52.Location = New System.Drawing.Point(459, 28)
        Me.GroupBox52.Name = "GroupBox52"
        Me.GroupBox52.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox52.TabIndex = 35
        Me.GroupBox52.TabStop = False
        Me.GroupBox52.Text = "V502"
        '
        'GroupBox54
        '
        Me.GroupBox54.Controls.Add(Me.btn_stn5_cyl2_fw)
        Me.GroupBox54.Controls.Add(Me.btn_stn5_cyl2_bw)
        Me.GroupBox54.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox54.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox54.Name = "GroupBox54"
        Me.GroupBox54.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox54.TabIndex = 3
        Me.GroupBox54.TabStop = False
        Me.GroupBox54.Text = "Button"
        '
        'btn_stn5_cyl2_bw
        '
        Me.btn_stn5_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl2_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn5_cyl2_bw.Name = "btn_stn5_cyl2_bw"
        Me.btn_stn5_cyl2_bw.Size = New System.Drawing.Size(102, 86)
        Me.btn_stn5_cyl2_bw.TabIndex = 2
        Me.btn_stn5_cyl2_bw.Text = "Backward"
        Me.btn_stn5_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl2_bw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl2_fw
        '
        Me.btn_stn5_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl2_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn5_cyl2_fw.Name = "btn_stn5_cyl2_fw"
        Me.btn_stn5_cyl2_fw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn5_cyl2_fw.TabIndex = 2
        Me.btn_stn5_cyl2_fw.Text = "Forward"
        Me.btn_stn5_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl2_fw.UseVisualStyleBackColor = False
        '
        'GroupBox53
        '
        Me.GroupBox53.Controls.Add(Me.Label45)
        Me.GroupBox53.Controls.Add(Me.Label46)
        Me.GroupBox53.Controls.Add(Me.stn5_cyl2_min)
        Me.GroupBox53.Controls.Add(Me.stn5_cyl2_max)
        Me.GroupBox53.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox53.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox53.Name = "GroupBox53"
        Me.GroupBox53.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox53.TabIndex = 3
        Me.GroupBox53.TabStop = False
        Me.GroupBox53.Text = "Sensor"
        '
        'stn5_cyl2_max
        '
        Me.stn5_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl2_max.Name = "stn5_cyl2_max"
        Me.stn5_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl2_max.TabIndex = 0
        Me.stn5_cyl2_max.TabStop = False
        '
        'stn5_cyl2_min
        '
        Me.stn5_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl2_min.Name = "stn5_cyl2_min"
        Me.stn5_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl2_min.TabIndex = 0
        Me.stn5_cyl2_min.TabStop = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(24, 70)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(73, 18)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "Maximum"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(24, 147)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(69, 18)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Minimum"
        '
        'GroupBox49
        '
        Me.GroupBox49.AutoSize = True
        Me.GroupBox49.Controls.Add(Me.GroupBox50)
        Me.GroupBox49.Controls.Add(Me.GroupBox51)
        Me.GroupBox49.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox49.Location = New System.Drawing.Point(459, 270)
        Me.GroupBox49.Name = "GroupBox49"
        Me.GroupBox49.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox49.TabIndex = 34
        Me.GroupBox49.TabStop = False
        Me.GroupBox49.Text = "V504"
        '
        'GroupBox51
        '
        Me.GroupBox51.Controls.Add(Me.btn_stn5_cyl4_fw)
        Me.GroupBox51.Controls.Add(Me.btn_stn5_cyl4_bw)
        Me.GroupBox51.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox51.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox51.Name = "GroupBox51"
        Me.GroupBox51.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox51.TabIndex = 3
        Me.GroupBox51.TabStop = False
        Me.GroupBox51.Text = "Button"
        '
        'btn_stn5_cyl4_bw
        '
        Me.btn_stn5_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl4_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn5_cyl4_bw.Name = "btn_stn5_cyl4_bw"
        Me.btn_stn5_cyl4_bw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_cyl4_bw.TabIndex = 2
        Me.btn_stn5_cyl4_bw.Text = "Backward"
        Me.btn_stn5_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl4_bw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl4_fw
        '
        Me.btn_stn5_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl4_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn5_cyl4_fw.Name = "btn_stn5_cyl4_fw"
        Me.btn_stn5_cyl4_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_cyl4_fw.TabIndex = 2
        Me.btn_stn5_cyl4_fw.Text = "Forward"
        Me.btn_stn5_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl4_fw.UseVisualStyleBackColor = False
        '
        'GroupBox50
        '
        Me.GroupBox50.Controls.Add(Me.Label43)
        Me.GroupBox50.Controls.Add(Me.Label44)
        Me.GroupBox50.Controls.Add(Me.stn5_cyl4_min)
        Me.GroupBox50.Controls.Add(Me.stn5_cyl4_max)
        Me.GroupBox50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox50.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox50.Name = "GroupBox50"
        Me.GroupBox50.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox50.TabIndex = 3
        Me.GroupBox50.TabStop = False
        Me.GroupBox50.Text = "Sensor"
        '
        'stn5_cyl4_max
        '
        Me.stn5_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl4_max.Name = "stn5_cyl4_max"
        Me.stn5_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl4_max.TabIndex = 0
        Me.stn5_cyl4_max.TabStop = False
        '
        'stn5_cyl4_min
        '
        Me.stn5_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl4_min.Name = "stn5_cyl4_min"
        Me.stn5_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.stn5_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl4_min.TabIndex = 0
        Me.stn5_cyl4_min.TabStop = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(20, 73)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(73, 18)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Maximum"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(20, 147)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(69, 18)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "Minimum"
        '
        'pnl_man_stn5
        '
        Me.pnl_man_stn5.Controls.Add(Me.TabPage5)
        Me.pnl_man_stn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn5.Location = New System.Drawing.Point(78, 97)
        Me.pnl_man_stn5.Name = "pnl_man_stn5"
        Me.pnl_man_stn5.SelectedIndex = 0
        Me.pnl_man_stn5.Size = New System.Drawing.Size(853, 558)
        Me.pnl_man_stn5.TabIndex = 97
        '
        'pnl_man_stn4
        '
        Me.pnl_man_stn4.Controls.Add(Me.TabPage6)
        Me.pnl_man_stn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn4.Location = New System.Drawing.Point(78, 97)
        Me.pnl_man_stn4.Name = "pnl_man_stn4"
        Me.pnl_man_stn4.SelectedIndex = 0
        Me.pnl_man_stn4.Size = New System.Drawing.Size(853, 563)
        Me.pnl_man_stn4.TabIndex = 98
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox37)
        Me.TabPage6.Controls.Add(Me.GroupBox43)
        Me.TabPage6.Controls.Add(Me.GroupBox46)
        Me.TabPage6.Controls.Add(Me.GroupBox40)
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(845, 521)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Station 4"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox37
        '
        Me.GroupBox37.AutoSize = True
        Me.GroupBox37.Controls.Add(Me.GroupBox38)
        Me.GroupBox37.Controls.Add(Me.GroupBox39)
        Me.GroupBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox37.Location = New System.Drawing.Point(459, 270)
        Me.GroupBox37.Name = "GroupBox37"
        Me.GroupBox37.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox37.TabIndex = 34
        Me.GroupBox37.TabStop = False
        Me.GroupBox37.Text = "V404"
        Me.GroupBox37.Visible = False
        '
        'GroupBox38
        '
        Me.GroupBox38.Controls.Add(Me.Label34)
        Me.GroupBox38.Controls.Add(Me.Label35)
        Me.GroupBox38.Controls.Add(Me.stn4_cyl4_min)
        Me.GroupBox38.Controls.Add(Me.stn4_cyl4_max)
        Me.GroupBox38.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox38.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox38.TabIndex = 3
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "Sensor"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(20, 146)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(69, 18)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Minimum"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(20, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 18)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Maximum"
        '
        'stn4_cyl4_min
        '
        Me.stn4_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.stn4_cyl4_min.Name = "stn4_cyl4_min"
        Me.stn4_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl4_min.TabIndex = 0
        Me.stn4_cyl4_min.TabStop = False
        '
        'stn4_cyl4_max
        '
        Me.stn4_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.stn4_cyl4_max.Name = "stn4_cyl4_max"
        Me.stn4_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl4_max.TabIndex = 0
        Me.stn4_cyl4_max.TabStop = False
        '
        'GroupBox39
        '
        Me.GroupBox39.Controls.Add(Me.btn_stn4_cyl4_fw)
        Me.GroupBox39.Controls.Add(Me.btn_stn4_cyl4_bw)
        Me.GroupBox39.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox39.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox39.Name = "GroupBox39"
        Me.GroupBox39.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox39.TabIndex = 3
        Me.GroupBox39.TabStop = False
        Me.GroupBox39.Text = "Button"
        '
        'btn_stn4_cyl4_fw
        '
        Me.btn_stn4_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl4_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn4_cyl4_fw.Name = "btn_stn4_cyl4_fw"
        Me.btn_stn4_cyl4_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn4_cyl4_fw.TabIndex = 2
        Me.btn_stn4_cyl4_fw.Text = "Forward"
        Me.btn_stn4_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl4_fw.UseVisualStyleBackColor = False
        '
        'btn_stn4_cyl4_bw
        '
        Me.btn_stn4_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl4_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn4_cyl4_bw.Name = "btn_stn4_cyl4_bw"
        Me.btn_stn4_cyl4_bw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn4_cyl4_bw.TabIndex = 2
        Me.btn_stn4_cyl4_bw.Text = "Backward"
        Me.btn_stn4_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl4_bw.UseVisualStyleBackColor = False
        '
        'GroupBox43
        '
        Me.GroupBox43.AutoSize = True
        Me.GroupBox43.Controls.Add(Me.GroupBox44)
        Me.GroupBox43.Controls.Add(Me.GroupBox45)
        Me.GroupBox43.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox43.Location = New System.Drawing.Point(94, 270)
        Me.GroupBox43.Name = "GroupBox43"
        Me.GroupBox43.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox43.TabIndex = 36
        Me.GroupBox43.TabStop = False
        Me.GroupBox43.Text = "V403"
        Me.GroupBox43.Visible = False
        '
        'GroupBox44
        '
        Me.GroupBox44.Controls.Add(Me.Label38)
        Me.GroupBox44.Controls.Add(Me.Label39)
        Me.GroupBox44.Controls.Add(Me.stn4_cyl3_min)
        Me.GroupBox44.Controls.Add(Me.stn4_cyl3_max)
        Me.GroupBox44.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox44.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox44.Name = "GroupBox44"
        Me.GroupBox44.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox44.TabIndex = 3
        Me.GroupBox44.TabStop = False
        Me.GroupBox44.Text = "Sensor"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(20, 146)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(69, 18)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Minimum"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(20, 70)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(73, 18)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Maximum"
        '
        'stn4_cyl3_min
        '
        Me.stn4_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.stn4_cyl3_min.Name = "stn4_cyl3_min"
        Me.stn4_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl3_min.TabIndex = 0
        Me.stn4_cyl3_min.TabStop = False
        '
        'stn4_cyl3_max
        '
        Me.stn4_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.stn4_cyl3_max.Name = "stn4_cyl3_max"
        Me.stn4_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl3_max.TabIndex = 0
        Me.stn4_cyl3_max.TabStop = False
        '
        'GroupBox45
        '
        Me.GroupBox45.Controls.Add(Me.btn_stn4_cyl3_fw)
        Me.GroupBox45.Controls.Add(Me.btn_stn4_cyl3_bw)
        Me.GroupBox45.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox45.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox45.Name = "GroupBox45"
        Me.GroupBox45.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox45.TabIndex = 3
        Me.GroupBox45.TabStop = False
        Me.GroupBox45.Text = "Button"
        '
        'btn_stn4_cyl3_fw
        '
        Me.btn_stn4_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl3_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn4_cyl3_fw.Name = "btn_stn4_cyl3_fw"
        Me.btn_stn4_cyl3_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn4_cyl3_fw.TabIndex = 2
        Me.btn_stn4_cyl3_fw.Text = "Forward"
        Me.btn_stn4_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl3_fw.UseVisualStyleBackColor = False
        '
        'btn_stn4_cyl3_bw
        '
        Me.btn_stn4_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl3_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn4_cyl3_bw.Name = "btn_stn4_cyl3_bw"
        Me.btn_stn4_cyl3_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn4_cyl3_bw.TabIndex = 2
        Me.btn_stn4_cyl3_bw.Text = "Backward"
        Me.btn_stn4_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl3_bw.UseVisualStyleBackColor = False
        '
        'GroupBox46
        '
        Me.GroupBox46.AutoSize = True
        Me.GroupBox46.Controls.Add(Me.GroupBox47)
        Me.GroupBox46.Controls.Add(Me.GroupBox48)
        Me.GroupBox46.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox46.Location = New System.Drawing.Point(94, 28)
        Me.GroupBox46.Name = "GroupBox46"
        Me.GroupBox46.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox46.TabIndex = 37
        Me.GroupBox46.TabStop = False
        Me.GroupBox46.Text = "V401"
        '
        'GroupBox47
        '
        Me.GroupBox47.Controls.Add(Me.Label40)
        Me.GroupBox47.Controls.Add(Me.Label41)
        Me.GroupBox47.Controls.Add(Me.stn4_cyl1_min)
        Me.GroupBox47.Controls.Add(Me.stn4_cyl1_max)
        Me.GroupBox47.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox47.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox47.Name = "GroupBox47"
        Me.GroupBox47.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox47.TabIndex = 3
        Me.GroupBox47.TabStop = False
        Me.GroupBox47.Text = "Sensor"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(20, 146)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(69, 18)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "Minimum"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(20, 70)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(73, 18)
        Me.Label41.TabIndex = 1
        Me.Label41.Text = "Maximum"
        '
        'stn4_cyl1_min
        '
        Me.stn4_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.stn4_cyl1_min.Name = "stn4_cyl1_min"
        Me.stn4_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl1_min.TabIndex = 0
        Me.stn4_cyl1_min.TabStop = False
        '
        'stn4_cyl1_max
        '
        Me.stn4_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.stn4_cyl1_max.Name = "stn4_cyl1_max"
        Me.stn4_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl1_max.TabIndex = 0
        Me.stn4_cyl1_max.TabStop = False
        '
        'GroupBox48
        '
        Me.GroupBox48.Controls.Add(Me.btn_stn4_cyl1_fw)
        Me.GroupBox48.Controls.Add(Me.btn_stn4_cyl1_bw)
        Me.GroupBox48.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox48.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox48.Name = "GroupBox48"
        Me.GroupBox48.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox48.TabIndex = 3
        Me.GroupBox48.TabStop = False
        Me.GroupBox48.Text = "Button"
        '
        'btn_stn4_cyl1_fw
        '
        Me.btn_stn4_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl1_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn4_cyl1_fw.Name = "btn_stn4_cyl1_fw"
        Me.btn_stn4_cyl1_fw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn4_cyl1_fw.TabIndex = 2
        Me.btn_stn4_cyl1_fw.Text = "Forward"
        Me.btn_stn4_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl1_fw.UseVisualStyleBackColor = False
        '
        'btn_stn4_cyl1_bw
        '
        Me.btn_stn4_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl1_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn4_cyl1_bw.Name = "btn_stn4_cyl1_bw"
        Me.btn_stn4_cyl1_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn4_cyl1_bw.TabIndex = 2
        Me.btn_stn4_cyl1_bw.Text = "Backward"
        Me.btn_stn4_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl1_bw.UseVisualStyleBackColor = False
        '
        'GroupBox40
        '
        Me.GroupBox40.AutoSize = True
        Me.GroupBox40.Controls.Add(Me.GroupBox41)
        Me.GroupBox40.Controls.Add(Me.GroupBox42)
        Me.GroupBox40.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox40.Location = New System.Drawing.Point(459, 28)
        Me.GroupBox40.Name = "GroupBox40"
        Me.GroupBox40.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox40.TabIndex = 35
        Me.GroupBox40.TabStop = False
        Me.GroupBox40.Text = "V402"
        '
        'GroupBox41
        '
        Me.GroupBox41.Controls.Add(Me.Label36)
        Me.GroupBox41.Controls.Add(Me.Label37)
        Me.GroupBox41.Controls.Add(Me.stn4_cyl2_min)
        Me.GroupBox41.Controls.Add(Me.stn4_cyl2_max)
        Me.GroupBox41.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox41.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox41.Name = "GroupBox41"
        Me.GroupBox41.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox41.TabIndex = 3
        Me.GroupBox41.TabStop = False
        Me.GroupBox41.Text = "Sensor"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(20, 147)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(69, 18)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Minimum"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(20, 70)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(73, 18)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "Maximum"
        '
        'stn4_cyl2_min
        '
        Me.stn4_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.stn4_cyl2_min.Name = "stn4_cyl2_min"
        Me.stn4_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl2_min.TabIndex = 0
        Me.stn4_cyl2_min.TabStop = False
        '
        'stn4_cyl2_max
        '
        Me.stn4_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn4_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.stn4_cyl2_max.Name = "stn4_cyl2_max"
        Me.stn4_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.stn4_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn4_cyl2_max.TabIndex = 0
        Me.stn4_cyl2_max.TabStop = False
        '
        'GroupBox42
        '
        Me.GroupBox42.Controls.Add(Me.btn_stn4_cyl2_fw)
        Me.GroupBox42.Controls.Add(Me.btn_stn4_cyl2_bw)
        Me.GroupBox42.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox42.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox42.Name = "GroupBox42"
        Me.GroupBox42.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox42.TabIndex = 3
        Me.GroupBox42.TabStop = False
        Me.GroupBox42.Text = "Button"
        '
        'btn_stn4_cyl2_fw
        '
        Me.btn_stn4_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl2_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn4_cyl2_fw.Name = "btn_stn4_cyl2_fw"
        Me.btn_stn4_cyl2_fw.Size = New System.Drawing.Size(102, 77)
        Me.btn_stn4_cyl2_fw.TabIndex = 2
        Me.btn_stn4_cyl2_fw.Text = "Forward"
        Me.btn_stn4_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl2_fw.UseVisualStyleBackColor = False
        '
        'btn_stn4_cyl2_bw
        '
        Me.btn_stn4_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn4_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn4_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn4_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn4_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn4_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn4_cyl2_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn4_cyl2_bw.Name = "btn_stn4_cyl2_bw"
        Me.btn_stn4_cyl2_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn4_cyl2_bw.TabIndex = 2
        Me.btn_stn4_cyl2_bw.Text = "Backward"
        Me.btn_stn4_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn4_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn4_cyl2_bw.UseVisualStyleBackColor = False
        '
        'pnl_man_stn3
        '
        Me.pnl_man_stn3.Controls.Add(Me.TabPage7)
        Me.pnl_man_stn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn3.Location = New System.Drawing.Point(78, 97)
        Me.pnl_man_stn3.Name = "pnl_man_stn3"
        Me.pnl_man_stn3.SelectedIndex = 0
        Me.pnl_man_stn3.Size = New System.Drawing.Size(853, 563)
        Me.pnl_man_stn3.TabIndex = 99
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox25)
        Me.TabPage7.Controls.Add(Me.GroupBox28)
        Me.TabPage7.Controls.Add(Me.GroupBox31)
        Me.TabPage7.Controls.Add(Me.GroupBox34)
        Me.TabPage7.Location = New System.Drawing.Point(4, 38)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(845, 521)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Station 3"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox25
        '
        Me.GroupBox25.AutoSize = True
        Me.GroupBox25.Controls.Add(Me.GroupBox26)
        Me.GroupBox25.Controls.Add(Me.GroupBox27)
        Me.GroupBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox25.Location = New System.Drawing.Point(459, 270)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox25.TabIndex = 39
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "V304"
        Me.GroupBox25.Visible = False
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.Label25)
        Me.GroupBox26.Controls.Add(Me.Label26)
        Me.GroupBox26.Controls.Add(Me.stn3_cyl4_min)
        Me.GroupBox26.Controls.Add(Me.stn3_cyl4_max)
        Me.GroupBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox26.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox26.TabIndex = 3
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Sensor"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(20, 146)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 18)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Minimum"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(20, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 18)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Maximum"
        '
        'stn3_cyl4_min
        '
        Me.stn3_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.stn3_cyl4_min.Name = "stn3_cyl4_min"
        Me.stn3_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl4_min.TabIndex = 0
        Me.stn3_cyl4_min.TabStop = False
        '
        'stn3_cyl4_max
        '
        Me.stn3_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.stn3_cyl4_max.Name = "stn3_cyl4_max"
        Me.stn3_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl4_max.TabIndex = 0
        Me.stn3_cyl4_max.TabStop = False
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.btn_stn3_cyl4_fw)
        Me.GroupBox27.Controls.Add(Me.btn_stn3_cyl4_bw)
        Me.GroupBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox27.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox27.TabIndex = 3
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Button"
        '
        'btn_stn3_cyl4_fw
        '
        Me.btn_stn3_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl4_fw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl4_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn3_cyl4_fw.Name = "btn_stn3_cyl4_fw"
        Me.btn_stn3_cyl4_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn3_cyl4_fw.TabIndex = 2
        Me.btn_stn3_cyl4_fw.Text = "Forward"
        Me.btn_stn3_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl4_fw.UseVisualStyleBackColor = False
        '
        'btn_stn3_cyl4_bw
        '
        Me.btn_stn3_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl4_bw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl4_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn3_cyl4_bw.Name = "btn_stn3_cyl4_bw"
        Me.btn_stn3_cyl4_bw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn3_cyl4_bw.TabIndex = 2
        Me.btn_stn3_cyl4_bw.Text = "Backward"
        Me.btn_stn3_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl4_bw.UseVisualStyleBackColor = False
        '
        'GroupBox28
        '
        Me.GroupBox28.AutoSize = True
        Me.GroupBox28.Controls.Add(Me.GroupBox29)
        Me.GroupBox28.Controls.Add(Me.GroupBox30)
        Me.GroupBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox28.Location = New System.Drawing.Point(459, 28)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox28.TabIndex = 40
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "V302"
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.Label27)
        Me.GroupBox29.Controls.Add(Me.Label28)
        Me.GroupBox29.Controls.Add(Me.stn3_cyl2_min)
        Me.GroupBox29.Controls.Add(Me.stn3_cyl2_max)
        Me.GroupBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox29.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox29.TabIndex = 3
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Sensor"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(20, 146)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 18)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Minimum"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(20, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 18)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Maximum"
        '
        'stn3_cyl2_min
        '
        Me.stn3_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.stn3_cyl2_min.Name = "stn3_cyl2_min"
        Me.stn3_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl2_min.TabIndex = 0
        Me.stn3_cyl2_min.TabStop = False
        '
        'stn3_cyl2_max
        '
        Me.stn3_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.stn3_cyl2_max.Name = "stn3_cyl2_max"
        Me.stn3_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl2_max.TabIndex = 0
        Me.stn3_cyl2_max.TabStop = False
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.btn_stn3_cyl2_fw)
        Me.GroupBox30.Controls.Add(Me.btn_stn3_cyl2_bw)
        Me.GroupBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox30.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox30.TabIndex = 3
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Button"
        '
        'btn_stn3_cyl2_fw
        '
        Me.btn_stn3_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl2_fw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl2_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn3_cyl2_fw.Name = "btn_stn3_cyl2_fw"
        Me.btn_stn3_cyl2_fw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn3_cyl2_fw.TabIndex = 2
        Me.btn_stn3_cyl2_fw.Text = "Forward"
        Me.btn_stn3_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl2_fw.UseVisualStyleBackColor = False
        '
        'btn_stn3_cyl2_bw
        '
        Me.btn_stn3_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl2_bw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl2_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn3_cyl2_bw.Name = "btn_stn3_cyl2_bw"
        Me.btn_stn3_cyl2_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn3_cyl2_bw.TabIndex = 2
        Me.btn_stn3_cyl2_bw.Text = "Backward"
        Me.btn_stn3_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl2_bw.UseVisualStyleBackColor = False
        '
        'GroupBox31
        '
        Me.GroupBox31.AutoSize = True
        Me.GroupBox31.Controls.Add(Me.GroupBox32)
        Me.GroupBox31.Controls.Add(Me.GroupBox33)
        Me.GroupBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox31.Location = New System.Drawing.Point(94, 270)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox31.TabIndex = 41
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "V303"
        Me.GroupBox31.Visible = False
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.Label29)
        Me.GroupBox32.Controls.Add(Me.Label30)
        Me.GroupBox32.Controls.Add(Me.stn3_cyl3_min)
        Me.GroupBox32.Controls.Add(Me.stn3_cyl3_max)
        Me.GroupBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox32.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox32.TabIndex = 3
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "Sensor"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(20, 146)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 18)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Minimum"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(20, 70)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 18)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Maximum"
        '
        'stn3_cyl3_min
        '
        Me.stn3_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.stn3_cyl3_min.Name = "stn3_cyl3_min"
        Me.stn3_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl3_min.TabIndex = 0
        Me.stn3_cyl3_min.TabStop = False
        '
        'stn3_cyl3_max
        '
        Me.stn3_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.stn3_cyl3_max.Name = "stn3_cyl3_max"
        Me.stn3_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl3_max.TabIndex = 0
        Me.stn3_cyl3_max.TabStop = False
        '
        'GroupBox33
        '
        Me.GroupBox33.Controls.Add(Me.btn_stn3_cyl3_fw)
        Me.GroupBox33.Controls.Add(Me.btn_stn3_cyl3_bw)
        Me.GroupBox33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox33.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox33.TabIndex = 3
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "Button"
        '
        'btn_stn3_cyl3_fw
        '
        Me.btn_stn3_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl3_fw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl3_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn3_cyl3_fw.Name = "btn_stn3_cyl3_fw"
        Me.btn_stn3_cyl3_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn3_cyl3_fw.TabIndex = 2
        Me.btn_stn3_cyl3_fw.Text = "Forward"
        Me.btn_stn3_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl3_fw.UseVisualStyleBackColor = False
        '
        'btn_stn3_cyl3_bw
        '
        Me.btn_stn3_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl3_bw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl3_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn3_cyl3_bw.Name = "btn_stn3_cyl3_bw"
        Me.btn_stn3_cyl3_bw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn3_cyl3_bw.TabIndex = 2
        Me.btn_stn3_cyl3_bw.Text = "Backward"
        Me.btn_stn3_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl3_bw.UseVisualStyleBackColor = False
        '
        'GroupBox34
        '
        Me.GroupBox34.AutoSize = True
        Me.GroupBox34.Controls.Add(Me.GroupBox35)
        Me.GroupBox34.Controls.Add(Me.GroupBox36)
        Me.GroupBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox34.Location = New System.Drawing.Point(94, 28)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox34.TabIndex = 42
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "V301"
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.Label31)
        Me.GroupBox35.Controls.Add(Me.Label32)
        Me.GroupBox35.Controls.Add(Me.stn3_cyl1_min)
        Me.GroupBox35.Controls.Add(Me.stn3_cyl1_max)
        Me.GroupBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox35.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox35.TabIndex = 3
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "Sensor"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(20, 146)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(69, 18)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Minimum"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(20, 70)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 18)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Maximum"
        '
        'stn3_cyl1_min
        '
        Me.stn3_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.stn3_cyl1_min.Name = "stn3_cyl1_min"
        Me.stn3_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl1_min.TabIndex = 0
        Me.stn3_cyl1_min.TabStop = False
        '
        'stn3_cyl1_max
        '
        Me.stn3_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn3_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.stn3_cyl1_max.Name = "stn3_cyl1_max"
        Me.stn3_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.stn3_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn3_cyl1_max.TabIndex = 0
        Me.stn3_cyl1_max.TabStop = False
        '
        'GroupBox36
        '
        Me.GroupBox36.Controls.Add(Me.btn_stn3_cyl1_fw)
        Me.GroupBox36.Controls.Add(Me.btn_stn3_cyl1_bw)
        Me.GroupBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox36.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox36.TabIndex = 3
        Me.GroupBox36.TabStop = False
        Me.GroupBox36.Text = "Button"
        '
        'btn_stn3_cyl1_fw
        '
        Me.btn_stn3_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl1_fw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl1_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn3_cyl1_fw.Name = "btn_stn3_cyl1_fw"
        Me.btn_stn3_cyl1_fw.Size = New System.Drawing.Size(102, 77)
        Me.btn_stn3_cyl1_fw.TabIndex = 2
        Me.btn_stn3_cyl1_fw.Text = "Forward"
        Me.btn_stn3_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl1_fw.UseVisualStyleBackColor = False
        '
        'btn_stn3_cyl1_bw
        '
        Me.btn_stn3_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn3_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn3_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn3_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn3_cyl1_bw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stn3_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn3_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn3_cyl1_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn3_cyl1_bw.Name = "btn_stn3_cyl1_bw"
        Me.btn_stn3_cyl1_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn3_cyl1_bw.TabIndex = 2
        Me.btn_stn3_cyl1_bw.Text = "Backward"
        Me.btn_stn3_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn3_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn3_cyl1_bw.UseVisualStyleBackColor = False
        '
        'pnl_man_stn2
        '
        Me.pnl_man_stn2.Controls.Add(Me.TabPage8)
        Me.pnl_man_stn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn2.Location = New System.Drawing.Point(78, 97)
        Me.pnl_man_stn2.Name = "pnl_man_stn2"
        Me.pnl_man_stn2.SelectedIndex = 0
        Me.pnl_man_stn2.Size = New System.Drawing.Size(853, 563)
        Me.pnl_man_stn2.TabIndex = 100
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.GroupBox13)
        Me.TabPage8.Controls.Add(Me.GroupBox16)
        Me.TabPage8.Controls.Add(Me.GroupBox19)
        Me.TabPage8.Controls.Add(Me.GroupBox22)
        Me.TabPage8.Location = New System.Drawing.Point(4, 38)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(845, 521)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Station 2"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.AutoSize = True
        Me.GroupBox13.Controls.Add(Me.GroupBox14)
        Me.GroupBox13.Controls.Add(Me.GroupBox15)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(459, 270)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox13.TabIndex = 34
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "V204"
        Me.GroupBox13.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Label15)
        Me.GroupBox14.Controls.Add(Me.Label16)
        Me.GroupBox14.Controls.Add(Me.stn2_cyl4_min)
        Me.GroupBox14.Controls.Add(Me.stn2_cyl4_max)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox14.TabIndex = 3
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Sensor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 18)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Minimum"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 18)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Maximum"
        '
        'stn2_cyl4_min
        '
        Me.stn2_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.stn2_cyl4_min.Name = "stn2_cyl4_min"
        Me.stn2_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl4_min.TabIndex = 0
        Me.stn2_cyl4_min.TabStop = False
        '
        'stn2_cyl4_max
        '
        Me.stn2_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.stn2_cyl4_max.Name = "stn2_cyl4_max"
        Me.stn2_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl4_max.TabIndex = 0
        Me.stn2_cyl4_max.TabStop = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.btn_stn2_cyl4_fw)
        Me.GroupBox15.Controls.Add(Me.btn_stn2_cyl4_bw)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox15.TabIndex = 3
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Button"
        '
        'btn_stn2_cyl4_fw
        '
        Me.btn_stn2_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl4_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn2_cyl4_fw.Name = "btn_stn2_cyl4_fw"
        Me.btn_stn2_cyl4_fw.Size = New System.Drawing.Size(102, 76)
        Me.btn_stn2_cyl4_fw.TabIndex = 2
        Me.btn_stn2_cyl4_fw.Text = "Forward"
        Me.btn_stn2_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl4_fw.UseVisualStyleBackColor = False
        '
        'btn_stn2_cyl4_bw
        '
        Me.btn_stn2_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl4_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn2_cyl4_bw.Name = "btn_stn2_cyl4_bw"
        Me.btn_stn2_cyl4_bw.Size = New System.Drawing.Size(102, 87)
        Me.btn_stn2_cyl4_bw.TabIndex = 2
        Me.btn_stn2_cyl4_bw.Text = "Backward"
        Me.btn_stn2_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl4_bw.UseVisualStyleBackColor = False
        '
        'GroupBox16
        '
        Me.GroupBox16.AutoSize = True
        Me.GroupBox16.Controls.Add(Me.GroupBox17)
        Me.GroupBox16.Controls.Add(Me.GroupBox18)
        Me.GroupBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.Location = New System.Drawing.Point(459, 28)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox16.TabIndex = 35
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "V202"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Label17)
        Me.GroupBox17.Controls.Add(Me.Label19)
        Me.GroupBox17.Controls.Add(Me.stn2_cyl2_min)
        Me.GroupBox17.Controls.Add(Me.stn2_cyl2_max)
        Me.GroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox17.TabIndex = 3
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Sensor"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 18)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Minimum"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 18)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Maximum"
        '
        'stn2_cyl2_min
        '
        Me.stn2_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.stn2_cyl2_min.Name = "stn2_cyl2_min"
        Me.stn2_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl2_min.TabIndex = 0
        Me.stn2_cyl2_min.TabStop = False
        '
        'stn2_cyl2_max
        '
        Me.stn2_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.stn2_cyl2_max.Name = "stn2_cyl2_max"
        Me.stn2_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl2_max.TabIndex = 0
        Me.stn2_cyl2_max.TabStop = False
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.btn_stn2_cyl2_fw)
        Me.GroupBox18.Controls.Add(Me.btn_stn2_cyl2_bw)
        Me.GroupBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox18.TabIndex = 3
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Button"
        '
        'btn_stn2_cyl2_fw
        '
        Me.btn_stn2_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl2_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn2_cyl2_fw.Name = "btn_stn2_cyl2_fw"
        Me.btn_stn2_cyl2_fw.Size = New System.Drawing.Size(102, 76)
        Me.btn_stn2_cyl2_fw.TabIndex = 2
        Me.btn_stn2_cyl2_fw.Text = "Forward"
        Me.btn_stn2_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl2_fw.UseVisualStyleBackColor = False
        '
        'btn_stn2_cyl2_bw
        '
        Me.btn_stn2_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl2_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn2_cyl2_bw.Name = "btn_stn2_cyl2_bw"
        Me.btn_stn2_cyl2_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn2_cyl2_bw.TabIndex = 2
        Me.btn_stn2_cyl2_bw.Text = "Backward"
        Me.btn_stn2_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl2_bw.UseVisualStyleBackColor = False
        '
        'GroupBox19
        '
        Me.GroupBox19.AutoSize = True
        Me.GroupBox19.Controls.Add(Me.GroupBox20)
        Me.GroupBox19.Controls.Add(Me.GroupBox21)
        Me.GroupBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox19.Location = New System.Drawing.Point(94, 270)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox19.TabIndex = 36
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "V203"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.Label20)
        Me.GroupBox20.Controls.Add(Me.Label21)
        Me.GroupBox20.Controls.Add(Me.stn2_cyl3_min)
        Me.GroupBox20.Controls.Add(Me.stn2_cyl3_max)
        Me.GroupBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox20.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox20.TabIndex = 3
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Sensor"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 146)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 18)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Minimum"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(20, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 18)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Maximum"
        '
        'stn2_cyl3_min
        '
        Me.stn2_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.stn2_cyl3_min.Name = "stn2_cyl3_min"
        Me.stn2_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl3_min.TabIndex = 0
        Me.stn2_cyl3_min.TabStop = False
        '
        'stn2_cyl3_max
        '
        Me.stn2_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.stn2_cyl3_max.Name = "stn2_cyl3_max"
        Me.stn2_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl3_max.TabIndex = 0
        Me.stn2_cyl3_max.TabStop = False
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.btn_stn2_cyl3_fw)
        Me.GroupBox21.Controls.Add(Me.btn_stn2_cyl3_bw)
        Me.GroupBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox21.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox21.TabIndex = 3
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Button"
        '
        'btn_stn2_cyl3_fw
        '
        Me.btn_stn2_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl3_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn2_cyl3_fw.Name = "btn_stn2_cyl3_fw"
        Me.btn_stn2_cyl3_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn2_cyl3_fw.TabIndex = 2
        Me.btn_stn2_cyl3_fw.Text = "Forward"
        Me.btn_stn2_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl3_fw.UseVisualStyleBackColor = False
        '
        'btn_stn2_cyl3_bw
        '
        Me.btn_stn2_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl3_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn2_cyl3_bw.Name = "btn_stn2_cyl3_bw"
        Me.btn_stn2_cyl3_bw.Size = New System.Drawing.Size(102, 77)
        Me.btn_stn2_cyl3_bw.TabIndex = 2
        Me.btn_stn2_cyl3_bw.Text = "Backward"
        Me.btn_stn2_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl3_bw.UseVisualStyleBackColor = False
        '
        'GroupBox22
        '
        Me.GroupBox22.AutoSize = True
        Me.GroupBox22.Controls.Add(Me.GroupBox23)
        Me.GroupBox22.Controls.Add(Me.GroupBox24)
        Me.GroupBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox22.Location = New System.Drawing.Point(94, 28)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox22.TabIndex = 37
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "V201"
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.Label22)
        Me.GroupBox23.Controls.Add(Me.Label23)
        Me.GroupBox23.Controls.Add(Me.stn2_cyl1_min)
        Me.GroupBox23.Controls.Add(Me.stn2_cyl1_max)
        Me.GroupBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox23.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox23.TabIndex = 3
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Sensor"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(20, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 18)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Minimum"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 70)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 18)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Maximum"
        '
        'stn2_cyl1_min
        '
        Me.stn2_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.stn2_cyl1_min.Name = "stn2_cyl1_min"
        Me.stn2_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl1_min.TabIndex = 0
        Me.stn2_cyl1_min.TabStop = False
        '
        'stn2_cyl1_max
        '
        Me.stn2_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn2_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.stn2_cyl1_max.Name = "stn2_cyl1_max"
        Me.stn2_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.stn2_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn2_cyl1_max.TabIndex = 0
        Me.stn2_cyl1_max.TabStop = False
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.btn_stn2_cyl1_fw)
        Me.GroupBox24.Controls.Add(Me.btn_stn2_cyl1_bw)
        Me.GroupBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox24.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox24.TabIndex = 3
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Button"
        '
        'btn_stn2_cyl1_fw
        '
        Me.btn_stn2_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl1_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn2_cyl1_fw.Name = "btn_stn2_cyl1_fw"
        Me.btn_stn2_cyl1_fw.Size = New System.Drawing.Size(102, 77)
        Me.btn_stn2_cyl1_fw.TabIndex = 2
        Me.btn_stn2_cyl1_fw.Text = "Forward"
        Me.btn_stn2_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl1_fw.UseVisualStyleBackColor = False
        '
        'btn_stn2_cyl1_bw
        '
        Me.btn_stn2_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn2_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn2_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn2_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn2_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn2_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn2_cyl1_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn2_cyl1_bw.Name = "btn_stn2_cyl1_bw"
        Me.btn_stn2_cyl1_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn2_cyl1_bw.TabIndex = 2
        Me.btn_stn2_cyl1_bw.Text = "Backward"
        Me.btn_stn2_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn2_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn2_cyl1_bw.UseVisualStyleBackColor = False
        '
        'pnl_man_stn1
        '
        Me.pnl_man_stn1.Controls.Add(Me.TabPage9)
        Me.pnl_man_stn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn1.Location = New System.Drawing.Point(78, 97)
        Me.pnl_man_stn1.Name = "pnl_man_stn1"
        Me.pnl_man_stn1.SelectedIndex = 0
        Me.pnl_man_stn1.Size = New System.Drawing.Size(853, 563)
        Me.pnl_man_stn1.TabIndex = 101
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.GroupBox10)
        Me.TabPage9.Controls.Add(Me.GroupBox4)
        Me.TabPage9.Controls.Add(Me.GroupBox7)
        Me.TabPage9.Controls.Add(Me.GroupBox3)
        Me.TabPage9.Location = New System.Drawing.Point(4, 38)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(845, 521)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Station 1"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.AutoSize = True
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Controls.Add(Me.GroupBox12)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(459, 270)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox10.TabIndex = 34
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "V104"
        Me.GroupBox10.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label13)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.stn1_cyl4_min)
        Me.GroupBox11.Controls.Add(Me.stn1_cyl4_max)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox11.TabIndex = 3
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Sensor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 18)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Minimum"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 18)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Maximum"
        '
        'stn1_cyl4_min
        '
        Me.stn1_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.stn1_cyl4_min.Name = "stn1_cyl4_min"
        Me.stn1_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl4_min.TabIndex = 0
        Me.stn1_cyl4_min.TabStop = False
        '
        'stn1_cyl4_max
        '
        Me.stn1_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.stn1_cyl4_max.Name = "stn1_cyl4_max"
        Me.stn1_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl4_max.TabIndex = 0
        Me.stn1_cyl4_max.TabStop = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.btn_stn1_cyl4_fw)
        Me.GroupBox12.Controls.Add(Me.btn_stn1_cyl4_bw)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Button"
        '
        'btn_stn1_cyl4_fw
        '
        Me.btn_stn1_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl4_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn1_cyl4_fw.Name = "btn_stn1_cyl4_fw"
        Me.btn_stn1_cyl4_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn1_cyl4_fw.TabIndex = 2
        Me.btn_stn1_cyl4_fw.Text = "Forward"
        Me.btn_stn1_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl4_fw.UseVisualStyleBackColor = False
        '
        'btn_stn1_cyl4_bw
        '
        Me.btn_stn1_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl4_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn1_cyl4_bw.Name = "btn_stn1_cyl4_bw"
        Me.btn_stn1_cyl4_bw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn1_cyl4_bw.TabIndex = 2
        Me.btn_stn1_cyl4_bw.Text = "Backward"
        Me.btn_stn1_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl4_bw.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(459, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "V102"
        Me.GroupBox4.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.stn1_cyl2_min)
        Me.GroupBox5.Controls.Add(Me.stn1_cyl2_max)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sensor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Minimum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Maximum"
        '
        'stn1_cyl2_min
        '
        Me.stn1_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.stn1_cyl2_min.Name = "stn1_cyl2_min"
        Me.stn1_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl2_min.TabIndex = 0
        Me.stn1_cyl2_min.TabStop = False
        '
        'stn1_cyl2_max
        '
        Me.stn1_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.stn1_cyl2_max.Name = "stn1_cyl2_max"
        Me.stn1_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl2_max.TabIndex = 0
        Me.stn1_cyl2_max.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_stn1_cyl2_fw)
        Me.GroupBox6.Controls.Add(Me.btn_stn1_cyl2_bw)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Button"
        '
        'btn_stn1_cyl2_fw
        '
        Me.btn_stn1_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl2_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn1_cyl2_fw.Name = "btn_stn1_cyl2_fw"
        Me.btn_stn1_cyl2_fw.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn1_cyl2_fw.TabIndex = 2
        Me.btn_stn1_cyl2_fw.Text = "Forward"
        Me.btn_stn1_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl2_fw.UseVisualStyleBackColor = False
        '
        'btn_stn1_cyl2_bw
        '
        Me.btn_stn1_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl2_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn1_cyl2_bw.Name = "btn_stn1_cyl2_bw"
        Me.btn_stn1_cyl2_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn1_cyl2_bw.TabIndex = 2
        Me.btn_stn1_cyl2_bw.Text = "Backward"
        Me.btn_stn1_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl2_bw.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.AutoSize = True
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(94, 270)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "V103"
        Me.GroupBox7.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.stn1_cyl3_min)
        Me.GroupBox8.Controls.Add(Me.stn1_cyl3_max)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Sensor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Minimum"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Maximum"
        '
        'stn1_cyl3_min
        '
        Me.stn1_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.stn1_cyl3_min.Name = "stn1_cyl3_min"
        Me.stn1_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl3_min.TabIndex = 0
        Me.stn1_cyl3_min.TabStop = False
        '
        'stn1_cyl3_max
        '
        Me.stn1_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.stn1_cyl3_max.Name = "stn1_cyl3_max"
        Me.stn1_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl3_max.TabIndex = 0
        Me.stn1_cyl3_max.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.btn_stn1_cyl3_fw)
        Me.GroupBox9.Controls.Add(Me.btn_stn1_cyl3_bw)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Button"
        '
        'btn_stn1_cyl3_fw
        '
        Me.btn_stn1_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl3_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn1_cyl3_fw.Name = "btn_stn1_cyl3_fw"
        Me.btn_stn1_cyl3_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn1_cyl3_fw.TabIndex = 2
        Me.btn_stn1_cyl3_fw.Text = "Forward"
        Me.btn_stn1_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl3_fw.UseVisualStyleBackColor = False
        '
        'btn_stn1_cyl3_bw
        '
        Me.btn_stn1_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl3_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn1_cyl3_bw.Name = "btn_stn1_cyl3_bw"
        Me.btn_stn1_cyl3_bw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn1_cyl3_bw.TabIndex = 2
        Me.btn_stn1_cyl3_bw.Text = "Backward"
        Me.btn_stn1_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl3_bw.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(94, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 239)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "V101"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.stn1_cyl1_min)
        Me.GroupBox2.Controls.Add(Me.stn1_cyl1_max)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sensor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Minimum"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Maximum"
        '
        'stn1_cyl1_min
        '
        Me.stn1_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.stn1_cyl1_min.Name = "stn1_cyl1_min"
        Me.stn1_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl1_min.TabIndex = 0
        Me.stn1_cyl1_min.TabStop = False
        '
        'stn1_cyl1_max
        '
        Me.stn1_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn1_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.stn1_cyl1_max.Name = "stn1_cyl1_max"
        Me.stn1_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.stn1_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn1_cyl1_max.TabIndex = 0
        Me.stn1_cyl1_max.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_stn1_cyl1_fw)
        Me.GroupBox1.Controls.Add(Me.btn_stn1_cyl1_bw)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Button"
        '
        'btn_stn1_cyl1_fw
        '
        Me.btn_stn1_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl1_fw.Location = New System.Drawing.Point(6, 19)
        Me.btn_stn1_cyl1_fw.Name = "btn_stn1_cyl1_fw"
        Me.btn_stn1_cyl1_fw.Size = New System.Drawing.Size(102, 83)
        Me.btn_stn1_cyl1_fw.TabIndex = 2
        Me.btn_stn1_cyl1_fw.Text = "Forward"
        Me.btn_stn1_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl1_fw.UseVisualStyleBackColor = False
        '
        'btn_stn1_cyl1_bw
        '
        Me.btn_stn1_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn1_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn1_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn1_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn1_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn1_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn1_cyl1_bw.Location = New System.Drawing.Point(6, 95)
        Me.btn_stn1_cyl1_bw.Name = "btn_stn1_cyl1_bw"
        Me.btn_stn1_cyl1_bw.Size = New System.Drawing.Size(102, 75)
        Me.btn_stn1_cyl1_bw.TabIndex = 2
        Me.btn_stn1_cyl1_bw.Text = "Backward"
        Me.btn_stn1_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn1_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn1_cyl1_bw.UseVisualStyleBackColor = False
        '
        'pnl_setting
        '
        Me.pnl_setting.Controls.Add(Me.TabPage10)
        Me.pnl_setting.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_setting.Location = New System.Drawing.Point(78, 97)
        Me.pnl_setting.Name = "pnl_setting"
        Me.pnl_setting.SelectedIndex = 0
        Me.pnl_setting.Size = New System.Drawing.Size(853, 563)
        Me.pnl_setting.TabIndex = 102
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.GroupBox169)
        Me.TabPage10.Controls.Add(Me.grp_plc)
        Me.TabPage10.Location = New System.Drawing.Point(4, 38)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(845, 521)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Configuration"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'GroupBox169
        '
        Me.GroupBox169.Controls.Add(Me.Label2)
        Me.GroupBox169.Controls.Add(Me.connect_multi_ind)
        Me.GroupBox169.Controls.Add(Me.Label226)
        Me.GroupBox169.Controls.Add(Me.txtIP_multi)
        Me.GroupBox169.Controls.Add(Me.btn_check_multi)
        Me.GroupBox169.Controls.Add(Me.btn_connect_multi)
        Me.GroupBox169.Controls.Add(Me.txtPort_multi)
        Me.GroupBox169.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox169.Location = New System.Drawing.Point(476, 118)
        Me.GroupBox169.Name = "GroupBox169"
        Me.GroupBox169.Size = New System.Drawing.Size(214, 190)
        Me.GroupBox169.TabIndex = 59
        Me.GroupBox169.TabStop = False
        Me.GroupBox169.Text = "Multimeter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server IP :"
        '
        'connect_multi_ind
        '
        Me.connect_multi_ind.BackColor = System.Drawing.Color.Transparent
        Me.connect_multi_ind.Image = Global.TESTER.My.Resources.Resources.led_red_on
        Me.connect_multi_ind.Location = New System.Drawing.Point(124, 106)
        Me.connect_multi_ind.Name = "connect_multi_ind"
        Me.connect_multi_ind.Size = New System.Drawing.Size(20, 20)
        Me.connect_multi_ind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connect_multi_ind.TabIndex = 1
        Me.connect_multi_ind.TabStop = False
        '
        'Label226
        '
        Me.Label226.AutoSize = True
        Me.Label226.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label226.Location = New System.Drawing.Point(9, 67)
        Me.Label226.Name = "Label226"
        Me.Label226.Size = New System.Drawing.Size(80, 20)
        Me.Label226.TabIndex = 1
        Me.Label226.Text = "TCP Port :"
        '
        'txtIP_multi
        '
        Me.txtIP_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP_multi.Location = New System.Drawing.Point(93, 30)
        Me.txtIP_multi.Name = "txtIP_multi"
        Me.txtIP_multi.Size = New System.Drawing.Size(112, 26)
        Me.txtIP_multi.TabIndex = 2
        Me.txtIP_multi.Text = "127.0.0.1"
        '
        'btn_check_multi
        '
        Me.btn_check_multi.AutoSize = True
        Me.btn_check_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check_multi.Location = New System.Drawing.Point(13, 140)
        Me.btn_check_multi.Name = "btn_check_multi"
        Me.btn_check_multi.Size = New System.Drawing.Size(149, 35)
        Me.btn_check_multi.TabIndex = 4
        Me.btn_check_multi.Text = "Check Connection"
        Me.btn_check_multi.UseVisualStyleBackColor = True
        '
        'btn_connect_multi
        '
        Me.btn_connect_multi.AutoSize = True
        Me.btn_connect_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect_multi.Location = New System.Drawing.Point(13, 99)
        Me.btn_connect_multi.Name = "btn_connect_multi"
        Me.btn_connect_multi.Size = New System.Drawing.Size(102, 35)
        Me.btn_connect_multi.TabIndex = 4
        Me.btn_connect_multi.Text = "Connect"
        Me.btn_connect_multi.UseVisualStyleBackColor = True
        '
        'txtPort_multi
        '
        Me.txtPort_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort_multi.Location = New System.Drawing.Point(93, 63)
        Me.txtPort_multi.Name = "txtPort_multi"
        Me.txtPort_multi.Size = New System.Drawing.Size(112, 26)
        Me.txtPort_multi.TabIndex = 3
        Me.txtPort_multi.Text = "8.8.8.8"
        '
        'grp_plc
        '
        Me.grp_plc.Controls.Add(Me.cbo_data_type)
        Me.grp_plc.Controls.Add(Me.connect_plc_ind)
        Me.grp_plc.Controls.Add(Me.btn_write)
        Me.grp_plc.Controls.Add(Me.btn_connect_plc)
        Me.grp_plc.Controls.Add(Me.btn_read)
        Me.grp_plc.Controls.Add(Me.txtPort_PLC)
        Me.grp_plc.Controls.Add(Me.txtValue)
        Me.grp_plc.Controls.Add(Me.txtIP_PLC)
        Me.grp_plc.Controls.Add(Me.Label72)
        Me.grp_plc.Controls.Add(Me.Label7)
        Me.grp_plc.Controls.Add(Me.txtAddress)
        Me.grp_plc.Controls.Add(Me.Label8)
        Me.grp_plc.Controls.Add(Me.Label6)
        Me.grp_plc.Controls.Add(Me.Label9)
        Me.grp_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_plc.Location = New System.Drawing.Point(155, 118)
        Me.grp_plc.Name = "grp_plc"
        Me.grp_plc.Size = New System.Drawing.Size(214, 301)
        Me.grp_plc.TabIndex = 58
        Me.grp_plc.TabStop = False
        Me.grp_plc.Text = "PLC"
        '
        'cbo_data_type
        '
        Me.cbo_data_type.FormattingEnabled = True
        Me.cbo_data_type.Items.AddRange(New Object() {"INT", "FLOAT"})
        Me.cbo_data_type.Location = New System.Drawing.Point(90, 210)
        Me.cbo_data_type.Name = "cbo_data_type"
        Me.cbo_data_type.Size = New System.Drawing.Size(112, 32)
        Me.cbo_data_type.TabIndex = 57
        '
        'connect_plc_ind
        '
        Me.connect_plc_ind.BackColor = System.Drawing.Color.Transparent
        Me.connect_plc_ind.Image = Global.TESTER.My.Resources.Resources.led_red_on
        Me.connect_plc_ind.Location = New System.Drawing.Point(121, 100)
        Me.connect_plc_ind.Name = "connect_plc_ind"
        Me.connect_plc_ind.Size = New System.Drawing.Size(20, 20)
        Me.connect_plc_ind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connect_plc_ind.TabIndex = 1
        Me.connect_plc_ind.TabStop = False
        '
        'btn_write
        '
        Me.btn_write.AutoSize = True
        Me.btn_write.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_write.Location = New System.Drawing.Point(118, 257)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(84, 35)
        Me.btn_write.TabIndex = 4
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'btn_connect_plc
        '
        Me.btn_connect_plc.AutoSize = True
        Me.btn_connect_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect_plc.Location = New System.Drawing.Point(10, 93)
        Me.btn_connect_plc.Name = "btn_connect_plc"
        Me.btn_connect_plc.Size = New System.Drawing.Size(102, 35)
        Me.btn_connect_plc.TabIndex = 4
        Me.btn_connect_plc.Text = "Connect"
        Me.btn_connect_plc.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.AutoSize = True
        Me.btn_read.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read.Location = New System.Drawing.Point(16, 257)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(84, 35)
        Me.btn_read.TabIndex = 4
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'txtPort_PLC
        '
        Me.txtPort_PLC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort_PLC.Location = New System.Drawing.Point(90, 57)
        Me.txtPort_PLC.Name = "txtPort_PLC"
        Me.txtPort_PLC.Size = New System.Drawing.Size(112, 26)
        Me.txtPort_PLC.TabIndex = 3
        Me.txtPort_PLC.Text = "502"
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(90, 178)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(112, 26)
        Me.txtValue.TabIndex = 3
        '
        'txtIP_PLC
        '
        Me.txtIP_PLC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP_PLC.Location = New System.Drawing.Point(90, 24)
        Me.txtIP_PLC.Name = "txtIP_PLC"
        Me.txtIP_PLC.Size = New System.Drawing.Size(112, 26)
        Me.txtIP_PLC.TabIndex = 2
        Me.txtIP_PLC.Text = "192.168.1.212"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(-5, 214)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(90, 20)
        Me.Label72.TabIndex = 1
        Me.Label72.Text = "Data Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "TCP Port :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(90, 145)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(112, 26)
        Me.txtAddress.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Value :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Server IP :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Address :"
        '
        'pnl_log
        '
        Me.pnl_log.Controls.Add(Me.TabPage1)
        Me.pnl_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_log.Location = New System.Drawing.Point(78, 97)
        Me.pnl_log.Name = "pnl_log"
        Me.pnl_log.SelectedIndex = 0
        Me.pnl_log.Size = New System.Drawing.Size(853, 563)
        Me.pnl_log.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox174)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(845, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Logger"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox174
        '
        Me.GroupBox174.Controls.Add(Me.TabControl10)
        Me.GroupBox174.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox174.Location = New System.Drawing.Point(7, 329)
        Me.GroupBox174.Name = "GroupBox174"
        Me.GroupBox174.Size = New System.Drawing.Size(831, 179)
        Me.GroupBox174.TabIndex = 69
        Me.GroupBox174.TabStop = False
        Me.GroupBox174.Text = "Find"
        '
        'TabControl10
        '
        Me.TabControl10.Controls.Add(Me.TabPage11)
        Me.TabControl10.Controls.Add(Me.TabPage12)
        Me.TabControl10.Location = New System.Drawing.Point(12, 35)
        Me.TabControl10.Name = "TabControl10"
        Me.TabControl10.SelectedIndex = 0
        Me.TabControl10.Size = New System.Drawing.Size(819, 138)
        Me.TabControl10.TabIndex = 64
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.btn_search)
        Me.TabPage11.Controls.Add(Me.Label249)
        Me.TabPage11.Controls.Add(Me.DateTimePickerEndDate)
        Me.TabPage11.Controls.Add(Me.Label250)
        Me.TabPage11.Controls.Add(Me.DateTimePickerStartDate)
        Me.TabPage11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage11.Location = New System.Drawing.Point(4, 33)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(811, 101)
        Me.TabPage11.TabIndex = 0
        Me.TabPage11.Text = "Date"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(494, 21)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(150, 58)
        Me.btn_search.TabIndex = 24
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label249
        '
        Me.Label249.AutoSize = True
        Me.Label249.Location = New System.Drawing.Point(173, 59)
        Me.Label249.Name = "Label249"
        Me.Label249.Size = New System.Drawing.Size(77, 20)
        Me.Label249.TabIndex = 23
        Me.Label249.Text = "End Date"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(274, 54)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerEndDate.TabIndex = 22
        '
        'Label250
        '
        Me.Label250.AutoSize = True
        Me.Label250.Location = New System.Drawing.Point(173, 27)
        Me.Label250.Name = "Label250"
        Me.Label250.Size = New System.Drawing.Size(83, 20)
        Me.Label250.TabIndex = 21
        Me.Label250.Text = "Start Date"
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(274, 22)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerStartDate.TabIndex = 20
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.cb_search_opt)
        Me.TabPage12.Controls.Add(Me.btn_search_other)
        Me.TabPage12.Controls.Add(Me.txt_find_other)
        Me.TabPage12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage12.Location = New System.Drawing.Point(4, 33)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(811, 101)
        Me.TabPage12.TabIndex = 1
        Me.TabPage12.Text = "Other"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'cb_search_opt
        '
        Me.cb_search_opt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_search_opt.FormattingEnabled = True
        Me.cb_search_opt.Items.AddRange(New Object() {"References", "PO Number", "Operator ID"})
        Me.cb_search_opt.Location = New System.Drawing.Point(190, 33)
        Me.cb_search_opt.Name = "cb_search_opt"
        Me.cb_search_opt.Size = New System.Drawing.Size(121, 32)
        Me.cb_search_opt.TabIndex = 6
        '
        'btn_search_other
        '
        Me.btn_search_other.Location = New System.Drawing.Point(508, 35)
        Me.btn_search_other.Name = "btn_search_other"
        Me.btn_search_other.Size = New System.Drawing.Size(107, 30)
        Me.btn_search_other.TabIndex = 5
        Me.btn_search_other.Text = "Search"
        Me.btn_search_other.UseVisualStyleBackColor = True
        '
        'txt_find_other
        '
        Me.txt_find_other.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_find_other.Location = New System.Drawing.Point(326, 36)
        Me.txt_find_other.Name = "txt_find_other"
        Me.txt_find_other.Size = New System.Drawing.Size(171, 29)
        Me.txt_find_other.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(831, 306)
        Me.DataGridView1.TabIndex = 68
        '
        'pnl_ref
        '
        Me.pnl_ref.Controls.Add(Me.TabPage2)
        Me.pnl_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_ref.Location = New System.Drawing.Point(78, 97)
        Me.pnl_ref.Name = "pnl_ref"
        Me.pnl_ref.SelectedIndex = 0
        Me.pnl_ref.Size = New System.Drawing.Size(853, 563)
        Me.pnl_ref.TabIndex = 104
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_ref)
        Me.TabPage2.Controls.Add(Me.GroupBox_Control)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(845, 521)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "References"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_ref
        '
        Me.dgv_ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ref.Location = New System.Drawing.Point(305, 34)
        Me.dgv_ref.Name = "dgv_ref"
        Me.dgv_ref.Size = New System.Drawing.Size(534, 476)
        Me.dgv_ref.TabIndex = 67
        '
        'GroupBox_Control
        '
        Me.GroupBox_Control.BackColor = System.Drawing.Color.White
        Me.GroupBox_Control.Controls.Add(Me.txt_laser_template_pnl)
        Me.GroupBox_Control.Controls.Add(Me.txt_beating_times_pnl)
        Me.GroupBox_Control.Controls.Add(Me.Label247)
        Me.GroupBox_Control.Controls.Add(Me.Label237)
        Me.GroupBox_Control.Controls.Add(Me.txt_laser_datecode_pnl)
        Me.GroupBox_Control.Controls.Add(Me.txt_dif_str_tol_pnl)
        Me.GroupBox_Control.Controls.Add(Me.Label246)
        Me.GroupBox_Control.Controls.Add(Me.Label238)
        Me.GroupBox_Control.Controls.Add(Me.btn_update)
        Me.GroupBox_Control.Controls.Add(Me.txt_unscrew_pnl)
        Me.GroupBox_Control.Controls.Add(Me.txt_dif_str_pnl)
        Me.GroupBox_Control.Controls.Add(Me.txt_cfg_2nd_pnl)
        Me.GroupBox_Control.Controls.Add(Me.txt_act_val_tol_pnl)
        Me.GroupBox_Control.Controls.Add(Me.Label245)
        Me.GroupBox_Control.Controls.Add(Me.Label239)
        Me.GroupBox_Control.Controls.Add(Me.Label244)
        Me.GroupBox_Control.Controls.Add(Me.Label240)
        Me.GroupBox_Control.Controls.Add(Me.btn_delete)
        Me.GroupBox_Control.Controls.Add(Me.btn_add)
        Me.GroupBox_Control.Controls.Add(Me.txt_cfg_1st_pnl)
        Me.GroupBox_Control.Controls.Add(Me.txt_act_val_pnl)
        Me.GroupBox_Control.Controls.Add(Me.Label243)
        Me.GroupBox_Control.Controls.Add(Me.txt_ref_pnl)
        Me.GroupBox_Control.Controls.Add(Me.Label241)
        Me.GroupBox_Control.Controls.Add(Me.Label242)
        Me.GroupBox_Control.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Control.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Control.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox_Control.Name = "GroupBox_Control"
        Me.GroupBox_Control.Size = New System.Drawing.Size(290, 491)
        Me.GroupBox_Control.TabIndex = 66
        Me.GroupBox_Control.TabStop = False
        Me.GroupBox_Control.Text = "Control"
        '
        'txt_laser_template_pnl
        '
        Me.txt_laser_template_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_laser_template_pnl.Location = New System.Drawing.Point(170, 369)
        Me.txt_laser_template_pnl.MaxLength = 3
        Me.txt_laser_template_pnl.Name = "txt_laser_template_pnl"
        Me.txt_laser_template_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_laser_template_pnl.TabIndex = 6
        '
        'txt_beating_times_pnl
        '
        Me.txt_beating_times_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_beating_times_pnl.Location = New System.Drawing.Point(169, 209)
        Me.txt_beating_times_pnl.MaxLength = 3
        Me.txt_beating_times_pnl.Name = "txt_beating_times_pnl"
        Me.txt_beating_times_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_beating_times_pnl.TabIndex = 6
        '
        'Label247
        '
        Me.Label247.AutoSize = True
        Me.Label247.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label247.Location = New System.Drawing.Point(18, 372)
        Me.Label247.Name = "Label247"
        Me.Label247.Size = New System.Drawing.Size(119, 20)
        Me.Label247.TabIndex = 18
        Me.Label247.Text = "Laser Template"
        '
        'Label237
        '
        Me.Label237.AutoSize = True
        Me.Label237.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label237.Location = New System.Drawing.Point(17, 212)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(110, 20)
        Me.Label237.TabIndex = 18
        Me.Label237.Text = "Beating Times"
        '
        'txt_laser_datecode_pnl
        '
        Me.txt_laser_datecode_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_laser_datecode_pnl.Location = New System.Drawing.Point(170, 337)
        Me.txt_laser_datecode_pnl.Name = "txt_laser_datecode_pnl"
        Me.txt_laser_datecode_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_laser_datecode_pnl.TabIndex = 5
        '
        'txt_dif_str_tol_pnl
        '
        Me.txt_dif_str_tol_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dif_str_tol_pnl.Location = New System.Drawing.Point(169, 177)
        Me.txt_dif_str_tol_pnl.Name = "txt_dif_str_tol_pnl"
        Me.txt_dif_str_tol_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_dif_str_tol_pnl.TabIndex = 5
        '
        'Label246
        '
        Me.Label246.AutoSize = True
        Me.Label246.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label246.Location = New System.Drawing.Point(18, 340)
        Me.Label246.Name = "Label246"
        Me.Label246.Size = New System.Drawing.Size(123, 20)
        Me.Label246.TabIndex = 16
        Me.Label246.Text = "Laser Datecode"
        '
        'Label238
        '
        Me.Label238.AutoSize = True
        Me.Label238.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label238.Location = New System.Drawing.Point(17, 180)
        Me.Label238.Name = "Label238"
        Me.Label238.Size = New System.Drawing.Size(119, 20)
        Me.Label238.TabIndex = 16
        Me.Label238.Text = "Dif Str Tol (mm)"
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(107, 414)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(85, 59)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_unscrew_pnl
        '
        Me.txt_unscrew_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unscrew_pnl.Location = New System.Drawing.Point(170, 305)
        Me.txt_unscrew_pnl.MaxLength = 2
        Me.txt_unscrew_pnl.Name = "txt_unscrew_pnl"
        Me.txt_unscrew_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_unscrew_pnl.TabIndex = 4
        '
        'txt_dif_str_pnl
        '
        Me.txt_dif_str_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dif_str_pnl.Location = New System.Drawing.Point(169, 145)
        Me.txt_dif_str_pnl.MaxLength = 2
        Me.txt_dif_str_pnl.Name = "txt_dif_str_pnl"
        Me.txt_dif_str_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_dif_str_pnl.TabIndex = 4
        '
        'txt_cfg_2nd_pnl
        '
        Me.txt_cfg_2nd_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cfg_2nd_pnl.Location = New System.Drawing.Point(170, 273)
        Me.txt_cfg_2nd_pnl.MaxLength = 2
        Me.txt_cfg_2nd_pnl.Name = "txt_cfg_2nd_pnl"
        Me.txt_cfg_2nd_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_cfg_2nd_pnl.TabIndex = 3
        '
        'txt_act_val_tol_pnl
        '
        Me.txt_act_val_tol_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_act_val_tol_pnl.Location = New System.Drawing.Point(169, 113)
        Me.txt_act_val_tol_pnl.MaxLength = 2
        Me.txt_act_val_tol_pnl.Name = "txt_act_val_tol_pnl"
        Me.txt_act_val_tol_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_act_val_tol_pnl.TabIndex = 3
        '
        'Label245
        '
        Me.Label245.AutoSize = True
        Me.Label245.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label245.Location = New System.Drawing.Point(18, 308)
        Me.Label245.Name = "Label245"
        Me.Label245.Size = New System.Drawing.Size(153, 20)
        Me.Label245.TabIndex = 13
        Me.Label245.Text = "Unscrewing Process"
        '
        'Label239
        '
        Me.Label239.AutoSize = True
        Me.Label239.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label239.Location = New System.Drawing.Point(17, 148)
        Me.Label239.Name = "Label239"
        Me.Label239.Size = New System.Drawing.Size(94, 20)
        Me.Label239.TabIndex = 13
        Me.Label239.Text = "Dif Str (mm)"
        '
        'Label244
        '
        Me.Label244.AutoSize = True
        Me.Label244.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label244.Location = New System.Drawing.Point(18, 276)
        Me.Label244.Name = "Label244"
        Me.Label244.Size = New System.Drawing.Size(150, 20)
        Me.Label244.TabIndex = 12
        Me.Label244.Text = "Config 2 nd Contact"
        '
        'Label240
        '
        Me.Label240.AutoSize = True
        Me.Label240.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label240.Location = New System.Drawing.Point(17, 116)
        Me.Label240.Name = "Label240"
        Me.Label240.Size = New System.Drawing.Size(125, 20)
        Me.Label240.TabIndex = 12
        Me.Label240.Text = "Act Val Tol (mm)"
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(197, 414)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(85, 59)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(22, 414)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 59)
        Me.btn_add.TabIndex = 12
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_cfg_1st_pnl
        '
        Me.txt_cfg_1st_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cfg_1st_pnl.Location = New System.Drawing.Point(170, 241)
        Me.txt_cfg_1st_pnl.MaxLength = 2
        Me.txt_cfg_1st_pnl.Name = "txt_cfg_1st_pnl"
        Me.txt_cfg_1st_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_cfg_1st_pnl.TabIndex = 2
        '
        'txt_act_val_pnl
        '
        Me.txt_act_val_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_act_val_pnl.Location = New System.Drawing.Point(169, 81)
        Me.txt_act_val_pnl.MaxLength = 2
        Me.txt_act_val_pnl.Name = "txt_act_val_pnl"
        Me.txt_act_val_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_act_val_pnl.TabIndex = 2
        '
        'Label243
        '
        Me.Label243.AutoSize = True
        Me.Label243.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label243.Location = New System.Drawing.Point(18, 244)
        Me.Label243.Name = "Label243"
        Me.Label243.Size = New System.Drawing.Size(141, 20)
        Me.Label243.TabIndex = 7
        Me.Label243.Text = "Config 1st Contact"
        '
        'txt_ref_pnl
        '
        Me.txt_ref_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ref_pnl.Location = New System.Drawing.Point(169, 49)
        Me.txt_ref_pnl.MaxLength = 32
        Me.txt_ref_pnl.Name = "txt_ref_pnl"
        Me.txt_ref_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_ref_pnl.TabIndex = 1
        '
        'Label241
        '
        Me.Label241.AutoSize = True
        Me.Label241.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label241.Location = New System.Drawing.Point(17, 84)
        Me.Label241.Name = "Label241"
        Me.Label241.Size = New System.Drawing.Size(100, 20)
        Me.Label241.TabIndex = 7
        Me.Label241.Text = "Act Val (mm)"
        '
        'Label242
        '
        Me.Label242.AutoSize = True
        Me.Label242.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label242.Location = New System.Drawing.Point(17, 52)
        Me.Label242.Name = "Label242"
        Me.Label242.Size = New System.Drawing.Size(92, 20)
        Me.Label242.TabIndex = 6
        Me.Label242.Text = "References"
        '
        'pnl_laser
        '
        Me.pnl_laser.Controls.Add(Me.TabPage13)
        Me.pnl_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_laser.Location = New System.Drawing.Point(78, 97)
        Me.pnl_laser.Name = "pnl_laser"
        Me.pnl_laser.SelectedIndex = 0
        Me.pnl_laser.Size = New System.Drawing.Size(853, 563)
        Me.pnl_laser.TabIndex = 105
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.GroupBox171)
        Me.TabPage13.Location = New System.Drawing.Point(4, 38)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(845, 521)
        Me.TabPage13.TabIndex = 0
        Me.TabPage13.Text = "Laser Mark"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'GroupBox171
        '
        Me.GroupBox171.Controls.Add(Me.GroupBox172)
        Me.GroupBox171.Controls.Add(Me.GroupBox173)
        Me.GroupBox171.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox171.Location = New System.Drawing.Point(171, 35)
        Me.GroupBox171.Name = "GroupBox171"
        Me.GroupBox171.Size = New System.Drawing.Size(502, 466)
        Me.GroupBox171.TabIndex = 62
        Me.GroupBox171.TabStop = False
        Me.GroupBox171.Text = "Laser Parameter"
        '
        'GroupBox172
        '
        Me.GroupBox172.Controls.Add(Me.txt_comm_log)
        Me.GroupBox172.Location = New System.Drawing.Point(6, 306)
        Me.GroupBox172.Name = "GroupBox172"
        Me.GroupBox172.Size = New System.Drawing.Size(485, 146)
        Me.GroupBox172.TabIndex = 7
        Me.GroupBox172.TabStop = False
        Me.GroupBox172.Text = "Communication Log"
        '
        'txt_comm_log
        '
        Me.txt_comm_log.Location = New System.Drawing.Point(6, 30)
        Me.txt_comm_log.Multiline = True
        Me.txt_comm_log.Name = "txt_comm_log"
        Me.txt_comm_log.Size = New System.Drawing.Size(473, 110)
        Me.txt_comm_log.TabIndex = 6
        '
        'GroupBox173
        '
        Me.GroupBox173.Controls.Add(Me.btn_mark_flag)
        Me.GroupBox173.Controls.Add(Me.btn_change_prg)
        Me.GroupBox173.Controls.Add(Me.btn_start_marking)
        Me.GroupBox173.Controls.Add(Me.btn_string_char)
        Me.GroupBox173.Controls.Add(Me.txt_block2)
        Me.GroupBox173.Controls.Add(Me.txt_block1)
        Me.GroupBox173.Controls.Add(Me.txt_block0)
        Me.GroupBox173.Controls.Add(Me.Label232)
        Me.GroupBox173.Controls.Add(Me.chb_mark_cavity_1)
        Me.GroupBox173.Controls.Add(Me.Label233)
        Me.GroupBox173.Controls.Add(Me.cb_prg_num)
        Me.GroupBox173.Controls.Add(Me.Label234)
        Me.GroupBox173.Controls.Add(Me.Label235)
        Me.GroupBox173.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox173.Name = "GroupBox173"
        Me.GroupBox173.Size = New System.Drawing.Size(489, 256)
        Me.GroupBox173.TabIndex = 5
        Me.GroupBox173.TabStop = False
        Me.GroupBox173.Text = "Cavity 1"
        '
        'btn_mark_flag
        '
        Me.btn_mark_flag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mark_flag.Location = New System.Drawing.Point(242, 169)
        Me.btn_mark_flag.Name = "btn_mark_flag"
        Me.btn_mark_flag.Size = New System.Drawing.Size(105, 28)
        Me.btn_mark_flag.TabIndex = 4
        Me.btn_mark_flag.Text = "Mark Flag"
        Me.btn_mark_flag.UseVisualStyleBackColor = True
        '
        'btn_change_prg
        '
        Me.btn_change_prg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change_prg.Location = New System.Drawing.Point(85, 202)
        Me.btn_change_prg.Name = "btn_change_prg"
        Me.btn_change_prg.Size = New System.Drawing.Size(148, 29)
        Me.btn_change_prg.TabIndex = 4
        Me.btn_change_prg.Text = "Change Program"
        Me.btn_change_prg.UseVisualStyleBackColor = True
        '
        'btn_start_marking
        '
        Me.btn_start_marking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_marking.Location = New System.Drawing.Point(242, 203)
        Me.btn_start_marking.Name = "btn_start_marking"
        Me.btn_start_marking.Size = New System.Drawing.Size(105, 28)
        Me.btn_start_marking.TabIndex = 4
        Me.btn_start_marking.Text = "Start Marking"
        Me.btn_start_marking.UseVisualStyleBackColor = True
        '
        'btn_string_char
        '
        Me.btn_string_char.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_string_char.Location = New System.Drawing.Point(85, 169)
        Me.btn_string_char.Name = "btn_string_char"
        Me.btn_string_char.Size = New System.Drawing.Size(148, 28)
        Me.btn_string_char.TabIndex = 4
        Me.btn_string_char.Text = "String Character"
        Me.btn_string_char.UseVisualStyleBackColor = True
        '
        'txt_block2
        '
        Me.txt_block2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block2.Location = New System.Drawing.Point(85, 135)
        Me.txt_block2.Name = "txt_block2"
        Me.txt_block2.Size = New System.Drawing.Size(310, 26)
        Me.txt_block2.TabIndex = 3
        '
        'txt_block1
        '
        Me.txt_block1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block1.Location = New System.Drawing.Point(85, 104)
        Me.txt_block1.Name = "txt_block1"
        Me.txt_block1.Size = New System.Drawing.Size(310, 26)
        Me.txt_block1.TabIndex = 3
        '
        'txt_block0
        '
        Me.txt_block0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block0.Location = New System.Drawing.Point(85, 73)
        Me.txt_block0.Name = "txt_block0"
        Me.txt_block0.Size = New System.Drawing.Size(310, 26)
        Me.txt_block0.TabIndex = 3
        '
        'Label232
        '
        Me.Label232.AutoSize = True
        Me.Label232.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label232.Location = New System.Drawing.Point(13, 138)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(69, 20)
        Me.Label232.TabIndex = 0
        Me.Label232.Text = "Block 2 :"
        '
        'chb_mark_cavity_1
        '
        Me.chb_mark_cavity_1.AutoSize = True
        Me.chb_mark_cavity_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_mark_cavity_1.Location = New System.Drawing.Point(295, 25)
        Me.chb_mark_cavity_1.Name = "chb_mark_cavity_1"
        Me.chb_mark_cavity_1.Size = New System.Drawing.Size(122, 24)
        Me.chb_mark_cavity_1.TabIndex = 2
        Me.chb_mark_cavity_1.Text = "Mark Cavity 1"
        Me.chb_mark_cavity_1.UseVisualStyleBackColor = True
        '
        'Label233
        '
        Me.Label233.AutoSize = True
        Me.Label233.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label233.Location = New System.Drawing.Point(13, 107)
        Me.Label233.Name = "Label233"
        Me.Label233.Size = New System.Drawing.Size(69, 20)
        Me.Label233.TabIndex = 0
        Me.Label233.Text = "Block 1 :"
        '
        'cb_prg_num
        '
        Me.cb_prg_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_prg_num.FormattingEnabled = True
        Me.cb_prg_num.Location = New System.Drawing.Point(151, 23)
        Me.cb_prg_num.Name = "cb_prg_num"
        Me.cb_prg_num.Size = New System.Drawing.Size(121, 28)
        Me.cb_prg_num.TabIndex = 1
        '
        'Label234
        '
        Me.Label234.AutoSize = True
        Me.Label234.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label234.Location = New System.Drawing.Point(13, 76)
        Me.Label234.Name = "Label234"
        Me.Label234.Size = New System.Drawing.Size(69, 20)
        Me.Label234.TabIndex = 0
        Me.Label234.Text = "Block 0 :"
        '
        'Label235
        '
        Me.Label235.AutoSize = True
        Me.Label235.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label235.Location = New System.Drawing.Point(13, 26)
        Me.Label235.Name = "Label235"
        Me.Label235.Size = New System.Drawing.Size(137, 20)
        Me.Label235.TabIndex = 0
        Me.Label235.Text = "Program Number :"
        '
        'pnl_multi
        '
        Me.pnl_multi.Controls.Add(Me.TabPage14)
        Me.pnl_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_multi.Location = New System.Drawing.Point(78, 97)
        Me.pnl_multi.Name = "pnl_multi"
        Me.pnl_multi.SelectedIndex = 0
        Me.pnl_multi.Size = New System.Drawing.Size(853, 563)
        Me.pnl_multi.TabIndex = 106
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.GroupBox170)
        Me.TabPage14.Location = New System.Drawing.Point(4, 38)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(845, 521)
        Me.TabPage14.TabIndex = 0
        Me.TabPage14.Text = "Multimeter"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'GroupBox170
        '
        Me.GroupBox170.Controls.Add(Me.Label229)
        Me.GroupBox170.Controls.Add(Me.Label230)
        Me.GroupBox170.Controls.Add(Me.txt_ch_1)
        Me.GroupBox170.Controls.Add(Me.btn_read_ch_2)
        Me.GroupBox170.Controls.Add(Me.btn_read_ch_1)
        Me.GroupBox170.Controls.Add(Me.txt_ch_2)
        Me.GroupBox170.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox170.Location = New System.Drawing.Point(305, 195)
        Me.GroupBox170.Name = "GroupBox170"
        Me.GroupBox170.Size = New System.Drawing.Size(235, 146)
        Me.GroupBox170.TabIndex = 61
        Me.GroupBox170.TabStop = False
        Me.GroupBox170.Text = "Measurement"
        '
        'Label229
        '
        Me.Label229.AutoSize = True
        Me.Label229.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label229.Location = New System.Drawing.Point(10, 33)
        Me.Label229.Name = "Label229"
        Me.Label229.Size = New System.Drawing.Size(89, 20)
        Me.Label229.TabIndex = 1
        Me.Label229.Text = "Channel 1 :"
        '
        'Label230
        '
        Me.Label230.AutoSize = True
        Me.Label230.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label230.Location = New System.Drawing.Point(11, 66)
        Me.Label230.Name = "Label230"
        Me.Label230.Size = New System.Drawing.Size(89, 20)
        Me.Label230.TabIndex = 1
        Me.Label230.Text = "Channel 2 :"
        '
        'txt_ch_1
        '
        Me.txt_ch_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ch_1.Location = New System.Drawing.Point(102, 30)
        Me.txt_ch_1.Name = "txt_ch_1"
        Me.txt_ch_1.Size = New System.Drawing.Size(123, 26)
        Me.txt_ch_1.TabIndex = 2
        '
        'btn_read_ch_2
        '
        Me.btn_read_ch_2.AutoSize = True
        Me.btn_read_ch_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read_ch_2.Location = New System.Drawing.Point(123, 98)
        Me.btn_read_ch_2.Name = "btn_read_ch_2"
        Me.btn_read_ch_2.Size = New System.Drawing.Size(102, 35)
        Me.btn_read_ch_2.TabIndex = 4
        Me.btn_read_ch_2.Text = "Read CH 2"
        Me.btn_read_ch_2.UseVisualStyleBackColor = True
        '
        'btn_read_ch_1
        '
        Me.btn_read_ch_1.AutoSize = True
        Me.btn_read_ch_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read_ch_1.Location = New System.Drawing.Point(12, 99)
        Me.btn_read_ch_1.Name = "btn_read_ch_1"
        Me.btn_read_ch_1.Size = New System.Drawing.Size(102, 35)
        Me.btn_read_ch_1.TabIndex = 4
        Me.btn_read_ch_1.Text = "Read CH 1"
        Me.btn_read_ch_1.UseVisualStyleBackColor = True
        '
        'txt_ch_2
        '
        Me.txt_ch_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ch_2.Location = New System.Drawing.Point(102, 63)
        Me.txt_ch_2.Name = "txt_ch_2"
        Me.txt_ch_2.Size = New System.Drawing.Size(123, 26)
        Me.txt_ch_2.TabIndex = 3
        '
        'pnl_alarm
        '
        Me.pnl_alarm.Controls.Add(Me.TabPage15)
        Me.pnl_alarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_alarm.Location = New System.Drawing.Point(78, 97)
        Me.pnl_alarm.Name = "pnl_alarm"
        Me.pnl_alarm.SelectedIndex = 0
        Me.pnl_alarm.Size = New System.Drawing.Size(853, 558)
        Me.pnl_alarm.TabIndex = 107
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(Me.GroupBox85)
        Me.TabPage15.Controls.Add(Me.GroupBox83)
        Me.TabPage15.Controls.Add(Me.GroupBox84)
        Me.TabPage15.Controls.Add(Me.GroupBox82)
        Me.TabPage15.Controls.Add(Me.GroupBox81)
        Me.TabPage15.Controls.Add(Me.GroupBox79)
        Me.TabPage15.Location = New System.Drawing.Point(4, 38)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(845, 516)
        Me.TabPage15.TabIndex = 0
        Me.TabPage15.Text = "Alarm"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'GroupBox85
        '
        Me.GroupBox85.Controls.Add(Me.ind_v602_descrepancy)
        Me.GroupBox85.Controls.Add(Me.Label94)
        Me.GroupBox85.Controls.Add(Me.ind_v601_descrepancy)
        Me.GroupBox85.Controls.Add(Me.Label96)
        Me.GroupBox85.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox85.Location = New System.Drawing.Point(437, 243)
        Me.GroupBox85.Name = "GroupBox85"
        Me.GroupBox85.Size = New System.Drawing.Size(216, 81)
        Me.GroupBox85.TabIndex = 57
        Me.GroupBox85.TabStop = False
        Me.GroupBox85.Text = "Alarm Station 6"
        '
        'ind_v602_descrepancy
        '
        Me.ind_v602_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v602_descrepancy.Location = New System.Drawing.Point(16, 51)
        Me.ind_v602_descrepancy.Name = "ind_v602_descrepancy"
        Me.ind_v602_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v602_descrepancy.TabIndex = 33
        Me.ind_v602_descrepancy.TabStop = False
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(37, 48)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(144, 20)
        Me.Label94.TabIndex = 31
        Me.Label94.Text = "V602 Descrepancy"
        '
        'ind_v601_descrepancy
        '
        Me.ind_v601_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v601_descrepancy.Location = New System.Drawing.Point(16, 30)
        Me.ind_v601_descrepancy.Name = "ind_v601_descrepancy"
        Me.ind_v601_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v601_descrepancy.TabIndex = 33
        Me.ind_v601_descrepancy.TabStop = False
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(37, 27)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(144, 20)
        Me.Label96.TabIndex = 31
        Me.Label96.Text = "V601 Descrepancy"
        '
        'GroupBox83
        '
        Me.GroupBox83.Controls.Add(Me.ind_v402_descrepancy)
        Me.GroupBox83.Controls.Add(Me.Label89)
        Me.GroupBox83.Controls.Add(Me.ind_v401_descrepancy)
        Me.GroupBox83.Controls.Add(Me.Label90)
        Me.GroupBox83.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox83.Location = New System.Drawing.Point(437, 69)
        Me.GroupBox83.Name = "GroupBox83"
        Me.GroupBox83.Size = New System.Drawing.Size(216, 81)
        Me.GroupBox83.TabIndex = 58
        Me.GroupBox83.TabStop = False
        Me.GroupBox83.Text = "Alarm Station 4"
        '
        'ind_v402_descrepancy
        '
        Me.ind_v402_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v402_descrepancy.Location = New System.Drawing.Point(16, 51)
        Me.ind_v402_descrepancy.Name = "ind_v402_descrepancy"
        Me.ind_v402_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v402_descrepancy.TabIndex = 33
        Me.ind_v402_descrepancy.TabStop = False
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(37, 48)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(144, 20)
        Me.Label89.TabIndex = 31
        Me.Label89.Text = "V402 Descrepancy"
        '
        'ind_v401_descrepancy
        '
        Me.ind_v401_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v401_descrepancy.Location = New System.Drawing.Point(16, 30)
        Me.ind_v401_descrepancy.Name = "ind_v401_descrepancy"
        Me.ind_v401_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v401_descrepancy.TabIndex = 33
        Me.ind_v401_descrepancy.TabStop = False
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(37, 27)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(144, 20)
        Me.Label90.TabIndex = 31
        Me.Label90.Text = "V401 Descrepancy"
        '
        'GroupBox84
        '
        Me.GroupBox84.Controls.Add(Me.ind_v502_descrepancy)
        Me.GroupBox84.Controls.Add(Me.Label92)
        Me.GroupBox84.Controls.Add(Me.ind_v501_descrepancy)
        Me.GroupBox84.Controls.Add(Me.Label93)
        Me.GroupBox84.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox84.Location = New System.Drawing.Point(437, 156)
        Me.GroupBox84.Name = "GroupBox84"
        Me.GroupBox84.Size = New System.Drawing.Size(216, 81)
        Me.GroupBox84.TabIndex = 59
        Me.GroupBox84.TabStop = False
        Me.GroupBox84.Text = "Alarm Station 5"
        '
        'ind_v502_descrepancy
        '
        Me.ind_v502_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v502_descrepancy.Location = New System.Drawing.Point(16, 51)
        Me.ind_v502_descrepancy.Name = "ind_v502_descrepancy"
        Me.ind_v502_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v502_descrepancy.TabIndex = 33
        Me.ind_v502_descrepancy.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(37, 48)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(144, 20)
        Me.Label92.TabIndex = 31
        Me.Label92.Text = "V502 Descrepancy"
        '
        'ind_v501_descrepancy
        '
        Me.ind_v501_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v501_descrepancy.Location = New System.Drawing.Point(16, 30)
        Me.ind_v501_descrepancy.Name = "ind_v501_descrepancy"
        Me.ind_v501_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v501_descrepancy.TabIndex = 33
        Me.ind_v501_descrepancy.TabStop = False
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(37, 27)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(144, 20)
        Me.Label93.TabIndex = 31
        Me.Label93.Text = "V501 Descrepancy"
        '
        'GroupBox82
        '
        Me.GroupBox82.Controls.Add(Me.ind_v302_descrepancy)
        Me.GroupBox82.Controls.Add(Me.Label87)
        Me.GroupBox82.Controls.Add(Me.ind_v301_descrepancy)
        Me.GroupBox82.Controls.Add(Me.Label88)
        Me.GroupBox82.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox82.Location = New System.Drawing.Point(192, 387)
        Me.GroupBox82.Name = "GroupBox82"
        Me.GroupBox82.Size = New System.Drawing.Size(216, 81)
        Me.GroupBox82.TabIndex = 60
        Me.GroupBox82.TabStop = False
        Me.GroupBox82.Text = "Alarm Station 3"
        '
        'ind_v302_descrepancy
        '
        Me.ind_v302_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v302_descrepancy.Location = New System.Drawing.Point(16, 51)
        Me.ind_v302_descrepancy.Name = "ind_v302_descrepancy"
        Me.ind_v302_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v302_descrepancy.TabIndex = 33
        Me.ind_v302_descrepancy.TabStop = False
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(37, 48)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(144, 20)
        Me.Label87.TabIndex = 31
        Me.Label87.Text = "V302 Descrepancy"
        '
        'ind_v301_descrepancy
        '
        Me.ind_v301_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v301_descrepancy.Location = New System.Drawing.Point(16, 30)
        Me.ind_v301_descrepancy.Name = "ind_v301_descrepancy"
        Me.ind_v301_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v301_descrepancy.TabIndex = 33
        Me.ind_v301_descrepancy.TabStop = False
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(37, 27)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(144, 20)
        Me.Label88.TabIndex = 31
        Me.Label88.Text = "V301 Descrepancy"
        '
        'GroupBox81
        '
        Me.GroupBox81.Controls.Add(Me.ind_v202_descrepancy)
        Me.GroupBox81.Controls.Add(Me.Label91)
        Me.GroupBox81.Controls.Add(Me.ind_v201_descrepancy)
        Me.GroupBox81.Controls.Add(Me.Label95)
        Me.GroupBox81.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox81.Location = New System.Drawing.Point(192, 300)
        Me.GroupBox81.Name = "GroupBox81"
        Me.GroupBox81.Size = New System.Drawing.Size(216, 81)
        Me.GroupBox81.TabIndex = 61
        Me.GroupBox81.TabStop = False
        Me.GroupBox81.Text = "Alarm Station 2"
        '
        'ind_v202_descrepancy
        '
        Me.ind_v202_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v202_descrepancy.Location = New System.Drawing.Point(16, 51)
        Me.ind_v202_descrepancy.Name = "ind_v202_descrepancy"
        Me.ind_v202_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v202_descrepancy.TabIndex = 33
        Me.ind_v202_descrepancy.TabStop = False
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(37, 48)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(144, 20)
        Me.Label91.TabIndex = 31
        Me.Label91.Text = "V202 Descrepancy"
        '
        'ind_v201_descrepancy
        '
        Me.ind_v201_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v201_descrepancy.Location = New System.Drawing.Point(16, 30)
        Me.ind_v201_descrepancy.Name = "ind_v201_descrepancy"
        Me.ind_v201_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v201_descrepancy.TabIndex = 33
        Me.ind_v201_descrepancy.TabStop = False
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(37, 27)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(144, 20)
        Me.Label95.TabIndex = 31
        Me.Label95.Text = "V201 Descrepancy"
        '
        'GroupBox79
        '
        Me.GroupBox79.Controls.Add(Me.ind_emg_button)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_6)
        Me.GroupBox79.Controls.Add(Me.ind_altivar_fault)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_4)
        Me.GroupBox79.Controls.Add(Me.Label79)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_2)
        Me.GroupBox79.Controls.Add(Me.Label78)
        Me.GroupBox79.Controls.Add(Me.Label76)
        Me.GroupBox79.Controls.Add(Me.Label74)
        Me.GroupBox79.Controls.Add(Me.ind_air_presence)
        Me.GroupBox79.Controls.Add(Me.Label70)
        Me.GroupBox79.Controls.Add(Me.Label77)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_5)
        Me.GroupBox79.Controls.Add(Me.Label75)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_3)
        Me.GroupBox79.Controls.Add(Me.Label73)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_1)
        Me.GroupBox79.Controls.Add(Me.Label69)
        Me.GroupBox79.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox79.Location = New System.Drawing.Point(192, 69)
        Me.GroupBox79.Name = "GroupBox79"
        Me.GroupBox79.Size = New System.Drawing.Size(216, 227)
        Me.GroupBox79.TabIndex = 62
        Me.GroupBox79.TabStop = False
        Me.GroupBox79.Text = "Alarm General"
        '
        'ind_emg_button
        '
        Me.ind_emg_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_emg_button.Location = New System.Drawing.Point(16, 198)
        Me.ind_emg_button.Name = "ind_emg_button"
        Me.ind_emg_button.Size = New System.Drawing.Size(15, 15)
        Me.ind_emg_button.TabIndex = 33
        Me.ind_emg_button.TabStop = False
        '
        'ind_door_lock_6
        '
        Me.ind_door_lock_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_door_lock_6.Location = New System.Drawing.Point(16, 135)
        Me.ind_door_lock_6.Name = "ind_door_lock_6"
        Me.ind_door_lock_6.Size = New System.Drawing.Size(15, 15)
        Me.ind_door_lock_6.TabIndex = 33
        Me.ind_door_lock_6.TabStop = False
        '
        'ind_altivar_fault
        '
        Me.ind_altivar_fault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_altivar_fault.Location = New System.Drawing.Point(16, 156)
        Me.ind_altivar_fault.Name = "ind_altivar_fault"
        Me.ind_altivar_fault.Size = New System.Drawing.Size(15, 15)
        Me.ind_altivar_fault.TabIndex = 33
        Me.ind_altivar_fault.TabStop = False
        '
        'ind_door_lock_4
        '
        Me.ind_door_lock_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_door_lock_4.Location = New System.Drawing.Point(16, 93)
        Me.ind_door_lock_4.Name = "ind_door_lock_4"
        Me.ind_door_lock_4.Size = New System.Drawing.Size(15, 15)
        Me.ind_door_lock_4.TabIndex = 33
        Me.ind_door_lock_4.TabStop = False
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(37, 195)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(168, 20)
        Me.Label79.TabIndex = 31
        Me.Label79.Text = "Emergency Button ON"
        '
        'ind_door_lock_2
        '
        Me.ind_door_lock_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_door_lock_2.Location = New System.Drawing.Point(16, 51)
        Me.ind_door_lock_2.Name = "ind_door_lock_2"
        Me.ind_door_lock_2.Size = New System.Drawing.Size(15, 15)
        Me.ind_door_lock_2.TabIndex = 33
        Me.ind_door_lock_2.TabStop = False
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(37, 153)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(92, 20)
        Me.Label78.TabIndex = 31
        Me.Label78.Text = "Altivar Fault"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(37, 132)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(138, 20)
        Me.Label76.TabIndex = 31
        Me.Label76.Text = "Door Lock 6 Open"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(37, 90)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(138, 20)
        Me.Label74.TabIndex = 31
        Me.Label74.Text = "Door Lock 4 Open"
        '
        'ind_air_presence
        '
        Me.ind_air_presence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_air_presence.Location = New System.Drawing.Point(16, 177)
        Me.ind_air_presence.Name = "ind_air_presence"
        Me.ind_air_presence.Size = New System.Drawing.Size(15, 15)
        Me.ind_air_presence.TabIndex = 33
        Me.ind_air_presence.TabStop = False
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(37, 48)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(138, 20)
        Me.Label70.TabIndex = 31
        Me.Label70.Text = "Door Lock 2 Open"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(37, 174)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(99, 20)
        Me.Label77.TabIndex = 31
        Me.Label77.Text = "Air Presence"
        '
        'ind_door_lock_5
        '
        Me.ind_door_lock_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_door_lock_5.Location = New System.Drawing.Point(16, 114)
        Me.ind_door_lock_5.Name = "ind_door_lock_5"
        Me.ind_door_lock_5.Size = New System.Drawing.Size(15, 15)
        Me.ind_door_lock_5.TabIndex = 33
        Me.ind_door_lock_5.TabStop = False
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(37, 111)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(138, 20)
        Me.Label75.TabIndex = 31
        Me.Label75.Text = "Door Lock 5 Open"
        '
        'ind_door_lock_3
        '
        Me.ind_door_lock_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_door_lock_3.Location = New System.Drawing.Point(16, 72)
        Me.ind_door_lock_3.Name = "ind_door_lock_3"
        Me.ind_door_lock_3.Size = New System.Drawing.Size(15, 15)
        Me.ind_door_lock_3.TabIndex = 33
        Me.ind_door_lock_3.TabStop = False
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(37, 69)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(138, 20)
        Me.Label73.TabIndex = 31
        Me.Label73.Text = "Door Lock 3 Open"
        '
        'ind_door_lock_1
        '
        Me.ind_door_lock_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_door_lock_1.Location = New System.Drawing.Point(16, 30)
        Me.ind_door_lock_1.Name = "ind_door_lock_1"
        Me.ind_door_lock_1.Size = New System.Drawing.Size(15, 15)
        Me.ind_door_lock_1.TabIndex = 33
        Me.ind_door_lock_1.TabStop = False
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(37, 27)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(138, 20)
        Me.Label69.TabIndex = 31
        Me.Label69.Text = "Door Lock 1 Open"
        '
        'pnl_mon_stn6
        '
        Me.pnl_mon_stn6.Controls.Add(Me.TabPage16)
        Me.pnl_mon_stn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_mon_stn6.Location = New System.Drawing.Point(78, 97)
        Me.pnl_mon_stn6.Name = "pnl_mon_stn6"
        Me.pnl_mon_stn6.SelectedIndex = 0
        Me.pnl_mon_stn6.Size = New System.Drawing.Size(853, 560)
        Me.pnl_mon_stn6.TabIndex = 108
        '
        'TabPage16
        '
        Me.TabPage16.Controls.Add(Me.GroupBox151)
        Me.TabPage16.Controls.Add(Me.GroupBox154)
        Me.TabPage16.Controls.Add(Me.GroupBox157)
        Me.TabPage16.Controls.Add(Me.GroupBox160)
        Me.TabPage16.Controls.Add(Me.GroupBox163)
        Me.TabPage16.Controls.Add(Me.GroupBox166)
        Me.TabPage16.Location = New System.Drawing.Point(4, 38)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage16.Size = New System.Drawing.Size(845, 518)
        Me.TabPage16.TabIndex = 0
        Me.TabPage16.Text = "Station 6"
        Me.TabPage16.UseVisualStyleBackColor = True
        '
        'GroupBox151
        '
        Me.GroupBox151.AutoSize = True
        Me.GroupBox151.Controls.Add(Me.GroupBox152)
        Me.GroupBox151.Controls.Add(Me.GroupBox153)
        Me.GroupBox151.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox151.Location = New System.Drawing.Point(566, 276)
        Me.GroupBox151.Name = "GroupBox151"
        Me.GroupBox151.Size = New System.Drawing.Size(215, 234)
        Me.GroupBox151.TabIndex = 65
        Me.GroupBox151.TabStop = False
        Me.GroupBox151.Text = "V606"
        Me.GroupBox151.Visible = False
        '
        'GroupBox152
        '
        Me.GroupBox152.Controls.Add(Me.Label201)
        Me.GroupBox152.Controls.Add(Me.Label202)
        Me.GroupBox152.Controls.Add(Me.mon_stn6_cyl6_min)
        Me.GroupBox152.Controls.Add(Me.mon_stn6_cyl6_max)
        Me.GroupBox152.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox152.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox152.Name = "GroupBox152"
        Me.GroupBox152.Size = New System.Drawing.Size(90, 165)
        Me.GroupBox152.TabIndex = 3
        Me.GroupBox152.TabStop = False
        Me.GroupBox152.Text = "Sensor"
        '
        'Label201
        '
        Me.Label201.AutoSize = True
        Me.Label201.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label201.Location = New System.Drawing.Point(6, 142)
        Me.Label201.Name = "Label201"
        Me.Label201.Size = New System.Drawing.Size(69, 18)
        Me.Label201.TabIndex = 1
        Me.Label201.Text = "Minimum"
        '
        'Label202
        '
        Me.Label202.AutoSize = True
        Me.Label202.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label202.Location = New System.Drawing.Point(6, 66)
        Me.Label202.Name = "Label202"
        Me.Label202.Size = New System.Drawing.Size(73, 18)
        Me.Label202.TabIndex = 1
        Me.Label202.Text = "Maximum"
        '
        'mon_stn6_cyl6_min
        '
        Me.mon_stn6_cyl6_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl6_min.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl6_min.Name = "mon_stn6_cyl6_min"
        Me.mon_stn6_cyl6_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl6_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl6_min.TabIndex = 0
        Me.mon_stn6_cyl6_min.TabStop = False
        '
        'mon_stn6_cyl6_max
        '
        Me.mon_stn6_cyl6_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl6_max.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl6_max.Name = "mon_stn6_cyl6_max"
        Me.mon_stn6_cyl6_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl6_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl6_max.TabIndex = 0
        Me.mon_stn6_cyl6_max.TabStop = False
        '
        'GroupBox153
        '
        Me.GroupBox153.Controls.Add(Me.Label214)
        Me.GroupBox153.Controls.Add(Me.mon_stn6_cyl6_fw)
        Me.GroupBox153.Controls.Add(Me.Label213)
        Me.GroupBox153.Controls.Add(Me.mon_stn6_cyl6_bw)
        Me.GroupBox153.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox153.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox153.Name = "GroupBox153"
        Me.GroupBox153.Size = New System.Drawing.Size(88, 165)
        Me.GroupBox153.TabIndex = 3
        Me.GroupBox153.TabStop = False
        Me.GroupBox153.Text = "Actuator"
        '
        'Label214
        '
        Me.Label214.AutoSize = True
        Me.Label214.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label214.Location = New System.Drawing.Point(13, 143)
        Me.Label214.Name = "Label214"
        Me.Label214.Size = New System.Drawing.Size(52, 18)
        Me.Label214.TabIndex = 1
        Me.Label214.Text = "Return"
        '
        'mon_stn6_cyl6_fw
        '
        Me.mon_stn6_cyl6_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl6_fw.Location = New System.Drawing.Point(0, 31)
        Me.mon_stn6_cyl6_fw.Name = "mon_stn6_cyl6_fw"
        Me.mon_stn6_cyl6_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl6_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl6_fw.TabIndex = 0
        Me.mon_stn6_cyl6_fw.TabStop = False
        '
        'Label213
        '
        Me.Label213.AutoSize = True
        Me.Label213.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label213.Location = New System.Drawing.Point(13, 67)
        Me.Label213.Name = "Label213"
        Me.Label213.Size = New System.Drawing.Size(53, 18)
        Me.Label213.TabIndex = 1
        Me.Label213.Text = "Extend"
        '
        'mon_stn6_cyl6_bw
        '
        Me.mon_stn6_cyl6_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl6_bw.Location = New System.Drawing.Point(0, 107)
        Me.mon_stn6_cyl6_bw.Name = "mon_stn6_cyl6_bw"
        Me.mon_stn6_cyl6_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl6_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl6_bw.TabIndex = 0
        Me.mon_stn6_cyl6_bw.TabStop = False
        '
        'GroupBox154
        '
        Me.GroupBox154.AutoSize = True
        Me.GroupBox154.Controls.Add(Me.GroupBox155)
        Me.GroupBox154.Controls.Add(Me.GroupBox156)
        Me.GroupBox154.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox154.Location = New System.Drawing.Point(315, 276)
        Me.GroupBox154.Name = "GroupBox154"
        Me.GroupBox154.Size = New System.Drawing.Size(215, 234)
        Me.GroupBox154.TabIndex = 66
        Me.GroupBox154.TabStop = False
        Me.GroupBox154.Text = "V605"
        '
        'GroupBox155
        '
        Me.GroupBox155.Controls.Add(Me.Label203)
        Me.GroupBox155.Controls.Add(Me.Label204)
        Me.GroupBox155.Controls.Add(Me.mon_stn6_cyl5_min)
        Me.GroupBox155.Controls.Add(Me.mon_stn6_cyl5_max)
        Me.GroupBox155.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox155.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox155.Name = "GroupBox155"
        Me.GroupBox155.Size = New System.Drawing.Size(90, 165)
        Me.GroupBox155.TabIndex = 3
        Me.GroupBox155.TabStop = False
        Me.GroupBox155.Text = "Sensor"
        '
        'Label203
        '
        Me.Label203.AutoSize = True
        Me.Label203.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label203.Location = New System.Drawing.Point(6, 142)
        Me.Label203.Name = "Label203"
        Me.Label203.Size = New System.Drawing.Size(69, 18)
        Me.Label203.TabIndex = 1
        Me.Label203.Text = "Minimum"
        '
        'Label204
        '
        Me.Label204.AutoSize = True
        Me.Label204.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label204.Location = New System.Drawing.Point(6, 66)
        Me.Label204.Name = "Label204"
        Me.Label204.Size = New System.Drawing.Size(73, 18)
        Me.Label204.TabIndex = 1
        Me.Label204.Text = "Maximum"
        '
        'mon_stn6_cyl5_min
        '
        Me.mon_stn6_cyl5_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl5_min.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl5_min.Name = "mon_stn6_cyl5_min"
        Me.mon_stn6_cyl5_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl5_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl5_min.TabIndex = 0
        Me.mon_stn6_cyl5_min.TabStop = False
        '
        'mon_stn6_cyl5_max
        '
        Me.mon_stn6_cyl5_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl5_max.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl5_max.Name = "mon_stn6_cyl5_max"
        Me.mon_stn6_cyl5_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl5_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl5_max.TabIndex = 0
        Me.mon_stn6_cyl5_max.TabStop = False
        '
        'GroupBox156
        '
        Me.GroupBox156.Controls.Add(Me.Label225)
        Me.GroupBox156.Controls.Add(Me.mon_stn6_cyl5_fw)
        Me.GroupBox156.Controls.Add(Me.Label224)
        Me.GroupBox156.Controls.Add(Me.mon_stn6_cyl5_bw)
        Me.GroupBox156.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox156.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox156.Name = "GroupBox156"
        Me.GroupBox156.Size = New System.Drawing.Size(88, 165)
        Me.GroupBox156.TabIndex = 3
        Me.GroupBox156.TabStop = False
        Me.GroupBox156.Text = "Actuator"
        '
        'Label225
        '
        Me.Label225.AutoSize = True
        Me.Label225.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label225.Location = New System.Drawing.Point(16, 143)
        Me.Label225.Name = "Label225"
        Me.Label225.Size = New System.Drawing.Size(52, 18)
        Me.Label225.TabIndex = 1
        Me.Label225.Text = "Return"
        '
        'mon_stn6_cyl5_fw
        '
        Me.mon_stn6_cyl5_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl5_fw.Location = New System.Drawing.Point(3, 31)
        Me.mon_stn6_cyl5_fw.Name = "mon_stn6_cyl5_fw"
        Me.mon_stn6_cyl5_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl5_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl5_fw.TabIndex = 0
        Me.mon_stn6_cyl5_fw.TabStop = False
        '
        'Label224
        '
        Me.Label224.AutoSize = True
        Me.Label224.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label224.Location = New System.Drawing.Point(16, 67)
        Me.Label224.Name = "Label224"
        Me.Label224.Size = New System.Drawing.Size(53, 18)
        Me.Label224.TabIndex = 1
        Me.Label224.Text = "Extend"
        '
        'mon_stn6_cyl5_bw
        '
        Me.mon_stn6_cyl5_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl5_bw.Location = New System.Drawing.Point(3, 107)
        Me.mon_stn6_cyl5_bw.Name = "mon_stn6_cyl5_bw"
        Me.mon_stn6_cyl5_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl5_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl5_bw.TabIndex = 0
        Me.mon_stn6_cyl5_bw.TabStop = False
        '
        'GroupBox157
        '
        Me.GroupBox157.AutoSize = True
        Me.GroupBox157.Controls.Add(Me.GroupBox158)
        Me.GroupBox157.Controls.Add(Me.GroupBox159)
        Me.GroupBox157.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox157.Location = New System.Drawing.Point(64, 276)
        Me.GroupBox157.Name = "GroupBox157"
        Me.GroupBox157.Size = New System.Drawing.Size(215, 234)
        Me.GroupBox157.TabIndex = 67
        Me.GroupBox157.TabStop = False
        Me.GroupBox157.Text = "V604"
        '
        'GroupBox158
        '
        Me.GroupBox158.Controls.Add(Me.Label205)
        Me.GroupBox158.Controls.Add(Me.Label206)
        Me.GroupBox158.Controls.Add(Me.mon_stn6_cyl4_min)
        Me.GroupBox158.Controls.Add(Me.mon_stn6_cyl4_max)
        Me.GroupBox158.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox158.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox158.Name = "GroupBox158"
        Me.GroupBox158.Size = New System.Drawing.Size(90, 165)
        Me.GroupBox158.TabIndex = 3
        Me.GroupBox158.TabStop = False
        Me.GroupBox158.Text = "Sensor"
        '
        'Label205
        '
        Me.Label205.AutoSize = True
        Me.Label205.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label205.Location = New System.Drawing.Point(6, 142)
        Me.Label205.Name = "Label205"
        Me.Label205.Size = New System.Drawing.Size(69, 18)
        Me.Label205.TabIndex = 1
        Me.Label205.Text = "Minimum"
        '
        'Label206
        '
        Me.Label206.AutoSize = True
        Me.Label206.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label206.Location = New System.Drawing.Point(6, 66)
        Me.Label206.Name = "Label206"
        Me.Label206.Size = New System.Drawing.Size(73, 18)
        Me.Label206.TabIndex = 1
        Me.Label206.Text = "Maximum"
        '
        'mon_stn6_cyl4_min
        '
        Me.mon_stn6_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl4_min.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl4_min.Name = "mon_stn6_cyl4_min"
        Me.mon_stn6_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl4_min.TabIndex = 0
        Me.mon_stn6_cyl4_min.TabStop = False
        '
        'mon_stn6_cyl4_max
        '
        Me.mon_stn6_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl4_max.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl4_max.Name = "mon_stn6_cyl4_max"
        Me.mon_stn6_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl4_max.TabIndex = 0
        Me.mon_stn6_cyl4_max.TabStop = False
        '
        'GroupBox159
        '
        Me.GroupBox159.Controls.Add(Me.Label223)
        Me.GroupBox159.Controls.Add(Me.mon_stn6_cyl4_fw)
        Me.GroupBox159.Controls.Add(Me.Label222)
        Me.GroupBox159.Controls.Add(Me.mon_stn6_cyl4_bw)
        Me.GroupBox159.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox159.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox159.Name = "GroupBox159"
        Me.GroupBox159.Size = New System.Drawing.Size(88, 165)
        Me.GroupBox159.TabIndex = 3
        Me.GroupBox159.TabStop = False
        Me.GroupBox159.Text = "Actuator"
        '
        'Label223
        '
        Me.Label223.AutoSize = True
        Me.Label223.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label223.Location = New System.Drawing.Point(19, 142)
        Me.Label223.Name = "Label223"
        Me.Label223.Size = New System.Drawing.Size(52, 18)
        Me.Label223.TabIndex = 1
        Me.Label223.Text = "Return"
        '
        'mon_stn6_cyl4_fw
        '
        Me.mon_stn6_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl4_fw.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl4_fw.Name = "mon_stn6_cyl4_fw"
        Me.mon_stn6_cyl4_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl4_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl4_fw.TabIndex = 0
        Me.mon_stn6_cyl4_fw.TabStop = False
        '
        'Label222
        '
        Me.Label222.AutoSize = True
        Me.Label222.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label222.Location = New System.Drawing.Point(19, 66)
        Me.Label222.Name = "Label222"
        Me.Label222.Size = New System.Drawing.Size(53, 18)
        Me.Label222.TabIndex = 1
        Me.Label222.Text = "Extend"
        '
        'mon_stn6_cyl4_bw
        '
        Me.mon_stn6_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl4_bw.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl4_bw.Name = "mon_stn6_cyl4_bw"
        Me.mon_stn6_cyl4_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl4_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl4_bw.TabIndex = 0
        Me.mon_stn6_cyl4_bw.TabStop = False
        '
        'GroupBox160
        '
        Me.GroupBox160.AutoSize = True
        Me.GroupBox160.Controls.Add(Me.GroupBox161)
        Me.GroupBox160.Controls.Add(Me.GroupBox162)
        Me.GroupBox160.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox160.Location = New System.Drawing.Point(566, 32)
        Me.GroupBox160.Name = "GroupBox160"
        Me.GroupBox160.Size = New System.Drawing.Size(215, 234)
        Me.GroupBox160.TabIndex = 68
        Me.GroupBox160.TabStop = False
        Me.GroupBox160.Text = "V603"
        '
        'GroupBox161
        '
        Me.GroupBox161.Controls.Add(Me.Label207)
        Me.GroupBox161.Controls.Add(Me.Label208)
        Me.GroupBox161.Controls.Add(Me.mon_stn6_cyl3_min)
        Me.GroupBox161.Controls.Add(Me.mon_stn6_cyl3_max)
        Me.GroupBox161.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox161.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox161.Name = "GroupBox161"
        Me.GroupBox161.Size = New System.Drawing.Size(90, 165)
        Me.GroupBox161.TabIndex = 3
        Me.GroupBox161.TabStop = False
        Me.GroupBox161.Text = "Sensor"
        '
        'Label207
        '
        Me.Label207.AutoSize = True
        Me.Label207.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label207.Location = New System.Drawing.Point(6, 142)
        Me.Label207.Name = "Label207"
        Me.Label207.Size = New System.Drawing.Size(69, 18)
        Me.Label207.TabIndex = 1
        Me.Label207.Text = "Minimum"
        '
        'Label208
        '
        Me.Label208.AutoSize = True
        Me.Label208.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label208.Location = New System.Drawing.Point(6, 66)
        Me.Label208.Name = "Label208"
        Me.Label208.Size = New System.Drawing.Size(73, 18)
        Me.Label208.TabIndex = 1
        Me.Label208.Text = "Maximum"
        '
        'mon_stn6_cyl3_min
        '
        Me.mon_stn6_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl3_min.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl3_min.Name = "mon_stn6_cyl3_min"
        Me.mon_stn6_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl3_min.TabIndex = 0
        Me.mon_stn6_cyl3_min.TabStop = False
        '
        'mon_stn6_cyl3_max
        '
        Me.mon_stn6_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl3_max.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl3_max.Name = "mon_stn6_cyl3_max"
        Me.mon_stn6_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl3_max.TabIndex = 0
        Me.mon_stn6_cyl3_max.TabStop = False
        '
        'GroupBox162
        '
        Me.GroupBox162.Controls.Add(Me.Label216)
        Me.GroupBox162.Controls.Add(Me.mon_stn6_cyl3_fw)
        Me.GroupBox162.Controls.Add(Me.Label215)
        Me.GroupBox162.Controls.Add(Me.mon_stn6_cyl3_bw)
        Me.GroupBox162.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox162.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox162.Name = "GroupBox162"
        Me.GroupBox162.Size = New System.Drawing.Size(88, 165)
        Me.GroupBox162.TabIndex = 3
        Me.GroupBox162.TabStop = False
        Me.GroupBox162.Text = "Actuator"
        '
        'Label216
        '
        Me.Label216.AutoSize = True
        Me.Label216.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label216.Location = New System.Drawing.Point(14, 142)
        Me.Label216.Name = "Label216"
        Me.Label216.Size = New System.Drawing.Size(52, 18)
        Me.Label216.TabIndex = 1
        Me.Label216.Text = "Return"
        '
        'mon_stn6_cyl3_fw
        '
        Me.mon_stn6_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl3_fw.Location = New System.Drawing.Point(1, 30)
        Me.mon_stn6_cyl3_fw.Name = "mon_stn6_cyl3_fw"
        Me.mon_stn6_cyl3_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl3_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl3_fw.TabIndex = 0
        Me.mon_stn6_cyl3_fw.TabStop = False
        '
        'Label215
        '
        Me.Label215.AutoSize = True
        Me.Label215.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label215.Location = New System.Drawing.Point(14, 66)
        Me.Label215.Name = "Label215"
        Me.Label215.Size = New System.Drawing.Size(53, 18)
        Me.Label215.TabIndex = 1
        Me.Label215.Text = "Extend"
        '
        'mon_stn6_cyl3_bw
        '
        Me.mon_stn6_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl3_bw.Location = New System.Drawing.Point(1, 106)
        Me.mon_stn6_cyl3_bw.Name = "mon_stn6_cyl3_bw"
        Me.mon_stn6_cyl3_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl3_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl3_bw.TabIndex = 0
        Me.mon_stn6_cyl3_bw.TabStop = False
        '
        'GroupBox163
        '
        Me.GroupBox163.AutoSize = True
        Me.GroupBox163.Controls.Add(Me.GroupBox164)
        Me.GroupBox163.Controls.Add(Me.GroupBox165)
        Me.GroupBox163.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox163.Location = New System.Drawing.Point(315, 32)
        Me.GroupBox163.Name = "GroupBox163"
        Me.GroupBox163.Size = New System.Drawing.Size(215, 234)
        Me.GroupBox163.TabIndex = 69
        Me.GroupBox163.TabStop = False
        Me.GroupBox163.Text = "V602"
        '
        'GroupBox164
        '
        Me.GroupBox164.Controls.Add(Me.Label209)
        Me.GroupBox164.Controls.Add(Me.Label210)
        Me.GroupBox164.Controls.Add(Me.mon_stn6_cyl2_min)
        Me.GroupBox164.Controls.Add(Me.mon_stn6_cyl2_max)
        Me.GroupBox164.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox164.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox164.Name = "GroupBox164"
        Me.GroupBox164.Size = New System.Drawing.Size(90, 165)
        Me.GroupBox164.TabIndex = 3
        Me.GroupBox164.TabStop = False
        Me.GroupBox164.Text = "Sensor"
        '
        'Label209
        '
        Me.Label209.AutoSize = True
        Me.Label209.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label209.Location = New System.Drawing.Point(6, 142)
        Me.Label209.Name = "Label209"
        Me.Label209.Size = New System.Drawing.Size(69, 18)
        Me.Label209.TabIndex = 1
        Me.Label209.Text = "Minimum"
        '
        'Label210
        '
        Me.Label210.AutoSize = True
        Me.Label210.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label210.Location = New System.Drawing.Point(6, 66)
        Me.Label210.Name = "Label210"
        Me.Label210.Size = New System.Drawing.Size(73, 18)
        Me.Label210.TabIndex = 1
        Me.Label210.Text = "Maximum"
        '
        'mon_stn6_cyl2_min
        '
        Me.mon_stn6_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl2_min.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl2_min.Name = "mon_stn6_cyl2_min"
        Me.mon_stn6_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl2_min.TabIndex = 0
        Me.mon_stn6_cyl2_min.TabStop = False
        '
        'mon_stn6_cyl2_max
        '
        Me.mon_stn6_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl2_max.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl2_max.Name = "mon_stn6_cyl2_max"
        Me.mon_stn6_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl2_max.TabIndex = 0
        Me.mon_stn6_cyl2_max.TabStop = False
        '
        'GroupBox165
        '
        Me.GroupBox165.Controls.Add(Me.Label219)
        Me.GroupBox165.Controls.Add(Me.mon_stn6_cyl2_fw)
        Me.GroupBox165.Controls.Add(Me.Label218)
        Me.GroupBox165.Controls.Add(Me.mon_stn6_cyl2_bw)
        Me.GroupBox165.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox165.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox165.Name = "GroupBox165"
        Me.GroupBox165.Size = New System.Drawing.Size(88, 165)
        Me.GroupBox165.TabIndex = 3
        Me.GroupBox165.TabStop = False
        Me.GroupBox165.Text = "Actuator"
        '
        'Label219
        '
        Me.Label219.AutoSize = True
        Me.Label219.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label219.Location = New System.Drawing.Point(14, 142)
        Me.Label219.Name = "Label219"
        Me.Label219.Size = New System.Drawing.Size(52, 18)
        Me.Label219.TabIndex = 1
        Me.Label219.Text = "Return"
        '
        'mon_stn6_cyl2_fw
        '
        Me.mon_stn6_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl2_fw.Location = New System.Drawing.Point(1, 30)
        Me.mon_stn6_cyl2_fw.Name = "mon_stn6_cyl2_fw"
        Me.mon_stn6_cyl2_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl2_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl2_fw.TabIndex = 0
        Me.mon_stn6_cyl2_fw.TabStop = False
        '
        'Label218
        '
        Me.Label218.AutoSize = True
        Me.Label218.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label218.Location = New System.Drawing.Point(14, 66)
        Me.Label218.Name = "Label218"
        Me.Label218.Size = New System.Drawing.Size(53, 18)
        Me.Label218.TabIndex = 1
        Me.Label218.Text = "Extend"
        '
        'mon_stn6_cyl2_bw
        '
        Me.mon_stn6_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl2_bw.Location = New System.Drawing.Point(1, 106)
        Me.mon_stn6_cyl2_bw.Name = "mon_stn6_cyl2_bw"
        Me.mon_stn6_cyl2_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl2_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl2_bw.TabIndex = 0
        Me.mon_stn6_cyl2_bw.TabStop = False
        '
        'GroupBox166
        '
        Me.GroupBox166.AutoSize = True
        Me.GroupBox166.Controls.Add(Me.GroupBox167)
        Me.GroupBox166.Controls.Add(Me.GroupBox168)
        Me.GroupBox166.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox166.Location = New System.Drawing.Point(64, 32)
        Me.GroupBox166.Name = "GroupBox166"
        Me.GroupBox166.Size = New System.Drawing.Size(215, 234)
        Me.GroupBox166.TabIndex = 70
        Me.GroupBox166.TabStop = False
        Me.GroupBox166.Text = "V601"
        '
        'GroupBox167
        '
        Me.GroupBox167.Controls.Add(Me.Label211)
        Me.GroupBox167.Controls.Add(Me.Label212)
        Me.GroupBox167.Controls.Add(Me.mon_stn6_cyl1_min)
        Me.GroupBox167.Controls.Add(Me.mon_stn6_cyl1_max)
        Me.GroupBox167.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox167.Location = New System.Drawing.Point(107, 37)
        Me.GroupBox167.Name = "GroupBox167"
        Me.GroupBox167.Size = New System.Drawing.Size(90, 165)
        Me.GroupBox167.TabIndex = 3
        Me.GroupBox167.TabStop = False
        Me.GroupBox167.Text = "Sensor"
        '
        'Label211
        '
        Me.Label211.AutoSize = True
        Me.Label211.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label211.Location = New System.Drawing.Point(6, 142)
        Me.Label211.Name = "Label211"
        Me.Label211.Size = New System.Drawing.Size(69, 18)
        Me.Label211.TabIndex = 1
        Me.Label211.Text = "Minimum"
        '
        'Label212
        '
        Me.Label212.AutoSize = True
        Me.Label212.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label212.Location = New System.Drawing.Point(6, 66)
        Me.Label212.Name = "Label212"
        Me.Label212.Size = New System.Drawing.Size(73, 18)
        Me.Label212.TabIndex = 1
        Me.Label212.Text = "Maximum"
        '
        'mon_stn6_cyl1_min
        '
        Me.mon_stn6_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl1_min.Location = New System.Drawing.Point(6, 106)
        Me.mon_stn6_cyl1_min.Name = "mon_stn6_cyl1_min"
        Me.mon_stn6_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl1_min.TabIndex = 0
        Me.mon_stn6_cyl1_min.TabStop = False
        '
        'mon_stn6_cyl1_max
        '
        Me.mon_stn6_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl1_max.Location = New System.Drawing.Point(6, 30)
        Me.mon_stn6_cyl1_max.Name = "mon_stn6_cyl1_max"
        Me.mon_stn6_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl1_max.TabIndex = 0
        Me.mon_stn6_cyl1_max.TabStop = False
        '
        'GroupBox168
        '
        Me.GroupBox168.Controls.Add(Me.Label221)
        Me.GroupBox168.Controls.Add(Me.mon_stn6_cyl1_fw)
        Me.GroupBox168.Controls.Add(Me.Label220)
        Me.GroupBox168.Controls.Add(Me.mon_stn6_cyl1_bw)
        Me.GroupBox168.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox168.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox168.Name = "GroupBox168"
        Me.GroupBox168.Size = New System.Drawing.Size(88, 165)
        Me.GroupBox168.TabIndex = 3
        Me.GroupBox168.TabStop = False
        Me.GroupBox168.Text = "Actuator"
        '
        'Label221
        '
        Me.Label221.AutoSize = True
        Me.Label221.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label221.Location = New System.Drawing.Point(20, 142)
        Me.Label221.Name = "Label221"
        Me.Label221.Size = New System.Drawing.Size(52, 18)
        Me.Label221.TabIndex = 1
        Me.Label221.Text = "Return"
        '
        'mon_stn6_cyl1_fw
        '
        Me.mon_stn6_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl1_fw.Location = New System.Drawing.Point(7, 30)
        Me.mon_stn6_cyl1_fw.Name = "mon_stn6_cyl1_fw"
        Me.mon_stn6_cyl1_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl1_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl1_fw.TabIndex = 0
        Me.mon_stn6_cyl1_fw.TabStop = False
        '
        'Label220
        '
        Me.Label220.AutoSize = True
        Me.Label220.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label220.Location = New System.Drawing.Point(20, 66)
        Me.Label220.Name = "Label220"
        Me.Label220.Size = New System.Drawing.Size(53, 18)
        Me.Label220.TabIndex = 1
        Me.Label220.Text = "Extend"
        '
        'mon_stn6_cyl1_bw
        '
        Me.mon_stn6_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn6_cyl1_bw.Location = New System.Drawing.Point(7, 106)
        Me.mon_stn6_cyl1_bw.Name = "mon_stn6_cyl1_bw"
        Me.mon_stn6_cyl1_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn6_cyl1_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn6_cyl1_bw.TabIndex = 0
        Me.mon_stn6_cyl1_bw.TabStop = False
        '
        'pnl_mon_stn5
        '
        Me.pnl_mon_stn5.Controls.Add(Me.TabPage17)
        Me.pnl_mon_stn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_mon_stn5.Location = New System.Drawing.Point(78, 97)
        Me.pnl_mon_stn5.Name = "pnl_mon_stn5"
        Me.pnl_mon_stn5.SelectedIndex = 0
        Me.pnl_mon_stn5.Size = New System.Drawing.Size(851, 563)
        Me.pnl_mon_stn5.TabIndex = 109
        '
        'TabPage17
        '
        Me.TabPage17.Controls.Add(Me.GroupBox139)
        Me.TabPage17.Controls.Add(Me.GroupBox142)
        Me.TabPage17.Controls.Add(Me.GroupBox145)
        Me.TabPage17.Controls.Add(Me.GroupBox148)
        Me.TabPage17.Location = New System.Drawing.Point(4, 38)
        Me.TabPage17.Name = "TabPage17"
        Me.TabPage17.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage17.Size = New System.Drawing.Size(843, 521)
        Me.TabPage17.TabIndex = 0
        Me.TabPage17.Text = "Station 5"
        Me.TabPage17.UseVisualStyleBackColor = True
        '
        'GroupBox139
        '
        Me.GroupBox139.AutoSize = True
        Me.GroupBox139.Controls.Add(Me.GroupBox140)
        Me.GroupBox139.Controls.Add(Me.GroupBox141)
        Me.GroupBox139.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox139.Location = New System.Drawing.Point(459, 273)
        Me.GroupBox139.Name = "GroupBox139"
        Me.GroupBox139.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox139.TabIndex = 63
        Me.GroupBox139.TabStop = False
        Me.GroupBox139.Text = "V504"
        '
        'GroupBox140
        '
        Me.GroupBox140.Controls.Add(Me.Label184)
        Me.GroupBox140.Controls.Add(Me.Label185)
        Me.GroupBox140.Controls.Add(Me.mon_stn5_cyl4_min)
        Me.GroupBox140.Controls.Add(Me.mon_stn5_cyl4_max)
        Me.GroupBox140.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox140.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox140.Name = "GroupBox140"
        Me.GroupBox140.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox140.TabIndex = 3
        Me.GroupBox140.TabStop = False
        Me.GroupBox140.Text = "Sensor"
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label184.Location = New System.Drawing.Point(20, 142)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(69, 18)
        Me.Label184.TabIndex = 1
        Me.Label184.Text = "Minimum"
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label185.Location = New System.Drawing.Point(20, 66)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(73, 18)
        Me.Label185.TabIndex = 1
        Me.Label185.Text = "Maximum"
        '
        'mon_stn5_cyl4_min
        '
        Me.mon_stn5_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn5_cyl4_min.Name = "mon_stn5_cyl4_min"
        Me.mon_stn5_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl4_min.TabIndex = 0
        Me.mon_stn5_cyl4_min.TabStop = False
        '
        'mon_stn5_cyl4_max
        '
        Me.mon_stn5_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn5_cyl4_max.Name = "mon_stn5_cyl4_max"
        Me.mon_stn5_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl4_max.TabIndex = 0
        Me.mon_stn5_cyl4_max.TabStop = False
        '
        'GroupBox141
        '
        Me.GroupBox141.Controls.Add(Me.Label186)
        Me.GroupBox141.Controls.Add(Me.mon_stn5_cyl4_fw)
        Me.GroupBox141.Controls.Add(Me.Label187)
        Me.GroupBox141.Controls.Add(Me.mon_stn5_cyl4_bw)
        Me.GroupBox141.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox141.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox141.Name = "GroupBox141"
        Me.GroupBox141.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox141.TabIndex = 3
        Me.GroupBox141.TabStop = False
        Me.GroupBox141.Text = "Actuator"
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label186.Location = New System.Drawing.Point(35, 142)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(52, 18)
        Me.Label186.TabIndex = 1
        Me.Label186.Text = "Return"
        '
        'mon_stn5_cyl4_fw
        '
        Me.mon_stn5_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl4_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn5_cyl4_fw.Name = "mon_stn5_cyl4_fw"
        Me.mon_stn5_cyl4_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl4_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl4_fw.TabIndex = 0
        Me.mon_stn5_cyl4_fw.TabStop = False
        '
        'Label187
        '
        Me.Label187.AutoSize = True
        Me.Label187.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label187.Location = New System.Drawing.Point(35, 66)
        Me.Label187.Name = "Label187"
        Me.Label187.Size = New System.Drawing.Size(53, 18)
        Me.Label187.TabIndex = 1
        Me.Label187.Text = "Extend"
        '
        'mon_stn5_cyl4_bw
        '
        Me.mon_stn5_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl4_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn5_cyl4_bw.Name = "mon_stn5_cyl4_bw"
        Me.mon_stn5_cyl4_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl4_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl4_bw.TabIndex = 0
        Me.mon_stn5_cyl4_bw.TabStop = False
        '
        'GroupBox142
        '
        Me.GroupBox142.AutoSize = True
        Me.GroupBox142.Controls.Add(Me.GroupBox143)
        Me.GroupBox142.Controls.Add(Me.GroupBox144)
        Me.GroupBox142.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox142.Location = New System.Drawing.Point(458, 30)
        Me.GroupBox142.Name = "GroupBox142"
        Me.GroupBox142.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox142.TabIndex = 64
        Me.GroupBox142.TabStop = False
        Me.GroupBox142.Text = "V502"
        '
        'GroupBox143
        '
        Me.GroupBox143.Controls.Add(Me.Label188)
        Me.GroupBox143.Controls.Add(Me.Label189)
        Me.GroupBox143.Controls.Add(Me.mon_stn5_cyl2_min)
        Me.GroupBox143.Controls.Add(Me.mon_stn5_cyl2_max)
        Me.GroupBox143.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox143.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox143.Name = "GroupBox143"
        Me.GroupBox143.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox143.TabIndex = 3
        Me.GroupBox143.TabStop = False
        Me.GroupBox143.Text = "Sensor"
        '
        'Label188
        '
        Me.Label188.AutoSize = True
        Me.Label188.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label188.Location = New System.Drawing.Point(20, 142)
        Me.Label188.Name = "Label188"
        Me.Label188.Size = New System.Drawing.Size(69, 18)
        Me.Label188.TabIndex = 1
        Me.Label188.Text = "Minimum"
        '
        'Label189
        '
        Me.Label189.AutoSize = True
        Me.Label189.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label189.Location = New System.Drawing.Point(20, 66)
        Me.Label189.Name = "Label189"
        Me.Label189.Size = New System.Drawing.Size(73, 18)
        Me.Label189.TabIndex = 1
        Me.Label189.Text = "Maximum"
        '
        'mon_stn5_cyl2_min
        '
        Me.mon_stn5_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn5_cyl2_min.Name = "mon_stn5_cyl2_min"
        Me.mon_stn5_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl2_min.TabIndex = 0
        Me.mon_stn5_cyl2_min.TabStop = False
        '
        'mon_stn5_cyl2_max
        '
        Me.mon_stn5_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn5_cyl2_max.Name = "mon_stn5_cyl2_max"
        Me.mon_stn5_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl2_max.TabIndex = 0
        Me.mon_stn5_cyl2_max.TabStop = False
        '
        'GroupBox144
        '
        Me.GroupBox144.Controls.Add(Me.Label190)
        Me.GroupBox144.Controls.Add(Me.mon_stn5_cyl2_fw)
        Me.GroupBox144.Controls.Add(Me.Label191)
        Me.GroupBox144.Controls.Add(Me.mon_stn5_cyl2_bw)
        Me.GroupBox144.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox144.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox144.Name = "GroupBox144"
        Me.GroupBox144.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox144.TabIndex = 3
        Me.GroupBox144.TabStop = False
        Me.GroupBox144.Text = "Actuator"
        '
        'Label190
        '
        Me.Label190.AutoSize = True
        Me.Label190.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label190.Location = New System.Drawing.Point(35, 142)
        Me.Label190.Name = "Label190"
        Me.Label190.Size = New System.Drawing.Size(52, 18)
        Me.Label190.TabIndex = 1
        Me.Label190.Text = "Return"
        '
        'mon_stn5_cyl2_fw
        '
        Me.mon_stn5_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl2_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn5_cyl2_fw.Name = "mon_stn5_cyl2_fw"
        Me.mon_stn5_cyl2_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl2_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl2_fw.TabIndex = 0
        Me.mon_stn5_cyl2_fw.TabStop = False
        '
        'Label191
        '
        Me.Label191.AutoSize = True
        Me.Label191.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label191.Location = New System.Drawing.Point(35, 66)
        Me.Label191.Name = "Label191"
        Me.Label191.Size = New System.Drawing.Size(53, 18)
        Me.Label191.TabIndex = 1
        Me.Label191.Text = "Extend"
        '
        'mon_stn5_cyl2_bw
        '
        Me.mon_stn5_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl2_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn5_cyl2_bw.Name = "mon_stn5_cyl2_bw"
        Me.mon_stn5_cyl2_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl2_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl2_bw.TabIndex = 0
        Me.mon_stn5_cyl2_bw.TabStop = False
        '
        'GroupBox145
        '
        Me.GroupBox145.AutoSize = True
        Me.GroupBox145.Controls.Add(Me.GroupBox146)
        Me.GroupBox145.Controls.Add(Me.GroupBox147)
        Me.GroupBox145.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox145.Location = New System.Drawing.Point(93, 273)
        Me.GroupBox145.Name = "GroupBox145"
        Me.GroupBox145.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox145.TabIndex = 65
        Me.GroupBox145.TabStop = False
        Me.GroupBox145.Text = "V503"
        '
        'GroupBox146
        '
        Me.GroupBox146.Controls.Add(Me.Label192)
        Me.GroupBox146.Controls.Add(Me.Label193)
        Me.GroupBox146.Controls.Add(Me.mon_stn5_cyl3_min)
        Me.GroupBox146.Controls.Add(Me.mon_stn5_cyl3_max)
        Me.GroupBox146.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox146.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox146.Name = "GroupBox146"
        Me.GroupBox146.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox146.TabIndex = 3
        Me.GroupBox146.TabStop = False
        Me.GroupBox146.Text = "Sensor"
        '
        'Label192
        '
        Me.Label192.AutoSize = True
        Me.Label192.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label192.Location = New System.Drawing.Point(20, 142)
        Me.Label192.Name = "Label192"
        Me.Label192.Size = New System.Drawing.Size(69, 18)
        Me.Label192.TabIndex = 1
        Me.Label192.Text = "Minimum"
        '
        'Label193
        '
        Me.Label193.AutoSize = True
        Me.Label193.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label193.Location = New System.Drawing.Point(20, 66)
        Me.Label193.Name = "Label193"
        Me.Label193.Size = New System.Drawing.Size(73, 18)
        Me.Label193.TabIndex = 1
        Me.Label193.Text = "Maximum"
        '
        'mon_stn5_cyl3_min
        '
        Me.mon_stn5_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn5_cyl3_min.Name = "mon_stn5_cyl3_min"
        Me.mon_stn5_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl3_min.TabIndex = 0
        Me.mon_stn5_cyl3_min.TabStop = False
        '
        'mon_stn5_cyl3_max
        '
        Me.mon_stn5_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn5_cyl3_max.Name = "mon_stn5_cyl3_max"
        Me.mon_stn5_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl3_max.TabIndex = 0
        Me.mon_stn5_cyl3_max.TabStop = False
        '
        'GroupBox147
        '
        Me.GroupBox147.Controls.Add(Me.Label194)
        Me.GroupBox147.Controls.Add(Me.mon_stn5_cyl3_fw)
        Me.GroupBox147.Controls.Add(Me.Label195)
        Me.GroupBox147.Controls.Add(Me.mon_stn5_cyl3_bw)
        Me.GroupBox147.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox147.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox147.Name = "GroupBox147"
        Me.GroupBox147.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox147.TabIndex = 3
        Me.GroupBox147.TabStop = False
        Me.GroupBox147.Text = "Actuator"
        '
        'Label194
        '
        Me.Label194.AutoSize = True
        Me.Label194.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label194.Location = New System.Drawing.Point(35, 142)
        Me.Label194.Name = "Label194"
        Me.Label194.Size = New System.Drawing.Size(52, 18)
        Me.Label194.TabIndex = 1
        Me.Label194.Text = "Return"
        '
        'mon_stn5_cyl3_fw
        '
        Me.mon_stn5_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl3_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn5_cyl3_fw.Name = "mon_stn5_cyl3_fw"
        Me.mon_stn5_cyl3_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl3_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl3_fw.TabIndex = 0
        Me.mon_stn5_cyl3_fw.TabStop = False
        '
        'Label195
        '
        Me.Label195.AutoSize = True
        Me.Label195.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label195.Location = New System.Drawing.Point(35, 66)
        Me.Label195.Name = "Label195"
        Me.Label195.Size = New System.Drawing.Size(53, 18)
        Me.Label195.TabIndex = 1
        Me.Label195.Text = "Extend"
        '
        'mon_stn5_cyl3_bw
        '
        Me.mon_stn5_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl3_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn5_cyl3_bw.Name = "mon_stn5_cyl3_bw"
        Me.mon_stn5_cyl3_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl3_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl3_bw.TabIndex = 0
        Me.mon_stn5_cyl3_bw.TabStop = False
        '
        'GroupBox148
        '
        Me.GroupBox148.AutoSize = True
        Me.GroupBox148.Controls.Add(Me.GroupBox149)
        Me.GroupBox148.Controls.Add(Me.GroupBox150)
        Me.GroupBox148.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox148.Location = New System.Drawing.Point(92, 30)
        Me.GroupBox148.Name = "GroupBox148"
        Me.GroupBox148.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox148.TabIndex = 66
        Me.GroupBox148.TabStop = False
        Me.GroupBox148.Text = "V501"
        '
        'GroupBox149
        '
        Me.GroupBox149.Controls.Add(Me.Label196)
        Me.GroupBox149.Controls.Add(Me.Label197)
        Me.GroupBox149.Controls.Add(Me.mon_stn5_cyl1_min)
        Me.GroupBox149.Controls.Add(Me.mon_stn5_cyl1_max)
        Me.GroupBox149.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox149.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox149.Name = "GroupBox149"
        Me.GroupBox149.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox149.TabIndex = 3
        Me.GroupBox149.TabStop = False
        Me.GroupBox149.Text = "Sensor"
        '
        'Label196
        '
        Me.Label196.AutoSize = True
        Me.Label196.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label196.Location = New System.Drawing.Point(20, 142)
        Me.Label196.Name = "Label196"
        Me.Label196.Size = New System.Drawing.Size(69, 18)
        Me.Label196.TabIndex = 1
        Me.Label196.Text = "Minimum"
        '
        'Label197
        '
        Me.Label197.AutoSize = True
        Me.Label197.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label197.Location = New System.Drawing.Point(20, 66)
        Me.Label197.Name = "Label197"
        Me.Label197.Size = New System.Drawing.Size(73, 18)
        Me.Label197.TabIndex = 1
        Me.Label197.Text = "Maximum"
        '
        'mon_stn5_cyl1_min
        '
        Me.mon_stn5_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn5_cyl1_min.Name = "mon_stn5_cyl1_min"
        Me.mon_stn5_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl1_min.TabIndex = 0
        Me.mon_stn5_cyl1_min.TabStop = False
        '
        'mon_stn5_cyl1_max
        '
        Me.mon_stn5_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn5_cyl1_max.Name = "mon_stn5_cyl1_max"
        Me.mon_stn5_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl1_max.TabIndex = 0
        Me.mon_stn5_cyl1_max.TabStop = False
        '
        'GroupBox150
        '
        Me.GroupBox150.Controls.Add(Me.Label198)
        Me.GroupBox150.Controls.Add(Me.mon_stn5_cyl1_fw)
        Me.GroupBox150.Controls.Add(Me.Label199)
        Me.GroupBox150.Controls.Add(Me.mon_stn5_cyl1_bw)
        Me.GroupBox150.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox150.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox150.Name = "GroupBox150"
        Me.GroupBox150.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox150.TabIndex = 3
        Me.GroupBox150.TabStop = False
        Me.GroupBox150.Text = "Actuator"
        '
        'Label198
        '
        Me.Label198.AutoSize = True
        Me.Label198.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label198.Location = New System.Drawing.Point(35, 142)
        Me.Label198.Name = "Label198"
        Me.Label198.Size = New System.Drawing.Size(52, 18)
        Me.Label198.TabIndex = 1
        Me.Label198.Text = "Return"
        '
        'mon_stn5_cyl1_fw
        '
        Me.mon_stn5_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl1_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn5_cyl1_fw.Name = "mon_stn5_cyl1_fw"
        Me.mon_stn5_cyl1_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl1_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl1_fw.TabIndex = 0
        Me.mon_stn5_cyl1_fw.TabStop = False
        '
        'Label199
        '
        Me.Label199.AutoSize = True
        Me.Label199.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label199.Location = New System.Drawing.Point(35, 66)
        Me.Label199.Name = "Label199"
        Me.Label199.Size = New System.Drawing.Size(53, 18)
        Me.Label199.TabIndex = 1
        Me.Label199.Text = "Extend"
        '
        'mon_stn5_cyl1_bw
        '
        Me.mon_stn5_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn5_cyl1_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn5_cyl1_bw.Name = "mon_stn5_cyl1_bw"
        Me.mon_stn5_cyl1_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn5_cyl1_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn5_cyl1_bw.TabIndex = 0
        Me.mon_stn5_cyl1_bw.TabStop = False
        '
        'pnl_mon_stn4
        '
        Me.pnl_mon_stn4.Controls.Add(Me.TabPage18)
        Me.pnl_mon_stn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_mon_stn4.Location = New System.Drawing.Point(78, 97)
        Me.pnl_mon_stn4.Name = "pnl_mon_stn4"
        Me.pnl_mon_stn4.SelectedIndex = 0
        Me.pnl_mon_stn4.Size = New System.Drawing.Size(852, 563)
        Me.pnl_mon_stn4.TabIndex = 110
        '
        'TabPage18
        '
        Me.TabPage18.Controls.Add(Me.GroupBox127)
        Me.TabPage18.Controls.Add(Me.GroupBox130)
        Me.TabPage18.Controls.Add(Me.GroupBox133)
        Me.TabPage18.Controls.Add(Me.GroupBox136)
        Me.TabPage18.Location = New System.Drawing.Point(4, 38)
        Me.TabPage18.Name = "TabPage18"
        Me.TabPage18.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage18.Size = New System.Drawing.Size(844, 521)
        Me.TabPage18.TabIndex = 0
        Me.TabPage18.Text = "Station 4"
        Me.TabPage18.UseVisualStyleBackColor = True
        '
        'GroupBox127
        '
        Me.GroupBox127.AutoSize = True
        Me.GroupBox127.Controls.Add(Me.GroupBox128)
        Me.GroupBox127.Controls.Add(Me.GroupBox129)
        Me.GroupBox127.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox127.Location = New System.Drawing.Point(460, 276)
        Me.GroupBox127.Name = "GroupBox127"
        Me.GroupBox127.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox127.TabIndex = 63
        Me.GroupBox127.TabStop = False
        Me.GroupBox127.Text = "V404"
        Me.GroupBox127.Visible = False
        '
        'GroupBox128
        '
        Me.GroupBox128.Controls.Add(Me.Label167)
        Me.GroupBox128.Controls.Add(Me.Label168)
        Me.GroupBox128.Controls.Add(Me.mon_stn4_cyl4_min)
        Me.GroupBox128.Controls.Add(Me.mon_stn4_cyl4_max)
        Me.GroupBox128.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox128.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox128.Name = "GroupBox128"
        Me.GroupBox128.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox128.TabIndex = 3
        Me.GroupBox128.TabStop = False
        Me.GroupBox128.Text = "Sensor"
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label167.Location = New System.Drawing.Point(20, 142)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(69, 18)
        Me.Label167.TabIndex = 1
        Me.Label167.Text = "Minimum"
        '
        'Label168
        '
        Me.Label168.AutoSize = True
        Me.Label168.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label168.Location = New System.Drawing.Point(20, 66)
        Me.Label168.Name = "Label168"
        Me.Label168.Size = New System.Drawing.Size(73, 18)
        Me.Label168.TabIndex = 1
        Me.Label168.Text = "Maximum"
        '
        'mon_stn4_cyl4_min
        '
        Me.mon_stn4_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn4_cyl4_min.Name = "mon_stn4_cyl4_min"
        Me.mon_stn4_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl4_min.TabIndex = 0
        Me.mon_stn4_cyl4_min.TabStop = False
        '
        'mon_stn4_cyl4_max
        '
        Me.mon_stn4_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn4_cyl4_max.Name = "mon_stn4_cyl4_max"
        Me.mon_stn4_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl4_max.TabIndex = 0
        Me.mon_stn4_cyl4_max.TabStop = False
        '
        'GroupBox129
        '
        Me.GroupBox129.Controls.Add(Me.Label169)
        Me.GroupBox129.Controls.Add(Me.mon_stn4_cyl4_fw)
        Me.GroupBox129.Controls.Add(Me.Label170)
        Me.GroupBox129.Controls.Add(Me.mon_stn4_cyl4_bw)
        Me.GroupBox129.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox129.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox129.Name = "GroupBox129"
        Me.GroupBox129.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox129.TabIndex = 3
        Me.GroupBox129.TabStop = False
        Me.GroupBox129.Text = "Actuator"
        '
        'Label169
        '
        Me.Label169.AutoSize = True
        Me.Label169.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label169.Location = New System.Drawing.Point(35, 142)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(52, 18)
        Me.Label169.TabIndex = 1
        Me.Label169.Text = "Return"
        '
        'mon_stn4_cyl4_fw
        '
        Me.mon_stn4_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl4_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn4_cyl4_fw.Name = "mon_stn4_cyl4_fw"
        Me.mon_stn4_cyl4_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl4_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl4_fw.TabIndex = 0
        Me.mon_stn4_cyl4_fw.TabStop = False
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label170.Location = New System.Drawing.Point(35, 66)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(53, 18)
        Me.Label170.TabIndex = 1
        Me.Label170.Text = "Extend"
        '
        'mon_stn4_cyl4_bw
        '
        Me.mon_stn4_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl4_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn4_cyl4_bw.Name = "mon_stn4_cyl4_bw"
        Me.mon_stn4_cyl4_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl4_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl4_bw.TabIndex = 0
        Me.mon_stn4_cyl4_bw.TabStop = False
        '
        'GroupBox130
        '
        Me.GroupBox130.AutoSize = True
        Me.GroupBox130.Controls.Add(Me.GroupBox131)
        Me.GroupBox130.Controls.Add(Me.GroupBox132)
        Me.GroupBox130.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox130.Location = New System.Drawing.Point(459, 33)
        Me.GroupBox130.Name = "GroupBox130"
        Me.GroupBox130.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox130.TabIndex = 64
        Me.GroupBox130.TabStop = False
        Me.GroupBox130.Text = "V402"
        '
        'GroupBox131
        '
        Me.GroupBox131.Controls.Add(Me.Label171)
        Me.GroupBox131.Controls.Add(Me.Label172)
        Me.GroupBox131.Controls.Add(Me.mon_stn4_cyl2_min)
        Me.GroupBox131.Controls.Add(Me.mon_stn4_cyl2_max)
        Me.GroupBox131.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox131.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox131.Name = "GroupBox131"
        Me.GroupBox131.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox131.TabIndex = 3
        Me.GroupBox131.TabStop = False
        Me.GroupBox131.Text = "Sensor"
        '
        'Label171
        '
        Me.Label171.AutoSize = True
        Me.Label171.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label171.Location = New System.Drawing.Point(20, 142)
        Me.Label171.Name = "Label171"
        Me.Label171.Size = New System.Drawing.Size(69, 18)
        Me.Label171.TabIndex = 1
        Me.Label171.Text = "Minimum"
        '
        'Label172
        '
        Me.Label172.AutoSize = True
        Me.Label172.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label172.Location = New System.Drawing.Point(20, 66)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(73, 18)
        Me.Label172.TabIndex = 1
        Me.Label172.Text = "Maximum"
        '
        'mon_stn4_cyl2_min
        '
        Me.mon_stn4_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn4_cyl2_min.Name = "mon_stn4_cyl2_min"
        Me.mon_stn4_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl2_min.TabIndex = 0
        Me.mon_stn4_cyl2_min.TabStop = False
        '
        'mon_stn4_cyl2_max
        '
        Me.mon_stn4_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl2_max.Location = New System.Drawing.Point(19, 30)
        Me.mon_stn4_cyl2_max.Name = "mon_stn4_cyl2_max"
        Me.mon_stn4_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl2_max.TabIndex = 0
        Me.mon_stn4_cyl2_max.TabStop = False
        '
        'GroupBox132
        '
        Me.GroupBox132.Controls.Add(Me.Label173)
        Me.GroupBox132.Controls.Add(Me.mon_stn4_cyl2_fw)
        Me.GroupBox132.Controls.Add(Me.Label174)
        Me.GroupBox132.Controls.Add(Me.mon_stn4_cyl2_bw)
        Me.GroupBox132.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox132.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox132.Name = "GroupBox132"
        Me.GroupBox132.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox132.TabIndex = 3
        Me.GroupBox132.TabStop = False
        Me.GroupBox132.Text = "Actuator"
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label173.Location = New System.Drawing.Point(35, 142)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(52, 18)
        Me.Label173.TabIndex = 1
        Me.Label173.Text = "Return"
        '
        'mon_stn4_cyl2_fw
        '
        Me.mon_stn4_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl2_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn4_cyl2_fw.Name = "mon_stn4_cyl2_fw"
        Me.mon_stn4_cyl2_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl2_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl2_fw.TabIndex = 0
        Me.mon_stn4_cyl2_fw.TabStop = False
        '
        'Label174
        '
        Me.Label174.AutoSize = True
        Me.Label174.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label174.Location = New System.Drawing.Point(35, 66)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(53, 18)
        Me.Label174.TabIndex = 1
        Me.Label174.Text = "Extend"
        '
        'mon_stn4_cyl2_bw
        '
        Me.mon_stn4_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl2_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn4_cyl2_bw.Name = "mon_stn4_cyl2_bw"
        Me.mon_stn4_cyl2_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl2_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl2_bw.TabIndex = 0
        Me.mon_stn4_cyl2_bw.TabStop = False
        '
        'GroupBox133
        '
        Me.GroupBox133.AutoSize = True
        Me.GroupBox133.Controls.Add(Me.GroupBox134)
        Me.GroupBox133.Controls.Add(Me.GroupBox135)
        Me.GroupBox133.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox133.Location = New System.Drawing.Point(94, 276)
        Me.GroupBox133.Name = "GroupBox133"
        Me.GroupBox133.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox133.TabIndex = 65
        Me.GroupBox133.TabStop = False
        Me.GroupBox133.Text = "V403"
        Me.GroupBox133.Visible = False
        '
        'GroupBox134
        '
        Me.GroupBox134.Controls.Add(Me.Label175)
        Me.GroupBox134.Controls.Add(Me.Label176)
        Me.GroupBox134.Controls.Add(Me.mon_stn4_cyl3_min)
        Me.GroupBox134.Controls.Add(Me.mon_stn4_cyl3_max)
        Me.GroupBox134.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox134.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox134.Name = "GroupBox134"
        Me.GroupBox134.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox134.TabIndex = 3
        Me.GroupBox134.TabStop = False
        Me.GroupBox134.Text = "Sensor"
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label175.Location = New System.Drawing.Point(20, 142)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(69, 18)
        Me.Label175.TabIndex = 1
        Me.Label175.Text = "Minimum"
        '
        'Label176
        '
        Me.Label176.AutoSize = True
        Me.Label176.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label176.Location = New System.Drawing.Point(20, 66)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(73, 18)
        Me.Label176.TabIndex = 1
        Me.Label176.Text = "Maximum"
        '
        'mon_stn4_cyl3_min
        '
        Me.mon_stn4_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn4_cyl3_min.Name = "mon_stn4_cyl3_min"
        Me.mon_stn4_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl3_min.TabIndex = 0
        Me.mon_stn4_cyl3_min.TabStop = False
        '
        'mon_stn4_cyl3_max
        '
        Me.mon_stn4_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn4_cyl3_max.Name = "mon_stn4_cyl3_max"
        Me.mon_stn4_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl3_max.TabIndex = 0
        Me.mon_stn4_cyl3_max.TabStop = False
        '
        'GroupBox135
        '
        Me.GroupBox135.Controls.Add(Me.Label177)
        Me.GroupBox135.Controls.Add(Me.mon_stn4_cyl3_fw)
        Me.GroupBox135.Controls.Add(Me.Label178)
        Me.GroupBox135.Controls.Add(Me.mon_stn4_cyl3_bw)
        Me.GroupBox135.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox135.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox135.Name = "GroupBox135"
        Me.GroupBox135.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox135.TabIndex = 3
        Me.GroupBox135.TabStop = False
        Me.GroupBox135.Text = "Actuator"
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label177.Location = New System.Drawing.Point(35, 142)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(52, 18)
        Me.Label177.TabIndex = 1
        Me.Label177.Text = "Return"
        '
        'mon_stn4_cyl3_fw
        '
        Me.mon_stn4_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl3_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn4_cyl3_fw.Name = "mon_stn4_cyl3_fw"
        Me.mon_stn4_cyl3_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl3_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl3_fw.TabIndex = 0
        Me.mon_stn4_cyl3_fw.TabStop = False
        '
        'Label178
        '
        Me.Label178.AutoSize = True
        Me.Label178.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label178.Location = New System.Drawing.Point(35, 66)
        Me.Label178.Name = "Label178"
        Me.Label178.Size = New System.Drawing.Size(53, 18)
        Me.Label178.TabIndex = 1
        Me.Label178.Text = "Extend"
        '
        'mon_stn4_cyl3_bw
        '
        Me.mon_stn4_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl3_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn4_cyl3_bw.Name = "mon_stn4_cyl3_bw"
        Me.mon_stn4_cyl3_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl3_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl3_bw.TabIndex = 0
        Me.mon_stn4_cyl3_bw.TabStop = False
        '
        'GroupBox136
        '
        Me.GroupBox136.AutoSize = True
        Me.GroupBox136.Controls.Add(Me.GroupBox137)
        Me.GroupBox136.Controls.Add(Me.GroupBox138)
        Me.GroupBox136.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox136.Location = New System.Drawing.Point(93, 33)
        Me.GroupBox136.Name = "GroupBox136"
        Me.GroupBox136.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox136.TabIndex = 66
        Me.GroupBox136.TabStop = False
        Me.GroupBox136.Text = "V401"
        '
        'GroupBox137
        '
        Me.GroupBox137.Controls.Add(Me.Label179)
        Me.GroupBox137.Controls.Add(Me.Label180)
        Me.GroupBox137.Controls.Add(Me.mon_stn4_cyl1_min)
        Me.GroupBox137.Controls.Add(Me.mon_stn4_cyl1_max)
        Me.GroupBox137.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox137.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox137.Name = "GroupBox137"
        Me.GroupBox137.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox137.TabIndex = 3
        Me.GroupBox137.TabStop = False
        Me.GroupBox137.Text = "Sensor"
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label179.Location = New System.Drawing.Point(20, 142)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(69, 18)
        Me.Label179.TabIndex = 1
        Me.Label179.Text = "Minimum"
        '
        'Label180
        '
        Me.Label180.AutoSize = True
        Me.Label180.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label180.Location = New System.Drawing.Point(20, 66)
        Me.Label180.Name = "Label180"
        Me.Label180.Size = New System.Drawing.Size(73, 18)
        Me.Label180.TabIndex = 1
        Me.Label180.Text = "Maximum"
        '
        'mon_stn4_cyl1_min
        '
        Me.mon_stn4_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn4_cyl1_min.Name = "mon_stn4_cyl1_min"
        Me.mon_stn4_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl1_min.TabIndex = 0
        Me.mon_stn4_cyl1_min.TabStop = False
        '
        'mon_stn4_cyl1_max
        '
        Me.mon_stn4_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn4_cyl1_max.Name = "mon_stn4_cyl1_max"
        Me.mon_stn4_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl1_max.TabIndex = 0
        Me.mon_stn4_cyl1_max.TabStop = False
        '
        'GroupBox138
        '
        Me.GroupBox138.Controls.Add(Me.Label181)
        Me.GroupBox138.Controls.Add(Me.mon_stn4_cyl1_fw)
        Me.GroupBox138.Controls.Add(Me.Label182)
        Me.GroupBox138.Controls.Add(Me.mon_stn4_cyl1_bw)
        Me.GroupBox138.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox138.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox138.Name = "GroupBox138"
        Me.GroupBox138.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox138.TabIndex = 3
        Me.GroupBox138.TabStop = False
        Me.GroupBox138.Text = "Actuator"
        '
        'Label181
        '
        Me.Label181.AutoSize = True
        Me.Label181.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label181.Location = New System.Drawing.Point(35, 142)
        Me.Label181.Name = "Label181"
        Me.Label181.Size = New System.Drawing.Size(52, 18)
        Me.Label181.TabIndex = 1
        Me.Label181.Text = "Return"
        '
        'mon_stn4_cyl1_fw
        '
        Me.mon_stn4_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl1_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn4_cyl1_fw.Name = "mon_stn4_cyl1_fw"
        Me.mon_stn4_cyl1_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl1_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl1_fw.TabIndex = 0
        Me.mon_stn4_cyl1_fw.TabStop = False
        '
        'Label182
        '
        Me.Label182.AutoSize = True
        Me.Label182.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label182.Location = New System.Drawing.Point(35, 66)
        Me.Label182.Name = "Label182"
        Me.Label182.Size = New System.Drawing.Size(53, 18)
        Me.Label182.TabIndex = 1
        Me.Label182.Text = "Extend"
        '
        'mon_stn4_cyl1_bw
        '
        Me.mon_stn4_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn4_cyl1_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn4_cyl1_bw.Name = "mon_stn4_cyl1_bw"
        Me.mon_stn4_cyl1_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn4_cyl1_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn4_cyl1_bw.TabIndex = 0
        Me.mon_stn4_cyl1_bw.TabStop = False
        '
        'pnl_mon_stn3
        '
        Me.pnl_mon_stn3.Controls.Add(Me.TabPage19)
        Me.pnl_mon_stn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_mon_stn3.Location = New System.Drawing.Point(78, 97)
        Me.pnl_mon_stn3.Name = "pnl_mon_stn3"
        Me.pnl_mon_stn3.SelectedIndex = 0
        Me.pnl_mon_stn3.Size = New System.Drawing.Size(853, 563)
        Me.pnl_mon_stn3.TabIndex = 111
        '
        'TabPage19
        '
        Me.TabPage19.Controls.Add(Me.GroupBox115)
        Me.TabPage19.Controls.Add(Me.GroupBox118)
        Me.TabPage19.Controls.Add(Me.GroupBox121)
        Me.TabPage19.Controls.Add(Me.GroupBox124)
        Me.TabPage19.Location = New System.Drawing.Point(4, 38)
        Me.TabPage19.Name = "TabPage19"
        Me.TabPage19.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage19.Size = New System.Drawing.Size(845, 521)
        Me.TabPage19.TabIndex = 0
        Me.TabPage19.Text = "Station 3"
        Me.TabPage19.UseVisualStyleBackColor = True
        '
        'GroupBox115
        '
        Me.GroupBox115.AutoSize = True
        Me.GroupBox115.Controls.Add(Me.GroupBox116)
        Me.GroupBox115.Controls.Add(Me.GroupBox117)
        Me.GroupBox115.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox115.Location = New System.Drawing.Point(460, 273)
        Me.GroupBox115.Name = "GroupBox115"
        Me.GroupBox115.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox115.TabIndex = 58
        Me.GroupBox115.TabStop = False
        Me.GroupBox115.Text = "V304"
        Me.GroupBox115.Visible = False
        '
        'GroupBox116
        '
        Me.GroupBox116.Controls.Add(Me.Label150)
        Me.GroupBox116.Controls.Add(Me.Label151)
        Me.GroupBox116.Controls.Add(Me.mon_stn3_cyl4_min)
        Me.GroupBox116.Controls.Add(Me.mon_stn3_cyl4_max)
        Me.GroupBox116.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox116.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox116.Name = "GroupBox116"
        Me.GroupBox116.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox116.TabIndex = 3
        Me.GroupBox116.TabStop = False
        Me.GroupBox116.Text = "Sensor"
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label150.Location = New System.Drawing.Point(20, 142)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(69, 18)
        Me.Label150.TabIndex = 1
        Me.Label150.Text = "Minimum"
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label151.Location = New System.Drawing.Point(20, 66)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(73, 18)
        Me.Label151.TabIndex = 1
        Me.Label151.Text = "Maximum"
        '
        'mon_stn3_cyl4_min
        '
        Me.mon_stn3_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn3_cyl4_min.Name = "mon_stn3_cyl4_min"
        Me.mon_stn3_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl4_min.TabIndex = 0
        Me.mon_stn3_cyl4_min.TabStop = False
        '
        'mon_stn3_cyl4_max
        '
        Me.mon_stn3_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn3_cyl4_max.Name = "mon_stn3_cyl4_max"
        Me.mon_stn3_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl4_max.TabIndex = 0
        Me.mon_stn3_cyl4_max.TabStop = False
        '
        'GroupBox117
        '
        Me.GroupBox117.Controls.Add(Me.Label152)
        Me.GroupBox117.Controls.Add(Me.mon_stn3_cyl4_fw)
        Me.GroupBox117.Controls.Add(Me.Label153)
        Me.GroupBox117.Controls.Add(Me.mon_stn3_cyl4_bw)
        Me.GroupBox117.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox117.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox117.Name = "GroupBox117"
        Me.GroupBox117.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox117.TabIndex = 3
        Me.GroupBox117.TabStop = False
        Me.GroupBox117.Text = "Actuator"
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label152.Location = New System.Drawing.Point(35, 142)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(52, 18)
        Me.Label152.TabIndex = 1
        Me.Label152.Text = "Return"
        '
        'mon_stn3_cyl4_fw
        '
        Me.mon_stn3_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl4_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn3_cyl4_fw.Name = "mon_stn3_cyl4_fw"
        Me.mon_stn3_cyl4_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl4_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl4_fw.TabIndex = 0
        Me.mon_stn3_cyl4_fw.TabStop = False
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label153.Location = New System.Drawing.Point(35, 66)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(53, 18)
        Me.Label153.TabIndex = 1
        Me.Label153.Text = "Extend"
        '
        'mon_stn3_cyl4_bw
        '
        Me.mon_stn3_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl4_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn3_cyl4_bw.Name = "mon_stn3_cyl4_bw"
        Me.mon_stn3_cyl4_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl4_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl4_bw.TabIndex = 0
        Me.mon_stn3_cyl4_bw.TabStop = False
        '
        'GroupBox118
        '
        Me.GroupBox118.AutoSize = True
        Me.GroupBox118.Controls.Add(Me.GroupBox119)
        Me.GroupBox118.Controls.Add(Me.GroupBox120)
        Me.GroupBox118.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox118.Location = New System.Drawing.Point(459, 30)
        Me.GroupBox118.Name = "GroupBox118"
        Me.GroupBox118.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox118.TabIndex = 59
        Me.GroupBox118.TabStop = False
        Me.GroupBox118.Text = "V302"
        '
        'GroupBox119
        '
        Me.GroupBox119.Controls.Add(Me.Label154)
        Me.GroupBox119.Controls.Add(Me.Label155)
        Me.GroupBox119.Controls.Add(Me.mon_stn3_cyl2_min)
        Me.GroupBox119.Controls.Add(Me.mon_stn3_cyl2_max)
        Me.GroupBox119.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox119.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox119.Name = "GroupBox119"
        Me.GroupBox119.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox119.TabIndex = 3
        Me.GroupBox119.TabStop = False
        Me.GroupBox119.Text = "Sensor"
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label154.Location = New System.Drawing.Point(20, 142)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(69, 18)
        Me.Label154.TabIndex = 1
        Me.Label154.Text = "Minimum"
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label155.Location = New System.Drawing.Point(20, 66)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(73, 18)
        Me.Label155.TabIndex = 1
        Me.Label155.Text = "Maximum"
        '
        'mon_stn3_cyl2_min
        '
        Me.mon_stn3_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn3_cyl2_min.Name = "mon_stn3_cyl2_min"
        Me.mon_stn3_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl2_min.TabIndex = 0
        Me.mon_stn3_cyl2_min.TabStop = False
        '
        'mon_stn3_cyl2_max
        '
        Me.mon_stn3_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn3_cyl2_max.Name = "mon_stn3_cyl2_max"
        Me.mon_stn3_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl2_max.TabIndex = 0
        Me.mon_stn3_cyl2_max.TabStop = False
        '
        'GroupBox120
        '
        Me.GroupBox120.Controls.Add(Me.Label156)
        Me.GroupBox120.Controls.Add(Me.mon_stn3_cyl2_fw)
        Me.GroupBox120.Controls.Add(Me.Label157)
        Me.GroupBox120.Controls.Add(Me.mon_stn3_cyl2_bw)
        Me.GroupBox120.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox120.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox120.Name = "GroupBox120"
        Me.GroupBox120.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox120.TabIndex = 3
        Me.GroupBox120.TabStop = False
        Me.GroupBox120.Text = "Actuator"
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.Location = New System.Drawing.Point(35, 142)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(52, 18)
        Me.Label156.TabIndex = 1
        Me.Label156.Text = "Return"
        '
        'mon_stn3_cyl2_fw
        '
        Me.mon_stn3_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl2_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn3_cyl2_fw.Name = "mon_stn3_cyl2_fw"
        Me.mon_stn3_cyl2_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl2_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl2_fw.TabIndex = 0
        Me.mon_stn3_cyl2_fw.TabStop = False
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label157.Location = New System.Drawing.Point(35, 66)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(53, 18)
        Me.Label157.TabIndex = 1
        Me.Label157.Text = "Extend"
        '
        'mon_stn3_cyl2_bw
        '
        Me.mon_stn3_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl2_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn3_cyl2_bw.Name = "mon_stn3_cyl2_bw"
        Me.mon_stn3_cyl2_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl2_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl2_bw.TabIndex = 0
        Me.mon_stn3_cyl2_bw.TabStop = False
        '
        'GroupBox121
        '
        Me.GroupBox121.AutoSize = True
        Me.GroupBox121.Controls.Add(Me.GroupBox122)
        Me.GroupBox121.Controls.Add(Me.GroupBox123)
        Me.GroupBox121.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox121.Location = New System.Drawing.Point(94, 273)
        Me.GroupBox121.Name = "GroupBox121"
        Me.GroupBox121.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox121.TabIndex = 60
        Me.GroupBox121.TabStop = False
        Me.GroupBox121.Text = "V303"
        Me.GroupBox121.Visible = False
        '
        'GroupBox122
        '
        Me.GroupBox122.Controls.Add(Me.Label158)
        Me.GroupBox122.Controls.Add(Me.Label159)
        Me.GroupBox122.Controls.Add(Me.mon_stn3_cyl3_min)
        Me.GroupBox122.Controls.Add(Me.mon_stn3_cyl3_max)
        Me.GroupBox122.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox122.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox122.Name = "GroupBox122"
        Me.GroupBox122.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox122.TabIndex = 3
        Me.GroupBox122.TabStop = False
        Me.GroupBox122.Text = "Sensor"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label158.Location = New System.Drawing.Point(20, 142)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(69, 18)
        Me.Label158.TabIndex = 1
        Me.Label158.Text = "Minimum"
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label159.Location = New System.Drawing.Point(20, 66)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(73, 18)
        Me.Label159.TabIndex = 1
        Me.Label159.Text = "Maximum"
        '
        'mon_stn3_cyl3_min
        '
        Me.mon_stn3_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn3_cyl3_min.Name = "mon_stn3_cyl3_min"
        Me.mon_stn3_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl3_min.TabIndex = 0
        Me.mon_stn3_cyl3_min.TabStop = False
        '
        'mon_stn3_cyl3_max
        '
        Me.mon_stn3_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn3_cyl3_max.Name = "mon_stn3_cyl3_max"
        Me.mon_stn3_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl3_max.TabIndex = 0
        Me.mon_stn3_cyl3_max.TabStop = False
        '
        'GroupBox123
        '
        Me.GroupBox123.Controls.Add(Me.Label160)
        Me.GroupBox123.Controls.Add(Me.mon_stn3_cyl3_fw)
        Me.GroupBox123.Controls.Add(Me.Label161)
        Me.GroupBox123.Controls.Add(Me.mon_stn3_cyl3_bw)
        Me.GroupBox123.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox123.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox123.Name = "GroupBox123"
        Me.GroupBox123.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox123.TabIndex = 3
        Me.GroupBox123.TabStop = False
        Me.GroupBox123.Text = "Actuator"
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label160.Location = New System.Drawing.Point(35, 142)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(52, 18)
        Me.Label160.TabIndex = 1
        Me.Label160.Text = "Return"
        '
        'mon_stn3_cyl3_fw
        '
        Me.mon_stn3_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl3_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn3_cyl3_fw.Name = "mon_stn3_cyl3_fw"
        Me.mon_stn3_cyl3_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl3_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl3_fw.TabIndex = 0
        Me.mon_stn3_cyl3_fw.TabStop = False
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label161.Location = New System.Drawing.Point(35, 66)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(53, 18)
        Me.Label161.TabIndex = 1
        Me.Label161.Text = "Extend"
        '
        'mon_stn3_cyl3_bw
        '
        Me.mon_stn3_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl3_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn3_cyl3_bw.Name = "mon_stn3_cyl3_bw"
        Me.mon_stn3_cyl3_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl3_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl3_bw.TabIndex = 0
        Me.mon_stn3_cyl3_bw.TabStop = False
        '
        'GroupBox124
        '
        Me.GroupBox124.AutoSize = True
        Me.GroupBox124.Controls.Add(Me.GroupBox125)
        Me.GroupBox124.Controls.Add(Me.GroupBox126)
        Me.GroupBox124.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox124.Location = New System.Drawing.Point(93, 30)
        Me.GroupBox124.Name = "GroupBox124"
        Me.GroupBox124.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox124.TabIndex = 61
        Me.GroupBox124.TabStop = False
        Me.GroupBox124.Text = "V301"
        '
        'GroupBox125
        '
        Me.GroupBox125.Controls.Add(Me.Label162)
        Me.GroupBox125.Controls.Add(Me.Label163)
        Me.GroupBox125.Controls.Add(Me.mon_stn3_cyl1_min)
        Me.GroupBox125.Controls.Add(Me.mon_stn3_cyl1_max)
        Me.GroupBox125.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox125.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox125.Name = "GroupBox125"
        Me.GroupBox125.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox125.TabIndex = 3
        Me.GroupBox125.TabStop = False
        Me.GroupBox125.Text = "Sensor"
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label162.Location = New System.Drawing.Point(20, 142)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(69, 18)
        Me.Label162.TabIndex = 1
        Me.Label162.Text = "Minimum"
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label163.Location = New System.Drawing.Point(20, 66)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(73, 18)
        Me.Label163.TabIndex = 1
        Me.Label163.Text = "Maximum"
        '
        'mon_stn3_cyl1_min
        '
        Me.mon_stn3_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn3_cyl1_min.Name = "mon_stn3_cyl1_min"
        Me.mon_stn3_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl1_min.TabIndex = 0
        Me.mon_stn3_cyl1_min.TabStop = False
        '
        'mon_stn3_cyl1_max
        '
        Me.mon_stn3_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn3_cyl1_max.Name = "mon_stn3_cyl1_max"
        Me.mon_stn3_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl1_max.TabIndex = 0
        Me.mon_stn3_cyl1_max.TabStop = False
        '
        'GroupBox126
        '
        Me.GroupBox126.Controls.Add(Me.Label164)
        Me.GroupBox126.Controls.Add(Me.mon_stn3_cyl1_fw)
        Me.GroupBox126.Controls.Add(Me.Label165)
        Me.GroupBox126.Controls.Add(Me.mon_stn3_cyl1_bw)
        Me.GroupBox126.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox126.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox126.Name = "GroupBox126"
        Me.GroupBox126.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox126.TabIndex = 3
        Me.GroupBox126.TabStop = False
        Me.GroupBox126.Text = "Actuator"
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label164.Location = New System.Drawing.Point(35, 142)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(52, 18)
        Me.Label164.TabIndex = 1
        Me.Label164.Text = "Return"
        '
        'mon_stn3_cyl1_fw
        '
        Me.mon_stn3_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl1_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn3_cyl1_fw.Name = "mon_stn3_cyl1_fw"
        Me.mon_stn3_cyl1_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl1_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl1_fw.TabIndex = 0
        Me.mon_stn3_cyl1_fw.TabStop = False
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label165.Location = New System.Drawing.Point(35, 66)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(53, 18)
        Me.Label165.TabIndex = 1
        Me.Label165.Text = "Extend"
        '
        'mon_stn3_cyl1_bw
        '
        Me.mon_stn3_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn3_cyl1_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn3_cyl1_bw.Name = "mon_stn3_cyl1_bw"
        Me.mon_stn3_cyl1_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn3_cyl1_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn3_cyl1_bw.TabIndex = 0
        Me.mon_stn3_cyl1_bw.TabStop = False
        '
        'pnl_mon_stn2
        '
        Me.pnl_mon_stn2.Controls.Add(Me.TabPage20)
        Me.pnl_mon_stn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_mon_stn2.Location = New System.Drawing.Point(78, 97)
        Me.pnl_mon_stn2.Name = "pnl_mon_stn2"
        Me.pnl_mon_stn2.SelectedIndex = 0
        Me.pnl_mon_stn2.Size = New System.Drawing.Size(852, 560)
        Me.pnl_mon_stn2.TabIndex = 112
        '
        'TabPage20
        '
        Me.TabPage20.Controls.Add(Me.GroupBox103)
        Me.TabPage20.Controls.Add(Me.GroupBox106)
        Me.TabPage20.Controls.Add(Me.GroupBox109)
        Me.TabPage20.Controls.Add(Me.GroupBox112)
        Me.TabPage20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage20.Location = New System.Drawing.Point(4, 38)
        Me.TabPage20.Name = "TabPage20"
        Me.TabPage20.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage20.Size = New System.Drawing.Size(844, 518)
        Me.TabPage20.TabIndex = 0
        Me.TabPage20.Text = "Station 2"
        Me.TabPage20.UseVisualStyleBackColor = True
        '
        'GroupBox103
        '
        Me.GroupBox103.AutoSize = True
        Me.GroupBox103.Controls.Add(Me.GroupBox104)
        Me.GroupBox103.Controls.Add(Me.GroupBox105)
        Me.GroupBox103.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox103.Location = New System.Drawing.Point(460, 272)
        Me.GroupBox103.Name = "GroupBox103"
        Me.GroupBox103.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox103.TabIndex = 53
        Me.GroupBox103.TabStop = False
        Me.GroupBox103.Text = "V204"
        Me.GroupBox103.Visible = False
        '
        'GroupBox104
        '
        Me.GroupBox104.Controls.Add(Me.Label133)
        Me.GroupBox104.Controls.Add(Me.Label134)
        Me.GroupBox104.Controls.Add(Me.mon_stn2_cyl4_min)
        Me.GroupBox104.Controls.Add(Me.mon_stn2_cyl4_max)
        Me.GroupBox104.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox104.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox104.Name = "GroupBox104"
        Me.GroupBox104.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox104.TabIndex = 3
        Me.GroupBox104.TabStop = False
        Me.GroupBox104.Text = "Sensor"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(20, 142)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(69, 18)
        Me.Label133.TabIndex = 1
        Me.Label133.Text = "Minimum"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(20, 66)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(73, 18)
        Me.Label134.TabIndex = 1
        Me.Label134.Text = "Maximum"
        '
        'mon_stn2_cyl4_min
        '
        Me.mon_stn2_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn2_cyl4_min.Name = "mon_stn2_cyl4_min"
        Me.mon_stn2_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl4_min.TabIndex = 0
        Me.mon_stn2_cyl4_min.TabStop = False
        '
        'mon_stn2_cyl4_max
        '
        Me.mon_stn2_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn2_cyl4_max.Name = "mon_stn2_cyl4_max"
        Me.mon_stn2_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl4_max.TabIndex = 0
        Me.mon_stn2_cyl4_max.TabStop = False
        '
        'GroupBox105
        '
        Me.GroupBox105.Controls.Add(Me.Label135)
        Me.GroupBox105.Controls.Add(Me.mon_stn2_cyl4_fw)
        Me.GroupBox105.Controls.Add(Me.Label136)
        Me.GroupBox105.Controls.Add(Me.mon_stn2_cyl4_bw)
        Me.GroupBox105.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox105.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox105.Name = "GroupBox105"
        Me.GroupBox105.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox105.TabIndex = 3
        Me.GroupBox105.TabStop = False
        Me.GroupBox105.Text = "Actuator"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.Location = New System.Drawing.Point(35, 142)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(52, 18)
        Me.Label135.TabIndex = 1
        Me.Label135.Text = "Return"
        '
        'mon_stn2_cyl4_fw
        '
        Me.mon_stn2_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl4_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn2_cyl4_fw.Name = "mon_stn2_cyl4_fw"
        Me.mon_stn2_cyl4_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl4_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl4_fw.TabIndex = 0
        Me.mon_stn2_cyl4_fw.TabStop = False
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.Location = New System.Drawing.Point(35, 66)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(53, 18)
        Me.Label136.TabIndex = 1
        Me.Label136.Text = "Extend"
        '
        'mon_stn2_cyl4_bw
        '
        Me.mon_stn2_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl4_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn2_cyl4_bw.Name = "mon_stn2_cyl4_bw"
        Me.mon_stn2_cyl4_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl4_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl4_bw.TabIndex = 0
        Me.mon_stn2_cyl4_bw.TabStop = False
        '
        'GroupBox106
        '
        Me.GroupBox106.AutoSize = True
        Me.GroupBox106.Controls.Add(Me.GroupBox107)
        Me.GroupBox106.Controls.Add(Me.GroupBox108)
        Me.GroupBox106.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox106.Location = New System.Drawing.Point(459, 29)
        Me.GroupBox106.Name = "GroupBox106"
        Me.GroupBox106.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox106.TabIndex = 54
        Me.GroupBox106.TabStop = False
        Me.GroupBox106.Text = "V202"
        '
        'GroupBox107
        '
        Me.GroupBox107.Controls.Add(Me.Label137)
        Me.GroupBox107.Controls.Add(Me.Label138)
        Me.GroupBox107.Controls.Add(Me.mon_stn2_cyl2_min)
        Me.GroupBox107.Controls.Add(Me.mon_stn2_cyl2_max)
        Me.GroupBox107.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox107.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox107.Name = "GroupBox107"
        Me.GroupBox107.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox107.TabIndex = 3
        Me.GroupBox107.TabStop = False
        Me.GroupBox107.Text = "Sensor"
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label137.Location = New System.Drawing.Point(20, 142)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(69, 18)
        Me.Label137.TabIndex = 1
        Me.Label137.Text = "Minimum"
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label138.Location = New System.Drawing.Point(20, 66)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(73, 18)
        Me.Label138.TabIndex = 1
        Me.Label138.Text = "Maximum"
        '
        'mon_stn2_cyl2_min
        '
        Me.mon_stn2_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn2_cyl2_min.Name = "mon_stn2_cyl2_min"
        Me.mon_stn2_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl2_min.TabIndex = 0
        Me.mon_stn2_cyl2_min.TabStop = False
        '
        'mon_stn2_cyl2_max
        '
        Me.mon_stn2_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn2_cyl2_max.Name = "mon_stn2_cyl2_max"
        Me.mon_stn2_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl2_max.TabIndex = 0
        Me.mon_stn2_cyl2_max.TabStop = False
        '
        'GroupBox108
        '
        Me.GroupBox108.Controls.Add(Me.Label139)
        Me.GroupBox108.Controls.Add(Me.mon_stn2_cyl2_fw)
        Me.GroupBox108.Controls.Add(Me.Label140)
        Me.GroupBox108.Controls.Add(Me.mon_stn2_cyl2_bw)
        Me.GroupBox108.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox108.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox108.Name = "GroupBox108"
        Me.GroupBox108.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox108.TabIndex = 3
        Me.GroupBox108.TabStop = False
        Me.GroupBox108.Text = "Actuator"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.Location = New System.Drawing.Point(35, 142)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(52, 18)
        Me.Label139.TabIndex = 1
        Me.Label139.Text = "Return"
        '
        'mon_stn2_cyl2_fw
        '
        Me.mon_stn2_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl2_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn2_cyl2_fw.Name = "mon_stn2_cyl2_fw"
        Me.mon_stn2_cyl2_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl2_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl2_fw.TabIndex = 0
        Me.mon_stn2_cyl2_fw.TabStop = False
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.Location = New System.Drawing.Point(35, 66)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(53, 18)
        Me.Label140.TabIndex = 1
        Me.Label140.Text = "Extend"
        '
        'mon_stn2_cyl2_bw
        '
        Me.mon_stn2_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl2_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn2_cyl2_bw.Name = "mon_stn2_cyl2_bw"
        Me.mon_stn2_cyl2_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl2_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl2_bw.TabIndex = 0
        Me.mon_stn2_cyl2_bw.TabStop = False
        '
        'GroupBox109
        '
        Me.GroupBox109.AutoSize = True
        Me.GroupBox109.Controls.Add(Me.GroupBox110)
        Me.GroupBox109.Controls.Add(Me.GroupBox111)
        Me.GroupBox109.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox109.Location = New System.Drawing.Point(94, 272)
        Me.GroupBox109.Name = "GroupBox109"
        Me.GroupBox109.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox109.TabIndex = 55
        Me.GroupBox109.TabStop = False
        Me.GroupBox109.Text = "V203"
        '
        'GroupBox110
        '
        Me.GroupBox110.Controls.Add(Me.Label141)
        Me.GroupBox110.Controls.Add(Me.Label142)
        Me.GroupBox110.Controls.Add(Me.mon_stn2_cyl3_min)
        Me.GroupBox110.Controls.Add(Me.mon_stn2_cyl3_max)
        Me.GroupBox110.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox110.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox110.Name = "GroupBox110"
        Me.GroupBox110.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox110.TabIndex = 3
        Me.GroupBox110.TabStop = False
        Me.GroupBox110.Text = "Sensor"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.Location = New System.Drawing.Point(20, 142)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(69, 18)
        Me.Label141.TabIndex = 1
        Me.Label141.Text = "Minimum"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(20, 66)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(73, 18)
        Me.Label142.TabIndex = 1
        Me.Label142.Text = "Maximum"
        '
        'mon_stn2_cyl3_min
        '
        Me.mon_stn2_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn2_cyl3_min.Name = "mon_stn2_cyl3_min"
        Me.mon_stn2_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl3_min.TabIndex = 0
        Me.mon_stn2_cyl3_min.TabStop = False
        '
        'mon_stn2_cyl3_max
        '
        Me.mon_stn2_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn2_cyl3_max.Name = "mon_stn2_cyl3_max"
        Me.mon_stn2_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl3_max.TabIndex = 0
        Me.mon_stn2_cyl3_max.TabStop = False
        '
        'GroupBox111
        '
        Me.GroupBox111.Controls.Add(Me.Label143)
        Me.GroupBox111.Controls.Add(Me.mon_stn2_cyl3_fw)
        Me.GroupBox111.Controls.Add(Me.Label144)
        Me.GroupBox111.Controls.Add(Me.mon_stn2_cyl3_bw)
        Me.GroupBox111.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox111.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox111.Name = "GroupBox111"
        Me.GroupBox111.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox111.TabIndex = 3
        Me.GroupBox111.TabStop = False
        Me.GroupBox111.Text = "Actuator"
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label143.Location = New System.Drawing.Point(35, 142)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(52, 18)
        Me.Label143.TabIndex = 1
        Me.Label143.Text = "Return"
        '
        'mon_stn2_cyl3_fw
        '
        Me.mon_stn2_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl3_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn2_cyl3_fw.Name = "mon_stn2_cyl3_fw"
        Me.mon_stn2_cyl3_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl3_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl3_fw.TabIndex = 0
        Me.mon_stn2_cyl3_fw.TabStop = False
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.Location = New System.Drawing.Point(35, 66)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(53, 18)
        Me.Label144.TabIndex = 1
        Me.Label144.Text = "Extend"
        '
        'mon_stn2_cyl3_bw
        '
        Me.mon_stn2_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl3_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn2_cyl3_bw.Name = "mon_stn2_cyl3_bw"
        Me.mon_stn2_cyl3_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl3_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl3_bw.TabIndex = 0
        Me.mon_stn2_cyl3_bw.TabStop = False
        '
        'GroupBox112
        '
        Me.GroupBox112.AutoSize = True
        Me.GroupBox112.Controls.Add(Me.GroupBox113)
        Me.GroupBox112.Controls.Add(Me.GroupBox114)
        Me.GroupBox112.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox112.Location = New System.Drawing.Point(93, 29)
        Me.GroupBox112.Name = "GroupBox112"
        Me.GroupBox112.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox112.TabIndex = 56
        Me.GroupBox112.TabStop = False
        Me.GroupBox112.Text = "V201"
        '
        'GroupBox113
        '
        Me.GroupBox113.Controls.Add(Me.Label145)
        Me.GroupBox113.Controls.Add(Me.Label146)
        Me.GroupBox113.Controls.Add(Me.mon_stn2_cyl1_min)
        Me.GroupBox113.Controls.Add(Me.mon_stn2_cyl1_max)
        Me.GroupBox113.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox113.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox113.Name = "GroupBox113"
        Me.GroupBox113.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox113.TabIndex = 3
        Me.GroupBox113.TabStop = False
        Me.GroupBox113.Text = "Sensor"
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label145.Location = New System.Drawing.Point(20, 142)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(69, 18)
        Me.Label145.TabIndex = 1
        Me.Label145.Text = "Minimum"
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label146.Location = New System.Drawing.Point(20, 66)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(73, 18)
        Me.Label146.TabIndex = 1
        Me.Label146.Text = "Maximum"
        '
        'mon_stn2_cyl1_min
        '
        Me.mon_stn2_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn2_cyl1_min.Name = "mon_stn2_cyl1_min"
        Me.mon_stn2_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl1_min.TabIndex = 0
        Me.mon_stn2_cyl1_min.TabStop = False
        '
        'mon_stn2_cyl1_max
        '
        Me.mon_stn2_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn2_cyl1_max.Name = "mon_stn2_cyl1_max"
        Me.mon_stn2_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl1_max.TabIndex = 0
        Me.mon_stn2_cyl1_max.TabStop = False
        '
        'GroupBox114
        '
        Me.GroupBox114.Controls.Add(Me.Label147)
        Me.GroupBox114.Controls.Add(Me.mon_stn2_cyl1_fw)
        Me.GroupBox114.Controls.Add(Me.Label148)
        Me.GroupBox114.Controls.Add(Me.mon_stn2_cyl1_bw)
        Me.GroupBox114.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox114.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox114.Name = "GroupBox114"
        Me.GroupBox114.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox114.TabIndex = 3
        Me.GroupBox114.TabStop = False
        Me.GroupBox114.Text = "Actuator"
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label147.Location = New System.Drawing.Point(35, 142)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(52, 18)
        Me.Label147.TabIndex = 1
        Me.Label147.Text = "Return"
        '
        'mon_stn2_cyl1_fw
        '
        Me.mon_stn2_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl1_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn2_cyl1_fw.Name = "mon_stn2_cyl1_fw"
        Me.mon_stn2_cyl1_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl1_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl1_fw.TabIndex = 0
        Me.mon_stn2_cyl1_fw.TabStop = False
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label148.Location = New System.Drawing.Point(35, 66)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(53, 18)
        Me.Label148.TabIndex = 1
        Me.Label148.Text = "Extend"
        '
        'mon_stn2_cyl1_bw
        '
        Me.mon_stn2_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn2_cyl1_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn2_cyl1_bw.Name = "mon_stn2_cyl1_bw"
        Me.mon_stn2_cyl1_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn2_cyl1_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn2_cyl1_bw.TabIndex = 0
        Me.mon_stn2_cyl1_bw.TabStop = False
        '
        'pnl_mon_stn1
        '
        Me.pnl_mon_stn1.Controls.Add(Me.TabPage21)
        Me.pnl_mon_stn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_mon_stn1.Location = New System.Drawing.Point(78, 97)
        Me.pnl_mon_stn1.Name = "pnl_mon_stn1"
        Me.pnl_mon_stn1.SelectedIndex = 0
        Me.pnl_mon_stn1.Size = New System.Drawing.Size(852, 563)
        Me.pnl_mon_stn1.TabIndex = 113
        '
        'TabPage21
        '
        Me.TabPage21.Controls.Add(Me.GroupBox97)
        Me.TabPage21.Controls.Add(Me.GroupBox91)
        Me.TabPage21.Controls.Add(Me.GroupBox94)
        Me.TabPage21.Controls.Add(Me.GroupBox100)
        Me.TabPage21.Location = New System.Drawing.Point(4, 38)
        Me.TabPage21.Name = "TabPage21"
        Me.TabPage21.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage21.Size = New System.Drawing.Size(844, 521)
        Me.TabPage21.TabIndex = 0
        Me.TabPage21.Text = "Station 1"
        Me.TabPage21.UseVisualStyleBackColor = True
        '
        'GroupBox97
        '
        Me.GroupBox97.AutoSize = True
        Me.GroupBox97.Controls.Add(Me.GroupBox98)
        Me.GroupBox97.Controls.Add(Me.GroupBox99)
        Me.GroupBox97.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox97.Location = New System.Drawing.Point(460, 273)
        Me.GroupBox97.Name = "GroupBox97"
        Me.GroupBox97.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox97.TabIndex = 48
        Me.GroupBox97.TabStop = False
        Me.GroupBox97.Text = "V104"
        Me.GroupBox97.Visible = False
        '
        'GroupBox98
        '
        Me.GroupBox98.Controls.Add(Me.Label129)
        Me.GroupBox98.Controls.Add(Me.Label130)
        Me.GroupBox98.Controls.Add(Me.mon_stn1_cyl4_min)
        Me.GroupBox98.Controls.Add(Me.mon_stn1_cyl4_max)
        Me.GroupBox98.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox98.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox98.Name = "GroupBox98"
        Me.GroupBox98.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox98.TabIndex = 3
        Me.GroupBox98.TabStop = False
        Me.GroupBox98.Text = "Sensor"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(20, 142)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(69, 18)
        Me.Label129.TabIndex = 1
        Me.Label129.Text = "Minimum"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(20, 66)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(73, 18)
        Me.Label130.TabIndex = 1
        Me.Label130.Text = "Maximum"
        '
        'mon_stn1_cyl4_min
        '
        Me.mon_stn1_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn1_cyl4_min.Name = "mon_stn1_cyl4_min"
        Me.mon_stn1_cyl4_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl4_min.TabIndex = 0
        Me.mon_stn1_cyl4_min.TabStop = False
        '
        'mon_stn1_cyl4_max
        '
        Me.mon_stn1_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn1_cyl4_max.Name = "mon_stn1_cyl4_max"
        Me.mon_stn1_cyl4_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl4_max.TabIndex = 0
        Me.mon_stn1_cyl4_max.TabStop = False
        '
        'GroupBox99
        '
        Me.GroupBox99.Controls.Add(Me.Label131)
        Me.GroupBox99.Controls.Add(Me.mon_stn1_cyl4_fw)
        Me.GroupBox99.Controls.Add(Me.Label132)
        Me.GroupBox99.Controls.Add(Me.mon_stn1_cyl4_bw)
        Me.GroupBox99.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox99.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox99.Name = "GroupBox99"
        Me.GroupBox99.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox99.TabIndex = 3
        Me.GroupBox99.TabStop = False
        Me.GroupBox99.Text = "Actuator"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(35, 142)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(52, 18)
        Me.Label131.TabIndex = 1
        Me.Label131.Text = "Return"
        '
        'mon_stn1_cyl4_fw
        '
        Me.mon_stn1_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl4_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn1_cyl4_fw.Name = "mon_stn1_cyl4_fw"
        Me.mon_stn1_cyl4_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl4_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl4_fw.TabIndex = 0
        Me.mon_stn1_cyl4_fw.TabStop = False
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(35, 66)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(53, 18)
        Me.Label132.TabIndex = 1
        Me.Label132.Text = "Extend"
        '
        'mon_stn1_cyl4_bw
        '
        Me.mon_stn1_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl4_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn1_cyl4_bw.Name = "mon_stn1_cyl4_bw"
        Me.mon_stn1_cyl4_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl4_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl4_bw.TabIndex = 0
        Me.mon_stn1_cyl4_bw.TabStop = False
        '
        'GroupBox91
        '
        Me.GroupBox91.AutoSize = True
        Me.GroupBox91.Controls.Add(Me.GroupBox92)
        Me.GroupBox91.Controls.Add(Me.GroupBox93)
        Me.GroupBox91.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox91.Location = New System.Drawing.Point(459, 30)
        Me.GroupBox91.Name = "GroupBox91"
        Me.GroupBox91.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox91.TabIndex = 49
        Me.GroupBox91.TabStop = False
        Me.GroupBox91.Text = "V102"
        Me.GroupBox91.Visible = False
        '
        'GroupBox92
        '
        Me.GroupBox92.Controls.Add(Me.Label104)
        Me.GroupBox92.Controls.Add(Me.Label106)
        Me.GroupBox92.Controls.Add(Me.mon_stn1_cyl2_min)
        Me.GroupBox92.Controls.Add(Me.mon_stn1_cyl2_max)
        Me.GroupBox92.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox92.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox92.Name = "GroupBox92"
        Me.GroupBox92.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox92.TabIndex = 3
        Me.GroupBox92.TabStop = False
        Me.GroupBox92.Text = "Sensor"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(20, 142)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(69, 18)
        Me.Label104.TabIndex = 1
        Me.Label104.Text = "Minimum"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(20, 66)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(73, 18)
        Me.Label106.TabIndex = 1
        Me.Label106.Text = "Maximum"
        '
        'mon_stn1_cyl2_min
        '
        Me.mon_stn1_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn1_cyl2_min.Name = "mon_stn1_cyl2_min"
        Me.mon_stn1_cyl2_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl2_min.TabIndex = 0
        Me.mon_stn1_cyl2_min.TabStop = False
        '
        'mon_stn1_cyl2_max
        '
        Me.mon_stn1_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn1_cyl2_max.Name = "mon_stn1_cyl2_max"
        Me.mon_stn1_cyl2_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl2_max.TabIndex = 0
        Me.mon_stn1_cyl2_max.TabStop = False
        '
        'GroupBox93
        '
        Me.GroupBox93.Controls.Add(Me.Label111)
        Me.GroupBox93.Controls.Add(Me.mon_stn1_cyl2_fw)
        Me.GroupBox93.Controls.Add(Me.Label112)
        Me.GroupBox93.Controls.Add(Me.mon_stn1_cyl2_bw)
        Me.GroupBox93.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox93.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox93.Name = "GroupBox93"
        Me.GroupBox93.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox93.TabIndex = 3
        Me.GroupBox93.TabStop = False
        Me.GroupBox93.Text = "Actuator"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.Location = New System.Drawing.Point(35, 142)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(52, 18)
        Me.Label111.TabIndex = 1
        Me.Label111.Text = "Return"
        '
        'mon_stn1_cyl2_fw
        '
        Me.mon_stn1_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl2_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn1_cyl2_fw.Name = "mon_stn1_cyl2_fw"
        Me.mon_stn1_cyl2_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl2_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl2_fw.TabIndex = 0
        Me.mon_stn1_cyl2_fw.TabStop = False
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(35, 66)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(53, 18)
        Me.Label112.TabIndex = 1
        Me.Label112.Text = "Extend"
        '
        'mon_stn1_cyl2_bw
        '
        Me.mon_stn1_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl2_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn1_cyl2_bw.Name = "mon_stn1_cyl2_bw"
        Me.mon_stn1_cyl2_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl2_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl2_bw.TabIndex = 0
        Me.mon_stn1_cyl2_bw.TabStop = False
        '
        'GroupBox94
        '
        Me.GroupBox94.AutoSize = True
        Me.GroupBox94.Controls.Add(Me.GroupBox95)
        Me.GroupBox94.Controls.Add(Me.GroupBox96)
        Me.GroupBox94.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox94.Location = New System.Drawing.Point(94, 273)
        Me.GroupBox94.Name = "GroupBox94"
        Me.GroupBox94.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox94.TabIndex = 50
        Me.GroupBox94.TabStop = False
        Me.GroupBox94.Text = "V103"
        Me.GroupBox94.Visible = False
        '
        'GroupBox95
        '
        Me.GroupBox95.Controls.Add(Me.Label118)
        Me.GroupBox95.Controls.Add(Me.Label120)
        Me.GroupBox95.Controls.Add(Me.mon_stn1_cyl3_min)
        Me.GroupBox95.Controls.Add(Me.mon_stn1_cyl3_max)
        Me.GroupBox95.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox95.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox95.Name = "GroupBox95"
        Me.GroupBox95.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox95.TabIndex = 3
        Me.GroupBox95.TabStop = False
        Me.GroupBox95.Text = "Sensor"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(20, 142)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(69, 18)
        Me.Label118.TabIndex = 1
        Me.Label118.Text = "Minimum"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(20, 66)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(73, 18)
        Me.Label120.TabIndex = 1
        Me.Label120.Text = "Maximum"
        '
        'mon_stn1_cyl3_min
        '
        Me.mon_stn1_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn1_cyl3_min.Name = "mon_stn1_cyl3_min"
        Me.mon_stn1_cyl3_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl3_min.TabIndex = 0
        Me.mon_stn1_cyl3_min.TabStop = False
        '
        'mon_stn1_cyl3_max
        '
        Me.mon_stn1_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn1_cyl3_max.Name = "mon_stn1_cyl3_max"
        Me.mon_stn1_cyl3_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl3_max.TabIndex = 0
        Me.mon_stn1_cyl3_max.TabStop = False
        '
        'GroupBox96
        '
        Me.GroupBox96.Controls.Add(Me.Label127)
        Me.GroupBox96.Controls.Add(Me.mon_stn1_cyl3_fw)
        Me.GroupBox96.Controls.Add(Me.Label128)
        Me.GroupBox96.Controls.Add(Me.mon_stn1_cyl3_bw)
        Me.GroupBox96.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox96.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox96.Name = "GroupBox96"
        Me.GroupBox96.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox96.TabIndex = 3
        Me.GroupBox96.TabStop = False
        Me.GroupBox96.Text = "Actuator"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(35, 142)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(52, 18)
        Me.Label127.TabIndex = 1
        Me.Label127.Text = "Return"
        '
        'mon_stn1_cyl3_fw
        '
        Me.mon_stn1_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl3_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn1_cyl3_fw.Name = "mon_stn1_cyl3_fw"
        Me.mon_stn1_cyl3_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl3_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl3_fw.TabIndex = 0
        Me.mon_stn1_cyl3_fw.TabStop = False
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(35, 66)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(53, 18)
        Me.Label128.TabIndex = 1
        Me.Label128.Text = "Extend"
        '
        'mon_stn1_cyl3_bw
        '
        Me.mon_stn1_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl3_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn1_cyl3_bw.Name = "mon_stn1_cyl3_bw"
        Me.mon_stn1_cyl3_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl3_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl3_bw.TabIndex = 0
        Me.mon_stn1_cyl3_bw.TabStop = False
        '
        'GroupBox100
        '
        Me.GroupBox100.AutoSize = True
        Me.GroupBox100.Controls.Add(Me.GroupBox101)
        Me.GroupBox100.Controls.Add(Me.GroupBox102)
        Me.GroupBox100.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox100.Location = New System.Drawing.Point(93, 30)
        Me.GroupBox100.Name = "GroupBox100"
        Me.GroupBox100.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox100.TabIndex = 51
        Me.GroupBox100.TabStop = False
        Me.GroupBox100.Text = "V101"
        '
        'GroupBox101
        '
        Me.GroupBox101.Controls.Add(Me.Label122)
        Me.GroupBox101.Controls.Add(Me.Label123)
        Me.GroupBox101.Controls.Add(Me.mon_stn1_cyl1_min)
        Me.GroupBox101.Controls.Add(Me.mon_stn1_cyl1_max)
        Me.GroupBox101.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox101.Location = New System.Drawing.Point(154, 37)
        Me.GroupBox101.Name = "GroupBox101"
        Me.GroupBox101.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox101.TabIndex = 3
        Me.GroupBox101.TabStop = False
        Me.GroupBox101.Text = "Sensor"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(20, 142)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(69, 18)
        Me.Label122.TabIndex = 1
        Me.Label122.Text = "Minimum"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(20, 66)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(73, 18)
        Me.Label123.TabIndex = 1
        Me.Label123.Text = "Maximum"
        '
        'mon_stn1_cyl1_min
        '
        Me.mon_stn1_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.mon_stn1_cyl1_min.Name = "mon_stn1_cyl1_min"
        Me.mon_stn1_cyl1_min.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl1_min.TabIndex = 0
        Me.mon_stn1_cyl1_min.TabStop = False
        '
        'mon_stn1_cyl1_max
        '
        Me.mon_stn1_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.mon_stn1_cyl1_max.Name = "mon_stn1_cyl1_max"
        Me.mon_stn1_cyl1_max.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl1_max.TabIndex = 0
        Me.mon_stn1_cyl1_max.TabStop = False
        '
        'GroupBox102
        '
        Me.GroupBox102.Controls.Add(Me.Label126)
        Me.GroupBox102.Controls.Add(Me.mon_stn1_cyl1_fw)
        Me.GroupBox102.Controls.Add(Me.Label125)
        Me.GroupBox102.Controls.Add(Me.mon_stn1_cyl1_bw)
        Me.GroupBox102.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox102.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox102.Name = "GroupBox102"
        Me.GroupBox102.Size = New System.Drawing.Size(120, 165)
        Me.GroupBox102.TabIndex = 3
        Me.GroupBox102.TabStop = False
        Me.GroupBox102.Text = "Actuator"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(35, 142)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(52, 18)
        Me.Label126.TabIndex = 1
        Me.Label126.Text = "Return"
        '
        'mon_stn1_cyl1_fw
        '
        Me.mon_stn1_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl1_fw.Location = New System.Drawing.Point(21, 31)
        Me.mon_stn1_cyl1_fw.Name = "mon_stn1_cyl1_fw"
        Me.mon_stn1_cyl1_fw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl1_fw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl1_fw.TabIndex = 0
        Me.mon_stn1_cyl1_fw.TabStop = False
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.Location = New System.Drawing.Point(35, 66)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(53, 18)
        Me.Label125.TabIndex = 1
        Me.Label125.Text = "Extend"
        '
        'mon_stn1_cyl1_bw
        '
        Me.mon_stn1_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.mon_stn1_cyl1_bw.Location = New System.Drawing.Point(21, 107)
        Me.mon_stn1_cyl1_bw.Name = "mon_stn1_cyl1_bw"
        Me.mon_stn1_cyl1_bw.Size = New System.Drawing.Size(80, 33)
        Me.mon_stn1_cyl1_bw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mon_stn1_cyl1_bw.TabIndex = 0
        Me.mon_stn1_cyl1_bw.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_run_state)
        Me.Controls.Add(Me.lbl_curr_time)
        Me.Controls.Add(Me.lbl_auto_man)
        Me.Controls.Add(Me.status_bar)
        Me.Controls.Add(Me.btn_stn6)
        Me.Controls.Add(Me.btn_stn5)
        Me.Controls.Add(Me.btn_stn4)
        Me.Controls.Add(Me.btn_log)
        Me.Controls.Add(Me.btn_ref)
        Me.Controls.Add(Me.btn_laser)
        Me.Controls.Add(Me.btn_multimeter)
        Me.Controls.Add(Me.btn_alarm)
        Me.Controls.Add(Me.btn_setting)
        Me.Controls.Add(Me.btn_stn3)
        Me.Controls.Add(Me.btn_monitoring)
        Me.Controls.Add(Me.btn_stn2)
        Me.Controls.Add(Me.btn_manual)
        Me.Controls.Add(Me.btn_stn1)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnl_home)
        Me.Controls.Add(Me.pnl_man_stn6)
        Me.Controls.Add(Me.pnl_man_stn5)
        Me.Controls.Add(Me.pnl_man_stn4)
        Me.Controls.Add(Me.pnl_man_stn3)
        Me.Controls.Add(Me.pnl_man_stn2)
        Me.Controls.Add(Me.pnl_man_stn1)
        Me.Controls.Add(Me.pnl_setting)
        Me.Controls.Add(Me.pnl_log)
        Me.Controls.Add(Me.pnl_ref)
        Me.Controls.Add(Me.pnl_laser)
        Me.Controls.Add(Me.pnl_multi)
        Me.Controls.Add(Me.pnl_alarm)
        Me.Controls.Add(Me.pnl_mon_stn6)
        Me.Controls.Add(Me.pnl_mon_stn5)
        Me.Controls.Add(Me.pnl_mon_stn4)
        Me.Controls.Add(Me.pnl_mon_stn3)
        Me.Controls.Add(Me.pnl_mon_stn2)
        Me.Controls.Add(Me.pnl_mon_stn1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XCS-E Contact Block Tester"
        CType(Me.status_bar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_home.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout
        CType(Me.ind_pass_fail, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox87.ResumeLayout(False)
        Me.GroupBox87.PerformLayout
        Me.GroupBox78.ResumeLayout(False)
        Me.GroupBox78.PerformLayout
        Me.GroupBox86.ResumeLayout(False)
        Me.GroupBox86.PerformLayout
        Me.GroupBox77.ResumeLayout(False)
        Me.GroupBox77.PerformLayout
        CType(Me.ind_software_stop, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_software_run, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_software_open, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox80.ResumeLayout(False)
        Me.GroupBox80.PerformLayout
        Me.GroupBox76.ResumeLayout(False)
        Me.GroupBox76.PerformLayout
        CType(Me.ind_plc_status, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_man_stn6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout
        Me.GroupBox88.ResumeLayout(False)
        Me.GroupBox89.ResumeLayout(False)
        Me.GroupBox89.PerformLayout
        CType(Me.stn6_cyl6_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_cyl6_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox90.ResumeLayout(False)
        Me.GroupBox73.ResumeLayout(False)
        Me.GroupBox74.ResumeLayout(False)
        Me.GroupBox74.PerformLayout
        CType(Me.stn6_cyl5_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_cyl5_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox75.ResumeLayout(False)
        Me.GroupBox67.ResumeLayout(False)
        Me.GroupBox68.ResumeLayout(False)
        Me.GroupBox68.PerformLayout
        CType(Me.stn6_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox69.ResumeLayout(False)
        Me.GroupBox64.ResumeLayout(False)
        Me.GroupBox65.ResumeLayout(False)
        Me.GroupBox65.PerformLayout
        CType(Me.stn6_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox66.ResumeLayout(False)
        Me.GroupBox61.ResumeLayout(False)
        Me.GroupBox62.ResumeLayout(False)
        Me.GroupBox62.PerformLayout
        CType(Me.stn6_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox63.ResumeLayout(False)
        Me.GroupBox70.ResumeLayout(False)
        Me.GroupBox71.ResumeLayout(False)
        Me.GroupBox71.PerformLayout
        CType(Me.stn6_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox72.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout
        Me.GroupBox58.ResumeLayout(False)
        Me.GroupBox60.ResumeLayout(False)
        Me.GroupBox59.ResumeLayout(False)
        Me.GroupBox59.PerformLayout
        CType(Me.stn5_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox55.ResumeLayout(False)
        Me.GroupBox57.ResumeLayout(False)
        Me.GroupBox56.ResumeLayout(False)
        Me.GroupBox56.PerformLayout
        CType(Me.stn5_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox52.ResumeLayout(False)
        Me.GroupBox54.ResumeLayout(False)
        Me.GroupBox53.ResumeLayout(False)
        Me.GroupBox53.PerformLayout
        CType(Me.stn5_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox49.ResumeLayout(False)
        Me.GroupBox51.ResumeLayout(False)
        Me.GroupBox50.ResumeLayout(False)
        Me.GroupBox50.PerformLayout
        CType(Me.stn5_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_man_stn5.ResumeLayout(False)
        Me.pnl_man_stn4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout
        Me.GroupBox37.ResumeLayout(False)
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox38.PerformLayout
        CType(Me.stn4_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn4_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox39.ResumeLayout(False)
        Me.GroupBox43.ResumeLayout(False)
        Me.GroupBox44.ResumeLayout(False)
        Me.GroupBox44.PerformLayout
        CType(Me.stn4_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn4_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox45.ResumeLayout(False)
        Me.GroupBox46.ResumeLayout(False)
        Me.GroupBox47.ResumeLayout(False)
        Me.GroupBox47.PerformLayout
        CType(Me.stn4_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn4_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox48.ResumeLayout(False)
        Me.GroupBox40.ResumeLayout(False)
        Me.GroupBox41.ResumeLayout(False)
        Me.GroupBox41.PerformLayout
        CType(Me.stn4_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn4_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox42.ResumeLayout(False)
        Me.pnl_man_stn3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout
        CType(Me.stn3_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn3_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout
        CType(Me.stn3_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn3_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout
        CType(Me.stn3_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn3_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox34.ResumeLayout(False)
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout
        CType(Me.stn3_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn3_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox36.ResumeLayout(False)
        Me.pnl_man_stn2.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout
        CType(Me.stn2_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn2_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout
        CType(Me.stn2_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn2_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout
        CType(Me.stn2_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn2_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout
        CType(Me.stn2_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn2_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox24.ResumeLayout(False)
        Me.pnl_man_stn1.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout
        CType(Me.stn1_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn1_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout
        CType(Me.stn1_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn1_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout
        CType(Me.stn1_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn1_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout
        CType(Me.stn1_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn1_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(False)
        Me.pnl_setting.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.GroupBox169.ResumeLayout(False)
        Me.GroupBox169.PerformLayout
        CType(Me.connect_multi_ind, System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_plc.ResumeLayout(False)
        Me.grp_plc.PerformLayout
        CType(Me.connect_plc_ind, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_log.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox174.ResumeLayout(False)
        Me.TabControl10.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_ref.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_ref, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox_Control.ResumeLayout(False)
        Me.GroupBox_Control.PerformLayout
        Me.pnl_laser.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        Me.GroupBox171.ResumeLayout(False)
        Me.GroupBox172.ResumeLayout(False)
        Me.GroupBox172.PerformLayout
        Me.GroupBox173.ResumeLayout(False)
        Me.GroupBox173.PerformLayout
        Me.pnl_multi.ResumeLayout(False)
        Me.TabPage14.ResumeLayout(False)
        Me.GroupBox170.ResumeLayout(False)
        Me.GroupBox170.PerformLayout
        Me.pnl_alarm.ResumeLayout(False)
        Me.TabPage15.ResumeLayout(False)
        Me.GroupBox85.ResumeLayout(False)
        Me.GroupBox85.PerformLayout
        CType(Me.ind_v602_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v601_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox83.ResumeLayout(False)
        Me.GroupBox83.PerformLayout
        CType(Me.ind_v402_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v401_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox84.ResumeLayout(False)
        Me.GroupBox84.PerformLayout
        CType(Me.ind_v502_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v501_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox82.ResumeLayout(False)
        Me.GroupBox82.PerformLayout
        CType(Me.ind_v302_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v301_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox81.ResumeLayout(False)
        Me.GroupBox81.PerformLayout
        CType(Me.ind_v202_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v201_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox79.ResumeLayout(False)
        Me.GroupBox79.PerformLayout
        CType(Me.ind_emg_button, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_door_lock_6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_altivar_fault, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_door_lock_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_door_lock_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_air_presence, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_door_lock_5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_door_lock_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_door_lock_1, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_mon_stn6.ResumeLayout(False)
        Me.TabPage16.ResumeLayout(False)
        Me.TabPage16.PerformLayout
        Me.GroupBox151.ResumeLayout(False)
        Me.GroupBox152.ResumeLayout(False)
        Me.GroupBox152.PerformLayout
        CType(Me.mon_stn6_cyl6_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl6_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox153.ResumeLayout(False)
        Me.GroupBox153.PerformLayout
        CType(Me.mon_stn6_cyl6_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl6_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox154.ResumeLayout(False)
        Me.GroupBox155.ResumeLayout(False)
        Me.GroupBox155.PerformLayout
        CType(Me.mon_stn6_cyl5_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl5_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox156.ResumeLayout(False)
        Me.GroupBox156.PerformLayout
        CType(Me.mon_stn6_cyl5_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl5_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox157.ResumeLayout(False)
        Me.GroupBox158.ResumeLayout(False)
        Me.GroupBox158.PerformLayout
        CType(Me.mon_stn6_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox159.ResumeLayout(False)
        Me.GroupBox159.PerformLayout
        CType(Me.mon_stn6_cyl4_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl4_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox160.ResumeLayout(False)
        Me.GroupBox161.ResumeLayout(False)
        Me.GroupBox161.PerformLayout
        CType(Me.mon_stn6_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox162.ResumeLayout(False)
        Me.GroupBox162.PerformLayout
        CType(Me.mon_stn6_cyl3_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl3_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox163.ResumeLayout(False)
        Me.GroupBox164.ResumeLayout(False)
        Me.GroupBox164.PerformLayout
        CType(Me.mon_stn6_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox165.ResumeLayout(False)
        Me.GroupBox165.PerformLayout
        CType(Me.mon_stn6_cyl2_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl2_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox166.ResumeLayout(False)
        Me.GroupBox167.ResumeLayout(False)
        Me.GroupBox167.PerformLayout
        CType(Me.mon_stn6_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox168.ResumeLayout(False)
        Me.GroupBox168.PerformLayout
        CType(Me.mon_stn6_cyl1_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn6_cyl1_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_mon_stn5.ResumeLayout(False)
        Me.TabPage17.ResumeLayout(False)
        Me.TabPage17.PerformLayout
        Me.GroupBox139.ResumeLayout(False)
        Me.GroupBox140.ResumeLayout(False)
        Me.GroupBox140.PerformLayout
        CType(Me.mon_stn5_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox141.ResumeLayout(False)
        Me.GroupBox141.PerformLayout
        CType(Me.mon_stn5_cyl4_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl4_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox142.ResumeLayout(False)
        Me.GroupBox143.ResumeLayout(False)
        Me.GroupBox143.PerformLayout
        CType(Me.mon_stn5_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox144.ResumeLayout(False)
        Me.GroupBox144.PerformLayout
        CType(Me.mon_stn5_cyl2_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl2_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox145.ResumeLayout(False)
        Me.GroupBox146.ResumeLayout(False)
        Me.GroupBox146.PerformLayout
        CType(Me.mon_stn5_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox147.ResumeLayout(False)
        Me.GroupBox147.PerformLayout
        CType(Me.mon_stn5_cyl3_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl3_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox148.ResumeLayout(False)
        Me.GroupBox149.ResumeLayout(False)
        Me.GroupBox149.PerformLayout
        CType(Me.mon_stn5_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox150.ResumeLayout(False)
        Me.GroupBox150.PerformLayout
        CType(Me.mon_stn5_cyl1_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn5_cyl1_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_mon_stn4.ResumeLayout(False)
        Me.TabPage18.ResumeLayout(False)
        Me.TabPage18.PerformLayout
        Me.GroupBox127.ResumeLayout(False)
        Me.GroupBox128.ResumeLayout(False)
        Me.GroupBox128.PerformLayout
        CType(Me.mon_stn4_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox129.ResumeLayout(False)
        Me.GroupBox129.PerformLayout
        CType(Me.mon_stn4_cyl4_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl4_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox130.ResumeLayout(False)
        Me.GroupBox131.ResumeLayout(False)
        Me.GroupBox131.PerformLayout
        CType(Me.mon_stn4_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox132.ResumeLayout(False)
        Me.GroupBox132.PerformLayout
        CType(Me.mon_stn4_cyl2_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl2_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox133.ResumeLayout(False)
        Me.GroupBox134.ResumeLayout(False)
        Me.GroupBox134.PerformLayout
        CType(Me.mon_stn4_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox135.ResumeLayout(False)
        Me.GroupBox135.PerformLayout
        CType(Me.mon_stn4_cyl3_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl3_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox136.ResumeLayout(False)
        Me.GroupBox137.ResumeLayout(False)
        Me.GroupBox137.PerformLayout
        CType(Me.mon_stn4_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox138.ResumeLayout(False)
        Me.GroupBox138.PerformLayout
        CType(Me.mon_stn4_cyl1_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn4_cyl1_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_mon_stn3.ResumeLayout(False)
        Me.TabPage19.ResumeLayout(False)
        Me.TabPage19.PerformLayout
        Me.GroupBox115.ResumeLayout(False)
        Me.GroupBox116.ResumeLayout(False)
        Me.GroupBox116.PerformLayout
        CType(Me.mon_stn3_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox117.ResumeLayout(False)
        Me.GroupBox117.PerformLayout
        CType(Me.mon_stn3_cyl4_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl4_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox118.ResumeLayout(False)
        Me.GroupBox119.ResumeLayout(False)
        Me.GroupBox119.PerformLayout
        CType(Me.mon_stn3_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox120.ResumeLayout(False)
        Me.GroupBox120.PerformLayout
        CType(Me.mon_stn3_cyl2_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl2_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox121.ResumeLayout(False)
        Me.GroupBox122.ResumeLayout(False)
        Me.GroupBox122.PerformLayout
        CType(Me.mon_stn3_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox123.ResumeLayout(False)
        Me.GroupBox123.PerformLayout
        CType(Me.mon_stn3_cyl3_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl3_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox124.ResumeLayout(False)
        Me.GroupBox125.ResumeLayout(False)
        Me.GroupBox125.PerformLayout
        CType(Me.mon_stn3_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox126.ResumeLayout(False)
        Me.GroupBox126.PerformLayout
        CType(Me.mon_stn3_cyl1_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn3_cyl1_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_mon_stn2.ResumeLayout(False)
        Me.TabPage20.ResumeLayout(False)
        Me.TabPage20.PerformLayout
        Me.GroupBox103.ResumeLayout(False)
        Me.GroupBox104.ResumeLayout(False)
        Me.GroupBox104.PerformLayout
        CType(Me.mon_stn2_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox105.ResumeLayout(False)
        Me.GroupBox105.PerformLayout
        CType(Me.mon_stn2_cyl4_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl4_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox106.ResumeLayout(False)
        Me.GroupBox107.ResumeLayout(False)
        Me.GroupBox107.PerformLayout
        CType(Me.mon_stn2_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox108.ResumeLayout(False)
        Me.GroupBox108.PerformLayout
        CType(Me.mon_stn2_cyl2_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl2_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox109.ResumeLayout(False)
        Me.GroupBox110.ResumeLayout(False)
        Me.GroupBox110.PerformLayout
        CType(Me.mon_stn2_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox111.ResumeLayout(False)
        Me.GroupBox111.PerformLayout
        CType(Me.mon_stn2_cyl3_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl3_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox112.ResumeLayout(False)
        Me.GroupBox113.ResumeLayout(False)
        Me.GroupBox113.PerformLayout
        CType(Me.mon_stn2_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox114.ResumeLayout(False)
        Me.GroupBox114.PerformLayout
        CType(Me.mon_stn2_cyl1_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn2_cyl1_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_mon_stn1.ResumeLayout(False)
        Me.TabPage21.ResumeLayout(False)
        Me.TabPage21.PerformLayout
        Me.GroupBox97.ResumeLayout(False)
        Me.GroupBox98.ResumeLayout(False)
        Me.GroupBox98.PerformLayout
        CType(Me.mon_stn1_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox99.ResumeLayout(False)
        Me.GroupBox99.PerformLayout
        CType(Me.mon_stn1_cyl4_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl4_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox91.ResumeLayout(False)
        Me.GroupBox92.ResumeLayout(False)
        Me.GroupBox92.PerformLayout
        CType(Me.mon_stn1_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox93.ResumeLayout(False)
        Me.GroupBox93.PerformLayout
        CType(Me.mon_stn1_cyl2_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl2_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox94.ResumeLayout(False)
        Me.GroupBox95.ResumeLayout(False)
        Me.GroupBox95.PerformLayout
        CType(Me.mon_stn1_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox96.ResumeLayout(False)
        Me.GroupBox96.PerformLayout
        CType(Me.mon_stn1_cyl3_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl3_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox100.ResumeLayout(False)
        Me.GroupBox101.ResumeLayout(False)
        Me.GroupBox101.PerformLayout
        CType(Me.mon_stn1_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox102.ResumeLayout(False)
        Me.GroupBox102.PerformLayout
        CType(Me.mon_stn1_cyl1_fw, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mon_stn1_cyl1_bw, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents btn_setting As Button
    Friend WithEvents btn_monitoring As Button
    Friend WithEvents btn_manual As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dateTime As Timer
    Friend WithEvents btn_stn6 As Button
    Friend WithEvents btn_stn5 As Button
    Friend WithEvents btn_stn4 As Button
    Friend WithEvents btn_stn3 As Button
    Friend WithEvents btn_stn2 As Button
    Friend WithEvents btn_stn1 As Button
    Friend WithEvents ModbusRW As Timer
    Friend WithEvents Status As Timer
    Friend WithEvents BarcodeComm As IO.Ports.SerialPort
    Friend WithEvents btn_alarm As Button
    Friend WithEvents ST2 As Timer
    Friend WithEvents ST3 As Timer
    Friend WithEvents ST4 As Timer
    Friend WithEvents ST5 As Timer
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_run_state As Label
    Friend WithEvents lbl_curr_time As Label
    Friend WithEvents lbl_auto_man As Label
    Friend WithEvents status_bar As PictureBox
    Friend WithEvents btn_multimeter As Button
    Friend WithEvents btn_laser As Button
    Friend WithEvents btn_ref As Button
    Friend WithEvents btn_log As Button
    Friend WithEvents pnl_home As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ind_pass_fail As PictureBox
    Friend WithEvents GroupBox87 As GroupBox
    Friend WithEvents btn_clear_database As Button
    Friend WithEvents Label105 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents lbl_cnt_st5 As Label
    Friend WithEvents lbl_cnt_st4 As Label
    Friend WithEvents lbl_cnt_st3 As Label
    Friend WithEvents lbl_cnt_st2 As Label
    Friend WithEvents GroupBox78 As GroupBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents laabel2 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents laabel3 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents laabel1 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents lbl_unscrew_status As Label
    Friend WithEvents lbl_st4_t2 As Label
    Friend WithEvents lbl_st4_p2 As Label
    Friend WithEvents lbl_diff_result As Label
    Friend WithEvents lbl_st2_meas As Label
    Friend WithEvents lbl_cot As Label
    Friend WithEvents lbl_st4_t1 As Label
    Friend WithEvents lbl_st3_res As Label
    Friend WithEvents lbl_st4_p3 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents GroupBox86 As GroupBox
    Friend WithEvents Label114 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents lbl_laser_template As Label
    Friend WithEvents lbl_unscrew_process As Label
    Friend WithEvents lbl_dif_str_tol As Label
    Friend WithEvents lbl_cfg_1st As Label
    Friend WithEvents lbl_act_val_tol As Label
    Friend WithEvents lbl_laser_datecode As Label
    Friend WithEvents lbl_cfg_2nd As Label
    Friend WithEvents lbl_dif_str As Label
    Friend WithEvents lbl_beating_times As Label
    Friend WithEvents lbl_act_val As Label
    Friend WithEvents GroupBox77 As GroupBox
    Friend WithEvents ind_software_stop As PictureBox
    Friend WithEvents Label67 As Label
    Friend WithEvents ind_software_run As PictureBox
    Friend WithEvents Label66 As Label
    Friend WithEvents ind_software_open As PictureBox
    Friend WithEvents Label65 As Label
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_run As Button
    Friend WithEvents GroupBox80 As GroupBox
    Friend WithEvents Label85 As Label
    Friend WithEvents lbl_po_num As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents lbl_ope_id As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label80 As Label
    Friend WithEvents lbl_ref As Label
    Friend WithEvents GroupBox76 As GroupBox
    Friend WithEvents ind_plc_status As PictureBox
    Friend WithEvents Label64 As Label
    Friend WithEvents lbl_cnt As Label
    Friend WithEvents lbl_op_ins As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents pnl_man_stn6 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox88 As GroupBox
    Friend WithEvents GroupBox89 As GroupBox
    Friend WithEvents Label97 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents stn6_cyl6_min As PictureBox
    Friend WithEvents stn6_cyl6_max As PictureBox
    Friend WithEvents GroupBox90 As GroupBox
    Friend WithEvents btn_stn6_cyl6_fw As Button
    Friend WithEvents btn_stn6_cyl6_bw As Button
    Friend WithEvents GroupBox73 As GroupBox
    Friend WithEvents GroupBox74 As GroupBox
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents stn6_cyl5_min As PictureBox
    Friend WithEvents stn6_cyl5_max As PictureBox
    Friend WithEvents GroupBox75 As GroupBox
    Friend WithEvents btn_stn6_cyl5_fw As Button
    Friend WithEvents btn_stn6_cyl5_bw As Button
    Friend WithEvents GroupBox67 As GroupBox
    Friend WithEvents GroupBox68 As GroupBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents stn6_cyl4_min As PictureBox
    Friend WithEvents stn6_cyl4_max As PictureBox
    Friend WithEvents GroupBox69 As GroupBox
    Friend WithEvents btn_stn6_cyl4_fw As Button
    Friend WithEvents btn_stn6_cyl4_bw As Button
    Friend WithEvents GroupBox64 As GroupBox
    Friend WithEvents GroupBox65 As GroupBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents stn6_cyl3_min As PictureBox
    Friend WithEvents stn6_cyl3_max As PictureBox
    Friend WithEvents GroupBox66 As GroupBox
    Friend WithEvents btn_stn6_cyl3_fw As Button
    Friend WithEvents btn_stn6_cyl3_bw As Button
    Friend WithEvents GroupBox61 As GroupBox
    Friend WithEvents GroupBox62 As GroupBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents stn6_cyl2_min As PictureBox
    Friend WithEvents stn6_cyl2_max As PictureBox
    Friend WithEvents GroupBox63 As GroupBox
    Friend WithEvents btn_stn6_cyl2_fw As Button
    Friend WithEvents btn_stn6_cyl2_bw As Button
    Friend WithEvents GroupBox70 As GroupBox
    Friend WithEvents GroupBox71 As GroupBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents stn6_cyl1_min As PictureBox
    Friend WithEvents stn6_cyl1_max As PictureBox
    Friend WithEvents GroupBox72 As GroupBox
    Friend WithEvents btn_stn6_cyl1_fw As Button
    Friend WithEvents btn_stn6_cyl1_bw As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox49 As GroupBox
    Friend WithEvents GroupBox50 As GroupBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents stn5_cyl4_min As PictureBox
    Friend WithEvents stn5_cyl4_max As PictureBox
    Friend WithEvents GroupBox51 As GroupBox
    Friend WithEvents btn_stn5_cyl4_fw As Button
    Friend WithEvents btn_stn5_cyl4_bw As Button
    Friend WithEvents GroupBox52 As GroupBox
    Friend WithEvents GroupBox53 As GroupBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents stn5_cyl2_min As PictureBox
    Friend WithEvents stn5_cyl2_max As PictureBox
    Friend WithEvents GroupBox54 As GroupBox
    Friend WithEvents btn_stn5_cyl2_fw As Button
    Friend WithEvents btn_stn5_cyl2_bw As Button
    Friend WithEvents GroupBox55 As GroupBox
    Friend WithEvents GroupBox56 As GroupBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents stn5_cyl3_min As PictureBox
    Friend WithEvents stn5_cyl3_max As PictureBox
    Friend WithEvents GroupBox57 As GroupBox
    Friend WithEvents btn_stn5_cyl3_fw As Button
    Friend WithEvents btn_stn5_cyl3_bw As Button
    Friend WithEvents GroupBox58 As GroupBox
    Friend WithEvents GroupBox59 As GroupBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents stn5_cyl1_min As PictureBox
    Friend WithEvents stn5_cyl1_max As PictureBox
    Friend WithEvents GroupBox60 As GroupBox
    Friend WithEvents btn_stn5_cyl1_fw As Button
    Friend WithEvents btn_stn5_cyl1_bw As Button
    Friend WithEvents pnl_man_stn5 As TabControl
    Friend WithEvents pnl_man_stn4 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBox37 As GroupBox
    Friend WithEvents GroupBox38 As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents stn4_cyl4_min As PictureBox
    Friend WithEvents stn4_cyl4_max As PictureBox
    Friend WithEvents GroupBox39 As GroupBox
    Friend WithEvents btn_stn4_cyl4_fw As Button
    Friend WithEvents btn_stn4_cyl4_bw As Button
    Friend WithEvents GroupBox43 As GroupBox
    Friend WithEvents GroupBox44 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents stn4_cyl3_min As PictureBox
    Friend WithEvents stn4_cyl3_max As PictureBox
    Friend WithEvents GroupBox45 As GroupBox
    Friend WithEvents btn_stn4_cyl3_fw As Button
    Friend WithEvents btn_stn4_cyl3_bw As Button
    Friend WithEvents GroupBox46 As GroupBox
    Friend WithEvents GroupBox47 As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents stn4_cyl1_min As PictureBox
    Friend WithEvents stn4_cyl1_max As PictureBox
    Friend WithEvents GroupBox48 As GroupBox
    Friend WithEvents btn_stn4_cyl1_fw As Button
    Friend WithEvents btn_stn4_cyl1_bw As Button
    Friend WithEvents GroupBox40 As GroupBox
    Friend WithEvents GroupBox41 As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents stn4_cyl2_min As PictureBox
    Friend WithEvents stn4_cyl2_max As PictureBox
    Friend WithEvents GroupBox42 As GroupBox
    Friend WithEvents btn_stn4_cyl2_fw As Button
    Friend WithEvents btn_stn4_cyl2_bw As Button
    Friend WithEvents pnl_man_stn3 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents stn3_cyl4_min As PictureBox
    Friend WithEvents stn3_cyl4_max As PictureBox
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents btn_stn3_cyl4_fw As Button
    Friend WithEvents btn_stn3_cyl4_bw As Button
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents stn3_cyl2_min As PictureBox
    Friend WithEvents stn3_cyl2_max As PictureBox
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents btn_stn3_cyl2_fw As Button
    Friend WithEvents btn_stn3_cyl2_bw As Button
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents GroupBox32 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents stn3_cyl3_min As PictureBox
    Friend WithEvents stn3_cyl3_max As PictureBox
    Friend WithEvents GroupBox33 As GroupBox
    Friend WithEvents btn_stn3_cyl3_fw As Button
    Friend WithEvents btn_stn3_cyl3_bw As Button
    Friend WithEvents GroupBox34 As GroupBox
    Friend WithEvents GroupBox35 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents stn3_cyl1_min As PictureBox
    Friend WithEvents stn3_cyl1_max As PictureBox
    Friend WithEvents GroupBox36 As GroupBox
    Friend WithEvents btn_stn3_cyl1_fw As Button
    Friend WithEvents btn_stn3_cyl1_bw As Button
    Friend WithEvents pnl_man_stn2 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents stn2_cyl4_min As PictureBox
    Friend WithEvents stn2_cyl4_max As PictureBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents btn_stn2_cyl4_fw As Button
    Friend WithEvents btn_stn2_cyl4_bw As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents stn2_cyl2_min As PictureBox
    Friend WithEvents stn2_cyl2_max As PictureBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents btn_stn2_cyl2_fw As Button
    Friend WithEvents btn_stn2_cyl2_bw As Button
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents stn2_cyl3_min As PictureBox
    Friend WithEvents stn2_cyl3_max As PictureBox
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents btn_stn2_cyl3_fw As Button
    Friend WithEvents btn_stn2_cyl3_bw As Button
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents stn2_cyl1_min As PictureBox
    Friend WithEvents stn2_cyl1_max As PictureBox
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents btn_stn2_cyl1_fw As Button
    Friend WithEvents btn_stn2_cyl1_bw As Button
    Friend WithEvents pnl_man_stn1 As TabControl
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents stn1_cyl4_min As PictureBox
    Friend WithEvents stn1_cyl4_max As PictureBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents btn_stn1_cyl4_fw As Button
    Friend WithEvents btn_stn1_cyl4_bw As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents stn1_cyl2_min As PictureBox
    Friend WithEvents stn1_cyl2_max As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btn_stn1_cyl2_fw As Button
    Friend WithEvents btn_stn1_cyl2_bw As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents stn1_cyl3_min As PictureBox
    Friend WithEvents stn1_cyl3_max As PictureBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents btn_stn1_cyl3_fw As Button
    Friend WithEvents btn_stn1_cyl3_bw As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents stn1_cyl1_min As PictureBox
    Friend WithEvents stn1_cyl1_max As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_stn1_cyl1_fw As Button
    Friend WithEvents btn_stn1_cyl1_bw As Button
    Friend WithEvents pnl_setting As TabControl
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents GroupBox169 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents connect_multi_ind As PictureBox
    Friend WithEvents Label226 As Label
    Friend WithEvents txtIP_multi As TextBox
    Friend WithEvents btn_check_multi As Button
    Friend WithEvents btn_connect_multi As Button
    Friend WithEvents txtPort_multi As TextBox
    Friend WithEvents grp_plc As GroupBox
    Friend WithEvents cbo_data_type As ComboBox
    Friend WithEvents connect_plc_ind As PictureBox
    Friend WithEvents btn_write As Button
    Friend WithEvents btn_connect_plc As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents txtPort_PLC As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtIP_PLC As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pnl_log As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox174 As GroupBox
    Friend WithEvents TabControl10 As TabControl
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents btn_search As Button
    Friend WithEvents Label249 As Label
    Friend WithEvents DateTimePickerEndDate As DateTimePicker
    Friend WithEvents Label250 As Label
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents cb_search_opt As ComboBox
    Friend WithEvents btn_search_other As Button
    Friend WithEvents txt_find_other As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnl_ref As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_ref As DataGridView
    Friend WithEvents GroupBox_Control As GroupBox
    Friend WithEvents txt_laser_template_pnl As TextBox
    Friend WithEvents txt_beating_times_pnl As TextBox
    Friend WithEvents Label247 As Label
    Friend WithEvents Label237 As Label
    Friend WithEvents txt_laser_datecode_pnl As TextBox
    Friend WithEvents txt_dif_str_tol_pnl As TextBox
    Friend WithEvents Label246 As Label
    Friend WithEvents Label238 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_unscrew_pnl As TextBox
    Friend WithEvents txt_dif_str_pnl As TextBox
    Friend WithEvents txt_cfg_2nd_pnl As TextBox
    Friend WithEvents txt_act_val_tol_pnl As TextBox
    Friend WithEvents Label245 As Label
    Friend WithEvents Label239 As Label
    Friend WithEvents Label244 As Label
    Friend WithEvents Label240 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_cfg_1st_pnl As TextBox
    Friend WithEvents txt_act_val_pnl As TextBox
    Friend WithEvents Label243 As Label
    Friend WithEvents txt_ref_pnl As TextBox
    Friend WithEvents Label241 As Label
    Friend WithEvents Label242 As Label
    Friend WithEvents pnl_laser As TabControl
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents GroupBox171 As GroupBox
    Friend WithEvents GroupBox172 As GroupBox
    Friend WithEvents txt_comm_log As TextBox
    Friend WithEvents GroupBox173 As GroupBox
    Friend WithEvents btn_mark_flag As Button
    Friend WithEvents btn_change_prg As Button
    Friend WithEvents btn_start_marking As Button
    Friend WithEvents btn_string_char As Button
    Friend WithEvents txt_block2 As TextBox
    Friend WithEvents txt_block1 As TextBox
    Friend WithEvents txt_block0 As TextBox
    Friend WithEvents Label232 As Label
    Friend WithEvents chb_mark_cavity_1 As CheckBox
    Friend WithEvents Label233 As Label
    Friend WithEvents cb_prg_num As ComboBox
    Friend WithEvents Label234 As Label
    Friend WithEvents Label235 As Label
    Friend WithEvents pnl_multi As TabControl
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents GroupBox170 As GroupBox
    Friend WithEvents Label229 As Label
    Friend WithEvents Label230 As Label
    Friend WithEvents txt_ch_1 As TextBox
    Friend WithEvents btn_read_ch_2 As Button
    Friend WithEvents btn_read_ch_1 As Button
    Friend WithEvents txt_ch_2 As TextBox
    Friend WithEvents pnl_alarm As TabControl
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents GroupBox85 As GroupBox
    Friend WithEvents ind_v602_descrepancy As PictureBox
    Friend WithEvents Label94 As Label
    Friend WithEvents ind_v601_descrepancy As PictureBox
    Friend WithEvents Label96 As Label
    Friend WithEvents GroupBox83 As GroupBox
    Friend WithEvents ind_v402_descrepancy As PictureBox
    Friend WithEvents Label89 As Label
    Friend WithEvents ind_v401_descrepancy As PictureBox
    Friend WithEvents Label90 As Label
    Friend WithEvents GroupBox84 As GroupBox
    Friend WithEvents ind_v502_descrepancy As PictureBox
    Friend WithEvents Label92 As Label
    Friend WithEvents ind_v501_descrepancy As PictureBox
    Friend WithEvents Label93 As Label
    Friend WithEvents GroupBox82 As GroupBox
    Friend WithEvents ind_v302_descrepancy As PictureBox
    Friend WithEvents Label87 As Label
    Friend WithEvents ind_v301_descrepancy As PictureBox
    Friend WithEvents Label88 As Label
    Friend WithEvents GroupBox81 As GroupBox
    Friend WithEvents ind_v202_descrepancy As PictureBox
    Friend WithEvents Label91 As Label
    Friend WithEvents ind_v201_descrepancy As PictureBox
    Friend WithEvents Label95 As Label
    Friend WithEvents GroupBox79 As GroupBox
    Friend WithEvents ind_emg_button As PictureBox
    Friend WithEvents ind_door_lock_6 As PictureBox
    Friend WithEvents ind_altivar_fault As PictureBox
    Friend WithEvents ind_door_lock_4 As PictureBox
    Friend WithEvents Label79 As Label
    Friend WithEvents ind_door_lock_2 As PictureBox
    Friend WithEvents Label78 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents ind_air_presence As PictureBox
    Friend WithEvents Label70 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents ind_door_lock_5 As PictureBox
    Friend WithEvents Label75 As Label
    Friend WithEvents ind_door_lock_3 As PictureBox
    Friend WithEvents Label73 As Label
    Friend WithEvents ind_door_lock_1 As PictureBox
    Friend WithEvents Label69 As Label
    Friend WithEvents pnl_mon_stn6 As TabControl
    Friend WithEvents TabPage16 As TabPage
    Friend WithEvents GroupBox151 As GroupBox
    Friend WithEvents GroupBox152 As GroupBox
    Friend WithEvents Label201 As Label
    Friend WithEvents Label202 As Label
    Friend WithEvents mon_stn6_cyl6_min As PictureBox
    Friend WithEvents mon_stn6_cyl6_max As PictureBox
    Friend WithEvents GroupBox153 As GroupBox
    Friend WithEvents Label214 As Label
    Friend WithEvents mon_stn6_cyl6_fw As PictureBox
    Friend WithEvents Label213 As Label
    Friend WithEvents mon_stn6_cyl6_bw As PictureBox
    Friend WithEvents GroupBox154 As GroupBox
    Friend WithEvents GroupBox155 As GroupBox
    Friend WithEvents Label203 As Label
    Friend WithEvents Label204 As Label
    Friend WithEvents mon_stn6_cyl5_min As PictureBox
    Friend WithEvents mon_stn6_cyl5_max As PictureBox
    Friend WithEvents GroupBox156 As GroupBox
    Friend WithEvents Label225 As Label
    Friend WithEvents mon_stn6_cyl5_fw As PictureBox
    Friend WithEvents Label224 As Label
    Friend WithEvents mon_stn6_cyl5_bw As PictureBox
    Friend WithEvents GroupBox157 As GroupBox
    Friend WithEvents GroupBox158 As GroupBox
    Friend WithEvents Label205 As Label
    Friend WithEvents Label206 As Label
    Friend WithEvents mon_stn6_cyl4_min As PictureBox
    Friend WithEvents mon_stn6_cyl4_max As PictureBox
    Friend WithEvents GroupBox159 As GroupBox
    Friend WithEvents Label223 As Label
    Friend WithEvents mon_stn6_cyl4_fw As PictureBox
    Friend WithEvents Label222 As Label
    Friend WithEvents mon_stn6_cyl4_bw As PictureBox
    Friend WithEvents GroupBox160 As GroupBox
    Friend WithEvents GroupBox161 As GroupBox
    Friend WithEvents Label207 As Label
    Friend WithEvents Label208 As Label
    Friend WithEvents mon_stn6_cyl3_min As PictureBox
    Friend WithEvents mon_stn6_cyl3_max As PictureBox
    Friend WithEvents GroupBox162 As GroupBox
    Friend WithEvents Label216 As Label
    Friend WithEvents mon_stn6_cyl3_fw As PictureBox
    Friend WithEvents Label215 As Label
    Friend WithEvents mon_stn6_cyl3_bw As PictureBox
    Friend WithEvents GroupBox163 As GroupBox
    Friend WithEvents GroupBox164 As GroupBox
    Friend WithEvents Label209 As Label
    Friend WithEvents Label210 As Label
    Friend WithEvents mon_stn6_cyl2_min As PictureBox
    Friend WithEvents mon_stn6_cyl2_max As PictureBox
    Friend WithEvents GroupBox165 As GroupBox
    Friend WithEvents Label219 As Label
    Friend WithEvents mon_stn6_cyl2_fw As PictureBox
    Friend WithEvents Label218 As Label
    Friend WithEvents mon_stn6_cyl2_bw As PictureBox
    Friend WithEvents GroupBox166 As GroupBox
    Friend WithEvents GroupBox167 As GroupBox
    Friend WithEvents Label211 As Label
    Friend WithEvents Label212 As Label
    Friend WithEvents mon_stn6_cyl1_min As PictureBox
    Friend WithEvents mon_stn6_cyl1_max As PictureBox
    Friend WithEvents GroupBox168 As GroupBox
    Friend WithEvents Label221 As Label
    Friend WithEvents mon_stn6_cyl1_fw As PictureBox
    Friend WithEvents Label220 As Label
    Friend WithEvents mon_stn6_cyl1_bw As PictureBox
    Friend WithEvents pnl_mon_stn5 As TabControl
    Friend WithEvents TabPage17 As TabPage
    Friend WithEvents GroupBox139 As GroupBox
    Friend WithEvents GroupBox140 As GroupBox
    Friend WithEvents Label184 As Label
    Friend WithEvents Label185 As Label
    Friend WithEvents mon_stn5_cyl4_min As PictureBox
    Friend WithEvents mon_stn5_cyl4_max As PictureBox
    Friend WithEvents GroupBox141 As GroupBox
    Friend WithEvents Label186 As Label
    Friend WithEvents mon_stn5_cyl4_fw As PictureBox
    Friend WithEvents Label187 As Label
    Friend WithEvents mon_stn5_cyl4_bw As PictureBox
    Friend WithEvents GroupBox142 As GroupBox
    Friend WithEvents GroupBox143 As GroupBox
    Friend WithEvents Label188 As Label
    Friend WithEvents Label189 As Label
    Friend WithEvents mon_stn5_cyl2_min As PictureBox
    Friend WithEvents mon_stn5_cyl2_max As PictureBox
    Friend WithEvents GroupBox144 As GroupBox
    Friend WithEvents Label190 As Label
    Friend WithEvents mon_stn5_cyl2_fw As PictureBox
    Friend WithEvents Label191 As Label
    Friend WithEvents mon_stn5_cyl2_bw As PictureBox
    Friend WithEvents GroupBox145 As GroupBox
    Friend WithEvents GroupBox146 As GroupBox
    Friend WithEvents Label192 As Label
    Friend WithEvents Label193 As Label
    Friend WithEvents mon_stn5_cyl3_min As PictureBox
    Friend WithEvents mon_stn5_cyl3_max As PictureBox
    Friend WithEvents GroupBox147 As GroupBox
    Friend WithEvents Label194 As Label
    Friend WithEvents mon_stn5_cyl3_fw As PictureBox
    Friend WithEvents Label195 As Label
    Friend WithEvents mon_stn5_cyl3_bw As PictureBox
    Friend WithEvents GroupBox148 As GroupBox
    Friend WithEvents GroupBox149 As GroupBox
    Friend WithEvents Label196 As Label
    Friend WithEvents Label197 As Label
    Friend WithEvents mon_stn5_cyl1_min As PictureBox
    Friend WithEvents mon_stn5_cyl1_max As PictureBox
    Friend WithEvents GroupBox150 As GroupBox
    Friend WithEvents Label198 As Label
    Friend WithEvents mon_stn5_cyl1_fw As PictureBox
    Friend WithEvents Label199 As Label
    Friend WithEvents mon_stn5_cyl1_bw As PictureBox
    Friend WithEvents pnl_mon_stn4 As TabControl
    Friend WithEvents TabPage18 As TabPage
    Friend WithEvents GroupBox127 As GroupBox
    Friend WithEvents GroupBox128 As GroupBox
    Friend WithEvents Label167 As Label
    Friend WithEvents Label168 As Label
    Friend WithEvents mon_stn4_cyl4_min As PictureBox
    Friend WithEvents mon_stn4_cyl4_max As PictureBox
    Friend WithEvents GroupBox129 As GroupBox
    Friend WithEvents Label169 As Label
    Friend WithEvents mon_stn4_cyl4_fw As PictureBox
    Friend WithEvents Label170 As Label
    Friend WithEvents mon_stn4_cyl4_bw As PictureBox
    Friend WithEvents GroupBox130 As GroupBox
    Friend WithEvents GroupBox131 As GroupBox
    Friend WithEvents Label171 As Label
    Friend WithEvents Label172 As Label
    Friend WithEvents mon_stn4_cyl2_min As PictureBox
    Friend WithEvents mon_stn4_cyl2_max As PictureBox
    Friend WithEvents GroupBox132 As GroupBox
    Friend WithEvents Label173 As Label
    Friend WithEvents mon_stn4_cyl2_fw As PictureBox
    Friend WithEvents Label174 As Label
    Friend WithEvents mon_stn4_cyl2_bw As PictureBox
    Friend WithEvents GroupBox133 As GroupBox
    Friend WithEvents GroupBox134 As GroupBox
    Friend WithEvents Label175 As Label
    Friend WithEvents Label176 As Label
    Friend WithEvents mon_stn4_cyl3_min As PictureBox
    Friend WithEvents mon_stn4_cyl3_max As PictureBox
    Friend WithEvents GroupBox135 As GroupBox
    Friend WithEvents Label177 As Label
    Friend WithEvents mon_stn4_cyl3_fw As PictureBox
    Friend WithEvents Label178 As Label
    Friend WithEvents mon_stn4_cyl3_bw As PictureBox
    Friend WithEvents GroupBox136 As GroupBox
    Friend WithEvents GroupBox137 As GroupBox
    Friend WithEvents Label179 As Label
    Friend WithEvents Label180 As Label
    Friend WithEvents mon_stn4_cyl1_min As PictureBox
    Friend WithEvents mon_stn4_cyl1_max As PictureBox
    Friend WithEvents GroupBox138 As GroupBox
    Friend WithEvents Label181 As Label
    Friend WithEvents mon_stn4_cyl1_fw As PictureBox
    Friend WithEvents Label182 As Label
    Friend WithEvents mon_stn4_cyl1_bw As PictureBox
    Friend WithEvents pnl_mon_stn3 As TabControl
    Friend WithEvents TabPage19 As TabPage
    Friend WithEvents GroupBox115 As GroupBox
    Friend WithEvents GroupBox116 As GroupBox
    Friend WithEvents Label150 As Label
    Friend WithEvents Label151 As Label
    Friend WithEvents mon_stn3_cyl4_min As PictureBox
    Friend WithEvents mon_stn3_cyl4_max As PictureBox
    Friend WithEvents GroupBox117 As GroupBox
    Friend WithEvents Label152 As Label
    Friend WithEvents mon_stn3_cyl4_fw As PictureBox
    Friend WithEvents Label153 As Label
    Friend WithEvents mon_stn3_cyl4_bw As PictureBox
    Friend WithEvents GroupBox118 As GroupBox
    Friend WithEvents GroupBox119 As GroupBox
    Friend WithEvents Label154 As Label
    Friend WithEvents Label155 As Label
    Friend WithEvents mon_stn3_cyl2_min As PictureBox
    Friend WithEvents mon_stn3_cyl2_max As PictureBox
    Friend WithEvents GroupBox120 As GroupBox
    Friend WithEvents Label156 As Label
    Friend WithEvents mon_stn3_cyl2_fw As PictureBox
    Friend WithEvents Label157 As Label
    Friend WithEvents mon_stn3_cyl2_bw As PictureBox
    Friend WithEvents GroupBox121 As GroupBox
    Friend WithEvents GroupBox122 As GroupBox
    Friend WithEvents Label158 As Label
    Friend WithEvents Label159 As Label
    Friend WithEvents mon_stn3_cyl3_min As PictureBox
    Friend WithEvents mon_stn3_cyl3_max As PictureBox
    Friend WithEvents GroupBox123 As GroupBox
    Friend WithEvents Label160 As Label
    Friend WithEvents mon_stn3_cyl3_fw As PictureBox
    Friend WithEvents Label161 As Label
    Friend WithEvents mon_stn3_cyl3_bw As PictureBox
    Friend WithEvents GroupBox124 As GroupBox
    Friend WithEvents GroupBox125 As GroupBox
    Friend WithEvents Label162 As Label
    Friend WithEvents Label163 As Label
    Friend WithEvents mon_stn3_cyl1_min As PictureBox
    Friend WithEvents mon_stn3_cyl1_max As PictureBox
    Friend WithEvents GroupBox126 As GroupBox
    Friend WithEvents Label164 As Label
    Friend WithEvents mon_stn3_cyl1_fw As PictureBox
    Friend WithEvents Label165 As Label
    Friend WithEvents mon_stn3_cyl1_bw As PictureBox
    Friend WithEvents pnl_mon_stn2 As TabControl
    Friend WithEvents TabPage20 As TabPage
    Friend WithEvents GroupBox103 As GroupBox
    Friend WithEvents GroupBox104 As GroupBox
    Friend WithEvents Label133 As Label
    Friend WithEvents Label134 As Label
    Friend WithEvents mon_stn2_cyl4_min As PictureBox
    Friend WithEvents mon_stn2_cyl4_max As PictureBox
    Friend WithEvents GroupBox105 As GroupBox
    Friend WithEvents Label135 As Label
    Friend WithEvents mon_stn2_cyl4_fw As PictureBox
    Friend WithEvents Label136 As Label
    Friend WithEvents mon_stn2_cyl4_bw As PictureBox
    Friend WithEvents GroupBox106 As GroupBox
    Friend WithEvents GroupBox107 As GroupBox
    Friend WithEvents Label137 As Label
    Friend WithEvents Label138 As Label
    Friend WithEvents mon_stn2_cyl2_min As PictureBox
    Friend WithEvents mon_stn2_cyl2_max As PictureBox
    Friend WithEvents GroupBox108 As GroupBox
    Friend WithEvents Label139 As Label
    Friend WithEvents mon_stn2_cyl2_fw As PictureBox
    Friend WithEvents Label140 As Label
    Friend WithEvents mon_stn2_cyl2_bw As PictureBox
    Friend WithEvents GroupBox109 As GroupBox
    Friend WithEvents GroupBox110 As GroupBox
    Friend WithEvents Label141 As Label
    Friend WithEvents Label142 As Label
    Friend WithEvents mon_stn2_cyl3_min As PictureBox
    Friend WithEvents mon_stn2_cyl3_max As PictureBox
    Friend WithEvents GroupBox111 As GroupBox
    Friend WithEvents Label143 As Label
    Friend WithEvents mon_stn2_cyl3_fw As PictureBox
    Friend WithEvents Label144 As Label
    Friend WithEvents mon_stn2_cyl3_bw As PictureBox
    Friend WithEvents GroupBox112 As GroupBox
    Friend WithEvents GroupBox113 As GroupBox
    Friend WithEvents Label145 As Label
    Friend WithEvents Label146 As Label
    Friend WithEvents mon_stn2_cyl1_min As PictureBox
    Friend WithEvents mon_stn2_cyl1_max As PictureBox
    Friend WithEvents GroupBox114 As GroupBox
    Friend WithEvents Label147 As Label
    Friend WithEvents mon_stn2_cyl1_fw As PictureBox
    Friend WithEvents Label148 As Label
    Friend WithEvents mon_stn2_cyl1_bw As PictureBox
    Friend WithEvents pnl_mon_stn1 As TabControl
    Friend WithEvents TabPage21 As TabPage
    Friend WithEvents GroupBox97 As GroupBox
    Friend WithEvents GroupBox98 As GroupBox
    Friend WithEvents Label129 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents mon_stn1_cyl4_min As PictureBox
    Friend WithEvents mon_stn1_cyl4_max As PictureBox
    Friend WithEvents GroupBox99 As GroupBox
    Friend WithEvents Label131 As Label
    Friend WithEvents mon_stn1_cyl4_fw As PictureBox
    Friend WithEvents Label132 As Label
    Friend WithEvents mon_stn1_cyl4_bw As PictureBox
    Friend WithEvents GroupBox91 As GroupBox
    Friend WithEvents GroupBox92 As GroupBox
    Friend WithEvents Label104 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents mon_stn1_cyl2_min As PictureBox
    Friend WithEvents mon_stn1_cyl2_max As PictureBox
    Friend WithEvents GroupBox93 As GroupBox
    Friend WithEvents Label111 As Label
    Friend WithEvents mon_stn1_cyl2_fw As PictureBox
    Friend WithEvents Label112 As Label
    Friend WithEvents mon_stn1_cyl2_bw As PictureBox
    Friend WithEvents GroupBox94 As GroupBox
    Friend WithEvents GroupBox95 As GroupBox
    Friend WithEvents Label118 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents mon_stn1_cyl3_min As PictureBox
    Friend WithEvents mon_stn1_cyl3_max As PictureBox
    Friend WithEvents GroupBox96 As GroupBox
    Friend WithEvents Label127 As Label
    Friend WithEvents mon_stn1_cyl3_fw As PictureBox
    Friend WithEvents Label128 As Label
    Friend WithEvents mon_stn1_cyl3_bw As PictureBox
    Friend WithEvents GroupBox100 As GroupBox
    Friend WithEvents GroupBox101 As GroupBox
    Friend WithEvents Label122 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents mon_stn1_cyl1_min As PictureBox
    Friend WithEvents mon_stn1_cyl1_max As PictureBox
    Friend WithEvents GroupBox102 As GroupBox
    Friend WithEvents Label126 As Label
    Friend WithEvents mon_stn1_cyl1_fw As PictureBox
    Friend WithEvents Label125 As Label
    Friend WithEvents mon_stn1_cyl1_bw As PictureBox
End Class
