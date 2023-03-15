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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
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
        primo = New TextBox()
        Label2 = New Label()
        primoo = New Button()
        dia = New TextBox()
        mes = New TextBox()
        fecha = New Button()
        tabla = New Button()
        mayorif = New Button()
        palabra = New Button()
        GroupBox1 = New GroupBox()
        multiple = New Button()
        nume2 = New TextBox()
        nume1 = New TextBox()
        dividir = New RadioButton()
        resta = New RadioButton()
        Label3 = New Label()
        azul = New CheckBox()
        rojo = New CheckBox()
        Button1 = New Button()
        verde = New CheckBox()
        fibonacci = New Button()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' texto1
        ' 
        texto1.AutoSize = True
        texto1.BackColor = Color.Transparent
        texto1.ForeColor = SystemColors.ControlLightLight
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
        nombre.Size = New Size(250, 32)
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
        numero1.BackColor = SystemColors.ButtonHighlight
        numero1.Location = New Point(3, 89)
        numero1.Name = "numero1"
        numero1.Size = New Size(100, 32)
        numero1.TabIndex = 3
        ' 
        ' numero2
        ' 
        numero2.BackColor = SystemColors.ButtonHighlight
        numero2.Location = New Point(109, 89)
        numero2.Name = "numero2"
        numero2.Size = New Size(100, 32)
        numero2.TabIndex = 4
        ' 
        ' sumar
        ' 
        sumar.BackColor = SystemColors.ButtonHighlight
        sumar.Location = New Point(215, 89)
        sumar.Name = "sumar"
        sumar.Size = New Size(75, 32)
        sumar.TabIndex = 5
        sumar.Text = "Sumar"
        sumar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(3, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 20)
        Label1.TabIndex = 6
        Label1.Text = "Digíte un número en cada casilla"' 
        ' cierro
        ' 
        cierro.BackColor = SystemColors.ButtonHighlight
        cierro.Location = New Point(296, 89)
        cierro.Name = "cierro"
        cierro.Size = New Size(75, 32)
        cierro.TabIndex = 7
        cierro.Text = "Cerrar"
        cierro.UseVisualStyleBackColor = False
        ' 
        ' igual
        ' 
        igual.BackColor = SystemColors.ButtonHighlight
        igual.Location = New Point(3, 127)
        igual.Name = "igual"
        igual.Size = New Size(75, 28)
        igual.TabIndex = 8
        igual.Text = "Igual"
        igual.UseVisualStyleBackColor = False
        ' 
        ' diferente
        ' 
        diferente.BackColor = SystemColors.ButtonHighlight
        diferente.Location = New Point(109, 127)
        diferente.Name = "diferente"
        diferente.Size = New Size(81, 28)
        diferente.TabIndex = 9
        diferente.Text = "Diferente"
        diferente.UseVisualStyleBackColor = False
        ' 
        ' mayorque
        ' 
        mayorque.BackColor = SystemColors.ButtonHighlight
        mayorque.Location = New Point(3, 161)
        mayorque.Name = "mayorque"
        mayorque.Size = New Size(93, 29)
        mayorque.TabIndex = 10
        mayorque.Text = "Mayor que"
        mayorque.UseVisualStyleBackColor = False
        ' 
        ' menorque
        ' 
        menorque.BackColor = SystemColors.ButtonHighlight
        menorque.Location = New Point(109, 161)
        menorque.Name = "menorque"
        menorque.Size = New Size(90, 29)
        menorque.TabIndex = 11
        menorque.Text = "Menor que"
        menorque.UseVisualStyleBackColor = False
        ' 
        ' mayorigual
        ' 
        mayorigual.BackColor = SystemColors.ButtonHighlight
        mayorigual.Location = New Point(3, 196)
        mayorigual.Name = "mayorigual"
        mayorigual.Size = New Size(100, 29)
        mayorigual.TabIndex = 12
        mayorigual.Text = "Mayor igual"
        mayorigual.UseVisualStyleBackColor = False
        ' 
        ' menorigual
        ' 
        menorigual.BackColor = SystemColors.ButtonHighlight
        menorigual.Location = New Point(109, 196)
        menorigual.Name = "menorigual"
        menorigual.Size = New Size(100, 29)
        menorigual.TabIndex = 13
        menorigual.Text = "Menor igual"
        menorigual.UseVisualStyleBackColor = False
        ' 
        ' primo
        ' 
        primo.BackColor = SystemColors.ButtonHighlight
        primo.Location = New Point(3, 251)
        primo.Name = "primo"
        primo.Size = New Size(100, 32)
        primo.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(3, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 20)
        Label2.TabIndex = 15
        Label2.Text = "Ingrese un número"' 
        ' primoo
        ' 
        primoo.BackColor = SystemColors.ButtonHighlight
        primoo.Location = New Point(109, 251)
        primoo.Name = "primoo"
        primoo.Size = New Size(125, 32)
        primoo.TabIndex = 16
        primoo.Text = "Es primo o No"
        primoo.UseVisualStyleBackColor = False
        ' 
        ' dia
        ' 
        dia.BackColor = SystemColors.ButtonHighlight
        dia.Location = New Point(3, 289)
        dia.Name = "dia"
        dia.Size = New Size(100, 32)
        dia.TabIndex = 17
        dia.Text = "Escribe el día"' 
        ' mes
        ' 
        mes.BackColor = SystemColors.ButtonHighlight
        mes.Location = New Point(109, 289)
        mes.Name = "mes"
        mes.Size = New Size(111, 32)
        mes.TabIndex = 18
        mes.Text = "Escribe el mes"' 
        ' fecha
        ' 
        fecha.BackColor = SystemColors.ButtonHighlight
        fecha.Location = New Point(226, 289)
        fecha.Name = "fecha"
        fecha.Size = New Size(75, 32)
        fecha.TabIndex = 19
        fecha.Text = "Calcular"
        fecha.UseVisualStyleBackColor = False
        ' 
        ' tabla
        ' 
        tabla.BackColor = SystemColors.ButtonHighlight
        tabla.Location = New Point(240, 251)
        tabla.Name = "tabla"
        tabla.Size = New Size(157, 32)
        tabla.TabIndex = 20
        tabla.Text = "Tabla de multiplicar"
        tabla.UseVisualStyleBackColor = False
        ' 
        ' mayorif
        ' 
        mayorif.BackColor = SystemColors.ButtonHighlight
        mayorif.Location = New Point(196, 127)
        mayorif.Name = "mayorif"
        mayorif.Size = New Size(237, 28)
        mayorif.TabIndex = 21
        mayorif.Text = "Determinar si es mayor o igual"
        mayorif.UseVisualStyleBackColor = False
        ' 
        ' palabra
        ' 
        palabra.Location = New Point(403, 13)
        palabra.Name = "palabra"
        palabra.Size = New Size(67, 32)
        palabra.TabIndex = 22
        palabra.Text = "Palabra"
        palabra.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(multiple)
        GroupBox1.Controls.Add(nume2)
        GroupBox1.Controls.Add(nume1)
        GroupBox1.Controls.Add(dividir)
        GroupBox1.Controls.Add(resta)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(3, 327)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(247, 81)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Seleccione una opción"' 
        ' multiple
        ' 
        multiple.Location = New Point(164, 31)
        multiple.Name = "multiple"
        multiple.Size = New Size(75, 32)
        multiple.TabIndex = 4
        multiple.Text = "Calcular"
        multiple.UseVisualStyleBackColor = True
        ' 
        ' nume2
        ' 
        nume2.Location = New Point(126, 31)
        nume2.Name = "nume2"
        nume2.Size = New Size(32, 32)
        nume2.TabIndex = 3
        ' 
        ' nume1
        ' 
        nume1.Location = New Point(83, 31)
        nume1.Name = "nume1"
        nume1.Size = New Size(37, 32)
        nume1.TabIndex = 2
        ' 
        ' dividir
        ' 
        dividir.AutoSize = True
        dividir.Location = New Point(6, 53)
        dividir.Name = "dividir"
        dividir.Size = New Size(70, 24)
        dividir.TabIndex = 1
        dividir.TabStop = True
        dividir.Text = "Dividir"
        dividir.UseVisualStyleBackColor = True
        ' 
        ' resta
        ' 
        resta.AutoSize = True
        resta.Location = New Point(6, 23)
        resta.Name = "resta"
        resta.Size = New Size(71, 24)
        resta.TabIndex = 0
        resta.TabStop = True
        resta.Text = "Restar"
        resta.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(265, 327)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 20)
        Label3.TabIndex = 24
        Label3.Text = "Qué colores le gustan ?"' 
        ' azul
        ' 
        azul.AutoSize = True
        azul.BackColor = SystemColors.ButtonHighlight
        azul.Location = New Point(265, 351)
        azul.Name = "azul"
        azul.Size = New Size(58, 24)
        azul.TabIndex = 25
        azul.Text = "Azul"
        azul.UseVisualStyleBackColor = False
        ' 
        ' rojo
        ' 
        rojo.AutoSize = True
        rojo.BackColor = SystemColors.ButtonHighlight
        rojo.Location = New Point(265, 381)
        rojo.Name = "rojo"
        rojo.Size = New Size(58, 24)
        rojo.TabIndex = 26
        rojo.Text = "Rojo"
        rojo.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(403, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(60, 34)
        Button1.TabIndex = 27
        Button1.Text = "Enviar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' verde
        ' 
        verde.AutoSize = True
        verde.BackColor = SystemColors.ButtonHighlight
        verde.Location = New Point(329, 350)
        verde.Name = "verde"
        verde.Size = New Size(66, 24)
        verde.TabIndex = 28
        verde.Text = "Verde"
        verde.UseVisualStyleBackColor = False
        ' 
        ' fibonacci
        ' 
        fibonacci.Location = New Point(296, 441)
        fibonacci.Name = "fibonacci"
        fibonacci.Size = New Size(81, 32)
        fibonacci.TabIndex = 29
        fibonacci.Text = "Fibonacci"
        fibonacci.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(3, 414)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(287, 84)
        ListBox1.TabIndex = 30
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(625, 522)
        Controls.Add(ListBox1)
        Controls.Add(fibonacci)
        Controls.Add(verde)
        Controls.Add(Button1)
        Controls.Add(rojo)
        Controls.Add(azul)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(palabra)
        Controls.Add(mayorif)
        Controls.Add(tabla)
        Controls.Add(fecha)
        Controls.Add(mes)
        Controls.Add(dia)
        Controls.Add(primoo)
        Controls.Add(Label2)
        Controls.Add(primo)
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
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
    Friend WithEvents primo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents primoo As Button
    Friend WithEvents dia As TextBox
    Friend WithEvents mes As TextBox
    Friend WithEvents fecha As Button
    Friend WithEvents tabla As Button
    Friend WithEvents mayorif As Button
    Friend WithEvents palabra As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nume2 As TextBox
    Friend WithEvents nume1 As TextBox
    Friend WithEvents dividir As RadioButton
    Friend WithEvents resta As RadioButton
    Friend WithEvents multiple As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents azul As CheckBox
    Friend WithEvents rojo As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents verde As CheckBox
    Friend WithEvents fibonacci As Button
    Friend WithEvents ListBox1 As ListBox
End Class
