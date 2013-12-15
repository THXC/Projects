Imports System.IO.Ports



Public Class Form1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Dim str As String
    Dim value As String

    Private Strt As System.Threading.Thread

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        Try
            With SerialPort1
                .PortName = "COM3"
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With
            SerialPort1.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'Show degrees sign.
        LB_ConnStatus.Text = "Connected"

        Strt = New System.Threading.Thread(AddressOf MyThread1)
        Strt.Start()

    End Sub

    Sub MyThread1()


        OutputString()

    End Sub


    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        str = SerialPort1.ReadExisting()

        OutputString()



    End Sub




    Private Sub OutputString()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf OutputString))
        Else
            ' LB.Text = str
        End If

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        Dim valueInStr As String = CStr(TrackBar1.Value)
        Dim command As String = "M2P0D" + valueInStr + "/"

        SerialPort1.Write(command)
        LB_ServoPos.Text = valueInStr

        System.Threading.Thread.Sleep(100)

    End Sub



    Private Sub RB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.Click
        RB1.Checked = True
        RB2.Checked = False
        RB3.Checked = False
    End Sub

    Private Sub RB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.Click
        RB2.Checked = True
        RB1.Checked = False
        RB3.Checked = False
    End Sub

    Private Sub RB3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB3.Click
        RB3.Checked = True
        RB2.Checked = False
        RB1.Checked = False
    End Sub

    Private Sub Btn_On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_On.Click

        If RB1.Checked = True Then
            SerialPort1.Write("M0P2D1/")
        ElseIf RB2.Checked = True Then
            SerialPort1.Write("M0P3D1/")
        ElseIf RB3.Checked = True Then
            SerialPort1.Write("M0P4D1/")
        End If

    End Sub

    Private Sub btn_Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Off.Click

        If RB1.Checked = True Then
            SerialPort1.Write("M0P2D0/")
        ElseIf RB2.Checked = True Then
            SerialPort1.Write("M0P3D0/")
        ElseIf RB3.Checked = True Then
            SerialPort1.Write("M0P4D0/")
        End If

    End Sub

    Private Sub Btn_Display1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Display1.Click

        For i = 0 To 15

            SerialPort1.Write("M0P2D1/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P2D0/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P3D1/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P3D0/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P4D1/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P4D0/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P5D1/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P5D0/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P6D1/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P6D0/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P7D1/")
            System.Threading.Thread.Sleep(60)
            SerialPort1.Write("M0P7D0/")

        Next


    End Sub

    Private Sub Btn_Display2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Display2.Click

        SerialPort1.Write("M0P2D1/")
        SerialPort1.Write("M0P3D1/")
        SerialPort1.Write("M0P4D1/")
        SerialPort1.Write("M0P5D1/")
        SerialPort1.Write("M0P6D1/")

        For i = 0 To 15
            SerialPort1.Write("M0P2D0/")
            System.Threading.Thread.Sleep(70)
            SerialPort1.Write("M0P2D1/")
            SerialPort1.Write("M0P3D0/")
            System.Threading.Thread.Sleep(70)
            SerialPort1.Write("M0P3D1/")
            SerialPort1.Write("M0P4D0/")
            System.Threading.Thread.Sleep(70)
            SerialPort1.Write("M0P4D1/")
            SerialPort1.Write("M0P5D0/")
            System.Threading.Thread.Sleep(70)
            SerialPort1.Write("M0P5D1/")
            SerialPort1.Write("M0P6D0/")
            System.Threading.Thread.Sleep(70)
            SerialPort1.Write("M0P6D1/")
            SerialPort1.Write("M0P7D0/")
            System.Threading.Thread.Sleep(70)
            SerialPort1.Write("M0P7D1/")

        Next

        SerialPort1.Write("M0P2D0/")
        SerialPort1.Write("M0P3D0/")
        SerialPort1.Write("M0P4D0/")
        SerialPort1.Write("M0P5D0/")
        SerialPort1.Write("M0P6D0/")

    End Sub


    Private Sub RB_S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_S1.Click
        RB_S1.Checked = True
        RB_S2.Checked = False
        RB_S3.Checked = False
    End Sub

    Private Sub RB_S2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_S2.Click
        RB_S1.Checked = False
        RB_S2.Checked = True
        RB_S3.Checked = False
    End Sub

    Private Sub RB_S3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_S3.Click
        RB_S1.Checked = False
        RB_S2.Checked = False
        RB_S3.Checked = True
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll

        Dim valueInStr As String = CStr(TrackBar2.Value)
        Dim command As String = ""

        If CB_Servo0.Checked = True Then
            command = "M2P0D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo1.Checked = True Then
            command = "M2P1D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo2.Checked = True Then
            command = "M2P2D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo3.Checked = True Then
            command = "M2P3D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo4.Checked = True Then
            command = "M2P4D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo5.Checked = True Then
            command = "M2P5D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo6.Checked = True Then
            command = "M2P6D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo7.Checked = True Then
            command = "M2P7D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo8.Checked = True Then
            command = "M2P8D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo9.Checked = True Then
            command = "M2P9D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo10.Checked = True Then
            command = "M2P10D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        System.Threading.Thread.Sleep(1)

        If CB_Servo11.Checked = True Then
            command = "M2P11D" + valueInStr + "/"
            SerialPort1.Write(command)
        End If

        LB_ServoPos.Text = valueInStr

        System.Threading.Thread.Sleep(1)

    End Sub
End Class
