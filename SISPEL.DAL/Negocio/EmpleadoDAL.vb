Imports RodriguezEscobedo.Framework.Persistencia
Imports RodriguezEscobedo.Framework.Serializadores
Imports SISPEL.Biz.Entities

Namespace DAL

    Public Class EmpleadoDAL

        Dim config As New Configuracion
        Dim serializador As New SerializadorXml
        Dim archivoConfiguracion As String = System.IO.File.ReadAllText("config.xml")

        Public Sub insertarEmpleado(Empleado As Empleado)

            config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

            Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
            Dim listaParametros As New List(Of Parametro)
            listaParametros.Add(New Parametro("empleado_nombre", Empleado.nombre))
            listaParametros.Add(New Parametro("empleado_apellido", Empleado.apellido))
            listaParametros.Add(New Parametro("empleado_dni", Empleado.dni))
            listaParametros.Add(New Parametro("empleado_activo", Empleado.activo))
            listaParametros.Add(New Parametro("empleado_userName", Empleado.usuario))
            listaParametros.Add(New Parametro("empleado_password", Empleado.contrasenia))
            listaParametros.Add(New Parametro("empleado_fechaDeNacimiento", Empleado.fechaDeNacimiento))
            listaParametros.Add(New Parametro("empleado_telefono", Empleado.telefono))
            listaParametros.Add(New Parametro("empleado_domicilio", Empleado.domicilio))


            nuevaConexion.ConexionIniciar()

            nuevaConexion.EjecutarSinResultado("INSERT INTO Empleado VALUES(@empleado_nombre,@empleado_apellido,@empleado_dni,@empleado_activo,@empleado_userName,@empleado_password,@empleado_fechaDeNacimiento,@empleado_telefono,@empleado_domicilio)", listaParametros)

            nuevaConexion.ConexionFinalizar()

        End Sub

        Public Function traerTodosLosEmpleados() As List(Of Empleado)

            config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

            Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
            Dim listaParametros As New List(Of Parametro)
            nuevaConexion.ConexionIniciar()

            Dim Resultado As List(Of Empleado) = nuevaConexion.EjecutarTupla(Of Empleado)("SELECT * FROM Empleado", listaParametros)

            nuevaConexion.ConexionFinalizar()

            Return Resultado

        End Function

        Public Function traerTodosLosEmpleadosPorNombre() As List(Of Empleado)

            config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

            Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
            Dim listaParametros As New List(Of Parametro)
            nuevaConexion.ConexionIniciar()

            Dim Resultado As List(Of Empleado) = nuevaConexion.EjecutarTupla(Of Empleado)("SELECT Nombre FROM Empleado", listaParametros)

            nuevaConexion.ConexionFinalizar()

            Return Resultado

        End Function

        Public Function comprobarInicioDeSesionDeEmpleado(user As String, password As String) As Boolean

            config = serializador.Deserealizar(Of Configuracion)(archivoConfiguracion)

            Dim nuevaConexion As New Conexion(Conexion.EstrategiasDbEnum.SqlServer, config.Servidor, config.Catalogo)
            Dim listaParametros As New List(Of Parametro)
            nuevaConexion.ConexionIniciar()
            listaParametros.Add(New Parametro("usuario", user))
            listaParametros.Add(New Parametro("contrasenia", password))

            nuevaConexion.ConexionIniciar()

            Dim checkRegistrado As Boolean


            Dim resultado As List(Of Empleado)

                resultado = nuevaConexion.EjecutarTupla(Of Empleado)("Select * from Empleado where Usuario=@usuario and Contrasenia=@contrasenia", listaParametros)

                nuevaConexion.ConexionFinalizar()

                If resultado.Count = 1 Then
                    checkRegistrado = True
                Else
                    checkRegistrado = False
                End If

                Return checkRegistrado

        End Function

    End Class

End Namespace