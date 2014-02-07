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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDisconnected = New System.Windows.Forms.Button()
        Me.btnConnected = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnON = New System.Windows.Forms.Button()
        Me.btnOFF = New System.Windows.Forms.Button()
        Me.lbData = New System.Windows.Forms.ListBox()
        Me.cmbHost = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPort)
        Me.GroupBox1.Controls.Add(Me.cmbHost)
        Me.GroupBox1.Controls.Add(Me.btnDisconnected)
        Me.GroupBox1.Controls.Add(Me.btnConnected)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ethernet"
        '
        'btnDisconnected
        '
        Me.btnDisconnected.Location = New System.Drawing.Point(207, 45)
        Me.btnDisconnected.Name = "btnDisconnected"
        Me.btnDisconnected.Size = New System.Drawing.Size(138, 23)
        Me.btnDisconnected.TabIndex = 5
        Me.btnDisconnected.Text = "Disconnected"
        Me.btnDisconnected.UseVisualStyleBackColor = True
        '
        'btnConnected
        '
        Me.btnConnected.Location = New System.Drawing.Point(207, 16)
        Me.btnConnected.Name = "btnConnected"
        Me.btnConnected.Size = New System.Drawing.Size(138, 23)
        Me.btnConnected.TabIndex = 4
        Me.btnConnected.Text = "Connected"
        Me.btnConnected.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'btnON
        '
        Me.btnON.Location = New System.Drawing.Point(12, 99)
        Me.btnON.Name = "btnON"
        Me.btnON.Size = New System.Drawing.Size(360, 77)
        Me.btnON.TabIndex = 2
        Me.btnON.Text = "ON"
        Me.btnON.UseVisualStyleBackColor = True
        '
        'btnOFF
        '
        Me.btnOFF.Location = New System.Drawing.Point(12, 183)
        Me.btnOFF.Name = "btnOFF"
        Me.btnOFF.Size = New System.Drawing.Size(360, 77)
        Me.btnOFF.TabIndex = 3
        Me.btnOFF.Text = "OFF"
        Me.btnOFF.UseVisualStyleBackColor = True
        '
        'lbData
        '
        Me.lbData.BackColor = System.Drawing.SystemColors.Info
        Me.lbData.FormattingEnabled = True
        Me.lbData.Location = New System.Drawing.Point(378, 12)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(776, 251)
        Me.lbData.TabIndex = 6
        '
        'cmbHost
        '
        Me.cmbHost.FormattingEnabled = True
        Me.cmbHost.Location = New System.Drawing.Point(39, 13)
        Me.cmbHost.Name = "cmbHost"
        Me.cmbHost.Size = New System.Drawing.Size(162, 21)
        Me.cmbHost.TabIndex = 6
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(39, 44)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(162, 21)
        Me.cmbPort.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 463)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.btnOFF)
        Me.Controls.Add(Me.btnON)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Arduino UFI Ethernet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisconnected As System.Windows.Forms.Button
    Friend WithEvents btnConnected As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnON As System.Windows.Forms.Button
    Friend WithEvents btnOFF As System.Windows.Forms.Button
    Friend WithEvents lbData As System.Windows.Forms.ListBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHost As System.Windows.Forms.ComboBox

End Class
