Imports Database
Public Class frmUserManagement
    Private _path As String = Application.StartupPath
    Private testDatabase As DBManager = DBManager.getInstance()
    Public _userManager As UserManagement = New UserManagement()

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim tb As DataTable = _userManager.loadTable()
        DataGridViewTable.DataSource = Nothing
        DataGridViewTable.DataSource = tb
        DataGridViewTable.ClearSelection()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then

            End If
        Next
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _userManager.Initialize()
        Dim tb As DataTable = _userManager.loadTable()
        DataGridViewTable.DataSource = Nothing
        DataGridViewTable.DataSource = tb
        DataGridViewTable.ClearSelection()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

    End Sub
End Class