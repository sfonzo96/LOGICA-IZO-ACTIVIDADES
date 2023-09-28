Public Class FrmEdades
    Private Sub BtnVerifEdad_Click(sender As Object, e As EventArgs) Handles BtnVerifEdad.Click
        Dim edad As Integer = CInt(Me.TxtEdad.Text)
        If CInt(Me.TxtEdad.Text) < 18 Then
            Me.TxtResult.Text = "Menor"
        Else
            Me.TxtResult.Text = "Mayor"

            TxtService.AddRecord(edad)
        End If
    End Sub
End Class