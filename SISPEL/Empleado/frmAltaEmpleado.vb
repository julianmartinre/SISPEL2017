Imports SISPEL.Biz.Entities
Imports SISPEL.BLL.BLL
Imports RodriguezEscobedo.Framework.Seguridad

Public Class frmAltaEmpleado

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim empleadoBLL As New EmpleadoBLL
        Dim unEncriptador As Encriptador = Encriptador.GetInstance
        Dim esValido As Boolean = True

        Dim unEmpleado As New Empleado

        If txtNombre.Text <> "" Then
            unEmpleado.nombre = txtNombre.Text
        Else
            MsgBox("Debe ingresar un Nombre válido")
            txtNombre.BackColor = Color.Red
            esValido = False
        End If

        If txtApellido.Text <> "" Then
            unEmpleado.apellido = txtApellido.Text
        Else
            MsgBox("Debe ingresar un Apellido válido")
            txtApellido.BackColor = Color.Red
            esValido = False
        End If

        If txtDni.Text <> "" Then
            unEmpleado.dni = txtDni.Text
        Else
            MsgBox("Debe ingresar un DNI válido")
            txtDni.BackColor = Color.Red
            esValido = False
        End If

        If txtUser.Text <> "" Then
            unEmpleado.usuario = txtUser.Text
        Else
            MsgBox("Debe ingresar un Usuario válido")
            txtUser.BackColor = Color.Red
            esValido = False
        End If

        If txtPassword.Text <> "" Then
            unEmpleado.contrasenia = unEncriptador.Encriptar(txtPassword.Text)
        Else
            MsgBox("Debe ingresar una Contraseña válida")
            txtPassword.BackColor = Color.Red
            esValido = False
        End If

        If txtTelefono.Text <> "" Then
            unEmpleado.telefono = txtTelefono.Text
        Else
            MsgBox("Debe ingresar un Teléfono válido")
            txtTelefono.BackColor = Color.Red
            esValido = False
        End If

        If txtDomicilio.Text <> "" Then
            unEmpleado.domicilio = txtDomicilio.Text
        Else
            MsgBox("Debe ingresar un Domicilio válido")
            txtDomicilio.BackColor = Color.Red
            esValido = False
        End If

        'If dtFechaDeNacimiento.Value <> "" Then
        '    unEmpleado.fechaDeNacimiento = dtFechaDeNacimiento.Value
        'Else
        '    MsgBox("Debe ingresar una fecha válida")
        '    dtFechaDeNacimiento.BackColor = Color.Red
        '    esValido = False
        'End If

        unEmpleado.fechaDeNacimiento = dtFechaDeNacimiento.Value
        unEmpleado.activo = True

        If esValido = True Then
            'empleadoBLL.insertarEmpleado(unEmpleado)
        End If

    End Sub

End Class