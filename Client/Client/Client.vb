Imports System.IO
Imports System.Net
Imports System.Threading
Imports N = System.Net
Imports System.Collections
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Class TalkUser
    Shared talk As Form
    Shared TC As N.Sockets.TcpClient

    <DllImport("kernel32.dll")> _
    Private Shared Sub ExitProcess(a As Integer)
    End Sub

    Public Shared Sub Main()
        talk = New Form()
        talk.Text = "TalkUser - The OFFICIAL TalkServ Client"
        AddHandler talk.Closing, New CancelEventHandler(AddressOf talk_Closing)
        talk.Controls.Add(New TextBox())
        talk.Controls(0).Dock = DockStyle.Fill
        talk.Controls.Add(New TextBox())
        talk.Controls(1).Dock = DockStyle.Bottom
        DirectCast(talk.Controls(0), TextBox).Multiline = True
        DirectCast(talk.Controls(1), TextBox).Multiline = True
        talk.WindowState = FormWindowState.Maximized
        talk.Show()
        AddHandler DirectCast(talk.Controls(1), TextBox).KeyUp, New KeyEventHandler(AddressOf key_up)
        TC = New N.Sockets.TcpClient()
        TC.Connect("IP OF A SERVER HERE", 4296)
        Dim t As New Thread(New ThreadStart(AddressOf run))
        t.Start()
        While True
            Application.DoEvents()
        End While
    End Sub

    Private Shared Sub talk_Closing(s As Object, e As CancelEventArgs)
        e.Cancel = False
        Application.[Exit]()
        ExitProcess(0)
    End Sub

    Private Shared Sub key_up(s As Object, e As KeyEventArgs)
        Dim TB As TextBox = DirectCast(s, TextBox)
        If TB.Lines.Length > 1 Then
            Dim SW As New StreamWriter(TC.GetStream())
            SW.WriteLine(TB.Text)
            SW.Flush()
            TB.Text = ""
            TB.Lines = Nothing
        End If
    End Sub

    Private Shared Sub run()
        Dim SR As New StreamReader(TC.GetStream())
        While True
            Application.DoEvents()
            Dim TB As TextBox = DirectCast(talk.Controls(0), TextBox)
            TB.AppendText(SR.ReadLine() & vbCr & vbLf)
            TB.SelectionStart = TB.Text.Length
        End While
    End Sub
End Class