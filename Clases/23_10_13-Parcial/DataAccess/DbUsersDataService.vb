Imports System.Data.SqlClient

Public Class DbUsersDataService
    Private ReadOnly ConnectionString As String = "Server=localhost;Database=exchange;Trusted_Connection=True;"
    Public Function GetUser(username As String) As User
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
                        Throw New Exception("El usuario y/o contraseña son incorrectos. Intenta nuevamente")
                    End If
                    user = New User(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3))
                End Using
            End Using
        End Using
        Return user
    End Function
End Class
