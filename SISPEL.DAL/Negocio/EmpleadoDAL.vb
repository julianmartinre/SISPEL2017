'Imports RodriguezEscobedo.Framework.Persistencia
'Imports RodriguezEscobedo.Framework.Serializadores
Imports SISPEL.Biz.Entities
Imports SISPEL.DAL.Conexion

Namespace DAL

    Public Class EmpleadoDAL

        'Dim config As New Configuracion
        'Dim serializador As New SerializadorXml
        'Dim archivoConfiguracion As String = System.IO.File.ReadAllText("config.xml")

        'Public Sub insertarEmpleado(Empleado As Empleado)

        '    config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

        '    Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
        '    Dim listaParametros As New List(Of Parametro)
        '    listaParametros.Add(New Parametro("empleado_nombre", Empleado.nombre))
        '    listaParametros.Add(New Parametro("empleado_apellido", Empleado.apellido))
        '    listaParametros.Add(New Parametro("empleado_dni", Empleado.dni))
        '    listaParametros.Add(New Parametro("empleado_activo", Empleado.activo))
        '    listaParametros.Add(New Parametro("empleado_userName", Empleado.usuario))
        '    listaParametros.Add(New Parametro("empleado_password", Empleado.contrasenia))
        '    listaParametros.Add(New Parametro("empleado_fechaDeNacimiento", Empleado.fechaDeNacimiento))
        '    listaParametros.Add(New Parametro("empleado_telefono", Empleado.telefono))
        '    listaParametros.Add(New Parametro("empleado_domicilio", Empleado.domicilio))


        '    nuevaConexion.ConexionIniciar()

        '    nuevaConexion.EjecutarSinResultado("INSERT INTO Empleado VALUES(@empleado_nombre,@empleado_apellido,@empleado_dni,@empleado_activo,@empleado_userName,@empleado_password,@empleado_fechaDeNacimiento,@empleado_telefono,@empleado_domicilio)", listaParametros)

        '    nuevaConexion.ConexionFinalizar()

        'End Sub

        Public Shared Function ObtenerEmpleado(pUser As String) As Empleado
            Dim mUsuario As New Empleado
            Dim mCommand As String = "SELECT empleado_nombre, empleado_apellido, empleado_dni, empleado_activo, empleado_id, empleado_userName, empleado_password, empleado_fechaDeNacimiento, empleado_telefono, empleado_domicilio FROM Empleado WHERE empleado_userName LIKE '" & pUser & "';"

            Try
                Dim mDataSet As DataSet = BD.ExecuteDataSet(mCommand)

                If Not IsNothing(mDataSet) And mDataSet.Tables.Count > 0 And mDataSet.Tables(0).Rows.Count > 0 Then
                    mUsuario = CargarEmpleado(mUsuario, mDataSet.Tables(0).Rows(0))
                    Return mUsuario
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Error - DataSet - UsuarioDAL")
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Private Shared Function CargarEmpleado(pEmpleado As Empleado, pRow As DataRow) As Empleado

            pEmpleado.nombre = pRow("empleado_nombre")
            pEmpleado.apellido = pRow("empleado_apellido")
            pEmpleado.dni = pRow("empleado_dni")
            pEmpleado.activo = pRow("empleado_activo")
            pEmpleado.idEmpleado = pRow("empleado_id")
            pEmpleado.usuario = pRow("empleado_userName")
            pEmpleado.contrasenia = pRow("empleado_password")
            pEmpleado.fechaDeNacimiento = pRow("empleado_fechaDeNacimiento")
            pEmpleado.telefono = pRow("empleado_telefono")
            pEmpleado.domicilio = pRow("empleado_domicilio")

            Return pEmpleado

        End Function

        'Public Function traerTodosLosEmpleados() As List(Of Empleado)

        '    config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

        '    Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
        '    Dim listaParametros As New List(Of Parametro)
        '    nuevaConexion.ConexionIniciar()

        '    Dim Resultado As List(Of Empleado) = nuevaConexion.EjecutarTupla(Of Empleado)("SELECT * FROM Empleado", listaParametros)

        '    nuevaConexion.ConexionFinalizar()

        '    Return Resultado

        'End Function

        'Public Function traerTodosLosEmpleadosPorNombre() As List(Of Empleado)

        '    config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

        '    Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
        '    Dim listaParametros As New List(Of Parametro)
        '    nuevaConexion.ConexionIniciar()

        '    Dim Resultado As List(Of Empleado) = nuevaConexion.EjecutarTupla(Of Empleado)("SELECT Nombre FROM Empleado", listaParametros)

        '    nuevaConexion.ConexionFinalizar()

        '    Return Resultado

        'End Function

        'Public Function comprobarInicioDeSesionDeEmpleado(user As String, password As String) As Boolean

        '    config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

        '    Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
        '    Dim listaParametros As New List(Of Parametro)
        '    nuevaConexion.ConexionIniciar()
        '    listaParametros.Add(New Parametro("usuario", user))
        '    listaParametros.Add(New Parametro("contrasenia", password))

        '    nuevaConexion.ConexionIniciar()

        '    Dim checkRegistrado As Boolean


        '    Dim resultado As List(Of Empleado)

        '        resultado = nuevaConexion.EjecutarTupla(Of Empleado)("Select * from Empleado where Usuario=@usuario and Contrasenia=@contrasenia", listaParametros)

        '        nuevaConexion.ConexionFinalizar()

        '        If resultado.Count = 1 Then
        '            checkRegistrado = True
        '        Else
        '            checkRegistrado = False
        '        End If

        '        Return checkRegistrado

        'End Function

        Public Shared Sub GuardarNuevo(propEmpleado As Empleado)
            Dim mCommand As String = "INSERT INTO Empleado(empleado_nombre, empleado_apellido, empleado_dni, empleado_activo, empleado_id, empleado_userName, empleado_password, empleado_fechaDeNacimiento, empleado_telefono, empleado_domicilio) " &
                                     "VALUES ('" & propEmpleado.nombre & "', '" & propEmpleado.apellido & "', '" & propEmpleado.dni & "', '" & propEmpleado.activo & "', '" & propEmpleado.idEmpleado & "', '" & propEmpleado.usuario & "', '" & propEmpleado.contrasenia & "', '" & propEmpleado.fechaDeNacimiento & "', '" & propEmpleado.telefono & "', " & propEmpleado.domicilio & ");"

            Try
                BD.ExecuteNonQuery(mCommand)
            Catch ex As Exception
                MsgBox("Error - Nuevo - UsuarioDAL")
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Sub GuardarModificacion(propEmpleado As Empleado)
            Dim mCommand As String = "UPDATE Empleado SET " &
                                     "empleado_nombre = '" & propEmpleado.nombre &
                                     "', empleado_apellido = '" & propEmpleado.apellido &
                                     "', empleado_dni = '" & propEmpleado.dni &
                                     "', empleado_activo = '" & propEmpleado.activo &
                                     "', empleado_id = " & propEmpleado.idEmpleado &
                                     "', empleado_userName = '" & propEmpleado.usuario &
                                     "', empleado_password = " & propEmpleado.contrasenia &
                                     "', empleado_fechaDeNacimiento = '" & propEmpleado.fechaDeNacimiento &
                                     "', empleado_telefono = " & propEmpleado.telefono &
                                     ", empleado_domicilio = " & propEmpleado.domicilio &
                                     " WHERE empleado_id = " & propEmpleado.idEmpleado

            Try
                BD.ExecuteNonQuery(mCommand)
            Catch ex As Exception
                MsgBox("Error - Modificacion - UsuarioDAL")
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

End Namespace