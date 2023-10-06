Imports System.IO

Public Class FsOperationsService
    Private ReadOnly FilePath As String = "C:\Deposito\Programación\IZO\MATERIAS\1° AÑO\LÓGICA Y ESTRUCTURA DE DATOS\ACTIVIDADES\Clases\Clases\23_10_13-Parcial\records.txt"

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
            Dim txtLine As String

            While Not reader.EndOfStream
                txtLine = reader.ReadLine()
                operations.Add(MapOperationFromTxtLine(txtLine))
            End While
        End Using

        Return operations
    End Function

    Public Function MapOperationFromTxtLine(txtLine As String) As Operation
        Dim operationValues As String() = txtLine.Split(";")
        Dim operation As New Operation(operationValues(0), operationValues(1), operationValues(2), operationValues(3))
        Return operation
    End Function
End Class
