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
        Me.lbl_run_state = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.lbl_auto_man = New System.Windows.Forms.Label()
        Me.pnl_home = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_alarm_copy = New System.Windows.Forms.Label()
        Me.GroupBox175 = New System.Windows.Forms.GroupBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lbl_fpy = New System.Windows.Forms.Label()
        Me.lbl_oee = New System.Windows.Forms.Label()
        Me.lbl_fail = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.GroupBox78 = New System.Windows.Forms.GroupBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label310 = New System.Windows.Forms.Label()
        Me.laabel2 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label257 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.laabel1 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status_5 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status_4 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status_3 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status_2 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status_1 = New System.Windows.Forms.Label()
        Me.lbl_unscrew_status = New System.Windows.Forms.Label()
        Me.lbl_st4_p2_5 = New System.Windows.Forms.Label()
        Me.lbl_st4_p2_4 = New System.Windows.Forms.Label()
        Me.lbl_st4_p2_3 = New System.Windows.Forms.Label()
        Me.lbl_st4_p2_2 = New System.Windows.Forms.Label()
        Me.lbl_st4_p2_1 = New System.Windows.Forms.Label()
        Me.lbl_st4_p2 = New System.Windows.Forms.Label()
        Me.lbl_st4_actu_pos_5 = New System.Windows.Forms.Label()
        Me.lbl_diff_result_5 = New System.Windows.Forms.Label()
        Me.lbl_st4_actu_pos_4 = New System.Windows.Forms.Label()
        Me.lbl_diff_result_4 = New System.Windows.Forms.Label()
        Me.lbl_st4_actu_pos_3 = New System.Windows.Forms.Label()
        Me.lbl_diff_result_3 = New System.Windows.Forms.Label()
        Me.lbl_st4_actu_pos_2 = New System.Windows.Forms.Label()
        Me.lbl_diff_result_2 = New System.Windows.Forms.Label()
        Me.lbl_st4_actu_pos_1 = New System.Windows.Forms.Label()
        Me.lbl_diff_result_1 = New System.Windows.Forms.Label()
        Me.lbl_st4_actu_pos = New System.Windows.Forms.Label()
        Me.lbl_diff_result = New System.Windows.Forms.Label()
        Me.lbl_st2_meas_5 = New System.Windows.Forms.Label()
        Me.lbl_st2_meas_4 = New System.Windows.Forms.Label()
        Me.lbl_st2_meas_3 = New System.Windows.Forms.Label()
        Me.lbl_st2_meas_2 = New System.Windows.Forms.Label()
        Me.lbl_st2_meas_1 = New System.Windows.Forms.Label()
        Me.lbl_st2_meas = New System.Windows.Forms.Label()
        Me.lbl_st4NO_res_5 = New System.Windows.Forms.Label()
        Me.lbl_st4NO_res_4 = New System.Windows.Forms.Label()
        Me.lbl_st4NC_res_5 = New System.Windows.Forms.Label()
        Me.lbl_st4NO_res_3 = New System.Windows.Forms.Label()
        Me.lbl_st4NC_res_4 = New System.Windows.Forms.Label()
        Me.lbl_st4NO_res_2 = New System.Windows.Forms.Label()
        Me.lbl_st4NC_res_3 = New System.Windows.Forms.Label()
        Me.lbl_st4NO_res_1 = New System.Windows.Forms.Label()
        Me.lbl_st4NC_res_2 = New System.Windows.Forms.Label()
        Me.lbl_st4NO_res = New System.Windows.Forms.Label()
        Me.lbl_st4NC_res_1 = New System.Windows.Forms.Label()
        Me.lbl_st4NC_res = New System.Windows.Forms.Label()
        Me.lbl_st4_p3_5 = New System.Windows.Forms.Label()
        Me.lbl_st4_p3_4 = New System.Windows.Forms.Label()
        Me.lbl_st4_p3_3 = New System.Windows.Forms.Label()
        Me.lbl_st4_p3_2 = New System.Windows.Forms.Label()
        Me.lbl_st4_p3_1 = New System.Windows.Forms.Label()
        Me.lbl_st4_p3 = New System.Windows.Forms.Label()
        Me.lbl_item_6 = New System.Windows.Forms.Label()
        Me.lbl_item_5 = New System.Windows.Forms.Label()
        Me.lbl_status_5 = New System.Windows.Forms.Label()
        Me.lbl_item_4 = New System.Windows.Forms.Label()
        Me.lbl_status_4 = New System.Windows.Forms.Label()
        Me.lbl_item_3 = New System.Windows.Forms.Label()
        Me.lbl_status_3 = New System.Windows.Forms.Label()
        Me.lbl_item_2 = New System.Windows.Forms.Label()
        Me.lbl_status_2 = New System.Windows.Forms.Label()
        Me.lbl_item_1 = New System.Windows.Forms.Label()
        Me.lbl_status_1 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.GroupBox77 = New System.Windows.Forms.GroupBox()
        Me.ind_software_stop = New System.Windows.Forms.PictureBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.ind_software_run = New System.Windows.Forms.PictureBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.ind_software_open = New System.Windows.Forms.PictureBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.GroupBox80 = New System.Windows.Forms.GroupBox()
        Me.txt_po_num = New System.Windows.Forms.TextBox()
        Me.txt_ope_id = New System.Windows.Forms.TextBox()
        Me.txt_ref = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.btn_run = New System.Windows.Forms.Button()
        Me.btn_empty = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.GroupBox76 = New System.Windows.Forms.GroupBox()
        Me.ind_plc_status = New System.Windows.Forms.PictureBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.lbl_op_ins = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.laabel3 = New System.Windows.Forms.Label()
        Me.lbl_st4_t2_5 = New System.Windows.Forms.Label()
        Me.lbl_st4_t2_4 = New System.Windows.Forms.Label()
        Me.lbl_st4_t2_3 = New System.Windows.Forms.Label()
        Me.lbl_st4_t2_2 = New System.Windows.Forms.Label()
        Me.lbl_st4_t2_1 = New System.Windows.Forms.Label()
        Me.lbl_st4_t2 = New System.Windows.Forms.Label()
        Me.lbl_cot_5 = New System.Windows.Forms.Label()
        Me.lbl_cot_4 = New System.Windows.Forms.Label()
        Me.lbl_cot_3 = New System.Windows.Forms.Label()
        Me.lbl_cot_2 = New System.Windows.Forms.Label()
        Me.lbl_cot_1 = New System.Windows.Forms.Label()
        Me.lbl_cot = New System.Windows.Forms.Label()
        Me.lbl_st4_t1_5 = New System.Windows.Forms.Label()
        Me.lbl_st4_t1_4 = New System.Windows.Forms.Label()
        Me.lbl_st4_t1_3 = New System.Windows.Forms.Label()
        Me.lbl_st4_t1_2 = New System.Windows.Forms.Label()
        Me.lbl_st4_t1_1 = New System.Windows.Forms.Label()
        Me.lbl_st4_t1 = New System.Windows.Forms.Label()
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
        Me.txt_msg = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
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
        Me.GroupBox82 = New System.Windows.Forms.GroupBox()
        Me.GroupBox83 = New System.Windows.Forms.GroupBox()
        Me.Label312 = New System.Windows.Forms.Label()
        Me.Label300 = New System.Windows.Forms.Label()
        Me.Label311 = New System.Windows.Forms.Label()
        Me.stn6_laser_interlock = New System.Windows.Forms.PictureBox()
        Me.stn6_laser_finish = New System.Windows.Forms.PictureBox()
        Me.stn6_laser_ready = New System.Windows.Forms.PictureBox()
        Me.GroupBox85 = New System.Windows.Forms.GroupBox()
        Me.btn_stn6_laser_start = New System.Windows.Forms.Button()
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
        Me.GroupBox172 = New System.Windows.Forms.GroupBox()
        Me.GroupBox173 = New System.Windows.Forms.GroupBox()
        Me.Label297 = New System.Windows.Forms.Label()
        Me.Label298 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox180 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_screw_fw = New System.Windows.Forms.Button()
        Me.btn_stn5_screw_bw = New System.Windows.Forms.Button()
        Me.GroupBox49 = New System.Windows.Forms.GroupBox()
        Me.GroupBox50 = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.stn5_cyl4_min = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl4_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox51 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl4_fw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl4_bw = New System.Windows.Forms.Button()
        Me.GroupBox52 = New System.Windows.Forms.GroupBox()
        Me.GroupBox53 = New System.Windows.Forms.GroupBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.stn5_cyl2_min = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl2_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox54 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl2_fw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl2_bw = New System.Windows.Forms.Button()
        Me.GroupBox55 = New System.Windows.Forms.GroupBox()
        Me.GroupBox56 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.stn5_cyl3_min = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl3_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox57 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl3_fw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl3_bw = New System.Windows.Forms.Button()
        Me.GroupBox58 = New System.Windows.Forms.GroupBox()
        Me.GroupBox59 = New System.Windows.Forms.GroupBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.stn5_cyl1_min = New System.Windows.Forms.PictureBox()
        Me.stn5_cyl1_max = New System.Windows.Forms.PictureBox()
        Me.GroupBox60 = New System.Windows.Forms.GroupBox()
        Me.btn_stn5_cyl1_fw = New System.Windows.Forms.Button()
        Me.btn_stn5_cyl1_bw = New System.Windows.Forms.Button()
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
        Me.TabPage24 = New System.Windows.Forms.TabPage()
        Me.txt_st4_cal_val_gt2_6 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_gt2_5 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_p0_6 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_gt2_4 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_p0_5 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_gt2_3 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_p0_4 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_gt2_2 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_p0_3 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_gt2_1 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_p0_2 = New System.Windows.Forms.TextBox()
        Me.txt_st4_cal_val_p0_1 = New System.Windows.Forms.TextBox()
        Me.Label324 = New System.Windows.Forms.Label()
        Me.Label294 = New System.Windows.Forms.Label()
        Me.Label323 = New System.Windows.Forms.Label()
        Me.Label322 = New System.Windows.Forms.Label()
        Me.Label293 = New System.Windows.Forms.Label()
        Me.Label319 = New System.Windows.Forms.Label()
        Me.Label318 = New System.Windows.Forms.Label()
        Me.Label317 = New System.Windows.Forms.Label()
        Me.txt_offset_gt = New System.Windows.Forms.TextBox()
        Me.txt_st4_analog_data = New System.Windows.Forms.TextBox()
        Me.txt_st4_diff_str = New System.Windows.Forms.TextBox()
        Me.txt_st4_act_vel = New System.Windows.Forms.TextBox()
        Me.txt_st4_actu_pos = New System.Windows.Forms.TextBox()
        Me.txt_st4_act_pos = New System.Windows.Forms.TextBox()
        Me.txt_st4_set_vel = New System.Windows.Forms.TextBox()
        Me.txt_st4_set_pos = New System.Windows.Forms.TextBox()
        Me.btn_st4_servo_stop = New System.Windows.Forms.Button()
        Me.btn_st4_servo_reset = New System.Windows.Forms.Button()
        Me.btn_st4_jog_ccw = New System.Windows.Forms.Button()
        Me.btn_st4_auto_calibration = New System.Windows.Forms.Button()
        Me.btn_st4_man_trig = New System.Windows.Forms.Button()
        Me.btn_st4_cal = New System.Windows.Forms.Button()
        Me.btn_st4_jog_cw = New System.Windows.Forms.Button()
        Me.btn_st4_move_vel = New System.Windows.Forms.Button()
        Me.btn_st4_move_pos = New System.Windows.Forms.Button()
        Me.btn_st4_save_data = New System.Windows.Forms.Button()
        Me.btn_st4_homing = New System.Windows.Forms.Button()
        Me.btn_st4_servo_enable = New System.Windows.Forms.Button()
        Me.Label290 = New System.Windows.Forms.Label()
        Me.Label234 = New System.Windows.Forms.Label()
        Me.Label235 = New System.Windows.Forms.Label()
        Me.Label259 = New System.Windows.Forms.Label()
        Me.Label260 = New System.Windows.Forms.Label()
        Me.Label261 = New System.Windows.Forms.Label()
        Me.Label291 = New System.Windows.Forms.Label()
        Me.Label331 = New System.Windows.Forms.Label()
        Me.Label292 = New System.Windows.Forms.Label()
        Me.label_297 = New System.Windows.Forms.Label()
        Me.Label262 = New System.Windows.Forms.Label()
        Me.Label295 = New System.Windows.Forms.Label()
        Me.Label263 = New System.Windows.Forms.Label()
        Me.Label264 = New System.Windows.Forms.Label()
        Me.Label265 = New System.Windows.Forms.Label()
        Me.Label266 = New System.Windows.Forms.Label()
        Me.Label267 = New System.Windows.Forms.Label()
        Me.ind_st4_discrete_motion = New System.Windows.Forms.PictureBox()
        Me.ind_st4_continuous_motion = New System.Windows.Forms.PictureBox()
        Me.ind_st4_servo_busy = New System.Windows.Forms.PictureBox()
        Me.ind_st4_standstill = New System.Windows.Forms.PictureBox()
        Me.ind_st4_stopping = New System.Windows.Forms.PictureBox()
        Me.ind_st4_servo_error = New System.Windows.Forms.PictureBox()
        Me.ind_st4_home_busy = New System.Windows.Forms.PictureBox()
        Me.ind_st4_servo_enabled = New System.Windows.Forms.PictureBox()
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
        Me.TabPage25 = New System.Windows.Forms.TabPage()
        Me.txt_st3_act_vel = New System.Windows.Forms.TextBox()
        Me.txt_st3_act_pos = New System.Windows.Forms.TextBox()
        Me.txt_st3_set_vel = New System.Windows.Forms.TextBox()
        Me.txt_st3_set_pos = New System.Windows.Forms.TextBox()
        Me.btn_st3_servo_stop = New System.Windows.Forms.Button()
        Me.btn_st3_servo_reset = New System.Windows.Forms.Button()
        Me.btn_st3_jog_ccw = New System.Windows.Forms.Button()
        Me.btn_st3_jog_cw = New System.Windows.Forms.Button()
        Me.btn_st3_move_vel = New System.Windows.Forms.Button()
        Me.btn_st3_move_pos = New System.Windows.Forms.Button()
        Me.btn_st3_save_data = New System.Windows.Forms.Button()
        Me.btn_st3_homing = New System.Windows.Forms.Button()
        Me.btn_st3_servo_enable = New System.Windows.Forms.Button()
        Me.Label296 = New System.Windows.Forms.Label()
        Me.Label268 = New System.Windows.Forms.Label()
        Me.Label269 = New System.Windows.Forms.Label()
        Me.Label270 = New System.Windows.Forms.Label()
        Me.Label271 = New System.Windows.Forms.Label()
        Me.Label272 = New System.Windows.Forms.Label()
        Me.Label273 = New System.Windows.Forms.Label()
        Me.Label274 = New System.Windows.Forms.Label()
        Me.Label275 = New System.Windows.Forms.Label()
        Me.Label276 = New System.Windows.Forms.Label()
        Me.Label277 = New System.Windows.Forms.Label()
        Me.Label278 = New System.Windows.Forms.Label()
        Me.ind_st3_discrete_motion = New System.Windows.Forms.PictureBox()
        Me.ind_st3_continuous_motion = New System.Windows.Forms.PictureBox()
        Me.ind_st3_servo_busy = New System.Windows.Forms.PictureBox()
        Me.ind_st3_standstill = New System.Windows.Forms.PictureBox()
        Me.ind_st3_stopping = New System.Windows.Forms.PictureBox()
        Me.ind_st3_servo_error = New System.Windows.Forms.PictureBox()
        Me.ind_st3_home_busy = New System.Windows.Forms.PictureBox()
        Me.ind_st3_servo_enabled = New System.Windows.Forms.PictureBox()
        Me.pnl_man_stn1 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox183 = New System.Windows.Forms.GroupBox()
        Me.btn_trig_turn_table = New System.Windows.Forms.Button()
        Me.Label301 = New System.Windows.Forms.Label()
        Me.Label283 = New System.Windows.Forms.Label()
        Me.Label288 = New System.Windows.Forms.Label()
        Me.Label280 = New System.Windows.Forms.Label()
        Me.Label285 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label284 = New System.Windows.Forms.Label()
        Me.Label281 = New System.Windows.Forms.Label()
        Me.ind_safety_st6 = New System.Windows.Forms.PictureBox()
        Me.ind_safety_st2 = New System.Windows.Forms.PictureBox()
        Me.ind_safety_st4 = New System.Windows.Forms.PictureBox()
        Me.ind_cycle_status = New System.Windows.Forms.PictureBox()
        Me.ind_safety_st5 = New System.Windows.Forms.PictureBox()
        Me.ind_safety_st1 = New System.Windows.Forms.PictureBox()
        Me.ind_safety_st3 = New System.Windows.Forms.PictureBox()
        Me.ind_altivar_status = New System.Windows.Forms.PictureBox()
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
        Me.gb_laser = New System.Windows.Forms.GroupBox()
        Me.txtIP_laser = New System.Windows.Forms.TextBox()
        Me.connect_laser_ind = New System.Windows.Forms.PictureBox()
        Me.Label256 = New System.Windows.Forms.Label()
        Me.Label258 = New System.Windows.Forms.Label()
        Me.btn_save_laser = New System.Windows.Forms.Button()
        Me.txtPort_laser = New System.Windows.Forms.TextBox()
        Me.btn_connect_laser = New System.Windows.Forms.Button()
        Me.RTB_CFG = New System.Windows.Forms.RichTextBox()
        Me.GroupBox179 = New System.Windows.Forms.GroupBox()
        Me.Label254 = New System.Windows.Forms.Label()
        Me.Label252 = New System.Windows.Forms.Label()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label253 = New System.Windows.Forms.Label()
        Me.Label251 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_hostname = New System.Windows.Forms.TextBox()
        Me.btn_apply_database = New System.Windows.Forms.Button()
        Me.GroupBox177 = New System.Windows.Forms.GroupBox()
        Me.Label231 = New System.Windows.Forms.Label()
        Me.Label217 = New System.Windows.Forms.Label()
        Me.Label228 = New System.Windows.Forms.Label()
        Me.Label200 = New System.Windows.Forms.Label()
        Me.Label227 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.ind_stn_6 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_3 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_5 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_2 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_4 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox176 = New System.Windows.Forms.GroupBox()
        Me.st4_resistance = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.st2_beating = New System.Windows.Forms.CheckBox()
        Me.st4_cot = New System.Windows.Forms.CheckBox()
        Me.st3_adjustment = New System.Windows.Forms.CheckBox()
        Me.cb_downgrade_6 = New System.Windows.Forms.ComboBox()
        Me.st2_measuring = New System.Windows.Forms.CheckBox()
        Me.Label166 = New System.Windows.Forms.Label()
        Me.cb_downgrade_5 = New System.Windows.Forms.ComboBox()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.cb_downgrade_4 = New System.Windows.Forms.ComboBox()
        Me.btn_apply_station = New System.Windows.Forms.Button()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.cb_downgrade_3 = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.cb_downgrade_2 = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cb_downgrade_1 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox169 = New System.Windows.Forms.GroupBox()
        Me.Label255 = New System.Windows.Forms.Label()
        Me.Label316 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.connect_multi_ind = New System.Windows.Forms.PictureBox()
        Me.Label226 = New System.Windows.Forms.Label()
        Me.txt_name_multi = New System.Windows.Forms.TextBox()
        Me.txt_offset_multi = New System.Windows.Forms.TextBox()
        Me.txt_port_multi = New System.Windows.Forms.TextBox()
        Me.btn_apply_multi = New System.Windows.Forms.Button()
        Me.btn_open_multi = New System.Windows.Forms.Button()
        Me.txt_baud_multi = New System.Windows.Forms.TextBox()
        Me.grp_plc = New System.Windows.Forms.GroupBox()
        Me.cbo_data_type = New System.Windows.Forms.ComboBox()
        Me.connect_plc_ind = New System.Windows.Forms.PictureBox()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.btn_save_plc = New System.Windows.Forms.Button()
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.rbByREF = New System.Windows.Forms.RadioButton()
        Me.rbBydate = New System.Windows.Forms.RadioButton()
        Me.GroupBox174 = New System.Windows.Forms.GroupBox()
        Me.tbSearchREF = New System.Windows.Forms.TextBox()
        Me.GroupBox181 = New System.Windows.Forms.GroupBox()
        Me.Label249 = New System.Windows.Forms.Label()
        Me.Label250 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.btn_fileLocation = New System.Windows.Forms.Button()
        Me.ProgressBarExport = New System.Windows.Forms.ProgressBar()
        Me.txtFileLocation = New System.Windows.Forms.TextBox()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.GroupBox182 = New System.Windows.Forms.GroupBox()
        Me.RTB_LOG = New System.Windows.Forms.RichTextBox()
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
        Me.btn_send_laser = New System.Windows.Forms.Button()
        Me.txtResponse_laser = New System.Windows.Forms.TextBox()
        Me.Label233 = New System.Windows.Forms.Label()
        Me.txtCommand_laser = New System.Windows.Forms.TextBox()
        Me.Label232 = New System.Windows.Forms.Label()
        Me.pnl_multi = New System.Windows.Forms.TabControl()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.GroupBox178 = New System.Windows.Forms.GroupBox()
        Me.Label236 = New System.Windows.Forms.Label()
        Me.Label248 = New System.Windows.Forms.Label()
        Me.txt_cmd_multi = New System.Windows.Forms.TextBox()
        Me.btn_send_multi = New System.Windows.Forms.Button()
        Me.txt_respond_multi = New System.Windows.Forms.TextBox()
        Me.GroupBox170 = New System.Windows.Forms.GroupBox()
        Me.Label229 = New System.Windows.Forms.Label()
        Me.txt_ch_1 = New System.Windows.Forms.TextBox()
        Me.btn_read_ch_1 = New System.Windows.Forms.Button()
        Me.pnl_alarm = New System.Windows.Forms.TabControl()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.txt_alarm = New System.Windows.Forms.TextBox()
        Me.GroupBox184 = New System.Windows.Forms.GroupBox()
        Me.ind_laser_err_emg = New System.Windows.Forms.PictureBox()
        Me.ind_pos_servo_st4 = New System.Windows.Forms.PictureBox()
        Me.ind_pos_servo_st3 = New System.Windows.Forms.PictureBox()
        Me.ind_conn_servo_st4 = New System.Windows.Forms.PictureBox()
        Me.Label315 = New System.Windows.Forms.Label()
        Me.ind_conn_servo_st3 = New System.Windows.Forms.PictureBox()
        Me.Label314 = New System.Windows.Forms.Label()
        Me.Label320 = New System.Windows.Forms.Label()
        Me.Label313 = New System.Windows.Forms.Label()
        Me.Label321 = New System.Windows.Forms.Label()
        Me.GroupBox84 = New System.Windows.Forms.GroupBox()
        Me.ind_v606_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v604_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v602_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v504_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label309 = New System.Windows.Forms.Label()
        Me.Label307 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.ind_v503_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v605_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v603_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v601_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v502_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label308 = New System.Windows.Forms.Label()
        Me.Label306 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label305 = New System.Windows.Forms.Label()
        Me.Label304 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.GroupBox81 = New System.Windows.Forms.GroupBox()
        Me.ind_v402_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v302_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v501_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.ind_v203_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v401_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.ind_v202_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v301_descrepancy = New System.Windows.Forms.PictureBox()
        Me.labelaaa = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.ind_v101_descrepancy = New System.Windows.Forms.PictureBox()
        Me.ind_v201_descrepancy = New System.Windows.Forms.PictureBox()
        Me.Label299 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.GroupBox79 = New System.Windows.Forms.GroupBox()
        Me.ind_safety_curtain = New System.Windows.Forms.PictureBox()
        Me.ind_emg_button = New System.Windows.Forms.PictureBox()
        Me.ind_door_lock_6 = New System.Windows.Forms.PictureBox()
        Me.ind_altivar_fault = New System.Windows.Forms.PictureBox()
        Me.Label230 = New System.Windows.Forms.Label()
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
        Me.ChromaComm = New System.IO.Ports.SerialPort(Me.components)
        Me.pnl_calibration = New System.Windows.Forms.TabControl()
        Me.TabPage22 = New System.Windows.Forms.TabPage()
        Me.dgv_calibration = New System.Windows.Forms.DataGridView()
        Me.Parameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_save_calib = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.MC_Status = New System.Windows.Forms.PictureBox()
        Me.status_bar = New System.Windows.Forms.PictureBox()
        Me.btn_calib = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_alarm = New System.Windows.Forms.Button()
        Me.btn_laser = New System.Windows.Forms.Button()
        Me.btn_ref = New System.Windows.Forms.Button()
        Me.btn_multimeter = New System.Windows.Forms.Button()
        Me.btn_monitoring = New System.Windows.Forms.Button()
        Me.btn_manual = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.TabPage26 = New System.Windows.Forms.TabPage()
        Me.txt_st2_punch_cycle = New System.Windows.Forms.TextBox()
        Me.txt_st2_cal_val_6 = New System.Windows.Forms.TextBox()
        Me.txt_st2_cal_val_5 = New System.Windows.Forms.TextBox()
        Me.txt_st2_cal_val_4 = New System.Windows.Forms.TextBox()
        Me.txt_st2_cal_val_3 = New System.Windows.Forms.TextBox()
        Me.txt_st2_cal_val_2 = New System.Windows.Forms.TextBox()
        Me.txt_st2_cal_val_1 = New System.Windows.Forms.TextBox()
        Me.txt_st2_punch_count = New System.Windows.Forms.TextBox()
        Me.txt_st2_act_mea = New System.Windows.Forms.TextBox()
        Me.btn_st2_set_cal_val = New System.Windows.Forms.Button()
        Me.btn_st2_preset_heidenhain = New System.Windows.Forms.Button()
        Me.btn_st2_stop_punch = New System.Windows.Forms.Button()
        Me.Label330 = New System.Windows.Forms.Label()
        Me.btn_st2_start_punch = New System.Windows.Forms.Button()
        Me.Label329 = New System.Windows.Forms.Label()
        Me.btn_st2_enable_heidenhain = New System.Windows.Forms.Button()
        Me.Label328 = New System.Windows.Forms.Label()
        Me.Label279 = New System.Windows.Forms.Label()
        Me.Label327 = New System.Windows.Forms.Label()
        Me.Label282 = New System.Windows.Forms.Label()
        Me.Label326 = New System.Windows.Forms.Label()
        Me.Label303 = New System.Windows.Forms.Label()
        Me.Label325 = New System.Windows.Forms.Label()
        Me.Label286 = New System.Windows.Forms.Label()
        Me.Label302 = New System.Windows.Forms.Label()
        Me.Label287 = New System.Windows.Forms.Label()
        Me.Label289 = New System.Windows.Forms.Label()
        Me.ind_st2_motor_status = New System.Windows.Forms.PictureBox()
        Me.ind_st2_heidenhain_error = New System.Windows.Forms.PictureBox()
        Me.ind_st2_heidenhain_valid = New System.Windows.Forms.PictureBox()
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
        Me.pnl_man_stn2 = New System.Windows.Forms.TabControl()
        Me.btn_st2_auto_caib = New System.Windows.Forms.Button()
        Me.st6_laser = New System.Windows.Forms.CheckBox()
        Me.pnl_home.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.GroupBox175.SuspendLayout
        Me.GroupBox78.SuspendLayout
        Me.GroupBox77.SuspendLayout
        CType(Me.ind_software_stop, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_software_run, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_software_open, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox80.SuspendLayout
        Me.GroupBox76.SuspendLayout
        CType(Me.ind_plc_status, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox87.SuspendLayout
        Me.GroupBox86.SuspendLayout
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
        Me.GroupBox82.SuspendLayout
        Me.GroupBox83.SuspendLayout
        CType(Me.stn6_laser_interlock, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_laser_finish, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn6_laser_ready, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox85.SuspendLayout
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
        Me.GroupBox172.SuspendLayout
        Me.GroupBox173.SuspendLayout
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox180.SuspendLayout
        Me.GroupBox49.SuspendLayout
        Me.GroupBox50.SuspendLayout
        CType(Me.stn5_cyl4_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl4_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox51.SuspendLayout
        Me.GroupBox52.SuspendLayout
        Me.GroupBox53.SuspendLayout
        CType(Me.stn5_cyl2_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl2_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox54.SuspendLayout
        Me.GroupBox55.SuspendLayout
        Me.GroupBox56.SuspendLayout
        CType(Me.stn5_cyl3_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl3_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox57.SuspendLayout
        Me.GroupBox58.SuspendLayout
        Me.GroupBox59.SuspendLayout
        CType(Me.stn5_cyl1_min, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stn5_cyl1_max, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox60.SuspendLayout
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
        Me.TabPage24.SuspendLayout
        CType(Me.ind_st4_discrete_motion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_continuous_motion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_servo_busy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_standstill, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_stopping, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_servo_error, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_home_busy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st4_servo_enabled, System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.TabPage25.SuspendLayout
        CType(Me.ind_st3_discrete_motion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_continuous_motion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_servo_busy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_standstill, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_stopping, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_servo_error, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_home_busy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st3_servo_enabled, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_man_stn1.SuspendLayout
        Me.TabPage9.SuspendLayout
        Me.GroupBox183.SuspendLayout
        CType(Me.ind_safety_st6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_safety_st2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_safety_st4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_cycle_status, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_safety_st5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_safety_st1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_safety_st3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_altivar_status, System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.gb_laser.SuspendLayout
        CType(Me.connect_laser_ind, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox179.SuspendLayout
        Me.GroupBox177.SuspendLayout
        CType(Me.ind_stn_6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_stn_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_stn_5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_stn_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_stn_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_stn_1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox176.SuspendLayout
        Me.GroupBox169.SuspendLayout
        CType(Me.connect_multi_ind, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_plc.SuspendLayout
        CType(Me.connect_plc_ind, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_log.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage11.SuspendLayout
        Me.GroupBox174.SuspendLayout
        Me.GroupBox181.SuspendLayout
        Me.TabPage12.SuspendLayout
        Me.GroupBox182.SuspendLayout
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_ref.SuspendLayout
        Me.TabPage2.SuspendLayout
        CType(Me.dgv_ref, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox_Control.SuspendLayout
        Me.pnl_laser.SuspendLayout
        Me.TabPage13.SuspendLayout
        Me.GroupBox171.SuspendLayout
        Me.pnl_multi.SuspendLayout
        Me.TabPage14.SuspendLayout
        Me.GroupBox178.SuspendLayout
        Me.GroupBox170.SuspendLayout
        Me.pnl_alarm.SuspendLayout
        Me.TabPage15.SuspendLayout
        Me.GroupBox184.SuspendLayout
        CType(Me.ind_laser_err_emg, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_pos_servo_st4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_pos_servo_st3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_conn_servo_st4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_conn_servo_st3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox84.SuspendLayout
        CType(Me.ind_v606_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v604_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v602_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v504_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v503_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v605_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v603_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v601_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v502_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox81.SuspendLayout
        CType(Me.ind_v402_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v302_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v501_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v203_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v401_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v202_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v301_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v101_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_v201_descrepancy, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox79.SuspendLayout
        CType(Me.ind_safety_curtain, System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.pnl_calibration.SuspendLayout
        Me.TabPage22.SuspendLayout
        CType(Me.dgv_calibration, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MC_Status, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.status_bar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage26.SuspendLayout
        CType(Me.ind_st2_motor_status, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st2_heidenhain_error, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ind_st2_heidenhain_valid, System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.pnl_man_stn2.SuspendLayout
        Me.SuspendLayout
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Black
        Me.lbl_user.Location = New System.Drawing.Point(929, 61)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(44, 20)
        Me.lbl_user.TabIndex = 61
        Me.lbl_user.Text = "ENG"
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
        'pnl_home
        '
        Me.pnl_home.Controls.Add(Me.TabPage3)
        Me.pnl_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_home.Location = New System.Drawing.Point(78, 86)
        Me.pnl_home.Name = "pnl_home"
        Me.pnl_home.SelectedIndex = 0
        Me.pnl_home.Size = New System.Drawing.Size(853, 558)
        Me.pnl_home.TabIndex = 95
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_alarm_copy)
        Me.TabPage3.Controls.Add(Me.GroupBox175)
        Me.TabPage3.Controls.Add(Me.GroupBox78)
        Me.TabPage3.Controls.Add(Me.GroupBox77)
        Me.TabPage3.Controls.Add(Me.GroupBox80)
        Me.TabPage3.Controls.Add(Me.GroupBox76)
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
        'txt_alarm_copy
        '
        Me.txt_alarm_copy.BackColor = System.Drawing.Color.DarkRed
        Me.txt_alarm_copy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_alarm_copy.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alarm_copy.ForeColor = System.Drawing.SystemColors.Control
        Me.txt_alarm_copy.Location = New System.Drawing.Point(288, 461)
        Me.txt_alarm_copy.Name = "txt_alarm_copy"
        Me.txt_alarm_copy.Size = New System.Drawing.Size(487, 47)
        Me.txt_alarm_copy.TabIndex = 58
        Me.txt_alarm_copy.Text = "Alarm : . . . . "
        Me.txt_alarm_copy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox175
        '
        Me.GroupBox175.Controls.Add(Me.Label124)
        Me.GroupBox175.Controls.Add(Me.Label63)
        Me.GroupBox175.Controls.Add(Me.Label51)
        Me.GroupBox175.Controls.Add(Me.Label33)
        Me.GroupBox175.Controls.Add(Me.lbl_fpy)
        Me.GroupBox175.Controls.Add(Me.lbl_oee)
        Me.GroupBox175.Controls.Add(Me.lbl_fail)
        Me.GroupBox175.Controls.Add(Me.lbl_pass)
        Me.GroupBox175.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox175.Location = New System.Drawing.Point(518, 4)
        Me.GroupBox175.Name = "GroupBox175"
        Me.GroupBox175.Size = New System.Drawing.Size(256, 118)
        Me.GroupBox175.TabIndex = 57
        Me.GroupBox175.TabStop = False
        Me.GroupBox175.Text = "Product Output"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(26, 92)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(36, 18)
        Me.Label124.TabIndex = 38
        Me.Label124.Text = "FPY"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(26, 70)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(40, 18)
        Me.Label63.TabIndex = 39
        Me.Label63.Text = "OEE"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(26, 48)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(31, 18)
        Me.Label51.TabIndex = 40
        Me.Label51.Text = "Fail"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(26, 25)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 18)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "Pass"
        '
        'lbl_fpy
        '
        Me.lbl_fpy.BackColor = System.Drawing.Color.DimGray
        Me.lbl_fpy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fpy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fpy.Location = New System.Drawing.Point(117, 90)
        Me.lbl_fpy.Name = "lbl_fpy"
        Me.lbl_fpy.Size = New System.Drawing.Size(114, 20)
        Me.lbl_fpy.TabIndex = 42
        Me.lbl_fpy.Text = "0 %"
        Me.lbl_fpy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_oee
        '
        Me.lbl_oee.BackColor = System.Drawing.Color.DimGray
        Me.lbl_oee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_oee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oee.Location = New System.Drawing.Point(117, 68)
        Me.lbl_oee.Name = "lbl_oee"
        Me.lbl_oee.Size = New System.Drawing.Size(114, 20)
        Me.lbl_oee.TabIndex = 43
        Me.lbl_oee.Text = "0 %"
        Me.lbl_oee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_fail
        '
        Me.lbl_fail.BackColor = System.Drawing.Color.Red
        Me.lbl_fail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fail.Location = New System.Drawing.Point(117, 46)
        Me.lbl_fail.Name = "lbl_fail"
        Me.lbl_fail.Size = New System.Drawing.Size(114, 20)
        Me.lbl_fail.TabIndex = 44
        Me.lbl_fail.Text = "0"
        Me.lbl_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_pass
        '
        Me.lbl_pass.BackColor = System.Drawing.Color.DarkGreen
        Me.lbl_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(117, 23)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(114, 20)
        Me.lbl_pass.TabIndex = 45
        Me.lbl_pass.Text = "0"
        Me.lbl_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox78
        '
        Me.GroupBox78.Controls.Add(Me.Label68)
        Me.GroupBox78.Controls.Add(Me.Label84)
        Me.GroupBox78.Controls.Add(Me.Label310)
        Me.GroupBox78.Controls.Add(Me.laabel2)
        Me.GroupBox78.Controls.Add(Me.Label116)
        Me.GroupBox78.Controls.Add(Me.Label257)
        Me.GroupBox78.Controls.Add(Me.Label119)
        Me.GroupBox78.Controls.Add(Me.laabel1)
        Me.GroupBox78.Controls.Add(Me.Label121)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status_5)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status_4)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status_3)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status_2)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status_1)
        Me.GroupBox78.Controls.Add(Me.lbl_unscrew_status)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2_5)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2_4)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2_3)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2_2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2_1)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_actu_pos_5)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result_5)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_actu_pos_4)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result_4)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_actu_pos_3)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result_3)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_actu_pos_2)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result_2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_actu_pos_1)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result_1)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_actu_pos)
        Me.GroupBox78.Controls.Add(Me.lbl_diff_result)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas_5)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas_4)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas_3)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas_2)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas_1)
        Me.GroupBox78.Controls.Add(Me.lbl_st2_meas)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NO_res_5)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NO_res_4)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NC_res_5)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NO_res_3)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NC_res_4)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NO_res_2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NC_res_3)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NO_res_1)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NC_res_2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NO_res)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NC_res_1)
        Me.GroupBox78.Controls.Add(Me.lbl_st4NC_res)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3_5)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3_4)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3_3)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3_2)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3_1)
        Me.GroupBox78.Controls.Add(Me.lbl_st4_p3)
        Me.GroupBox78.Controls.Add(Me.lbl_item_6)
        Me.GroupBox78.Controls.Add(Me.lbl_item_5)
        Me.GroupBox78.Controls.Add(Me.lbl_status_5)
        Me.GroupBox78.Controls.Add(Me.lbl_item_4)
        Me.GroupBox78.Controls.Add(Me.lbl_status_4)
        Me.GroupBox78.Controls.Add(Me.lbl_item_3)
        Me.GroupBox78.Controls.Add(Me.lbl_status_3)
        Me.GroupBox78.Controls.Add(Me.lbl_item_2)
        Me.GroupBox78.Controls.Add(Me.lbl_status_2)
        Me.GroupBox78.Controls.Add(Me.lbl_item_1)
        Me.GroupBox78.Controls.Add(Me.lbl_status_1)
        Me.GroupBox78.Controls.Add(Me.lbl_status)
        Me.GroupBox78.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox78.Location = New System.Drawing.Point(289, 126)
        Me.GroupBox78.Name = "GroupBox78"
        Me.GroupBox78.Size = New System.Drawing.Size(486, 317)
        Me.GroupBox78.TabIndex = 52
        Me.GroupBox78.TabStop = False
        Me.GroupBox78.Text = "Production Data :"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(6, 207)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(144, 18)
        Me.Label68.TabIndex = 36
        Me.Label68.Text = "ST5 Unscrew Status"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(6, 139)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(150, 18)
        Me.Label84.TabIndex = 36
        Me.Label84.Text = "ST4 Actuation Point 1"
        '
        'Label310
        '
        Me.Label310.AutoSize = True
        Me.Label310.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label310.Location = New System.Drawing.Point(6, 292)
        Me.Label310.Name = "Label310"
        Me.Label310.Size = New System.Drawing.Size(150, 18)
        Me.Label310.TabIndex = 36
        Me.Label310.Text = "ST4 Actuation Point 1"
        Me.Label310.Visible = False
        '
        'laabel2
        '
        Me.laabel2.AutoSize = True
        Me.laabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laabel2.Location = New System.Drawing.Point(6, 184)
        Me.laabel2.Name = "laabel2"
        Me.laabel2.Size = New System.Drawing.Size(84, 18)
        Me.laabel2.TabIndex = 36
        Me.laabel2.Text = "ST4 Diff Str"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(6, 70)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(130, 18)
        Me.Label116.TabIndex = 36
        Me.Label116.Text = "ST2 Measurement"
        '
        'Label257
        '
        Me.Label257.AutoSize = True
        Me.Label257.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label257.Location = New System.Drawing.Point(6, 116)
        Me.Label257.Name = "Label257"
        Me.Label257.Size = New System.Drawing.Size(140, 18)
        Me.Label257.TabIndex = 36
        Me.Label257.Text = "ST4 Resistance NO"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(6, 93)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(139, 18)
        Me.Label119.TabIndex = 36
        Me.Label119.Text = "ST4 Resistance NC"
        '
        'laabel1
        '
        Me.laabel1.AutoSize = True
        Me.laabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laabel1.Location = New System.Drawing.Point(6, 161)
        Me.laabel1.Name = "laabel1"
        Me.laabel1.Size = New System.Drawing.Size(150, 18)
        Me.laabel1.TabIndex = 36
        Me.laabel1.Text = "ST4 Actuation Point 2"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(6, 46)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(115, 18)
        Me.Label121.TabIndex = 36
        Me.Label121.Text = "Status Pass/Fail"
        '
        'lbl_unscrew_status_5
        '
        Me.lbl_unscrew_status_5.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status_5.Location = New System.Drawing.Point(426, 205)
        Me.lbl_unscrew_status_5.Name = "lbl_unscrew_status_5"
        Me.lbl_unscrew_status_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_unscrew_status_5.TabIndex = 37
        Me.lbl_unscrew_status_5.Text = "..."
        '
        'lbl_unscrew_status_4
        '
        Me.lbl_unscrew_status_4.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status_4.Location = New System.Drawing.Point(373, 205)
        Me.lbl_unscrew_status_4.Name = "lbl_unscrew_status_4"
        Me.lbl_unscrew_status_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_unscrew_status_4.TabIndex = 37
        Me.lbl_unscrew_status_4.Text = "..."
        '
        'lbl_unscrew_status_3
        '
        Me.lbl_unscrew_status_3.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status_3.Location = New System.Drawing.Point(320, 205)
        Me.lbl_unscrew_status_3.Name = "lbl_unscrew_status_3"
        Me.lbl_unscrew_status_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_unscrew_status_3.TabIndex = 37
        Me.lbl_unscrew_status_3.Text = "..."
        '
        'lbl_unscrew_status_2
        '
        Me.lbl_unscrew_status_2.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status_2.Location = New System.Drawing.Point(267, 205)
        Me.lbl_unscrew_status_2.Name = "lbl_unscrew_status_2"
        Me.lbl_unscrew_status_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_unscrew_status_2.TabIndex = 37
        Me.lbl_unscrew_status_2.Text = "..."
        '
        'lbl_unscrew_status_1
        '
        Me.lbl_unscrew_status_1.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status_1.Location = New System.Drawing.Point(214, 205)
        Me.lbl_unscrew_status_1.Name = "lbl_unscrew_status_1"
        Me.lbl_unscrew_status_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_unscrew_status_1.TabIndex = 37
        Me.lbl_unscrew_status_1.Text = "..."
        '
        'lbl_unscrew_status
        '
        Me.lbl_unscrew_status.BackColor = System.Drawing.Color.White
        Me.lbl_unscrew_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_unscrew_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unscrew_status.Location = New System.Drawing.Point(161, 205)
        Me.lbl_unscrew_status.Name = "lbl_unscrew_status"
        Me.lbl_unscrew_status.Size = New System.Drawing.Size(50, 20)
        Me.lbl_unscrew_status.TabIndex = 37
        Me.lbl_unscrew_status.Text = "..."
        '
        'lbl_st4_p2_5
        '
        Me.lbl_st4_p2_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2_5.Location = New System.Drawing.Point(426, 137)
        Me.lbl_st4_p2_5.Name = "lbl_st4_p2_5"
        Me.lbl_st4_p2_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p2_5.TabIndex = 37
        Me.lbl_st4_p2_5.Text = "..."
        '
        'lbl_st4_p2_4
        '
        Me.lbl_st4_p2_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2_4.Location = New System.Drawing.Point(373, 137)
        Me.lbl_st4_p2_4.Name = "lbl_st4_p2_4"
        Me.lbl_st4_p2_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p2_4.TabIndex = 37
        Me.lbl_st4_p2_4.Text = "..."
        '
        'lbl_st4_p2_3
        '
        Me.lbl_st4_p2_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2_3.Location = New System.Drawing.Point(320, 137)
        Me.lbl_st4_p2_3.Name = "lbl_st4_p2_3"
        Me.lbl_st4_p2_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p2_3.TabIndex = 37
        Me.lbl_st4_p2_3.Text = "..."
        '
        'lbl_st4_p2_2
        '
        Me.lbl_st4_p2_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2_2.Location = New System.Drawing.Point(267, 137)
        Me.lbl_st4_p2_2.Name = "lbl_st4_p2_2"
        Me.lbl_st4_p2_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p2_2.TabIndex = 37
        Me.lbl_st4_p2_2.Text = "..."
        '
        'lbl_st4_p2_1
        '
        Me.lbl_st4_p2_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2_1.Location = New System.Drawing.Point(214, 137)
        Me.lbl_st4_p2_1.Name = "lbl_st4_p2_1"
        Me.lbl_st4_p2_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p2_1.TabIndex = 37
        Me.lbl_st4_p2_1.Text = "..."
        '
        'lbl_st4_p2
        '
        Me.lbl_st4_p2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p2.Location = New System.Drawing.Point(161, 137)
        Me.lbl_st4_p2.Name = "lbl_st4_p2"
        Me.lbl_st4_p2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p2.TabIndex = 37
        Me.lbl_st4_p2.Text = "..."
        '
        'lbl_st4_actu_pos_5
        '
        Me.lbl_st4_actu_pos_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4_actu_pos_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_actu_pos_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_actu_pos_5.Location = New System.Drawing.Point(426, 290)
        Me.lbl_st4_actu_pos_5.Name = "lbl_st4_actu_pos_5"
        Me.lbl_st4_actu_pos_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_actu_pos_5.TabIndex = 37
        Me.lbl_st4_actu_pos_5.Text = "..."
        Me.lbl_st4_actu_pos_5.Visible = False
        '
        'lbl_diff_result_5
        '
        Me.lbl_diff_result_5.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result_5.Location = New System.Drawing.Point(426, 182)
        Me.lbl_diff_result_5.Name = "lbl_diff_result_5"
        Me.lbl_diff_result_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_diff_result_5.TabIndex = 37
        Me.lbl_diff_result_5.Text = "..."
        '
        'lbl_st4_actu_pos_4
        '
        Me.lbl_st4_actu_pos_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4_actu_pos_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_actu_pos_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_actu_pos_4.Location = New System.Drawing.Point(373, 290)
        Me.lbl_st4_actu_pos_4.Name = "lbl_st4_actu_pos_4"
        Me.lbl_st4_actu_pos_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_actu_pos_4.TabIndex = 37
        Me.lbl_st4_actu_pos_4.Text = "..."
        Me.lbl_st4_actu_pos_4.Visible = False
        '
        'lbl_diff_result_4
        '
        Me.lbl_diff_result_4.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result_4.Location = New System.Drawing.Point(373, 182)
        Me.lbl_diff_result_4.Name = "lbl_diff_result_4"
        Me.lbl_diff_result_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_diff_result_4.TabIndex = 37
        Me.lbl_diff_result_4.Text = "..."
        '
        'lbl_st4_actu_pos_3
        '
        Me.lbl_st4_actu_pos_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_actu_pos_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_actu_pos_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_actu_pos_3.Location = New System.Drawing.Point(320, 290)
        Me.lbl_st4_actu_pos_3.Name = "lbl_st4_actu_pos_3"
        Me.lbl_st4_actu_pos_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_actu_pos_3.TabIndex = 37
        Me.lbl_st4_actu_pos_3.Text = "..."
        Me.lbl_st4_actu_pos_3.Visible = False
        '
        'lbl_diff_result_3
        '
        Me.lbl_diff_result_3.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result_3.Location = New System.Drawing.Point(320, 182)
        Me.lbl_diff_result_3.Name = "lbl_diff_result_3"
        Me.lbl_diff_result_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_diff_result_3.TabIndex = 37
        Me.lbl_diff_result_3.Text = "..."
        '
        'lbl_st4_actu_pos_2
        '
        Me.lbl_st4_actu_pos_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_actu_pos_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_actu_pos_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_actu_pos_2.Location = New System.Drawing.Point(267, 290)
        Me.lbl_st4_actu_pos_2.Name = "lbl_st4_actu_pos_2"
        Me.lbl_st4_actu_pos_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_actu_pos_2.TabIndex = 37
        Me.lbl_st4_actu_pos_2.Text = "..."
        Me.lbl_st4_actu_pos_2.Visible = False
        '
        'lbl_diff_result_2
        '
        Me.lbl_diff_result_2.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result_2.Location = New System.Drawing.Point(267, 182)
        Me.lbl_diff_result_2.Name = "lbl_diff_result_2"
        Me.lbl_diff_result_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_diff_result_2.TabIndex = 37
        Me.lbl_diff_result_2.Text = "..."
        '
        'lbl_st4_actu_pos_1
        '
        Me.lbl_st4_actu_pos_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_actu_pos_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_actu_pos_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_actu_pos_1.Location = New System.Drawing.Point(214, 290)
        Me.lbl_st4_actu_pos_1.Name = "lbl_st4_actu_pos_1"
        Me.lbl_st4_actu_pos_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_actu_pos_1.TabIndex = 37
        Me.lbl_st4_actu_pos_1.Text = "..."
        Me.lbl_st4_actu_pos_1.Visible = False
        '
        'lbl_diff_result_1
        '
        Me.lbl_diff_result_1.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result_1.Location = New System.Drawing.Point(214, 182)
        Me.lbl_diff_result_1.Name = "lbl_diff_result_1"
        Me.lbl_diff_result_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_diff_result_1.TabIndex = 37
        Me.lbl_diff_result_1.Text = "..."
        '
        'lbl_st4_actu_pos
        '
        Me.lbl_st4_actu_pos.BackColor = System.Drawing.Color.White
        Me.lbl_st4_actu_pos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_actu_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_actu_pos.Location = New System.Drawing.Point(161, 290)
        Me.lbl_st4_actu_pos.Name = "lbl_st4_actu_pos"
        Me.lbl_st4_actu_pos.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_actu_pos.TabIndex = 37
        Me.lbl_st4_actu_pos.Text = "..."
        Me.lbl_st4_actu_pos.Visible = False
        '
        'lbl_diff_result
        '
        Me.lbl_diff_result.BackColor = System.Drawing.Color.White
        Me.lbl_diff_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_diff_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diff_result.Location = New System.Drawing.Point(161, 182)
        Me.lbl_diff_result.Name = "lbl_diff_result"
        Me.lbl_diff_result.Size = New System.Drawing.Size(50, 20)
        Me.lbl_diff_result.TabIndex = 37
        Me.lbl_diff_result.Text = "..."
        '
        'lbl_st2_meas_5
        '
        Me.lbl_st2_meas_5.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas_5.Location = New System.Drawing.Point(426, 68)
        Me.lbl_st2_meas_5.Name = "lbl_st2_meas_5"
        Me.lbl_st2_meas_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st2_meas_5.TabIndex = 37
        Me.lbl_st2_meas_5.Text = "..."
        '
        'lbl_st2_meas_4
        '
        Me.lbl_st2_meas_4.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas_4.Location = New System.Drawing.Point(373, 68)
        Me.lbl_st2_meas_4.Name = "lbl_st2_meas_4"
        Me.lbl_st2_meas_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st2_meas_4.TabIndex = 37
        Me.lbl_st2_meas_4.Text = "..."
        '
        'lbl_st2_meas_3
        '
        Me.lbl_st2_meas_3.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas_3.Location = New System.Drawing.Point(320, 68)
        Me.lbl_st2_meas_3.Name = "lbl_st2_meas_3"
        Me.lbl_st2_meas_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st2_meas_3.TabIndex = 37
        Me.lbl_st2_meas_3.Text = "..."
        '
        'lbl_st2_meas_2
        '
        Me.lbl_st2_meas_2.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas_2.Location = New System.Drawing.Point(267, 68)
        Me.lbl_st2_meas_2.Name = "lbl_st2_meas_2"
        Me.lbl_st2_meas_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st2_meas_2.TabIndex = 37
        Me.lbl_st2_meas_2.Text = "..."
        '
        'lbl_st2_meas_1
        '
        Me.lbl_st2_meas_1.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas_1.Location = New System.Drawing.Point(214, 68)
        Me.lbl_st2_meas_1.Name = "lbl_st2_meas_1"
        Me.lbl_st2_meas_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st2_meas_1.TabIndex = 37
        Me.lbl_st2_meas_1.Text = "..."
        '
        'lbl_st2_meas
        '
        Me.lbl_st2_meas.BackColor = System.Drawing.Color.White
        Me.lbl_st2_meas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st2_meas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st2_meas.Location = New System.Drawing.Point(161, 68)
        Me.lbl_st2_meas.Name = "lbl_st2_meas"
        Me.lbl_st2_meas.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st2_meas.TabIndex = 37
        Me.lbl_st2_meas.Text = "..."
        '
        'lbl_st4NO_res_5
        '
        Me.lbl_st4NO_res_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4NO_res_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NO_res_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NO_res_5.Location = New System.Drawing.Point(426, 114)
        Me.lbl_st4NO_res_5.Name = "lbl_st4NO_res_5"
        Me.lbl_st4NO_res_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NO_res_5.TabIndex = 37
        Me.lbl_st4NO_res_5.Text = "..."
        '
        'lbl_st4NO_res_4
        '
        Me.lbl_st4NO_res_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4NO_res_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NO_res_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NO_res_4.Location = New System.Drawing.Point(373, 114)
        Me.lbl_st4NO_res_4.Name = "lbl_st4NO_res_4"
        Me.lbl_st4NO_res_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NO_res_4.TabIndex = 37
        Me.lbl_st4NO_res_4.Text = "..."
        '
        'lbl_st4NC_res_5
        '
        Me.lbl_st4NC_res_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4NC_res_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NC_res_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NC_res_5.Location = New System.Drawing.Point(426, 91)
        Me.lbl_st4NC_res_5.Name = "lbl_st4NC_res_5"
        Me.lbl_st4NC_res_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NC_res_5.TabIndex = 37
        Me.lbl_st4NC_res_5.Text = "..."
        '
        'lbl_st4NO_res_3
        '
        Me.lbl_st4NO_res_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4NO_res_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NO_res_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NO_res_3.Location = New System.Drawing.Point(320, 114)
        Me.lbl_st4NO_res_3.Name = "lbl_st4NO_res_3"
        Me.lbl_st4NO_res_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NO_res_3.TabIndex = 37
        Me.lbl_st4NO_res_3.Text = "..."
        '
        'lbl_st4NC_res_4
        '
        Me.lbl_st4NC_res_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4NC_res_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NC_res_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NC_res_4.Location = New System.Drawing.Point(373, 91)
        Me.lbl_st4NC_res_4.Name = "lbl_st4NC_res_4"
        Me.lbl_st4NC_res_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NC_res_4.TabIndex = 37
        Me.lbl_st4NC_res_4.Text = "..."
        '
        'lbl_st4NO_res_2
        '
        Me.lbl_st4NO_res_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4NO_res_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NO_res_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NO_res_2.Location = New System.Drawing.Point(267, 114)
        Me.lbl_st4NO_res_2.Name = "lbl_st4NO_res_2"
        Me.lbl_st4NO_res_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NO_res_2.TabIndex = 37
        Me.lbl_st4NO_res_2.Text = "..."
        '
        'lbl_st4NC_res_3
        '
        Me.lbl_st4NC_res_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4NC_res_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NC_res_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NC_res_3.Location = New System.Drawing.Point(320, 91)
        Me.lbl_st4NC_res_3.Name = "lbl_st4NC_res_3"
        Me.lbl_st4NC_res_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NC_res_3.TabIndex = 37
        Me.lbl_st4NC_res_3.Text = "..."
        '
        'lbl_st4NO_res_1
        '
        Me.lbl_st4NO_res_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4NO_res_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NO_res_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NO_res_1.Location = New System.Drawing.Point(214, 114)
        Me.lbl_st4NO_res_1.Name = "lbl_st4NO_res_1"
        Me.lbl_st4NO_res_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NO_res_1.TabIndex = 37
        Me.lbl_st4NO_res_1.Text = "..."
        '
        'lbl_st4NC_res_2
        '
        Me.lbl_st4NC_res_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4NC_res_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NC_res_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NC_res_2.Location = New System.Drawing.Point(267, 91)
        Me.lbl_st4NC_res_2.Name = "lbl_st4NC_res_2"
        Me.lbl_st4NC_res_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NC_res_2.TabIndex = 37
        Me.lbl_st4NC_res_2.Text = "..."
        '
        'lbl_st4NO_res
        '
        Me.lbl_st4NO_res.BackColor = System.Drawing.Color.White
        Me.lbl_st4NO_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NO_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NO_res.Location = New System.Drawing.Point(161, 114)
        Me.lbl_st4NO_res.Name = "lbl_st4NO_res"
        Me.lbl_st4NO_res.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NO_res.TabIndex = 37
        Me.lbl_st4NO_res.Text = "..."
        '
        'lbl_st4NC_res_1
        '
        Me.lbl_st4NC_res_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4NC_res_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NC_res_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NC_res_1.Location = New System.Drawing.Point(214, 91)
        Me.lbl_st4NC_res_1.Name = "lbl_st4NC_res_1"
        Me.lbl_st4NC_res_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NC_res_1.TabIndex = 37
        Me.lbl_st4NC_res_1.Text = "..."
        '
        'lbl_st4NC_res
        '
        Me.lbl_st4NC_res.BackColor = System.Drawing.Color.White
        Me.lbl_st4NC_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4NC_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4NC_res.Location = New System.Drawing.Point(161, 91)
        Me.lbl_st4NC_res.Name = "lbl_st4NC_res"
        Me.lbl_st4NC_res.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4NC_res.TabIndex = 37
        Me.lbl_st4NC_res.Text = "..."
        '
        'lbl_st4_p3_5
        '
        Me.lbl_st4_p3_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3_5.Location = New System.Drawing.Point(426, 159)
        Me.lbl_st4_p3_5.Name = "lbl_st4_p3_5"
        Me.lbl_st4_p3_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p3_5.TabIndex = 37
        Me.lbl_st4_p3_5.Text = "..."
        '
        'lbl_st4_p3_4
        '
        Me.lbl_st4_p3_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3_4.Location = New System.Drawing.Point(373, 159)
        Me.lbl_st4_p3_4.Name = "lbl_st4_p3_4"
        Me.lbl_st4_p3_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p3_4.TabIndex = 37
        Me.lbl_st4_p3_4.Text = "..."
        '
        'lbl_st4_p3_3
        '
        Me.lbl_st4_p3_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3_3.Location = New System.Drawing.Point(320, 159)
        Me.lbl_st4_p3_3.Name = "lbl_st4_p3_3"
        Me.lbl_st4_p3_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p3_3.TabIndex = 37
        Me.lbl_st4_p3_3.Text = "..."
        '
        'lbl_st4_p3_2
        '
        Me.lbl_st4_p3_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3_2.Location = New System.Drawing.Point(267, 159)
        Me.lbl_st4_p3_2.Name = "lbl_st4_p3_2"
        Me.lbl_st4_p3_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p3_2.TabIndex = 37
        Me.lbl_st4_p3_2.Text = "..."
        '
        'lbl_st4_p3_1
        '
        Me.lbl_st4_p3_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3_1.Location = New System.Drawing.Point(214, 159)
        Me.lbl_st4_p3_1.Name = "lbl_st4_p3_1"
        Me.lbl_st4_p3_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p3_1.TabIndex = 37
        Me.lbl_st4_p3_1.Text = "..."
        '
        'lbl_st4_p3
        '
        Me.lbl_st4_p3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_p3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_p3.Location = New System.Drawing.Point(161, 159)
        Me.lbl_st4_p3.Name = "lbl_st4_p3"
        Me.lbl_st4_p3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_p3.TabIndex = 37
        Me.lbl_st4_p3.Text = "..."
        '
        'lbl_item_6
        '
        Me.lbl_item_6.BackColor = System.Drawing.Color.White
        Me.lbl_item_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_item_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_6.Location = New System.Drawing.Point(426, 21)
        Me.lbl_item_6.Name = "lbl_item_6"
        Me.lbl_item_6.Size = New System.Drawing.Size(50, 20)
        Me.lbl_item_6.TabIndex = 37
        Me.lbl_item_6.Text = "6"
        Me.lbl_item_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_item_5
        '
        Me.lbl_item_5.BackColor = System.Drawing.Color.White
        Me.lbl_item_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_item_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_5.Location = New System.Drawing.Point(373, 21)
        Me.lbl_item_5.Name = "lbl_item_5"
        Me.lbl_item_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_item_5.TabIndex = 37
        Me.lbl_item_5.Text = "5"
        Me.lbl_item_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_status_5
        '
        Me.lbl_status_5.BackColor = System.Drawing.Color.White
        Me.lbl_status_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_5.Location = New System.Drawing.Point(426, 44)
        Me.lbl_status_5.Name = "lbl_status_5"
        Me.lbl_status_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status_5.TabIndex = 37
        Me.lbl_status_5.Text = "..."
        '
        'lbl_item_4
        '
        Me.lbl_item_4.BackColor = System.Drawing.Color.White
        Me.lbl_item_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_item_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_4.Location = New System.Drawing.Point(320, 21)
        Me.lbl_item_4.Name = "lbl_item_4"
        Me.lbl_item_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_item_4.TabIndex = 37
        Me.lbl_item_4.Text = "4"
        Me.lbl_item_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_status_4
        '
        Me.lbl_status_4.BackColor = System.Drawing.Color.White
        Me.lbl_status_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_4.Location = New System.Drawing.Point(373, 44)
        Me.lbl_status_4.Name = "lbl_status_4"
        Me.lbl_status_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status_4.TabIndex = 37
        Me.lbl_status_4.Text = "..."
        '
        'lbl_item_3
        '
        Me.lbl_item_3.BackColor = System.Drawing.Color.White
        Me.lbl_item_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_item_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_3.Location = New System.Drawing.Point(267, 21)
        Me.lbl_item_3.Name = "lbl_item_3"
        Me.lbl_item_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_item_3.TabIndex = 37
        Me.lbl_item_3.Text = "3"
        Me.lbl_item_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_status_3
        '
        Me.lbl_status_3.BackColor = System.Drawing.Color.White
        Me.lbl_status_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_3.Location = New System.Drawing.Point(320, 44)
        Me.lbl_status_3.Name = "lbl_status_3"
        Me.lbl_status_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status_3.TabIndex = 37
        Me.lbl_status_3.Text = "..."
        '
        'lbl_item_2
        '
        Me.lbl_item_2.BackColor = System.Drawing.Color.White
        Me.lbl_item_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_item_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_2.Location = New System.Drawing.Point(214, 21)
        Me.lbl_item_2.Name = "lbl_item_2"
        Me.lbl_item_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_item_2.TabIndex = 37
        Me.lbl_item_2.Text = "2"
        Me.lbl_item_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_status_2
        '
        Me.lbl_status_2.BackColor = System.Drawing.Color.White
        Me.lbl_status_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_2.Location = New System.Drawing.Point(267, 44)
        Me.lbl_status_2.Name = "lbl_status_2"
        Me.lbl_status_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status_2.TabIndex = 37
        Me.lbl_status_2.Text = "..."
        '
        'lbl_item_1
        '
        Me.lbl_item_1.BackColor = System.Drawing.Color.White
        Me.lbl_item_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_item_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_1.Location = New System.Drawing.Point(161, 21)
        Me.lbl_item_1.Name = "lbl_item_1"
        Me.lbl_item_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_item_1.TabIndex = 37
        Me.lbl_item_1.Text = "1"
        Me.lbl_item_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_status_1
        '
        Me.lbl_status_1.BackColor = System.Drawing.Color.White
        Me.lbl_status_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_1.Location = New System.Drawing.Point(214, 44)
        Me.lbl_status_1.Name = "lbl_status_1"
        Me.lbl_status_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status_1.TabIndex = 37
        Me.lbl_status_1.Text = "..."
        '
        'lbl_status
        '
        Me.lbl_status.BackColor = System.Drawing.Color.White
        Me.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(161, 44)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status.TabIndex = 37
        Me.lbl_status.Text = "..."
        '
        'GroupBox77
        '
        Me.GroupBox77.Controls.Add(Me.ind_software_stop)
        Me.GroupBox77.Controls.Add(Me.Label67)
        Me.GroupBox77.Controls.Add(Me.ind_software_run)
        Me.GroupBox77.Controls.Add(Me.Label66)
        Me.GroupBox77.Controls.Add(Me.ind_software_open)
        Me.GroupBox77.Controls.Add(Me.Label65)
        Me.GroupBox77.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox77.Location = New System.Drawing.Point(73, 345)
        Me.GroupBox77.Name = "GroupBox77"
        Me.GroupBox77.Size = New System.Drawing.Size(200, 98)
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
        'GroupBox80
        '
        Me.GroupBox80.Controls.Add(Me.txt_po_num)
        Me.GroupBox80.Controls.Add(Me.txt_ope_id)
        Me.GroupBox80.Controls.Add(Me.txt_ref)
        Me.GroupBox80.Controls.Add(Me.Label85)
        Me.GroupBox80.Controls.Add(Me.Label83)
        Me.GroupBox80.Controls.Add(Me.btn_run)
        Me.GroupBox80.Controls.Add(Me.btn_empty)
        Me.GroupBox80.Controls.Add(Me.btn_stop)
        Me.GroupBox80.Controls.Add(Me.btn_clear)
        Me.GroupBox80.Controls.Add(Me.Label80)
        Me.GroupBox80.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox80.Location = New System.Drawing.Point(73, 4)
        Me.GroupBox80.Name = "GroupBox80"
        Me.GroupBox80.Size = New System.Drawing.Size(200, 339)
        Me.GroupBox80.TabIndex = 55
        Me.GroupBox80.TabStop = False
        Me.GroupBox80.Text = "Product Information"
        '
        'txt_po_num
        '
        Me.txt_po_num.Location = New System.Drawing.Point(10, 150)
        Me.txt_po_num.Name = "txt_po_num"
        Me.txt_po_num.Size = New System.Drawing.Size(170, 29)
        Me.txt_po_num.TabIndex = 70
        '
        'txt_ope_id
        '
        Me.txt_ope_id.Location = New System.Drawing.Point(10, 98)
        Me.txt_ope_id.Name = "txt_ope_id"
        Me.txt_ope_id.Size = New System.Drawing.Size(170, 29)
        Me.txt_ope_id.TabIndex = 70
        '
        'txt_ref
        '
        Me.txt_ref.Location = New System.Drawing.Point(10, 48)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Size = New System.Drawing.Size(170, 29)
        Me.txt_ref.TabIndex = 70
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
        'btn_run
        '
        Me.btn_run.FlatAppearance.BorderSize = 0
        Me.btn_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_run.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_run.Image = Global.TESTER.My.Resources.Resources.icons8_run_56
        Me.btn_run.Location = New System.Drawing.Point(12, 184)
        Me.btn_run.Name = "btn_run"
        Me.btn_run.Size = New System.Drawing.Size(80, 79)
        Me.btn_run.TabIndex = 69
        Me.btn_run.Text = "Start"
        Me.btn_run.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_run.UseVisualStyleBackColor = True
        '
        'btn_empty
        '
        Me.btn_empty.FlatAppearance.BorderSize = 0
        Me.btn_empty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_empty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empty.Image = Global.TESTER.My.Resources.Resources.icons8_emptying_baskets_56
        Me.btn_empty.Location = New System.Drawing.Point(10, 255)
        Me.btn_empty.Name = "btn_empty"
        Me.btn_empty.Size = New System.Drawing.Size(80, 79)
        Me.btn_empty.TabIndex = 69
        Me.btn_empty.Text = "Emptying"
        Me.btn_empty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_empty.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.FlatAppearance.BorderSize = 0
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stop.Image = Global.TESTER.My.Resources.Resources.icons8_stop_56
        Me.btn_stop.Location = New System.Drawing.Point(117, 184)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(60, 79)
        Me.btn_stop.TabIndex = 69
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = Global.TESTER.My.Resources.Resources.icons8_erase_56
        Me.btn_clear.Location = New System.Drawing.Point(120, 255)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 79)
        Me.btn_clear.TabIndex = 69
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'GroupBox76
        '
        Me.GroupBox76.Controls.Add(Me.ind_plc_status)
        Me.GroupBox76.Controls.Add(Me.Label64)
        Me.GroupBox76.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox76.Location = New System.Drawing.Point(73, 449)
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
        'lbl_op_ins
        '
        Me.lbl_op_ins.BackColor = System.Drawing.Color.Transparent
        Me.lbl_op_ins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_op_ins.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op_ins.ForeColor = System.Drawing.Color.Red
        Me.lbl_op_ins.Location = New System.Drawing.Point(289, 37)
        Me.lbl_op_ins.Name = "lbl_op_ins"
        Me.lbl_op_ins.Size = New System.Drawing.Size(216, 85)
        Me.lbl_op_ins.TabIndex = 49
        Me.lbl_op_ins.Text = "Please Scan Product References.."
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(285, 4)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(193, 24)
        Me.Label86.TabIndex = 50
        Me.Label86.Text = "Operator Instructions :"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(1013, 616)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(56, 18)
        Me.Label81.TabIndex = 36
        Me.Label81.Text = "ST4 T2"
        Me.Label81.Visible = False
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(1013, 640)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(93, 18)
        Me.Label117.TabIndex = 36
        Me.Label117.Text = "COT (T2-T1)"
        Me.Label117.Visible = False
        '
        'laabel3
        '
        Me.laabel3.AutoSize = True
        Me.laabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laabel3.Location = New System.Drawing.Point(1013, 592)
        Me.laabel3.Name = "laabel3"
        Me.laabel3.Size = New System.Drawing.Size(56, 18)
        Me.laabel3.TabIndex = 36
        Me.laabel3.Text = "ST4 T1"
        Me.laabel3.Visible = False
        '
        'lbl_st4_t2_5
        '
        Me.lbl_st4_t2_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2_5.Location = New System.Drawing.Point(1433, 614)
        Me.lbl_st4_t2_5.Name = "lbl_st4_t2_5"
        Me.lbl_st4_t2_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t2_5.TabIndex = 37
        Me.lbl_st4_t2_5.Text = "..."
        Me.lbl_st4_t2_5.Visible = False
        '
        'lbl_st4_t2_4
        '
        Me.lbl_st4_t2_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2_4.Location = New System.Drawing.Point(1380, 614)
        Me.lbl_st4_t2_4.Name = "lbl_st4_t2_4"
        Me.lbl_st4_t2_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t2_4.TabIndex = 37
        Me.lbl_st4_t2_4.Text = "..."
        Me.lbl_st4_t2_4.Visible = False
        '
        'lbl_st4_t2_3
        '
        Me.lbl_st4_t2_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2_3.Location = New System.Drawing.Point(1327, 614)
        Me.lbl_st4_t2_3.Name = "lbl_st4_t2_3"
        Me.lbl_st4_t2_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t2_3.TabIndex = 37
        Me.lbl_st4_t2_3.Text = "..."
        Me.lbl_st4_t2_3.Visible = False
        '
        'lbl_st4_t2_2
        '
        Me.lbl_st4_t2_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2_2.Location = New System.Drawing.Point(1274, 614)
        Me.lbl_st4_t2_2.Name = "lbl_st4_t2_2"
        Me.lbl_st4_t2_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t2_2.TabIndex = 37
        Me.lbl_st4_t2_2.Text = "..."
        Me.lbl_st4_t2_2.Visible = False
        '
        'lbl_st4_t2_1
        '
        Me.lbl_st4_t2_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2_1.Location = New System.Drawing.Point(1221, 614)
        Me.lbl_st4_t2_1.Name = "lbl_st4_t2_1"
        Me.lbl_st4_t2_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t2_1.TabIndex = 37
        Me.lbl_st4_t2_1.Text = "..."
        Me.lbl_st4_t2_1.Visible = False
        '
        'lbl_st4_t2
        '
        Me.lbl_st4_t2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t2.Location = New System.Drawing.Point(1168, 614)
        Me.lbl_st4_t2.Name = "lbl_st4_t2"
        Me.lbl_st4_t2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t2.TabIndex = 37
        Me.lbl_st4_t2.Text = "..."
        Me.lbl_st4_t2.Visible = False
        '
        'lbl_cot_5
        '
        Me.lbl_cot_5.BackColor = System.Drawing.Color.White
        Me.lbl_cot_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot_5.Location = New System.Drawing.Point(1433, 638)
        Me.lbl_cot_5.Name = "lbl_cot_5"
        Me.lbl_cot_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_cot_5.TabIndex = 37
        Me.lbl_cot_5.Text = "..."
        Me.lbl_cot_5.Visible = False
        '
        'lbl_cot_4
        '
        Me.lbl_cot_4.BackColor = System.Drawing.Color.White
        Me.lbl_cot_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot_4.Location = New System.Drawing.Point(1380, 638)
        Me.lbl_cot_4.Name = "lbl_cot_4"
        Me.lbl_cot_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_cot_4.TabIndex = 37
        Me.lbl_cot_4.Text = "..."
        Me.lbl_cot_4.Visible = False
        '
        'lbl_cot_3
        '
        Me.lbl_cot_3.BackColor = System.Drawing.Color.White
        Me.lbl_cot_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot_3.Location = New System.Drawing.Point(1327, 638)
        Me.lbl_cot_3.Name = "lbl_cot_3"
        Me.lbl_cot_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_cot_3.TabIndex = 37
        Me.lbl_cot_3.Text = "..."
        Me.lbl_cot_3.Visible = False
        '
        'lbl_cot_2
        '
        Me.lbl_cot_2.BackColor = System.Drawing.Color.White
        Me.lbl_cot_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot_2.Location = New System.Drawing.Point(1274, 638)
        Me.lbl_cot_2.Name = "lbl_cot_2"
        Me.lbl_cot_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_cot_2.TabIndex = 37
        Me.lbl_cot_2.Text = "..."
        Me.lbl_cot_2.Visible = False
        '
        'lbl_cot_1
        '
        Me.lbl_cot_1.BackColor = System.Drawing.Color.White
        Me.lbl_cot_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot_1.Location = New System.Drawing.Point(1221, 638)
        Me.lbl_cot_1.Name = "lbl_cot_1"
        Me.lbl_cot_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_cot_1.TabIndex = 37
        Me.lbl_cot_1.Text = "..."
        Me.lbl_cot_1.Visible = False
        '
        'lbl_cot
        '
        Me.lbl_cot.BackColor = System.Drawing.Color.White
        Me.lbl_cot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cot.Location = New System.Drawing.Point(1168, 638)
        Me.lbl_cot.Name = "lbl_cot"
        Me.lbl_cot.Size = New System.Drawing.Size(50, 20)
        Me.lbl_cot.TabIndex = 37
        Me.lbl_cot.Text = "..."
        Me.lbl_cot.Visible = False
        '
        'lbl_st4_t1_5
        '
        Me.lbl_st4_t1_5.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1_5.Location = New System.Drawing.Point(1433, 590)
        Me.lbl_st4_t1_5.Name = "lbl_st4_t1_5"
        Me.lbl_st4_t1_5.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t1_5.TabIndex = 37
        Me.lbl_st4_t1_5.Text = "..."
        Me.lbl_st4_t1_5.Visible = False
        '
        'lbl_st4_t1_4
        '
        Me.lbl_st4_t1_4.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1_4.Location = New System.Drawing.Point(1380, 590)
        Me.lbl_st4_t1_4.Name = "lbl_st4_t1_4"
        Me.lbl_st4_t1_4.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t1_4.TabIndex = 37
        Me.lbl_st4_t1_4.Text = "..."
        Me.lbl_st4_t1_4.Visible = False
        '
        'lbl_st4_t1_3
        '
        Me.lbl_st4_t1_3.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1_3.Location = New System.Drawing.Point(1327, 590)
        Me.lbl_st4_t1_3.Name = "lbl_st4_t1_3"
        Me.lbl_st4_t1_3.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t1_3.TabIndex = 37
        Me.lbl_st4_t1_3.Text = "..."
        Me.lbl_st4_t1_3.Visible = False
        '
        'lbl_st4_t1_2
        '
        Me.lbl_st4_t1_2.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1_2.Location = New System.Drawing.Point(1274, 590)
        Me.lbl_st4_t1_2.Name = "lbl_st4_t1_2"
        Me.lbl_st4_t1_2.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t1_2.TabIndex = 37
        Me.lbl_st4_t1_2.Text = "..."
        Me.lbl_st4_t1_2.Visible = False
        '
        'lbl_st4_t1_1
        '
        Me.lbl_st4_t1_1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1_1.Location = New System.Drawing.Point(1221, 590)
        Me.lbl_st4_t1_1.Name = "lbl_st4_t1_1"
        Me.lbl_st4_t1_1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t1_1.TabIndex = 37
        Me.lbl_st4_t1_1.Text = "..."
        Me.lbl_st4_t1_1.Visible = False
        '
        'lbl_st4_t1
        '
        Me.lbl_st4_t1.BackColor = System.Drawing.Color.White
        Me.lbl_st4_t1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_st4_t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_st4_t1.Location = New System.Drawing.Point(1168, 590)
        Me.lbl_st4_t1.Name = "lbl_st4_t1"
        Me.lbl_st4_t1.Size = New System.Drawing.Size(50, 20)
        Me.lbl_st4_t1.TabIndex = 37
        Me.lbl_st4_t1.Text = "..."
        Me.lbl_st4_t1.Visible = False
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
        Me.GroupBox87.Location = New System.Drawing.Point(532, 727)
        Me.GroupBox87.Name = "GroupBox87"
        Me.GroupBox87.Size = New System.Drawing.Size(485, 61)
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
        Me.lbl_cnt_st5.Size = New System.Drawing.Size(27, 20)
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
        Me.lbl_cnt_st4.Size = New System.Drawing.Size(27, 20)
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
        Me.lbl_cnt_st3.Size = New System.Drawing.Size(27, 20)
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
        Me.lbl_cnt_st2.Size = New System.Drawing.Size(27, 20)
        Me.lbl_cnt_st2.TabIndex = 37
        Me.lbl_cnt_st2.Text = "..."
        '
        'txt_msg
        '
        Me.txt_msg.BackColor = System.Drawing.Color.Silver
        Me.txt_msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_msg.ForeColor = System.Drawing.Color.Black
        Me.txt_msg.Location = New System.Drawing.Point(259, 758)
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(216, 253)
        Me.txt_msg.TabIndex = 49
        Me.txt_msg.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(256, 729)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 24)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "System Information :"
        Me.Label18.Visible = False
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
        Me.GroupBox86.Location = New System.Drawing.Point(1014, 526)
        Me.GroupBox86.Name = "GroupBox86"
        Me.GroupBox86.Size = New System.Drawing.Size(215, 278)
        Me.GroupBox86.TabIndex = 53
        Me.GroupBox86.TabStop = False
        Me.GroupBox86.Text = "Product Database :"
        Me.GroupBox86.Visible = False
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
        'pnl_man_stn6
        '
        Me.pnl_man_stn6.Controls.Add(Me.TabPage4)
        Me.pnl_man_stn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn6.Location = New System.Drawing.Point(78, 88)
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
        Me.TabPage4.Controls.Add(Me.GroupBox82)
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
        Me.GroupBox88.Location = New System.Drawing.Point(464, 269)
        Me.GroupBox88.Name = "GroupBox88"
        Me.GroupBox88.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox88.TabIndex = 39
        Me.GroupBox88.TabStop = False
        Me.GroupBox88.Text = "V606"
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
        Me.GroupBox73.Location = New System.Drawing.Point(238, 269)
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
        Me.GroupBox67.Location = New System.Drawing.Point(13, 269)
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
        'GroupBox82
        '
        Me.GroupBox82.AutoSize = True
        Me.GroupBox82.Controls.Add(Me.GroupBox83)
        Me.GroupBox82.Controls.Add(Me.GroupBox85)
        Me.GroupBox82.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox82.Location = New System.Drawing.Point(689, 25)
        Me.GroupBox82.Name = "GroupBox82"
        Me.GroupBox82.Size = New System.Drawing.Size(140, 481)
        Me.GroupBox82.TabIndex = 42
        Me.GroupBox82.TabStop = False
        Me.GroupBox82.Text = "Laser"
        '
        'GroupBox83
        '
        Me.GroupBox83.Controls.Add(Me.Label312)
        Me.GroupBox83.Controls.Add(Me.Label300)
        Me.GroupBox83.Controls.Add(Me.Label311)
        Me.GroupBox83.Controls.Add(Me.stn6_laser_interlock)
        Me.GroupBox83.Controls.Add(Me.stn6_laser_finish)
        Me.GroupBox83.Controls.Add(Me.stn6_laser_ready)
        Me.GroupBox83.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox83.Location = New System.Drawing.Point(25, 155)
        Me.GroupBox83.Name = "GroupBox83"
        Me.GroupBox83.Size = New System.Drawing.Size(90, 292)
        Me.GroupBox83.TabIndex = 4
        Me.GroupBox83.TabStop = False
        Me.GroupBox83.Text = "Sensor"
        '
        'Label312
        '
        Me.Label312.AutoSize = True
        Me.Label312.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label312.Location = New System.Drawing.Point(16, 268)
        Me.Label312.Name = "Label312"
        Me.Label312.Size = New System.Drawing.Size(64, 18)
        Me.Label312.TabIndex = 1
        Me.Label312.Text = "Interlock"
        '
        'Label300
        '
        Me.Label300.AutoSize = True
        Me.Label300.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label300.Location = New System.Drawing.Point(21, 170)
        Me.Label300.Name = "Label300"
        Me.Label300.Size = New System.Drawing.Size(47, 18)
        Me.Label300.TabIndex = 1
        Me.Label300.Text = "Finish"
        '
        'Label311
        '
        Me.Label311.AutoSize = True
        Me.Label311.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label311.Location = New System.Drawing.Point(21, 73)
        Me.Label311.Name = "Label311"
        Me.Label311.Size = New System.Drawing.Size(50, 18)
        Me.Label311.TabIndex = 1
        Me.Label311.Text = "Ready"
        '
        'stn6_laser_interlock
        '
        Me.stn6_laser_interlock.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_laser_interlock.Location = New System.Drawing.Point(6, 226)
        Me.stn6_laser_interlock.Name = "stn6_laser_interlock"
        Me.stn6_laser_interlock.Size = New System.Drawing.Size(80, 33)
        Me.stn6_laser_interlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_laser_interlock.TabIndex = 0
        Me.stn6_laser_interlock.TabStop = False
        '
        'stn6_laser_finish
        '
        Me.stn6_laser_finish.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_laser_finish.Location = New System.Drawing.Point(6, 128)
        Me.stn6_laser_finish.Name = "stn6_laser_finish"
        Me.stn6_laser_finish.Size = New System.Drawing.Size(80, 33)
        Me.stn6_laser_finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_laser_finish.TabIndex = 0
        Me.stn6_laser_finish.TabStop = False
        '
        'stn6_laser_ready
        '
        Me.stn6_laser_ready.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn6_laser_ready.Location = New System.Drawing.Point(6, 30)
        Me.stn6_laser_ready.Name = "stn6_laser_ready"
        Me.stn6_laser_ready.Size = New System.Drawing.Size(80, 33)
        Me.stn6_laser_ready.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn6_laser_ready.TabIndex = 0
        Me.stn6_laser_ready.TabStop = False
        '
        'GroupBox85
        '
        Me.GroupBox85.Controls.Add(Me.btn_stn6_laser_start)
        Me.GroupBox85.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox85.Location = New System.Drawing.Point(25, 33)
        Me.GroupBox85.Name = "GroupBox85"
        Me.GroupBox85.Size = New System.Drawing.Size(88, 103)
        Me.GroupBox85.TabIndex = 5
        Me.GroupBox85.TabStop = False
        Me.GroupBox85.Text = "Button"
        '
        'btn_stn6_laser_start
        '
        Me.btn_stn6_laser_start.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn6_laser_start.FlatAppearance.BorderSize = 0
        Me.btn_stn6_laser_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn6_laser_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn6_laser_start.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn6_laser_start.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn6_laser_start.Location = New System.Drawing.Point(-8, 19)
        Me.btn_stn6_laser_start.Name = "btn_stn6_laser_start"
        Me.btn_stn6_laser_start.Size = New System.Drawing.Size(102, 80)
        Me.btn_stn6_laser_start.TabIndex = 2
        Me.btn_stn6_laser_start.Text = "Start"
        Me.btn_stn6_laser_start.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn6_laser_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn6_laser_start.UseVisualStyleBackColor = False
        '
        'GroupBox64
        '
        Me.GroupBox64.AutoSize = True
        Me.GroupBox64.Controls.Add(Me.GroupBox65)
        Me.GroupBox64.Controls.Add(Me.GroupBox66)
        Me.GroupBox64.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox64.Location = New System.Drawing.Point(464, 25)
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
        Me.GroupBox61.Location = New System.Drawing.Point(238, 25)
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
        Me.GroupBox70.Location = New System.Drawing.Point(13, 25)
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
        Me.TabPage5.Controls.Add(Me.GroupBox172)
        Me.TabPage5.Controls.Add(Me.GroupBox49)
        Me.TabPage5.Controls.Add(Me.GroupBox52)
        Me.TabPage5.Controls.Add(Me.GroupBox55)
        Me.TabPage5.Controls.Add(Me.GroupBox58)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(845, 516)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Manual Station 5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox172
        '
        Me.GroupBox172.AutoSize = True
        Me.GroupBox172.Controls.Add(Me.GroupBox173)
        Me.GroupBox172.Controls.Add(Me.GroupBox180)
        Me.GroupBox172.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox172.Location = New System.Drawing.Point(448, 272)
        Me.GroupBox172.Name = "GroupBox172"
        Me.GroupBox172.Size = New System.Drawing.Size(208, 239)
        Me.GroupBox172.TabIndex = 34
        Me.GroupBox172.TabStop = False
        Me.GroupBox172.Text = "Screw Driver"
        '
        'GroupBox173
        '
        Me.GroupBox173.Controls.Add(Me.Label297)
        Me.GroupBox173.Controls.Add(Me.Label298)
        Me.GroupBox173.Controls.Add(Me.PictureBox2)
        Me.GroupBox173.Controls.Add(Me.PictureBox3)
        Me.GroupBox173.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox173.Location = New System.Drawing.Point(106, 38)
        Me.GroupBox173.Name = "GroupBox173"
        Me.GroupBox173.Size = New System.Drawing.Size(89, 170)
        Me.GroupBox173.TabIndex = 3
        Me.GroupBox173.TabStop = False
        Me.GroupBox173.Text = "Sensor"
        '
        'Label297
        '
        Me.Label297.AutoSize = True
        Me.Label297.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label297.Location = New System.Drawing.Point(11, 147)
        Me.Label297.Name = "Label297"
        Me.Label297.Size = New System.Drawing.Size(69, 18)
        Me.Label297.TabIndex = 1
        Me.Label297.Text = "Minimum"
        '
        'Label298
        '
        Me.Label298.AutoSize = True
        Me.Label298.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label298.Location = New System.Drawing.Point(11, 73)
        Me.Label298.Name = "Label298"
        Me.Label298.Size = New System.Drawing.Size(73, 18)
        Me.Label298.TabIndex = 1
        Me.Label298.Text = "Maximum"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.PictureBox2.Location = New System.Drawing.Point(20, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.PictureBox3.Location = New System.Drawing.Point(20, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'GroupBox180
        '
        Me.GroupBox180.Controls.Add(Me.btn_stn5_screw_fw)
        Me.GroupBox180.Controls.Add(Me.btn_stn5_screw_bw)
        Me.GroupBox180.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox180.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox180.Name = "GroupBox180"
        Me.GroupBox180.Size = New System.Drawing.Size(81, 170)
        Me.GroupBox180.TabIndex = 3
        Me.GroupBox180.TabStop = False
        Me.GroupBox180.Text = "Button"
        '
        'btn_stn5_screw_fw
        '
        Me.btn_stn5_screw_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_screw_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_screw_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_screw_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_screw_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_screw_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_screw_fw.Location = New System.Drawing.Point(-11, 19)
        Me.btn_stn5_screw_fw.Name = "btn_stn5_screw_fw"
        Me.btn_stn5_screw_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_screw_fw.TabIndex = 2
        Me.btn_stn5_screw_fw.Text = "Forward"
        Me.btn_stn5_screw_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_screw_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_screw_fw.UseVisualStyleBackColor = False
        '
        'btn_stn5_screw_bw
        '
        Me.btn_stn5_screw_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_screw_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_screw_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_screw_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_screw_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_screw_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_screw_bw.Location = New System.Drawing.Point(-11, 95)
        Me.btn_stn5_screw_bw.Name = "btn_stn5_screw_bw"
        Me.btn_stn5_screw_bw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_screw_bw.TabIndex = 2
        Me.btn_stn5_screw_bw.Text = "Backward"
        Me.btn_stn5_screw_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_screw_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_screw_bw.UseVisualStyleBackColor = False
        '
        'GroupBox49
        '
        Me.GroupBox49.AutoSize = True
        Me.GroupBox49.Controls.Add(Me.GroupBox50)
        Me.GroupBox49.Controls.Add(Me.GroupBox51)
        Me.GroupBox49.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox49.Location = New System.Drawing.Point(218, 272)
        Me.GroupBox49.Name = "GroupBox49"
        Me.GroupBox49.Size = New System.Drawing.Size(208, 239)
        Me.GroupBox49.TabIndex = 34
        Me.GroupBox49.TabStop = False
        Me.GroupBox49.Text = "V504"
        '
        'GroupBox50
        '
        Me.GroupBox50.Controls.Add(Me.Label43)
        Me.GroupBox50.Controls.Add(Me.Label44)
        Me.GroupBox50.Controls.Add(Me.stn5_cyl4_min)
        Me.GroupBox50.Controls.Add(Me.stn5_cyl4_max)
        Me.GroupBox50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox50.Location = New System.Drawing.Point(106, 38)
        Me.GroupBox50.Name = "GroupBox50"
        Me.GroupBox50.Size = New System.Drawing.Size(89, 170)
        Me.GroupBox50.TabIndex = 3
        Me.GroupBox50.TabStop = False
        Me.GroupBox50.Text = "Sensor"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(11, 147)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(69, 18)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "Minimum"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(11, 73)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(73, 18)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Maximum"
        '
        'stn5_cyl4_min
        '
        Me.stn5_cyl4_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl4_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl4_min.Name = "stn5_cyl4_min"
        Me.stn5_cyl4_min.Size = New System.Drawing.Size(51, 33)
        Me.stn5_cyl4_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl4_min.TabIndex = 0
        Me.stn5_cyl4_min.TabStop = False
        '
        'stn5_cyl4_max
        '
        Me.stn5_cyl4_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl4_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl4_max.Name = "stn5_cyl4_max"
        Me.stn5_cyl4_max.Size = New System.Drawing.Size(51, 33)
        Me.stn5_cyl4_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl4_max.TabIndex = 0
        Me.stn5_cyl4_max.TabStop = False
        '
        'GroupBox51
        '
        Me.GroupBox51.Controls.Add(Me.btn_stn5_cyl4_fw)
        Me.GroupBox51.Controls.Add(Me.btn_stn5_cyl4_bw)
        Me.GroupBox51.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox51.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox51.Name = "GroupBox51"
        Me.GroupBox51.Size = New System.Drawing.Size(81, 170)
        Me.GroupBox51.TabIndex = 3
        Me.GroupBox51.TabStop = False
        Me.GroupBox51.Text = "Button"
        '
        'btn_stn5_cyl4_fw
        '
        Me.btn_stn5_cyl4_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl4_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl4_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl4_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl4_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl4_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl4_fw.Location = New System.Drawing.Point(-11, 19)
        Me.btn_stn5_cyl4_fw.Name = "btn_stn5_cyl4_fw"
        Me.btn_stn5_cyl4_fw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_cyl4_fw.TabIndex = 2
        Me.btn_stn5_cyl4_fw.Text = "Forward"
        Me.btn_stn5_cyl4_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl4_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl4_fw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl4_bw
        '
        Me.btn_stn5_cyl4_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl4_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl4_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl4_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl4_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl4_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl4_bw.Location = New System.Drawing.Point(-11, 95)
        Me.btn_stn5_cyl4_bw.Name = "btn_stn5_cyl4_bw"
        Me.btn_stn5_cyl4_bw.Size = New System.Drawing.Size(102, 79)
        Me.btn_stn5_cyl4_bw.TabIndex = 2
        Me.btn_stn5_cyl4_bw.Text = "Backward"
        Me.btn_stn5_cyl4_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl4_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl4_bw.UseVisualStyleBackColor = False
        '
        'GroupBox52
        '
        Me.GroupBox52.AutoSize = True
        Me.GroupBox52.Controls.Add(Me.GroupBox53)
        Me.GroupBox52.Controls.Add(Me.GroupBox54)
        Me.GroupBox52.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox52.Location = New System.Drawing.Point(328, 27)
        Me.GroupBox52.Name = "GroupBox52"
        Me.GroupBox52.Size = New System.Drawing.Size(208, 239)
        Me.GroupBox52.TabIndex = 35
        Me.GroupBox52.TabStop = False
        Me.GroupBox52.Text = "V502"
        '
        'GroupBox53
        '
        Me.GroupBox53.Controls.Add(Me.Label45)
        Me.GroupBox53.Controls.Add(Me.Label46)
        Me.GroupBox53.Controls.Add(Me.stn5_cyl2_min)
        Me.GroupBox53.Controls.Add(Me.stn5_cyl2_max)
        Me.GroupBox53.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox53.Location = New System.Drawing.Point(106, 37)
        Me.GroupBox53.Name = "GroupBox53"
        Me.GroupBox53.Size = New System.Drawing.Size(87, 170)
        Me.GroupBox53.TabIndex = 3
        Me.GroupBox53.TabStop = False
        Me.GroupBox53.Text = "Sensor"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(10, 148)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(69, 18)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Minimum"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(11, 72)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(73, 18)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "Maximum"
        '
        'stn5_cyl2_min
        '
        Me.stn5_cyl2_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl2_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl2_min.Name = "stn5_cyl2_min"
        Me.stn5_cyl2_min.Size = New System.Drawing.Size(51, 33)
        Me.stn5_cyl2_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl2_min.TabIndex = 0
        Me.stn5_cyl2_min.TabStop = False
        '
        'stn5_cyl2_max
        '
        Me.stn5_cyl2_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl2_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl2_max.Name = "stn5_cyl2_max"
        Me.stn5_cyl2_max.Size = New System.Drawing.Size(51, 33)
        Me.stn5_cyl2_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl2_max.TabIndex = 0
        Me.stn5_cyl2_max.TabStop = False
        '
        'GroupBox54
        '
        Me.GroupBox54.Controls.Add(Me.btn_stn5_cyl2_fw)
        Me.GroupBox54.Controls.Add(Me.btn_stn5_cyl2_bw)
        Me.GroupBox54.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox54.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox54.Name = "GroupBox54"
        Me.GroupBox54.Size = New System.Drawing.Size(78, 170)
        Me.GroupBox54.TabIndex = 3
        Me.GroupBox54.TabStop = False
        Me.GroupBox54.Text = "Button"
        '
        'btn_stn5_cyl2_fw
        '
        Me.btn_stn5_cyl2_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl2_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl2_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl2_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl2_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl2_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl2_fw.Location = New System.Drawing.Point(-4, 19)
        Me.btn_stn5_cyl2_fw.Name = "btn_stn5_cyl2_fw"
        Me.btn_stn5_cyl2_fw.Size = New System.Drawing.Size(83, 83)
        Me.btn_stn5_cyl2_fw.TabIndex = 2
        Me.btn_stn5_cyl2_fw.Text = "Forward"
        Me.btn_stn5_cyl2_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl2_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl2_fw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl2_bw
        '
        Me.btn_stn5_cyl2_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl2_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl2_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl2_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl2_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl2_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl2_bw.Location = New System.Drawing.Point(-4, 95)
        Me.btn_stn5_cyl2_bw.Name = "btn_stn5_cyl2_bw"
        Me.btn_stn5_cyl2_bw.Size = New System.Drawing.Size(83, 86)
        Me.btn_stn5_cyl2_bw.TabIndex = 2
        Me.btn_stn5_cyl2_bw.Text = "Backward"
        Me.btn_stn5_cyl2_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl2_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl2_bw.UseVisualStyleBackColor = False
        '
        'GroupBox55
        '
        Me.GroupBox55.AutoSize = True
        Me.GroupBox55.Controls.Add(Me.GroupBox56)
        Me.GroupBox55.Controls.Add(Me.GroupBox57)
        Me.GroupBox55.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox55.Location = New System.Drawing.Point(556, 26)
        Me.GroupBox55.Name = "GroupBox55"
        Me.GroupBox55.Size = New System.Drawing.Size(215, 239)
        Me.GroupBox55.TabIndex = 36
        Me.GroupBox55.TabStop = False
        Me.GroupBox55.Text = "V503"
        '
        'GroupBox56
        '
        Me.GroupBox56.Controls.Add(Me.Label47)
        Me.GroupBox56.Controls.Add(Me.Label48)
        Me.GroupBox56.Controls.Add(Me.stn5_cyl3_min)
        Me.GroupBox56.Controls.Add(Me.stn5_cyl3_max)
        Me.GroupBox56.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox56.Location = New System.Drawing.Point(111, 39)
        Me.GroupBox56.Name = "GroupBox56"
        Me.GroupBox56.Size = New System.Drawing.Size(92, 170)
        Me.GroupBox56.TabIndex = 3
        Me.GroupBox56.TabStop = False
        Me.GroupBox56.Text = "Sensor"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(15, 148)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(69, 18)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Minimum"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(14, 72)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(73, 18)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "Maximum"
        '
        'stn5_cyl3_min
        '
        Me.stn5_cyl3_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl3_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl3_min.Name = "stn5_cyl3_min"
        Me.stn5_cyl3_min.Size = New System.Drawing.Size(55, 33)
        Me.stn5_cyl3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl3_min.TabIndex = 0
        Me.stn5_cyl3_min.TabStop = False
        '
        'stn5_cyl3_max
        '
        Me.stn5_cyl3_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl3_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl3_max.Name = "stn5_cyl3_max"
        Me.stn5_cyl3_max.Size = New System.Drawing.Size(55, 33)
        Me.stn5_cyl3_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl3_max.TabIndex = 0
        Me.stn5_cyl3_max.TabStop = False
        '
        'GroupBox57
        '
        Me.GroupBox57.Controls.Add(Me.btn_stn5_cyl3_fw)
        Me.GroupBox57.Controls.Add(Me.btn_stn5_cyl3_bw)
        Me.GroupBox57.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox57.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox57.Name = "GroupBox57"
        Me.GroupBox57.Size = New System.Drawing.Size(85, 170)
        Me.GroupBox57.TabIndex = 3
        Me.GroupBox57.TabStop = False
        Me.GroupBox57.Text = "Button"
        '
        'btn_stn5_cyl3_fw
        '
        Me.btn_stn5_cyl3_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl3_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl3_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl3_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl3_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl3_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl3_fw.Location = New System.Drawing.Point(1, 19)
        Me.btn_stn5_cyl3_fw.Name = "btn_stn5_cyl3_fw"
        Me.btn_stn5_cyl3_fw.Size = New System.Drawing.Size(82, 79)
        Me.btn_stn5_cyl3_fw.TabIndex = 2
        Me.btn_stn5_cyl3_fw.Text = "Forward"
        Me.btn_stn5_cyl3_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl3_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl3_fw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl3_bw
        '
        Me.btn_stn5_cyl3_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl3_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl3_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl3_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl3_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl3_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl3_bw.Location = New System.Drawing.Point(1, 95)
        Me.btn_stn5_cyl3_bw.Name = "btn_stn5_cyl3_bw"
        Me.btn_stn5_cyl3_bw.Size = New System.Drawing.Size(82, 83)
        Me.btn_stn5_cyl3_bw.TabIndex = 2
        Me.btn_stn5_cyl3_bw.Text = "Backward"
        Me.btn_stn5_cyl3_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl3_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl3_bw.UseVisualStyleBackColor = False
        '
        'GroupBox58
        '
        Me.GroupBox58.AutoSize = True
        Me.GroupBox58.Controls.Add(Me.GroupBox59)
        Me.GroupBox58.Controls.Add(Me.GroupBox60)
        Me.GroupBox58.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox58.Location = New System.Drawing.Point(94, 28)
        Me.GroupBox58.Name = "GroupBox58"
        Me.GroupBox58.Size = New System.Drawing.Size(215, 237)
        Me.GroupBox58.TabIndex = 37
        Me.GroupBox58.TabStop = False
        Me.GroupBox58.Text = "V501"
        '
        'GroupBox59
        '
        Me.GroupBox59.Controls.Add(Me.Label49)
        Me.GroupBox59.Controls.Add(Me.Label50)
        Me.GroupBox59.Controls.Add(Me.stn5_cyl1_min)
        Me.GroupBox59.Controls.Add(Me.stn5_cyl1_max)
        Me.GroupBox59.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox59.Location = New System.Drawing.Point(104, 37)
        Me.GroupBox59.Name = "GroupBox59"
        Me.GroupBox59.Size = New System.Drawing.Size(89, 170)
        Me.GroupBox59.TabIndex = 3
        Me.GroupBox59.TabStop = False
        Me.GroupBox59.Text = "Sensor"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(10, 144)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 18)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Minimum"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(10, 71)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(73, 18)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Maximum"
        '
        'stn5_cyl1_min
        '
        Me.stn5_cyl1_min.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl1_min.Location = New System.Drawing.Point(20, 106)
        Me.stn5_cyl1_min.Name = "stn5_cyl1_min"
        Me.stn5_cyl1_min.Size = New System.Drawing.Size(52, 33)
        Me.stn5_cyl1_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl1_min.TabIndex = 0
        Me.stn5_cyl1_min.TabStop = False
        '
        'stn5_cyl1_max
        '
        Me.stn5_cyl1_max.Image = Global.TESTER.My.Resources.Resources.led_red_off
        Me.stn5_cyl1_max.Location = New System.Drawing.Point(20, 30)
        Me.stn5_cyl1_max.Name = "stn5_cyl1_max"
        Me.stn5_cyl1_max.Size = New System.Drawing.Size(52, 33)
        Me.stn5_cyl1_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stn5_cyl1_max.TabIndex = 0
        Me.stn5_cyl1_max.TabStop = False
        '
        'GroupBox60
        '
        Me.GroupBox60.Controls.Add(Me.btn_stn5_cyl1_fw)
        Me.GroupBox60.Controls.Add(Me.btn_stn5_cyl1_bw)
        Me.GroupBox60.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox60.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox60.Name = "GroupBox60"
        Me.GroupBox60.Size = New System.Drawing.Size(77, 170)
        Me.GroupBox60.TabIndex = 3
        Me.GroupBox60.TabStop = False
        Me.GroupBox60.Text = "Button"
        '
        'btn_stn5_cyl1_fw
        '
        Me.btn_stn5_cyl1_fw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl1_fw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl1_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl1_fw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl1_fw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl1_fw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl1_fw.Location = New System.Drawing.Point(-11, 19)
        Me.btn_stn5_cyl1_fw.Name = "btn_stn5_cyl1_fw"
        Me.btn_stn5_cyl1_fw.Size = New System.Drawing.Size(102, 74)
        Me.btn_stn5_cyl1_fw.TabIndex = 2
        Me.btn_stn5_cyl1_fw.Text = "Forward"
        Me.btn_stn5_cyl1_fw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl1_fw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl1_fw.UseVisualStyleBackColor = False
        '
        'btn_stn5_cyl1_bw
        '
        Me.btn_stn5_cyl1_bw.BackColor = System.Drawing.Color.Transparent
        Me.btn_stn5_cyl1_bw.FlatAppearance.BorderSize = 0
        Me.btn_stn5_cyl1_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stn5_cyl1_bw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stn5_cyl1_bw.Image = Global.TESTER.My.Resources.Resources.button_silver
        Me.btn_stn5_cyl1_bw.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stn5_cyl1_bw.Location = New System.Drawing.Point(-11, 95)
        Me.btn_stn5_cyl1_bw.Name = "btn_stn5_cyl1_bw"
        Me.btn_stn5_cyl1_bw.Size = New System.Drawing.Size(102, 86)
        Me.btn_stn5_cyl1_bw.TabIndex = 2
        Me.btn_stn5_cyl1_bw.Text = "Backward"
        Me.btn_stn5_cyl1_bw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stn5_cyl1_bw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stn5_cyl1_bw.UseVisualStyleBackColor = False
        '
        'pnl_man_stn5
        '
        Me.pnl_man_stn5.Controls.Add(Me.TabPage5)
        Me.pnl_man_stn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn5.Location = New System.Drawing.Point(78, 87)
        Me.pnl_man_stn5.Name = "pnl_man_stn5"
        Me.pnl_man_stn5.SelectedIndex = 0
        Me.pnl_man_stn5.Size = New System.Drawing.Size(853, 558)
        Me.pnl_man_stn5.TabIndex = 97
        '
        'pnl_man_stn4
        '
        Me.pnl_man_stn4.Controls.Add(Me.TabPage6)
        Me.pnl_man_stn4.Controls.Add(Me.TabPage24)
        Me.pnl_man_stn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn4.Location = New System.Drawing.Point(78, 87)
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
        Me.TabPage6.Text = "Manual Station 4"
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
        'TabPage24
        '
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_gt2_6)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_gt2_5)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_p0_6)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_gt2_4)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_p0_5)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_gt2_3)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_p0_4)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_gt2_2)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_p0_3)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_gt2_1)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_p0_2)
        Me.TabPage24.Controls.Add(Me.txt_st4_cal_val_p0_1)
        Me.TabPage24.Controls.Add(Me.Label324)
        Me.TabPage24.Controls.Add(Me.Label294)
        Me.TabPage24.Controls.Add(Me.Label323)
        Me.TabPage24.Controls.Add(Me.Label322)
        Me.TabPage24.Controls.Add(Me.Label293)
        Me.TabPage24.Controls.Add(Me.Label319)
        Me.TabPage24.Controls.Add(Me.Label318)
        Me.TabPage24.Controls.Add(Me.Label317)
        Me.TabPage24.Controls.Add(Me.txt_offset_gt)
        Me.TabPage24.Controls.Add(Me.txt_st4_analog_data)
        Me.TabPage24.Controls.Add(Me.txt_st4_diff_str)
        Me.TabPage24.Controls.Add(Me.txt_st4_act_vel)
        Me.TabPage24.Controls.Add(Me.txt_st4_actu_pos)
        Me.TabPage24.Controls.Add(Me.txt_st4_act_pos)
        Me.TabPage24.Controls.Add(Me.txt_st4_set_vel)
        Me.TabPage24.Controls.Add(Me.txt_st4_set_pos)
        Me.TabPage24.Controls.Add(Me.btn_st4_servo_stop)
        Me.TabPage24.Controls.Add(Me.btn_st4_servo_reset)
        Me.TabPage24.Controls.Add(Me.btn_st4_jog_ccw)
        Me.TabPage24.Controls.Add(Me.btn_st4_auto_calibration)
        Me.TabPage24.Controls.Add(Me.btn_st4_man_trig)
        Me.TabPage24.Controls.Add(Me.btn_st4_cal)
        Me.TabPage24.Controls.Add(Me.btn_st4_jog_cw)
        Me.TabPage24.Controls.Add(Me.btn_st4_move_vel)
        Me.TabPage24.Controls.Add(Me.btn_st4_move_pos)
        Me.TabPage24.Controls.Add(Me.btn_st4_save_data)
        Me.TabPage24.Controls.Add(Me.btn_st4_homing)
        Me.TabPage24.Controls.Add(Me.btn_st4_servo_enable)
        Me.TabPage24.Controls.Add(Me.Label290)
        Me.TabPage24.Controls.Add(Me.Label234)
        Me.TabPage24.Controls.Add(Me.Label235)
        Me.TabPage24.Controls.Add(Me.Label259)
        Me.TabPage24.Controls.Add(Me.Label260)
        Me.TabPage24.Controls.Add(Me.Label261)
        Me.TabPage24.Controls.Add(Me.Label291)
        Me.TabPage24.Controls.Add(Me.Label331)
        Me.TabPage24.Controls.Add(Me.Label292)
        Me.TabPage24.Controls.Add(Me.label_297)
        Me.TabPage24.Controls.Add(Me.Label262)
        Me.TabPage24.Controls.Add(Me.Label295)
        Me.TabPage24.Controls.Add(Me.Label263)
        Me.TabPage24.Controls.Add(Me.Label264)
        Me.TabPage24.Controls.Add(Me.Label265)
        Me.TabPage24.Controls.Add(Me.Label266)
        Me.TabPage24.Controls.Add(Me.Label267)
        Me.TabPage24.Controls.Add(Me.ind_st4_discrete_motion)
        Me.TabPage24.Controls.Add(Me.ind_st4_continuous_motion)
        Me.TabPage24.Controls.Add(Me.ind_st4_servo_busy)
        Me.TabPage24.Controls.Add(Me.ind_st4_standstill)
        Me.TabPage24.Controls.Add(Me.ind_st4_stopping)
        Me.TabPage24.Controls.Add(Me.ind_st4_servo_error)
        Me.TabPage24.Controls.Add(Me.ind_st4_home_busy)
        Me.TabPage24.Controls.Add(Me.ind_st4_servo_enabled)
        Me.TabPage24.Location = New System.Drawing.Point(4, 38)
        Me.TabPage24.Name = "TabPage24"
        Me.TabPage24.Size = New System.Drawing.Size(845, 521)
        Me.TabPage24.TabIndex = 1
        Me.TabPage24.Text = "Servo ST4"
        Me.TabPage24.UseVisualStyleBackColor = True
        '
        'txt_st4_cal_val_gt2_6
        '
        Me.txt_st4_cal_val_gt2_6.Enabled = False
        Me.txt_st4_cal_val_gt2_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_gt2_6.Location = New System.Drawing.Point(422, 230)
        Me.txt_st4_cal_val_gt2_6.Name = "txt_st4_cal_val_gt2_6"
        Me.txt_st4_cal_val_gt2_6.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_gt2_6.TabIndex = 116
        '
        'txt_st4_cal_val_gt2_5
        '
        Me.txt_st4_cal_val_gt2_5.Enabled = False
        Me.txt_st4_cal_val_gt2_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_gt2_5.Location = New System.Drawing.Point(422, 202)
        Me.txt_st4_cal_val_gt2_5.Name = "txt_st4_cal_val_gt2_5"
        Me.txt_st4_cal_val_gt2_5.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_gt2_5.TabIndex = 114
        '
        'txt_st4_cal_val_p0_6
        '
        Me.txt_st4_cal_val_p0_6.Enabled = False
        Me.txt_st4_cal_val_p0_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_p0_6.Location = New System.Drawing.Point(279, 231)
        Me.txt_st4_cal_val_p0_6.Name = "txt_st4_cal_val_p0_6"
        Me.txt_st4_cal_val_p0_6.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_p0_6.TabIndex = 105
        '
        'txt_st4_cal_val_gt2_4
        '
        Me.txt_st4_cal_val_gt2_4.Enabled = False
        Me.txt_st4_cal_val_gt2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_gt2_4.Location = New System.Drawing.Point(422, 174)
        Me.txt_st4_cal_val_gt2_4.Name = "txt_st4_cal_val_gt2_4"
        Me.txt_st4_cal_val_gt2_4.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_gt2_4.TabIndex = 113
        '
        'txt_st4_cal_val_p0_5
        '
        Me.txt_st4_cal_val_p0_5.Enabled = False
        Me.txt_st4_cal_val_p0_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_p0_5.Location = New System.Drawing.Point(279, 203)
        Me.txt_st4_cal_val_p0_5.Name = "txt_st4_cal_val_p0_5"
        Me.txt_st4_cal_val_p0_5.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_p0_5.TabIndex = 106
        '
        'txt_st4_cal_val_gt2_3
        '
        Me.txt_st4_cal_val_gt2_3.Enabled = False
        Me.txt_st4_cal_val_gt2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_gt2_3.Location = New System.Drawing.Point(422, 146)
        Me.txt_st4_cal_val_gt2_3.Name = "txt_st4_cal_val_gt2_3"
        Me.txt_st4_cal_val_gt2_3.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_gt2_3.TabIndex = 112
        '
        'txt_st4_cal_val_p0_4
        '
        Me.txt_st4_cal_val_p0_4.Enabled = False
        Me.txt_st4_cal_val_p0_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_p0_4.Location = New System.Drawing.Point(279, 175)
        Me.txt_st4_cal_val_p0_4.Name = "txt_st4_cal_val_p0_4"
        Me.txt_st4_cal_val_p0_4.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_p0_4.TabIndex = 107
        '
        'txt_st4_cal_val_gt2_2
        '
        Me.txt_st4_cal_val_gt2_2.Enabled = False
        Me.txt_st4_cal_val_gt2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_gt2_2.Location = New System.Drawing.Point(422, 118)
        Me.txt_st4_cal_val_gt2_2.Name = "txt_st4_cal_val_gt2_2"
        Me.txt_st4_cal_val_gt2_2.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_gt2_2.TabIndex = 115
        '
        'txt_st4_cal_val_p0_3
        '
        Me.txt_st4_cal_val_p0_3.Enabled = False
        Me.txt_st4_cal_val_p0_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_p0_3.Location = New System.Drawing.Point(279, 147)
        Me.txt_st4_cal_val_p0_3.Name = "txt_st4_cal_val_p0_3"
        Me.txt_st4_cal_val_p0_3.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_p0_3.TabIndex = 108
        '
        'txt_st4_cal_val_gt2_1
        '
        Me.txt_st4_cal_val_gt2_1.Enabled = False
        Me.txt_st4_cal_val_gt2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_gt2_1.Location = New System.Drawing.Point(422, 90)
        Me.txt_st4_cal_val_gt2_1.Name = "txt_st4_cal_val_gt2_1"
        Me.txt_st4_cal_val_gt2_1.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_gt2_1.TabIndex = 111
        '
        'txt_st4_cal_val_p0_2
        '
        Me.txt_st4_cal_val_p0_2.Enabled = False
        Me.txt_st4_cal_val_p0_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_p0_2.Location = New System.Drawing.Point(279, 119)
        Me.txt_st4_cal_val_p0_2.Name = "txt_st4_cal_val_p0_2"
        Me.txt_st4_cal_val_p0_2.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_p0_2.TabIndex = 109
        '
        'txt_st4_cal_val_p0_1
        '
        Me.txt_st4_cal_val_p0_1.Enabled = False
        Me.txt_st4_cal_val_p0_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_cal_val_p0_1.Location = New System.Drawing.Point(279, 91)
        Me.txt_st4_cal_val_p0_1.Name = "txt_st4_cal_val_p0_1"
        Me.txt_st4_cal_val_p0_1.Size = New System.Drawing.Size(107, 22)
        Me.txt_st4_cal_val_p0_1.TabIndex = 110
        '
        'Label324
        '
        Me.Label324.AutoSize = True
        Me.Label324.Enabled = False
        Me.Label324.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label324.Location = New System.Drawing.Point(259, 236)
        Me.Label324.Name = "Label324"
        Me.Label324.Size = New System.Drawing.Size(15, 16)
        Me.Label324.TabIndex = 102
        Me.Label324.Text = "6"
        '
        'Label294
        '
        Me.Label294.AutoSize = True
        Me.Label294.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label294.Location = New System.Drawing.Point(422, 52)
        Me.Label294.Name = "Label294"
        Me.Label294.Size = New System.Drawing.Size(78, 32)
        Me.Label294.TabIndex = 104
        Me.Label294.Text = "Calib" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value GT2 :"
        '
        'Label323
        '
        Me.Label323.AutoSize = True
        Me.Label323.Enabled = False
        Me.Label323.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label323.Location = New System.Drawing.Point(259, 208)
        Me.Label323.Name = "Label323"
        Me.Label323.Size = New System.Drawing.Size(15, 16)
        Me.Label323.TabIndex = 100
        Me.Label323.Text = "5"
        '
        'Label322
        '
        Me.Label322.AutoSize = True
        Me.Label322.Enabled = False
        Me.Label322.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label322.Location = New System.Drawing.Point(259, 180)
        Me.Label322.Name = "Label322"
        Me.Label322.Size = New System.Drawing.Size(15, 16)
        Me.Label322.TabIndex = 99
        Me.Label322.Text = "4"
        '
        'Label293
        '
        Me.Label293.AutoSize = True
        Me.Label293.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label293.Location = New System.Drawing.Point(276, 52)
        Me.Label293.Name = "Label293"
        Me.Label293.Size = New System.Drawing.Size(68, 32)
        Me.Label293.TabIndex = 103
        Me.Label293.Text = "Calib" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value P0 :"
        '
        'Label319
        '
        Me.Label319.AutoSize = True
        Me.Label319.Enabled = False
        Me.Label319.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label319.Location = New System.Drawing.Point(259, 152)
        Me.Label319.Name = "Label319"
        Me.Label319.Size = New System.Drawing.Size(15, 16)
        Me.Label319.TabIndex = 98
        Me.Label319.Text = "3"
        '
        'Label318
        '
        Me.Label318.AutoSize = True
        Me.Label318.Enabled = False
        Me.Label318.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label318.Location = New System.Drawing.Point(259, 124)
        Me.Label318.Name = "Label318"
        Me.Label318.Size = New System.Drawing.Size(15, 16)
        Me.Label318.TabIndex = 101
        Me.Label318.Text = "2"
        '
        'Label317
        '
        Me.Label317.AutoSize = True
        Me.Label317.Enabled = False
        Me.Label317.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label317.Location = New System.Drawing.Point(259, 96)
        Me.Label317.Name = "Label317"
        Me.Label317.Size = New System.Drawing.Size(15, 16)
        Me.Label317.TabIndex = 97
        Me.Label317.Text = "1"
        '
        'txt_offset_gt
        '
        Me.txt_offset_gt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_offset_gt.Location = New System.Drawing.Point(371, 335)
        Me.txt_offset_gt.Name = "txt_offset_gt"
        Me.txt_offset_gt.Size = New System.Drawing.Size(124, 22)
        Me.txt_offset_gt.TabIndex = 96
        Me.txt_offset_gt.Text = "0"
        '
        'txt_st4_analog_data
        '
        Me.txt_st4_analog_data.Enabled = False
        Me.txt_st4_analog_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_analog_data.Location = New System.Drawing.Point(371, 298)
        Me.txt_st4_analog_data.Name = "txt_st4_analog_data"
        Me.txt_st4_analog_data.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_analog_data.TabIndex = 96
        '
        'txt_st4_diff_str
        '
        Me.txt_st4_diff_str.Enabled = False
        Me.txt_st4_diff_str.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_diff_str.Location = New System.Drawing.Point(367, 451)
        Me.txt_st4_diff_str.Name = "txt_st4_diff_str"
        Me.txt_st4_diff_str.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_diff_str.TabIndex = 96
        '
        'txt_st4_act_vel
        '
        Me.txt_st4_act_vel.Enabled = False
        Me.txt_st4_act_vel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_act_vel.Location = New System.Drawing.Point(651, 199)
        Me.txt_st4_act_vel.Name = "txt_st4_act_vel"
        Me.txt_st4_act_vel.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_act_vel.TabIndex = 96
        '
        'txt_st4_actu_pos
        '
        Me.txt_st4_actu_pos.Enabled = False
        Me.txt_st4_actu_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_actu_pos.Location = New System.Drawing.Point(367, 423)
        Me.txt_st4_actu_pos.Name = "txt_st4_actu_pos"
        Me.txt_st4_actu_pos.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_actu_pos.TabIndex = 95
        '
        'txt_st4_act_pos
        '
        Me.txt_st4_act_pos.Enabled = False
        Me.txt_st4_act_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_act_pos.Location = New System.Drawing.Point(651, 164)
        Me.txt_st4_act_pos.Name = "txt_st4_act_pos"
        Me.txt_st4_act_pos.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_act_pos.TabIndex = 95
        '
        'txt_st4_set_vel
        '
        Me.txt_st4_set_vel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_set_vel.Location = New System.Drawing.Point(651, 267)
        Me.txt_st4_set_vel.Name = "txt_st4_set_vel"
        Me.txt_st4_set_vel.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_set_vel.TabIndex = 94
        '
        'txt_st4_set_pos
        '
        Me.txt_st4_set_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st4_set_pos.Location = New System.Drawing.Point(651, 234)
        Me.txt_st4_set_pos.Name = "txt_st4_set_pos"
        Me.txt_st4_set_pos.Size = New System.Drawing.Size(124, 22)
        Me.txt_st4_set_pos.TabIndex = 93
        '
        'btn_st4_servo_stop
        '
        Me.btn_st4_servo_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_servo_stop.Location = New System.Drawing.Point(677, 54)
        Me.btn_st4_servo_stop.Name = "btn_st4_servo_stop"
        Me.btn_st4_servo_stop.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_servo_stop.TabIndex = 92
        Me.btn_st4_servo_stop.Text = "Servo Stop"
        Me.btn_st4_servo_stop.UseVisualStyleBackColor = True
        '
        'btn_st4_servo_reset
        '
        Me.btn_st4_servo_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_servo_reset.Location = New System.Drawing.Point(575, 107)
        Me.btn_st4_servo_reset.Name = "btn_st4_servo_reset"
        Me.btn_st4_servo_reset.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_servo_reset.TabIndex = 91
        Me.btn_st4_servo_reset.Text = "Servo Reset"
        Me.btn_st4_servo_reset.UseVisualStyleBackColor = True
        '
        'btn_st4_jog_ccw
        '
        Me.btn_st4_jog_ccw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_jog_ccw.Location = New System.Drawing.Point(677, 355)
        Me.btn_st4_jog_ccw.Name = "btn_st4_jog_ccw"
        Me.btn_st4_jog_ccw.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_jog_ccw.TabIndex = 90
        Me.btn_st4_jog_ccw.Text = "JOG CCW"
        Me.btn_st4_jog_ccw.UseVisualStyleBackColor = True
        '
        'btn_st4_auto_calibration
        '
        Me.btn_st4_auto_calibration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_auto_calibration.Location = New System.Drawing.Point(403, 370)
        Me.btn_st4_auto_calibration.Name = "btn_st4_auto_calibration"
        Me.btn_st4_auto_calibration.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_auto_calibration.TabIndex = 89
        Me.btn_st4_auto_calibration.Text = "Auto Calibration"
        Me.btn_st4_auto_calibration.UseVisualStyleBackColor = True
        '
        'btn_st4_man_trig
        '
        Me.btn_st4_man_trig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_man_trig.Location = New System.Drawing.Point(292, 370)
        Me.btn_st4_man_trig.Name = "btn_st4_man_trig"
        Me.btn_st4_man_trig.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_man_trig.TabIndex = 89
        Me.btn_st4_man_trig.Text = "Manual Testing Trigger"
        Me.btn_st4_man_trig.UseVisualStyleBackColor = True
        '
        'btn_st4_cal
        '
        Me.btn_st4_cal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_cal.Location = New System.Drawing.Point(677, 402)
        Me.btn_st4_cal.Name = "btn_st4_cal"
        Me.btn_st4_cal.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_cal.TabIndex = 89
        Me.btn_st4_cal.Text = "Calibrate Data"
        Me.btn_st4_cal.UseVisualStyleBackColor = True
        '
        'btn_st4_jog_cw
        '
        Me.btn_st4_jog_cw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_jog_cw.Location = New System.Drawing.Point(576, 355)
        Me.btn_st4_jog_cw.Name = "btn_st4_jog_cw"
        Me.btn_st4_jog_cw.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_jog_cw.TabIndex = 89
        Me.btn_st4_jog_cw.Text = "JOG CW"
        Me.btn_st4_jog_cw.UseVisualStyleBackColor = True
        '
        'btn_st4_move_vel
        '
        Me.btn_st4_move_vel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_move_vel.Location = New System.Drawing.Point(677, 306)
        Me.btn_st4_move_vel.Name = "btn_st4_move_vel"
        Me.btn_st4_move_vel.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_move_vel.TabIndex = 88
        Me.btn_st4_move_vel.Text = "Move " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VELOCITY"
        Me.btn_st4_move_vel.UseVisualStyleBackColor = True
        '
        'btn_st4_move_pos
        '
        Me.btn_st4_move_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_move_pos.Location = New System.Drawing.Point(576, 306)
        Me.btn_st4_move_pos.Name = "btn_st4_move_pos"
        Me.btn_st4_move_pos.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_move_pos.TabIndex = 87
        Me.btn_st4_move_pos.Text = "Move POS"
        Me.btn_st4_move_pos.UseVisualStyleBackColor = True
        '
        'btn_st4_save_data
        '
        Me.btn_st4_save_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_save_data.Location = New System.Drawing.Point(576, 402)
        Me.btn_st4_save_data.Name = "btn_st4_save_data"
        Me.btn_st4_save_data.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_save_data.TabIndex = 86
        Me.btn_st4_save_data.Text = "Save Data"
        Me.btn_st4_save_data.UseVisualStyleBackColor = True
        Me.btn_st4_save_data.Visible = False
        '
        'btn_st4_homing
        '
        Me.btn_st4_homing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_homing.Location = New System.Drawing.Point(677, 107)
        Me.btn_st4_homing.Name = "btn_st4_homing"
        Me.btn_st4_homing.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_homing.TabIndex = 85
        Me.btn_st4_homing.Text = "Homing"
        Me.btn_st4_homing.UseVisualStyleBackColor = True
        '
        'btn_st4_servo_enable
        '
        Me.btn_st4_servo_enable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4_servo_enable.Location = New System.Drawing.Point(575, 55)
        Me.btn_st4_servo_enable.Name = "btn_st4_servo_enable"
        Me.btn_st4_servo_enable.Size = New System.Drawing.Size(100, 40)
        Me.btn_st4_servo_enable.TabIndex = 84
        Me.btn_st4_servo_enable.Text = "Servo Enable"
        Me.btn_st4_servo_enable.UseVisualStyleBackColor = True
        '
        'Label290
        '
        Me.Label290.AutoSize = True
        Me.Label290.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label290.Location = New System.Drawing.Point(96, 443)
        Me.Label290.Name = "Label290"
        Me.Label290.Size = New System.Drawing.Size(101, 16)
        Me.Label290.TabIndex = 82
        Me.Label290.Text = "Discrete Motion"
        '
        'Label234
        '
        Me.Label234.AutoSize = True
        Me.Label234.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label234.Location = New System.Drawing.Point(96, 391)
        Me.Label234.Name = "Label234"
        Me.Label234.Size = New System.Drawing.Size(117, 16)
        Me.Label234.TabIndex = 82
        Me.Label234.Text = "Continuous Motion"
        '
        'Label235
        '
        Me.Label235.AutoSize = True
        Me.Label235.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label235.Location = New System.Drawing.Point(95, 225)
        Me.Label235.Name = "Label235"
        Me.Label235.Size = New System.Drawing.Size(77, 16)
        Me.Label235.TabIndex = 83
        Me.Label235.Text = "Servo Busy"
        '
        'Label259
        '
        Me.Label259.AutoSize = True
        Me.Label259.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label259.Location = New System.Drawing.Point(95, 281)
        Me.Label259.Name = "Label259"
        Me.Label259.Size = New System.Drawing.Size(62, 16)
        Me.Label259.TabIndex = 81
        Me.Label259.Text = "Standstill"
        '
        'Label260
        '
        Me.Label260.AutoSize = True
        Me.Label260.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label260.Location = New System.Drawing.Point(94, 113)
        Me.Label260.Name = "Label260"
        Me.Label260.Size = New System.Drawing.Size(76, 16)
        Me.Label260.TabIndex = 80
        Me.Label260.Text = "Servo Error"
        '
        'Label261
        '
        Me.Label261.AutoSize = True
        Me.Label261.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label261.Location = New System.Drawing.Point(96, 336)
        Me.Label261.Name = "Label261"
        Me.Label261.Size = New System.Drawing.Size(62, 16)
        Me.Label261.TabIndex = 79
        Me.Label261.Text = "Stopping"
        '
        'Label291
        '
        Me.Label291.AutoSize = True
        Me.Label291.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label291.Location = New System.Drawing.Point(291, 272)
        Me.Label291.Name = "Label291"
        Me.Label291.Size = New System.Drawing.Size(207, 16)
        Me.Label291.TabIndex = 78
        Me.Label291.Text = "Keyence GT2 Sensor Monitoring :"
        '
        'Label331
        '
        Me.Label331.AutoSize = True
        Me.Label331.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label331.Location = New System.Drawing.Point(292, 328)
        Me.Label331.Name = "Label331"
        Me.Label331.Size = New System.Drawing.Size(49, 32)
        Me.Label331.TabIndex = 78
        Me.Label331.Text = "Offset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value :"
        '
        'Label292
        '
        Me.Label292.AutoSize = True
        Me.Label292.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label292.Location = New System.Drawing.Point(292, 293)
        Me.Label292.Name = "Label292"
        Me.Label292.Size = New System.Drawing.Size(51, 32)
        Me.Label292.TabIndex = 78
        Me.Label292.Text = "Analog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data :"
        '
        'label_297
        '
        Me.label_297.AutoSize = True
        Me.label_297.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_297.Location = New System.Drawing.Point(288, 459)
        Me.label_297.Name = "label_297"
        Me.label_297.Size = New System.Drawing.Size(52, 16)
        Me.label_297.TabIndex = 78
        Me.label_297.Text = "Diff Str :"
        '
        'Label262
        '
        Me.Label262.AutoSize = True
        Me.Label262.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label262.Location = New System.Drawing.Point(572, 191)
        Me.Label262.Name = "Label262"
        Me.Label262.Size = New System.Drawing.Size(62, 32)
        Me.Label262.TabIndex = 78
        Me.Label262.Text = "Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Velocity :"
        '
        'Label295
        '
        Me.Label295.AutoSize = True
        Me.Label295.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label295.Location = New System.Drawing.Point(288, 418)
        Me.Label295.Name = "Label295"
        Me.Label295.Size = New System.Drawing.Size(63, 32)
        Me.Label295.TabIndex = 77
        Me.Label295.Text = "Actuation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pos :"
        '
        'Label263
        '
        Me.Label263.AutoSize = True
        Me.Label263.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label263.Location = New System.Drawing.Point(572, 159)
        Me.Label263.Name = "Label263"
        Me.Label263.Size = New System.Drawing.Size(62, 32)
        Me.Label263.TabIndex = 77
        Me.Label263.Text = "Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Position :"
        '
        'Label264
        '
        Me.Label264.AutoSize = True
        Me.Label264.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label264.Location = New System.Drawing.Point(573, 259)
        Me.Label264.Name = "Label264"
        Me.Label264.Size = New System.Drawing.Size(62, 32)
        Me.Label264.TabIndex = 76
        Me.Label264.Text = "Set " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Velocity :"
        '
        'Label265
        '
        Me.Label265.AutoSize = True
        Me.Label265.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label265.Location = New System.Drawing.Point(573, 225)
        Me.Label265.Name = "Label265"
        Me.Label265.Size = New System.Drawing.Size(62, 32)
        Me.Label265.TabIndex = 75
        Me.Label265.Text = "Set " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Position :"
        '
        'Label266
        '
        Me.Label266.AutoSize = True
        Me.Label266.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label266.Location = New System.Drawing.Point(95, 169)
        Me.Label266.Name = "Label266"
        Me.Label266.Size = New System.Drawing.Size(78, 16)
        Me.Label266.TabIndex = 74
        Me.Label266.Text = "Home Busy"
        '
        'Label267
        '
        Me.Label267.AutoSize = True
        Me.Label267.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label267.Location = New System.Drawing.Point(94, 57)
        Me.Label267.Name = "Label267"
        Me.Label267.Size = New System.Drawing.Size(98, 16)
        Me.Label267.TabIndex = 73
        Me.Label267.Text = "Servo Enabled"
        '
        'ind_st4_discrete_motion
        '
        Me.ind_st4_discrete_motion.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_discrete_motion.Location = New System.Drawing.Point(58, 438)
        Me.ind_st4_discrete_motion.Name = "ind_st4_discrete_motion"
        Me.ind_st4_discrete_motion.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_discrete_motion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_discrete_motion.TabIndex = 71
        Me.ind_st4_discrete_motion.TabStop = False
        '
        'ind_st4_continuous_motion
        '
        Me.ind_st4_continuous_motion.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_continuous_motion.Location = New System.Drawing.Point(58, 386)
        Me.ind_st4_continuous_motion.Name = "ind_st4_continuous_motion"
        Me.ind_st4_continuous_motion.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_continuous_motion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_continuous_motion.TabIndex = 71
        Me.ind_st4_continuous_motion.TabStop = False
        '
        'ind_st4_servo_busy
        '
        Me.ind_st4_servo_busy.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_servo_busy.Location = New System.Drawing.Point(57, 220)
        Me.ind_st4_servo_busy.Name = "ind_st4_servo_busy"
        Me.ind_st4_servo_busy.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_servo_busy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_servo_busy.TabIndex = 70
        Me.ind_st4_servo_busy.TabStop = False
        '
        'ind_st4_standstill
        '
        Me.ind_st4_standstill.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_standstill.Location = New System.Drawing.Point(57, 276)
        Me.ind_st4_standstill.Name = "ind_st4_standstill"
        Me.ind_st4_standstill.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_standstill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_standstill.TabIndex = 69
        Me.ind_st4_standstill.TabStop = False
        '
        'ind_st4_stopping
        '
        Me.ind_st4_stopping.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_stopping.Location = New System.Drawing.Point(58, 331)
        Me.ind_st4_stopping.Name = "ind_st4_stopping"
        Me.ind_st4_stopping.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_stopping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_stopping.TabIndex = 68
        Me.ind_st4_stopping.TabStop = False
        '
        'ind_st4_servo_error
        '
        Me.ind_st4_servo_error.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_servo_error.Location = New System.Drawing.Point(56, 108)
        Me.ind_st4_servo_error.Name = "ind_st4_servo_error"
        Me.ind_st4_servo_error.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_servo_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_servo_error.TabIndex = 67
        Me.ind_st4_servo_error.TabStop = False
        '
        'ind_st4_home_busy
        '
        Me.ind_st4_home_busy.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_home_busy.Location = New System.Drawing.Point(57, 164)
        Me.ind_st4_home_busy.Name = "ind_st4_home_busy"
        Me.ind_st4_home_busy.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_home_busy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_home_busy.TabIndex = 72
        Me.ind_st4_home_busy.TabStop = False
        '
        'ind_st4_servo_enabled
        '
        Me.ind_st4_servo_enabled.BackColor = System.Drawing.Color.Transparent
        Me.ind_st4_servo_enabled.Location = New System.Drawing.Point(56, 52)
        Me.ind_st4_servo_enabled.Name = "ind_st4_servo_enabled"
        Me.ind_st4_servo_enabled.Size = New System.Drawing.Size(30, 30)
        Me.ind_st4_servo_enabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st4_servo_enabled.TabIndex = 66
        Me.ind_st4_servo_enabled.TabStop = False
        '
        'pnl_man_stn3
        '
        Me.pnl_man_stn3.Controls.Add(Me.TabPage7)
        Me.pnl_man_stn3.Controls.Add(Me.TabPage25)
        Me.pnl_man_stn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn3.Location = New System.Drawing.Point(78, 87)
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
        Me.TabPage7.Text = "Manual Station 3"
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
        'TabPage25
        '
        Me.TabPage25.Controls.Add(Me.txt_st3_act_vel)
        Me.TabPage25.Controls.Add(Me.txt_st3_act_pos)
        Me.TabPage25.Controls.Add(Me.txt_st3_set_vel)
        Me.TabPage25.Controls.Add(Me.txt_st3_set_pos)
        Me.TabPage25.Controls.Add(Me.btn_st3_servo_stop)
        Me.TabPage25.Controls.Add(Me.btn_st3_servo_reset)
        Me.TabPage25.Controls.Add(Me.btn_st3_jog_ccw)
        Me.TabPage25.Controls.Add(Me.btn_st3_jog_cw)
        Me.TabPage25.Controls.Add(Me.btn_st3_move_vel)
        Me.TabPage25.Controls.Add(Me.btn_st3_move_pos)
        Me.TabPage25.Controls.Add(Me.btn_st3_save_data)
        Me.TabPage25.Controls.Add(Me.btn_st3_homing)
        Me.TabPage25.Controls.Add(Me.btn_st3_servo_enable)
        Me.TabPage25.Controls.Add(Me.Label296)
        Me.TabPage25.Controls.Add(Me.Label268)
        Me.TabPage25.Controls.Add(Me.Label269)
        Me.TabPage25.Controls.Add(Me.Label270)
        Me.TabPage25.Controls.Add(Me.Label271)
        Me.TabPage25.Controls.Add(Me.Label272)
        Me.TabPage25.Controls.Add(Me.Label273)
        Me.TabPage25.Controls.Add(Me.Label274)
        Me.TabPage25.Controls.Add(Me.Label275)
        Me.TabPage25.Controls.Add(Me.Label276)
        Me.TabPage25.Controls.Add(Me.Label277)
        Me.TabPage25.Controls.Add(Me.Label278)
        Me.TabPage25.Controls.Add(Me.ind_st3_discrete_motion)
        Me.TabPage25.Controls.Add(Me.ind_st3_continuous_motion)
        Me.TabPage25.Controls.Add(Me.ind_st3_servo_busy)
        Me.TabPage25.Controls.Add(Me.ind_st3_standstill)
        Me.TabPage25.Controls.Add(Me.ind_st3_stopping)
        Me.TabPage25.Controls.Add(Me.ind_st3_servo_error)
        Me.TabPage25.Controls.Add(Me.ind_st3_home_busy)
        Me.TabPage25.Controls.Add(Me.ind_st3_servo_enabled)
        Me.TabPage25.Location = New System.Drawing.Point(4, 38)
        Me.TabPage25.Name = "TabPage25"
        Me.TabPage25.Size = New System.Drawing.Size(845, 521)
        Me.TabPage25.TabIndex = 1
        Me.TabPage25.Text = "Servo ST3"
        Me.TabPage25.UseVisualStyleBackColor = True
        '
        'txt_st3_act_vel
        '
        Me.txt_st3_act_vel.Enabled = False
        Me.txt_st3_act_vel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st3_act_vel.Location = New System.Drawing.Point(604, 238)
        Me.txt_st3_act_vel.Name = "txt_st3_act_vel"
        Me.txt_st3_act_vel.Size = New System.Drawing.Size(107, 35)
        Me.txt_st3_act_vel.TabIndex = 96
        '
        'txt_st3_act_pos
        '
        Me.txt_st3_act_pos.Enabled = False
        Me.txt_st3_act_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st3_act_pos.Location = New System.Drawing.Point(604, 189)
        Me.txt_st3_act_pos.Name = "txt_st3_act_pos"
        Me.txt_st3_act_pos.Size = New System.Drawing.Size(107, 35)
        Me.txt_st3_act_pos.TabIndex = 95
        '
        'txt_st3_set_vel
        '
        Me.txt_st3_set_vel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st3_set_vel.Location = New System.Drawing.Point(398, 238)
        Me.txt_st3_set_vel.Name = "txt_st3_set_vel"
        Me.txt_st3_set_vel.Size = New System.Drawing.Size(107, 35)
        Me.txt_st3_set_vel.TabIndex = 94
        '
        'txt_st3_set_pos
        '
        Me.txt_st3_set_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st3_set_pos.Location = New System.Drawing.Point(398, 189)
        Me.txt_st3_set_pos.Name = "txt_st3_set_pos"
        Me.txt_st3_set_pos.Size = New System.Drawing.Size(107, 35)
        Me.txt_st3_set_pos.TabIndex = 93
        '
        'btn_st3_servo_stop
        '
        Me.btn_st3_servo_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_servo_stop.Location = New System.Drawing.Point(604, 50)
        Me.btn_st3_servo_stop.Name = "btn_st3_servo_stop"
        Me.btn_st3_servo_stop.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_servo_stop.TabIndex = 92
        Me.btn_st3_servo_stop.Text = "Servo Stop"
        Me.btn_st3_servo_stop.UseVisualStyleBackColor = True
        '
        'btn_st3_servo_reset
        '
        Me.btn_st3_servo_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_servo_reset.Location = New System.Drawing.Point(462, 50)
        Me.btn_st3_servo_reset.Name = "btn_st3_servo_reset"
        Me.btn_st3_servo_reset.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_servo_reset.TabIndex = 91
        Me.btn_st3_servo_reset.Text = "Servo Reset"
        Me.btn_st3_servo_reset.UseVisualStyleBackColor = True
        '
        'btn_st3_jog_ccw
        '
        Me.btn_st3_jog_ccw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_jog_ccw.Location = New System.Drawing.Point(462, 420)
        Me.btn_st3_jog_ccw.Name = "btn_st3_jog_ccw"
        Me.btn_st3_jog_ccw.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_jog_ccw.TabIndex = 90
        Me.btn_st3_jog_ccw.Text = "JOG CCW"
        Me.btn_st3_jog_ccw.UseVisualStyleBackColor = True
        '
        'btn_st3_jog_cw
        '
        Me.btn_st3_jog_cw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_jog_cw.Location = New System.Drawing.Point(319, 420)
        Me.btn_st3_jog_cw.Name = "btn_st3_jog_cw"
        Me.btn_st3_jog_cw.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_jog_cw.TabIndex = 89
        Me.btn_st3_jog_cw.Text = "JOG CW"
        Me.btn_st3_jog_cw.UseVisualStyleBackColor = True
        '
        'btn_st3_move_vel
        '
        Me.btn_st3_move_vel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_move_vel.Location = New System.Drawing.Point(462, 352)
        Me.btn_st3_move_vel.Name = "btn_st3_move_vel"
        Me.btn_st3_move_vel.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_move_vel.TabIndex = 88
        Me.btn_st3_move_vel.Text = "Move " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VELOCITY"
        Me.btn_st3_move_vel.UseVisualStyleBackColor = True
        '
        'btn_st3_move_pos
        '
        Me.btn_st3_move_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_move_pos.Location = New System.Drawing.Point(319, 352)
        Me.btn_st3_move_pos.Name = "btn_st3_move_pos"
        Me.btn_st3_move_pos.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_move_pos.TabIndex = 87
        Me.btn_st3_move_pos.Text = "Move POS"
        Me.btn_st3_move_pos.UseVisualStyleBackColor = True
        '
        'btn_st3_save_data
        '
        Me.btn_st3_save_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_save_data.Location = New System.Drawing.Point(319, 286)
        Me.btn_st3_save_data.Name = "btn_st3_save_data"
        Me.btn_st3_save_data.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_save_data.TabIndex = 86
        Me.btn_st3_save_data.Text = "Save Data"
        Me.btn_st3_save_data.UseVisualStyleBackColor = True
        '
        'btn_st3_homing
        '
        Me.btn_st3_homing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_homing.Location = New System.Drawing.Point(319, 115)
        Me.btn_st3_homing.Name = "btn_st3_homing"
        Me.btn_st3_homing.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_homing.TabIndex = 85
        Me.btn_st3_homing.Text = "Homing"
        Me.btn_st3_homing.UseVisualStyleBackColor = True
        '
        'btn_st3_servo_enable
        '
        Me.btn_st3_servo_enable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3_servo_enable.Location = New System.Drawing.Point(319, 50)
        Me.btn_st3_servo_enable.Name = "btn_st3_servo_enable"
        Me.btn_st3_servo_enable.Size = New System.Drawing.Size(128, 50)
        Me.btn_st3_servo_enable.TabIndex = 84
        Me.btn_st3_servo_enable.Text = "Servo Enable"
        Me.btn_st3_servo_enable.UseVisualStyleBackColor = True
        '
        'Label296
        '
        Me.Label296.AutoSize = True
        Me.Label296.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label296.Location = New System.Drawing.Point(153, 448)
        Me.Label296.Name = "Label296"
        Me.Label296.Size = New System.Drawing.Size(120, 20)
        Me.Label296.TabIndex = 82
        Me.Label296.Text = "Discrete Motion"
        '
        'Label268
        '
        Me.Label268.AutoSize = True
        Me.Label268.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label268.Location = New System.Drawing.Point(153, 395)
        Me.Label268.Name = "Label268"
        Me.Label268.Size = New System.Drawing.Size(142, 20)
        Me.Label268.TabIndex = 82
        Me.Label268.Text = "Continuous Motion"
        '
        'Label269
        '
        Me.Label269.AutoSize = True
        Me.Label269.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label269.Location = New System.Drawing.Point(152, 229)
        Me.Label269.Name = "Label269"
        Me.Label269.Size = New System.Drawing.Size(89, 20)
        Me.Label269.TabIndex = 83
        Me.Label269.Text = "Servo Busy"
        '
        'Label270
        '
        Me.Label270.AutoSize = True
        Me.Label270.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label270.Location = New System.Drawing.Point(152, 285)
        Me.Label270.Name = "Label270"
        Me.Label270.Size = New System.Drawing.Size(74, 20)
        Me.Label270.TabIndex = 81
        Me.Label270.Text = "Standstill"
        '
        'Label271
        '
        Me.Label271.AutoSize = True
        Me.Label271.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label271.Location = New System.Drawing.Point(151, 117)
        Me.Label271.Name = "Label271"
        Me.Label271.Size = New System.Drawing.Size(89, 20)
        Me.Label271.TabIndex = 80
        Me.Label271.Text = "Servo Error"
        '
        'Label272
        '
        Me.Label272.AutoSize = True
        Me.Label272.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label272.Location = New System.Drawing.Point(153, 340)
        Me.Label272.Name = "Label272"
        Me.Label272.Size = New System.Drawing.Size(73, 20)
        Me.Label272.TabIndex = 79
        Me.Label272.Text = "Stopping"
        '
        'Label273
        '
        Me.Label273.AutoSize = True
        Me.Label273.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label273.Location = New System.Drawing.Point(525, 233)
        Me.Label273.Name = "Label273"
        Me.Label273.Size = New System.Drawing.Size(72, 40)
        Me.Label273.TabIndex = 78
        Me.Label273.Text = "Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Velocity :"
        '
        'Label274
        '
        Me.Label274.AutoSize = True
        Me.Label274.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label274.Location = New System.Drawing.Point(525, 184)
        Me.Label274.Name = "Label274"
        Me.Label274.Size = New System.Drawing.Size(73, 40)
        Me.Label274.TabIndex = 77
        Me.Label274.Text = "Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Position :"
        '
        'Label275
        '
        Me.Label275.AutoSize = True
        Me.Label275.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label275.Location = New System.Drawing.Point(319, 233)
        Me.Label275.Name = "Label275"
        Me.Label275.Size = New System.Drawing.Size(72, 40)
        Me.Label275.TabIndex = 76
        Me.Label275.Text = "Set " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Velocity :"
        '
        'Label276
        '
        Me.Label276.AutoSize = True
        Me.Label276.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label276.Location = New System.Drawing.Point(319, 184)
        Me.Label276.Name = "Label276"
        Me.Label276.Size = New System.Drawing.Size(73, 40)
        Me.Label276.TabIndex = 75
        Me.Label276.Text = "Set " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Position :"
        '
        'Label277
        '
        Me.Label277.AutoSize = True
        Me.Label277.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label277.Location = New System.Drawing.Point(152, 173)
        Me.Label277.Name = "Label277"
        Me.Label277.Size = New System.Drawing.Size(91, 20)
        Me.Label277.TabIndex = 74
        Me.Label277.Text = "Home Busy"
        '
        'Label278
        '
        Me.Label278.AutoSize = True
        Me.Label278.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label278.Location = New System.Drawing.Point(151, 61)
        Me.Label278.Name = "Label278"
        Me.Label278.Size = New System.Drawing.Size(113, 20)
        Me.Label278.TabIndex = 73
        Me.Label278.Text = "Servo Enabled"
        '
        'ind_st3_discrete_motion
        '
        Me.ind_st3_discrete_motion.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_discrete_motion.Location = New System.Drawing.Point(115, 443)
        Me.ind_st3_discrete_motion.Name = "ind_st3_discrete_motion"
        Me.ind_st3_discrete_motion.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_discrete_motion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_discrete_motion.TabIndex = 71
        Me.ind_st3_discrete_motion.TabStop = False
        '
        'ind_st3_continuous_motion
        '
        Me.ind_st3_continuous_motion.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_continuous_motion.Location = New System.Drawing.Point(115, 390)
        Me.ind_st3_continuous_motion.Name = "ind_st3_continuous_motion"
        Me.ind_st3_continuous_motion.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_continuous_motion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_continuous_motion.TabIndex = 71
        Me.ind_st3_continuous_motion.TabStop = False
        '
        'ind_st3_servo_busy
        '
        Me.ind_st3_servo_busy.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_servo_busy.Location = New System.Drawing.Point(114, 224)
        Me.ind_st3_servo_busy.Name = "ind_st3_servo_busy"
        Me.ind_st3_servo_busy.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_servo_busy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_servo_busy.TabIndex = 70
        Me.ind_st3_servo_busy.TabStop = False
        '
        'ind_st3_standstill
        '
        Me.ind_st3_standstill.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_standstill.Location = New System.Drawing.Point(114, 280)
        Me.ind_st3_standstill.Name = "ind_st3_standstill"
        Me.ind_st3_standstill.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_standstill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_standstill.TabIndex = 69
        Me.ind_st3_standstill.TabStop = False
        '
        'ind_st3_stopping
        '
        Me.ind_st3_stopping.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_stopping.Location = New System.Drawing.Point(115, 335)
        Me.ind_st3_stopping.Name = "ind_st3_stopping"
        Me.ind_st3_stopping.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_stopping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_stopping.TabIndex = 68
        Me.ind_st3_stopping.TabStop = False
        '
        'ind_st3_servo_error
        '
        Me.ind_st3_servo_error.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_servo_error.Location = New System.Drawing.Point(113, 112)
        Me.ind_st3_servo_error.Name = "ind_st3_servo_error"
        Me.ind_st3_servo_error.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_servo_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_servo_error.TabIndex = 67
        Me.ind_st3_servo_error.TabStop = False
        '
        'ind_st3_home_busy
        '
        Me.ind_st3_home_busy.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_home_busy.Location = New System.Drawing.Point(114, 168)
        Me.ind_st3_home_busy.Name = "ind_st3_home_busy"
        Me.ind_st3_home_busy.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_home_busy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_home_busy.TabIndex = 72
        Me.ind_st3_home_busy.TabStop = False
        '
        'ind_st3_servo_enabled
        '
        Me.ind_st3_servo_enabled.BackColor = System.Drawing.Color.Transparent
        Me.ind_st3_servo_enabled.Location = New System.Drawing.Point(113, 56)
        Me.ind_st3_servo_enabled.Name = "ind_st3_servo_enabled"
        Me.ind_st3_servo_enabled.Size = New System.Drawing.Size(30, 30)
        Me.ind_st3_servo_enabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st3_servo_enabled.TabIndex = 66
        Me.ind_st3_servo_enabled.TabStop = False
        '
        'pnl_man_stn1
        '
        Me.pnl_man_stn1.Controls.Add(Me.TabPage9)
        Me.pnl_man_stn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn1.Location = New System.Drawing.Point(78, 87)
        Me.pnl_man_stn1.Name = "pnl_man_stn1"
        Me.pnl_man_stn1.SelectedIndex = 0
        Me.pnl_man_stn1.Size = New System.Drawing.Size(853, 563)
        Me.pnl_man_stn1.TabIndex = 101
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.GroupBox183)
        Me.TabPage9.Controls.Add(Me.Label301)
        Me.TabPage9.Controls.Add(Me.Label283)
        Me.TabPage9.Controls.Add(Me.Label288)
        Me.TabPage9.Controls.Add(Me.Label280)
        Me.TabPage9.Controls.Add(Me.Label285)
        Me.TabPage9.Controls.Add(Me.Label1)
        Me.TabPage9.Controls.Add(Me.Label284)
        Me.TabPage9.Controls.Add(Me.Label281)
        Me.TabPage9.Controls.Add(Me.ind_safety_st6)
        Me.TabPage9.Controls.Add(Me.ind_safety_st2)
        Me.TabPage9.Controls.Add(Me.ind_safety_st4)
        Me.TabPage9.Controls.Add(Me.ind_cycle_status)
        Me.TabPage9.Controls.Add(Me.ind_safety_st5)
        Me.TabPage9.Controls.Add(Me.ind_safety_st1)
        Me.TabPage9.Controls.Add(Me.ind_safety_st3)
        Me.TabPage9.Controls.Add(Me.ind_altivar_status)
        Me.TabPage9.Controls.Add(Me.GroupBox10)
        Me.TabPage9.Controls.Add(Me.GroupBox4)
        Me.TabPage9.Controls.Add(Me.GroupBox7)
        Me.TabPage9.Controls.Add(Me.GroupBox3)
        Me.TabPage9.Location = New System.Drawing.Point(4, 38)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(845, 521)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Manual Station 1"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'GroupBox183
        '
        Me.GroupBox183.Controls.Add(Me.btn_trig_turn_table)
        Me.GroupBox183.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox183.Location = New System.Drawing.Point(302, 41)
        Me.GroupBox183.Name = "GroupBox183"
        Me.GroupBox183.Size = New System.Drawing.Size(169, 100)
        Me.GroupBox183.TabIndex = 108
        Me.GroupBox183.TabStop = False
        Me.GroupBox183.Text = "Turn Table"
        '
        'btn_trig_turn_table
        '
        Me.btn_trig_turn_table.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_trig_turn_table.Location = New System.Drawing.Point(22, 39)
        Me.btn_trig_turn_table.Name = "btn_trig_turn_table"
        Me.btn_trig_turn_table.Size = New System.Drawing.Size(128, 50)
        Me.btn_trig_turn_table.TabIndex = 107
        Me.btn_trig_turn_table.Text = "Trigger Turn " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Table"
        Me.btn_trig_turn_table.UseVisualStyleBackColor = True
        '
        'Label301
        '
        Me.Label301.AutoSize = True
        Me.Label301.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label301.Location = New System.Drawing.Point(169, 443)
        Me.Label301.Name = "Label301"
        Me.Label301.Size = New System.Drawing.Size(123, 20)
        Me.Label301.TabIndex = 106
        Me.Label301.Text = "Safety Station 6"
        '
        'Label283
        '
        Me.Label283.AutoSize = True
        Me.Label283.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label283.Location = New System.Drawing.Point(168, 218)
        Me.Label283.Name = "Label283"
        Me.Label283.Size = New System.Drawing.Size(123, 20)
        Me.Label283.TabIndex = 105
        Me.Label283.Text = "Safety Station 2"
        '
        'Label288
        '
        Me.Label288.AutoSize = True
        Me.Label288.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label288.Location = New System.Drawing.Point(169, 331)
        Me.Label288.Name = "Label288"
        Me.Label288.Size = New System.Drawing.Size(123, 20)
        Me.Label288.TabIndex = 104
        Me.Label288.Text = "Safety Station 4"
        '
        'Label280
        '
        Me.Label280.AutoSize = True
        Me.Label280.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label280.Location = New System.Drawing.Point(168, 106)
        Me.Label280.Name = "Label280"
        Me.Label280.Size = New System.Drawing.Size(98, 20)
        Me.Label280.TabIndex = 103
        Me.Label280.Text = "Cycle Status"
        '
        'Label285
        '
        Me.Label285.AutoSize = True
        Me.Label285.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label285.Location = New System.Drawing.Point(169, 387)
        Me.Label285.Name = "Label285"
        Me.Label285.Size = New System.Drawing.Size(123, 20)
        Me.Label285.TabIndex = 101
        Me.Label285.Text = "Safety Station 5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Safety Station 1"
        '
        'Label284
        '
        Me.Label284.AutoSize = True
        Me.Label284.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label284.Location = New System.Drawing.Point(169, 275)
        Me.Label284.Name = "Label284"
        Me.Label284.Size = New System.Drawing.Size(123, 20)
        Me.Label284.TabIndex = 102
        Me.Label284.Text = "Safety Station 3"
        '
        'Label281
        '
        Me.Label281.AutoSize = True
        Me.Label281.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label281.Location = New System.Drawing.Point(168, 50)
        Me.Label281.Name = "Label281"
        Me.Label281.Size = New System.Drawing.Size(103, 20)
        Me.Label281.TabIndex = 99
        Me.Label281.Text = "Altivar Status"
        '
        'ind_safety_st6
        '
        Me.ind_safety_st6.BackColor = System.Drawing.Color.Transparent
        Me.ind_safety_st6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_st6.Location = New System.Drawing.Point(131, 438)
        Me.ind_safety_st6.Name = "ind_safety_st6"
        Me.ind_safety_st6.Size = New System.Drawing.Size(30, 30)
        Me.ind_safety_st6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_safety_st6.TabIndex = 98
        Me.ind_safety_st6.TabStop = False
        '
        'ind_safety_st2
        '
        Me.ind_safety_st2.BackColor = System.Drawing.Color.Transparent
        Me.ind_safety_st2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_st2.Location = New System.Drawing.Point(130, 213)
        Me.ind_safety_st2.Name = "ind_safety_st2"
        Me.ind_safety_st2.Size = New System.Drawing.Size(30, 30)
        Me.ind_safety_st2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_safety_st2.TabIndex = 97
        Me.ind_safety_st2.TabStop = False
        '
        'ind_safety_st4
        '
        Me.ind_safety_st4.BackColor = System.Drawing.Color.Transparent
        Me.ind_safety_st4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_st4.Location = New System.Drawing.Point(131, 326)
        Me.ind_safety_st4.Name = "ind_safety_st4"
        Me.ind_safety_st4.Size = New System.Drawing.Size(30, 30)
        Me.ind_safety_st4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_safety_st4.TabIndex = 96
        Me.ind_safety_st4.TabStop = False
        '
        'ind_cycle_status
        '
        Me.ind_cycle_status.BackColor = System.Drawing.Color.Transparent
        Me.ind_cycle_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_cycle_status.Location = New System.Drawing.Point(130, 101)
        Me.ind_cycle_status.Name = "ind_cycle_status"
        Me.ind_cycle_status.Size = New System.Drawing.Size(30, 30)
        Me.ind_cycle_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_cycle_status.TabIndex = 95
        Me.ind_cycle_status.TabStop = False
        '
        'ind_safety_st5
        '
        Me.ind_safety_st5.BackColor = System.Drawing.Color.Transparent
        Me.ind_safety_st5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_st5.Location = New System.Drawing.Point(131, 382)
        Me.ind_safety_st5.Name = "ind_safety_st5"
        Me.ind_safety_st5.Size = New System.Drawing.Size(30, 30)
        Me.ind_safety_st5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_safety_st5.TabIndex = 93
        Me.ind_safety_st5.TabStop = False
        '
        'ind_safety_st1
        '
        Me.ind_safety_st1.BackColor = System.Drawing.Color.Transparent
        Me.ind_safety_st1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_st1.Location = New System.Drawing.Point(130, 157)
        Me.ind_safety_st1.Name = "ind_safety_st1"
        Me.ind_safety_st1.Size = New System.Drawing.Size(30, 30)
        Me.ind_safety_st1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_safety_st1.TabIndex = 92
        Me.ind_safety_st1.TabStop = False
        '
        'ind_safety_st3
        '
        Me.ind_safety_st3.BackColor = System.Drawing.Color.Transparent
        Me.ind_safety_st3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_st3.Location = New System.Drawing.Point(131, 270)
        Me.ind_safety_st3.Name = "ind_safety_st3"
        Me.ind_safety_st3.Size = New System.Drawing.Size(30, 30)
        Me.ind_safety_st3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_safety_st3.TabIndex = 94
        Me.ind_safety_st3.TabStop = False
        '
        'ind_altivar_status
        '
        Me.ind_altivar_status.BackColor = System.Drawing.Color.Transparent
        Me.ind_altivar_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_altivar_status.Location = New System.Drawing.Point(130, 45)
        Me.ind_altivar_status.Name = "ind_altivar_status"
        Me.ind_altivar_status.Size = New System.Drawing.Size(30, 30)
        Me.ind_altivar_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_altivar_status.TabIndex = 91
        Me.ind_altivar_status.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Controls.Add(Me.GroupBox12)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(13, 476)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(79, 34)
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
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 395)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(79, 36)
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
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(12, 434)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(78, 34)
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
        Me.GroupBox3.Location = New System.Drawing.Point(490, 40)
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
        Me.pnl_setting.Location = New System.Drawing.Point(78, 87)
        Me.pnl_setting.Name = "pnl_setting"
        Me.pnl_setting.SelectedIndex = 0
        Me.pnl_setting.Size = New System.Drawing.Size(853, 563)
        Me.pnl_setting.TabIndex = 102
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.gb_laser)
        Me.TabPage10.Controls.Add(Me.RTB_CFG)
        Me.TabPage10.Controls.Add(Me.GroupBox179)
        Me.TabPage10.Controls.Add(Me.GroupBox177)
        Me.TabPage10.Controls.Add(Me.GroupBox176)
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
        'gb_laser
        '
        Me.gb_laser.Controls.Add(Me.txtIP_laser)
        Me.gb_laser.Controls.Add(Me.connect_laser_ind)
        Me.gb_laser.Controls.Add(Me.Label256)
        Me.gb_laser.Controls.Add(Me.Label258)
        Me.gb_laser.Controls.Add(Me.btn_save_laser)
        Me.gb_laser.Controls.Add(Me.txtPort_laser)
        Me.gb_laser.Controls.Add(Me.btn_connect_laser)
        Me.gb_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_laser.Location = New System.Drawing.Point(31, 342)
        Me.gb_laser.Name = "gb_laser"
        Me.gb_laser.Size = New System.Drawing.Size(214, 159)
        Me.gb_laser.TabIndex = 64
        Me.gb_laser.TabStop = False
        Me.gb_laser.Text = "Laser"
        '
        'txtIP_laser
        '
        Me.txtIP_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP_laser.Location = New System.Drawing.Point(90, 20)
        Me.txtIP_laser.Name = "txtIP_laser"
        Me.txtIP_laser.Size = New System.Drawing.Size(112, 26)
        Me.txtIP_laser.TabIndex = 2
        '
        'connect_laser_ind
        '
        Me.connect_laser_ind.BackColor = System.Drawing.Color.DarkRed
        Me.connect_laser_ind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.connect_laser_ind.Location = New System.Drawing.Point(119, 95)
        Me.connect_laser_ind.Name = "connect_laser_ind"
        Me.connect_laser_ind.Size = New System.Drawing.Size(20, 20)
        Me.connect_laser_ind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connect_laser_ind.TabIndex = 1
        Me.connect_laser_ind.TabStop = False
        '
        'Label256
        '
        Me.Label256.AutoSize = True
        Me.Label256.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label256.Location = New System.Drawing.Point(4, 25)
        Me.Label256.Name = "Label256"
        Me.Label256.Size = New System.Drawing.Size(82, 20)
        Me.Label256.TabIndex = 1
        Me.Label256.Text = "Server IP :"
        '
        'Label258
        '
        Me.Label258.AutoSize = True
        Me.Label258.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label258.Location = New System.Drawing.Point(6, 53)
        Me.Label258.Name = "Label258"
        Me.Label258.Size = New System.Drawing.Size(80, 20)
        Me.Label258.TabIndex = 1
        Me.Label258.Text = "TCP Port :"
        '
        'btn_save_laser
        '
        Me.btn_save_laser.AutoSize = True
        Me.btn_save_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_laser.Location = New System.Drawing.Point(10, 124)
        Me.btn_save_laser.Name = "btn_save_laser"
        Me.btn_save_laser.Size = New System.Drawing.Size(105, 32)
        Me.btn_save_laser.TabIndex = 4
        Me.btn_save_laser.Text = "Save Config"
        Me.btn_save_laser.UseVisualStyleBackColor = True
        '
        'txtPort_laser
        '
        Me.txtPort_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort_laser.Location = New System.Drawing.Point(90, 53)
        Me.txtPort_laser.Name = "txtPort_laser"
        Me.txtPort_laser.Size = New System.Drawing.Size(112, 26)
        Me.txtPort_laser.TabIndex = 3
        '
        'btn_connect_laser
        '
        Me.btn_connect_laser.AutoSize = True
        Me.btn_connect_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect_laser.Location = New System.Drawing.Point(10, 89)
        Me.btn_connect_laser.Name = "btn_connect_laser"
        Me.btn_connect_laser.Size = New System.Drawing.Size(79, 33)
        Me.btn_connect_laser.TabIndex = 4
        Me.btn_connect_laser.Text = "Connect"
        Me.btn_connect_laser.UseVisualStyleBackColor = True
        '
        'RTB_CFG
        '
        Me.RTB_CFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_CFG.Location = New System.Drawing.Point(279, 445)
        Me.RTB_CFG.Name = "RTB_CFG"
        Me.RTB_CFG.Size = New System.Drawing.Size(530, 53)
        Me.RTB_CFG.TabIndex = 63
        Me.RTB_CFG.Text = ""
        '
        'GroupBox179
        '
        Me.GroupBox179.Controls.Add(Me.Label254)
        Me.GroupBox179.Controls.Add(Me.Label252)
        Me.GroupBox179.Controls.Add(Me.txt_database)
        Me.GroupBox179.Controls.Add(Me.txt_username)
        Me.GroupBox179.Controls.Add(Me.Label253)
        Me.GroupBox179.Controls.Add(Me.Label251)
        Me.GroupBox179.Controls.Add(Me.txt_password)
        Me.GroupBox179.Controls.Add(Me.txt_hostname)
        Me.GroupBox179.Controls.Add(Me.btn_apply_database)
        Me.GroupBox179.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox179.Location = New System.Drawing.Point(528, 237)
        Me.GroupBox179.Name = "GroupBox179"
        Me.GroupBox179.Size = New System.Drawing.Size(280, 201)
        Me.GroupBox179.TabIndex = 62
        Me.GroupBox179.TabStop = False
        Me.GroupBox179.Text = "Database"
        '
        'Label254
        '
        Me.Label254.AutoSize = True
        Me.Label254.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label254.Location = New System.Drawing.Point(5, 100)
        Me.Label254.Name = "Label254"
        Me.Label254.Size = New System.Drawing.Size(86, 20)
        Me.Label254.TabIndex = 1
        Me.Label254.Text = "Password :"
        '
        'Label252
        '
        Me.Label252.AutoSize = True
        Me.Label252.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label252.Location = New System.Drawing.Point(0, 35)
        Me.Label252.Name = "Label252"
        Me.Label252.Size = New System.Drawing.Size(91, 20)
        Me.Label252.TabIndex = 1
        Me.Label252.Text = "Hostname :"
        '
        'txt_database
        '
        Me.txt_database.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_database.Location = New System.Drawing.Point(92, 130)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(167, 26)
        Me.txt_database.TabIndex = 3
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(92, 65)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(167, 26)
        Me.txt_username.TabIndex = 3
        '
        'Label253
        '
        Me.Label253.AutoSize = True
        Me.Label253.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label253.Location = New System.Drawing.Point(4, 133)
        Me.Label253.Name = "Label253"
        Me.Label253.Size = New System.Drawing.Size(87, 20)
        Me.Label253.TabIndex = 1
        Me.Label253.Text = "Database :"
        '
        'Label251
        '
        Me.Label251.AutoSize = True
        Me.Label251.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label251.Location = New System.Drawing.Point(0, 67)
        Me.Label251.Name = "Label251"
        Me.Label251.Size = New System.Drawing.Size(91, 20)
        Me.Label251.TabIndex = 1
        Me.Label251.Text = "Username :"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(92, 97)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(167, 26)
        Me.txt_password.TabIndex = 2
        '
        'txt_hostname
        '
        Me.txt_hostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hostname.Location = New System.Drawing.Point(92, 32)
        Me.txt_hostname.Name = "txt_hostname"
        Me.txt_hostname.Size = New System.Drawing.Size(167, 26)
        Me.txt_hostname.TabIndex = 2
        '
        'btn_apply_database
        '
        Me.btn_apply_database.AutoSize = True
        Me.btn_apply_database.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply_database.Location = New System.Drawing.Point(13, 161)
        Me.btn_apply_database.Name = "btn_apply_database"
        Me.btn_apply_database.Size = New System.Drawing.Size(105, 35)
        Me.btn_apply_database.TabIndex = 4
        Me.btn_apply_database.Text = "Save Config"
        Me.btn_apply_database.UseVisualStyleBackColor = True
        '
        'GroupBox177
        '
        Me.GroupBox177.Controls.Add(Me.Label231)
        Me.GroupBox177.Controls.Add(Me.Label217)
        Me.GroupBox177.Controls.Add(Me.Label228)
        Me.GroupBox177.Controls.Add(Me.Label200)
        Me.GroupBox177.Controls.Add(Me.Label227)
        Me.GroupBox177.Controls.Add(Me.Label183)
        Me.GroupBox177.Controls.Add(Me.ind_stn_6)
        Me.GroupBox177.Controls.Add(Me.ind_stn_3)
        Me.GroupBox177.Controls.Add(Me.ind_stn_5)
        Me.GroupBox177.Controls.Add(Me.ind_stn_2)
        Me.GroupBox177.Controls.Add(Me.ind_stn_4)
        Me.GroupBox177.Controls.Add(Me.ind_stn_1)
        Me.GroupBox177.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox177.Location = New System.Drawing.Point(31, 20)
        Me.GroupBox177.Name = "GroupBox177"
        Me.GroupBox177.Size = New System.Drawing.Size(215, 124)
        Me.GroupBox177.TabIndex = 61
        Me.GroupBox177.TabStop = False
        Me.GroupBox177.Text = "Station Status"
        '
        'Label231
        '
        Me.Label231.AutoSize = True
        Me.Label231.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label231.Location = New System.Drawing.Point(133, 87)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(73, 20)
        Me.Label231.TabIndex = 0
        Me.Label231.Text = "Station 6"
        '
        'Label217
        '
        Me.Label217.AutoSize = True
        Me.Label217.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label217.Location = New System.Drawing.Point(29, 87)
        Me.Label217.Name = "Label217"
        Me.Label217.Size = New System.Drawing.Size(73, 20)
        Me.Label217.TabIndex = 0
        Me.Label217.Text = "Station 3"
        '
        'Label228
        '
        Me.Label228.AutoSize = True
        Me.Label228.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label228.Location = New System.Drawing.Point(133, 61)
        Me.Label228.Name = "Label228"
        Me.Label228.Size = New System.Drawing.Size(73, 20)
        Me.Label228.TabIndex = 0
        Me.Label228.Text = "Station 5"
        '
        'Label200
        '
        Me.Label200.AutoSize = True
        Me.Label200.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label200.Location = New System.Drawing.Point(29, 61)
        Me.Label200.Name = "Label200"
        Me.Label200.Size = New System.Drawing.Size(73, 20)
        Me.Label200.TabIndex = 0
        Me.Label200.Text = "Station 2"
        '
        'Label227
        '
        Me.Label227.AutoSize = True
        Me.Label227.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label227.Location = New System.Drawing.Point(133, 35)
        Me.Label227.Name = "Label227"
        Me.Label227.Size = New System.Drawing.Size(73, 20)
        Me.Label227.TabIndex = 0
        Me.Label227.Text = "Station 4"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label183.Location = New System.Drawing.Point(29, 35)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(77, 20)
        Me.Label183.TabIndex = 0
        Me.Label183.Text = "Station 1 "
        '
        'ind_stn_6
        '
        Me.ind_stn_6.BackColor = System.Drawing.Color.DarkRed
        Me.ind_stn_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_6.Location = New System.Drawing.Point(109, 87)
        Me.ind_stn_6.Name = "ind_stn_6"
        Me.ind_stn_6.Size = New System.Drawing.Size(20, 20)
        Me.ind_stn_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_6.TabIndex = 1
        Me.ind_stn_6.TabStop = False
        '
        'ind_stn_3
        '
        Me.ind_stn_3.BackColor = System.Drawing.Color.DarkRed
        Me.ind_stn_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_3.Location = New System.Drawing.Point(5, 87)
        Me.ind_stn_3.Name = "ind_stn_3"
        Me.ind_stn_3.Size = New System.Drawing.Size(20, 20)
        Me.ind_stn_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_3.TabIndex = 1
        Me.ind_stn_3.TabStop = False
        '
        'ind_stn_5
        '
        Me.ind_stn_5.BackColor = System.Drawing.Color.DarkRed
        Me.ind_stn_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_5.Location = New System.Drawing.Point(109, 61)
        Me.ind_stn_5.Name = "ind_stn_5"
        Me.ind_stn_5.Size = New System.Drawing.Size(20, 20)
        Me.ind_stn_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_5.TabIndex = 1
        Me.ind_stn_5.TabStop = False
        '
        'ind_stn_2
        '
        Me.ind_stn_2.BackColor = System.Drawing.Color.DarkRed
        Me.ind_stn_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_2.Location = New System.Drawing.Point(5, 61)
        Me.ind_stn_2.Name = "ind_stn_2"
        Me.ind_stn_2.Size = New System.Drawing.Size(20, 20)
        Me.ind_stn_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_2.TabIndex = 1
        Me.ind_stn_2.TabStop = False
        '
        'ind_stn_4
        '
        Me.ind_stn_4.BackColor = System.Drawing.Color.DarkRed
        Me.ind_stn_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_4.Location = New System.Drawing.Point(109, 35)
        Me.ind_stn_4.Name = "ind_stn_4"
        Me.ind_stn_4.Size = New System.Drawing.Size(20, 20)
        Me.ind_stn_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_4.TabIndex = 1
        Me.ind_stn_4.TabStop = False
        '
        'ind_stn_1
        '
        Me.ind_stn_1.BackColor = System.Drawing.Color.DarkRed
        Me.ind_stn_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_1.Location = New System.Drawing.Point(5, 35)
        Me.ind_stn_1.Name = "ind_stn_1"
        Me.ind_stn_1.Size = New System.Drawing.Size(20, 20)
        Me.ind_stn_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_1.TabIndex = 1
        Me.ind_stn_1.TabStop = False
        '
        'GroupBox176
        '
        Me.GroupBox176.Controls.Add(Me.st6_laser)
        Me.GroupBox176.Controls.Add(Me.st4_resistance)
        Me.GroupBox176.Controls.Add(Me.CheckBox2)
        Me.GroupBox176.Controls.Add(Me.st2_beating)
        Me.GroupBox176.Controls.Add(Me.st4_cot)
        Me.GroupBox176.Controls.Add(Me.st3_adjustment)
        Me.GroupBox176.Controls.Add(Me.cb_downgrade_6)
        Me.GroupBox176.Controls.Add(Me.st2_measuring)
        Me.GroupBox176.Controls.Add(Me.Label166)
        Me.GroupBox176.Controls.Add(Me.cb_downgrade_5)
        Me.GroupBox176.Controls.Add(Me.Label149)
        Me.GroupBox176.Controls.Add(Me.cb_downgrade_4)
        Me.GroupBox176.Controls.Add(Me.btn_apply_station)
        Me.GroupBox176.Controls.Add(Me.Label71)
        Me.GroupBox176.Controls.Add(Me.cb_downgrade_3)
        Me.GroupBox176.Controls.Add(Me.Label60)
        Me.GroupBox176.Controls.Add(Me.cb_downgrade_2)
        Me.GroupBox176.Controls.Add(Me.Label42)
        Me.GroupBox176.Controls.Add(Me.cb_downgrade_1)
        Me.GroupBox176.Controls.Add(Me.Label24)
        Me.GroupBox176.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox176.Location = New System.Drawing.Point(279, 19)
        Me.GroupBox176.Name = "GroupBox176"
        Me.GroupBox176.Size = New System.Drawing.Size(214, 420)
        Me.GroupBox176.TabIndex = 60
        Me.GroupBox176.TabStop = False
        Me.GroupBox176.Text = "Station Downgrade"
        '
        'st4_resistance
        '
        Me.st4_resistance.AutoSize = True
        Me.st4_resistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st4_resistance.Location = New System.Drawing.Point(73, 194)
        Me.st4_resistance.Name = "st4_resistance"
        Me.st4_resistance.Size = New System.Drawing.Size(95, 20)
        Me.st4_resistance.TabIndex = 5
        Me.st4_resistance.Text = "Resistance"
        Me.st4_resistance.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(73, 268)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 20)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Spare"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'st2_beating
        '
        Me.st2_beating.AutoSize = True
        Me.st2_beating.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st2_beating.Location = New System.Drawing.Point(73, 121)
        Me.st2_beating.Name = "st2_beating"
        Me.st2_beating.Size = New System.Drawing.Size(73, 20)
        Me.st2_beating.TabIndex = 5
        Me.st2_beating.Text = "Beating"
        Me.st2_beating.UseVisualStyleBackColor = True
        '
        'st4_cot
        '
        Me.st4_cot.AutoSize = True
        Me.st4_cot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st4_cot.Location = New System.Drawing.Point(73, 251)
        Me.st4_cot.Name = "st4_cot"
        Me.st4_cot.Size = New System.Drawing.Size(55, 20)
        Me.st4_cot.TabIndex = 5
        Me.st4_cot.Text = "COT"
        Me.st4_cot.UseVisualStyleBackColor = True
        '
        'st3_adjustment
        '
        Me.st3_adjustment.AutoSize = True
        Me.st3_adjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st3_adjustment.Location = New System.Drawing.Point(73, 176)
        Me.st3_adjustment.Name = "st3_adjustment"
        Me.st3_adjustment.Size = New System.Drawing.Size(93, 20)
        Me.st3_adjustment.TabIndex = 5
        Me.st3_adjustment.Text = "Adjustment"
        Me.st3_adjustment.UseVisualStyleBackColor = True
        '
        'cb_downgrade_6
        '
        Me.cb_downgrade_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_downgrade_6.FormattingEnabled = True
        Me.cb_downgrade_6.Items.AddRange(New Object() {"Enable", "Disable"})
        Me.cb_downgrade_6.Location = New System.Drawing.Point(73, 328)
        Me.cb_downgrade_6.Name = "cb_downgrade_6"
        Me.cb_downgrade_6.Size = New System.Drawing.Size(121, 28)
        Me.cb_downgrade_6.TabIndex = 0
        Me.cb_downgrade_6.Text = "Enable"
        '
        'st2_measuring
        '
        Me.st2_measuring.AutoSize = True
        Me.st2_measuring.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st2_measuring.Location = New System.Drawing.Point(73, 104)
        Me.st2_measuring.Name = "st2_measuring"
        Me.st2_measuring.Size = New System.Drawing.Size(90, 20)
        Me.st2_measuring.TabIndex = 5
        Me.st2_measuring.Text = "Measuring"
        Me.st2_measuring.UseVisualStyleBackColor = True
        '
        'Label166
        '
        Me.Label166.AutoSize = True
        Me.Label166.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label166.Location = New System.Drawing.Point(10, 332)
        Me.Label166.Name = "Label166"
        Me.Label166.Size = New System.Drawing.Size(50, 20)
        Me.Label166.TabIndex = 1
        Me.Label166.Text = "ST 6 :"
        '
        'cb_downgrade_5
        '
        Me.cb_downgrade_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_downgrade_5.FormattingEnabled = True
        Me.cb_downgrade_5.Items.AddRange(New Object() {"Enable", "Disable"})
        Me.cb_downgrade_5.Location = New System.Drawing.Point(73, 294)
        Me.cb_downgrade_5.Name = "cb_downgrade_5"
        Me.cb_downgrade_5.Size = New System.Drawing.Size(121, 28)
        Me.cb_downgrade_5.TabIndex = 0
        Me.cb_downgrade_5.Text = "Enable"
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label149.Location = New System.Drawing.Point(10, 298)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(50, 20)
        Me.Label149.TabIndex = 1
        Me.Label149.Text = "ST 5 :"
        '
        'cb_downgrade_4
        '
        Me.cb_downgrade_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_downgrade_4.FormattingEnabled = True
        Me.cb_downgrade_4.Items.AddRange(New Object() {"Enable", "Disable"})
        Me.cb_downgrade_4.Location = New System.Drawing.Point(73, 220)
        Me.cb_downgrade_4.Name = "cb_downgrade_4"
        Me.cb_downgrade_4.Size = New System.Drawing.Size(121, 28)
        Me.cb_downgrade_4.TabIndex = 0
        Me.cb_downgrade_4.Text = "Enable"
        '
        'btn_apply_station
        '
        Me.btn_apply_station.AutoSize = True
        Me.btn_apply_station.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply_station.Location = New System.Drawing.Point(94, 378)
        Me.btn_apply_station.Name = "btn_apply_station"
        Me.btn_apply_station.Size = New System.Drawing.Size(102, 36)
        Me.btn_apply_station.TabIndex = 4
        Me.btn_apply_station.Text = "Apply"
        Me.btn_apply_station.UseVisualStyleBackColor = True
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(10, 224)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(50, 20)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "ST 4 :"
        '
        'cb_downgrade_3
        '
        Me.cb_downgrade_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_downgrade_3.FormattingEnabled = True
        Me.cb_downgrade_3.Items.AddRange(New Object() {"Enable", "Disable"})
        Me.cb_downgrade_3.Location = New System.Drawing.Point(73, 145)
        Me.cb_downgrade_3.Name = "cb_downgrade_3"
        Me.cb_downgrade_3.Size = New System.Drawing.Size(121, 28)
        Me.cb_downgrade_3.TabIndex = 0
        Me.cb_downgrade_3.Text = "Enable"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(10, 149)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(50, 20)
        Me.Label60.TabIndex = 1
        Me.Label60.Text = "ST 3 :"
        '
        'cb_downgrade_2
        '
        Me.cb_downgrade_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_downgrade_2.FormattingEnabled = True
        Me.cb_downgrade_2.Items.AddRange(New Object() {"Enable", "Disable"})
        Me.cb_downgrade_2.Location = New System.Drawing.Point(73, 72)
        Me.cb_downgrade_2.Name = "cb_downgrade_2"
        Me.cb_downgrade_2.Size = New System.Drawing.Size(121, 28)
        Me.cb_downgrade_2.TabIndex = 0
        Me.cb_downgrade_2.Text = "Enable"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(10, 76)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(50, 20)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "ST 2 :"
        '
        'cb_downgrade_1
        '
        Me.cb_downgrade_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_downgrade_1.FormattingEnabled = True
        Me.cb_downgrade_1.Items.AddRange(New Object() {"Enable", "Disable"})
        Me.cb_downgrade_1.Location = New System.Drawing.Point(73, 38)
        Me.cb_downgrade_1.Name = "cb_downgrade_1"
        Me.cb_downgrade_1.Size = New System.Drawing.Size(121, 28)
        Me.cb_downgrade_1.TabIndex = 0
        Me.cb_downgrade_1.Text = "Enable"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(10, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 20)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "ST 1 :"
        '
        'GroupBox169
        '
        Me.GroupBox169.Controls.Add(Me.Label255)
        Me.GroupBox169.Controls.Add(Me.Label316)
        Me.GroupBox169.Controls.Add(Me.Label2)
        Me.GroupBox169.Controls.Add(Me.connect_multi_ind)
        Me.GroupBox169.Controls.Add(Me.Label226)
        Me.GroupBox169.Controls.Add(Me.txt_name_multi)
        Me.GroupBox169.Controls.Add(Me.txt_offset_multi)
        Me.GroupBox169.Controls.Add(Me.txt_port_multi)
        Me.GroupBox169.Controls.Add(Me.btn_apply_multi)
        Me.GroupBox169.Controls.Add(Me.btn_open_multi)
        Me.GroupBox169.Controls.Add(Me.txt_baud_multi)
        Me.GroupBox169.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox169.Location = New System.Drawing.Point(529, 18)
        Me.GroupBox169.Name = "GroupBox169"
        Me.GroupBox169.Size = New System.Drawing.Size(281, 215)
        Me.GroupBox169.TabIndex = 59
        Me.GroupBox169.TabStop = False
        Me.GroupBox169.Text = "Instrument"
        '
        'Label255
        '
        Me.Label255.AutoSize = True
        Me.Label255.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label255.Location = New System.Drawing.Point(17, 34)
        Me.Label255.Name = "Label255"
        Me.Label255.Size = New System.Drawing.Size(59, 20)
        Me.Label255.TabIndex = 1
        Me.Label255.Text = "Name :"
        '
        'Label316
        '
        Me.Label316.AutoSize = True
        Me.Label316.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label316.Location = New System.Drawing.Point(15, 98)
        Me.Label316.Name = "Label316"
        Me.Label316.Size = New System.Drawing.Size(65, 20)
        Me.Label316.TabIndex = 1
        Me.Label316.Text = "Offset : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port :"
        '
        'connect_multi_ind
        '
        Me.connect_multi_ind.BackColor = System.Drawing.Color.DarkRed
        Me.connect_multi_ind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.connect_multi_ind.Location = New System.Drawing.Point(120, 138)
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
        Me.Label226.Location = New System.Drawing.Point(143, 66)
        Me.Label226.Name = "Label226"
        Me.Label226.Size = New System.Drawing.Size(55, 20)
        Me.Label226.TabIndex = 1
        Me.Label226.Text = "Baud :"
        '
        'txt_name_multi
        '
        Me.txt_name_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name_multi.Location = New System.Drawing.Point(82, 31)
        Me.txt_name_multi.Name = "txt_name_multi"
        Me.txt_name_multi.Size = New System.Drawing.Size(177, 26)
        Me.txt_name_multi.TabIndex = 2
        '
        'txt_offset_multi
        '
        Me.txt_offset_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_offset_multi.Location = New System.Drawing.Point(82, 95)
        Me.txt_offset_multi.Name = "txt_offset_multi"
        Me.txt_offset_multi.Size = New System.Drawing.Size(60, 26)
        Me.txt_offset_multi.TabIndex = 2
        '
        'txt_port_multi
        '
        Me.txt_port_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_port_multi.Location = New System.Drawing.Point(82, 63)
        Me.txt_port_multi.Name = "txt_port_multi"
        Me.txt_port_multi.Size = New System.Drawing.Size(60, 26)
        Me.txt_port_multi.TabIndex = 2
        '
        'btn_apply_multi
        '
        Me.btn_apply_multi.AutoSize = True
        Me.btn_apply_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply_multi.Location = New System.Drawing.Point(9, 172)
        Me.btn_apply_multi.Name = "btn_apply_multi"
        Me.btn_apply_multi.Size = New System.Drawing.Size(110, 34)
        Me.btn_apply_multi.TabIndex = 4
        Me.btn_apply_multi.Text = "Save Config"
        Me.btn_apply_multi.UseVisualStyleBackColor = True
        '
        'btn_open_multi
        '
        Me.btn_open_multi.AutoSize = True
        Me.btn_open_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_open_multi.Location = New System.Drawing.Point(9, 131)
        Me.btn_open_multi.Name = "btn_open_multi"
        Me.btn_open_multi.Size = New System.Drawing.Size(102, 35)
        Me.btn_open_multi.TabIndex = 4
        Me.btn_open_multi.Text = "Open Port"
        Me.btn_open_multi.UseVisualStyleBackColor = True
        '
        'txt_baud_multi
        '
        Me.txt_baud_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_baud_multi.Location = New System.Drawing.Point(199, 63)
        Me.txt_baud_multi.Name = "txt_baud_multi"
        Me.txt_baud_multi.Size = New System.Drawing.Size(60, 26)
        Me.txt_baud_multi.TabIndex = 3
        '
        'grp_plc
        '
        Me.grp_plc.Controls.Add(Me.cbo_data_type)
        Me.grp_plc.Controls.Add(Me.connect_plc_ind)
        Me.grp_plc.Controls.Add(Me.btn_write)
        Me.grp_plc.Controls.Add(Me.btn_save_plc)
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
        Me.grp_plc.Location = New System.Drawing.Point(32, 158)
        Me.grp_plc.Name = "grp_plc"
        Me.grp_plc.Size = New System.Drawing.Size(214, 344)
        Me.grp_plc.TabIndex = 58
        Me.grp_plc.TabStop = False
        Me.grp_plc.Text = "PLC"
        '
        'cbo_data_type
        '
        Me.cbo_data_type.FormattingEnabled = True
        Me.cbo_data_type.Items.AddRange(New Object() {"INT", "FLOAT", "DWORD"})
        Me.cbo_data_type.Location = New System.Drawing.Point(94, 249)
        Me.cbo_data_type.Name = "cbo_data_type"
        Me.cbo_data_type.Size = New System.Drawing.Size(112, 32)
        Me.cbo_data_type.TabIndex = 57
        '
        'connect_plc_ind
        '
        Me.connect_plc_ind.BackColor = System.Drawing.Color.DarkRed
        Me.connect_plc_ind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.connect_plc_ind.Location = New System.Drawing.Point(119, 99)
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
        Me.btn_write.Location = New System.Drawing.Point(122, 296)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(84, 35)
        Me.btn_write.TabIndex = 4
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'btn_save_plc
        '
        Me.btn_save_plc.AutoSize = True
        Me.btn_save_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_plc.Location = New System.Drawing.Point(10, 132)
        Me.btn_save_plc.Name = "btn_save_plc"
        Me.btn_save_plc.Size = New System.Drawing.Size(105, 32)
        Me.btn_save_plc.TabIndex = 4
        Me.btn_save_plc.Text = "Save Config"
        Me.btn_save_plc.UseVisualStyleBackColor = True
        '
        'btn_connect_plc
        '
        Me.btn_connect_plc.AutoSize = True
        Me.btn_connect_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect_plc.Location = New System.Drawing.Point(10, 93)
        Me.btn_connect_plc.Name = "btn_connect_plc"
        Me.btn_connect_plc.Size = New System.Drawing.Size(79, 33)
        Me.btn_connect_plc.TabIndex = 4
        Me.btn_connect_plc.Text = "Connect"
        Me.btn_connect_plc.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.AutoSize = True
        Me.btn_read.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read.Location = New System.Drawing.Point(20, 296)
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
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(94, 217)
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
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(-1, 253)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(90, 20)
        Me.Label72.TabIndex = 1
        Me.Label72.Text = "Data Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "TCP Port :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(94, 184)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(112, 26)
        Me.txtAddress.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Value :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Server IP :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Address :"
        '
        'pnl_log
        '
        Me.pnl_log.Controls.Add(Me.TabPage1)
        Me.pnl_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_log.Location = New System.Drawing.Point(78, 87)
        Me.pnl_log.Name = "pnl_log"
        Me.pnl_log.SelectedIndex = 0
        Me.pnl_log.Size = New System.Drawing.Size(853, 563)
        Me.pnl_log.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl1)
        Me.TabPage1.Controls.Add(Me.GroupBox182)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(845, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Logger"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 368)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 147)
        Me.TabControl1.TabIndex = 71
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.rbByREF)
        Me.TabPage11.Controls.Add(Me.rbBydate)
        Me.TabPage11.Controls.Add(Me.GroupBox174)
        Me.TabPage11.Controls.Add(Me.GroupBox181)
        Me.TabPage11.Controls.Add(Me.btn_search)
        Me.TabPage11.Location = New System.Drawing.Point(4, 29)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(520, 114)
        Me.TabPage11.TabIndex = 0
        Me.TabPage11.Text = "Datalog Finder"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'rbByREF
        '
        Me.rbByREF.AutoSize = True
        Me.rbByREF.Location = New System.Drawing.Point(344, 33)
        Me.rbByREF.Name = "rbByREF"
        Me.rbByREF.Size = New System.Drawing.Size(145, 24)
        Me.rbByREF.TabIndex = 13
        Me.rbByREF.TabStop = True
        Me.rbByREF.Text = "By References"
        Me.rbByREF.UseVisualStyleBackColor = True
        '
        'rbBydate
        '
        Me.rbBydate.AutoSize = True
        Me.rbBydate.Location = New System.Drawing.Point(344, 7)
        Me.rbBydate.Name = "rbBydate"
        Me.rbBydate.Size = New System.Drawing.Size(91, 24)
        Me.rbBydate.TabIndex = 12
        Me.rbBydate.TabStop = True
        Me.rbBydate.Text = "By Date"
        Me.rbBydate.UseVisualStyleBackColor = True
        '
        'GroupBox174
        '
        Me.GroupBox174.Controls.Add(Me.tbSearchREF)
        Me.GroupBox174.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox174.Location = New System.Drawing.Point(2, 72)
        Me.GroupBox174.Name = "GroupBox174"
        Me.GroupBox174.Size = New System.Drawing.Size(313, 43)
        Me.GroupBox174.TabIndex = 11
        Me.GroupBox174.TabStop = False
        Me.GroupBox174.Text = "By References"
        '
        'tbSearchREF
        '
        Me.tbSearchREF.BackColor = System.Drawing.SystemColors.Control
        Me.tbSearchREF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchREF.ForeColor = System.Drawing.Color.Black
        Me.tbSearchREF.Location = New System.Drawing.Point(9, 16)
        Me.tbSearchREF.Name = "tbSearchREF"
        Me.tbSearchREF.Size = New System.Drawing.Size(298, 22)
        Me.tbSearchREF.TabIndex = 24
        '
        'GroupBox181
        '
        Me.GroupBox181.Controls.Add(Me.Label249)
        Me.GroupBox181.Controls.Add(Me.Label250)
        Me.GroupBox181.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox181.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox181.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox181.Location = New System.Drawing.Point(2, -1)
        Me.GroupBox181.Name = "GroupBox181"
        Me.GroupBox181.Size = New System.Drawing.Size(313, 73)
        Me.GroupBox181.TabIndex = 10
        Me.GroupBox181.TabStop = False
        Me.GroupBox181.Text = "By Date"
        '
        'Label249
        '
        Me.Label249.AutoSize = True
        Me.Label249.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label249.Location = New System.Drawing.Point(16, 17)
        Me.Label249.Name = "Label249"
        Me.Label249.Size = New System.Drawing.Size(71, 15)
        Me.Label249.TabIndex = 1
        Me.Label249.Text = "Start Date"
        '
        'Label250
        '
        Me.Label250.AutoSize = True
        Me.Label250.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label250.Location = New System.Drawing.Point(16, 45)
        Me.Label250.Name = "Label250"
        Me.Label250.Size = New System.Drawing.Size(66, 15)
        Me.Label250.TabIndex = 3
        Me.Label250.Text = "End Date"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(107, 41)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerEndDate.TabIndex = 2
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(107, 13)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerStartDate.TabIndex = 0
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(321, 66)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(197, 49)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.btn_fileLocation)
        Me.TabPage12.Controls.Add(Me.ProgressBarExport)
        Me.TabPage12.Controls.Add(Me.txtFileLocation)
        Me.TabPage12.Controls.Add(Me.btn_export)
        Me.TabPage12.Location = New System.Drawing.Point(4, 29)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(520, 114)
        Me.TabPage12.TabIndex = 1
        Me.TabPage12.Text = "Export"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'btn_fileLocation
        '
        Me.btn_fileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fileLocation.Location = New System.Drawing.Point(85, 75)
        Me.btn_fileLocation.Name = "btn_fileLocation"
        Me.btn_fileLocation.Size = New System.Drawing.Size(155, 35)
        Me.btn_fileLocation.TabIndex = 14
        Me.btn_fileLocation.Text = "Select File Location"
        Me.btn_fileLocation.UseVisualStyleBackColor = True
        '
        'ProgressBarExport
        '
        Me.ProgressBarExport.Location = New System.Drawing.Point(85, 37)
        Me.ProgressBarExport.Name = "ProgressBarExport"
        Me.ProgressBarExport.Size = New System.Drawing.Size(350, 23)
        Me.ProgressBarExport.TabIndex = 13
        '
        'txtFileLocation
        '
        Me.txtFileLocation.BackColor = System.Drawing.SystemColors.Control
        Me.txtFileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileLocation.ForeColor = System.Drawing.Color.Black
        Me.txtFileLocation.Location = New System.Drawing.Point(85, 5)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.Size = New System.Drawing.Size(350, 22)
        Me.txtFileLocation.TabIndex = 12
        '
        'btn_export
        '
        Me.btn_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.Location = New System.Drawing.Point(280, 75)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(155, 35)
        Me.btn_export.TabIndex = 11
        Me.btn_export.Text = "Export"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'GroupBox182
        '
        Me.GroupBox182.BackColor = System.Drawing.Color.White
        Me.GroupBox182.Controls.Add(Me.RTB_LOG)
        Me.GroupBox182.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox182.ForeColor = System.Drawing.Color.Black
        Me.GroupBox182.Location = New System.Drawing.Point(542, 367)
        Me.GroupBox182.Name = "GroupBox182"
        Me.GroupBox182.Size = New System.Drawing.Size(295, 147)
        Me.GroupBox182.TabIndex = 70
        Me.GroupBox182.TabStop = False
        Me.GroupBox182.Text = "Status"
        '
        'RTB_LOG
        '
        Me.RTB_LOG.BackColor = System.Drawing.Color.White
        Me.RTB_LOG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_LOG.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RTB_LOG.Location = New System.Drawing.Point(6, 25)
        Me.RTB_LOG.Name = "RTB_LOG"
        Me.RTB_LOG.ReadOnly = True
        Me.RTB_LOG.Size = New System.Drawing.Size(281, 111)
        Me.RTB_LOG.TabIndex = 0
        Me.RTB_LOG.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(831, 351)
        Me.DataGridView1.TabIndex = 68
        '
        'pnl_ref
        '
        Me.pnl_ref.Controls.Add(Me.TabPage2)
        Me.pnl_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_ref.Location = New System.Drawing.Point(78, 87)
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
        Me.dgv_ref.Location = New System.Drawing.Point(317, 33)
        Me.dgv_ref.Name = "dgv_ref"
        Me.dgv_ref.Size = New System.Drawing.Size(515, 477)
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
        Me.txt_laser_template_pnl.MaxLength = 32
        Me.txt_laser_template_pnl.Name = "txt_laser_template_pnl"
        Me.txt_laser_template_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_laser_template_pnl.TabIndex = 6
        '
        'txt_beating_times_pnl
        '
        Me.txt_beating_times_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_beating_times_pnl.Location = New System.Drawing.Point(169, 209)
        Me.txt_beating_times_pnl.MaxLength = 32
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
        Me.txt_laser_datecode_pnl.MaxLength = 32
        Me.txt_laser_datecode_pnl.Name = "txt_laser_datecode_pnl"
        Me.txt_laser_datecode_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_laser_datecode_pnl.TabIndex = 5
        '
        'txt_dif_str_tol_pnl
        '
        Me.txt_dif_str_tol_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dif_str_tol_pnl.Location = New System.Drawing.Point(169, 177)
        Me.txt_dif_str_tol_pnl.MaxLength = 32
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
        Me.txt_unscrew_pnl.MaxLength = 32
        Me.txt_unscrew_pnl.Name = "txt_unscrew_pnl"
        Me.txt_unscrew_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_unscrew_pnl.TabIndex = 4
        '
        'txt_dif_str_pnl
        '
        Me.txt_dif_str_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dif_str_pnl.Location = New System.Drawing.Point(169, 145)
        Me.txt_dif_str_pnl.MaxLength = 32
        Me.txt_dif_str_pnl.Name = "txt_dif_str_pnl"
        Me.txt_dif_str_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_dif_str_pnl.TabIndex = 4
        '
        'txt_cfg_2nd_pnl
        '
        Me.txt_cfg_2nd_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cfg_2nd_pnl.Location = New System.Drawing.Point(170, 273)
        Me.txt_cfg_2nd_pnl.MaxLength = 32
        Me.txt_cfg_2nd_pnl.Name = "txt_cfg_2nd_pnl"
        Me.txt_cfg_2nd_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_cfg_2nd_pnl.TabIndex = 3
        '
        'txt_act_val_tol_pnl
        '
        Me.txt_act_val_tol_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_act_val_tol_pnl.Location = New System.Drawing.Point(169, 113)
        Me.txt_act_val_tol_pnl.MaxLength = 32
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
        Me.txt_cfg_1st_pnl.MaxLength = 32
        Me.txt_cfg_1st_pnl.Name = "txt_cfg_1st_pnl"
        Me.txt_cfg_1st_pnl.Size = New System.Drawing.Size(112, 26)
        Me.txt_cfg_1st_pnl.TabIndex = 2
        '
        'txt_act_val_pnl
        '
        Me.txt_act_val_pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_act_val_pnl.Location = New System.Drawing.Point(169, 81)
        Me.txt_act_val_pnl.MaxLength = 32
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
        Me.pnl_laser.Location = New System.Drawing.Point(78, 87)
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
        Me.GroupBox171.Controls.Add(Me.btn_send_laser)
        Me.GroupBox171.Controls.Add(Me.txtResponse_laser)
        Me.GroupBox171.Controls.Add(Me.Label233)
        Me.GroupBox171.Controls.Add(Me.txtCommand_laser)
        Me.GroupBox171.Controls.Add(Me.Label232)
        Me.GroupBox171.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox171.Location = New System.Drawing.Point(171, 35)
        Me.GroupBox171.Name = "GroupBox171"
        Me.GroupBox171.Size = New System.Drawing.Size(502, 466)
        Me.GroupBox171.TabIndex = 62
        Me.GroupBox171.TabStop = False
        Me.GroupBox171.Text = "Laser Parameter"
        '
        'btn_send_laser
        '
        Me.btn_send_laser.Location = New System.Drawing.Point(226, 143)
        Me.btn_send_laser.Name = "btn_send_laser"
        Me.btn_send_laser.Size = New System.Drawing.Size(75, 37)
        Me.btn_send_laser.TabIndex = 2
        Me.btn_send_laser.Text = "Send"
        Me.btn_send_laser.UseVisualStyleBackColor = True
        '
        'txtResponse_laser
        '
        Me.txtResponse_laser.Location = New System.Drawing.Point(158, 100)
        Me.txtResponse_laser.Name = "txtResponse_laser"
        Me.txtResponse_laser.Size = New System.Drawing.Size(143, 29)
        Me.txtResponse_laser.TabIndex = 1
        '
        'Label233
        '
        Me.Label233.AutoSize = True
        Me.Label233.Location = New System.Drawing.Point(46, 105)
        Me.Label233.Name = "Label233"
        Me.Label233.Size = New System.Drawing.Size(106, 24)
        Me.Label233.TabIndex = 0
        Me.Label233.Text = "Response :"
        '
        'txtCommand_laser
        '
        Me.txtCommand_laser.Location = New System.Drawing.Point(158, 66)
        Me.txtCommand_laser.Name = "txtCommand_laser"
        Me.txtCommand_laser.Size = New System.Drawing.Size(143, 29)
        Me.txtCommand_laser.TabIndex = 1
        '
        'Label232
        '
        Me.Label232.AutoSize = True
        Me.Label232.Location = New System.Drawing.Point(44, 71)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(108, 24)
        Me.Label232.TabIndex = 0
        Me.Label232.Text = "Command :"
        '
        'pnl_multi
        '
        Me.pnl_multi.Controls.Add(Me.TabPage14)
        Me.pnl_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_multi.Location = New System.Drawing.Point(78, 87)
        Me.pnl_multi.Name = "pnl_multi"
        Me.pnl_multi.SelectedIndex = 0
        Me.pnl_multi.Size = New System.Drawing.Size(853, 563)
        Me.pnl_multi.TabIndex = 106
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.GroupBox178)
        Me.TabPage14.Controls.Add(Me.GroupBox170)
        Me.TabPage14.Location = New System.Drawing.Point(4, 38)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(845, 521)
        Me.TabPage14.TabIndex = 0
        Me.TabPage14.Text = "Multimeter"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'GroupBox178
        '
        Me.GroupBox178.Controls.Add(Me.Label236)
        Me.GroupBox178.Controls.Add(Me.Label248)
        Me.GroupBox178.Controls.Add(Me.txt_cmd_multi)
        Me.GroupBox178.Controls.Add(Me.btn_send_multi)
        Me.GroupBox178.Controls.Add(Me.txt_respond_multi)
        Me.GroupBox178.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox178.Location = New System.Drawing.Point(497, 158)
        Me.GroupBox178.Name = "GroupBox178"
        Me.GroupBox178.Size = New System.Drawing.Size(235, 146)
        Me.GroupBox178.TabIndex = 61
        Me.GroupBox178.TabStop = False
        Me.GroupBox178.Text = "Check Connection"
        '
        'Label236
        '
        Me.Label236.AutoSize = True
        Me.Label236.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label236.Location = New System.Drawing.Point(6, 34)
        Me.Label236.Name = "Label236"
        Me.Label236.Size = New System.Drawing.Size(90, 20)
        Me.Label236.TabIndex = 1
        Me.Label236.Text = "Command :"
        '
        'Label248
        '
        Me.Label248.AutoSize = True
        Me.Label248.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label248.Location = New System.Drawing.Point(14, 64)
        Me.Label248.Name = "Label248"
        Me.Label248.Size = New System.Drawing.Size(82, 20)
        Me.Label248.TabIndex = 1
        Me.Label248.Text = "Respond :"
        '
        'txt_cmd_multi
        '
        Me.txt_cmd_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cmd_multi.Location = New System.Drawing.Point(102, 30)
        Me.txt_cmd_multi.Name = "txt_cmd_multi"
        Me.txt_cmd_multi.Size = New System.Drawing.Size(123, 26)
        Me.txt_cmd_multi.TabIndex = 2
        '
        'btn_send_multi
        '
        Me.btn_send_multi.AutoSize = True
        Me.btn_send_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send_multi.Location = New System.Drawing.Point(12, 99)
        Me.btn_send_multi.Name = "btn_send_multi"
        Me.btn_send_multi.Size = New System.Drawing.Size(102, 35)
        Me.btn_send_multi.TabIndex = 4
        Me.btn_send_multi.Text = "Send"
        Me.btn_send_multi.UseVisualStyleBackColor = True
        '
        'txt_respond_multi
        '
        Me.txt_respond_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_respond_multi.Location = New System.Drawing.Point(102, 63)
        Me.txt_respond_multi.Name = "txt_respond_multi"
        Me.txt_respond_multi.Size = New System.Drawing.Size(123, 26)
        Me.txt_respond_multi.TabIndex = 3
        '
        'GroupBox170
        '
        Me.GroupBox170.Controls.Add(Me.Label229)
        Me.GroupBox170.Controls.Add(Me.txt_ch_1)
        Me.GroupBox170.Controls.Add(Me.btn_read_ch_1)
        Me.GroupBox170.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox170.Location = New System.Drawing.Point(102, 157)
        Me.GroupBox170.Name = "GroupBox170"
        Me.GroupBox170.Size = New System.Drawing.Size(235, 120)
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
        Me.Label229.Size = New System.Drawing.Size(58, 20)
        Me.Label229.TabIndex = 1
        Me.Label229.Text = "Value :"
        '
        'txt_ch_1
        '
        Me.txt_ch_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ch_1.Location = New System.Drawing.Point(102, 30)
        Me.txt_ch_1.Name = "txt_ch_1"
        Me.txt_ch_1.Size = New System.Drawing.Size(123, 26)
        Me.txt_ch_1.TabIndex = 2
        '
        'btn_read_ch_1
        '
        Me.btn_read_ch_1.AutoSize = True
        Me.btn_read_ch_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read_ch_1.Location = New System.Drawing.Point(15, 72)
        Me.btn_read_ch_1.Name = "btn_read_ch_1"
        Me.btn_read_ch_1.Size = New System.Drawing.Size(102, 35)
        Me.btn_read_ch_1.TabIndex = 4
        Me.btn_read_ch_1.Text = "Read"
        Me.btn_read_ch_1.UseVisualStyleBackColor = True
        '
        'pnl_alarm
        '
        Me.pnl_alarm.Controls.Add(Me.TabPage15)
        Me.pnl_alarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_alarm.Location = New System.Drawing.Point(78, 87)
        Me.pnl_alarm.Name = "pnl_alarm"
        Me.pnl_alarm.SelectedIndex = 0
        Me.pnl_alarm.Size = New System.Drawing.Size(853, 558)
        Me.pnl_alarm.TabIndex = 107
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(Me.txt_alarm)
        Me.TabPage15.Controls.Add(Me.GroupBox184)
        Me.TabPage15.Controls.Add(Me.GroupBox84)
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
        'txt_alarm
        '
        Me.txt_alarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alarm.Location = New System.Drawing.Point(26, 20)
        Me.txt_alarm.Multiline = True
        Me.txt_alarm.Name = "txt_alarm"
        Me.txt_alarm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_alarm.Size = New System.Drawing.Size(393, 478)
        Me.txt_alarm.TabIndex = 63
        '
        'GroupBox184
        '
        Me.GroupBox184.Controls.Add(Me.ind_laser_err_emg)
        Me.GroupBox184.Controls.Add(Me.ind_pos_servo_st4)
        Me.GroupBox184.Controls.Add(Me.ind_pos_servo_st3)
        Me.GroupBox184.Controls.Add(Me.ind_conn_servo_st4)
        Me.GroupBox184.Controls.Add(Me.Label315)
        Me.GroupBox184.Controls.Add(Me.ind_conn_servo_st3)
        Me.GroupBox184.Controls.Add(Me.Label314)
        Me.GroupBox184.Controls.Add(Me.Label320)
        Me.GroupBox184.Controls.Add(Me.Label313)
        Me.GroupBox184.Controls.Add(Me.Label321)
        Me.GroupBox184.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox184.Location = New System.Drawing.Point(646, 276)
        Me.GroupBox184.Name = "GroupBox184"
        Me.GroupBox184.Size = New System.Drawing.Size(193, 222)
        Me.GroupBox184.TabIndex = 59
        Me.GroupBox184.TabStop = False
        Me.GroupBox184.Text = "Other"
        '
        'ind_laser_err_emg
        '
        Me.ind_laser_err_emg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_laser_err_emg.Location = New System.Drawing.Point(14, 117)
        Me.ind_laser_err_emg.Name = "ind_laser_err_emg"
        Me.ind_laser_err_emg.Size = New System.Drawing.Size(15, 15)
        Me.ind_laser_err_emg.TabIndex = 33
        Me.ind_laser_err_emg.TabStop = False
        '
        'ind_pos_servo_st4
        '
        Me.ind_pos_servo_st4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_pos_servo_st4.Location = New System.Drawing.Point(14, 96)
        Me.ind_pos_servo_st4.Name = "ind_pos_servo_st4"
        Me.ind_pos_servo_st4.Size = New System.Drawing.Size(15, 15)
        Me.ind_pos_servo_st4.TabIndex = 33
        Me.ind_pos_servo_st4.TabStop = False
        '
        'ind_pos_servo_st3
        '
        Me.ind_pos_servo_st3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_pos_servo_st3.Location = New System.Drawing.Point(14, 54)
        Me.ind_pos_servo_st3.Name = "ind_pos_servo_st3"
        Me.ind_pos_servo_st3.Size = New System.Drawing.Size(15, 15)
        Me.ind_pos_servo_st3.TabIndex = 33
        Me.ind_pos_servo_st3.TabStop = False
        '
        'ind_conn_servo_st4
        '
        Me.ind_conn_servo_st4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_conn_servo_st4.Location = New System.Drawing.Point(14, 75)
        Me.ind_conn_servo_st4.Name = "ind_conn_servo_st4"
        Me.ind_conn_servo_st4.Size = New System.Drawing.Size(15, 15)
        Me.ind_conn_servo_st4.TabIndex = 33
        Me.ind_conn_servo_st4.TabStop = False
        '
        'Label315
        '
        Me.Label315.AutoSize = True
        Me.Label315.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label315.Location = New System.Drawing.Point(35, 114)
        Me.Label315.Name = "Label315"
        Me.Label315.Size = New System.Drawing.Size(111, 20)
        Me.Label315.TabIndex = 31
        Me.Label315.Text = "Laser Err/Emg"
        '
        'ind_conn_servo_st3
        '
        Me.ind_conn_servo_st3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_conn_servo_st3.Location = New System.Drawing.Point(14, 33)
        Me.ind_conn_servo_st3.Name = "ind_conn_servo_st3"
        Me.ind_conn_servo_st3.Size = New System.Drawing.Size(15, 15)
        Me.ind_conn_servo_st3.TabIndex = 33
        Me.ind_conn_servo_st3.TabStop = False
        '
        'Label314
        '
        Me.Label314.AutoSize = True
        Me.Label314.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label314.Location = New System.Drawing.Point(35, 93)
        Me.Label314.Name = "Label314"
        Me.Label314.Size = New System.Drawing.Size(98, 20)
        Me.Label314.TabIndex = 31
        Me.Label314.Text = "Position ST4"
        '
        'Label320
        '
        Me.Label320.AutoSize = True
        Me.Label320.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label320.Location = New System.Drawing.Point(35, 51)
        Me.Label320.Name = "Label320"
        Me.Label320.Size = New System.Drawing.Size(98, 20)
        Me.Label320.TabIndex = 31
        Me.Label320.Text = "Position ST3"
        '
        'Label313
        '
        Me.Label313.AutoSize = True
        Me.Label313.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label313.Location = New System.Drawing.Point(35, 72)
        Me.Label313.Name = "Label313"
        Me.Label313.Size = New System.Drawing.Size(123, 20)
        Me.Label313.TabIndex = 31
        Me.Label313.Text = "Connection ST4"
        '
        'Label321
        '
        Me.Label321.AutoSize = True
        Me.Label321.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label321.Location = New System.Drawing.Point(35, 30)
        Me.Label321.Name = "Label321"
        Me.Label321.Size = New System.Drawing.Size(123, 20)
        Me.Label321.TabIndex = 31
        Me.Label321.Text = "Connection ST3"
        '
        'GroupBox84
        '
        Me.GroupBox84.Controls.Add(Me.ind_v606_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v604_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v602_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v504_descrepancy)
        Me.GroupBox84.Controls.Add(Me.Label309)
        Me.GroupBox84.Controls.Add(Me.Label307)
        Me.GroupBox84.Controls.Add(Me.Label94)
        Me.GroupBox84.Controls.Add(Me.ind_v503_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v605_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v603_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v601_descrepancy)
        Me.GroupBox84.Controls.Add(Me.ind_v502_descrepancy)
        Me.GroupBox84.Controls.Add(Me.Label308)
        Me.GroupBox84.Controls.Add(Me.Label306)
        Me.GroupBox84.Controls.Add(Me.Label96)
        Me.GroupBox84.Controls.Add(Me.Label305)
        Me.GroupBox84.Controls.Add(Me.Label304)
        Me.GroupBox84.Controls.Add(Me.Label92)
        Me.GroupBox84.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox84.Location = New System.Drawing.Point(646, 12)
        Me.GroupBox84.Name = "GroupBox84"
        Me.GroupBox84.Size = New System.Drawing.Size(193, 257)
        Me.GroupBox84.TabIndex = 59
        Me.GroupBox84.TabStop = False
        Me.GroupBox84.Text = "Alarm Cylinder"
        '
        'ind_v606_descrepancy
        '
        Me.ind_v606_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v606_descrepancy.Location = New System.Drawing.Point(14, 200)
        Me.ind_v606_descrepancy.Name = "ind_v606_descrepancy"
        Me.ind_v606_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v606_descrepancy.TabIndex = 33
        Me.ind_v606_descrepancy.TabStop = False
        '
        'ind_v604_descrepancy
        '
        Me.ind_v604_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v604_descrepancy.Location = New System.Drawing.Point(14, 159)
        Me.ind_v604_descrepancy.Name = "ind_v604_descrepancy"
        Me.ind_v604_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v604_descrepancy.TabIndex = 33
        Me.ind_v604_descrepancy.TabStop = False
        '
        'ind_v602_descrepancy
        '
        Me.ind_v602_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v602_descrepancy.Location = New System.Drawing.Point(14, 117)
        Me.ind_v602_descrepancy.Name = "ind_v602_descrepancy"
        Me.ind_v602_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v602_descrepancy.TabIndex = 33
        Me.ind_v602_descrepancy.TabStop = False
        '
        'ind_v504_descrepancy
        '
        Me.ind_v504_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v504_descrepancy.Location = New System.Drawing.Point(14, 75)
        Me.ind_v504_descrepancy.Name = "ind_v504_descrepancy"
        Me.ind_v504_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v504_descrepancy.TabIndex = 33
        Me.ind_v504_descrepancy.TabStop = False
        '
        'Label309
        '
        Me.Label309.AutoSize = True
        Me.Label309.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label309.Location = New System.Drawing.Point(35, 197)
        Me.Label309.Name = "Label309"
        Me.Label309.Size = New System.Drawing.Size(144, 20)
        Me.Label309.TabIndex = 31
        Me.Label309.Text = "V606 Descrepancy"
        '
        'Label307
        '
        Me.Label307.AutoSize = True
        Me.Label307.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label307.Location = New System.Drawing.Point(35, 156)
        Me.Label307.Name = "Label307"
        Me.Label307.Size = New System.Drawing.Size(144, 20)
        Me.Label307.TabIndex = 31
        Me.Label307.Text = "V604 Descrepancy"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(35, 114)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(144, 20)
        Me.Label94.TabIndex = 31
        Me.Label94.Text = "V602 Descrepancy"
        '
        'ind_v503_descrepancy
        '
        Me.ind_v503_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v503_descrepancy.Location = New System.Drawing.Point(14, 54)
        Me.ind_v503_descrepancy.Name = "ind_v503_descrepancy"
        Me.ind_v503_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v503_descrepancy.TabIndex = 33
        Me.ind_v503_descrepancy.TabStop = False
        '
        'ind_v605_descrepancy
        '
        Me.ind_v605_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v605_descrepancy.Location = New System.Drawing.Point(14, 179)
        Me.ind_v605_descrepancy.Name = "ind_v605_descrepancy"
        Me.ind_v605_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v605_descrepancy.TabIndex = 33
        Me.ind_v605_descrepancy.TabStop = False
        '
        'ind_v603_descrepancy
        '
        Me.ind_v603_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v603_descrepancy.Location = New System.Drawing.Point(14, 138)
        Me.ind_v603_descrepancy.Name = "ind_v603_descrepancy"
        Me.ind_v603_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v603_descrepancy.TabIndex = 33
        Me.ind_v603_descrepancy.TabStop = False
        '
        'ind_v601_descrepancy
        '
        Me.ind_v601_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v601_descrepancy.Location = New System.Drawing.Point(14, 96)
        Me.ind_v601_descrepancy.Name = "ind_v601_descrepancy"
        Me.ind_v601_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v601_descrepancy.TabIndex = 33
        Me.ind_v601_descrepancy.TabStop = False
        '
        'ind_v502_descrepancy
        '
        Me.ind_v502_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v502_descrepancy.Location = New System.Drawing.Point(14, 33)
        Me.ind_v502_descrepancy.Name = "ind_v502_descrepancy"
        Me.ind_v502_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v502_descrepancy.TabIndex = 33
        Me.ind_v502_descrepancy.TabStop = False
        '
        'Label308
        '
        Me.Label308.AutoSize = True
        Me.Label308.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label308.Location = New System.Drawing.Point(35, 176)
        Me.Label308.Name = "Label308"
        Me.Label308.Size = New System.Drawing.Size(144, 20)
        Me.Label308.TabIndex = 31
        Me.Label308.Text = "V605 Descrepancy"
        '
        'Label306
        '
        Me.Label306.AutoSize = True
        Me.Label306.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label306.Location = New System.Drawing.Point(35, 135)
        Me.Label306.Name = "Label306"
        Me.Label306.Size = New System.Drawing.Size(144, 20)
        Me.Label306.TabIndex = 31
        Me.Label306.Text = "V603 Descrepancy"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(35, 93)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(144, 20)
        Me.Label96.TabIndex = 31
        Me.Label96.Text = "V601 Descrepancy"
        '
        'Label305
        '
        Me.Label305.AutoSize = True
        Me.Label305.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label305.Location = New System.Drawing.Point(35, 72)
        Me.Label305.Name = "Label305"
        Me.Label305.Size = New System.Drawing.Size(144, 20)
        Me.Label305.TabIndex = 31
        Me.Label305.Text = "V504 Descrepancy"
        '
        'Label304
        '
        Me.Label304.AutoSize = True
        Me.Label304.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label304.Location = New System.Drawing.Point(35, 51)
        Me.Label304.Name = "Label304"
        Me.Label304.Size = New System.Drawing.Size(144, 20)
        Me.Label304.TabIndex = 31
        Me.Label304.Text = "V503 Descrepancy"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(35, 30)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(144, 20)
        Me.Label92.TabIndex = 31
        Me.Label92.Text = "V502 Descrepancy"
        '
        'GroupBox81
        '
        Me.GroupBox81.Controls.Add(Me.ind_v402_descrepancy)
        Me.GroupBox81.Controls.Add(Me.ind_v302_descrepancy)
        Me.GroupBox81.Controls.Add(Me.ind_v501_descrepancy)
        Me.GroupBox81.Controls.Add(Me.Label89)
        Me.GroupBox81.Controls.Add(Me.Label93)
        Me.GroupBox81.Controls.Add(Me.ind_v203_descrepancy)
        Me.GroupBox81.Controls.Add(Me.ind_v401_descrepancy)
        Me.GroupBox81.Controls.Add(Me.Label87)
        Me.GroupBox81.Controls.Add(Me.Label90)
        Me.GroupBox81.Controls.Add(Me.ind_v202_descrepancy)
        Me.GroupBox81.Controls.Add(Me.ind_v301_descrepancy)
        Me.GroupBox81.Controls.Add(Me.labelaaa)
        Me.GroupBox81.Controls.Add(Me.Label88)
        Me.GroupBox81.Controls.Add(Me.Label91)
        Me.GroupBox81.Controls.Add(Me.ind_v101_descrepancy)
        Me.GroupBox81.Controls.Add(Me.ind_v201_descrepancy)
        Me.GroupBox81.Controls.Add(Me.Label299)
        Me.GroupBox81.Controls.Add(Me.Label95)
        Me.GroupBox81.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox81.Location = New System.Drawing.Point(431, 276)
        Me.GroupBox81.Name = "GroupBox81"
        Me.GroupBox81.Size = New System.Drawing.Size(205, 222)
        Me.GroupBox81.TabIndex = 61
        Me.GroupBox81.TabStop = False
        Me.GroupBox81.Text = "Alarm Cylinder"
        '
        'ind_v402_descrepancy
        '
        Me.ind_v402_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v402_descrepancy.Location = New System.Drawing.Point(16, 177)
        Me.ind_v402_descrepancy.Name = "ind_v402_descrepancy"
        Me.ind_v402_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v402_descrepancy.TabIndex = 33
        Me.ind_v402_descrepancy.TabStop = False
        '
        'ind_v302_descrepancy
        '
        Me.ind_v302_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v302_descrepancy.Location = New System.Drawing.Point(16, 135)
        Me.ind_v302_descrepancy.Name = "ind_v302_descrepancy"
        Me.ind_v302_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v302_descrepancy.TabIndex = 33
        Me.ind_v302_descrepancy.TabStop = False
        '
        'ind_v501_descrepancy
        '
        Me.ind_v501_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v501_descrepancy.Location = New System.Drawing.Point(16, 198)
        Me.ind_v501_descrepancy.Name = "ind_v501_descrepancy"
        Me.ind_v501_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v501_descrepancy.TabIndex = 33
        Me.ind_v501_descrepancy.TabStop = False
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(37, 174)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(144, 20)
        Me.Label89.TabIndex = 31
        Me.Label89.Text = "V402 Descrepancy"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(37, 195)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(144, 20)
        Me.Label93.TabIndex = 31
        Me.Label93.Text = "V501 Descrepancy"
        '
        'ind_v203_descrepancy
        '
        Me.ind_v203_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v203_descrepancy.Location = New System.Drawing.Point(16, 93)
        Me.ind_v203_descrepancy.Name = "ind_v203_descrepancy"
        Me.ind_v203_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v203_descrepancy.TabIndex = 33
        Me.ind_v203_descrepancy.TabStop = False
        '
        'ind_v401_descrepancy
        '
        Me.ind_v401_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v401_descrepancy.Location = New System.Drawing.Point(16, 156)
        Me.ind_v401_descrepancy.Name = "ind_v401_descrepancy"
        Me.ind_v401_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v401_descrepancy.TabIndex = 33
        Me.ind_v401_descrepancy.TabStop = False
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(37, 132)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(144, 20)
        Me.Label87.TabIndex = 31
        Me.Label87.Text = "V302 Descrepancy"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(37, 153)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(144, 20)
        Me.Label90.TabIndex = 31
        Me.Label90.Text = "V401 Descrepancy"
        '
        'ind_v202_descrepancy
        '
        Me.ind_v202_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v202_descrepancy.Location = New System.Drawing.Point(16, 71)
        Me.ind_v202_descrepancy.Name = "ind_v202_descrepancy"
        Me.ind_v202_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v202_descrepancy.TabIndex = 33
        Me.ind_v202_descrepancy.TabStop = False
        '
        'ind_v301_descrepancy
        '
        Me.ind_v301_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v301_descrepancy.Location = New System.Drawing.Point(16, 114)
        Me.ind_v301_descrepancy.Name = "ind_v301_descrepancy"
        Me.ind_v301_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v301_descrepancy.TabIndex = 33
        Me.ind_v301_descrepancy.TabStop = False
        '
        'labelaaa
        '
        Me.labelaaa.AutoSize = True
        Me.labelaaa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelaaa.Location = New System.Drawing.Point(37, 90)
        Me.labelaaa.Name = "labelaaa"
        Me.labelaaa.Size = New System.Drawing.Size(144, 20)
        Me.labelaaa.TabIndex = 31
        Me.labelaaa.Text = "V203 Descrepancy"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(37, 111)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(144, 20)
        Me.Label88.TabIndex = 31
        Me.Label88.Text = "V301 Descrepancy"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(37, 68)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(144, 20)
        Me.Label91.TabIndex = 31
        Me.Label91.Text = "V202 Descrepancy"
        '
        'ind_v101_descrepancy
        '
        Me.ind_v101_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v101_descrepancy.Location = New System.Drawing.Point(16, 28)
        Me.ind_v101_descrepancy.Name = "ind_v101_descrepancy"
        Me.ind_v101_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v101_descrepancy.TabIndex = 33
        Me.ind_v101_descrepancy.TabStop = False
        '
        'ind_v201_descrepancy
        '
        Me.ind_v201_descrepancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_v201_descrepancy.Location = New System.Drawing.Point(16, 50)
        Me.ind_v201_descrepancy.Name = "ind_v201_descrepancy"
        Me.ind_v201_descrepancy.Size = New System.Drawing.Size(15, 15)
        Me.ind_v201_descrepancy.TabIndex = 33
        Me.ind_v201_descrepancy.TabStop = False
        '
        'Label299
        '
        Me.Label299.AutoSize = True
        Me.Label299.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label299.Location = New System.Drawing.Point(37, 25)
        Me.Label299.Name = "Label299"
        Me.Label299.Size = New System.Drawing.Size(144, 20)
        Me.Label299.TabIndex = 31
        Me.Label299.Text = "V101 Descrepancy"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(37, 47)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(144, 20)
        Me.Label95.TabIndex = 31
        Me.Label95.Text = "V201 Descrepancy"
        '
        'GroupBox79
        '
        Me.GroupBox79.Controls.Add(Me.ind_safety_curtain)
        Me.GroupBox79.Controls.Add(Me.ind_emg_button)
        Me.GroupBox79.Controls.Add(Me.ind_door_lock_6)
        Me.GroupBox79.Controls.Add(Me.ind_altivar_fault)
        Me.GroupBox79.Controls.Add(Me.Label230)
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
        Me.GroupBox79.Location = New System.Drawing.Point(431, 12)
        Me.GroupBox79.Name = "GroupBox79"
        Me.GroupBox79.Size = New System.Drawing.Size(205, 257)
        Me.GroupBox79.TabIndex = 62
        Me.GroupBox79.TabStop = False
        Me.GroupBox79.Text = "Alarm General"
        '
        'ind_safety_curtain
        '
        Me.ind_safety_curtain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_safety_curtain.Location = New System.Drawing.Point(16, 220)
        Me.ind_safety_curtain.Name = "ind_safety_curtain"
        Me.ind_safety_curtain.Size = New System.Drawing.Size(15, 15)
        Me.ind_safety_curtain.TabIndex = 33
        Me.ind_safety_curtain.TabStop = False
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
        'Label230
        '
        Me.Label230.AutoSize = True
        Me.Label230.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label230.Location = New System.Drawing.Point(37, 217)
        Me.Label230.Name = "Label230"
        Me.Label230.Size = New System.Drawing.Size(110, 20)
        Me.Label230.TabIndex = 31
        Me.Label230.Text = "Safety Curtain"
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
        Me.pnl_mon_stn6.Location = New System.Drawing.Point(78, 87)
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
        Me.pnl_mon_stn5.Location = New System.Drawing.Point(78, 87)
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
        Me.pnl_mon_stn4.Location = New System.Drawing.Point(78, 87)
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
        Me.pnl_mon_stn3.Location = New System.Drawing.Point(78, 87)
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
        Me.pnl_mon_stn2.Location = New System.Drawing.Point(78, 87)
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
        Me.pnl_mon_stn1.Location = New System.Drawing.Point(78, 87)
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
        'ChromaComm
        '
        Me.ChromaComm.BaudRate = 19200
        Me.ChromaComm.PortName = "COM8"
        '
        'pnl_calibration
        '
        Me.pnl_calibration.Controls.Add(Me.TabPage22)
        Me.pnl_calibration.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_calibration.Location = New System.Drawing.Point(78, 86)
        Me.pnl_calibration.Name = "pnl_calibration"
        Me.pnl_calibration.SelectedIndex = 0
        Me.pnl_calibration.Size = New System.Drawing.Size(852, 564)
        Me.pnl_calibration.TabIndex = 114
        '
        'TabPage22
        '
        Me.TabPage22.Controls.Add(Me.dgv_calibration)
        Me.TabPage22.Controls.Add(Me.btn_save_calib)
        Me.TabPage22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage22.Location = New System.Drawing.Point(4, 38)
        Me.TabPage22.Name = "TabPage22"
        Me.TabPage22.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage22.Size = New System.Drawing.Size(844, 522)
        Me.TabPage22.TabIndex = 0
        Me.TabPage22.Text = "Dummy Calibration"
        Me.TabPage22.UseVisualStyleBackColor = True
        '
        'dgv_calibration
        '
        Me.dgv_calibration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_calibration.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_calibration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_calibration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parameter, Me.Value})
        Me.dgv_calibration.Location = New System.Drawing.Point(279, 67)
        Me.dgv_calibration.Name = "dgv_calibration"
        Me.dgv_calibration.Size = New System.Drawing.Size(337, 150)
        Me.dgv_calibration.TabIndex = 68
        '
        'Parameter
        '
        Me.Parameter.HeaderText = "Parameter"
        Me.Parameter.Name = "Parameter"
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        '
        'btn_save_calib
        '
        Me.btn_save_calib.FlatAppearance.BorderSize = 0
        Me.btn_save_calib.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_calib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_calib.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save_calib.Image = Global.TESTER.My.Resources.Resources.icons8_save_56
        Me.btn_save_calib.Location = New System.Drawing.Point(740, 402)
        Me.btn_save_calib.Name = "btn_save_calib"
        Me.btn_save_calib.Size = New System.Drawing.Size(75, 90)
        Me.btn_save_calib.TabIndex = 67
        Me.btn_save_calib.Text = "Save"
        Me.btn_save_calib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_save_calib.UseVisualStyleBackColor = True
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
        'MC_Status
        '
        Me.MC_Status.Image = Global.TESTER.My.Resources.Resources.mark_ok
        Me.MC_Status.Location = New System.Drawing.Point(811, 2)
        Me.MC_Status.Name = "MC_Status"
        Me.MC_Status.Size = New System.Drawing.Size(79, 79)
        Me.MC_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MC_Status.TabIndex = 116
        Me.MC_Status.TabStop = False
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
        'btn_calib
        '
        Me.btn_calib.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_calib.FlatAppearance.BorderSize = 0
        Me.btn_calib.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calib.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_calib.Image = Global.TESTER.My.Resources.Resources.icons8_check_document_56
        Me.btn_calib.Location = New System.Drawing.Point(937, 548)
        Me.btn_calib.Name = "btn_calib"
        Me.btn_calib.Size = New System.Drawing.Size(60, 87)
        Me.btn_calib.TabIndex = 69
        Me.btn_calib.Text = "Calib"
        Me.btn_calib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_calib.UseVisualStyleBackColor = False
        Me.btn_calib.Visible = False
        '
        'btn_user
        '
        Me.btn_user.FlatAppearance.BorderSize = 0
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_user.Image = Global.TESTER.My.Resources.Resources.icons8_padlock_24
        Me.btn_user.Location = New System.Drawing.Point(926, 12)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(50, 50)
        Me.btn_user.TabIndex = 65
        Me.btn_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_user.UseVisualStyleBackColor = True
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
        'btn_setting
        '
        Me.btn_setting.FlatAppearance.BorderSize = 0
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_setting.Image = Global.TESTER.My.Resources.Resources.icons8_setting_56
        Me.btn_setting.Location = New System.Drawing.Point(10, 504)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(60, 87)
        Me.btn_setting.TabIndex = 69
        Me.btn_setting.Text = "Setting"
        Me.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_setting.UseVisualStyleBackColor = True
        '
        'btn_alarm
        '
        Me.btn_alarm.FlatAppearance.BorderSize = 0
        Me.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alarm.Image = Global.TESTER.My.Resources.Resources.icons8_siren_56
        Me.btn_alarm.Location = New System.Drawing.Point(1, 338)
        Me.btn_alarm.Name = "btn_alarm"
        Me.btn_alarm.Size = New System.Drawing.Size(75, 90)
        Me.btn_alarm.TabIndex = 69
        Me.btn_alarm.Text = "Alarm"
        Me.btn_alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_alarm.UseVisualStyleBackColor = True
        '
        'btn_laser
        '
        Me.btn_laser.FlatAppearance.BorderSize = 0
        Me.btn_laser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_laser.Image = Global.TESTER.My.Resources.Resources.icons8_laser_56
        Me.btn_laser.Location = New System.Drawing.Point(922, 645)
        Me.btn_laser.Name = "btn_laser"
        Me.btn_laser.Size = New System.Drawing.Size(92, 90)
        Me.btn_laser.TabIndex = 69
        Me.btn_laser.Text = "Laser Mark"
        Me.btn_laser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_laser.UseVisualStyleBackColor = True
        Me.btn_laser.Visible = False
        '
        'btn_ref
        '
        Me.btn_ref.FlatAppearance.BorderSize = 0
        Me.btn_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ref.Image = Global.TESTER.My.Resources.Resources.icons8_open_book_56
        Me.btn_ref.Location = New System.Drawing.Point(-8, 256)
        Me.btn_ref.Name = "btn_ref"
        Me.btn_ref.Size = New System.Drawing.Size(95, 90)
        Me.btn_ref.TabIndex = 69
        Me.btn_ref.Text = "References"
        Me.btn_ref.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ref.UseVisualStyleBackColor = True
        '
        'btn_multimeter
        '
        Me.btn_multimeter.FlatAppearance.BorderSize = 0
        Me.btn_multimeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multimeter.Image = Global.TESTER.My.Resources.Resources.icons8_multimeter_56
        Me.btn_multimeter.Location = New System.Drawing.Point(776, 649)
        Me.btn_multimeter.Name = "btn_multimeter"
        Me.btn_multimeter.Size = New System.Drawing.Size(87, 79)
        Me.btn_multimeter.TabIndex = 69
        Me.btn_multimeter.Text = "Ohm Meter"
        Me.btn_multimeter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_multimeter.UseVisualStyleBackColor = True
        Me.btn_multimeter.Visible = False
        '
        'btn_monitoring
        '
        Me.btn_monitoring.FlatAppearance.BorderSize = 0
        Me.btn_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_monitoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_monitoring.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_monitoring.Image = Global.TESTER.My.Resources.Resources.icons8_monitor_56
        Me.btn_monitoring.Location = New System.Drawing.Point(851, 646)
        Me.btn_monitoring.Name = "btn_monitoring"
        Me.btn_monitoring.Size = New System.Drawing.Size(80, 90)
        Me.btn_monitoring.TabIndex = 68
        Me.btn_monitoring.Text = "Monitor"
        Me.btn_monitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_monitoring.UseVisualStyleBackColor = True
        Me.btn_monitoring.Visible = False
        '
        'btn_manual
        '
        Me.btn_manual.FlatAppearance.BorderSize = 0
        Me.btn_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_manual.Image = Global.TESTER.My.Resources.Resources.icons8_manual_56
        Me.btn_manual.Location = New System.Drawing.Point(1, 171)
        Me.btn_manual.Name = "btn_manual"
        Me.btn_manual.Size = New System.Drawing.Size(75, 90)
        Me.btn_manual.TabIndex = 67
        Me.btn_manual.Text = "Manual"
        Me.btn_manual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_manual.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_home.Image = Global.TESTER.My.Resources.Resources.icons8_home_56
        Me.btn_home.Location = New System.Drawing.Point(0, 94)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 90)
        Me.btn_home.TabIndex = 66
        Me.btn_home.Text = "Home"
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_log
        '
        Me.btn_log.FlatAppearance.BorderSize = 0
        Me.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log.Image = Global.TESTER.My.Resources.Resources.icons8_log_56
        Me.btn_log.Location = New System.Drawing.Point(-4, 421)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(87, 86)
        Me.btn_log.TabIndex = 69
        Me.btn_log.Text = "Log"
        Me.btn_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'TabPage26
        '
        Me.TabPage26.Controls.Add(Me.txt_st2_punch_cycle)
        Me.TabPage26.Controls.Add(Me.txt_st2_cal_val_6)
        Me.TabPage26.Controls.Add(Me.txt_st2_cal_val_5)
        Me.TabPage26.Controls.Add(Me.txt_st2_cal_val_4)
        Me.TabPage26.Controls.Add(Me.txt_st2_cal_val_3)
        Me.TabPage26.Controls.Add(Me.txt_st2_cal_val_2)
        Me.TabPage26.Controls.Add(Me.txt_st2_cal_val_1)
        Me.TabPage26.Controls.Add(Me.txt_st2_punch_count)
        Me.TabPage26.Controls.Add(Me.txt_st2_act_mea)
        Me.TabPage26.Controls.Add(Me.btn_st2_auto_caib)
        Me.TabPage26.Controls.Add(Me.btn_st2_set_cal_val)
        Me.TabPage26.Controls.Add(Me.btn_st2_preset_heidenhain)
        Me.TabPage26.Controls.Add(Me.btn_st2_stop_punch)
        Me.TabPage26.Controls.Add(Me.Label330)
        Me.TabPage26.Controls.Add(Me.btn_st2_start_punch)
        Me.TabPage26.Controls.Add(Me.Label329)
        Me.TabPage26.Controls.Add(Me.btn_st2_enable_heidenhain)
        Me.TabPage26.Controls.Add(Me.Label328)
        Me.TabPage26.Controls.Add(Me.Label279)
        Me.TabPage26.Controls.Add(Me.Label327)
        Me.TabPage26.Controls.Add(Me.Label282)
        Me.TabPage26.Controls.Add(Me.Label326)
        Me.TabPage26.Controls.Add(Me.Label303)
        Me.TabPage26.Controls.Add(Me.Label325)
        Me.TabPage26.Controls.Add(Me.Label286)
        Me.TabPage26.Controls.Add(Me.Label302)
        Me.TabPage26.Controls.Add(Me.Label287)
        Me.TabPage26.Controls.Add(Me.Label289)
        Me.TabPage26.Controls.Add(Me.ind_st2_motor_status)
        Me.TabPage26.Controls.Add(Me.ind_st2_heidenhain_error)
        Me.TabPage26.Controls.Add(Me.ind_st2_heidenhain_valid)
        Me.TabPage26.Location = New System.Drawing.Point(4, 38)
        Me.TabPage26.Name = "TabPage26"
        Me.TabPage26.Size = New System.Drawing.Size(845, 521)
        Me.TabPage26.TabIndex = 1
        Me.TabPage26.Text = "Puncher / Heidenhain"
        Me.TabPage26.UseVisualStyleBackColor = True
        '
        'txt_st2_punch_cycle
        '
        Me.txt_st2_punch_cycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_punch_cycle.Location = New System.Drawing.Point(601, 257)
        Me.txt_st2_punch_cycle.Name = "txt_st2_punch_cycle"
        Me.txt_st2_punch_cycle.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_punch_cycle.TabIndex = 94
        '
        'txt_st2_cal_val_6
        '
        Me.txt_st2_cal_val_6.Enabled = False
        Me.txt_st2_cal_val_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_cal_val_6.Location = New System.Drawing.Point(344, 282)
        Me.txt_st2_cal_val_6.Name = "txt_st2_cal_val_6"
        Me.txt_st2_cal_val_6.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_cal_val_6.TabIndex = 94
        '
        'txt_st2_cal_val_5
        '
        Me.txt_st2_cal_val_5.Enabled = False
        Me.txt_st2_cal_val_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_cal_val_5.Location = New System.Drawing.Point(344, 250)
        Me.txt_st2_cal_val_5.Name = "txt_st2_cal_val_5"
        Me.txt_st2_cal_val_5.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_cal_val_5.TabIndex = 94
        '
        'txt_st2_cal_val_4
        '
        Me.txt_st2_cal_val_4.Enabled = False
        Me.txt_st2_cal_val_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_cal_val_4.Location = New System.Drawing.Point(344, 218)
        Me.txt_st2_cal_val_4.Name = "txt_st2_cal_val_4"
        Me.txt_st2_cal_val_4.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_cal_val_4.TabIndex = 94
        '
        'txt_st2_cal_val_3
        '
        Me.txt_st2_cal_val_3.Enabled = False
        Me.txt_st2_cal_val_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_cal_val_3.Location = New System.Drawing.Point(344, 186)
        Me.txt_st2_cal_val_3.Name = "txt_st2_cal_val_3"
        Me.txt_st2_cal_val_3.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_cal_val_3.TabIndex = 94
        '
        'txt_st2_cal_val_2
        '
        Me.txt_st2_cal_val_2.Enabled = False
        Me.txt_st2_cal_val_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_cal_val_2.Location = New System.Drawing.Point(344, 154)
        Me.txt_st2_cal_val_2.Name = "txt_st2_cal_val_2"
        Me.txt_st2_cal_val_2.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_cal_val_2.TabIndex = 94
        '
        'txt_st2_cal_val_1
        '
        Me.txt_st2_cal_val_1.Enabled = False
        Me.txt_st2_cal_val_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_cal_val_1.Location = New System.Drawing.Point(344, 122)
        Me.txt_st2_cal_val_1.Name = "txt_st2_cal_val_1"
        Me.txt_st2_cal_val_1.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_cal_val_1.TabIndex = 94
        '
        'txt_st2_punch_count
        '
        Me.txt_st2_punch_count.Enabled = False
        Me.txt_st2_punch_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_punch_count.Location = New System.Drawing.Point(600, 364)
        Me.txt_st2_punch_count.Name = "txt_st2_punch_count"
        Me.txt_st2_punch_count.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_punch_count.TabIndex = 93
        '
        'txt_st2_act_mea
        '
        Me.txt_st2_act_mea.Enabled = False
        Me.txt_st2_act_mea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_st2_act_mea.Location = New System.Drawing.Point(601, 79)
        Me.txt_st2_act_mea.Name = "txt_st2_act_mea"
        Me.txt_st2_act_mea.Size = New System.Drawing.Size(107, 26)
        Me.txt_st2_act_mea.TabIndex = 93
        '
        'btn_st2_set_cal_val
        '
        Me.btn_st2_set_cal_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2_set_cal_val.Location = New System.Drawing.Point(526, 183)
        Me.btn_st2_set_cal_val.Name = "btn_st2_set_cal_val"
        Me.btn_st2_set_cal_val.Size = New System.Drawing.Size(100, 50)
        Me.btn_st2_set_cal_val.TabIndex = 92
        Me.btn_st2_set_cal_val.Text = "Set Calib Value"
        Me.btn_st2_set_cal_val.UseVisualStyleBackColor = True
        '
        'btn_st2_preset_heidenhain
        '
        Me.btn_st2_preset_heidenhain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2_preset_heidenhain.Location = New System.Drawing.Point(632, 121)
        Me.btn_st2_preset_heidenhain.Name = "btn_st2_preset_heidenhain"
        Me.btn_st2_preset_heidenhain.Size = New System.Drawing.Size(100, 50)
        Me.btn_st2_preset_heidenhain.TabIndex = 91
        Me.btn_st2_preset_heidenhain.Text = "Preset Heidenhain"
        Me.btn_st2_preset_heidenhain.UseVisualStyleBackColor = True
        '
        'btn_st2_stop_punch
        '
        Me.btn_st2_stop_punch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2_stop_punch.Location = New System.Drawing.Point(636, 302)
        Me.btn_st2_stop_punch.Name = "btn_st2_stop_punch"
        Me.btn_st2_stop_punch.Size = New System.Drawing.Size(100, 50)
        Me.btn_st2_stop_punch.TabIndex = 90
        Me.btn_st2_stop_punch.Text = "Stop Puncher"
        Me.btn_st2_stop_punch.UseVisualStyleBackColor = True
        '
        'Label330
        '
        Me.Label330.AutoSize = True
        Me.Label330.Enabled = False
        Me.Label330.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label330.Location = New System.Drawing.Point(317, 285)
        Me.Label330.Name = "Label330"
        Me.Label330.Size = New System.Drawing.Size(18, 20)
        Me.Label330.TabIndex = 76
        Me.Label330.Text = "6"
        '
        'btn_st2_start_punch
        '
        Me.btn_st2_start_punch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2_start_punch.Location = New System.Drawing.Point(526, 302)
        Me.btn_st2_start_punch.Name = "btn_st2_start_punch"
        Me.btn_st2_start_punch.Size = New System.Drawing.Size(100, 50)
        Me.btn_st2_start_punch.TabIndex = 89
        Me.btn_st2_start_punch.Text = "Start Puncher"
        Me.btn_st2_start_punch.UseVisualStyleBackColor = True
        '
        'Label329
        '
        Me.Label329.AutoSize = True
        Me.Label329.Enabled = False
        Me.Label329.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label329.Location = New System.Drawing.Point(317, 253)
        Me.Label329.Name = "Label329"
        Me.Label329.Size = New System.Drawing.Size(18, 20)
        Me.Label329.TabIndex = 76
        Me.Label329.Text = "5"
        '
        'btn_st2_enable_heidenhain
        '
        Me.btn_st2_enable_heidenhain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2_enable_heidenhain.Location = New System.Drawing.Point(526, 121)
        Me.btn_st2_enable_heidenhain.Name = "btn_st2_enable_heidenhain"
        Me.btn_st2_enable_heidenhain.Size = New System.Drawing.Size(100, 50)
        Me.btn_st2_enable_heidenhain.TabIndex = 84
        Me.btn_st2_enable_heidenhain.Text = "Enable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Heidenhain"
        Me.btn_st2_enable_heidenhain.UseVisualStyleBackColor = True
        '
        'Label328
        '
        Me.Label328.AutoSize = True
        Me.Label328.Enabled = False
        Me.Label328.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label328.Location = New System.Drawing.Point(317, 221)
        Me.Label328.Name = "Label328"
        Me.Label328.Size = New System.Drawing.Size(18, 20)
        Me.Label328.TabIndex = 76
        Me.Label328.Text = "4"
        '
        'Label279
        '
        Me.Label279.AutoSize = True
        Me.Label279.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label279.Location = New System.Drawing.Point(94, 367)
        Me.Label279.Name = "Label279"
        Me.Label279.Size = New System.Drawing.Size(101, 20)
        Me.Label279.TabIndex = 82
        Me.Label279.Text = "Motor Status"
        '
        'Label327
        '
        Me.Label327.AutoSize = True
        Me.Label327.Enabled = False
        Me.Label327.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label327.Location = New System.Drawing.Point(317, 189)
        Me.Label327.Name = "Label327"
        Me.Label327.Size = New System.Drawing.Size(18, 20)
        Me.Label327.TabIndex = 76
        Me.Label327.Text = "3"
        '
        'Label282
        '
        Me.Label282.AutoSize = True
        Me.Label282.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label282.Location = New System.Drawing.Point(94, 175)
        Me.Label282.Name = "Label282"
        Me.Label282.Size = New System.Drawing.Size(129, 20)
        Me.Label282.TabIndex = 80
        Me.Label282.Text = "Heidenhain Error"
        '
        'Label326
        '
        Me.Label326.AutoSize = True
        Me.Label326.Enabled = False
        Me.Label326.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label326.Location = New System.Drawing.Point(317, 157)
        Me.Label326.Name = "Label326"
        Me.Label326.Size = New System.Drawing.Size(18, 20)
        Me.Label326.TabIndex = 76
        Me.Label326.Text = "2"
        '
        'Label303
        '
        Me.Label303.AutoSize = True
        Me.Label303.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label303.Location = New System.Drawing.Point(522, 252)
        Me.Label303.Name = "Label303"
        Me.Label303.Size = New System.Drawing.Size(55, 40)
        Me.Label303.TabIndex = 76
        Me.Label303.Text = "Punch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cycle :"
        '
        'Label325
        '
        Me.Label325.AutoSize = True
        Me.Label325.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label325.Location = New System.Drawing.Point(317, 125)
        Me.Label325.Name = "Label325"
        Me.Label325.Size = New System.Drawing.Size(18, 20)
        Me.Label325.TabIndex = 76
        Me.Label325.Text = "1"
        '
        'Label286
        '
        Me.Label286.AutoSize = True
        Me.Label286.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label286.Location = New System.Drawing.Point(341, 77)
        Me.Label286.Name = "Label286"
        Me.Label286.Size = New System.Drawing.Size(58, 40)
        Me.Label286.TabIndex = 76
        Me.Label286.Text = "Calib" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value :"
        '
        'Label302
        '
        Me.Label302.AutoSize = True
        Me.Label302.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label302.Location = New System.Drawing.Point(521, 359)
        Me.Label302.Name = "Label302"
        Me.Label302.Size = New System.Drawing.Size(74, 40)
        Me.Label302.TabIndex = 75
        Me.Label302.Text = "Punch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Counter :"
        '
        'Label287
        '
        Me.Label287.AutoSize = True
        Me.Label287.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label287.Location = New System.Drawing.Point(522, 74)
        Me.Label287.Name = "Label287"
        Me.Label287.Size = New System.Drawing.Size(79, 40)
        Me.Label287.TabIndex = 75
        Me.Label287.Text = "Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measure :"
        '
        'Label289
        '
        Me.Label289.AutoSize = True
        Me.Label289.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label289.Location = New System.Drawing.Point(94, 119)
        Me.Label289.Name = "Label289"
        Me.Label289.Size = New System.Drawing.Size(129, 20)
        Me.Label289.TabIndex = 73
        Me.Label289.Text = "Heidenhain Valid"
        '
        'ind_st2_motor_status
        '
        Me.ind_st2_motor_status.BackColor = System.Drawing.Color.Transparent
        Me.ind_st2_motor_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_st2_motor_status.Location = New System.Drawing.Point(56, 362)
        Me.ind_st2_motor_status.Name = "ind_st2_motor_status"
        Me.ind_st2_motor_status.Size = New System.Drawing.Size(30, 30)
        Me.ind_st2_motor_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st2_motor_status.TabIndex = 71
        Me.ind_st2_motor_status.TabStop = False
        '
        'ind_st2_heidenhain_error
        '
        Me.ind_st2_heidenhain_error.BackColor = System.Drawing.Color.Transparent
        Me.ind_st2_heidenhain_error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_st2_heidenhain_error.Location = New System.Drawing.Point(56, 170)
        Me.ind_st2_heidenhain_error.Name = "ind_st2_heidenhain_error"
        Me.ind_st2_heidenhain_error.Size = New System.Drawing.Size(30, 30)
        Me.ind_st2_heidenhain_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st2_heidenhain_error.TabIndex = 67
        Me.ind_st2_heidenhain_error.TabStop = False
        '
        'ind_st2_heidenhain_valid
        '
        Me.ind_st2_heidenhain_valid.BackColor = System.Drawing.Color.Transparent
        Me.ind_st2_heidenhain_valid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_st2_heidenhain_valid.Location = New System.Drawing.Point(56, 114)
        Me.ind_st2_heidenhain_valid.Name = "ind_st2_heidenhain_valid"
        Me.ind_st2_heidenhain_valid.Size = New System.Drawing.Size(30, 30)
        Me.ind_st2_heidenhain_valid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ind_st2_heidenhain_valid.TabIndex = 66
        Me.ind_st2_heidenhain_valid.TabStop = False
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
        Me.TabPage8.Text = "Manual Station 2"
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
        'pnl_man_stn2
        '
        Me.pnl_man_stn2.Controls.Add(Me.TabPage8)
        Me.pnl_man_stn2.Controls.Add(Me.TabPage26)
        Me.pnl_man_stn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_man_stn2.Location = New System.Drawing.Point(78, 87)
        Me.pnl_man_stn2.Name = "pnl_man_stn2"
        Me.pnl_man_stn2.SelectedIndex = 0
        Me.pnl_man_stn2.Size = New System.Drawing.Size(853, 563)
        Me.pnl_man_stn2.TabIndex = 100
        '
        'btn_st2_auto_caib
        '
        Me.btn_st2_auto_caib.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2_auto_caib.Location = New System.Drawing.Point(632, 183)
        Me.btn_st2_auto_caib.Name = "btn_st2_auto_caib"
        Me.btn_st2_auto_caib.Size = New System.Drawing.Size(100, 50)
        Me.btn_st2_auto_caib.TabIndex = 92
        Me.btn_st2_auto_caib.Text = "Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calibration"
        Me.btn_st2_auto_caib.UseVisualStyleBackColor = True
        '
        'st6_laser
        '
        Me.st6_laser.AutoSize = True
        Me.st6_laser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st6_laser.Location = New System.Drawing.Point(73, 358)
        Me.st6_laser.Name = "st6_laser"
        Me.st6_laser.Size = New System.Drawing.Size(61, 20)
        Me.st6_laser.TabIndex = 5
        Me.st6_laser.Text = "Laser"
        Me.st6_laser.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.MC_Status)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.GroupBox87)
        Me.Controls.Add(Me.lbl_run_state)
        Me.Controls.Add(Me.lbl_curr_time)
        Me.Controls.Add(Me.Label117)
        Me.Controls.Add(Me.GroupBox86)
        Me.Controls.Add(Me.laabel3)
        Me.Controls.Add(Me.lbl_auto_man)
        Me.Controls.Add(Me.status_bar)
        Me.Controls.Add(Me.btn_stn6)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.btn_stn5)
        Me.Controls.Add(Me.btn_stn4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btn_calib)
        Me.Controls.Add(Me.btn_stn3)
        Me.Controls.Add(Me.btn_stn2)
        Me.Controls.Add(Me.lbl_st4_t2_5)
        Me.Controls.Add(Me.btn_stn1)
        Me.Controls.Add(Me.lbl_st4_t2_4)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.lbl_st4_t2_3)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_st4_t2_2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_st4_t2_1)
        Me.Controls.Add(Me.lbl_st4_t2)
        Me.Controls.Add(Me.btn_laser)
        Me.Controls.Add(Me.lbl_cot_5)
        Me.Controls.Add(Me.lbl_cot_4)
        Me.Controls.Add(Me.lbl_cot_3)
        Me.Controls.Add(Me.lbl_cot_2)
        Me.Controls.Add(Me.lbl_cot_1)
        Me.Controls.Add(Me.lbl_cot)
        Me.Controls.Add(Me.lbl_st4_t1_5)
        Me.Controls.Add(Me.lbl_st4_t1_4)
        Me.Controls.Add(Me.lbl_st4_t1_3)
        Me.Controls.Add(Me.lbl_st4_t1_2)
        Me.Controls.Add(Me.lbl_st4_t1_1)
        Me.Controls.Add(Me.lbl_st4_t1)
        Me.Controls.Add(Me.btn_multimeter)
        Me.Controls.Add(Me.btn_monitoring)
        Me.Controls.Add(Me.pnl_setting)
        Me.Controls.Add(Me.pnl_log)
        Me.Controls.Add(Me.pnl_ref)
        Me.Controls.Add(Me.pnl_laser)
        Me.Controls.Add(Me.pnl_calibration)
        Me.Controls.Add(Me.pnl_multi)
        Me.Controls.Add(Me.pnl_alarm)
        Me.Controls.Add(Me.pnl_mon_stn6)
        Me.Controls.Add(Me.pnl_mon_stn5)
        Me.Controls.Add(Me.pnl_mon_stn4)
        Me.Controls.Add(Me.pnl_mon_stn3)
        Me.Controls.Add(Me.pnl_mon_stn2)
        Me.Controls.Add(Me.pnl_mon_stn1)
        Me.Controls.Add(Me.btn_setting)
        Me.Controls.Add(Me.btn_log)
        Me.Controls.Add(Me.btn_alarm)
        Me.Controls.Add(Me.btn_ref)
        Me.Controls.Add(Me.btn_manual)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.pnl_home)
        Me.Controls.Add(Me.pnl_man_stn6)
        Me.Controls.Add(Me.pnl_man_stn5)
        Me.Controls.Add(Me.pnl_man_stn4)
        Me.Controls.Add(Me.pnl_man_stn3)
        Me.Controls.Add(Me.pnl_man_stn2)
        Me.Controls.Add(Me.pnl_man_stn1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XCS-E Contact Block Tester"
        Me.pnl_home.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout
        Me.GroupBox175.ResumeLayout(False)
        Me.GroupBox175.PerformLayout
        Me.GroupBox78.ResumeLayout(False)
        Me.GroupBox78.PerformLayout
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
        Me.GroupBox87.ResumeLayout(False)
        Me.GroupBox87.PerformLayout
        Me.GroupBox86.ResumeLayout(False)
        Me.GroupBox86.PerformLayout
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
        Me.GroupBox82.ResumeLayout(False)
        Me.GroupBox83.ResumeLayout(False)
        Me.GroupBox83.PerformLayout
        CType(Me.stn6_laser_interlock, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_laser_finish, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn6_laser_ready, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox85.ResumeLayout(False)
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
        Me.GroupBox172.ResumeLayout(False)
        Me.GroupBox173.ResumeLayout(False)
        Me.GroupBox173.PerformLayout
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox180.ResumeLayout(False)
        Me.GroupBox49.ResumeLayout(False)
        Me.GroupBox50.ResumeLayout(False)
        Me.GroupBox50.PerformLayout
        CType(Me.stn5_cyl4_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl4_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox51.ResumeLayout(False)
        Me.GroupBox52.ResumeLayout(False)
        Me.GroupBox53.ResumeLayout(False)
        Me.GroupBox53.PerformLayout
        CType(Me.stn5_cyl2_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl2_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox54.ResumeLayout(False)
        Me.GroupBox55.ResumeLayout(False)
        Me.GroupBox56.ResumeLayout(False)
        Me.GroupBox56.PerformLayout
        CType(Me.stn5_cyl3_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl3_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox57.ResumeLayout(False)
        Me.GroupBox58.ResumeLayout(False)
        Me.GroupBox59.ResumeLayout(False)
        Me.GroupBox59.PerformLayout
        CType(Me.stn5_cyl1_min, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stn5_cyl1_max, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox60.ResumeLayout(False)
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
        Me.TabPage24.ResumeLayout(False)
        Me.TabPage24.PerformLayout
        CType(Me.ind_st4_discrete_motion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_continuous_motion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_servo_busy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_standstill, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_stopping, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_servo_error, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_home_busy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st4_servo_enabled, System.ComponentModel.ISupportInitialize).EndInit
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
        Me.TabPage25.ResumeLayout(False)
        Me.TabPage25.PerformLayout
        CType(Me.ind_st3_discrete_motion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_continuous_motion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_servo_busy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_standstill, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_stopping, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_servo_error, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_home_busy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st3_servo_enabled, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_man_stn1.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout
        Me.GroupBox183.ResumeLayout(False)
        CType(Me.ind_safety_st6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_safety_st2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_safety_st4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_cycle_status, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_safety_st5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_safety_st1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_safety_st3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_altivar_status, System.ComponentModel.ISupportInitialize).EndInit
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
        Me.gb_laser.ResumeLayout(False)
        Me.gb_laser.PerformLayout
        CType(Me.connect_laser_ind, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox179.ResumeLayout(False)
        Me.GroupBox179.PerformLayout
        Me.GroupBox177.ResumeLayout(False)
        Me.GroupBox177.PerformLayout
        CType(Me.ind_stn_6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_stn_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_stn_5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_stn_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_stn_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_stn_1, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox176.ResumeLayout(False)
        Me.GroupBox176.PerformLayout
        Me.GroupBox169.ResumeLayout(False)
        Me.GroupBox169.PerformLayout
        CType(Me.connect_multi_ind, System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_plc.ResumeLayout(False)
        Me.grp_plc.PerformLayout
        CType(Me.connect_plc_ind, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_log.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout
        Me.GroupBox174.ResumeLayout(False)
        Me.GroupBox174.PerformLayout
        Me.GroupBox181.ResumeLayout(False)
        Me.GroupBox181.PerformLayout
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout
        Me.GroupBox182.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_ref.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_ref, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox_Control.ResumeLayout(False)
        Me.GroupBox_Control.PerformLayout
        Me.pnl_laser.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        Me.GroupBox171.ResumeLayout(False)
        Me.GroupBox171.PerformLayout
        Me.pnl_multi.ResumeLayout(False)
        Me.TabPage14.ResumeLayout(False)
        Me.GroupBox178.ResumeLayout(False)
        Me.GroupBox178.PerformLayout
        Me.GroupBox170.ResumeLayout(False)
        Me.GroupBox170.PerformLayout
        Me.pnl_alarm.ResumeLayout(False)
        Me.TabPage15.ResumeLayout(False)
        Me.TabPage15.PerformLayout
        Me.GroupBox184.ResumeLayout(False)
        Me.GroupBox184.PerformLayout
        CType(Me.ind_laser_err_emg, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_pos_servo_st4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_pos_servo_st3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_conn_servo_st4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_conn_servo_st3, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox84.ResumeLayout(False)
        Me.GroupBox84.PerformLayout
        CType(Me.ind_v606_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v604_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v602_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v504_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v503_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v605_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v603_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v601_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v502_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox81.ResumeLayout(False)
        Me.GroupBox81.PerformLayout
        CType(Me.ind_v402_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v302_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v501_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v203_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v401_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v202_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v301_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v101_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_v201_descrepancy, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox79.ResumeLayout(False)
        Me.GroupBox79.PerformLayout
        CType(Me.ind_safety_curtain, System.ComponentModel.ISupportInitialize).EndInit
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
        Me.pnl_calibration.ResumeLayout(False)
        Me.TabPage22.ResumeLayout(False)
        CType(Me.dgv_calibration, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MC_Status, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.status_bar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage26.ResumeLayout(False)
        Me.TabPage26.PerformLayout
        CType(Me.ind_st2_motor_status, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st2_heidenhain_error, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ind_st2_heidenhain_valid, System.ComponentModel.ISupportInitialize).EndInit
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
        Me.pnl_man_stn2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents btn_setting As Button
    Friend WithEvents btn_monitoring As Button
    Friend WithEvents btn_manual As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents lbl_user As Label
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
    Friend WithEvents lbl_st4NC_res As Label
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
    Friend WithEvents GroupBox80 As GroupBox
    Friend WithEvents Label85 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label80 As Label
    Friend WithEvents GroupBox76 As GroupBox
    Friend WithEvents ind_plc_status As PictureBox
    Friend WithEvents Label64 As Label
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
    Friend WithEvents txt_port_multi As TextBox
    Friend WithEvents btn_apply_multi As Button
    Friend WithEvents btn_open_multi As Button
    Friend WithEvents txt_baud_multi As TextBox
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnl_ref As TabControl
    Friend WithEvents TabPage2 As TabPage
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
    Friend WithEvents pnl_multi As TabControl
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents GroupBox170 As GroupBox
    Friend WithEvents Label229 As Label
    Friend WithEvents txt_ch_1 As TextBox
    Friend WithEvents btn_read_ch_1 As Button
    Friend WithEvents pnl_alarm As TabControl
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents ind_v602_descrepancy As PictureBox
    Friend WithEvents Label94 As Label
    Friend WithEvents ind_v601_descrepancy As PictureBox
    Friend WithEvents Label96 As Label
    Friend WithEvents ind_v402_descrepancy As PictureBox
    Friend WithEvents Label89 As Label
    Friend WithEvents ind_v401_descrepancy As PictureBox
    Friend WithEvents Label90 As Label
    Friend WithEvents GroupBox84 As GroupBox
    Friend WithEvents ind_v502_descrepancy As PictureBox
    Friend WithEvents Label92 As Label
    Friend WithEvents ind_v501_descrepancy As PictureBox
    Friend WithEvents Label93 As Label
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
    Friend WithEvents txt_msg As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_unscrew_status_5 As Label
    Friend WithEvents lbl_unscrew_status_4 As Label
    Friend WithEvents lbl_unscrew_status_3 As Label
    Friend WithEvents lbl_unscrew_status_2 As Label
    Friend WithEvents lbl_unscrew_status_1 As Label
    Friend WithEvents lbl_st4_t2_5 As Label
    Friend WithEvents lbl_st4_t2_4 As Label
    Friend WithEvents lbl_st4_t2_3 As Label
    Friend WithEvents lbl_st4_t2_2 As Label
    Friend WithEvents lbl_st4_t2_1 As Label
    Friend WithEvents lbl_st4_p2_5 As Label
    Friend WithEvents lbl_st4_p2_4 As Label
    Friend WithEvents lbl_st4_p2_3 As Label
    Friend WithEvents lbl_st4_p2_2 As Label
    Friend WithEvents lbl_st4_p2_1 As Label
    Friend WithEvents lbl_diff_result_5 As Label
    Friend WithEvents lbl_diff_result_4 As Label
    Friend WithEvents lbl_diff_result_3 As Label
    Friend WithEvents lbl_diff_result_2 As Label
    Friend WithEvents lbl_diff_result_1 As Label
    Friend WithEvents lbl_st2_meas_5 As Label
    Friend WithEvents lbl_st2_meas_4 As Label
    Friend WithEvents lbl_st2_meas_3 As Label
    Friend WithEvents lbl_st2_meas_2 As Label
    Friend WithEvents lbl_st2_meas_1 As Label
    Friend WithEvents lbl_cot_5 As Label
    Friend WithEvents lbl_cot_4 As Label
    Friend WithEvents lbl_cot_3 As Label
    Friend WithEvents lbl_cot_2 As Label
    Friend WithEvents lbl_cot_1 As Label
    Friend WithEvents lbl_st4_t1_5 As Label
    Friend WithEvents lbl_st4_t1_4 As Label
    Friend WithEvents lbl_st4_t1_3 As Label
    Friend WithEvents lbl_st4_t1_2 As Label
    Friend WithEvents lbl_st4_t1_1 As Label
    Friend WithEvents lbl_st4NC_res_5 As Label
    Friend WithEvents lbl_st4NC_res_4 As Label
    Friend WithEvents lbl_st4NC_res_3 As Label
    Friend WithEvents lbl_st4NC_res_2 As Label
    Friend WithEvents lbl_st4NC_res_1 As Label
    Friend WithEvents lbl_st4_p3_5 As Label
    Friend WithEvents lbl_st4_p3_4 As Label
    Friend WithEvents lbl_st4_p3_3 As Label
    Friend WithEvents lbl_st4_p3_2 As Label
    Friend WithEvents lbl_st4_p3_1 As Label
    Friend WithEvents lbl_status_5 As Label
    Friend WithEvents lbl_status_4 As Label
    Friend WithEvents lbl_status_3 As Label
    Friend WithEvents lbl_status_2 As Label
    Friend WithEvents lbl_status_1 As Label
    Friend WithEvents lbl_item_6 As Label
    Friend WithEvents lbl_item_5 As Label
    Friend WithEvents lbl_item_4 As Label
    Friend WithEvents lbl_item_3 As Label
    Friend WithEvents lbl_item_2 As Label
    Friend WithEvents lbl_item_1 As Label
    Friend WithEvents txt_po_num As TextBox
    Friend WithEvents txt_ope_id As TextBox
    Friend WithEvents txt_ref As TextBox
    Friend WithEvents GroupBox175 As GroupBox
    Friend WithEvents Label124 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lbl_fpy As Label
    Friend WithEvents lbl_oee As Label
    Friend WithEvents lbl_fail As Label
    Friend WithEvents lbl_pass As Label
    Friend WithEvents btn_empty As Button
    Friend WithEvents GroupBox176 As GroupBox
    Friend WithEvents cb_downgrade_6 As ComboBox
    Friend WithEvents Label166 As Label
    Friend WithEvents cb_downgrade_5 As ComboBox
    Friend WithEvents Label149 As Label
    Friend WithEvents cb_downgrade_4 As ComboBox
    Friend WithEvents Label71 As Label
    Friend WithEvents cb_downgrade_3 As ComboBox
    Friend WithEvents Label60 As Label
    Friend WithEvents cb_downgrade_2 As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents cb_downgrade_1 As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btn_apply_station As Button
    Friend WithEvents GroupBox177 As GroupBox
    Friend WithEvents Label183 As Label
    Friend WithEvents Label231 As Label
    Friend WithEvents Label217 As Label
    Friend WithEvents Label228 As Label
    Friend WithEvents Label200 As Label
    Friend WithEvents Label227 As Label
    Friend WithEvents ind_stn_6 As PictureBox
    Friend WithEvents ind_stn_3 As PictureBox
    Friend WithEvents ind_stn_5 As PictureBox
    Friend WithEvents ind_stn_2 As PictureBox
    Friend WithEvents ind_stn_4 As PictureBox
    Friend WithEvents ind_stn_1 As PictureBox
    Friend WithEvents st4_resistance As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents st2_beating As CheckBox
    Friend WithEvents st4_cot As CheckBox
    Friend WithEvents st3_adjustment As CheckBox
    Friend WithEvents st2_measuring As CheckBox
    Friend WithEvents ChromaComm As IO.Ports.SerialPort
    Friend WithEvents GroupBox178 As GroupBox
    Friend WithEvents Label236 As Label
    Friend WithEvents Label248 As Label
    Friend WithEvents txt_cmd_multi As TextBox
    Friend WithEvents btn_send_multi As Button
    Friend WithEvents txt_respond_multi As TextBox
    Friend WithEvents Label257 As Label
    Friend WithEvents lbl_st4NO_res_5 As Label
    Friend WithEvents lbl_st4NO_res_4 As Label
    Friend WithEvents lbl_st4NO_res_3 As Label
    Friend WithEvents lbl_st4NO_res_2 As Label
    Friend WithEvents lbl_st4NO_res_1 As Label
    Friend WithEvents lbl_st4NO_res As Label
    Friend WithEvents GroupBox179 As GroupBox
    Friend WithEvents Label254 As Label
    Friend WithEvents Label252 As Label
    Friend WithEvents txt_database As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label253 As Label
    Friend WithEvents Label251 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_hostname As TextBox
    Friend WithEvents btn_apply_database As Button
    Friend WithEvents Label255 As Label
    Friend WithEvents txt_name_multi As TextBox
    Friend WithEvents RTB_CFG As RichTextBox
    Friend WithEvents btn_save_plc As Button
    Friend WithEvents pnl_calibration As TabControl
    Friend WithEvents TabPage22 As TabPage
    Friend WithEvents ind_safety_curtain As PictureBox
    Friend WithEvents Label230 As Label
    Friend WithEvents btn_calib As Button
    Friend WithEvents gb_laser As GroupBox
    Friend WithEvents txtIP_laser As TextBox
    Friend WithEvents connect_laser_ind As PictureBox
    Friend WithEvents Label256 As Label
    Friend WithEvents Label258 As Label
    Friend WithEvents btn_save_laser As Button
    Friend WithEvents txtPort_laser As TextBox
    Friend WithEvents btn_connect_laser As Button
    Friend WithEvents btn_send_laser As Button
    Friend WithEvents txtResponse_laser As TextBox
    Friend WithEvents Label233 As Label
    Friend WithEvents txtCommand_laser As TextBox
    Friend WithEvents Label232 As Label
    Friend WithEvents btn_save_calib As Button
    Friend WithEvents dgv_calibration As DataGridView
    Friend WithEvents Parameter As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents TabPage24 As TabPage
    Friend WithEvents txt_st4_act_vel As TextBox
    Friend WithEvents txt_st4_act_pos As TextBox
    Friend WithEvents txt_st4_set_vel As TextBox
    Friend WithEvents txt_st4_set_pos As TextBox
    Friend WithEvents btn_st4_servo_stop As Button
    Friend WithEvents btn_st4_servo_reset As Button
    Friend WithEvents btn_st4_jog_ccw As Button
    Friend WithEvents btn_st4_jog_cw As Button
    Friend WithEvents btn_st4_move_vel As Button
    Friend WithEvents btn_st4_move_pos As Button
    Friend WithEvents btn_st4_save_data As Button
    Friend WithEvents btn_st4_homing As Button
    Friend WithEvents btn_st4_servo_enable As Button
    Friend WithEvents Label234 As Label
    Friend WithEvents Label235 As Label
    Friend WithEvents Label259 As Label
    Friend WithEvents Label260 As Label
    Friend WithEvents Label261 As Label
    Friend WithEvents Label262 As Label
    Friend WithEvents Label263 As Label
    Friend WithEvents Label264 As Label
    Friend WithEvents Label265 As Label
    Friend WithEvents Label266 As Label
    Friend WithEvents Label267 As Label
    Friend WithEvents ind_st4_continuous_motion As PictureBox
    Friend WithEvents ind_st4_servo_busy As PictureBox
    Friend WithEvents ind_st4_standstill As PictureBox
    Friend WithEvents ind_st4_stopping As PictureBox
    Friend WithEvents ind_st4_servo_error As PictureBox
    Friend WithEvents ind_st4_home_busy As PictureBox
    Friend WithEvents ind_st4_servo_enabled As PictureBox
    Friend WithEvents TabPage25 As TabPage
    Friend WithEvents txt_st3_act_vel As TextBox
    Friend WithEvents txt_st3_act_pos As TextBox
    Friend WithEvents txt_st3_set_vel As TextBox
    Friend WithEvents txt_st3_set_pos As TextBox
    Friend WithEvents btn_st3_servo_stop As Button
    Friend WithEvents btn_st3_servo_reset As Button
    Friend WithEvents btn_st3_jog_ccw As Button
    Friend WithEvents btn_st3_jog_cw As Button
    Friend WithEvents btn_st3_move_vel As Button
    Friend WithEvents btn_st3_move_pos As Button
    Friend WithEvents btn_st3_save_data As Button
    Friend WithEvents btn_st3_homing As Button
    Friend WithEvents btn_st3_servo_enable As Button
    Friend WithEvents Label268 As Label
    Friend WithEvents Label269 As Label
    Friend WithEvents Label270 As Label
    Friend WithEvents Label271 As Label
    Friend WithEvents Label272 As Label
    Friend WithEvents Label273 As Label
    Friend WithEvents Label274 As Label
    Friend WithEvents Label275 As Label
    Friend WithEvents Label276 As Label
    Friend WithEvents Label277 As Label
    Friend WithEvents Label278 As Label
    Friend WithEvents ind_st3_continuous_motion As PictureBox
    Friend WithEvents ind_st3_servo_busy As PictureBox
    Friend WithEvents ind_st3_standstill As PictureBox
    Friend WithEvents ind_st3_stopping As PictureBox
    Friend WithEvents ind_st3_servo_error As PictureBox
    Friend WithEvents ind_st3_home_busy As PictureBox
    Friend WithEvents ind_st3_servo_enabled As PictureBox
    Friend WithEvents dgv_ref As DataGridView
    Friend WithEvents lbl_date As Label
    Friend WithEvents MC_Status As PictureBox
    Friend WithEvents Label310 As Label
    Friend WithEvents lbl_st4_actu_pos_5 As Label
    Friend WithEvents lbl_st4_actu_pos_4 As Label
    Friend WithEvents lbl_st4_actu_pos_3 As Label
    Friend WithEvents lbl_st4_actu_pos_2 As Label
    Friend WithEvents lbl_st4_actu_pos_1 As Label
    Friend WithEvents lbl_st4_actu_pos As Label
    Friend WithEvents btn_run As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents txt_st4_analog_data As TextBox
    Friend WithEvents txt_st4_diff_str As TextBox
    Friend WithEvents txt_st4_actu_pos As TextBox
    Friend WithEvents btn_st4_man_trig As Button
    Friend WithEvents btn_st4_cal As Button
    Friend WithEvents Label290 As Label
    Friend WithEvents Label291 As Label
    Friend WithEvents Label292 As Label
    Friend WithEvents label_297 As Label
    Friend WithEvents Label295 As Label
    Friend WithEvents ind_st4_discrete_motion As PictureBox
    Friend WithEvents Label296 As Label
    Friend WithEvents ind_st3_discrete_motion As PictureBox
    Friend WithEvents GroupBox172 As GroupBox
    Friend WithEvents GroupBox173 As GroupBox
    Friend WithEvents Label297 As Label
    Friend WithEvents Label298 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox180 As GroupBox
    Friend WithEvents btn_stn5_screw_fw As Button
    Friend WithEvents btn_stn5_screw_bw As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents rbByREF As RadioButton
    Friend WithEvents rbBydate As RadioButton
    Friend WithEvents GroupBox174 As GroupBox
    Friend WithEvents tbSearchREF As TextBox
    Friend WithEvents GroupBox181 As GroupBox
    Friend WithEvents Label249 As Label
    Friend WithEvents Label250 As Label
    Friend WithEvents DateTimePickerEndDate As DateTimePicker
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents btn_search As Button
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents GroupBox182 As GroupBox
    Friend WithEvents RTB_LOG As RichTextBox
    Friend WithEvents btn_fileLocation As Button
    Friend WithEvents ProgressBarExport As ProgressBar
    Friend WithEvents txtFileLocation As TextBox
    Friend WithEvents btn_export As Button
    Friend WithEvents btn_trig_turn_table As Button
    Friend WithEvents Label301 As Label
    Friend WithEvents Label283 As Label
    Friend WithEvents Label288 As Label
    Friend WithEvents Label280 As Label
    Friend WithEvents Label285 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label284 As Label
    Friend WithEvents Label281 As Label
    Friend WithEvents ind_safety_st6 As PictureBox
    Friend WithEvents ind_safety_st2 As PictureBox
    Friend WithEvents ind_safety_st4 As PictureBox
    Friend WithEvents ind_cycle_status As PictureBox
    Friend WithEvents ind_safety_st5 As PictureBox
    Friend WithEvents ind_safety_st1 As PictureBox
    Friend WithEvents ind_safety_st3 As PictureBox
    Friend WithEvents ind_altivar_status As PictureBox
    Friend WithEvents GroupBox183 As GroupBox
    Friend WithEvents ind_v101_descrepancy As PictureBox
    Friend WithEvents Label299 As Label
    Friend WithEvents TabPage26 As TabPage
    Friend WithEvents txt_st2_punch_cycle As TextBox
    Friend WithEvents txt_st2_cal_val_1 As TextBox
    Friend WithEvents txt_st2_punch_count As TextBox
    Friend WithEvents txt_st2_act_mea As TextBox
    Friend WithEvents btn_st2_set_cal_val As Button
    Friend WithEvents btn_st2_preset_heidenhain As Button
    Friend WithEvents btn_st2_stop_punch As Button
    Friend WithEvents btn_st2_start_punch As Button
    Friend WithEvents btn_st2_enable_heidenhain As Button
    Friend WithEvents Label279 As Label
    Friend WithEvents Label282 As Label
    Friend WithEvents Label303 As Label
    Friend WithEvents Label286 As Label
    Friend WithEvents Label302 As Label
    Friend WithEvents Label287 As Label
    Friend WithEvents Label289 As Label
    Friend WithEvents ind_st2_motor_status As PictureBox
    Friend WithEvents ind_st2_heidenhain_error As PictureBox
    Friend WithEvents ind_st2_heidenhain_valid As PictureBox
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
    Friend WithEvents pnl_man_stn2 As TabControl
    Friend WithEvents txt_alarm As TextBox
    Friend WithEvents ind_v606_descrepancy As PictureBox
    Friend WithEvents ind_v604_descrepancy As PictureBox
    Friend WithEvents ind_v504_descrepancy As PictureBox
    Friend WithEvents Label309 As Label
    Friend WithEvents Label307 As Label
    Friend WithEvents ind_v503_descrepancy As PictureBox
    Friend WithEvents ind_v605_descrepancy As PictureBox
    Friend WithEvents ind_v603_descrepancy As PictureBox
    Friend WithEvents Label308 As Label
    Friend WithEvents Label306 As Label
    Friend WithEvents Label305 As Label
    Friend WithEvents Label304 As Label
    Friend WithEvents ind_v203_descrepancy As PictureBox
    Friend WithEvents labelaaa As Label
    Friend WithEvents GroupBox82 As GroupBox
    Friend WithEvents GroupBox83 As GroupBox
    Friend WithEvents Label312 As Label
    Friend WithEvents Label300 As Label
    Friend WithEvents Label311 As Label
    Friend WithEvents stn6_laser_interlock As PictureBox
    Friend WithEvents stn6_laser_finish As PictureBox
    Friend WithEvents stn6_laser_ready As PictureBox
    Friend WithEvents GroupBox85 As GroupBox
    Friend WithEvents btn_stn6_laser_start As Button
    Friend WithEvents GroupBox184 As GroupBox
    Friend WithEvents ind_pos_servo_st3 As PictureBox
    Friend WithEvents ind_conn_servo_st3 As PictureBox
    Friend WithEvents Label320 As Label
    Friend WithEvents Label321 As Label
    Friend WithEvents ind_laser_err_emg As PictureBox
    Friend WithEvents ind_pos_servo_st4 As PictureBox
    Friend WithEvents ind_conn_servo_st4 As PictureBox
    Friend WithEvents Label315 As Label
    Friend WithEvents Label314 As Label
    Friend WithEvents Label313 As Label
    Friend WithEvents txt_alarm_copy As Label
    Friend WithEvents Label316 As Label
    Friend WithEvents txt_offset_multi As TextBox
    Friend WithEvents txt_st4_cal_val_gt2_6 As TextBox
    Friend WithEvents txt_st4_cal_val_gt2_5 As TextBox
    Friend WithEvents txt_st4_cal_val_p0_6 As TextBox
    Friend WithEvents txt_st4_cal_val_gt2_4 As TextBox
    Friend WithEvents txt_st4_cal_val_p0_5 As TextBox
    Friend WithEvents txt_st4_cal_val_gt2_3 As TextBox
    Friend WithEvents txt_st4_cal_val_p0_4 As TextBox
    Friend WithEvents txt_st4_cal_val_gt2_2 As TextBox
    Friend WithEvents txt_st4_cal_val_p0_3 As TextBox
    Friend WithEvents txt_st4_cal_val_gt2_1 As TextBox
    Friend WithEvents txt_st4_cal_val_p0_2 As TextBox
    Friend WithEvents txt_st4_cal_val_p0_1 As TextBox
    Friend WithEvents Label324 As Label
    Friend WithEvents Label294 As Label
    Friend WithEvents Label323 As Label
    Friend WithEvents Label322 As Label
    Friend WithEvents Label293 As Label
    Friend WithEvents Label319 As Label
    Friend WithEvents Label318 As Label
    Friend WithEvents Label317 As Label
    Friend WithEvents txt_st2_cal_val_6 As TextBox
    Friend WithEvents txt_st2_cal_val_5 As TextBox
    Friend WithEvents txt_st2_cal_val_4 As TextBox
    Friend WithEvents txt_st2_cal_val_3 As TextBox
    Friend WithEvents txt_st2_cal_val_2 As TextBox
    Friend WithEvents Label330 As Label
    Friend WithEvents Label329 As Label
    Friend WithEvents Label328 As Label
    Friend WithEvents Label327 As Label
    Friend WithEvents Label326 As Label
    Friend WithEvents Label325 As Label
    Friend WithEvents txt_offset_gt As TextBox
    Friend WithEvents Label331 As Label
    Friend WithEvents btn_st4_auto_calibration As Button
    Friend WithEvents btn_st2_auto_caib As Button
    Friend WithEvents st6_laser As CheckBox
End Class
