Public Class frmLoadingBar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadingBar.Value = LOAD_VAL
        lbl_loading.Text = LOAD_MSG
    End Sub

    Private Sub frmLoadingBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class