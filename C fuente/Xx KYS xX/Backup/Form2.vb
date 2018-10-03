Public Class Form2
    'CODIGO PROGRAMADO POR KEVYN TAYLOR
    'PROYECTO UNIVERSITY AUTONOMA DEL CARIBE
    'SEGURIDAD INFORMATICA
    'COD 91513260
    'COPYRIGHT 

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If (TextBox1.Text = My.Settings.User And TextBox2.Text = My.Settings.pass) Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    Me.Hide()
                    Form1.NotifyIcon1.Visible = False
                    Form1.Show()
                Else
                    If TextBox1.Text <> My.Settings.User Then
                        MsgBox("Ah introduccido un usuario invalido por favor Verificar", MsgBoxStyle.Critical, "Login Error")
                    End If
                    If TextBox2.Text <> My.Settings.pass Then
                        MsgBox("Ah introduccido un Password invalido por favor Verificar", MsgBoxStyle.Critical, "Login Error")
                    End If
                End If

        End Select
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If (TextBox1.Text = My.Settings.User And TextBox2.Text = My.Settings.pass) Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    Me.Hide()
                    Form1.NotifyIcon1.Visible = False
                    Form1.Show()
                Else
                    If TextBox1.Text <> My.Settings.User Then
                        MsgBox("Ah introduccido un usuario invalido por favor Verificar", MsgBoxStyle.Critical, "Login Error")
                    End If
                    If TextBox2.Text <> My.Settings.pass Then
                        MsgBox("Ah introduccido un Password invalido por favor Verificar", MsgBoxStyle.Critical, "Login Error")
                    End If
                End If
        End Select
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = My.Settings.User And TextBox2.Text = My.Settings.pass) Then
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            Form1.NotifyIcon1.Visible = False
            Form1.Show()
        Else
            If TextBox1.Text <> My.Settings.User Then
                MsgBox("Ah introduccido un usuario invalido por favor Verificar", MsgBoxStyle.Critical, "Login Error")
            End If
            If TextBox2.Text <> My.Settings.pass Then
                MsgBox("Ah introduccido un Password invalido por favor Verificar", MsgBoxStyle.Critical, "Login Error")
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class