Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            Dim conexion As New MySqlConnectionStringBuilder()

            'Ingresamos los datos de la conexion
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = "root"
            conexion.Database = "visualbasic"

            'Realizamos la conexión a la base de datos
            Dim con As New MySqlConnection(conexion.ToString())
            con.Open()

            'Mandamos un mensaje en caso de que la conexión haya sido exitosa
            MsgBox("La conexion ha sido exitosa", MsgBoxStyle.Information, "EXITOSA")

        Catch ex As Exception

            'Mandamos un mensaje en caso de que la conexión haya fallado
            MsgBox("La conexión ha fallado", MsgBoxStyle.Critical, "ERROR")


        End Try








        'La función tiene que tener el mismo valor de envio
        'Dim var As String

        'var = "variable sin cambiar"

        'Elegimos que variable vamos a enviar
        'referencia(var)
        'MsgBox(var)

        'COMBOBOX MANUAL
        'Definimos la bariable de la base de datos
        Dim dt As DataTable = New DataTable("datos")

        'Asignamos las columnas
        dt.Columns.Add("codigo")
        dt.Columns.Add("descripcion")

        'Llenamos las filas del datatable
        Dim dr As DataRow

        dr = dt.NewRow()

        dr("codigo") = 0
        dr("descripcion") = "Masculino"

        'Hademos que reconozca a dr como una fila propia
        dt.Rows.Add(dr)

        dr = dt.NewRow()

        dr("codigo") = 1
        dr("descripcion") = "Femenino"

        'Hademos que reconozca a dr como una fila propia
        dt.Rows.Add(dr)

        'Asociamos el datatable al combobox
        Genero.DataSource = dt
        Genero.ValueMember = "codigo"
        Genero.DisplayMember = "descripcion"

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        'Mostramos el codigo de ese componente
        MsgBox(Genero.SelectedValue.ToString)

    End Sub


    Private Sub Formulario2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario2ToolStripMenuItem.Click

        'Forma de enlazar un segundo formulario en le menu
        Form2.ShowDialog()

    End Sub

    Private Sub DimeHolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DimeHolaToolStripMenuItem.Click

        'Eventos del menuStrip
        MsgBox("Hola individuo")
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click

        'Terminar y cerrar el formulario
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'Llamando a la función que creamos
        hola()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        'Debemos tener otra variable para que nos reciva el valor del procedimiento
        Dim holis As String

        holis = retornarhola()
        MsgBox(holis)

    End Sub

    'Creación de variables y parametros
    Sub hola()

        'MsgBox("Hola, soy un función")
    End Sub

    Function retornarhola()

        'Creamos una variable
        'Dim hol As String

        'hol = "Hola soy un procedimiento"
        'Return hol

    End Function

    'FUNCIONES CON PARAMETROS
    Private Sub parametro(ByVal variable As String)

        'MsgBox(variable)

        'Modificamos la variable crada
        'variable = "información cambiada"

        'MsgBox(variable)
    End Sub

    'Función de referencia
    Private Sub referencia(ByRef variable As String)

        'MsgBox(variable)

        'Modificamos la variable crada
        'variable = "información cambiada"

        'MsgBox(variable)

    End Sub


    'PROGRAMANDO EVENTOS DE CLICK PARA OTROS COMPONENENTES
    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click

        MsgBox("Has dado click en el checkbox")
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click

        MsgBox("Has da click en el radio buttom")
    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click

        MsgBox("Has dado click en el textbox")
    End Sub

    'EVENTO KEYPRESS DEL TEXTBOX
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        'Los resultados se guardaran en la variable e
        MsgBox(e.KeyChar.ToString)

        'Creamo un if para saber si determinada letra si es la que presiono el usuario
        If e.KeyChar.ToString = "w" Or e.KeyChar.ToString = "o" Then

            'Imprimimos el mensaje
            MsgBox("Has presionado la tecla: " + e.KeyChar.ToString)
        ElseIf e.KeyChar.ToString = "p" Then

            'Mostramos el mensaje de que la tecla enter no sirve 
            MessageBox.Show("la tecla P")

        End If
    End Sub

    'FUNCIÓN PARA RECIBIR SOLO NUMEROS
    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        'Validamos si el valor que ingreso es una letra
        If Char.IsDigit(e.KeyChar) Then

            'Si el usuario digito una letra no hacer nada
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            'Validamos si el valor ingresado en una tecla especial
            e.Handled = False

        Else
            e.Handled = True

        End If

        'Validamos que este funcionando correctamente
        MsgBox("Has ingresado: " + e.KeyChar.ToString)

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress

        'Llamamos a la funcion solo numeros
        solonumeros(e)
    End Sub


    'FUNCIÓN PARA RECIBIR SOLO LETRAS
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress

        'Llamamos a la función que creamos hace un momento en modulo 
        sololetras(e)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        'Compararemos textos
        Dim comparo As Integer

        comparo = StrComp("hola", "hola a todos")

        If comparo = 1 Then

            'Mostramos el mensaje
            MsgBox("El segundo texto tiene más información")

        ElseIf comparo = -1 Then

            MsgBox("El primer texto tiene menos información")

        Else

            MsgBox("Los textos son iguales")


        End If
    End Sub


End Class
