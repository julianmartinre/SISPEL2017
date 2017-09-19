<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdioma
    Inherits MetroFramework.Forms.MetroForm

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
        Me.cbIdiomas = New MetroFramework.Controls.MetroComboBox()
        Me.dtTextos = New System.Windows.Forms.DataGridView()
        Me.txtTextoSeleccionado = New MetroFramework.Controls.MetroTextBox()
        Me.txtTraduccion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        CType(Me.dtTextos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbIdiomas
        '
        Me.cbIdiomas.FormattingEnabled = True
        Me.cbIdiomas.ItemHeight = 23
        Me.cbIdiomas.Location = New System.Drawing.Point(9, 63)
        Me.cbIdiomas.Name = "cbIdiomas"
        Me.cbIdiomas.Size = New System.Drawing.Size(495, 29)
        Me.cbIdiomas.TabIndex = 0
        Me.cbIdiomas.UseSelectable = True
        '
        'dtTextos
        '
        Me.dtTextos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTextos.Location = New System.Drawing.Point(9, 98)
        Me.dtTextos.Name = "dtTextos"
        Me.dtTextos.Size = New System.Drawing.Size(240, 311)
        Me.dtTextos.TabIndex = 2
        '
        'txtTextoSeleccionado
        '
        '
        '
        '
        Me.txtTextoSeleccionado.CustomButton.Image = Nothing
        Me.txtTextoSeleccionado.CustomButton.Location = New System.Drawing.Point(227, 1)
        Me.txtTextoSeleccionado.CustomButton.Name = ""
        Me.txtTextoSeleccionado.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTextoSeleccionado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTextoSeleccionado.CustomButton.TabIndex = 1
        Me.txtTextoSeleccionado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTextoSeleccionado.CustomButton.UseSelectable = True
        Me.txtTextoSeleccionado.CustomButton.Visible = False
        Me.txtTextoSeleccionado.Lines = New String(-1) {}
        Me.txtTextoSeleccionado.Location = New System.Drawing.Point(255, 123)
        Me.txtTextoSeleccionado.MaxLength = 32767
        Me.txtTextoSeleccionado.Name = "txtTextoSeleccionado"
        Me.txtTextoSeleccionado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTextoSeleccionado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTextoSeleccionado.SelectedText = ""
        Me.txtTextoSeleccionado.SelectionLength = 0
        Me.txtTextoSeleccionado.SelectionStart = 0
        Me.txtTextoSeleccionado.ShortcutsEnabled = True
        Me.txtTextoSeleccionado.Size = New System.Drawing.Size(249, 23)
        Me.txtTextoSeleccionado.TabIndex = 3
        Me.txtTextoSeleccionado.UseSelectable = True
        Me.txtTextoSeleccionado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTextoSeleccionado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTraduccion
        '
        '
        '
        '
        Me.txtTraduccion.CustomButton.Image = Nothing
        Me.txtTraduccion.CustomButton.Location = New System.Drawing.Point(227, 1)
        Me.txtTraduccion.CustomButton.Name = ""
        Me.txtTraduccion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTraduccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTraduccion.CustomButton.TabIndex = 1
        Me.txtTraduccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTraduccion.CustomButton.UseSelectable = True
        Me.txtTraduccion.CustomButton.Visible = False
        Me.txtTraduccion.Lines = New String(-1) {}
        Me.txtTraduccion.Location = New System.Drawing.Point(255, 183)
        Me.txtTraduccion.MaxLength = 32767
        Me.txtTraduccion.Name = "txtTraduccion"
        Me.txtTraduccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTraduccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTraduccion.SelectedText = ""
        Me.txtTraduccion.SelectionLength = 0
        Me.txtTraduccion.SelectionStart = 0
        Me.txtTraduccion.ShortcutsEnabled = True
        Me.txtTraduccion.Size = New System.Drawing.Size(249, 23)
        Me.txtTraduccion.TabIndex = 4
        Me.txtTraduccion.UseSelectable = True
        Me.txtTraduccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTraduccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(255, 98)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Texto Seleccionado"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(255, 161)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Traducción"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(255, 212)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(120, 23)
        Me.MetroButton1.TabIndex = 7
        Me.MetroButton1.Text = "Guardar Cambios"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(384, 212)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(120, 23)
        Me.MetroButton2.TabIndex = 8
        Me.MetroButton2.Text = "Cambiar Traducción"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(255, 386)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(120, 23)
        Me.MetroButton3.TabIndex = 9
        Me.MetroButton3.Text = "Nuevo Idioma"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(381, 386)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(120, 23)
        Me.MetroButton4.TabIndex = 10
        Me.MetroButton4.Text = "Eliminar Idioma"
        Me.MetroButton4.UseSelectable = True
        '
        'frmIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 419)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtTraduccion)
        Me.Controls.Add(Me.txtTextoSeleccionado)
        Me.Controls.Add(Me.dtTextos)
        Me.Controls.Add(Me.cbIdiomas)
        Me.Name = "frmIdioma"
        Me.Text = "Gestión de IDIOMAS"
        CType(Me.dtTextos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbIdiomas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtTextos As DataGridView
    Friend WithEvents txtTextoSeleccionado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTraduccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
End Class
