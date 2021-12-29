Imports System.IO
Imports System.Data.SQLite

Public Class SQLite
    Inherits Database

    'Variable
    Private _connectionString As String
    Private _con As SQLiteConnection
    Private _cmd As SQLiteCommand

    Public Enum DBTYPE
        USER
        CONFIG
    End Enum

    Public Function GetFolderBase(type As DBTYPE) As String
        Select Case type
            Case DBTYPE.CONFIG
                Return "Config"
            Case DBTYPE.USER
                Return "User"
            Case Else
                Return "None"
        End Select
    End Function

    Public Function Open(FileName As String, Type As Data.DbType) As Boolean
        _isConnected = False
        Try
            Dim folderPath As String = Path.Combine(_path, GetFolderBase(Type))
            FolderExist(folderPath)
            _connectionString = "Data Source =" & IO.Path.Combine(folderPath, FileName + ".db") & ";Version=3;"

            _con = New SQLiteConnection(_connectionString)
            _cmd = New SQLiteCommand()
            _con.ParseViaFramework = True
            _con.Open()
            _isConnected = True
        Catch ex As Exception
            _isConnected = False
        End Try

        Return _isConnected
    End Function

    Public Sub Close()
        Try
            If _isConnected Then
                _cmd.Dispose()
                _con.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ExecNonQuery(cmd As String)
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _cmd.ExecuteNonQuery()

        End If
    End Sub



    Public Sub SQInsert(table As String, param As String, val As String)
        Dim query = DBInsert(param, table, val)
        ExecNonQuery(query)
    End Sub

    Public Sub SQUpdate(table As String, param As String, val As String)
        Dim query = DBUpdate(param, table, val)
        ExecNonQuery(query)

    End Sub

End Class
