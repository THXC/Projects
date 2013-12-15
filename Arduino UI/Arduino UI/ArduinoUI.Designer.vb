<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnOFF = New System.Windows.Forms.Button()
        Me.btnON = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnPWM25 = New System.Windows.Forms.Button()
        Me.btnPWM50 = New System.Windows.Forms.Button()
        Me.btnPWM75 = New System.Windows.Forms.Button()
        Me.btnPWM100 = New System.Windows.Forms.Button()
        Me.btnPWM125 = New System.Windows.Forms.Button()
        Me.btnPWM375 = New System.Windows.Forms.Button()
        Me.btnPWM625 = New System.Windows.Forms.Button()
        Me.btnPWM875 = New System.Windows.Forms.Button()
        Me.btnPWMOFF = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Com Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud Rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(220, 30)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(211, 21)
        Me.cmbPort.TabIndex = 2
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(220, 80)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(211, 21)
        Me.cmbBaud.TabIndex = 3
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(475, 20)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(127, 23)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(475, 75)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(127, 23)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPWMOFF)
        Me.GroupBox1.Controls.Add(Me.btnPWM875)
        Me.GroupBox1.Controls.Add(Me.btnPWM625)
        Me.GroupBox1.Controls.Add(Me.btnPWM375)
        Me.GroupBox1.Controls.Add(Me.btnPWM125)
        Me.GroupBox1.Controls.Add(Me.btnPWM100)
        Me.GroupBox1.Controls.Add(Me.btnPWM75)
        Me.GroupBox1.Controls.Add(Me.btnPWM50)
        Me.GroupBox1.Controls.Add(Me.btnPWM25)
        Me.GroupBox1.Controls.Add(Me.btnT)
        Me.GroupBox1.Controls.Add(Me.btnOFF)
        Me.GroupBox1.Controls.Add(Me.btnON)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 419)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmit Data"
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(228, 20)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(100, 25)
        Me.btnT.TabIndex = 2
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnOFF
        '
        Me.btnOFF.Location = New System.Drawing.Point(120, 20)
        Me.btnOFF.Name = "btnOFF"
        Me.btnOFF.Size = New System.Drawing.Size(100, 25)
        Me.btnOFF.TabIndex = 1
        Me.btnOFF.Text = "OFF"
        Me.btnOFF.UseVisualStyleBackColor = True
        '
        'btnON
        '
        Me.btnON.Location = New System.Drawing.Point(7, 20)
        Me.btnON.Name = "btnON"
        Me.btnON.Size = New System.Drawing.Size(100, 25)
        Me.btnON.TabIndex = 0
        Me.btnON.Text = "ON"
        Me.btnON.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbReceived)
        Me.GroupBox2.Location = New System.Drawing.Point(628, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 527)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recived Data"
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(22, 32)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.ReadOnly = True
        Me.rtbReceived.Size = New System.Drawing.Size(423, 479)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'SerialPort1
        '
        '
        'btnPWM25
        '
        Me.btnPWM25.Location = New System.Drawing.Point(7, 50)
        Me.btnPWM25.Name = "btnPWM25"
        Me.btnPWM25.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM25.TabIndex = 3
        Me.btnPWM25.Text = "PWM 25%"
        Me.btnPWM25.UseVisualStyleBackColor = True
        '
        'btnPWM50
        '
        Me.btnPWM50.Location = New System.Drawing.Point(120, 50)
        Me.btnPWM50.Name = "btnPWM50"
        Me.btnPWM50.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM50.TabIndex = 4
        Me.btnPWM50.Text = "PWM 50%"
        Me.btnPWM50.UseVisualStyleBackColor = True
        '
        'btnPWM75
        '
        Me.btnPWM75.Location = New System.Drawing.Point(232, 50)
        Me.btnPWM75.Name = "btnPWM75"
        Me.btnPWM75.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM75.TabIndex = 5
        Me.btnPWM75.Text = "PWM 75%"
        Me.btnPWM75.UseVisualStyleBackColor = True
        '
        'btnPWM100
        '
        Me.btnPWM100.Location = New System.Drawing.Point(340, 50)
        Me.btnPWM100.Name = "btnPWM100"
        Me.btnPWM100.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM100.TabIndex = 6
        Me.btnPWM100.Text = "PWM 100%"
        Me.btnPWM100.UseVisualStyleBackColor = True
        '
        'btnPWM125
        '
        Me.btnPWM125.Location = New System.Drawing.Point(7, 81)
        Me.btnPWM125.Name = "btnPWM125"
        Me.btnPWM125.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM125.TabIndex = 7
        Me.btnPWM125.Text = "PWM 12,5%"
        Me.btnPWM125.UseVisualStyleBackColor = True
        '
        'btnPWM375
        '
        Me.btnPWM375.Location = New System.Drawing.Point(120, 81)
        Me.btnPWM375.Name = "btnPWM375"
        Me.btnPWM375.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM375.TabIndex = 8
        Me.btnPWM375.Text = "PWM 37,5%"
        Me.btnPWM375.UseVisualStyleBackColor = True
        '
        'btnPWM625
        '
        Me.btnPWM625.Location = New System.Drawing.Point(232, 81)
        Me.btnPWM625.Name = "btnPWM625"
        Me.btnPWM625.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM625.TabIndex = 9
        Me.btnPWM625.Text = "PWM 62,5%"
        Me.btnPWM625.UseVisualStyleBackColor = True
        '
        'btnPWM875
        '
        Me.btnPWM875.Location = New System.Drawing.Point(340, 81)
        Me.btnPWM875.Name = "btnPWM875"
        Me.btnPWM875.Size = New System.Drawing.Size(80, 25)
        Me.btnPWM875.TabIndex = 10
        Me.btnPWM875.Text = "PWM 87,5%"
        Me.btnPWM875.UseVisualStyleBackColor = True
        '
        'btnPWMOFF
        '
        Me.btnPWMOFF.Location = New System.Drawing.Point(444, 50)
        Me.btnPWMOFF.Name = "btnPWMOFF"
        Me.btnPWMOFF.Size = New System.Drawing.Size(100, 57)
        Me.btnPWMOFF.TabIndex = 11
        Me.btnPWMOFF.Text = "PWMOFF"
        Me.btnPWMOFF.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 559)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Arduino UFI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnOFF As System.Windows.Forms.Button
    Friend WithEvents btnON As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnPWM25 As System.Windows.Forms.Button
    Friend WithEvents btnPWM50 As System.Windows.Forms.Button
    Friend WithEvents btnPWM875 As System.Windows.Forms.Button
    Friend WithEvents btnPWM625 As System.Windows.Forms.Button
    Friend WithEvents btnPWM375 As System.Windows.Forms.Button
    Friend WithEvents btnPWM125 As System.Windows.Forms.Button
    Friend WithEvents btnPWM100 As System.Windows.Forms.Button
    Friend WithEvents btnPWM75 As System.Windows.Forms.Button
    Friend WithEvents btnPWMOFF As System.Windows.Forms.Button

End Class
