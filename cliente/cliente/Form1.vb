Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
'CODIGO PROGRAMADO POR KEVYN MOLINA TAYLOR
'PROYECTO Developers Secuirty Group
'SEGURIDAD INFORMATICA
'Universidad Autonoma del Caribe Projects
'COD 91513260
'COPYRIGHT 
Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim TEXTOSERVIDOR As String
    Dim WithEvents WinSockCliente As New Cliente
    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click

        With WinSockCliente

            .IPDelHost = TxtIP.Text

            .PuertoDelHost = "8050"
            .Conectar()
            btnConectar.Text = "Conectado"
            TxtIP.Enabled = False
            btnConectar.Enabled = False
            btnEnviarMensaje.Enabled = True
            txtMensaje.Enabled = True

        End With
        TxtMensaje.Focus()
    End Sub



    Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles WinSockCliente.DatosRecibidos

        'MsgBox("El servidor envio el siguiente mensaje: " & datos)

        TEXTOSERVIDOR = datos

    End Sub



    Private Sub WinSockCliente_ConexionTerminada() Handles WinSockCliente.ConexionTerminada

        MsgBox("Finalizo la conexion")
        txtIP.Enabled = True
        btnConectar.Enabled = True
        btnEnviarMensaje.Enabled = False
        txtMensaje.Enabled = False

    End Sub



    Private Sub btnEnviarMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarMensaje.Click

        Dim TEXTOMENSAJE As String = TxtMensaje.Text
        WinSockCliente.EnviarDatos(TxtMensaje.Text)
        TxtMensaje.Text = ""
        TxtMensaje.Focus()
    End Sub
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtMensaje.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
Public Class Cliente



#Region "VARIABLES"

    Private Stm As Stream 'Utilizado para enviar datos al Servidor y recibir datos del mismo

    Private m_IPDelHost As String 'Direccion del objeto de la clase Servidor

    Private m_PuertoDelHost As String 'Puerto donde escucha el objeto de la clase Servidor

#End Region



#Region "EVENTOS"

    Public Event ConexionTerminada()

    Public Event DatosRecibidos(ByVal datos As String)

#End Region



#Region "PROPIEDADES"

    Public Property IPDelHost() As String

        Get

            IPDelHost = m_IPDelHost

        End Get



        Set(ByVal Value As String)

            m_IPDelHost = Value

        End Set

    End Property



    Public Property PuertoDelHost() As String

        Get

            PuertoDelHost = m_PuertoDelHost

        End Get

        Set(ByVal Value As String)

            m_PuertoDelHost = Value

        End Set

    End Property

#End Region



#Region "METODOS"

    Public Sub Conectar()

        Dim tcpClnt As TcpClient

        Dim tcpThd As Thread 'Se encarga de escuchar mensajes enviados por el Servidor



        tcpClnt = New TcpClient()

        'Me conecto al objeto de la clase Servidor,

        '  determinado por las propiedades IPDelHost y PuertoDelHost

        tcpClnt.Connect(IPDelHost, PuertoDelHost)

        Stm = tcpClnt.GetStream()
        'Creo e inicio un thread para que escuche los mensajes enviados por el Servidor

        tcpThd = New Thread(AddressOf LeerSocket)

        tcpThd.Start()

    End Sub



    Public Sub EnviarDatos(ByVal Datos As String)

        Dim BufferDeEscritura() As Byte



        BufferDeEscritura = Encoding.ASCII.GetBytes(Datos)



        If Not (Stm Is Nothing) Then

            'Envio los datos al Servidor

            Stm.Write(BufferDeEscritura, 0, BufferDeEscritura.Length)

        End If

    End Sub



#End Region
#Region "FUNCIONES PRIVADAS"

    Private Sub LeerSocket()

        Dim BufferDeLectura() As Byte



        While True

            Try

                BufferDeLectura = New Byte(100) {}

                'Me quedo esperando a que llegue algun mensaje

                Stm.Read(BufferDeLectura, 0, BufferDeLectura.Length)



                'Genero el evento DatosRecibidos, ya que se han recibido datos desde el Servidor

                RaiseEvent DatosRecibidos(Encoding.ASCII.GetString(BufferDeLectura))

            Catch e As Exception

                Exit While

            End Try

        End While



        'Finalizo la conexion, por lo tanto genero el evento correspondiente

        RaiseEvent ConexionTerminada()

    End Sub

#End Region



End Class