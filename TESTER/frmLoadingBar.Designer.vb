<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadingBar
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.lbl_loading = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TESTER.My.Resources.Resources.telemecanique_sensors_logo_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(117, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 79)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LoadingBar
        '
        Me.LoadingBar.Location = New System.Drawing.Point(14, 121)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(472, 23)
        Me.LoadingBar.TabIndex = 6
        Me.LoadingBar.Value = 100
        '
        'lbl_loading
        '
        Me.lbl_loading.AutoSize = True
        Me.lbl_loading.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loading.Location = New System.Drawing.Point(10, 152)
        Me.lbl_loading.Name = "lbl_loading"
        Me.lbl_loading.Size = New System.Drawing.Size(78, 19)
        Me.lbl_loading.TabIndex = 5
        Me.lbl_loading.Text = "Loading..."
        '
        'Timer1
        '
        '
        'frmLoadingBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(496, 200)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.lbl_loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoadingBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents lbl_loading As Label
    Friend WithEvents Timer1 As Timer
End Class
