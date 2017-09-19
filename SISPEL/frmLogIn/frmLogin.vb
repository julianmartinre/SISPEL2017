Imports RodriguezEscobedo.Framework
Imports RodriguezEscobedo.Framework.Seguridad
Imports SISPEL.Biz.Entities
Imports SISPEL.BLL
Imports SISPEL.BLL.BLL

Public Class frmLogin
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mBitacora As Bitacora = Bitacora.GetInstance

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Public Sub Actualizar(pObservador As Control) Implements IObservador.Actualizar
        For Each mControl As Control In pObservador.Controls
            Try
                mControl.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(mControl.Tag)
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    Actualizar(mControl)
                End If
            End Try
        Next
    End Sub

    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim unEmpleado As New EmpleadoBLL(txtUser.Text)
        Dim unEncriptador As Encriptador = Encriptador.GetInstance

        If unEmpleado.id <> 0 Then

            If unEncriptador.ValidarHash(txtPassword.Text, unEmpleado.password) Then
                txtUser.Clear()
                txtPassword.Clear()
                mBitacora.GuardarRegistro(unEmpleado.dni, System.DateTime.Now.Date, "Ingreso al sistema.")
                Dim frmGestionDeEmpleados As New frmGestionEmpleado
                frmGestionDeEmpleados.Show()
            Else
                MsgBox("Error al iniciar sesión.")
            End If

        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)

    End Sub

End Class