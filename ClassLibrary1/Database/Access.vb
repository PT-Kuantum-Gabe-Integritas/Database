Imports System.IO
Imports System.Data.OleDb
Public Class Access
    Inherits Databasemain
    Private _fileName
    Private _dataType
    Sub New()
        MyBase.New()

    End Sub
    Sub New(FileName As String, DataType As String)

        If FileName = String.Empty Then
            Return
        End If

        _fileName = FileName
        _dataType = DataType
        _fn = FileName
    End Sub
    Public Overrides Sub Open()
        Dim folderPath As String = Path.Combine(_path, GetFolderBase(_dataType))
        Try
            _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & IO.Path.Combine(folderPath, _fileName) & ";"
            _con = New OleDbConnection(_connectionString)
            _con.Open()
            _cmd = New OleDbCommand()
            _isConnected = True
        Catch ex As Exception
            _isConnected = False

        End Try
    End Sub

    Public Overrides Sub Close()
        Try
            If _isConnected Then
                _cmd.Dispose()
                _con.Close()
                _isConnected = False

            End If
        Catch ex As Exception

        End Try
        MyBase.Close()
    End Sub

    Public Overrides Sub ExecNonQuery(cmd As String)
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _cmd.ExecuteNonQuery()

        End If
    End Sub

    Public Overrides Function ExecQuery(cmd As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim _dr As OleDbDataReader
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _dr = _cmd.ExecuteReader()
            dt.Load(_dr)

        End If

        Return MyBase.ExecQuery(cmd)
    End Function
End Class
