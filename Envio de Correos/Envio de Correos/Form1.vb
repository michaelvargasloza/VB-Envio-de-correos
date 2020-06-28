Public Class frmInicio
    Dim destinatario As String
    Dim asunto As String
    Dim mensaje As String

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        destinatario = txtDestinatario.Text.ToString
        asunto = txtAsunto.Text.ToString
        mensaje = txtMensaje.Text.ToString

        If (destinatario.Length < 1 Or asunto.Length < 1 Or mensaje.Length < 1) Then
            MsgBox("Error: Debe llenar todos los campos.")
        Else
            Try
                enviarCorreo(destinatario, asunto, mensaje)
                MsgBox("¡Mensaje enviado correctamente!")
            Catch ex As Exception
                MsgBox("Error: " + ex.ToString)
            End Try
        End If


        
    End Sub
End Class
