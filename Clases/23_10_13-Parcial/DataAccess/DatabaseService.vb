Imports System.Data.SqlClient

Class DatabaseService
    Private Shared ReadOnly SQLServerConnectionString As String = "Server=localhost;Trusted_Connection=True;"
    Private Shared ReadOnly ExchangeDbConnectionString As String = "Server=localhost;Database=exchange;Trusted_Connection=True;"
    Private Shared Property DbName As String = "exchange"
    Private Shared ReadOnly Users As String(,) = New String(,) {{"izo", "izo2023", "Izo"}, {"mauricio", "mauri123", "Mauricio"}, {"santi", "santi123", "Santiago"}}
    Public Shared Property PersistenceSystem As String = "SQL"

    Private Shared Sub CreateDatabase()
        Dim query As String = "CREATE DATABASE " & DbName
        Using Connection As New SqlConnection(SQLServerConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                sqlCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Sub CreateTableOperations()
        Dim tableName As String = "operations"
        Dim query As String = "CREATE TABLE " & tableName & "(
            id BIGINT IDENTITY(1,1) PRIMARY KEY,
            operation_date DATETIME DEFAULT CURRENT_TIMESTAMP,
            usd_value DECIMAL(18, 2),
            usd_quantity DECIMAL(18, 2),
            ars_quantity DECIMAL(18, 2),
        );"
        Using Connection As New SqlConnection(ExchangeDbConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                sqlCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Sub CreateTableUsers()
        Dim tableName As String = "users"
        Dim query As String = "CREATE TABLE " & tableName & "(
            id BIGINT IDENTITY(1,1) PRIMARY KEY, -- Quitar y convertir username en primary key? O compuesta?
            username NVARCHAR(20),
            password NVARCHAR(20),
            nickname NVARCHAR(20)
            );"
        Using Connection As New SqlConnection(ExchangeDbConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                sqlCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Sub AddUsers(username As String, password As String, nickname As String)
        Dim query As String = "INSERT INTO users (username,password,nickname) values (@username,@password,@nickname)"
        Using Connection As New SqlConnection(ExchangeDbConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", username)
                    .Parameters.AddWithValue("@password", password)
                    .Parameters.AddWithValue("@nickname", nickname)
                End With

                sqlCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Function DbExists() As Boolean
        Dim query As String = "SELECT COUNT(*) FROM sys.databases WHERE name = @dbName"

        Using Connection As New SqlConnection(SQLServerConnectionString)
            Using sqlCommand As New SqlCommand()
                Connection.Open()

                With sqlCommand
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@dbName", DbName)
                End With

                Dim result As Integer = sqlCommand.ExecuteScalar()

                Return result > 0
            End Using
        End Using
    End Function

    Public Shared Sub InitDatabase()
        Try
            If Not DbExists() Then
                CreateDatabase()
                CreateTableOperations()
                CreateTableUsers()
                For rowIndex As Integer = 0 To Users.GetUpperBound(0)
                    AddUsers(Users(rowIndex, 0), Users(rowIndex, 1), Users(rowIndex, 2))
                Next
            End If
        Catch ex As Exception
            PersistenceSystem = "FILE"
        End Try
    End Sub
End Class
