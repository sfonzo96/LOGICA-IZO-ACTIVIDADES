Imports System.IO

Public Class TxtService

    Const filePath As String = "C:\Deposito\Programación\IZO\MATERIAS\1° AÑO\LÓGICA Y ESTRUCTURA DE DATOS\ACTIVIDADES\Clases\Clases\23_09_22-Actividad\Edades.txt"

    Public Shared Sub AddRecord(edad As String)
        Using writer As New StreamWriter(filePath, True)
            '            Dim nuevaLinea As String = edad
            writer.WriteLine(edad)
        End Using
    End Sub
End Class
