Imports System.IO

Public Class HistorialTxtService
    Private Shared ReadOnly filePath As String = "C:\Deposito\Programación\IZO\MATERIAS\1° AÑO\LÓGICA Y ESTRUCTURA DE DATOS\ACTIVIDADES\Clases\Clases\23_09_29-Actividad\HISTORIAL.txt"

    Public Shared Sub RegistrarPago(cantidadUSD As Decimal, cantidadPesos As Decimal)
        If Not File.Exists(filePath) Then
            MessageBox.Show($"No se encuentra archivo HISTORIAL.txt en {filePath}")
            Return
        End If

        Using writer As New StreamWriter(filePath, True)
            Dim nuevaLinea As String = $"Cantidad USD:{cantidadUSD}, Cantidad ARS: {cantidadPesos}"
            writer.WriteLine(nuevaLinea)
        End Using
    End Sub
End Class
