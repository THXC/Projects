


Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Public Class Form1

    Dim myPort As Array                                                                          'COM Ports detected on the system will be stored here 
    Delegate Sub SetTextCallback(ByVal [text] As String)                                         'Added to prevent threading errors during receiveing of data
    'DECLARE A COMM PORT 
    Dim WithEvents port As SerialPort = New  _
    System.IO.Ports.SerialPort("COM1", _
                                9600, _
                                Parity.None, _
                                8, _
                                StopBits.One)

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When our form loads, auto detect all serial ports in the system and populate the cmbPort Combo box. 
        myPort = IO.Ports.SerialPort.GetPortNames()                                              'Get all com ports available 
        cmbBaud.Items.Add(9600)                                                                  'Populate the cmbBaud Combo box to common baud rates used 
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)                                                     'Set cmbPort text to the first COM port detected 
        cmbBaud.Text = cmbBaud.Items.Item(0)                                                     'Set cmbBaud text to the first Baud rate on the list 

        SerialPort1.PortName = cmbPort.Text                                                      'Set SerialPort1 to the selected COM port at startup 
        SerialPort1.BaudRate = cmbBaud.Text                                                      'Set Baud rate to the selected value on
        btnDisconnect.Enabled = False                                                            'Initially Disconnect Button is Disabled 
    End Sub

    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnConnect.Click
        'Open our serial port
        SerialPort1.Open()
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        btnConnect.Enabled = False
        btnDisconnect.Enabled = True

    End Sub

    Private Sub btnDisconnect_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()                                                                      'Close our Serial Port 
        btnDisconnect.Enabled = False
        btnConnect.Enabled = True
    End Sub


    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())    'Automatically called every time a data is received at the serialPort 
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread 
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.rtbReceived.Text &= [text]
        End If
    End Sub

    Private Sub cmbPort_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text                 'pop a message box to user if he is changing ports 
        Else                                                    'without disconnecting first. 
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub

    Private Sub cmbBaud_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text                 'pop a message box to user if he is changing baud rate 
        Else                                                    'without disconnecting first. 
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        rtbReceived.Clear()
    End Sub

End Class
