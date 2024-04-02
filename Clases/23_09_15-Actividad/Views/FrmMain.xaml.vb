Public Class FrmMain
    Private Sub BtnGestionAlumnos_Click(sender As Object, e As RoutedEventArgs) Handles BtnGestionAlumnos.Click
        Dim formAlumnos As New FrmAlumnos

        formAlumnos.ShowDialog()
    End Sub
End Class
