Imports System.Net.Sockets
Imports System.Text


Public Class Form1
    Dim tcpClient As New System.Net.Sockets.TcpClient()
    Dim networkStream As NetworkStream

    Private Function Arduino_Connect(ByVal IP As String, ByVal Port As Integer) As Boolean
        tcpClient = New TcpClient
        tcpClient.Connect(IP, Port)
        networkStream = tcpClient.GetStream()
        If Not networkStream.CanWrite Or Not networkStream.CanRead Then
            tcpClient.Close()
            networkStream = Nothing
            Return False
        End If
        Return True
    End Function

    Private Sub Arduino_Write(ByVal Output As String)
        If Not IsNothing(networkStream) Then
            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(Output)
            Dim endByte As [Byte]() = {&HFE}
            networkStream.Write(sendBytes, 0, sendBytes.Length)
            networkStream.Write(endByte, 0, 1)
        Else
            MsgBox("ERROR")
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        btnDisconnected.Enabled = False

        btnON_1.Enabled = False
        btnON_2.Enabled = False
        btnON_3.Enabled = False
        btnON_4.Enabled = False
        btnON_5.Enabled = False
        btnON_6.Enabled = False
        btnON_7.Enabled = False
        btnON_8.Enabled = False
        btnON_9.Enabled = False
        btnON_10.Enabled = False
        btnON_11.Enabled = False
        btnON_12.Enabled = False

        btnOFF_1.Enabled = False
        btnOFF_2.Enabled = False
        btnOFF_3.Enabled = False
        btnOFF_4.Enabled = False
        btnOFF_5.Enabled = False
        btnOFF_6.Enabled = False
        btnOFF_7.Enabled = False
        btnOFF_8.Enabled = False
        btnOFF_9.Enabled = False
        btnOFF_10.Enabled = False
        btnOFF_11.Enabled = False
        btnOFF_12.Enabled = False

    End Sub

    Private Sub btnConnected_Click(sender As System.Object, e As System.EventArgs) Handles btnConnected.Click

        'Arduino_Connect(tbHost.Text, tbPort.Text)

        Arduino_Connect("192.168.178.199", 8496)

        btnConnected.Enabled = False
        btnDisconnected.Enabled = True

        btnON_1.Enabled = True
        btnON_2.Enabled = True
        btnON_3.Enabled = True

        btnON_4.Enabled = True
        btnON_5.Enabled = True
        btnON_6.Enabled = True
        btnON_7.Enabled = True
        btnON_8.Enabled = True
        btnON_9.Enabled = True
        btnON_10.Enabled = True
        btnON_11.Enabled = True
        btnON_12.Enabled = True

        btnOFF_1.Enabled = True
        btnOFF_2.Enabled = True
        btnOFF_3.Enabled = True

        btnOFF_4.Enabled = True
        btnOFF_5.Enabled = True
        btnOFF_6.Enabled = True
        btnOFF_7.Enabled = True
        btnOFF_8.Enabled = True
        btnOFF_9.Enabled = True
        btnOFF_10.Enabled = True
        btnOFF_11.Enabled = True
        btnOFF_12.Enabled = True

    End Sub

    Private Sub btnDisconnected_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnected.Click
        If Not tcpClient Is Nothing Then
            tcpClient.Close()
            tcpClient.Client.Dispose()
            tcpClient = Nothing

            btnConnected.Enabled = True
            btnDisconnected.Enabled = False

            btnON_1.Enabled = False
            btnON_2.Enabled = False
            btnON_3.Enabled = False
            btnON_4.Enabled = False
            btnON_5.Enabled = False
            btnON_6.Enabled = False
            btnON_7.Enabled = False
            btnON_8.Enabled = False
            btnON_9.Enabled = False
            btnON_10.Enabled = False
            btnON_11.Enabled = False
            btnON_12.Enabled = False

            btnOFF_1.Enabled = False
            btnOFF_2.Enabled = False
            btnOFF_3.Enabled = False
            btnOFF_4.Enabled = False
            btnOFF_5.Enabled = False
            btnOFF_6.Enabled = False
            btnOFF_7.Enabled = False
            btnOFF_8.Enabled = False
            btnOFF_9.Enabled = False
            btnOFF_10.Enabled = False
            btnOFF_11.Enabled = False
            btnOFF_12.Enabled = False

        End If
    End Sub

    Private Sub btON_1_Click(sender As System.Object, e As System.EventArgs) Handles btnON_1.Click

        Arduino_Write("0")

        btnOFF_1.Enabled = True
        btnON_1.Enabled = False

    End Sub

    Private Sub btOFF_1_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_1.Click

        Arduino_Write("1")

        btnON_1.Enabled = True
        btnOFF_1.Enabled = False

    End Sub

    Private Sub btnON_2_Click(sender As System.Object, e As System.EventArgs) Handles btnON_2.Click

        Arduino_Write("2")

        btnOFF_2.Enabled = True
        btnON_2.Enabled = False

    End Sub

    Private Sub btnOFF_2_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_2.Click

        Arduino_Write("3")

        btnON_2.Enabled = True
        btnOFF_2.Enabled = False

    End Sub

    Private Sub btnON_3_Click(sender As System.Object, e As System.EventArgs) Handles btnON_3.Click

        Arduino_Write("4")

        btnOFF_3.Enabled = True
        btnON_3.Enabled = False

    End Sub

    Private Sub btnOFF_3_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_3.Click

        Arduino_Write("5")

        btnON_3.Enabled = True
        btnOFF_3.Enabled = False

    End Sub

    Private Sub btnON_4_Click(sender As System.Object, e As System.EventArgs) Handles btnON_4.Click

        Arduino_Write("6")

        btnOFF_4.Enabled = True
        btnON_4.Enabled = False

    End Sub

    Private Sub btnOFF_4_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_4.Click

        Arduino_Write("7")

        btnON_4.Enabled = True
        btnOFF_4.Enabled = False

    End Sub

    Private Sub btnON_5_Click(sender As System.Object, e As System.EventArgs) Handles btnON_5.Click

        Arduino_Write("8")

        btnOFF_5.Enabled = True
        btnON_5.Enabled = False

    End Sub

    Private Sub btnOFF_5_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_5.Click

        Arduino_Write("9")

        btnON_5.Enabled = True
        btnOFF_5.Enabled = False

    End Sub

    Private Sub btnON_6_Click(sender As System.Object, e As System.EventArgs) Handles btnON_6.Click

        Arduino_Write("q")

        btnOFF_6.Enabled = True
        btnON_6.Enabled = False

    End Sub

    Private Sub btnOFF_6_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_6.Click

        Arduino_Write("w")

        btnON_6.Enabled = True
        btnOFF_6.Enabled = False

    End Sub

    Private Sub btnON_7_Click(sender As System.Object, e As System.EventArgs) Handles btnON_7.Click

        Arduino_Write("!")

        btnOFF_7.Enabled = True
        btnON_7.Enabled = False

    End Sub

    Private Sub btnOFF_7_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_7.Click

        Arduino_Write("e")

        btnON_7.Enabled = True
        btnOFF_7.Enabled = False

    End Sub

    Private Sub btnON_8_Click(sender As System.Object, e As System.EventArgs) Handles btnON_8.Click

        Arduino_Write("r")

        btnOFF_8.Enabled = True
        btnON_8.Enabled = False

    End Sub

    Private Sub btnOFF_8_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_8.Click

        Arduino_Write("$")

        btnON_8.Enabled = True
        btnOFF_8.Enabled = False

    End Sub

    Private Sub btnON_9_Click(sender As System.Object, e As System.EventArgs) Handles btnON_9.Click

        Arduino_Write("%")

        btnOFF_9.Enabled = True
        btnON_9.Enabled = False

    End Sub

    Private Sub btnOFF_9_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_9.Click

        Arduino_Write("&")

        btnON_9.Enabled = True
        btnOFF_9.Enabled = False

    End Sub

    Private Sub btnON_10_Click(sender As System.Object, e As System.EventArgs) Handles btnON_10.Click

        Arduino_Write("/")

        btnOFF_10.Enabled = True
        btnON_10.Enabled = False

    End Sub

    Private Sub btnOFF_10_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_10.Click

        Arduino_Write("{")

        btnON_10.Enabled = True
        btnOFF_10.Enabled = False

    End Sub

    Private Sub btnON_11_Click(sender As System.Object, e As System.EventArgs) Handles btnON_11.Click

        Arduino_Write("(")

        btnOFF_11.Enabled = True
        btnON_11.Enabled = False

    End Sub

    Private Sub btnOFF_11_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_11.Click

        Arduino_Write("[")

        btnON_11.Enabled = True
        btnOFF_11.Enabled = False

    End Sub

    Private Sub btnON_12_Click(sender As System.Object, e As System.EventArgs) Handles btnON_12.Click

        Arduino_Write(")")

        btnOFF_12.Enabled = True
        btnON_12.Enabled = False

    End Sub

    Private Sub btnOFF_12_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF_12.Click

        Arduino_Write("]")

        btnON_12.Enabled = True
        btnOFF_12.Enabled = False

    End Sub

End Class
