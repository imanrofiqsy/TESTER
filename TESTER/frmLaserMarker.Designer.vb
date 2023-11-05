<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaserMarker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_prg_num = New System.Windows.Forms.ComboBox()
        Me.chb_mark_cavity_1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_block0 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_block1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_block2 = New System.Windows.Forms.TextBox()
        Me.btn_string_char = New System.Windows.Forms.Button()
        Me.btn_start_marking = New System.Windows.Forms.Button()
        Me.btn_mark_flag = New System.Windows.Forms.Button()
        Me.btn_change_prg = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_comm_log = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Number :"
        '
        'cb_prg_num
        '
        Me.cb_prg_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_prg_num.FormattingEnabled = True
        Me.cb_prg_num.Location = New System.Drawing.Point(136, 23)
        Me.cb_prg_num.Name = "cb_prg_num"
        Me.cb_prg_num.Size = New System.Drawing.Size(121, 24)
        Me.cb_prg_num.TabIndex = 1
        '
        'chb_mark_cavity_1
        '
        Me.chb_mark_cavity_1.AutoSize = True
        Me.chb_mark_cavity_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_mark_cavity_1.Location = New System.Drawing.Point(280, 25)
        Me.chb_mark_cavity_1.Name = "chb_mark_cavity_1"
        Me.chb_mark_cavity_1.Size = New System.Drawing.Size(107, 20)
        Me.chb_mark_cavity_1.TabIndex = 2
        Me.chb_mark_cavity_1.Text = "Mark Cavity 1"
        Me.chb_mark_cavity_1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Block 0 :"
        '
        'txt_block0
        '
        Me.txt_block0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block0.Location = New System.Drawing.Point(77, 76)
        Me.txt_block0.Name = "txt_block0"
        Me.txt_block0.Size = New System.Drawing.Size(310, 22)
        Me.txt_block0.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Block 1 :"
        '
        'txt_block1
        '
        Me.txt_block1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block1.Location = New System.Drawing.Point(77, 104)
        Me.txt_block1.Name = "txt_block1"
        Me.txt_block1.Size = New System.Drawing.Size(310, 22)
        Me.txt_block1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Block 2 :"
        '
        'txt_block2
        '
        Me.txt_block2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block2.Location = New System.Drawing.Point(77, 132)
        Me.txt_block2.Name = "txt_block2"
        Me.txt_block2.Size = New System.Drawing.Size(310, 22)
        Me.txt_block2.TabIndex = 3
        '
        'btn_string_char
        '
        Me.btn_string_char.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_string_char.Location = New System.Drawing.Point(77, 160)
        Me.btn_string_char.Name = "btn_string_char"
        Me.btn_string_char.Size = New System.Drawing.Size(106, 23)
        Me.btn_string_char.TabIndex = 4
        Me.btn_string_char.Text = "String Character"
        Me.btn_string_char.UseVisualStyleBackColor = True
        '
        'btn_start_marking
        '
        Me.btn_start_marking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_marking.Location = New System.Drawing.Point(296, 160)
        Me.btn_start_marking.Name = "btn_start_marking"
        Me.btn_start_marking.Size = New System.Drawing.Size(91, 23)
        Me.btn_start_marking.TabIndex = 4
        Me.btn_start_marking.Text = "Start Marking"
        Me.btn_start_marking.UseVisualStyleBackColor = True
        '
        'btn_mark_flag
        '
        Me.btn_mark_flag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mark_flag.Location = New System.Drawing.Point(194, 160)
        Me.btn_mark_flag.Name = "btn_mark_flag"
        Me.btn_mark_flag.Size = New System.Drawing.Size(91, 23)
        Me.btn_mark_flag.TabIndex = 4
        Me.btn_mark_flag.Text = "Mark Flag"
        Me.btn_mark_flag.UseVisualStyleBackColor = True
        '
        'btn_change_prg
        '
        Me.btn_change_prg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change_prg.Location = New System.Drawing.Point(77, 189)
        Me.btn_change_prg.Name = "btn_change_prg"
        Me.btn_change_prg.Size = New System.Drawing.Size(106, 23)
        Me.btn_change_prg.TabIndex = 4
        Me.btn_change_prg.Text = "Change Program"
        Me.btn_change_prg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_mark_flag)
        Me.GroupBox1.Controls.Add(Me.btn_change_prg)
        Me.GroupBox1.Controls.Add(Me.btn_start_marking)
        Me.GroupBox1.Controls.Add(Me.btn_string_char)
        Me.GroupBox1.Controls.Add(Me.txt_block2)
        Me.GroupBox1.Controls.Add(Me.txt_block1)
        Me.GroupBox1.Controls.Add(Me.txt_block0)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chb_mark_cavity_1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cb_prg_num)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 226)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cavity 1"
        '
        'txt_comm_log
        '
        Me.txt_comm_log.Location = New System.Drawing.Point(6, 19)
        Me.txt_comm_log.Multiline = True
        Me.txt_comm_log.Name = "txt_comm_log"
        Me.txt_comm_log.Size = New System.Drawing.Size(393, 121)
        Me.txt_comm_log.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_comm_log)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 146)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Communication Log"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 406)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laser Parameter"
        '
        'frmLaserMarker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 423)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmLaserMarker"
        Me.Text = "Laser Marker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_prg_num As ComboBox
    Friend WithEvents chb_mark_cavity_1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_block0 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_block1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_block2 As TextBox
    Friend WithEvents btn_string_char As Button
    Friend WithEvents btn_start_marking As Button
    Friend WithEvents btn_mark_flag As Button
    Friend WithEvents btn_change_prg As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_comm_log As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
