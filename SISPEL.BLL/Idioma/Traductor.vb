Imports RodriguezEscobedo.Framework
Imports System.Windows.Forms
Imports RodriguezEscobedo

''' <summary>
''' Clase Singleton
''' Observable
''' </summary>
Public Class Traductor
    Implements IObservado

#Region "Singleton"

    Private Shared mTraductor As Traductor

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As Traductor
        If mTraductor Is Nothing Then
            mTraductor = New Traductor
        End If

        Return mTraductor
    End Function

#End Region


    Private mIdiomaSelec As IdiomaBLL
    ''' <remarks>
    ''' Cuando se cambie esta propiedad, se actualizaran todos los observadores que haya registrados
    ''' </remarks>
    Public Property IdiomaSeleccionado() As IdiomaBLL
        Get
            Return mIdiomaSelec
        End Get
        Set(ByVal value As IdiomaBLL)
            If mIdiomaSelec Is Nothing OrElse mIdiomaSelec.Nombre <> value.Nombre Then
                mIdiomaSelec = value
                ActualizarObservadores()
            End If
        End Set
    End Property


#Region "IObservado"

    Dim mListaRegistrados As New List(Of IObservador)
    ''' <summary>
    ''' Lista de los observadores registrados para esta instancia
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ObservadoresRegistrados As List(Of IObservador) Implements IObservado.ObservadoresRegistrados
        Get
            Return mListaRegistrados
        End Get
    End Property


    ''' <summary>
    ''' Registra un nuevo observador a la lista
    ''' </summary>
    ''' <param name="pObservador">Observador que se quiere registrar</param>
    Public Sub RegistrarObservador(pObservador As IObservador) Implements IObservado.RegistrarObservador
        If mListaRegistrados.Count > 0 Then
            For Each mObservador As IObservador In mListaRegistrados
                If mObservador.ToString = pObservador.ToString Then
                    mListaRegistrados.Remove(mObservador)
                    Exit For
                End If
            Next
        End If

        mListaRegistrados.Add(pObservador)
    End Sub


    ''' <summary>
    ''' Quita a un observador de la lista
    ''' </summary>
    ''' <param name="pObservador">Observador que quiere quitarse de la lista</param>
    Public Sub DesregistrarObservador(pObservador As IObservador) Implements IObservado.DesregistrarObservador
        For Each mObservador As IObservador In mListaRegistrados
            If mObservador.ToString = pObservador.ToString Then
                mListaRegistrados.Remove(mObservador)
                Exit For
            End If
        Next
    End Sub


    ''' <summary>
    ''' Ejecuta el metodo Actualizar() de todos los observadores registrados en esta instancia
    ''' </summary>
    Public Sub ActualizarObservadores() Implements IObservado.ActualizarObservadores
        For Each mObservador As IObservador In mListaRegistrados
            mObservador.Actualizar(mObservador)
        Next
    End Sub

#End Region


    ''' <summary>
    ''' Traduce texto de un idioma al idioma que haya en IdiomaSeleccionado
    ''' </summary>
    ''' <param name="pTexto">Texto que se quiere traducir</param>
    ''' <returns>Texto traducido</returns>
    Public Function Traducir(pTexto As String) As String
        If Me.IdiomaSeleccionado.Diccionario.ContainsKey(pTexto) Then
            Return Me.IdiomaSeleccionado.Diccionario(pTexto)
        Else
            Return pTexto
        End If
    End Function

End Class

