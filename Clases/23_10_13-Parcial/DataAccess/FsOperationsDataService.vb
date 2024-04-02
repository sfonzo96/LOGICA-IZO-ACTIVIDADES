Imports System.IO
Public Class FsOperationsDataService
    Implements IOperationsService
    Private ReadOnly FilePath As String = "..\..\..\TxtData\operations.txt"
    Private Shared FsOperationsServiceInstance As FsOperationsDataService
    Public Function AddOperation(usdValue As Decimal, usdQuantity As Decimal, arsQuantity As Decimal) As Boolean Implements IOperationsService.AddOperation
        CreateFileIfNotExists()

        Using writer As New StreamWriter(FilePath, True)
            Dim operationDate As DateTime = DateTime.Now
            Dim newLine As String = $"{operationDate};{usdValue};{usdQuantity};{arsQuantity}"
            writer.WriteLine(newLine)
        End Using
        Return True
    End Function

    Public Function GetOperations() As List(Of Operation) Implements IOperationsService.GetOperations
        CreateFileIfNotExists()

        Dim operations As New List(Of Operation)
        Using reader As New StreamReader(FilePath)
            Dim operationData As String

            While Not reader.EndOfStream
                operationData = reader.ReadLine()
                operations.Add(MapOperationFromTxtLine(operationData))
            End While
        End Using

        Return operations
    End Function

    Public Shared Function MapOperationFromTxtLine(operationData As String) As Operation
        Dim operationProperties As String() = operationData.Split(";")
        Dim operation As New Operation(operationProperties(0), operationProperties(1), operationProperties(2), operationProperties(3))
        Return operation
    End Function

    Public Sub CreateFileIfNotExists()
        If Not File.Exists(FilePath) Then
            File.CreateText(FilePath).Dispose()
        End If
    End Sub

    Public Shared Function GetInstance() As FsOperationsDataService
        If FsOperationsServiceInstance Is Nothing Then
            FsOperationsServiceInstance = New FsOperationsDataService()
        End If

        Return FsOperationsServiceInstance
    End Function
End Class
