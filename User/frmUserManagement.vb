Imports Database
Public Class frmUserManagement
    Private _path As String = Application.StartupPath
    Private testDatabase As DBManager = New DBManager()
    Private SQL As SQLite = New SQLite()
    Private ACC As Access = New Access()

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
    End Sub
    Private Sub loadTable(type As String)
        Dim TableDB As New DataTable
        If type = "-SQLite" Then

            Try

                SQL.DBLoad("tb_user", TableDB, SQL._con)
                DataGridViewTable.DataSource = Nothing
                DataGridViewTable.DataSource = TableDB
                DataGridViewTable.ClearSelection()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf type = "-Access" Then

            Try

                'ACC.DBLoad("tb_user", TableDB, ACC._con)
                DataGridViewTable.DataSource = Nothing
                DataGridViewTable.DataSource = TableDB
                DataGridViewTable.ClearSelection()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        For Each column As DataColumn In TableDB.Columns
            If cb_columname.Items.Contains(column.ColumnName) Then

            Else
                cb_columname.Items.Add(column.ColumnName)
            End If
        Next
    End Sub

    Private Sub bnt_clearall_Click(sender As Object, e As EventArgs) Handles bnt_clearall.Click
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        loadTable("-SQLite")
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then
                SQL.DBUpdate("tb_user", cb_columname.Text & "='" & tb_val.Text & "'", cb_columname.Items(0) & "='" & row.DataBoundItem(0).ToString() & "'")
            End If
        Next

    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub lb_val_Click(sender As Object, e As EventArgs) Handles lb_val.Click

    End Sub

End Class