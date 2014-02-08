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
        Me.picON = New System.Windows.Forms.Button()
        Me.picOFF = New System.Windows.Forms.Button()
        Me.btnON = New System.Windows.Forms.Button()
        Me.btnOFF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'picON
        '
        Me.picON.Location = New System.Drawing.Point(276, 98)
        Me.picON.Name = "picON"
        Me.picON.Size = New System.Drawing.Size(75, 23)
        Me.picON.TabIndex = 0
        Me.picON.Text = "ON"
        Me.picON.UseVisualStyleBackColor = True
        '
        'picOFF
        '
        Me.picOFF.Location = New System.Drawing.Point(131, 98)
        Me.picOFF.Name = "picOFF"
        Me.picOFF.Size = New System.Drawing.Size(75, 23)
        Me.picOFF.TabIndex = 1
        Me.picOFF.Text = "OFF"
        Me.picOFF.UseVisualStyleBackColor = True
        '
        'btnON
        '
        Me.btnON.Location = New System.Drawing.Point(276, 167)
        Me.btnON.Name = "btnON"
        Me.btnON.Size = New System.Drawing.Size(75, 23)
        Me.btnON.TabIndex = 2
        Me.btnON.Text = "Button1"
        Me.btnON.UseVisualStyleBackColor = True
        '
        'btnOFF
        '
        Me.btnOFF.Location = New System.Drawing.Point(131, 166)
        Me.btnOFF.Name = "btnOFF"
        Me.btnOFF.Size = New System.Drawing.Size(75, 23)
        Me.btnOFF.TabIndex = 3
        Me.btnOFF.Text = "Button2"
        Me.btnOFF.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 443)
        Me.Controls.Add(Me.btnOFF)
        Me.Controls.Add(Me.btnON)
        Me.Controls.Add(Me.picOFF)
        Me.Controls.Add(Me.picON)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picON As System.Windows.Forms.Button
    Friend WithEvents picOFF As System.Windows.Forms.Button
    Friend WithEvents btnON As System.Windows.Forms.Button
    Friend WithEvents btnOFF As System.Windows.Forms.Button

End Class
