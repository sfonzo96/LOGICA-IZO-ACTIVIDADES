Public Interface IOperationsService
    Function AddOperation(usdValue As Decimal, usdQuantity As Decimal, arsQuantity As Decimal) As Boolean
    Function GetOperations() As List(Of Operation)
End Interface
