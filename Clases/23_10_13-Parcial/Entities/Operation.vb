Public Class Operation
    Public Property UsdQuantity As Decimal
    Public Property ArsQuantity As Decimal
    Public Property UsdValue As Decimal
    Public Property OperationDate As DateTime

    Public Sub New(operationDate As DateTime, usdValue As Decimal, usdQuantity As Decimal, arsQuantity As Decimal)
        Me.UsdQuantity = usdQuantity
        Me.ArsQuantity = arsQuantity
        Me.UsdValue = usdValue
        Me.OperationDate = operationDate
    End Sub
End Class
