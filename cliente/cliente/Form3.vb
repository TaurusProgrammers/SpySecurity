Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class Form3
    Dim RECEPTOR As New UdpClient(2000) 'WEBCAM
    Private Sub ButtonCONECTAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonCONECTAR.Click
        ButtonCONECTAR.BackColor = Color.Red
        RECEPTOR.Client.ReceiveTimeout = 100 'TIEMPO PARA PASAR A ESPERA
        RECEPTOR.Client.Blocking = False 'RECEPTOR NO BLOQUEADO
        RELOJRECIBIR.Start()
    End Sub

    Private Sub RELOJRECIBIR_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles RELOJRECIBIR.Tick
        Try
            Dim IP As IPEndPoint = New IPEndPoint(IPAddress.Any, 0) 'RECIBIRA DESDE CUALQUIER IP Y CUALQUIER PUERTO
            Dim RECIBEMENSAJE As Byte() = RECEPTOR.Receive(IP) 'RECIBE EL MENSAJE EN BYTES
            Dim IMAGEN As New MemoryStream(RECIBEMENSAJE)
            Dim IMAGENRECIBIDA As Image = Image.FromStream(IMAGEN)
            'POSICIONAMIENTO DE LAS IMAGENES EN FUNCION DE LA IP DEL EMISOR
            If IP.Address.ToString = TextBoxIP1.Text Then
                PictureBox1.Image = IMAGENRECIBIDA
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonINTERVALO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonINTERVALO.Click
        RELOJRECIBIR.Interval = CInt(TextBoxINTERVALO.Text)
    End Sub

    Private Sub TextBoxIP1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxIP1.TextChanged
        If TextBoxIP1.Text = "" Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
