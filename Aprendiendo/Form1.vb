﻿Imports System.Security.Cryptography

Public Class Form1
    'Para Comentar Muchas lineas de código Ctrl + K +Ctrl + C
    'Para Desomentar Muchas lineas de código Ctrl + K +Ctrl + U
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'Esto genera un cuadro de error
        'MsgBox("Hola esto es un error", MsgBoxStyle.Critical, "ERROR")

        'Esto genera un cuadro de alerta
        'Msgbox("Hola esto es una alerta", MsgboxStyle.Exclamation, "ALERTA")

        'Esto genera un cuadro de multiple opción (Cancelar, volver, ignorar)
        'Msgbox("Hola elija una opción", MsgboxStyle.AbortRetryIgnore, "MULTIPLE OPCIÓN")

        'Esto genera un primer plano
        'Msgbox("Hola esto es un primer plano", MsgboxStyle.'MsgboxSetForeground, "PRIMER PLANO")

        'Esto genera un cuadro de información
        'Msgbox("Hola esto es un cuadro de información", MsgboxStyle.Information, "INFORMACIÓN")

        'Esto genera un cuadro de ayuda
        'Msgbox("Hola esto es un cuadro de ayuda", MsgboxStyle.'MsgboxHelp, "AYUDA")

        'Esto es un cuadro de confirmación
        'Msgbox("Hola esto es un cuadro de confirmación", MsgboxStyle.YesNo, "CONFIRMACIÓN")

        '
        'Msgbox("Hol", 'MsgboxStyle.ApplicationModal, "")

        '
        'Msgbox("", 'MsgboxStyle.'MsgboxRtlReading, "")

        '
        'Msgbox("Ho", 'MsgboxStyle.'MsgboxRight, "")


        'declarando primeras variables en vb
        'Dim variable As Integer = 3 + 12
        'MsgBox(variable)
        ''asignando nuevo valor a la variable
        'variable = 11
        'MsgBox(variable)

        ''Variables con decimales
        'Dim [decimal] As Double = 1.5
        'MsgBox([decimal])
        '[decimal] = 2.5
        'MsgBox([decimal])

        ''Variables con texto "String"
        'Dim texto As String = "Hola esto es texto"
        'MsgBox(texto)
        'Dim texto2 As String = "..."
        'MsgBox(texto + texto2)

        ''Variables con fecha
        'Dim fecha As Date = "13-02-2023"
        'MsgBox(fecha)
        ''Otra forma de hacerlo
        'Dim fecha2 As Date = "02-JAN-2023"
        'MsgBox(fecha2)

        ''Arrays en VB primero determinamos las cantidades
        'Dim arreglo(3) As String
        'arreglo(0) = "h"
        'arreglo(1) = "o"
        'arreglo(2) = "la"
        ''Imprimimos el resultado final
        'MsgBox(arreglo(0) + " " + arreglo(1) + "  " + arreglo(2))

        ''Arrays con posiciones ToString convierte una variable en un objeto del tipo String
        'Dim posicion() As Integer 'Integer es para enteros
        'posicion = New Integer() {1, 2, 3}
        'MsgBox(posicion(0).ToString + "--" + posicion(1).ToString + "--" + posicion(2).ToString + "--")

        ''Conservar los datos de las posiciones indcadas utilizar preserve
        'ReDim Preserve posicion(2)
        'MsgBox(posicion(0).ToString + "--" + posicion(1).ToString + "--" + posicion(2).ToString)

        ''Creando matriz, se pueden usar maximo 32 dimenciones
        'Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        'MsgBox(matriz(0, 1).ToString)

        ''OPPERADORES ARITMETICOS
        'Dim numero, numero2, operacion As Integer
        'numero = 2
        'numero2 = 5
        'operacion = numero + numero2
        ''Tambien puede -, Mod (Modulo), /, *, += Para incrementar, -= Para decrementar
        'MsgBox(operacion.ToString)

        'Cambiando valores de formulario por código


        'OPERADORES COMPARATIVOS
        'Tenemos mayor que >, menor que <,
        'mayor igual >=, menor igual <=, diferente <>

        'OPERADORES LÓGICOS
        'Tenemos And, Or y Not
        Dim logico As Boolean

        'And solo se cumple cuando los casos son verdaderos
        logico = (1 = 1) And (2 = 2)
        MsgBox(logico)

        'Or solo nesesita una afirmación verdadera para convertirse en verdadero
        logico = (1 = 1) Or (2 = 2)
        MsgBox(logico)

        'Not se encarga de negar la afirmación
        logico = Not (1 = 1)
        MsgBox(logico)

        logico = ((1 = 1) And (2 = 2)) Or (3 <> 2)
        MsgBox(logico)

    End Sub

    Private Sub nombre_TextChanged(sender As Object, e As EventArgs)

        'Modificando formulario por medio de código
        nombre.Text = "Nuevo texto"
        nombre.TextAlign = HorizontalAlignment.Right
        'Haciendo que el cuadro no sea modificable
        nombre.ReadOnly = True
    End Sub

    Private Sub boton_Click(sender As Object, e As EventArgs)

        'Programando eventos del botón
        MsgBox("La información ha sido guardada", MsgBoxStyle.Information, "Botón de guardar")

    End Sub

    Private Sub sumar_Click(sender As Object, e As EventArgs)

        'El evento de este botón gestionara la suma entre dos números ingresados por el usuario
        Dim num1, num2, suma As Integer

        'Asignamos el valor digitado en los cuadros de texto a las variables
        num1 = numero1.Text
        num2 = numero2.Text

        suma = num1 + num2

        MsgBox("La suma de los números es: " & suma)

    End Sub

    Private Sub cierro_Click(sender As Object, e As EventArgs) Handles cierro.Click
        'Este comando permitira cerrar la ventana al ser oprimido
        Me.Close()
    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click

        Dim igual As Boolean

        igual = numero1.Text = numero2.Text
        MsgBox(igual)

    End Sub

    Private Sub diferente_Click(sender As Object, e As EventArgs) Handles diferente.Click

        Dim diferent As Boolean

        diferent = numero1.Text <> numero2.Text
        MsgBox(diferent)
    End Sub

    Private Sub mayorque_Click(sender As Object, e As EventArgs) Handles mayorque.Click

        Dim mayor As Boolean
        'El numero 1 es mayor que el 2
        mayor = numero1.Text > numero2.Text
        MsgBox(mayor)
    End Sub

    Private Sub menorque_Click(sender As Object, e As EventArgs) Handles menorque.Click

        Dim menor As Boolean

        menor = numero1.Text < numero2.Text
        MsgBox(menor)
    End Sub

    Private Sub mayorigual_Click(sender As Object, e As EventArgs) Handles mayorigual.Click

        Dim mayori As Boolean

        mayori = numero1.Text >= numero2.Text
        MsgBox(mayori)
    End Sub

    Private Sub menorigual_Click(sender As Object, e As EventArgs) Handles menorigual.Click

        Dim menori As Boolean

        menori = numero1.Text <= numero2.Text
        MsgBox(menori)
    End Sub

    Private Sub primoo_Click(sender As Object, e As EventArgs) Handles primoo.Click
        'SENTENCIAS IF
        Dim nume As Integer
        Dim primono As Boolean = True

        nume = primo.Text

        'Determinamos que ninguno de los numeros sea divisible entre 2 o 3
        For i As Integer = 2 To nume - 1
            If nume Mod i = 0 Then
                primono = False
            End If
        Next

        'Dterminamos la siguiente sentencia basandonos en la ecuación anterior para imprimir su resultado
        If primono = False Then
            MsgBox("No es un número primo")
        Else
            MsgBox("Es un número primo")
        End If
    End Sub

    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click

        Dim Ndia, Nmes, DDA As Integer
        Ndia = dia.Text
        Nmes = mes.Text

        If Ndia >= 1 And Ndia <= 31 And Nmes >= 1 And Nmes <= 12 Then
            Select Case Nmes
                Case 1
                    DDA = Ndia '[DDA es día del año]
                Case 2
                    DDA = Ndia + 31
                Case 3
                    DDA = Ndia + 59
                Case 4
                    DDA = Ndia + 90
                Case 5
                    DDA = Ndia + 120
                Case 6
                    DDA = Ndia + 151
                Case 7
                    DDA = Ndia + 181
                Case 8
                    DDA = Ndia + 212
                Case 9
                    DDA = Ndia + 243
                Case 10
                    DDA = Ndia + 273
                Case 11
                    DDA = Ndia + 304
                Case 12
                    DDA = Ndia + 334
            End Select
            MsgBox("El " & Ndia & " del " & Nmes & " es el día " & DDA & " del año")
        Else
            MsgBox("Los datos que insertaste no son validos")
        End If
    End Sub

    Private Sub tabla_Click(sender As Object, e As EventArgs) Handles tabla.Click

        Dim multiplica As Integer

        multiplica = primo.Text

        'Creamos un ciclo For en el que el contador iniciara desde 1 hasta 10
        For i = 1 To 10
            MsgBox(multiplica & " * " & i & " = " & multiplica * i & vbCrLf)
        Next
    End Sub
End Class