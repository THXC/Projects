
Imports System

Public Class frmMain

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnConnected.Enabled = True
        btnDisconnected.Enabled = False

    End Sub
    Private Sub btConnected_Click(sender As System.Object, e As System.EventArgs) Handles btnConnected.Click
        AxWinsock1.RemoteHost = tbHost.Text
        AxWinsock1.RemotePort = tbPort.Text
        AxWinsock1.Connect()
        btnConnected.Enabled = False
        btnDisconnected.Enabled = True

    End Sub

    Private Sub btnDisconnected_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnected.Click
        AxWinsock1.Close()
        btnConnected.Enabled = True
        btnDisconnected.Enabled = False
    End Sub
End Class
