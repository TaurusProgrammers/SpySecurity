Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading
Public Class TCPController
    Public Function getIp() As String
        Dim valorIp As String
        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
        Return valorIp
    End Function
    Public Event MessageReceived(ByVal sendre As TCPController, ByVal Data As String)
    Public serverIP As IPAddress = IPAddress.Parse(getIp)
    Public serverPort As Integer = 8080
    Public server As TcpListener
    Private comThread As Thread
    Public isListening As Boolean = True


    Private client As TcpClient
    Private clienteData As StreamReader


    Private Sub listening()
        Do Until isListening = False
            If server.Pending = True Then
                client = server.AcceptTcpClient
                clienteData = New StreamReader(client.GetStream)
            End If
            Try
                RaiseEvent MessageReceived(Me, clienteData.ReadLine)
            Catch ex As Exception

            End Try
            Thread.Sleep(100)

        Loop
    End Sub

    Public Sub New()
        server = New TcpListener(serverIP, serverPort)
        server.Start()
        comThread = New Thread(New ThreadStart(AddressOf listening))
        comThread.Start()
    End Sub
End Class
