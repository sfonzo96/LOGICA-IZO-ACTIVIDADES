﻿Imports System.Data.SqlClient

Public Class FrmOperations
    Private Sub FrmRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim operationService As IOperationsService = DataAccessFactory.CreateOperationsDataService()

            DGridOperations.DataSource = operationService.GetOperations()
        Catch sqlEx As SqlException
            MessageBox.Show("SQL Error", sqlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class