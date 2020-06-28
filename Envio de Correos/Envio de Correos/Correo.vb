Imports System.Net.Mail

Module Correo
    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal destinatario As String, ByVal asunto As String, ByVal mensaje As String)
        correos.Attachments.Clear()
        correos.To.Clear()
        correos.Subject = asunto
        correos.Body = mensaje
        correos.IsBodyHtml = True
        correos.To.Add(destinatario)
        'Correo
        correos.From = New MailAddress("")
        'Correo / contraseña
        envios.Credentials = New Net.NetworkCredential("", "")
        'GOOGLE
        'https://myaccount.google.com/lesssecureapps Habilitar correo
        envios.Host = "smtp.gmail.com"
        envios.Port = "587"

        envios.Send(correos)
    End Sub
End Module
