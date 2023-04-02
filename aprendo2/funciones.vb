Imports System.Windows.Forms.VisualStyles

Module funciones

    'Creamos el modulo en casos de que queramos reciclar funciones en muchos mas
    Public Sub sololetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        'Creamos la función que recibira solo letras
        If Char.IsDigit(e.KeyChar) Then

            'Permitimos que se uestre
            e.Handled = True

        ElseIf Char.IsControl(e.KeyChar) Then

            'No mostramos el valor si no es una letra
            e.Handled = False


        Else

            e.Handled = False
        End If

    End Sub


    Public Sub comparotexto(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        'Definimos las variables
        Dim cadena As String
        Dim verifica As Boolean

        cadena = "Hola a todos"
        verifica = cadena.Contains("todos")

        'Creamos una condicional que verifique si es igual o no
        If verifica = True Then

            MsgBox("La cadena es igual")

        Else
            MsgBox("Las cadena es diferente")

        End If

    End Sub


End Module
