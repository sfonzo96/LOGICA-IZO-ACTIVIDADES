Class MainWindow
    Private Sub btnSuma_Click(sender As Object, e As RoutedEventArgs) Handles btnSuma.Click

        If (IsNumeric(txtValor1.Text) AndAlso IsNumeric(txtValor2.Text)) Then
            Sumar(txtValor1.Text, txtValor2.Text)
        Else
            txtResultado.Text = "Valor inválido"
        End If

    End Sub

    Private Sub btnResta_Click(sender As Object, e As RoutedEventArgs) Handles btnResta.Click

        If (IsNumeric(txtValor1.Text) AndAlso IsNumeric(txtValor2.Text)) Then
            Restar(txtValor1.Text, txtValor2.Text)
        Else
            txtResultado.Text = "Valor inválido"
        End If
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As RoutedEventArgs) Handles btnMultiplicacion.Click

        If (IsNumeric(txtValor1.Text) AndAlso IsNumeric(txtValor2.Text)) Then
            Multiplicar(txtValor1.Text, txtValor2.Text)
        Else
            txtResultado.Text = "Valor inválido"
        End If
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As RoutedEventArgs) Handles btnDivision.Click

        If (IsNumeric(txtValor1.Text) AndAlso IsNumeric(txtValor2.Text)) Then
            Dividir(txtValor1.Text, txtValor2.Text)
        Else
            txtResultado.Text = "Valor inválido"
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As RoutedEventArgs) Handles btnLimpiar.Click
        txtResultado.Clear()
        txtValor1.Clear()
        txtValor2.Clear()
    End Sub

    Private Sub Sumar(valor1 As Decimal, valor2 As Decimal)
        Dim dbResultado As Decimal = valor1 + valor2
        txtResultado.Text = dbResultado
    End Sub

    Private Sub Restar(valor1 As Decimal, valor2 As Decimal)
        Dim dbResultado As Decimal = valor1 - valor2
        txtResultado.Text = dbResultado
    End Sub

    Private Sub Dividir(valor1 As Decimal, valor2 As Decimal)
        Dim dbResultado As Decimal = valor1 / valor2
        txtResultado.Text = dbResultado
    End Sub

    Private Sub Multiplicar(valor1 As Decimal, valor2 As Decimal)
        Dim dbResultado As Decimal = valor1 * valor2
        txtResultado.Text = dbResultado
    End Sub
End Class
