Imports System.DirectoryServices
Imports System.Security.Cryptography

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

        'CICLO FOR
        'Declaramos el incrementador del ciclo
        'Definimos entre parentesis las posiciocnes que tendra la variable
        Dim ciclo(5)
        Dim i As Integer
        Dim anidado As Integer

        'Sintaxis básica del ciclo for

        For i = 0 To 4
            ciclo(i) = i + i
            MsgBox("Posición ( " + i.ToString + " ) = " + ciclo(i).ToString)
        Next

        'Ciclo for anidado
        'Por cada ciclo externo se ejecutara in ciclo interno
        For i = 0 To 2
            MsgBox("Ciclo externo  i = " + i.ToString)
            For anidado = 0 To 3
                MsgBox("Ciclo interno anidado = " + anidado.ToString)
            Next
        Next



        'CICLOS DO - WHILE
        Dim doo As Integer = 0

        'Dterminamos que la variable tenfra 5 posiciones
        Dim eje(5) As Integer

        'Ciclo Do
        Do
            MsgBox("Ciclo Do: " + doo.ToString)
            'Creamos la incrementación en ña variable i

            'Definimos el incrementador
            doo += 1

            'Determinamos que el ciclo se ejecute hasta que i sea menor que 2
        Loop While doo < 2

        'Reiniciamos el valor de nuestra variable
        doo = 0

        'Ciclo Do While
        Do While doo < 3
            MsgBox("Ciclo do while: " + doo.ToString)

            'Definimos el incrementador
            doo = doo + 1
        Loop

        i = 0

        'Ciclo While
        While doo < 3
            MsgBox("Ciclo while: " + doo.ToString)

            'Definimos el incrementador
            doo += 1
        End While

        Do While doo < 5
            eje(doo) = doo
            doo += 1
        Loop

        doo = 0

        While doo < 5
            MsgBox("Arreglo ( " + doo.ToString + " ) = " + eje(doo).ToString)

            'Si quitamos el incremento, entraremos en un ciclo infinito
            doo += 1
        End While
    End Sub

    Private Sub nombre_TextChanged(sender As Object, e As EventArgs)

        'Modificando formulario por medio de código
        nombre.Text = "Nuevo texto"
        'Haciendo que el cuadro no sea modificable
        nombre.ReadOnly = False
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

    Private Sub cierro_Click(sender As Object, e As EventArgs)
        'Este comando permitira cerrar la ventana al ser oprimido
        Me.Close()
    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs)

        Dim igual As Boolean

        igual = numero1.Text = numero2.Text
        MsgBox(igual)

    End Sub

    Private Sub diferente_Click(sender As Object, e As EventArgs)

        Dim diferent As Boolean

        diferent = numero1.Text <> numero2.Text
        MsgBox(diferent)
    End Sub

    Private Sub mayorque_Click(sender As Object, e As EventArgs)

        Dim mayor As Boolean
        'El numero 1 es mayor que el 2
        mayor = numero1.Text > numero2.Text
        MsgBox(mayor)
    End Sub

    Private Sub menorque_Click(sender As Object, e As EventArgs)

        Dim menor As Boolean

        menor = numero1.Text < numero2.Text
        MsgBox(menor)
    End Sub

    Private Sub mayorigual_Click(sender As Object, e As EventArgs)

        Dim mayori As Boolean

        mayori = numero1.Text >= numero2.Text
        MsgBox(mayori)
    End Sub

    Private Sub menorigual_Click(sender As Object, e As EventArgs)

        Dim menori As Boolean

        menori = numero1.Text <= numero2.Text
        MsgBox(menori)
    End Sub

    Private Sub primoo_Click(sender As Object, e As EventArgs)
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

    Private Sub fecha_Click(sender As Object, e As EventArgs)

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

    Private Sub tabla_Click(sender As Object, e As EventArgs)

        Dim multiplica As Integer

        multiplica = primo.Text

        'Creamos un ciclo For en el que el contador iniciara desde 1 hasta 10
        For i = 1 To 10
            MsgBox(multiplica & " * " & i & " = " & multiplica * i & vbCrLf)
        Next
    End Sub

    Private Sub mayorif_Click(sender As Object, e As EventArgs)

        'Definimos las variables
        Dim num1, num2 As Integer

        'Asignamos a las variables la propiedasd de los cuadros de texto
        num1 = numero1.Text
        num2 = numero2.Text

        'Determinamos si el número 1 es menor que el número 2
        If (num1 < num2) Then
            MsgBox("El " & num1 & " es menor que: " & num2)

        ElseIf (num1 = num2) Then
            MsgBox("El " & num1 & " es igual que: " & num2)

        Else
            MsgBox("El " & num1 & " es mayor que: " & num2)

        End If
    End Sub

    Private Sub palabra_Click(sender As Object, e As EventArgs)

        'Comprobando su un campo tiene la palabra
        If (nombre.Text.Contains("juan")) Then
            MsgBox("En efecto, ´sí es Juan", MsgBoxStyle.Information, "Este hombnre es juan")
        Else
            MsgBox("Lo siento, no eres Juan", MsgBoxStyle.Critical, "No es Juan :'(")
        End If

    End Sub

    Private Sub multiple_Click(sender As Object, e As EventArgs)

        'Programando eventos de un RadioButton
        'Definimos la variables
        Dim num1, num2 As Integer
        'Definimos resultado como double para tener los resultados tando de división como de resta
        Dim resulta As Double

        'Capturamos los numeros en la variables
        num1 = nume1.Text
        num2 = nume2.Text

        'Determinamos que rediobutton esta seleccionado
        If (resta.Checked = True) Then
            resulta = num1 + num2

        ElseIf (dividir.Checked = True) Then
            resulta = num1 / num2
        End If

        MsgBox("El resultado de la operación es: " & resulta)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs)

        'Determinando que radiobutton este chequeado al principio 
        dividir.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Programando los eventos de un checkbox
        Dim azul, rojo, verde As Boolean

        If Me.azul.Checked = True Then
            azul = True
        Else
            azul = False
        End If

        If Me.rojo.Checked = True Then
            rojo = True
        Else
            rojo = False
        End If

        If Me.verde.Checked = True Then
            verde = True
        Else
            verde = False
        End If

        MsgBox("Opciones seleccionadas: ")

        If azul = True Then
            MsgBox("AZUL")
        End If


        If rojo = True Then
            MsgBox("ROJO")
        End If


        If verde = True Then
            MsgBox("VERDE")
        End If

    End Sub

    Private Sub fibonacci_Click(sender As Object, e As EventArgs) Handles fibonacci.Click

        'Serie de fibonacci
        Dim n1, n2, n3, i As Single

        'Asignamos los valores a las variables
        n1 = 1
        n2 = 1
        n3 = 0

        'Definimos el ciclo for hasta que cantidad queremos que vaya
        For i = 1 To 12

            n3 = n1 + n2

            'Agregamos a la lista los valores obtenidos de la ecuación
            ListBox1.Items.Add("Posición " & i & " en Fibonacci es: " & n1)

            n1 = n2
            n2 = n3
        Next

    End Sub

    Private Sub volumen_Click(sender As Object, e As EventArgs) Handles volumen.Click
        'Calculando el columen de un cilindro
        'Definimos la constante (Es un valor que una vez definido no puede cambiar) de pi
        Const pi As Single = 3.141592654
        'Definimos la variables que necesitamos
        Dim V, D, A As Single

        'Capturamos los valores que ingresara el usuario
        'Obtenemos el valor del elementos con val
        D = Val(diametro.Text) / 2
        A = Val(altura.Text)
        V = pi * (D ^ 2) * A

        'Mostramos el resultado por una caja de texto
        MsgBox("El volumen del cilindro es: " & V & "Metros cúbicos")

    End Sub
End Class