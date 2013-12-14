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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Com Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud Rate"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = true
        Me.cmbPort.Location = New System.Drawing.Point(220, 30)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(211, 21)
        Me.cmbPort.TabIndex = 2
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = true
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
        Me.btnConnect.UseVisualStyleBackColor = true
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(475, 75)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(127, 23)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconect"
        Me.btnDisconnect.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtTransmit)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Transmit Data"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(436, 29)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(135, 41)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = true
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(27, 40)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(373, 20)
        Me.txtTransmit.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbReceived)
        Me.GroupBox2.Location = New System.Drawing.Point(628, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 527)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Recived Data"
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(22, 32)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(423, 479)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "frmMain"
        Me.Text = "Arduino UFI"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
