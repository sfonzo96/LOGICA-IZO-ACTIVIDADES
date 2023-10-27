Public Class DataAccessFactory
    Shared Function CreateUserDataService() As IUsersService
        If DatabaseService.PersistenceSystem = "SQL" Then
            Return DbUsersDataService.GetInstance()
        ElseIf DatabaseService.PersistenceSystem = "FILE" Then
            Return FsUsersDataService.GetInstance()
        Else
            Throw New Exception("Error en el sistema de persistencia, la aplicación no guardará la información.")
        End If
    End Function

    Shared Function CreateOperationsDataService() As IOperationsService
        If DatabaseService.PersistenceSystem = "SQL" Then
            Return DbOperationsDataService.GetInstance()
        ElseIf DatabaseService.PersistenceSystem = "FILE" Then
            Return FsOperationsDataService.GetInstance()
        Else
            Throw New Exception("Error en el sistema de persistencia, la aplicación no guardará la información.")
        End If
    End Function
End Class
