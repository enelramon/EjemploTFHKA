<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FacturaFirmaButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PuertoTextBox = New System.Windows.Forms.TextBox()
        Me.NCButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.DescargarZButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FacturaFirmaButton
        '
        Me.FacturaFirmaButton.Location = New System.Drawing.Point(49, 63)
        Me.FacturaFirmaButton.Name = "FacturaFirmaButton"
        Me.FacturaFirmaButton.Size = New System.Drawing.Size(139, 36)
        Me.FacturaFirmaButton.TabIndex = 25
        Me.FacturaFirmaButton.Text = "Factura Consumidor Final"
        Me.FacturaFirmaButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Puerto"
        '
        'PuertoTextBox
        '
        Me.PuertoTextBox.Location = New System.Drawing.Point(49, 12)
        Me.PuertoTextBox.Name = "PuertoTextBox"
        Me.PuertoTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PuertoTextBox.TabIndex = 26
        Me.PuertoTextBox.Text = "5"
        '
        'NCButton
        '
        Me.NCButton.Location = New System.Drawing.Point(49, 121)
        Me.NCButton.Name = "NCButton"
        Me.NCButton.Size = New System.Drawing.Size(139, 36)
        Me.NCButton.TabIndex = 28
        Me.NCButton.Text = "Nota de Credito"
        Me.NCButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Flags"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtLog
        '
        Me.TxtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLog.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtLog.Location = New System.Drawing.Point(242, 10)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(122, 195)
        Me.TxtLog.TabIndex = 30
        Me.TxtLog.WordWrap = False
        '
        'DescargarZButton
        '
        Me.DescargarZButton.Location = New System.Drawing.Point(12, 182)
        Me.DescargarZButton.Name = "DescargarZButton"
        Me.DescargarZButton.Size = New System.Drawing.Size(76, 23)
        Me.DescargarZButton.TabIndex = 31
        Me.DescargarZButton.Text = "Descargar Z"
        Me.DescargarZButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 217)
        Me.Controls.Add(Me.DescargarZButton)
        Me.Controls.Add(Me.TxtLog)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NCButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PuertoTextBox)
        Me.Controls.Add(Me.FacturaFirmaButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents FacturaFirmaButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PuertoTextBox As TextBox
    Private WithEvents NCButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents DescargarZButton As Button
End Class
