Public Class Form2
    'Creamos un contador para los productos
    Dim subtotal As Double = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Definimos las finciones para calcular el total a pagar
        Dim t As Double = 0
        Dim cantidad As Double
        Dim tot As Double

        'Creamos una condicional para valiar cual es el producto seleccionado
        If RadioButton1.Checked = True Then
            t = +4000
        End If
        If RadioButton2.Checked = True Then
            t = +3000
        End If
        If RadioButton3.Checked = True Then
            t = +2500
        End If
        If RadioButton4.Checked = True Then
            t = +1800
        End If


        'Creamos la validación de los utiles
        If CheckBox1.Checked = True Then
            t = t + 1000
        End If
        If CheckBox2.Checked = True Then
            t = t + 800
        End If
        If CheckBox3.Checked = True Then
            t = t + 600
        End If


        'Creamos las operaciones
        cantidad = Convert.ToDouble(nmrcantidad.Value)
        t = Convert.ToDouble(nmrcantidad.Value) * t


        'Mostramos el valor del monto
        total.Text = t.ToString("c2")


        'Creamos el contador de los productos
        tot = t
        subtotal = subtotal + tot

        total.Text = subtotal.ToString("c2") & vbCr & "Pesos"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Fincionalidad del botón de borrar
        total.Clear()

        nmrcantidad.Value = 1

        'Hacemos que todos los valores checkeados ya no existan
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False



    End Sub
End Class