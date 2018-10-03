Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Public Class TCPController
    Public client As TcpClient
    Public clientData As StreamWriter

    Public Sub New(ByVal host As String, ByVal port As Integer)
        client = New TcpClient(host, port)
        clientData = New StreamWriter(client.GetStream)
    End Sub
    Public Sub send(ByVal Data As String)
        clientData.Write(Data & vbCrLf)
        clientData.Flush()
    End Sub
End Class
