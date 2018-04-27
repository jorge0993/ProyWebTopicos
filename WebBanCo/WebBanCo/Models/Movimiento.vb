Public Class MovimientoDatosModel
    Public Property IdMovimientos As Integer
    Public Property TipoMovimiento As String
    Public Property Tarjeta As String
    Public Property CantidadMovimiento As Double
End Class
Public Class Movimientos
    Dim movDato As New DatosDataContext

    Function MovimientosDatos() As List(Of MovimientoDatosModel)
        Dim list As List(Of MovimientoDatosModel) = New List(Of MovimientoDatosModel)
        Dim query = From u In movDato.Movimientos
                    Where u.Tarjeta = System.Configuration.ConfigurationManager.AppSettings("tarjeta").ToString().Trim()

        Dim listData = query.ToList()

        For Each datos In listData
            list.Add(New MovimientoDatosModel() With {
            .IdMovimientos = datos.IdMovimientos,
            .TipoMovimiento = datos.TipoMovimiento,
            .Tarjeta = datos.Tarjeta,
            .CantidadMovimiento = datos.CantidadMovimiento
            })
        Next
        Return list
    End Function
End Class