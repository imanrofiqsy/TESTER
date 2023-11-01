Public Class frmLogin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If cb_username.Text = "Admin" And txt_password.Text = "admin" Then
            USER_LEVEL = 1
            Me.Close()
        ElseIf cb_username.Text = "Engineer" And txt_password.Text = "engineer" Then
            USER_LEVEL = 2
            Me.Close()
        ElseIf cb_username.Text = "Operator" And txt_password.Text = "operator" Then
            USER_LEVEL = 3
            Me.Close()
        Else
            MsgBox("Wrong Password")
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_username.Text = ""
        txt_password.Text = ""
    End Sub
End Class