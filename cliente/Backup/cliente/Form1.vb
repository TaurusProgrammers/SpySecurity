Public Class Form1
    Private client As TCPController
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            client = New TCPController(TextBox2.Text, 8080)
            If client.client.Connected Then Button1.Text = "Conectado"
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SendMessage()
        Try
            If client.client.Connected = True Then client.send(TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            SendMessage()
            TextBox1.Clear()
            TextBox1.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If client.client.Connected = True Then
                client.clientData.Close()
                client.client.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If TextBox1.Text = "#help" Then
                        Form2.Show()
                    Else
                        SendMessage()
                        TextBox1.Clear()
                        TextBox1.Focus()
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    client = New TCPController(TextBox2.Text, 8080)
                    If client.client.Connected Then Button1.Text = "Conectado"
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
