<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupDB
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreBackup = New MetroFramework.Controls.MetroTextBox()
        Me.txtDireccionBackup = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombreBackup)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton3)
        Me.GroupBox2.Controls.Add(Me.MetroButton2)
        Me.GroupBox2.Controls.Add(Me.txtDireccionBackup)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 97)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Restaurar"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Nombre"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 16)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Dirección:"
        '
        'txtNombreBackup
        '
        '
        '
        '
        Me.txtNombreBackup.CustomButton.Image = Nothing
        Me.txtNombreBackup.CustomButton.Location = New System.Drawing.Point(195, 1)
        Me.txtNombreBackup.CustomButton.Name = ""
        Me.txtNombreBackup.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombreBackup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreBackup.CustomButton.TabIndex = 1
        Me.txtNombreBackup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreBackup.CustomButton.UseSelectable = True
        Me.txtNombreBackup.CustomButton.Visible = False
        Me.txtNombreBackup.Lines = New String(-1) {}
        Me.txtNombreBackup.Location = New System.Drawing.Point(12, 50)
        Me.txtNombreBackup.MaxLength = 32767
        Me.txtNombreBackup.Name = "txtNombreBackup"
        Me.txtNombreBackup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreBackup.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreBackup.SelectedText = ""
        Me.txtNombreBackup.SelectionLength = 0
        Me.txtNombreBackup.SelectionStart = 0
        Me.txtNombreBackup.ShortcutsEnabled = True
        Me.txtNombreBackup.Size = New System.Drawing.Size(217, 23)
        Me.txtNombreBackup.TabIndex = 3
        Me.txtNombreBackup.UseSelectable = True
        Me.txtNombreBackup.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombreBackup.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDireccionBackup
        '
        '
        '
        '
        Me.txtDireccionBackup.CustomButton.Image = Nothing
        Me.txtDireccionBackup.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtDireccionBackup.CustomButton.Name = ""
        Me.txtDireccionBackup.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDireccionBackup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccionBackup.CustomButton.TabIndex = 1
        Me.txtDireccionBackup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccionBackup.CustomButton.UseSelectable = True
        Me.txtDireccionBackup.CustomButton.Visible = False
        Me.txtDireccionBackup.Lines = New String(-1) {}
        Me.txtDireccionBackup.Location = New System.Drawing.Point(12, 38)
        Me.txtDireccionBackup.MaxLength = 32767
        Me.txtDireccionBackup.Name = "txtDireccionBackup"
        Me.txtDireccionBackup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccionBackup.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccionBackup.SelectedText = ""
        Me.txtDireccionBackup.SelectionLength = 0
        Me.txtDireccionBackup.SelectionStart = 0
        Me.txtDireccionBackup.ShortcutsEnabled = True
        Me.txtDireccionBackup.Size = New System.Drawing.Size(219, 23)
        Me.txtDireccionBackup.TabIndex = 4
        Me.txtDireccionBackup.UseSelectable = True
        Me.txtDireccionBackup.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccionBackup.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(235, 50)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(129, 23)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Crear"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(237, 38)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(127, 23)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "Examinar"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(12, 67)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(352, 23)
        Me.MetroButton3.TabIndex = 7
        Me.MetroButton3.Text = "Restaurar"
        Me.MetroButton3.UseSelectable = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 273)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBackup"
        Me.Text = "Gestión de BACKUP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreBackup As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDireccionBackup As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
