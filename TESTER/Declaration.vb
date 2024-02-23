Module Declaration
    Public CURTAIN As Boolean
    Public CALIBRATION As Boolean
    Public Config As New machineConfig
    Public Result As New testerResult
    Public Structure machineConfig
        Dim addressPlc As String
        Dim portPlc As String
        Dim addressLaser As String
        Dim portLaser As String
        Dim dbHostName As String
        Dim dbUsername As String
        Dim dbPassword As String
        Dim dbDatabase As String
        Dim instrumentName As String
        Dim instrumentBaud As String
        Dim instrumentPort As String
        Dim sequenceCounter As String
    End Structure

    Public STATION_STATUS As Integer
    Public SERVO_ST5 As Integer
    Public SERVO_ST4 As Integer
    Public SERVO_ST3 As Integer
    Public HEIDENHAIN As Integer
    Public MANUAL_OPERATION As Integer

    Public ADDR_CALIB_VALUE_P0_ST4 As Integer = 40082
    Public ADDR_CALIB_VALUE_GT2_ST4 As Integer = 40084
    Public ADDR_ANALOG_DATA_ST2 As Integer = 40080
    Public ADDR_ACTUATION_POS_ST4 As Integer = 40086
    Public ADDR_DIFF_STR_ST4 As Integer = 40088

    Public ADDR_SERVO_ST5 As Integer = 40026
    Public ADDR_SET_VEL_ST5 As Integer = 40054
    Public ADDR_ACT_VEL_ST5 As Integer = 40056
    Public ADDR_SET_POS_ST5 As Integer = 40050
    Public ADDR_ACT_POS_ST5 As Integer = 40052

    Public ADDR_SERVO_ST4 As Integer = 40028
    Public ADDR_SET_VEL_ST4 As Integer = 40062
    Public ADDR_ACT_VEL_ST4 As Integer = 40064
    Public ADDR_SET_POS_ST4 As Integer = 40058
    Public ADDR_ACT_POS_ST4 As Integer = 40060

    Public ADDR_SERVO_ST3 As Integer = 40030
    Public ADDR_SET_VEL_ST3 As Integer = 40070
    Public ADDR_ACT_VEL_ST3 As Integer = 40072
    Public ADDR_SET_POS_ST3 As Integer = 40066
    Public ADDR_ACT_POS_ST3 As Integer = 40068

    Public ADDR_HEIDENHAIN As Integer = 40032
    Public ADDR_CAL_VAL_ST2 As Integer = 40074
    Public ADDR_ACT_MEA_ST2 As Integer = 40076
    Public ADDR_PUNCH_COUNTER_ST2 As Integer = 40078
    Public ADDR_PUNCH_CYCLE_ST2 As Integer = 40079

    Public ADDR_MANUAL_OPERATION As Integer = 40024

    Public ADDR_ST_DOWNGRADE As Integer = 40011
    Public ADDR_ST_DOWNGRADE_SUB As Integer = 40012

    Public MODBUS_ERR As Boolean = False

    Public ADDR_PASS As Integer = 40003
    Public ADDR_FAIL As Integer = 40004
    Public ADDR_OEE As Integer = 40008
    Public ADDR_FPY As Integer = 40007
    Public ADDR_EMPTY_PROCCESS As Integer = 40009

    Public CNT_ST2 As Integer = 0
    Public CNT_ST3 As Integer = 0
    Public CNT_ST4 As Integer = 0
    Public CNT_ST5 As Integer = 0

    Public ADDR_ST_COMM2 As Integer = 40020
    Public ST_COMM2 As Integer
    Public ADDR_ST_COMM3 As Integer = 40021
    Public ST_COMM3 As Integer
    Public ADDR_ST_COMM4 As Integer = 40022
    Public ST_COMM4 As Integer
    Public ADDR_ST_COMM5 As Integer = 40023
    Public ST_COMM5 As Integer

    Public SCAN_MODE As Integer = 0
    Public LASER_STATE As Integer = 0
    Public ACTION As Integer = 0
    Public IS_RUN As Boolean = False

    Public ADDR_ST2_MEASUREMENT As Integer = 47200
    Public ADDR_ST3_RESISTANCE As Integer = 0
    Public ADDR_ST4_P2_TRAVEL As Integer = 47202
    Public ADDR_ST4_P3_TRAVEL As Integer = 47204
    Public ADDR_ST4_ACTUATION_POS As Integer = 47215
    Public ADDR_DIFF_STR_RESULT As Integer = 47206
    Public ADDR_ST4_T1 As Integer = 47208
    Public ADDR_ST4_T2 As Integer = 47210
    Public ADDR_COT As Integer = 47212
    Public ADDR_UNSCREW_STATUS As Integer = 47214

    Public Structure testerResult
        Dim MEASUREMENT As String
        Dim RESISTANCE_OFF As String
        Dim RESISTANCE_ON As String
        Dim TRAVEL_P2 As String
        Dim TRAVEL_P3 As String
        Dim ACTUATION_POS As String
        Dim DIFF_STR As String
        Dim T1 As String
        Dim T2 As String
        Dim COT As String
        Dim UNSCREW_STATUS As String
    End Structure


    Public ADDR_ACT_VAL As Integer = 47000
    Public ADDR_ACT_VAL_TOL As Integer = 47002
    Public ADDR_DIF_STR As Integer = 47004
    Public ADDR_DIF_STR_TOL As Integer = 47006
    Public ADDR_BEATING_TIMES As Integer = 47008
    Public ADDR_CFG_FIRST_CONTACT As Integer = 47009
    Public ADDR_CFG_SECOND_CONTACT As Integer = 47010
    Public ADDR_UNSCREWING_PROCESS As Integer = 47011
    Public ADDR_LASER_DATE_CODE As Integer = 47012

    Public LOAD_VAL As Integer = 0
    Public LOAD_MSG As String

    Public PLC_READY As Integer = 0
    Public ADDR_PLC_READY As Integer = 40100
    Public RUNNING_STATE As Integer = 0
    Public ADDR_RUNNING_STATE As Integer = 40002
    Public RUNNING_MODE As Integer = 0
    Public ADDR_RUNNING_MODE As Integer = 40001

    Public ADDR_PC_STATUS As Integer = 40101
    Public PC_STATUS As Integer = 0 '100,110,101
    Public LAST_PC_STATUS As Integer = 0

    Public ADDR_ALARM_GENERAL As Integer = 40005
    Public ALARM_GENERAL As Integer
    Public ADDR_ALARM_STN2 As Integer = 40204
    Public ALARM_STN2 As Integer
    Public ADDR_ALARM_STN3 As Integer = 40304
    Public ALARM_STN3 As Integer
    Public ADDR_ALARM_STN4 As Integer = 40404
    Public ALARM_STN4 As Integer
    Public ADDR_ALARM_STN5 As Integer = 40504
    Public ALARM_STN5 As Integer
    Public ADDR_ALARM_STN6 As Integer = 40604
    Public ALARM_STN6 As Integer

    Public USER_LEVEL As Integer
    Public REGISTER_TYPE As Integer = 3

    Public FORWARD As Integer = 1
    Public BACKWARD As Integer = 2
    Public IDLE As Integer = 0

    Public ADDR_STN1_CYL1 As Integer = 45101
    Public ADDR_STN1_CYL2 As Integer = 45102
    Public ADDR_STN1_CYL3 As Integer = 45103
    Public ADDR_STN1_CYL4 As Integer = 45104

    Public STN1_CYL1 As Integer = 0
    Public STN1_CYL2 As Integer = 0
    Public STN1_CYL3 As Integer = 0
    Public STN1_CYL4 As Integer = 0
    Public LAST_STN1_CYL1 As Integer = 0
    Public LAST_STN1_CYL2 As Integer = 0
    Public LAST_STN1_CYL3 As Integer = 0
    Public LAST_STN1_CYL4 As Integer = 0

    Public ADDR_STN2_CYL1 As Integer = 45201
    Public ADDR_STN2_CYL2 As Integer = 45202
    Public ADDR_STN2_CYL3 As Integer = 45203
    Public ADDR_STN2_CYL4 As Integer = 45204

    Public STN2_CYL1 As Integer = 0
    Public STN2_CYL2 As Integer = 0
    Public STN2_CYL3 As Integer = 0
    Public STN2_CYL4 As Integer = 0
    Public LAST_STN2_CYL1 As Integer = 0
    Public LAST_STN2_CYL2 As Integer = 0
    Public LAST_STN2_CYL3 As Integer = 0
    Public LAST_STN2_CYL4 As Integer = 0

    Public ADDR_STN3_CYL1 As Integer = 45301
    Public ADDR_STN3_CYL2 As Integer = 45302
    Public ADDR_STN3_CYL3 As Integer = 45303
    Public ADDR_STN3_CYL4 As Integer = 45304

    Public STN3_CYL1 As Integer = 0
    Public STN3_CYL2 As Integer = 0
    Public STN3_CYL3 As Integer = 0
    Public STN3_CYL4 As Integer = 0
    Public LAST_STN3_CYL1 As Integer = 0
    Public LAST_STN3_CYL2 As Integer = 0
    Public LAST_STN3_CYL3 As Integer = 0
    Public LAST_STN3_CYL4 As Integer = 0

    Public ADDR_STN4_CYL1 As Integer = 45401
    Public ADDR_STN4_CYL2 As Integer = 45402
    Public ADDR_STN4_CYL3 As Integer = 45403
    Public ADDR_STN4_CYL4 As Integer = 45404

    Public STN4_CYL1 As Integer = 0
    Public STN4_CYL2 As Integer = 0
    Public STN4_CYL3 As Integer = 0
    Public STN4_CYL4 As Integer = 0
    Public LAST_STN4_CYL1 As Integer = 0
    Public LAST_STN4_CYL2 As Integer = 0
    Public LAST_STN4_CYL3 As Integer = 0
    Public LAST_STN4_CYL4 As Integer = 0

    Public ADDR_STN5_CYL1 As Integer = 45501
    Public ADDR_STN5_CYL2 As Integer = 45502
    Public ADDR_STN5_CYL3 As Integer = 45503
    Public ADDR_STN5_CYL4 As Integer = 45504
    Public ADDR_STN5_SCREW As Integer = 45505

    Public STN5_CYL1 As Integer = 0
    Public STN5_CYL2 As Integer = 0
    Public STN5_CYL3 As Integer = 0
    Public STN5_CYL4 As Integer = 0
    Public STN5_SCREW As Integer = 0
    Public LAST_STN5_CYL1 As Integer = 0
    Public LAST_STN5_CYL2 As Integer = 0
    Public LAST_STN5_CYL3 As Integer = 0
    Public LAST_STN5_CYL4 As Integer = 0
    Public LAST_STN5_SCREW As Integer = 0

    Public ADDR_STN6_CYL1 As Integer = 45601
    Public ADDR_STN6_CYL2 As Integer = 45602
    Public ADDR_STN6_CYL3 As Integer = 45603
    Public ADDR_STN6_CYL4 As Integer = 45604
    Public ADDR_STN6_CYL5 As Integer = 45605
    Public ADDR_STN6_CYL6 As Integer = 45606

    Public STN6_CYL1 As Integer = 0
    Public STN6_CYL2 As Integer = 0
    Public STN6_CYL3 As Integer = 0
    Public STN6_CYL4 As Integer = 0
    Public STN6_CYL5 As Integer = 0
    Public STN6_CYL6 As Integer = 0
    Public LAST_STN6_CYL1 As Integer = 0
    Public LAST_STN6_CYL2 As Integer = 0
    Public LAST_STN6_CYL3 As Integer = 0
    Public LAST_STN6_CYL4 As Integer = 0
    Public LAST_STN6_CYL5 As Integer = 0
    Public LAST_STN6_CYL6 As Integer = 0

    Public ADDR_STN1_SEN1 As Integer = 46101
    Public ADDR_STN1_SEN2 As Integer = 46102
    Public ADDR_STN1_SEN3 As Integer = 46103
    Public ADDR_STN1_SEN4 As Integer = 46104

    Public ADDR_STN2_SEN1 As Integer = 46201
    Public ADDR_STN2_SEN2 As Integer = 46202
    Public ADDR_STN2_SEN3 As Integer = 46203
    Public ADDR_STN2_SEN4 As Integer = 46204

    Public ADDR_STN3_SEN1 As Integer = 46301
    Public ADDR_STN3_SEN2 As Integer = 46302
    Public ADDR_STN3_SEN3 As Integer = 46303
    Public ADDR_STN3_SEN4 As Integer = 46304

    Public ADDR_STN4_SEN1 As Integer = 46401
    Public ADDR_STN4_SEN2 As Integer = 46402
    Public ADDR_STN4_SEN3 As Integer = 46403
    Public ADDR_STN4_SEN4 As Integer = 46404

    Public ADDR_STN5_SEN1 As Integer = 46501
    Public ADDR_STN5_SEN2 As Integer = 46502
    Public ADDR_STN5_SEN3 As Integer = 46503
    Public ADDR_STN5_SEN4 As Integer = 46504

    Public ADDR_STN6_SEN1 As Integer = 46601
    Public ADDR_STN6_SEN2 As Integer = 46602
    Public ADDR_STN6_SEN3 As Integer = 46603
    Public ADDR_STN6_SEN4 As Integer = 46604
    Public ADDR_STN6_SEN5 As Integer = 46605
    Public ADDR_STN6_SEN6 As Integer = 46606
End Module
