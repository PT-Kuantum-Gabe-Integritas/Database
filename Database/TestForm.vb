Imports Database
Public Class TestForm
    Private _path As String = Application.StartupPath
    Private testDatabase As DBManager = New DBManager()
    Private SQL As SQLite = New SQLite()
    Private ACC As Access = New Access()

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If cb_type.Text = "-SQLite" Then
            SQL = testDatabase.GetDataBase(cb_filename.Text, tb_UID.Text, cb_type.Text, cb_foldername.Text)
            'MsgBox(SQL._isConnected)
            loadTable(cb_type.Text)
        ElseIf cb_type.Text = "-Access" Then
            ACC = testDatabase.GetDataBase(cb_filename.Text, tb_UID.Text, cb_type.Text, cb_foldername.Text)
            'MsgBox(ACC._isConnected)
            loadTable(cb_type.Text)
        End If
    End Sub
    Private Sub loadTable(type As String)
        Dim TableDB As New DataTable
        If type = "-SQLite" Then

            Try

                SQL.DBLoad(tb_tablename.Text, TableDB, SQL._con)
                DataGridViewTable.DataSource = Nothing
                DataGridViewTable.DataSource = TableDB
                DataGridViewTable.ClearSelection()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf type = "-Access" Then

            Try

                ACC.DBLoad(tb_tablename.Text, TableDB, ACC._con)
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

        tb_input.Clear()
        tb_tablename.Clear()
        tb_UID.Clear()
        tb_val.Clear()
        cb_columname.SelectedIndex = -1
        cb_filename.SelectedIndex = -1
        cb_foldername.SelectedIndex = -1
        cb_type.SelectedIndex = -1
        cb_columname.Items.Clear()
        cb_filename.Items.Clear()
        cb_foldername.Items.Clear()
        cb_type.Items.Clear()

        Dim folders() As String = IO.Directory.GetDirectories(_path)
        For Each folder As String In folders
            folder = folder.Replace(_path & "\", "")
            cb_foldername.Items.Add(folder)
        Next
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If cb_type.Text = "-SQLite" Then
            SQL.DBDelete(tb_tablename.Text, cb_columname.Text & "=" & "'" & tb_val.Text & "'")
        ElseIf cb_type.Text = "-Access" Then
            ACC.DBDelete(tb_tablename.Text, cb_columname.Text & "=" & "'" & tb_val.Text & "'")
        End If
        loadTable(cb_type.Text)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        loadTable(cb_type.Text)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If cb_type.Text = "-SQLite" Then
            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                If row.Selected = True Then
                    SQL.DBUpdate(tb_tablename.Text, cb_columname.Text & "='" & tb_val.Text & "'", cb_columname.Items(0) & "='" & row.DataBoundItem(0).ToString() & "'")
                End If
            Next
        ElseIf cb_type.Text = "-Access" Then
            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                If row.Selected = True Then
                    ACC.DBUpdate(tb_tablename.Text, cb_columname.Text & "='" & tb_val.Text & "'", cb_columname.Items(0) & "='" & row.DataBoundItem(0).ToString() & "'")
                End If
            Next
        End If
        loadTable(cb_type.Text)
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim folders() As String = IO.Directory.GetDirectories(_path)
        For Each folder As String In folders
            folder = folder.Replace(_path & "\", "")
            cb_foldername.Items.Add(folder)
        Next

    End Sub

    Private Sub cb_foldername_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_foldername.SelectedValueChanged
        cb_filename.Items.Clear()
        Dim files() As String = IO.Directory.GetFiles(_path & "\" & cb_foldername.Text)
        For Each file As String In files
            file = file.Replace(_path & "\" & cb_foldername.Text & "\", "")
            cb_filename.Items.Add(file)
        Next
    End Sub

    Private Sub lb_val_Click(sender As Object, e As EventArgs) Handles lb_val.Click

    End Sub

    Private Sub tb_UID_TextChanged(sender As Object, e As EventArgs) Handles tb_UID.TextChanged

    End Sub
End Class