Module Declaration
    Public SCAN_MODE As String

    Public LOAD_VAL As Integer = 0
    Public LOAD_MSG As String

    Public PLC_READY As Integer = 1
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

    Public STN5_CYL1 As Integer = 0
    Public STN5_CYL2 As Integer = 0
    Public STN5_CYL3 As Integer = 0
    Public STN5_CYL4 As Integer = 0
    Public LAST_STN5_CYL1 As Integer = 0
    Public LAST_STN5_CYL2 As Integer = 0
    Public LAST_STN5_CYL3 As Integer = 0
    Public LAST_STN5_CYL4 As Integer = 0

    Public ADDR_STN6_CYL1 As Integer = 45601
    Public ADDR_STN6_CYL2 As Integer = 45602
    Public ADDR_STN6_CYL3 As Integer = 45603
    Public ADDR_STN6_CYL4 As Integer = 45604
    Public ADDR_STN6_CYL5 As Integer = 45605

    Public STN6_CYL1 As Integer = 0
    Public STN6_CYL2 As Integer = 0
    Public STN6_CYL3 As Integer = 0
    Public STN6_CYL4 As Integer = 0
    Public STN6_CYL5 As Integer = 0
    Public LAST_STN6_CYL1 As Integer = 0
    Public LAST_STN6_CYL2 As Integer = 0
    Public LAST_STN6_CYL3 As Integer = 0
    Public LAST_STN6_CYL4 As Integer = 0
    Public LAST_STN6_CYL5 As Integer = 0

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
End Module
