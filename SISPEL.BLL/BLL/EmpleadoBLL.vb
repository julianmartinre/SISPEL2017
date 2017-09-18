Imports SISPEL.Biz.Entities
Imports SISPEL.DAL.DAL

Namespace BLL

    Public Class EmpleadoBLL

        Public Sub insertarEmpleado(unEmpleado As Empleado)

            If unEmpleado.dni > 0 And unEmpleado.dni < 99999999 Then
                Dim empleadoDAL As New EmpleadoDAL
                empleadoDAL.insertarEmpleado(unEmpleado)
            Else
                MsgBox("ERROR, DNI INVALIDO.")
            End If

        End Sub
    End Class

End Namespace
