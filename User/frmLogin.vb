Public Class frmLogin
    Private _newUser As UserData = New UserData()
    Public _userManager As UserManagement = New UserManagement()
    Public Sub Initialize()
        cb_user.Items.Clear()
        cb_user.Items.AddRange(_userManager.GetUserList().ToArray())
        cb_user.SelectedIndex = 0
        SetDisplay(False)
    End Sub
    Public Sub SetDisplay(requiredPassword As Boolean)
        If requiredPassword Then
            lb_user.Text = cb_user.Text
            lb_info.Text = "Please fill password to continue!"
            tb_input.PasswordChar = "*"
            tb_input.Text = ""
            tb_input.Focus()
        Else
            lb_user.Text = cb_user.Text
            lb_info.Text = "Please fill name or id to continue!"
            tb_input.PasswordChar = ""
            tb_input.Text = ""
            tb_input.Focus()
        End If
    End Sub
    Private Sub DoLogin()
        With _newUser
            .Type = cb_user.SelectedItem
            If _userManager.GetPass(.Type) Then
                .Pass = tb_input.Text
            Else
                .Name = tb_input.Text
            End If

        End With
        If _userManager.ValidateUser(_newUser) Then
            'Main_ChangeUser()
            lb_info.Text = "LOGGED"
        Else
            lb_info.Text = "Wrong Password!"
            lb_info.ForeColor = Color.Red
            tb_input.Text = ""
            tb_input.Focus()
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        DoLogin()
    End Sub

    Private Sub cb_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_user.SelectedIndexChanged
        If _userManager.GetPass(cb_user.SelectedItem) Then
            SetDisplay(True)
        Else
            SetDisplay(False)
        End If
    End Sub

    Private Sub tb_input_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_input.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            DoLogin()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        _userManager.Initialize()
    End Sub
End Class