Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.PasswordChar = "*"
        If My.Settings.capt = "vacio" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
        End If
        If My.Settings.capt = "Op1" Then
            CheckBox16.Checked = True
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
        End If
        If My.Settings.capt = "Op2" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = True
            CheckBox18.Checked = False
            CheckBox19.Checked = False
        End If
        If My.Settings.capt = "Op3" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = True
            CheckBox19.Checked = False
        End If
        If My.Settings.capt = "Op4" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = True
        End If
        If (My.Settings.AutR = True) Then
            CheckBox11.Checked = True
            CheckBox10.Checked = False
        Else
            CheckBox10.Checked = True
            CheckBox11.Checked = False
        End If
        If My.Settings.Setting = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox2.Text = My.Settings.remi
            TextBox3.Text = My.Settings.contra
            TextBox1.Text = My.Settings.desti
        Else
            CheckBox2.Checked = False
            CheckBox1.Checked = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox2.Text = My.Settings.remi
            TextBox3.Text = My.Settings.contra
            TextBox1.Text = My.Settings.desti
        End If
        If My.Settings.ActT = True Then
            CheckBox3.Checked = True
            CheckBox4.Checked = False
            TextBox4.Enabled = False
            ComboBox1.Enabled = False
            TextBox4.Text = "12"
            ComboBox1.Text = "Seg"
        Else
            CheckBox3.Checked = False
            CheckBox4.Checked = True
            TextBox4.Enabled = True
            ComboBox1.Enabled = True
            TextBox4.Text = My.Settings.Tm
            ComboBox1.Text = My.Settings.TP
        End If
        If My.Settings.No = True Then
            CheckBox6.Checked = True
            CheckBox5.Checked = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox5.Text = My.Settings.pass
            TextBox6.Text = My.Settings.User
        Else
            CheckBox5.Checked = True
            CheckBox6.Checked = False
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox5.Text = My.Settings.pass
            TextBox6.Text = My.Settings.User
        End If

        If (CheckBox11.Checked = True) Then
            CheckBox10.Checked = False
            My.Settings.AutR = True
        Else
            CheckBox11.Checked = False
            CheckBox10.Checked = True
            My.Settings.AutR = False
        End If
        If My.Settings.remot = False Then
            CheckBox14.Checked = True
            CheckBox15.Checked = False
        Else
            CheckBox14.Checked = False
            CheckBox15.Checked = True
        End If
        If My.Settings.icono = False Then
            CheckBox9.Checked = True
            CheckBox8.Checked = False
        Else
            CheckBox9.Checked = False
            CheckBox8.Checked = True
        End If

        If (My.Settings.Setting = False) And (My.Settings.ruta = "vacio") And (My.Settings.ActT = True) And (My.Settings.No = True) And (My.Settings.icono = False) And (My.Settings.AutR = True) And (My.Settings.EsIn = False) And (My.Settings.remot = False) Then
            MsgBox("Actualmente utiliza configuración predeterminada del software", MsgBoxStyle.Information, "Informacion")
        End If
    End Sub

    Private Sub CheckBox1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        CheckBox1.Checked = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        CheckBox2.Checked = False
    End Sub

    Private Sub CheckBox2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        CheckBox2.Checked = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        CheckBox1.Checked = False
    End Sub
    Private Sub CheckBox3_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        CheckBox3.Checked = True
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox4_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox4.Click
        CheckBox4.Checked = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
        CheckBox3.Checked = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.Setting = False
            My.Settings.remi = "jromero97s@hotmail.com"
            My.Settings.contra = "sanmartin.edu"
            My.Settings.desti = "jromero97s@hotmail.com"
        End If
        If CheckBox2.Checked = True Then
            My.Settings.Setting = True
            My.Settings.remi = TextBox2.Text
            My.Settings.contra = TextBox3.Text
            My.Settings.desti = TextBox1.Text
        End If
        If CheckBox3.Checked = True Then
            My.Settings.ActT = True
            My.Settings.ControlTM = "120000"
            My.Settings.Tm = "12"
            My.Settings.TP = "Seg"
        End If
        If CheckBox4.Checked = True Then
            Dim TM As Integer
            If ComboBox1.Text = "Seg" Then
                TM = Val(TextBox4.Text * 1000)
            End If
            If ComboBox1.Text = "Min" Then
                TM = Val(TextBox4.Text * 60000)
            End If
            If ComboBox1.Text = "Hrs" Then
                TM = Val(TextBox4.Text * 3600000)
            End If
            If ComboBox1.Text = "Dia" Then
                TM = Val(TextBox4.Text * 86400000)
            End If
            My.Settings.ControlTM = TM
            My.Settings.Tm = TextBox4.Text
            My.Settings.TP = ComboBox1.Text
            My.Settings.ActT = False
        End If
        If CheckBox5.Checked = True Then
            My.Settings.No = False
            My.Settings.User = TextBox6.Text
            My.Settings.pass = TextBox5.Text
        End If
        If CheckBox6.Checked = True Then
            My.Settings.No = True
            My.Settings.User = "Developers"
            My.Settings.pass = "ciscosecurity"
        End If
        If CheckBox9.Checked = True Then
            CheckBox8.Checked = False
            My.Settings.icono = False
        End If
        If CheckBox8.Checked = True Then
            CheckBox9.Checked = False
            My.Settings.icono = True
        End If

        My.Settings.Save()
        Dim sM = MsgBox("Configuración manual Guardada exitosamente", MsgBoxStyle.Information, "Informacion")
        If sM = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (My.Settings.ruta = "vacio") Then
            If (My.Settings.AutR = True) Then
                Dim ru As String
                System.IO.Directory.CreateDirectory(Label13.Text + "\Spy" + My.Settings.Cor)
                ru = (Label13.Text + "\Spy" + My.Settings.Cor)
                Form3.ToolStripStatusLabel1.Text = (ru)
                My.Settings.ruta = Form3.ToolStripStatusLabel1.Text
            Else
                Form1.FolderBrowserDialog1.ShowDialog()
                Form3.ToolStripStatusLabel1.Text = Form1.FolderBrowserDialog1.SelectedPath
                My.Settings.ruta = Form3.ToolStripStatusLabel1.Text
            End If
        Else
            Form3.ToolStripStatusLabel1.Text = My.Settings.ruta
        End If
        MsgBox("la ruta se ah seleccionado con exito", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (CheckBox11.Checked = True) Then
            CheckBox10.Checked = False
            My.Settings.AutR = True
        Else
            CheckBox11.Checked = False
            CheckBox10.Checked = True
            My.Settings.AutR = False
        End If
        If (CheckBox13.Checked = True) Then
            CheckBox12.Checked = False
            My.Settings.EsIn = True
        Else
            CheckBox12.Checked = True
            CheckBox13.Checked = False
            My.Settings.EsIn = False
        End If
        If CheckBox14.Checked = True Then
            CheckBox15.Checked = False
            My.Settings.remot = False
        End If
        If CheckBox15.Checked = True Then
            CheckBox14.Checked = False
            My.Settings.remot = True
            Form8.Show()
        End If
        If (CheckBox16.Checked = False) And (CheckBox17.Checked = False) And (CheckBox18.Checked = False) And (CheckBox19.Checked = False) Then
            My.Settings.capt = "vacio"
        Else
            If (CheckBox16.Checked = True) Then
                My.Settings.capt = "Op1"
                Form1.Timer8.Interval = 3000
                Form1.Timer8.Enabled = True
            Else
                Form1.Timer8.Enabled = False
            End If
            If (CheckBox17.Checked = True) Then
                My.Settings.capt = "Op2"
                Form1.Timer4.Interval = 15000
                Form1.Timer3.Enabled = True
                Form1.Timer4.Enabled = True
            Else
                Form1.Timer3.Enabled = False
                Form1.Timer4.Enabled = False
            End If
            If (CheckBox19.Checked = True) Then
                My.Settings.capt = "Op3"
                Form1.Timer9.Interval = 3000
                Form1.Timer9.Enabled = True
            Else
                Form1.Timer9.Enabled = False
            End If
            If (CheckBox18.Checked = True) Then
                My.Settings.capt = "Op4"
                Form1.Timer7.Interval = My.Settings.ControlTM
                Form1.Timer7.Enabled = True
            Else
                Form1.Timer7.Enabled = False
            End If
        End If
        My.Settings.Save()
        Dim sM = MsgBox("Configuración manual Guardada exitosamente", MsgBoxStyle.Information, "Informacion")
        If sM = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox5.Click
        CheckBox5.Checked = True
        TextBox6.Enabled = True
        TextBox5.Enabled = True
        CheckBox6.Checked = False
    End Sub

    Private Sub CheckBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox6.Click
        CheckBox6.Checked = True
        TextBox6.Enabled = False
        TextBox5.Enabled = False
        CheckBox5.Checked = False
    End Sub

    Private Sub CheckBox11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox11.Click
        CheckBox11.Checked = True
        CheckBox10.Checked = False
    End Sub

    Private Sub CheckBox10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox10.Click
        CheckBox11.Checked = False
        CheckBox10.Checked = True
    End Sub

    Private Sub CheckBox13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox13.Click
        CheckBox13.Checked = True
        CheckBox12.Checked = False
    End Sub

    Private Sub CheckBox12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox12.Click
        CheckBox12.Checked = True
        CheckBox13.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.Setting = False
        My.Settings.ActT = True
        My.Settings.No = True
        My.Settings.icono = False
        My.Settings.AutR = True
        My.Settings.EsIn = False
        My.Settings.AutR = True
        My.Settings.remot = False
        My.Settings.ruta = "vacio"
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Settings.Setting = False
        My.Settings.ruta = "vacio"
        My.Settings.ActT = True
        My.Settings.No = True
        My.Settings.icono = False
        My.Settings.AutR = True
        My.Settings.EsIn = False
        My.Settings.AutR = True
        My.Settings.remot = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        Me.Close()
    End Sub

    Private Sub CheckBox14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox14.Click
        CheckBox14.Checked = True
        CheckBox15.Checked = False
    End Sub

    Private Sub CheckBox15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox15.Click
        CheckBox15.Checked = True
        CheckBox14.Checked = False
    End Sub

    Private Sub CheckBox9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox9.Click
        CheckBox9.Checked = True
        CheckBox8.Checked = False
    End Sub

    Private Sub CheckBox8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox8.Click
        CheckBox8.Checked = True
        CheckBox9.Checked = False
    End Sub

    Private Sub CheckBox16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox16.Click
        If My.Settings.ruta <> "vacio" Then
            CheckBox16.Checked = True
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
        Else
            MsgBox("Debe seleccionar previamente una ruta", MsgBoxStyle.Critical, "Informacion")
            CheckBox16.Checked = False
        End If
    End Sub

    Private Sub CheckBox17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox17.Click
        If My.Settings.ruta <> "vacio" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = True
            CheckBox18.Checked = False
            CheckBox19.Checked = False
        Else
            MsgBox("Debe seleccionar previamente una ruta", MsgBoxStyle.Critical, "Informacion")
            CheckBox17.Checked = False
        End If
        
    End Sub

    Private Sub CheckBox18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox18.Click
        If My.Settings.ruta <> "vacio" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = True
            CheckBox19.Checked = False
        Else
            MsgBox("Debe seleccionar previamente una ruta", MsgBoxStyle.Critical, "Informacion")
            CheckBox18.Checked = False
        End If
    End Sub

    Private Sub CheckBox19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox19.Click
        If My.Settings.ruta <> "vacio" Then
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = True
        Else
            MsgBox("Debe seleccionar previamente una ruta", MsgBoxStyle.Critical, "Informacion")
            CheckBox19.Checked = False
        End If
    End Sub

End Class