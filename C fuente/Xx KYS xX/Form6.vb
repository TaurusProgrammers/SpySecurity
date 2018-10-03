Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Public Class Form6
    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    Dim DATOS As IDataObject
    Dim IMAGENCAMARA As Image

    Dim ENVIANTE As New UdpClient() 'WEBCAM
    Public Sub OpenPreviewWindow()
        Try

            ' Open Preview window in picturebox
            '
            hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
               480, PictureBoxVISOR.Handle.ToInt32, 0)

            ' Connect to device
            '
            SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
                '
                'Set the preview scale

                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

                'Set the preview rate in milliseconds
                '
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

                'Start previewing the image from the camera
                '
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

                ' Resize window to fit in picturebox
                '
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureBoxVISOR.Width, PictureBoxVISOR.Height, _
                        SWP_NOMOVE Or SWP_NOZORDER)
                ButtonINICIAR.Visible = False
            Else
                ' Error connecting to device close window
                ' 
                DestroyWindow(hHwnd)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonINICIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonINICIAR.Click
        Try
            OpenPreviewWindow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonENVIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonENVIA.Click
        Try
            ButtonENVIA.Visible = False
            RELOJENVIAR.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RELOJENVIAR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RELOJENVIAR.Tick
        Try
            ' Copy image to clipboard
            '
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

            ' Get image from clipboard and convert it to a bitmap
            '
            DATOS = Clipboard.GetDataObject()

            IMAGENCAMARA = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
            ENVIANTE.Connect(My.Settings.ipmaster, 2000) 'SE CONECTA CON EL RECEPTOR
            Dim ARRAY As New MemoryStream()
            IMAGENCAMARA.Save(ARRAY, Imaging.ImageFormat.Jpeg)
            Dim IMAGEN_ARRAY As Byte() = ARRAY.ToArray
            ENVIANTE.Send(IMAGEN_ARRAY, IMAGEN_ARRAY.Length) 'ENVIA EL MENSAJE
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            ButtonINICIAR.PerformClick()
            Timer2.Interval = 10000
            Timer2.Enabled = True
            Timer1.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            ButtonENVIA.PerformClick()
            Timer2.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Timer1.Enabled = True
    End Sub
End Class