<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccederToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DimeHolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccederToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccederToolStripMenuItem
        '
        Me.AccederToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FromulariosToolStripMenuItem, Me.DimeHolaToolStripMenuItem})
        Me.AccederToolStripMenuItem.Name = "AccederToolStripMenuItem"
        Me.AccederToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AccederToolStripMenuItem.Text = "Acceder"
        '
        'FromulariosToolStripMenuItem
        '
        Me.FromulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Formulario2ToolStripMenuItem})
        Me.FromulariosToolStripMenuItem.Name = "FromulariosToolStripMenuItem"
        Me.FromulariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FromulariosToolStripMenuItem.Text = "Fromularios"
        '
        'Formulario2ToolStripMenuItem
        '
        Me.Formulario2ToolStripMenuItem.Name = "Formulario2ToolStripMenuItem"
        Me.Formulario2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formulario2ToolStripMenuItem.Text = "Formulario2"
        '
        'DimeHolaToolStripMenuItem
        '
        Me.DimeHolaToolStripMenuItem.Name = "DimeHolaToolStripMenuItem"
        Me.DimeHolaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DimeHolaToolStripMenuItem.Text = "Dime hola"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(506, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccederToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DimeHolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
End Class
