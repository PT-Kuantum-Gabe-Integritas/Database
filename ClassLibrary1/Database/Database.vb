Imports Database
Imports System.Threading
Imports System.IO
Imports System.Data.SQLite
Imports System.Data.OleDb
Imports System.Windows.Forms


Public Class Database
    Implements IDatabase

    Public _isConnected
    Public _path = Application.StartupPath
    Public _connectionString As String
    Public _con
    Public _cmd
    Public Data
    Public _conType As Boolean
    Public _fn

    Public Property Filename As String Implements IDatabase.Filename
        Get
            Return _fn
        End Get
        Set(value As String)
            value = _fn
        End Set
    End Property
    Public Property UID As Integer Implements IDatabase.UID


    Enum DATATYPE
        CONFIG
        USER
    End Enum

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

    Public Function GetFolderBase(type As DATATYPE) As String
        Select Case type
            Case DATATYPE.CONFIG
                Return "Config"
            Case DATATYPE.USER
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

    Public Function DBSelect(param As String, table As String, where As String, sortbyASC As Boolean, limit As Integer) As DataTable Implements IDatabase.DBSelect
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


    Public Overridable Sub Open() Implements IDatabase.Open

        'Return _isConnected
    End Sub

    Public Overridable Sub Close() Implements IDatabase.Close
        'Try
        '    If _isConnected Then
        '        _cmd.Dispose()
        '        _con.Close()

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Public Overridable Sub ExecNonQuery(cmd As String)

    End Sub
    Public Overridable Function ExecQuery(cmd As String) As DataTable
        Dim dt As DataTable = New DataTable()

        Return dt
    End Function
End Class
