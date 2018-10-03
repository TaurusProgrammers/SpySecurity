<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.ButtonENVIA = New System.Windows.Forms.Button()
        Me.ButtonINICIAR = New System.Windows.Forms.Button()
        Me.PictureBoxVISOR = New System.Windows.Forms.PictureBox()
        Me.RELOJENVIAR = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxVISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonENVIA
        '
        Me.ButtonENVIA.BackColor = System.Drawing.Color.Black
        Me.ButtonENVIA.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonENVIA.Location = New System.Drawing.Point(192, 258)
        Me.ButtonENVIA.Name = "ButtonENVIA"
        Me.ButtonENVIA.Size = New System.Drawing.Size(140, 40)
        Me.ButtonENVIA.TabIndex = 7
        Me.ButtonENVIA.Text = "ENVIAR"
        Me.ButtonENVIA.UseVisualStyleBackColor = False
        '
        'ButtonINICIAR
        '
        Me.ButtonINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonINICIAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonINICIAR.Location = New System.Drawing.Point(12, 258)
        Me.ButtonINICIAR.Name = "ButtonINICIAR"
        Me.ButtonINICIAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonINICIAR.TabIndex = 6
        Me.ButtonINICIAR.Text = "CAMARA"
        Me.ButtonINICIAR.UseVisualStyleBackColor = False
        '
        'PictureBoxVISOR
        '
        Me.PictureBoxVISOR.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxVISOR.Name = "PictureBoxVISOR"
        Me.PictureBoxVISOR.Size = New System.Drawing.Size(320, 240)
        Me.PictureBoxVISOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVISOR.TabIndex = 4
        Me.PictureBoxVISOR.TabStop = False
        '
        'RELOJENVIAR
        '
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(31, 25)
        Me.Controls.Add(Me.ButtonENVIA)
        Me.Controls.Add(Me.ButtonINICIAR)
        Me.Controls.Add(Me.PictureBoxVISOR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisor"
        CType(Me.PictureBoxVISOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonENVIA As System.Windows.Forms.Button
    Friend WithEvents ButtonINICIAR As System.Windows.Forms.Button
    Friend WithEvents PictureBoxVISOR As System.Windows.Forms.PictureBox
    Friend WithEvents RELOJENVIAR As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
