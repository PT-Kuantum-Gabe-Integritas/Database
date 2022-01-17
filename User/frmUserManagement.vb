Imports Database
Public Class frmUserManagement
    Private _path As String = Application.StartupPath
    Public _userManager As UserManagement = New UserManagement()

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        lb_info.Text = "Select cell you want to Delete"
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then
                _userManager.DeleteUser(row.DataBoundItem(0))
            End If
        Next
        loadtb()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        loadtb()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If cb_user.Text Is "" Then
            lb_info.Text = "Select User"
        Else
            If tb_input.Text = tb_confirm.Text Then
                _userManager.UpdateUser(cb_user.Text, tb_input.Text)
            Else
                lb_info.Text = "Password is not the same"
            End If
        End If
        _userManager.GetPermit(cb_user.Text)
        loadtb()
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _userManager.Initialize()
        tb_confirm.Enabled = False
        tb_input.Enabled = False
        loadtb()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If cb_user.Text Is "" Or cb_user.SelectedIndex = 0 Then
            lb_info.Text = "Select User"
        Else
            If tb_input.Text = tb_confirm.Text Then
                _userManager.AddUser(cb_user.Text, tb_input.Text)
                loadtb()
            Else
                lb_info.Text = "Password is not the same"
            End If
        End If

    End Sub

    Private Sub loadtb()
        Dim tb As DataTable = _userManager.loadTable()
        DataGridViewTable.DataSource = Nothing
        DataGridViewTable.DataSource = tb
        DataGridViewTable.ClearSelection()
    End Sub

    Private Sub cb_user_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_user.SelectedValueChanged
        If cb_user.SelectedValue = 0 Or cb_user.Text = "" Then
            tb_confirm.Enabled = False
            tb_input.Enabled = False
        End If

        tb_confirm.Enabled = True
        tb_input.Enabled = True
    End Sub
End Class