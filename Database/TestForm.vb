Imports Database
Public Class TestForm
    Private testDatabase As IDBManager = New DBManager()
    Private SQL As SQLite = New SQLite()
    Private ACC As Access = New Access()
    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If cb_type.Text = "-SQLite" Then
            SQL = testDatabase.GetDataBase(tb_filename.Text, tb_UID.Text, cb_type.Text, cb_foldername.Text)
            MsgBox(SQL._isConnected)
            Dim TableDB As New DataTable
            Try

                SQL.DBLoad(tb_tablename.Text, TableDB, SQL._con)
                DataGridViewTable.DataSource = Nothing
                DataGridViewTable.DataSource = TableDB
                DataGridViewTable.ClearSelection()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf cb_type.Text = "-Access" Then
            ACC = testDatabase.GetDataBase(tb_filename.Text, tb_UID.Text, cb_type.Text, cb_foldername.Text)
            MsgBox(ACC._isConnected)
            'Dim TableDB As New DataTable
            'Try

            '    'ACC.DBLoad(tb_tablename.Text, TableDB, ACC._con)
            '    DataGridViewTable.DataSource = Nothing
            '    DataGridViewTable.DataSource = TableDB
            '    DataGridViewTable.ClearSelection()

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End If
    End Sub
End Class