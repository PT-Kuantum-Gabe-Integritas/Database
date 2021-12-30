Imports Database
Imports System.IO
Imports System.Data.SQLite
Imports System.Data.OleDb


Public Class Database
    Implements IDatabase

    Public _isConnected
    Public _path = Application.StartupPath
    Private _connectionString As String
    Private _con
    Private _cmd

    Private _conType As Boolean

    Public Property BasePath As String Implements IDatabase.BasePath
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    'Public Sub New(Path As String)
    '    _path = Path
    'End Sub

    Private Function GetFolderBase(type As IDatabase.DATATYPE) As String
        Select Case type
            Case IDatabase.DATATYPE.CONFIG
                Return "Config"
            Case IDatabase.DATATYPE.USER
                Return "User"
            Case Else
                Return "None"
        End Select
    End Function


    Public ReadOnly Property isConnected As String Implements IDatabase.isConnected
        Get
            Return _isConnected

        End Get
    End Property

    Public Sub DBInsert(table As String, param As String, values As String) Implements IDatabase.DBInsert
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("INSERT INTO {0} {1} VALUES {2}", table, param, values)
        End If
        ExecNonQuery(query)
        'Return query
    End Sub

    Public Sub DBUpdate(table As String, param As String, where As String) Implements IDatabase.DBUpdate
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("UPDATE {0} SET {1} WHERE {2}", table, param, where)
        End If
        ExecNonQuery(query)
    End Sub

    Public Sub DBDelete(table As String, where As String) Implements IDatabase.DBDelete
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("DELETE FROM {0} WHER {1}", table, where)
        End If
        ExecNonQuery(query)
    End Sub

    Private Sub FolderExist(path As String) Implements IDatabase.FolderExist
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function DBSelect(param As String, table As String, where As String) As DataTable Implements IDatabase.DBSelect
        Dim query As String = ""
        Dim dt As DataTable
        If _isConnected Then
            If where = String.Empty Then
                query = String.Format("SELECT {0} FROM {1}",
                                            param, table)
            Else
                query = String.Format("SELECT {0} FROM {1} WHERE {2}",
                                            param, table, where)

            End If
        End If
        dt = ExecQuery(query)
        Return dt
    End Function


    Public Function GetDate(_date As Date) As String Implements IDatabase.GetDate
        Return String.Format("{0:0000}-{1:00}-{2:00}", _date.Year, _date.Month, _date.Day)
    End Function


    Public Function Open(FileName As String, Type As IDatabase.DATATYPE, connection_type As IDatabase.CONTYPE) As Boolean Implements IDatabase.Open
        _isConnected = False
        Dim folderPath As String = Path.Combine(_path, GetFolderBase(Type))
        FolderExist(folderPath)

        If connection_type = IDatabase.CONTYPE.SQL Then
            Try
                _connectionString = "Data Source =" & IO.Path.Combine(folderPath, FileName + ".db") & ";Version=3;"
                _con = New SQLiteConnection(_connectionString)
                _cmd = New SQLiteCommand()
                _con.ParseViaFramework = True
                _con.Open()
                _isConnected = True
                _conType = 0
            Catch ex As Exception
                _isConnected = False
            End Try

        Else
            Try
                _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Path.Combine(folderPath, FileName + ".accdb") & ";"
                _con = New OleDbConnection(_connectionString)
                _cmd = New OleDbCommand()
                _con.ParseViaFramework = True
                _con.Open()
                _isConnected = True
                _conType = 1
            Catch ex As Exception
                _isConnected = False
            End Try
        End If

        Return _isConnected
    End Function

    Public Sub Close() Implements IDatabase.Close
        Try
            If _isConnected Then
                _cmd.Dispose()
                _con.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ExecNonQuery(cmd As String) Implements IDatabase.ExecNonQuery
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _cmd.ExecuteNonQuery()

        End If
    End Sub
    Public Function ExecQuery(cmd As String) As DataTable Implements IDatabase.ExecQuery
        Dim dt As DataTable = New DataTable()

        If _conType = 0 Then
            Dim _dr As SQLiteDataReader
            If _isConnected Then
                _cmd = _con.CreateCommand()
                _cmd.CommandText = cmd
                _dr = _cmd.ExecuteReader()
                dt.Load(_dr)

            End If
        Else
            Dim _dr As OleDbDataReader
            If _isConnected Then
                _cmd = _con.CreateCommand()
                _cmd.CommandText = cmd
                _dr = _cmd.ExecuteReader()
                dt.Load(_dr)
            End If
        End If

        Return dt
    End Function
End Class
