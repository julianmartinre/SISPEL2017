Imports RodriguezEscobedo.Framework.Seguridad
Imports SISPEL.Biz.Entities
Imports SISPEL.BLL.BLL

Public Class frmLogin

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim unEmpleado As New EmpleadoBLL(txtUser.Text)
        Dim unEncriptador As Encriptador = Encriptador.GetInstance

        If unEmpleado.id <> 0 Then

            If unEncriptador.ValidarHash(txtPassword.Text, unEmpleado.password) Then
                txtUser.Clear()
                txtPassword.Clear()
                Dim frmGestionDeEmpleados As New frmGestionEmpleado
                frmGestionDeEmpleados.Show()
            Else
                MsgBox("Error al iniciar sesión.")
            End If

        End If

    End Sub

End Class