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
        boton = New Button()
        numero1 = New TextBox()
        numero2 = New TextBox()
        sumar = New Button()
        Label1 = New Label()
        cierro = New Button()
        igual = New Button()
        diferente = New Button()
        mayorque = New Button()
        menorque = New Button()
        mayorigual = New Button()
        menorigual = New Button()
        SuspendLayout()
        ' 
        ' texto1
        ' 
        texto1.AutoSize = True
        texto1.Location = New Point(3, 16)
        texto1.Margin = New Padding(4, 0, 4, 0)
        texto1.Name = "texto1"
        texto1.Size = New Size(147, 20)
        texto1.TabIndex = 0
        texto1.Text = "Nombre Completo: "' 
        ' nombre
        ' 
        nombre.Location = New Point(147, 13)
        nombre.Margin = New Padding(4)
        nombre.Name = "nombre"
        nombre.Size = New Size(328, 32)
        nombre.TabIndex = 1
        nombre.Text = "Nombre Completo"' 
        ' boton
        ' 
        boton.Location = New Point(476, 12)
        boton.Name = "boton"
        boton.Size = New Size(75, 33)
        boton.TabIndex = 2
        boton.Text = "Guardar"
        boton.UseVisualStyleBackColor = True
        ' 
        ' numero1
        ' 
        numero1.Location = New Point(3, 89)
        numero1.Name = "numero1"
        numero1.Size = New Size(100, 32)
        numero1.TabIndex = 3
        ' 
        ' numero2
        ' 
        numero2.Location = New Point(109, 89)
        numero2.Name = "numero2"
        numero2.Size = New Size(100, 32)
        numero2.TabIndex = 4
        ' 
        ' sumar
        ' 
        sumar.Location = New Point(215, 89)
        sumar.Name = "sumar"
        sumar.Size = New Size(75, 32)
        sumar.TabIndex = 5
        sumar.Text = "Sumar"
        sumar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 20)
        Label1.TabIndex = 6
        Label1.Text = "Digíte un número en cada casilla"' 
        ' cierro
        ' 
        cierro.Location = New Point(296, 89)
        cierro.Name = "cierro"
        cierro.Size = New Size(75, 32)
        cierro.TabIndex = 7
        cierro.Text = "Cerrar"
        cierro.UseVisualStyleBackColor = True
        ' 
        ' igual
        ' 
        igual.Location = New Point(3, 127)
        igual.Name = "igual"
        igual.Size = New Size(75, 28)
        igual.TabIndex = 8
        igual.Text = "Igual"
        igual.UseVisualStyleBackColor = True
        ' 
        ' diferente
        ' 
        diferente.Location = New Point(109, 127)
        diferente.Name = "diferente"
        diferente.Size = New Size(81, 28)
        diferente.TabIndex = 9
        diferente.Text = "Diferente"
        diferente.UseVisualStyleBackColor = True
        ' 
        ' mayorque
        ' 
        mayorque.Location = New Point(3, 161)
        mayorque.Name = "mayorque"
        mayorque.Size = New Size(93, 29)
        mayorque.TabIndex = 10
        mayorque.Text = "Mayor que"
        mayorque.UseVisualStyleBackColor = True
        ' 
        ' menorque
        ' 
        menorque.Location = New Point(109, 161)
        menorque.Name = "menorque"
        menorque.Size = New Size(90, 29)
        menorque.TabIndex = 11
        menorque.Text = "Menor que"
        menorque.UseVisualStyleBackColor = True
        ' 
        ' mayorigual
        ' 
        mayorigual.Location = New Point(3, 196)
        mayorigual.Name = "mayorigual"
        mayorigual.Size = New Size(100, 29)
        mayorigual.TabIndex = 12
        mayorigual.Text = "Mayor igual"
        mayorigual.UseVisualStyleBackColor = True
        ' 
        ' menorigual
        ' 
        menorigual.Location = New Point(109, 196)
        menorigual.Name = "menorigual"
        menorigual.Size = New Size(100, 29)
        menorigual.TabIndex = 13
        menorigual.Text = "Menor igual"
        menorigual.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(563, 522)
        Controls.Add(menorigual)
        Controls.Add(mayorigual)
        Controls.Add(menorque)
        Controls.Add(mayorque)
        Controls.Add(diferente)
        Controls.Add(igual)
        Controls.Add(cierro)
        Controls.Add(Label1)
        Controls.Add(sumar)
        Controls.Add(numero2)
        Controls.Add(numero1)
        Controls.Add(boton)
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
    Friend WithEvents boton As Button
    Friend WithEvents numero1 As TextBox
    Friend WithEvents numero2 As TextBox
    Friend WithEvents sumar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cierro As Button
    Friend WithEvents igual As Button
    Friend WithEvents diferente As Button
    Friend WithEvents mayorque As Button
    Friend WithEvents menorque As Button
    Friend WithEvents mayorigual As Button
    Friend WithEvents menorigual As Button
End Class
