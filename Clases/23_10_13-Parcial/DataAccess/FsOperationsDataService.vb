Imports System.IO

Public Class FsOperationsDataService
    'Private ReadOnly FilePath As String = "C:\Deposito\Programación\IZO\MATERIAS\1° AÑO\LÓGICA Y ESTRUCTURA DE DATOS\ACTIVIDADES\Clases\Clases\23_10_13-Parcial\records.txt"
    Private workingDirectory As String = Environment.CurrentDirectory
    Private projectDirectory As String = Directory.GetParent(workingDirectory).Parent.Parent.FullName
    Private ReadOnly FilePath As String = Path.Combine(projectDirectory, "TxtData\operations.txt")
    Public Function AddOperation(usdValue As Decimal, usdQuantity As Decimal, arsQuantity As Decimal) As Boolean
        If Not File.Exists(FilePath) Then
            Throw New Exception($"No se encontró el archivo en ¨{FilePath}")
        End If

        Using writer As New StreamWriter(FilePath, True)
            Dim operationDate As DateTime = DateTime.Now
            Dim newLine As String = $"{operationDate};{usdValue};{usdQuantity};{arsQuantity}"
            writer.WriteLine(newLine)
        End Using
        Return True
    End Function

    Public Function GetOperations() As List(Of Operation)

        If Not File.Exists(FilePath) Then
            Throw New Exception($"No se encontró el archivo en ¨{FilePath}")
        End If

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

    Public Function MapOperationFromTxtLine(operationData As String) As Operation
        Dim operationProperties As String() = operationData.Split(";")
        Dim operation As New Operation(operationProperties(0), operationProperties(1), operationProperties(2), operationProperties(3))
        Return operation
    End Function
End Class
