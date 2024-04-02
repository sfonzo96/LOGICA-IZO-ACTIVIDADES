Imports System.Data
Imports System.IO

Public Class FrmAlumnos
    Private Sub FrmAlumnos_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded
        UpdateDataGrid()
    End Sub
    Private Sub BtnNewAlumno_Click(sender As Object, e As RoutedEventArgs) Handles BtnNewAlumno.Click
        Dim frmAddAlumno As New FrmAddAlumno(Me)

        frmAddAlumno.ShowDialog()
    End Sub
    Private Sub BtnDeleteAlumno_Click(sender As Object, e As RoutedEventArgs) Handles btnDeleteAlumno.Click
        Dim alumno As Alumno = DataGridAlumnos.SelectedItem
        Dim legajo As String = alumno.Legajo

        TxtStudentService.DeleteAlumno(legajo)

        UpdateDataGrid()
    End Sub
    Public Sub UpdateDataGrid()
        DataGridAlumnos.ItemsSource = TxtStudentService.GetAlumnos()
    End Sub
End Class
