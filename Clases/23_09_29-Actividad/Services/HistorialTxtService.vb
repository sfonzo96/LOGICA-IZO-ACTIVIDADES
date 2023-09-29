Imports System.IO

Public Class HistorialTxtService
    Private Const filePath As String = "C:\Users\santi\source\repos\2023_09_29-Actividad\HISTORIAL.txt"

    Public Shared Sub RegistrarPago(cantidadUSD As Decimal, cantidadPesos As Decimal)
        Using writer As New StreamWriter(filePath, True)
            Dim nuevaLinea As String = $"Cantidad USD:{cantidadUSD}, Cantidad ARS: {cantidadPesos}"
            writer.WriteLine(nuevaLinea)
        End Using
    End Sub
End Class
