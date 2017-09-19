Public Interface IObservado

    ReadOnly Property ObservadoresRegistrados As List(Of IObservador)

    Sub RegistrarObservador(pObservador As IObservador)
    Sub DesregistrarObservador(pObservador As IObservador)
    Sub ActualizarObservadores()

End Interface
