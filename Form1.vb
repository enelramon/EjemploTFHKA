Imports TfhkaNet.IF.DO

Public Class Form1

    Private Impresora As New Tfhka
    Dim Stopwatch As New Stopwatch

    Private Sub FacturaFirmaButton_Click(sender As Object, e As EventArgs) Handles FacturaFirmaButton.Click
        If AbrirPuerto() = False Then
            Return
        End If

        Stopwatch.Restart()

        EnviarComando("F00000000B0200002000")

        EnviarComando("iR0404000316") 'RNC

        EnviarComando("iS0AYUNTAMIENTO MUNICIPAL COTUI") 'NOMBRE
        EnviarComando("i00CODIGO: 641") 'CODIGO
        EnviarComando("i01DIR: SANCHEZ") 'DIRECCION

        EnviarComando("/0") 'Consumidor final

        'envio estas descriciones aqui, porque si pasa algo luego no las puedo imprimir.
        EnviarComando("y0000707825")
        '----------------------------------------------

        EnviarComando("""000008000000003000|12458|PIES123|PINO 2X4X16 BT0123450123456789012345678901234567890123456789") 'PRECIO=800.00  X CANTIDAD= 30.00
        EnviarComando("@MUY LARGO")                'Descripcion adicional para el articulo
        EnviarComando("""000017600000015000|98765432109|KG|CLORO PICINA") 'PRECIO=1760.00  X CANTIDAD= 150.00
        EnviarComando("@MUY BUENO")

        EnviarComando("4") 'totalizar sin imprimir

        EnviarComando("201000030000000") 'Pagar 300,000.00
        'ERROR IMPORTANTE: si envio 101 las descripciones adicionales no salen. me dijeron que le de 201

        Dim EstadoS1 = Impresora.GetS1PrinterData()

        Dim Numero = EstadoS1.LastFiscalTransactionNumber().ToString()
        Dim Serial = EstadoS1.RegisteredMachineNumber

        EnviarComando("@ ")
        EnviarComando("@VALORES PARA ARMAR NIF")

        'USARE ESTOS VALORES PARA SABER EL NIF GENERADO.
        EnviarComando("@Serial:" & Serial)
        EnviarComando("@Secuencia:" & Numero)

        EnviarComando("199") 'cerrar el documento

        Stopwatch.Stop()

        LoggearMensaje($"tardo: { Stopwatch.ElapsedMilliseconds}ms")


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
        EnviarComando("198")

        EnviarComando("@*Coment. despues del TOTAL")
        EnviarComando("@COMENT. DESPUES DEL TOTAL")
        EnviarComando("@ESTOS COMENTARIOS pie de pagina")

        EnviarComando("199")
    End Sub

    Function AbrirPuerto() As Boolean
        Dim paso As Boolean = False
        If (Impresora.StatusPort) Then
            Impresora.CloseFpCtrl()
            MsgBox("El puerto ya estaba abierto")
        End If

        If Impresora.OpenFpCtrl("COM" & PuertoTextBox.Text) Then

            Dim s2 = Impresora.GetS2PrinterData()
            If (s2.TypeDocument <> 0) Then
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
            Dim StatusError = Impresora.GetPrinterStatus()
            MsgBox("El comando: " & Comando & vbCrLf &
                   $"Estado: {StatusError.PrinterStatusCode} - {StatusError.PrinterStatusDescription}{vbCrLf}" &
                   $"Dio el error: {StatusError.PrinterErrorCode} - {StatusError.PrinterErrorDescription}")

        End If

        Return Retorno

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AbrirPuerto() = False Then
            Return
        End If

        'CONFIGURAR CODE 39
        EnviarComando("PJ4303")
        EnviarComando("PJ3000") 'imprimir numero debajo del las barras

        'CONFIGURAR 1 copias
        EnviarComando("PJ5600")

        'CONFIGURAR MODO RETAIL
        EnviarComando("PJ3201")
    End Sub
    Sub LoggearMensaje(mensaje As String)
        TxtLog.Text &= mensaje & vbCrLf
    End Sub

    Private Sub DescargarZButton_Click(sender As Object, e As EventArgs) Handles DescargarZButton.Click
        Impresora.UploadReportCmd("U0Z")
    End Sub
End Class
