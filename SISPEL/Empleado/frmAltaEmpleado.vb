Imports SISPEL.Biz.Entities
Imports SISPEL.BLL.BLL

Public Class frmAltaEmpleado

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Try

            Dim unEmpleado As New Empleado
            unEmpleado.nombre = txtNombre.Text
            unEmpleado.apellido = txtApellido.Text
            unEmpleado.dni = txtDni.Text
            unEmpleado.usuario = txtUser.Text
            unEmpleado.contrasenia = txtPassword.Text
            unEmpleado.telefono = txtTelefono.Text
            unEmpleado.domicilio = txtDomicilio.Text
            unEmpleado.fechaDeNacimiento = dtFechaDeNacimiento.Value

            Dim gestorEmpleado As New GestorEmpleado
            gestorEmpleado.insertarEmpleado(unEmpleado)
            MsgBox("Usuario agregado con éxito.")

        Catch ex As Exception

            MsgBox("Error al agregar el sistema.")

        End Try

    End Sub

End Class