<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.CHAT = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CHAT
        '
        Me.CHAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHAT.ForeColor = System.Drawing.Color.Black
        Me.CHAT.Location = New System.Drawing.Point(84, 12)
        Me.CHAT.Name = "CHAT"
        Me.CHAT.Size = New System.Drawing.Size(454, 475)
        Me.CHAT.TabIndex = 12
        Me.CHAT.Text = Global.svchost.My.Resources.Resources._String
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Location = New System.Drawing.Point(567, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "MINIMIZAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Location = New System.Drawing.Point(559, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 41)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CERRAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(567, 495)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(94, 35)
        Me.btnEnviarMensaje.TabIndex = 9
        Me.btnEnviarMensaje.Text = "ENVIAR"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = False
        '
        'TxtMensaje
        '
        Me.TxtMensaje.ForeColor = System.Drawing.Color.Black
        Me.TxtMensaje.Location = New System.Drawing.Point(84, 503)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMensaje.Size = New System.Drawing.Size(314, 30)
        Me.TxtMensaje.TabIndex = 8
        '
        'RELOJ
        '
        Me.RELOJ.Enabled = True
        Me.RELOJ.Interval = 500
        '
        'Timer1
        '
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(25, 19)
        Me.Controls.Add(Me.CHAT)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.Controls.Add(Me.TxtMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHAT As System.Windows.Forms.RichTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnEnviarMensaje As System.Windows.Forms.Button
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents RELOJ As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
