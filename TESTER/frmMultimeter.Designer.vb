<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultimeter
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_disc = New System.Windows.Forms.Button()
        Me.btn_conn = New System.Windows.Forms.Button()
        Me.txt_port = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ch_1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ch_2 = New System.Windows.Forms.TextBox()
        Me.btn_read_ch_1 = New System.Windows.Forms.Button()
        Me.btn_read_ch_2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_disc)
        Me.GroupBox2.Controls.Add(Me.btn_conn)
        Me.GroupBox2.Controls.Add(Me.txt_port)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_ip)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 76)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuration"
        '
        'btn_disc
        '
        Me.btn_disc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_disc.Location = New System.Drawing.Point(223, 44)
        Me.btn_disc.Name = "btn_disc"
        Me.btn_disc.Size = New System.Drawing.Size(80, 22)
        Me.btn_disc.TabIndex = 10
        Me.btn_disc.Text = "Disconnect"
        Me.btn_disc.UseVisualStyleBackColor = True
        '
        'btn_conn
        '
        Me.btn_conn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_conn.Location = New System.Drawing.Point(223, 16)
        Me.btn_conn.Name = "btn_conn"
        Me.btn_conn.Size = New System.Drawing.Size(80, 22)
        Me.btn_conn.TabIndex = 10
        Me.btn_conn.Text = "Connect"
        Me.btn_conn.UseVisualStyleBackColor = True
        '
        'txt_port
        '
        Me.txt_port.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_port.Location = New System.Drawing.Point(85, 44)
        Me.txt_port.Name = "txt_port"
        Me.txt_port.Size = New System.Drawing.Size(119, 22)
        Me.txt_port.TabIndex = 8
        Me.txt_port.Text = "8.8.8.8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port :"
        '
        'txt_ip
        '
        Me.txt_ip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ip.Location = New System.Drawing.Point(85, 16)
        Me.txt_ip.Name = "txt_ip"
        Me.txt_ip.Size = New System.Drawing.Size(119, 22)
        Me.txt_ip.TabIndex = 8
        Me.txt_ip.Text = "127.0.0.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "IP Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Channel 1 :"
        '
        'txt_ch_1
        '
        Me.txt_ch_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ch_1.Location = New System.Drawing.Point(85, 16)
        Me.txt_ch_1.Name = "txt_ch_1"
        Me.txt_ch_1.Size = New System.Drawing.Size(119, 22)
        Me.txt_ch_1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Channel 2 :"
        '
        'txt_ch_2
        '
        Me.txt_ch_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ch_2.Location = New System.Drawing.Point(85, 44)
        Me.txt_ch_2.Name = "txt_ch_2"
        Me.txt_ch_2.Size = New System.Drawing.Size(119, 22)
        Me.txt_ch_2.TabIndex = 8
        '
        'btn_read_ch_1
        '
        Me.btn_read_ch_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read_ch_1.Location = New System.Drawing.Point(223, 16)
        Me.btn_read_ch_1.Name = "btn_read_ch_1"
        Me.btn_read_ch_1.Size = New System.Drawing.Size(80, 22)
        Me.btn_read_ch_1.TabIndex = 10
        Me.btn_read_ch_1.Text = "Read CH1"
        Me.btn_read_ch_1.UseVisualStyleBackColor = True
        '
        'btn_read_ch_2
        '
        Me.btn_read_ch_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read_ch_2.Location = New System.Drawing.Point(223, 44)
        Me.btn_read_ch_2.Name = "btn_read_ch_2"
        Me.btn_read_ch_2.Size = New System.Drawing.Size(80, 22)
        Me.btn_read_ch_2.TabIndex = 10
        Me.btn_read_ch_2.Text = "Read CH2"
        Me.btn_read_ch_2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_read_ch_2)
        Me.GroupBox1.Controls.Add(Me.btn_read_ch_1)
        Me.GroupBox1.Controls.Add(Me.txt_ch_2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ch_1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 76)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Measurement"
        '
        'frmMultimeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 178)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMultimeter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multimeter"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_disc As Button
    Friend WithEvents btn_conn As Button
    Friend WithEvents txt_port As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ip As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ch_1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ch_2 As TextBox
    Friend WithEvents btn_read_ch_1 As Button
    Friend WithEvents btn_read_ch_2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
