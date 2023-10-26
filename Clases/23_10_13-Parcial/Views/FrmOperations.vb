Imports System.Data.SqlClient

Public Class FrmOperations
    Private Sub FrmRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim operationService
            If DatabaseService.PersistenceSystem = "SQL" Then
                operationService = New DbOperationsDataService()
            Else
                operationService = New FsOperationsDataService()
            End If

            DGridOperations.DataSource = operationService.GetOperations()

        Catch sqlEx As SqlException
            MessageBox.Show("SQL Error", sqlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGridOperations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGridOperations.CellContentClick

    End Sub
End Class