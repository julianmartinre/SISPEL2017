Imports SISPEL.BLL
Imports RodriguezEscobedo.Framework
Imports RodriguezEscobedo.Framework.System.Windows

Public Class frmIdioma
    Implements IObservador

    Dim mTraductor As Traductor = Traductor.GetInstance
    Dim mIdiomaSelec As IdiomaBLL = Nothing

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


    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    ''' <summary>
    ''' Cambia el todos los mensajes de los controles por los mensajes que haya en Traductor.GetInstance().IdiomaSeleccionado.Diccionario
    ''' </summary>
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

    ''' <summary>
    ''' Carga en ComboIdiomas todos los idiomas que haya guardados en BD
    ''' </summary>
    Public Sub ActualizarCombo()
        cbIdiomas.Items.Clear()

        For Each mIdioma As IdiomaBLL In IdiomaBLL.ListarIdiomas
            cbIdiomas.Items.Add(mIdioma)
        Next
    End Sub


    ''' <summary>
    ''' Carga en GridTextos todas las traducciones que haya en mIdiomaSelec.Diccionario
    ''' </summary>
    Public Sub ActualizarGrid()
        dtTextos.Rows.Clear()

        If Not IsNothing(mIdiomaSelec) Then
            For Each mTexto As KeyValuePair(Of String, String) In mIdiomaSelec.Diccionario
                dtTextos.Rows.Add(mTexto.Key, mTexto.Value)
            Next
        End If
    End Sub

    Private Sub frmIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtTextos.ColumnCount = 2
        dtTextos.Columns(0).Name = "Key"
        dtTextos.Columns(0).Visible = False
        dtTextos.Columns(1).Name = "Texto"

        mTraductor.RegistrarObservador(Me)

        ActualizarCombo()
        cbIdiomas.SelectedIndex = 0

        ActualizarGrid()

        Actualizar(Me)

    End Sub

    Private Sub cbIdiomas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbIdiomas.SelectedValueChanged

        If Not IsNothing(cbIdiomas.SelectedItem) Then
            If TypeOf cbIdiomas.SelectedItem Is IdiomaBLL Then
                mIdiomaSelec = cbIdiomas.SelectedItem
                ActualizarGrid()
            End If
        End If

    End Sub

    Private Sub dtTextos_SelectionChanged(sender As Object, e As EventArgs) Handles dtTextos.SelectionChanged

        If dtTextos.SelectedRows.Count > 0 Then
            If dtTextos.SelectedRows(0).Cells(0).Value <> "" Then
                txtTextoSeleccionado.Text = dtTextos.SelectedRows(0).Cells(1).Value
                txtTraduccion.Text = dtTextos.SelectedRows(0).Cells(1).Value
            End If
        End If

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        If MsgBox("Esta seguro que desea guardar los cambios hechos a las traducciones de este idioma?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Not IsNothing(mIdiomaSelec) Then
                For i = 0 To (dtTextos.RowCount - 2)
                    mIdiomaSelec.Diccionario.Item(dtTextos.Rows.Item(i).Cells(0).Value) = dtTextos.Rows.Item(i).Cells(1).Value
                Next

                mIdiomaSelec.GuardarTraducciones()
            End If
        End If

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

        If dtTextos.SelectedRows.Count > 0 Then
            If dtTextos.SelectedRows(0).Cells(0).Value <> "" Then
                dtTextos.SelectedRows(0).Cells(1).Value = txtTraduccion.Text
                txtTextoSeleccionado.Text = dtTextos.SelectedRows(0).Cells(1).Value
            End If
        End If

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click

        Dim mIdioma As New IdiomaBLL

        mIdioma.Nombre = InputBox("Ingrese el nombre del nuevo idioma")

        mIdioma.Guardar()

        ActualizarCombo()
        ActualizarGrid()

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click

        If Not IsNothing(mIdiomaSelec) Then
            If MsgBox("Esta seguro que desea borrar este idioma del sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mIdiomaSelec.Eliminar()
            End If

            ActualizarCombo()
            ActualizarGrid()
        End If

    End Sub

#End Region

End Class