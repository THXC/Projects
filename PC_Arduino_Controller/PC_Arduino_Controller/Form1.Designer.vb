<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.LB_ServoPos = New System.Windows.Forms.Label()
        Me.LB_ConnStatus = New System.Windows.Forms.Label()
        Me.btn_Off = New System.Windows.Forms.Button()
        Me.Btn_On = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.Btn_Display1 = New System.Windows.Forms.Button()
        Me.Btn_Display2 = New System.Windows.Forms.Button()
        Me.RB_S1 = New System.Windows.Forms.RadioButton()
        Me.RB_S2 = New System.Windows.Forms.RadioButton()
        Me.RB_S3 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CB_Servo0 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo10 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo8 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo7 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo6 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo2 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo11 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo1 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo9 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo3 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo4 = New System.Windows.Forms.CheckBox()
        Me.CB_Servo5 = New System.Windows.Forms.CheckBox()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(22, 23)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(55, 42)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Setup USB"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'LB_ServoPos
        '
        Me.LB_ServoPos.AutoSize = True
        Me.LB_ServoPos.Location = New System.Drawing.Point(12, 267)
        Me.LB_ServoPos.Name = "LB_ServoPos"
        Me.LB_ServoPos.Size = New System.Drawing.Size(75, 13)
        Me.LB_ServoPos.TabIndex = 1
        Me.LB_ServoPos.Text = "Servo Position"
        '
        'LB_ConnStatus
        '
        Me.LB_ConnStatus.AutoSize = True
        Me.LB_ConnStatus.Location = New System.Drawing.Point(12, 296)
        Me.LB_ConnStatus.Name = "LB_ConnStatus"
        Me.LB_ConnStatus.Size = New System.Drawing.Size(91, 13)
        Me.LB_ConnStatus.TabIndex = 2
        Me.LB_ConnStatus.Text = "ConnectionStatus"
        '
        'btn_Off
        '
        Me.btn_Off.Location = New System.Drawing.Point(223, 22)
        Me.btn_Off.Name = "btn_Off"
        Me.btn_Off.Size = New System.Drawing.Size(55, 42)
        Me.btn_Off.TabIndex = 3
        Me.btn_Off.Text = "OFF"
        Me.btn_Off.UseVisualStyleBackColor = True
        '
        'Btn_On
        '
        Me.Btn_On.Location = New System.Drawing.Point(162, 23)
        Me.Btn_On.Name = "Btn_On"
        Me.Btn_On.Size = New System.Drawing.Size(55, 42)
        Me.Btn_On.TabIndex = 4
        Me.Btn_On.Text = "ON"
        Me.Btn_On.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 100
        Me.TrackBar1.Location = New System.Drawing.Point(22, 215)
        Me.TrackBar1.Maximum = 2400
        Me.TrackBar1.Minimum = 600
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(256, 45)
        Me.TrackBar1.SmallChange = 100
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.Value = 1500
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(109, 23)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(52, 17)
        Me.RB1.TabIndex = 6
        Me.RB1.Text = "LED1"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(109, 47)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(52, 17)
        Me.RB2.TabIndex = 7
        Me.RB2.Text = "LED2"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(109, 70)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(52, 17)
        Me.RB3.TabIndex = 8
        Me.RB3.Text = "LED3"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'Btn_Display1
        '
        Me.Btn_Display1.Location = New System.Drawing.Point(162, 70)
        Me.Btn_Display1.Name = "Btn_Display1"
        Me.Btn_Display1.Size = New System.Drawing.Size(55, 39)
        Me.Btn_Display1.TabIndex = 9
        Me.Btn_Display1.Text = "Display 1"
        Me.Btn_Display1.UseVisualStyleBackColor = True
        '
        'Btn_Display2
        '
        Me.Btn_Display2.Location = New System.Drawing.Point(223, 70)
        Me.Btn_Display2.Name = "Btn_Display2"
        Me.Btn_Display2.Size = New System.Drawing.Size(55, 40)
        Me.Btn_Display2.TabIndex = 10
        Me.Btn_Display2.Text = "Display 2"
        Me.Btn_Display2.UseVisualStyleBackColor = True
        '
        'RB_S1
        '
        Me.RB_S1.AutoSize = True
        Me.RB_S1.Checked = True
        Me.RB_S1.Location = New System.Drawing.Point(22, 143)
        Me.RB_S1.Name = "RB_S1"
        Me.RB_S1.Size = New System.Drawing.Size(59, 17)
        Me.RB_S1.TabIndex = 11
        Me.RB_S1.TabStop = True
        Me.RB_S1.Text = "Servo1"
        Me.RB_S1.UseVisualStyleBackColor = True
        '
        'RB_S2
        '
        Me.RB_S2.AutoSize = True
        Me.RB_S2.Location = New System.Drawing.Point(22, 167)
        Me.RB_S2.Name = "RB_S2"
        Me.RB_S2.Size = New System.Drawing.Size(59, 17)
        Me.RB_S2.TabIndex = 11
        Me.RB_S2.Text = "Servo2"
        Me.RB_S2.UseVisualStyleBackColor = True
        '
        'RB_S3
        '
        Me.RB_S3.AutoSize = True
        Me.RB_S3.Location = New System.Drawing.Point(22, 191)
        Me.RB_S3.Name = "RB_S3"
        Me.RB_S3.Size = New System.Drawing.Size(59, 17)
        Me.RB_S3.TabIndex = 11
        Me.RB_S3.Text = "Servo3"
        Me.RB_S3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(479, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'CB_Servo0
        '
        Me.CB_Servo0.AutoSize = True
        Me.CB_Servo0.Location = New System.Drawing.Point(520, 24)
        Me.CB_Servo0.Name = "CB_Servo0"
        Me.CB_Servo0.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo0.TabIndex = 13
        Me.CB_Servo0.Text = "0"
        Me.CB_Servo0.UseVisualStyleBackColor = True
        '
        'CB_Servo10
        '
        Me.CB_Servo10.AutoSize = True
        Me.CB_Servo10.Location = New System.Drawing.Point(496, 116)
        Me.CB_Servo10.Name = "CB_Servo10"
        Me.CB_Servo10.Size = New System.Drawing.Size(38, 17)
        Me.CB_Servo10.TabIndex = 17
        Me.CB_Servo10.Text = "10"
        Me.CB_Servo10.UseVisualStyleBackColor = True
        '
        'CB_Servo8
        '
        Me.CB_Servo8.AutoSize = True
        Me.CB_Servo8.Location = New System.Drawing.Point(547, 116)
        Me.CB_Servo8.Name = "CB_Servo8"
        Me.CB_Servo8.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo8.TabIndex = 18
        Me.CB_Servo8.Text = "8"
        Me.CB_Servo8.UseVisualStyleBackColor = True
        '
        'CB_Servo7
        '
        Me.CB_Servo7.AutoSize = True
        Me.CB_Servo7.Location = New System.Drawing.Point(547, 92)
        Me.CB_Servo7.Name = "CB_Servo7"
        Me.CB_Servo7.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo7.TabIndex = 19
        Me.CB_Servo7.Text = "7"
        Me.CB_Servo7.UseVisualStyleBackColor = True
        '
        'CB_Servo6
        '
        Me.CB_Servo6.AutoSize = True
        Me.CB_Servo6.Location = New System.Drawing.Point(520, 72)
        Me.CB_Servo6.Name = "CB_Servo6"
        Me.CB_Servo6.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo6.TabIndex = 20
        Me.CB_Servo6.Text = "6"
        Me.CB_Servo6.UseVisualStyleBackColor = True
        '
        'CB_Servo2
        '
        Me.CB_Servo2.AutoSize = True
        Me.CB_Servo2.Location = New System.Drawing.Point(586, 143)
        Me.CB_Servo2.Name = "CB_Servo2"
        Me.CB_Servo2.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo2.TabIndex = 21
        Me.CB_Servo2.Text = "2"
        Me.CB_Servo2.UseVisualStyleBackColor = True
        '
        'CB_Servo11
        '
        Me.CB_Servo11.AutoSize = True
        Me.CB_Servo11.Location = New System.Drawing.Point(496, 92)
        Me.CB_Servo11.Name = "CB_Servo11"
        Me.CB_Servo11.Size = New System.Drawing.Size(38, 17)
        Me.CB_Servo11.TabIndex = 23
        Me.CB_Servo11.Text = "11"
        Me.CB_Servo11.UseVisualStyleBackColor = True
        '
        'CB_Servo1
        '
        Me.CB_Servo1.AutoSize = True
        Me.CB_Servo1.Location = New System.Drawing.Point(586, 60)
        Me.CB_Servo1.Name = "CB_Servo1"
        Me.CB_Servo1.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo1.TabIndex = 24
        Me.CB_Servo1.Text = "1"
        Me.CB_Servo1.UseVisualStyleBackColor = True
        '
        'CB_Servo9
        '
        Me.CB_Servo9.AutoSize = True
        Me.CB_Servo9.Location = New System.Drawing.Point(520, 140)
        Me.CB_Servo9.Name = "CB_Servo9"
        Me.CB_Servo9.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo9.TabIndex = 25
        Me.CB_Servo9.Text = "9"
        Me.CB_Servo9.UseVisualStyleBackColor = True
        '
        'CB_Servo3
        '
        Me.CB_Servo3.AutoSize = True
        Me.CB_Servo3.Location = New System.Drawing.Point(520, 180)
        Me.CB_Servo3.Name = "CB_Servo3"
        Me.CB_Servo3.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo3.TabIndex = 26
        Me.CB_Servo3.Text = "3"
        Me.CB_Servo3.UseVisualStyleBackColor = True
        '
        'CB_Servo4
        '
        Me.CB_Servo4.AutoSize = True
        Me.CB_Servo4.Location = New System.Drawing.Point(461, 143)
        Me.CB_Servo4.Name = "CB_Servo4"
        Me.CB_Servo4.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo4.TabIndex = 27
        Me.CB_Servo4.Text = "4"
        Me.CB_Servo4.UseVisualStyleBackColor = True
        '
        'CB_Servo5
        '
        Me.CB_Servo5.AutoSize = True
        Me.CB_Servo5.Location = New System.Drawing.Point(461, 60)
        Me.CB_Servo5.Name = "CB_Servo5"
        Me.CB_Servo5.Size = New System.Drawing.Size(32, 17)
        Me.CB_Servo5.TabIndex = 28
        Me.CB_Servo5.Text = "5"
        Me.CB_Servo5.UseVisualStyleBackColor = True
        '
        'TrackBar2
        '
        Me.TrackBar2.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.TrackBar2.LargeChange = 200
        Me.TrackBar2.Location = New System.Drawing.Point(119, 267)
        Me.TrackBar2.Maximum = 2400
        Me.TrackBar2.Minimum = 600
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(522, 45)
        Me.TrackBar2.SmallChange = 100
        Me.TrackBar2.TabIndex = 29
        Me.TrackBar2.TickFrequency = 100
        Me.TrackBar2.Value = 1500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 326)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.CB_Servo5)
        Me.Controls.Add(Me.CB_Servo4)
        Me.Controls.Add(Me.CB_Servo3)
        Me.Controls.Add(Me.CB_Servo9)
        Me.Controls.Add(Me.CB_Servo1)
        Me.Controls.Add(Me.CB_Servo11)
        Me.Controls.Add(Me.CB_Servo2)
        Me.Controls.Add(Me.CB_Servo6)
        Me.Controls.Add(Me.CB_Servo7)
        Me.Controls.Add(Me.CB_Servo8)
        Me.Controls.Add(Me.CB_Servo10)
        Me.Controls.Add(Me.CB_Servo0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RB_S3)
        Me.Controls.Add(Me.RB_S2)
        Me.Controls.Add(Me.RB_S1)
        Me.Controls.Add(Me.Btn_Display2)
        Me.Controls.Add(Me.Btn_Display1)
        Me.Controls.Add(Me.RB3)
        Me.Controls.Add(Me.RB2)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Btn_On)
        Me.Controls.Add(Me.btn_Off)
        Me.Controls.Add(Me.LB_ConnStatus)
        Me.Controls.Add(Me.LB_ServoPos)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents LB_ServoPos As System.Windows.Forms.Label
    Friend WithEvents LB_ConnStatus As System.Windows.Forms.Label
    Friend WithEvents btn_Off As System.Windows.Forms.Button
    Friend WithEvents Btn_On As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Display1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Display2 As System.Windows.Forms.Button
    Friend WithEvents RB_S1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_S2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_S3 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CB_Servo0 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo10 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo8 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo7 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo6 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo2 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo11 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo1 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo9 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo3 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo4 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Servo5 As System.Windows.Forms.CheckBox
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar

End Class
