<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.RELOJRECIBIR = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonINTERVALO = New System.Windows.Forms.Button()
        Me.TextBoxINTERVALO = New System.Windows.Forms.TextBox()
        Me.TextBoxIP1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCONECTAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RELOJRECIBIR
        '
        '
        'ButtonINTERVALO
        '
        Me.ButtonINTERVALO.BackColor = System.Drawing.Color.Black
        Me.ButtonINTERVALO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonINTERVALO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonINTERVALO.ForeColor = System.Drawing.Color.Lime
        Me.ButtonINTERVALO.Location = New System.Drawing.Point(382, 111)
        Me.ButtonINTERVALO.Name = "ButtonINTERVALO"
        Me.ButtonINTERVALO.Size = New System.Drawing.Size(140, 42)
        Me.ButtonINTERVALO.TabIndex = 23
        Me.ButtonINTERVALO.Text = "INTERVALO"
        Me.ButtonINTERVALO.UseVisualStyleBackColor = False
        '
        'TextBoxINTERVALO
        '
        Me.TextBoxINTERVALO.Location = New System.Drawing.Point(411, 83)
        Me.TextBoxINTERVALO.Name = "TextBoxINTERVALO"
        Me.TextBoxINTERVALO.Size = New System.Drawing.Size(86, 20)
        Me.TextBoxINTERVALO.TabIndex = 22
        Me.TextBoxINTERVALO.Text = "500"
        Me.TextBoxINTERVALO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxIP1
        '
        Me.TextBoxIP1.Location = New System.Drawing.Point(102, 277)
        Me.TextBoxIP1.Name = "TextBoxIP1"
        Me.TextBoxIP1.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxIP1.TabIndex = 20
        Me.TextBoxIP1.Text = "192.168.1.39"
        Me.TextBoxIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox1.Location = New System.Drawing.Point(18, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ButtonCONECTAR
        '
        Me.ButtonCONECTAR.BackColor = System.Drawing.Color.Black
        Me.ButtonCONECTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCONECTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCONECTAR.ForeColor = System.Drawing.Color.Lime
        Me.ButtonCONECTAR.Location = New System.Drawing.Point(382, 21)
        Me.ButtonCONECTAR.Name = "ButtonCONECTAR"
        Me.ButtonCONECTAR.Size = New System.Drawing.Size(140, 42)
        Me.ButtonCONECTAR.TabIndex = 18
        Me.ButtonCONECTAR.Text = "CONECTAR"
        Me.ButtonCONECTAR.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(556, 331)
        Me.Controls.Add(Me.ButtonINTERVALO)
        Me.Controls.Add(Me.TextBoxINTERVALO)
        Me.Controls.Add(Me.TextBoxIP1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonCONECTAR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Webcam Victima"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RELOJRECIBIR As System.Windows.Forms.Timer
    Friend WithEvents ButtonINTERVALO As System.Windows.Forms.Button
    Friend WithEvents TextBoxINTERVALO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIP1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonCONECTAR As System.Windows.Forms.Button

End Class
