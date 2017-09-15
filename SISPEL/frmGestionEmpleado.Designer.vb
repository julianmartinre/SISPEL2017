<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionEmpleado
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
        Me.tlAlta = New MetroFramework.Controls.MetroTile()
        Me.tlBaja = New MetroFramework.Controls.MetroTile()
        Me.tlEdit = New MetroFramework.Controls.MetroTile()
        Me.tlSelect = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'tlAlta
        '
        Me.tlAlta.ActiveControl = Nothing
        Me.tlAlta.Location = New System.Drawing.Point(35, 67)
        Me.tlAlta.Name = "tlAlta"
        Me.tlAlta.Size = New System.Drawing.Size(98, 91)
        Me.tlAlta.TabIndex = 0
        Me.tlAlta.Text = "ALTA"
        Me.tlAlta.UseSelectable = True
        '
        'tlBaja
        '
        Me.tlBaja.ActiveControl = Nothing
        Me.tlBaja.Location = New System.Drawing.Point(138, 67)
        Me.tlBaja.Name = "tlBaja"
        Me.tlBaja.Size = New System.Drawing.Size(98, 91)
        Me.tlBaja.TabIndex = 1
        Me.tlBaja.Text = "BAJA"
        Me.tlBaja.UseSelectable = True
        '
        'tlEdit
        '
        Me.tlEdit.ActiveControl = Nothing
        Me.tlEdit.Location = New System.Drawing.Point(35, 163)
        Me.tlEdit.Name = "tlEdit"
        Me.tlEdit.Size = New System.Drawing.Size(98, 91)
        Me.tlEdit.TabIndex = 2
        Me.tlEdit.Text = "EDITAR"
        Me.tlEdit.UseSelectable = True
        '
        'tlSelect
        '
        Me.tlSelect.ActiveControl = Nothing
        Me.tlSelect.Location = New System.Drawing.Point(138, 163)
        Me.tlSelect.Name = "tlSelect"
        Me.tlSelect.Size = New System.Drawing.Size(98, 91)
        Me.tlSelect.TabIndex = 3
        Me.tlSelect.Text = "VER"
        Me.tlSelect.UseSelectable = True
        '
        'frmGestionEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 271)
        Me.Controls.Add(Me.tlSelect)
        Me.Controls.Add(Me.tlEdit)
        Me.Controls.Add(Me.tlBaja)
        Me.Controls.Add(Me.tlAlta)
        Me.Name = "frmGestionEmpleado"
        Me.Text = "Gestión de Empleado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlAlta As MetroFramework.Controls.MetroTile
    Friend WithEvents tlBaja As MetroFramework.Controls.MetroTile
    Friend WithEvents tlEdit As MetroFramework.Controls.MetroTile
    Friend WithEvents tlSelect As MetroFramework.Controls.MetroTile
End Class
