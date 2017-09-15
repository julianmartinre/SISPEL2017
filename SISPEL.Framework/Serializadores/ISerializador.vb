Public Interface ISerializador

    Function Serializar(unObjeto As Object) As String

    Function Deserealizar(Of T As New)(unObjetoSerializadoEnXml As String) As T

End Interface
