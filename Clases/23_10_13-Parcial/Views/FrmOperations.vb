Imports System.Data.SqlClient

Public Class FrmOperations
    Private Sub FrmRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim dbOperationService As New DbOperationsDataService()
            'DGridOperations.DataSource = dbOperationService.GetOperations()
            Dim fsOperationService As New FsOperationsDataService()
            DGridOperations.DataSource = fsOperationService.GetOperations()
        Catch sqlEx As SqlException
            MessageBox.Show("SQL Error", sqlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class