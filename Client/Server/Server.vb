Imports System.IO
Imports System.Net
Imports System.Threading
Imports N = System.Net
Imports System.Collections

Class TalkServ

    Private server As System.Net.Sockets.TcpListener
    Public Shared [handles] As Hashtable
    Public Shared handleByConnect As Hashtable

    Public Shared Sub Main()
        Dim TS As New TalkServ()
    End Sub

    Public Sub New()
        [handles] = New Hashtable(100)
        handleByConnect = New Hashtable(100)
        server = New System.Net.Sockets.TcpListener(4296)
        While True
            server.Start()
            If server.Pending() Then
                Dim connection As N.Sockets.TcpClient = server.AcceptTcpClient()
                Console.WriteLine("Connection made")
                Dim BF As New BackForth(connection)
            End If
        End While
    End Sub

    Public Shared Sub SendToAll(name As String, msg As String)
        Dim SW As StreamWriter
        Dim ToRemove As New ArrayList(0)
        Dim tc As N.Sockets.TcpClient() = New N.Sockets.TcpClient(TalkServ.[handles].Count - 1) {}
        TalkServ.[handles].Values.CopyTo(tc, 0)
        For i As Integer = 0 To tc.Length - 1
            Try
                If msg.Trim() = "" OrElse tc(i) Is Nothing Then
					Continue Try
                End If
                SW = New StreamWriter(tc(i).GetStream())
                SW.WriteLine(name & ": " & msg)
                SW.Flush()
                SW = Nothing
            Catch
                Dim g As String = DirectCast(TalkServ.handleByConnect(tc(i)), String)
                TalkServ.SendSysMsg("** " & g & " ** HAS LEFT US.")
                TalkServ.[handles].Remove(g)
                TalkServ.handleByConnect.Remove(tc(i))
            End Try
        Next
    End Sub

    Public Shared Sub SendSysMsg(msg As String)
        Dim SW As StreamWriter
        Dim ToRemove As New ArrayList(0)
        Dim tc As N.Sockets.TcpClient() = New N.Sockets.TcpClient(TalkServ.[handles].Count - 1) {}
        TalkServ.[handles].Values.CopyTo(tc, 0)
        For i As Integer = 0 To tc.Length - 1
            Try
                If msg.Trim() = "" OrElse tc(i) Is Nothing Then
					Continue Try
                End If
                SW = New StreamWriter(tc(i).GetStream())
                SW.WriteLine(msg)
                SW.Flush()
                SW = Nothing
            Catch
                TalkServ.[handles].Remove(TalkServ.handleByConnect(tc(i)))
                TalkServ.handleByConnect.Remove(tc(i))
            End Try
        Next
    End Sub
End Class
'end of class TalkServ 
Class BackForth
    Private client As N.Sockets.TcpClient
    Private SR As System.IO.StreamReader
    Private SW As System.IO.StreamWriter
    Private handle As String

    Public Sub New(c As System.Net.Sockets.TcpClient)
        client = c
        Dim t As New Thread(New ThreadStart(AddressOf init))
        t.Start()
    End Sub

    Private Function GetHandle() As String
        SW.WriteLine("What is your handle? ")
        SW.Flush()
        Return SR.ReadLine()
    End Function

    Private Sub run()
        Try
            Dim l As String = ""
            While True
                l = SR.ReadLine()
                TalkServ.SendToAll(handle, l)
            End While
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub init()
        SR = New System.IO.StreamReader(client.GetStream())
        SW = New System.IO.StreamWriter(client.GetStream())
        SW.WriteLine("WELCOME TO TalkServ! Be Nice!")
        'SW.WriteLine("What is your handle? "); 
        'SW.Flush(); 
        handle = GetHandle()
        While TalkServ.[handles].Contains(handle)
            SW.WriteLine("ERR - Handle already exists!")
            handle = GetHandle()
        End While
        TalkServ.[handles].Add(handle, client)
        TalkServ.handleByConnect.Add(client, handle)
        TalkServ.SendSysMsg("** " & handle & " ** HAS JOINED US.")
        SW.WriteLine("Now Talking....." & vbCr & vbLf & "-------------------------------")
        SW.Flush()
        Dim t As New Thread(New ThreadStart(AddressOf run))
        t.Start()
    End Sub
End Class
