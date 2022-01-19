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

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _userManager.Initialize()
        tb_confirm.Enabled = False
        tb_input.Enabled = False
        loadtb()
    End Sub

    Private Sub loadtb()
        Dim tb As DataTable = _userManager.loadTable()
        DataGridViewTable.DataSource = Nothing
        DataGridViewTable.DataSource = tb
        DataGridViewTable.ClearSelection()
        For Each row As DataRow In tb.Rows
            If cb_user.Items.Contains(row.Item(1)) Then

            Else
                cb_user.Items.Add(row.Item(1))
            End If
        Next
    End Sub

    Private Sub cb_user_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_user.SelectedValueChanged
        If cb_user.SelectedValue = 0 Or cb_user.Text = "" Then
            tb_confirm.Enabled = False
            tb_input.Enabled = False
        End If

        tb_confirm.Enabled = True
        tb_input.Enabled = True
    End Sub

    Private Sub DataGridViewTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTable.CellClick
        cb_user.Enabled = False
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then
                tb_id.Text = row.DataBoundItem(0)
            End If
        Next
    End Sub

    Private Sub tb_id_TextChanged(sender As Object, e As EventArgs) Handles tb_id.TextChanged
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then
                cb_user.SelectedItem = row.DataBoundItem(1).ToString
            End If
        Next
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If cb_user.Text Is "" Or cb_user.SelectedIndex = 0 And tb_id.Text = "" Then
            lb_info.Text = "Select User"
        ElseIf cb_user.Enabled = True Then
            If tb_input.Text = tb_confirm.Text Then
                _userManager.AddUser(cb_user.Text, tb_input.Text)
            Else
                lb_info.Text = "Password is not the same"
            End If
        Else
            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                If tb_input.Text = tb_confirm.Text Then

                    _userManager.UpdateUser(tb_id.Text, tb_input.Text)
                Else
                    lb_info.Text = "Password is not the same"
                End If
            Next
        End If

        loadtb()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        tb_id.Clear()
        tb_confirm.Clear()
        tb_input.Clear()
        DataGridViewTable.ClearSelection()
        cb_user.Enabled = True
        cb_user.SelectedIndex = -1
    End Sub
End Class