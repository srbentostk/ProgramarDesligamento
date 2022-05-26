<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Programar_Comportamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programar_Comportamento))
        Me.btnDesligar = New System.Windows.Forms.Button()
        Me.btnHibernar = New System.Windows.Forms.Button()
        Me.timerHibernar = New System.Windows.Forms.Timer(Me.components)
        Me.numHoras = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblContagem = New System.Windows.Forms.Label()
        Me.lblFaltam = New System.Windows.Forms.Label()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.timerDesligar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDesligar
        '
        Me.btnDesligar.Location = New System.Drawing.Point(74, 10)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesligar.TabIndex = 0
        Me.btnDesligar.Text = "Desligar"
        Me.btnDesligar.UseVisualStyleBackColor = True
        '
        'btnHibernar
        '
        Me.btnHibernar.Location = New System.Drawing.Point(155, 10)
        Me.btnHibernar.Name = "btnHibernar"
        Me.btnHibernar.Size = New System.Drawing.Size(75, 23)
        Me.btnHibernar.TabIndex = 1
        Me.btnHibernar.Text = "Hibernar"
        Me.btnHibernar.UseVisualStyleBackColor = True
        '
        'timerHibernar
        '
        Me.timerHibernar.Interval = 1000
        '
        'numHoras
        '
        Me.numHoras.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.numHoras.Location = New System.Drawing.Point(4, 10)
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(64, 50)
        Me.numHoras.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(236, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblContagem
        '
        Me.lblContagem.AutoSize = True
        Me.lblContagem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContagem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblContagem.Location = New System.Drawing.Point(100, 36)
        Me.lblContagem.Name = "lblContagem"
        Me.lblContagem.Size = New System.Drawing.Size(19, 21)
        Me.lblContagem.TabIndex = 6
        Me.lblContagem.Text = "0"
        '
        'lblFaltam
        '
        Me.lblFaltam.AutoSize = True
        Me.lblFaltam.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFaltam.ForeColor = System.Drawing.Color.Red
        Me.lblFaltam.Location = New System.Drawing.Point(183, 36)
        Me.lblFaltam.Name = "lblFaltam"
        Me.lblFaltam.Size = New System.Drawing.Size(19, 21)
        Me.lblFaltam.TabIndex = 7
        Me.lblFaltam.Text = "0"
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTempo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTempo.ForeColor = System.Drawing.Color.Black
        Me.lblTempo.Location = New System.Drawing.Point(262, 36)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(19, 21)
        Me.lblTempo.TabIndex = 8
        Me.lblTempo.Text = "0"
        '
        'timerDesligar
        '
        Me.timerDesligar.Interval = 1000
        '
        'Programar_Comportamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 74)
        Me.Controls.Add(Me.lblTempo)
        Me.Controls.Add(Me.lblFaltam)
        Me.Controls.Add(Me.lblContagem)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.numHoras)
        Me.Controls.Add(Me.btnHibernar)
        Me.Controls.Add(Me.btnDesligar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Programar_Comportamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programar Comportamento"
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDesligar As Button
    Friend WithEvents btnHibernar As Button
    Friend WithEvents timerHibernar As Timer
    Friend WithEvents numHoras As NumericUpDown
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblContagem As Label
    Friend WithEvents lblFaltam As Label
    Friend WithEvents lblTempo As Label
    Friend WithEvents timerDesligar As Timer
End Class
