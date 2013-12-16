
Imports System

Public Class frmMain

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        btnConnected.Enabled = True
        btnDisconnected.Enabled = False

        btnON.Enabled = False
        btnOFF.Enabled = False

    End Sub
    Private Sub btConnected_Click(sender As System.Object, e As System.EventArgs) Handles btnConnected.Click

        AxWinsock1.RemoteHost = tbHost.Text
        AxWinsock1.RemotePort = tbPort.Text
        AxWinsock1.Connect()

        btnConnected.Enabled = False
        btnDisconnected.Enabled = True

        btnON.Enabled = True
        btnOFF.Enabled = True

    End Sub

    Private Sub btnDisconnected_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnected.Click

        AxWinsock1.Close()

        btnConnected.Enabled = True
        btnDisconnected.Enabled = False

        btnON.Enabled = False
        btnOFF.Enabled = False

    End Sub

    Private Sub btnON_Click(sender As System.Object, e As System.EventArgs) Handles btnON.Click

        btnON.Enabled = False
        btnOFF.Enabled = True

        AxWinsock1.SendData("ON")

    End Sub

    Private Sub btnOFF_Click(sender As System.Object, e As System.EventArgs) Handles btnOFF.Click

        btnON.Enabled = True
        btnOFF.Enabled = False

        AxWinsock1.SendData("OFF")

    End Sub

    Private Sub Winsock1_DataArrival(ByVal bytesTotal As Long)
        Dim sData As String
        AxWinsock1.GetData(sData, vbString, 50)
        RichTextBox1.Text = sData


    End Sub
End Class
