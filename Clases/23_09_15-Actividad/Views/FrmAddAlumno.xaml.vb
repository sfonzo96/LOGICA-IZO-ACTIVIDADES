Public Class FrmAddAlumno

    Private frmAlumnos As FrmAlumnos

    Public Sub New(frmAlumnos As FrmAlumnos)
        InitializeComponent()
        Me.frmAlumnos = frmAlumnos
    End Sub

    Private Sub BtnAddAlumno_Click(sender As Object, e As RoutedEventArgs) Handles BtnAddAlumno.Click
        Dim opcionAño As String

        Try
            If RdBtn1.IsChecked Then
                opcionAño = RdBtn1.Content.ToString()
            ElseIf RdBtn2.IsChecked Then
                opcionAño = RdBtn2.Content.ToString()
            ElseIf RdBtn3.IsChecked Then
                opcionAño = RdBtn3.Content.ToString()
            Else
                Throw New Exception("Must select an option")
            End If

            Dim dataAlumno As String = $"{TxtLegajo.Text},{TxtNombre.Text},{TxtApellido.Text},{opcionAño}"

            TxtStudentService.AddAlumno(dataAlumno)
            frmAlumnos.UpdateDataGrid()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class