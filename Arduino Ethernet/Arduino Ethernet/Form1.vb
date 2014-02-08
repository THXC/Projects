Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Dim tcpClient As New System.Net.Sockets.TcpClient()
    Dim networkStream As NetworkStream
    Dim KeyPressed As Integer

    Private Function Arduino_Connect(ByVal IP As String, ByVal Port As Integer) As Boolean
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

    Private Sub Form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Arduino_Connect("192.168.178.199", 8496)

        picOff.Visible = True
        picOn.Visible = False
    End Sub
    Private Sub Arduino_Disconnect()
        If Not IsNothing(networkStream) Then
            tcpClient.Close()
            networkStream = Nothing
        End If
    End Sub

    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
        picOff.Visible = False
        picOn.Visible = True
        Arduino_Write("O")
    End Sub

    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.CLick
        picOff.Visible = True
        picOn.Visible = False
        Arduino_Write("F")
    End Sub

    'Private Sub Control_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Control.KeyDown
    '    Select Case KeyPressed
    '        Case 38 ' Up
    '            'Car_Stop()
    '        Case 40 ' Down
    '            ' Car_Stop()
    '        Case 39 ' Right
    '            'MsgBox("You pressed Ctrl and Arrowkey Right")
    '            picOff.Visible = False
    '            picOn.Visible = True
    '            Arduino_Write("O")
    '        Case 37 ' Left
    '            ' Car_TurnNone()
    '    End Select
    '    KeyPressed = 0
    'End Sub

    'Private Sub Control_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Control.KeyUp
    '    KeyPressed = e.KeyCode
    '    Select Case KeyPressed
    '        Case 38 ' Up
    '            'Car_ForwardDrive(Speed.Text)
    '        Case 40 ' Down
    '            'Car_BackwardDrive(Speed.Text)
    '        Case 39 ' Right
    '            picOff.Visible = True
    '            picOn.Visible = False
    '            Arduino_Write("F")
    '        Case 37 ' Left
    '            ' Car_TurnLeft()
    '    End Select
    'End Sub

End Class