Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esto genera un cuadro de error
        MsgBox("Hola esto es un error", MsgBoxStyle.Critical, "ERROR")

        'Esto genera un cuadro de alerta
        MsgBox("Hola esto es una alerta", MsgBoxStyle.Exclamation, "ALERTA")

        'Esto genera un cuadro de multiple opción (Cancelar, volver, ignorar)
        MsgBox("Hola elija una opción", MsgBoxStyle.AbortRetryIgnore, "MULTIPLE OPCIÓN")

        'Esto genera un primer plano
        MsgBox("Hola esto es un primer plano", MsgBoxStyle.MsgBoxSetForeground, "PRIMER PLANO")

        'Esto genera un cuadro de información
        MsgBox("Hola esto es un cuadro de información", MsgBoxStyle.Information, "INFORMACIÓN")

        'Esto genera un cuadro de ayuda
        MsgBox("Hola esto es un cuadro de ayuda", MsgBoxStyle.MsgBoxHelp, "AYUDA")

        'Esto es un cuadro de confirmación
        MsgBox("Hola esto es un cuadro de confirmación", MsgBoxStyle.YesNo, "CONFIRMACIÓN")

        '
        MsgBox("Hol", MsgBoxStyle.ApplicationModal, "")

        '
        MsgBox("", MsgBoxStyle.MsgBoxRtlReading, "")

        '
        MsgBox("Ho", MsgBoxStyle.MsgBoxRight, "")
    End Sub
End Class
