Imports System.IO

Public Class TxtStudentService
    Private Const filePath As String = "C:\Deposito\Programación\IZO\MATERIAS\1° AÑO\LÓGICA Y ESTRUCTURA DE DATOS\ACTIVIDADES\Clases\Clases\23_09_15-Actividad\Students.txt"
    Public Shared Function GetAlumnos()
        Dim alumnos As New List(Of Alumno)()
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine
                    alumnos.Add(MapAlumno(line))
                End While
            End Using
        End If

        Return alumnos
    End Function
    Public Shared Sub AddAlumno(nuevoAlumno As String)
        Dim alumno As Alumno = MapAlumno(nuevoAlumno)
        Using writer As New StreamWriter(filePath, True)
            Dim nuevaLinea As String = $"{alumno.Legajo},{alumno.Nombre},{alumno.Apellido},{alumno.Año}"
            writer.WriteLine(nuevaLinea)
        End Using
    End Sub

    Public Shared Sub DeleteAlumno(legajo As String)
        If File.Exists(filePath) Then
            Dim lines As New List(Of String)(File.ReadAllLines(filePath))

            lines.RemoveAll(Function(line) line(0) = (legajo))

            File.WriteAllLines(filePath, lines)
        End If
    End Sub

    'Public Shared Sub UpdateAlumno(field, legajo, newValue)
    '    If File.Exists(filePath) Then
    '        Dim lines As New List(Of String)(File.ReadAllLines(filePath))


    '        File.WriteAllLines(filePath, lines)
    '    End If
    'End Sub
    Public Shared Function MapAlumno(dataAlumno As String)
        Dim alumno As New Alumno
        Dim values As String() = dataAlumno.Split(",")

        alumno.Legajo = values(CamposAlumno.Legajo)
        alumno.Nombre = values(CamposAlumno.Nombre)
        alumno.Apellido = values(CamposAlumno.Apellido)
        alumno.Año = values(CamposAlumno.Año)

        Return alumno
    End Function
End Class

Public Enum CamposAlumno
    Legajo = 0
    Nombre = 1
    Apellido = 2
    Año = 3
End Enum
