Public Class FrmRecord
    Private Sub FrmRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Factory!
        DGridRecord.DataSource = DbExchangeService.GetOperations()
        'DGridRecord.DataSource = FsExchangeService.GetOperations()
    End Sub
End Class