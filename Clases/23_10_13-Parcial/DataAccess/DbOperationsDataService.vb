Imports System.Data.SqlClient
Public Class DbOperationsDataService
    Private ReadOnly ConnectionString As String = "Server=localhost;Database=exchange;Trusted_Connection=True;"
    Public Function AddOperation(usdValue As Decimal, usdQuantity As Decimal, arsQuantity As Decimal) As Boolean
        Dim query As String = "INSERT INTO operations (usd_value,usd_quantity,ars_quantity) values (@usd_value,@usd_quantity,@ars_quantity)"
        Using Connection As New SqlConnection(ConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@usd_value", usdValue)
                    .Parameters.AddWithValue("@usd_quantity", usdQuantity)
                    .Parameters.AddWithValue("@ars_quantity", arsQuantity)
                End With

                sqlCommand.ExecuteNonQuery()
            End Using
        End Using
        Return True
    End Function

    Public Function GetOperations() As List(Of Operation)
        Dim query As String = "SELECT * FROM operations"
        Dim operations As New List(Of Operation)
        Using Connection As New SqlConnection(ConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                Using dataReader As SqlDataReader = sqlCommand.ExecuteReader()
                    While dataReader.Read()
                        Dim operation As New Operation(dataReader.GetDateTime(1), dataReader.GetDecimal(2), dataReader.GetDecimal(3), dataReader.GetDecimal(4))
                        operations.Add(operation)
                    End While
                End Using
            End Using
        End Using
        Return operations
    End Function
End Class