Imports System.Data.SqlClient

Public Class DbUserService
    ' MSI String
    Private Shared ReadOnly ConnectionString As String = "Server=localhost\MSSQLSERVER01;Database=exchange;Trusted_Connection=True;"
    ' Compaq String
    'Private Shared ReadOnly ConnectionString As String = "Server=localhost;Database=exchange;Trusted_Connection=True;"
    Public Shared Function GetUser(username As String) As User
        Dim query As String = "SELECT * FROM users WHERE username = @username"
        Dim user As User
        Using Connection As New SqlConnection(ConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", username)
                End With

                Using dataReader As SqlDataReader = sqlCommand.ExecuteReader()
                    If Not dataReader.Read() Then
                        Throw New Exception("No se pudo obtener la información del usuario. Revisa tus credenciales e intenta nuevamente.")
                    End If
                    user = New User(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3))
                End Using
            End Using
        End Using
        Return user
    End Function
End Class
