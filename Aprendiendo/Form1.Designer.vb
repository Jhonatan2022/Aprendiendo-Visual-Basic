<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        texto1 = New Label()
        nombre = New TextBox()
        SuspendLayout()
        ' 
        ' texto1
        ' 
        texto1.AutoSize = True
        texto1.Location = New Point(16, 12)
        texto1.Margin = New Padding(4, 0, 4, 0)
        texto1.Name = "texto1"
        texto1.Size = New Size(139, 20)
        texto1.TabIndex = 0
        texto1.Text = "Digite su nombre: "' 
        ' nombre
        ' 
        nombre.Location = New Point(157, 8)
        nombre.Margin = New Padding(4)
        nombre.Name = "nombre"
        nombre.Size = New Size(328, 32)
        nombre.TabIndex = 1
        nombre.Text = "Nombre Completo"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(563, 522)
        Controls.Add(nombre)
        Controls.Add(texto1)
        Font = New Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents texto1 As Label
    Friend WithEvents nombre As TextBox
End Class
