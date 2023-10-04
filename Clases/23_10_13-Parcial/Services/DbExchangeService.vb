Imports System.Data.SqlClient
Public Class DbExchangeService
    Private Shared ReadOnly ConnectionString As String = "Server=localhost\MSSQLSERVER01;Database=exchange;Trusted_Connection=True;"
    Public Shared Function InsertOperation(usdValue As Decimal, usdQuantity As Decimal, arsQuantity As Decimal) As Boolean
        Dim sqlCommand As New SqlCommand()
        Dim query As String = "INSERT INTO operations (usd_value,usd_quantity,ars_quantity) values (@usd_value,@usd_quantity,@ars_quantity)"
        Using Connection As New SqlConnection(ConnectionString)
            Connection.Open()
            With sqlCommand
                .Connection = Connection
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@usd_value", usdValue)
                .Parameters.AddWithValue("@usd_quantity", usdQuantity)
                .Parameters.AddWithValue("@ars_quantity", arsQuantity)
            End With

            Try
                Dim affectedRows As Integer = sqlCommand.ExecuteNonQuery()
                Return True
            Catch sqlEx As SqlException
                MessageBox.Show(sqlEx.Message)
                Return False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            Finally
                Connection.Close()
            End Try
        End Using
    End Function

    'Public Shared Function readOperations() As List(Of Operation)

    'End Function
End Class