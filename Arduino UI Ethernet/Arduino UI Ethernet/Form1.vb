Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic

Public Class frmMain
    Dim tcpClient As New System.Net.Sockets.TcpClient()
    Dim networkStream As NetworkStream = tcpClient.GetStream()


    Private Function ArduinoUFIEthernet_Connect(ByVal IP As String, ByVal Port As Integer) As Boolean
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

    Private Sub ArduinoUFIEthernet_Disconnect()
        If Not IsNothing(networkStream) Then
            tcpClient.Close()
            networkStream = Nothing
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbHost.Items.Add("192.168.178.199")
        'cmbHost.Items.Add(cmbHost.Text)

        cmbPort.Items.Add(8496)
        'cmbPort.Items.Add(cmbPort.Text)


        cmbHost.Text = cmbHost.Items.Item(0)
        cmbPort.Text = cmbPort.Items.Item(0)

        btnConnected.Enabled = True
        btnDisconnected.Enabled = False

        btnON.Enabled = False
        btnOFF.Enabled = False

    End Sub

    Private Sub btConnected_Click(sender As System.Object, e As System.EventArgs) Handles btnConnected.Click
        ArduinoUFIEthernet_Connect(cmbHost.Text, cmbPort.Text)

        btnConnected.Enabled = False
        btnDisconnected.Enabled = True

        btnON.Enabled = True
        btnOFF.Enabled = True

    End Sub

    Private Sub btnDisconnected_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnected.Click

        ArduinoUFIEthernet_Disconnect()

        btnConnected.Enabled = True
        btnDisconnected.Enabled = False

        btnON.Enabled = False
        btnOFF.Enabled = False

    End Sub

    Private Sub btnON_Click(sender As System.Object, e As System.EventArgs) Handles btnON.Click

        btnON.Enabled = False
        btnOFF.Enabled = True


    End Sub

    Private Sub btnOFF_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF.Click

        btnON.Enabled = True
        btnOFF.Enabled = False


    End Sub

    Private Sub lbData_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbData.SelectedIndexChanged
        If networkStream.CanRead Then
            Dim bytes(tcpClient.ReceiveBufferSize) As Byte
            networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
            Dim returndata As String = Encoding.ASCII.GetString(bytes)
            lbData.Text(returndata)
        Else
            lbData.WriteLine()

        End If
    End Sub
End Class