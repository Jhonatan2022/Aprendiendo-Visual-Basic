Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
End Class
