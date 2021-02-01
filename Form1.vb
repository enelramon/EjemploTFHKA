Imports TfhkaNet.IF.RD

Public Class Form1

    Private Impresora As New Tfhka

    Private Sub FacturaFirmaButton_Click(sender As Object, e As EventArgs) Handles FacturaFirmaButton.Click
        If AbrirPuerto() = False Then
            Return
        End If

        EnviarComando("F00000000B1500002000")

        EnviarComando("iR0404000316") 'RNC

        EnviarComando("iS0AYUNTAMIENTO MUNICIPAL COTUI") 'NOMBRE
        EnviarComando("i00CODIGO: 641") 'CODIGO
        EnviarComando("i01DIR: SANCHEZ") 'DIRECCION

        EnviarComando("/0") 'Consumidor final

        'envio estas descriciones aqui, porque si pasa algo luego no las puedo imprimir.
        EnviarComando("y0000707825")
        '----------------------------------------------

        EnviarComando("""000008000000003000|codigo|Ref: 12458") 'PRECIO=800.00  X CANTIDAD= 30.00
        EnviarComando("@PINO 2X4X16 BT")                'Descripcion adicional para el articulo
        EnviarComando("""000017600000015000Ref: 13729") 'PRECIO=1760.00  X CANTIDAD= 150.00
        EnviarComando("@PLYWOOD HIDROFUGO 3/4")

        EnviarComando("4") 'totalizar sin imprimir

        EnviarComando("101000030000000") 'Pagar 300,000.00
        'ERROR IMPORTANTE: si envio 101 las descripciones adicionales no salen.

        Dim S1 As S1PrinterData = Impresora.getS1PrinterData()

        Dim Numero = S1.getQuantityNonFiscalDocuments().ToString()
        Dim Serial = S1.getRegisteredMachineNumber()

        EnviarComando("@ ")
        EnviarComando("@VALORES PARA ARMAR NIF")

        'USARE ESTOS VALORES PARA SABER EL NIF GENERADO.
        EnviarComando("@Serial:" & Serial)
        EnviarComando("@Secuencia:" & Numero)

        EnviarComando("199") 'cerrar el documento

    End Sub

    Private Sub NCButton_Click(sender As Object, e As EventArgs) Handles NCButton.Click

        If AbrirPuerto() = False Then
            Return
        End If

        EnviarComando("iS0ENEL RAMON ALMONTE PICHARDO PICHARDO PICHARDO")
        EnviarComando("iR005601453607")
        EnviarComando("F00000000B0400022597")
        EnviarComando("iF000000000B0200022597")

        EnviarComando("/2")

        EnviarComando("""000008000000003000|codigo|Ref: 12458") 'PRECIO=800.00  X CANTIDAD= 30.00
        EnviarComando("@PINO 2X4X16 BT")                'Descripcion adicional para el articulo
        EnviarComando("""000017600000015000Ref: 13729") 'PRECIO=1760.00  X CANTIDAD= 150.00
        EnviarComando("@PLYWOOD HIDROFUGO 3/4")

        EnviarComando("4") 'totalizar sin imprimir

        EnviarComando("@Coment. despues del TOTAL")
        EnviarComando("@COMENT. DESPUES DEL TOTAL")
        EnviarComando("@ESTOS COMENTARIOS pie de pagina")

        EnviarComando("199")
    End Sub

    Function AbrirPuerto() As Boolean
        Dim paso As Boolean = False
        If (Impresora.StatusPort) Then
            Impresora.CloseFpctrl()
            MsgBox("El puerto ya estaba abierto")
        End If

        If Impresora.OpenFpctrl("COM" & PuertoTextBox.Text) Then

            Impresora.getS2PrinterData()
            If (Impresora.S2Estado1.getTypeDocument <> 0) Then
                EnviarComando("7", "cancelar") 'cancelar
            End If

            paso = True
        Else
            MsgBox("NO fue posible abriel")
        End If

        Return paso
    End Function


    Private Function EnviarComando(Comando As String, Optional obsevacion As String = "") As Boolean
        Dim Retorno As Boolean

        Retorno = Impresora.SendCmd(Comando)

        If Retorno = False Then
            Impresora.ReadFpStatus()
            MsgBox("El comando: " & Comando & vbCrLf &
                   "Dio el error: " & Impresora.Status_Error)
        End If

        Return Retorno

    End Function
End Class
