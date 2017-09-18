Imports SISPEL.Biz.Entities
Imports SISPEL.DAL.DAL

Namespace BLL

    Public Class GestorEmpleado
        Public Sub insertarEmpleado(Empleado As Empleado)

            If Empleado.nombre = "" Or Empleado.apellido = "" Or Empleado.dni = Nothing Then

                Throw New Exception

            End If

            Dim empleadoDAL As New EmpleadoDAL
            empleadoDAL.insertarEmpleado(Empleado)

        End Sub
    End Class

End Namespace
