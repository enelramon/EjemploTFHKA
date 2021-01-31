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
        Me.PuertoTextBox.Text = "4"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 296)
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
End Class
