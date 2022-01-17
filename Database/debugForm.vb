Imports Database
Public Class debugForm
    Private _path As String = Application.StartupPath
    Private testDatabase As DBManager = DBManager.getInstance()
    Private SQL As SQLite = New SQLite()
    Private ACC As Access = New Access()

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If cb_type.Text = "-SQLite" Then
            SQL = testDatabase.GetDataBase(cb_filename.Text, tb_UID.Text, cb_type.Text, cb_foldername.Text)
            loadTable(cb_type.Text)
            loadCon(cb_type.Text)
            cb_list.Items.Add(SQL.UID)
        ElseIf cb_type.Text = "-Access" Then
            ACC = testDatabase.GetDataBase(cb_filename.Text, tb_UID.Text, cb_type.Text, cb_foldername.Text)
            loadTable(cb_type.Text)
            loadCon(cb_type.Text)
            cb_list.Items.Add(ACC.UID)
        Else
            tb_info.Text = "type = -SQLite/-Access"
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
        Else
            tb_info.Text = "type = -SQLite/-Access"
        End If

        For Each column As DataColumn In TableDB.Columns
            If cb_columname.Items.Contains(column.ColumnName) Then

            Else
                cb_columname.Items.Add(column.ColumnName)
            End If
        Next
    End Sub
    Private Sub loadCon(type As String)
        If cb_type.Text = "-SQLite" Then
            tb_cmd.Text = SQL._cmd.ToString
            tb_con.Text = SQL._con.ToString
            tb_connectionstring.Text = SQL._connectionString
            tb_data.Text = SQL.Data
            tb_fn.Text = SQL._fn.ToString
            tb_isConnected.Text = SQL._isConnected
            tb_path.Text = SQL._path
        ElseIf cb_type.Text = "-Access" Then
        Else
            tb_info.Text = "type = -SQLite/-Access"
        End If
        'tb_info.Multiline = True
        'tb_info.Text = "Line 1"
        'tb_info.Text = tb_info.Text & ControlChars.NewLine & "Line 2"
    End Sub

    Private Sub bnt_clearall_Click(sender As Object, e As EventArgs) Handles bnt_clearall.Click

        'tb_input.Clear()
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
        Else
            tb_info.Text = "type = -SQLite/-Access"
        End If
        loadTable(cb_type.Text)
        loadCon(cb_type.Text)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        loadTable(cb_type.Text)
        'Dim dt As DataTable = New DataTable()
        'dt = SQL.DBSelect("pass", "tb_user", "'Engineer'", True, 3)
        'tb_info.Text = dt.ToString
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        testDatabase.CloseDataBase(cb_list.Text)
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
        Else
            tb_info.Text = "type = -SQLite/-Access"
        End If
        loadTable(cb_type.Text)
        loadCon(cb_type.Text)
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

    Private Sub cb_list_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_list.SelectedValueChanged
        If cb_type.Text = "-SQLite" Then
            SQL = testDatabase.GetDataBase(cb_filename.Text, cb_list.Text, cb_type.Text, cb_foldername.Text)
            'MsgBox(SQL._isConnected)
            loadTable(cb_type.Text)
            loadCon(cb_type.Text)
            cb_list.Items.Add(SQL.UID)
        ElseIf cb_type.Text = "-Access" Then
            ACC = testDatabase.GetDataBase(cb_filename.Text, cb_list.Text, cb_type.Text, cb_foldername.Text)
            'MsgBox(ACC._isConnected)
            loadTable(cb_type.Text)
            cb_list.Items.Add(ACC.UID)
        Else
            tb_info.Text = "type = -SQLite/-Access"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_info.TextChanged

    End Sub
End Class