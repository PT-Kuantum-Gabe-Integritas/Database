Imports System.IO
Imports System.Data.SQLite
Imports System.Threading
Imports Database.DBManager
Imports Database

Public Class SQLite
    Inherits Database
    Private _fileName
    Private _dataType
    Sub New()
        MyBase.New()

    End Sub

    Sub New(FileName As String, DataType As DATATYPE)

        If FileName = String.Empty Then
            Return
        End If

        _fileName = FileName
        _dataType = DataType
        _fn = FileName
    End Sub

    Public Overrides Function ExecQuery(cmd As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim _dr As SQLiteDataReader
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _dr = _cmd.ExecuteReader()
            dt.Load(_dr)

        End If

        Return MyBase.ExecQuery(cmd)
    End Function

    Public Overrides Sub ExecNonQuery(cmd As String)
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _cmd.ExecuteNonQuery()

        End If
        MyBase.ExecNonQuery(cmd)
    End Sub
    Private Function connectionBuilder()
        Dim folderPath As String = Path.Combine(_path, GetFolderBase(_dataType))
        _connectionString = "Data Source =" & IO.Path.Combine(folderPath, _fileName + ".db") & ";Version=3;"
        Return folderPath
    End Function

    Public Overrides Sub Open()
        Dim folderPath As String = Path.Combine(_path, GetFolderBase(_dataType))
        Try
            _connectionString = "Data Source =" & IO.Path.Combine(folderPath, _fileName + ".db") & ";Version=3;"
            _con = New SQLiteConnection(_connectionString)
            _cmd = New SQLiteCommand()
            _con.ParseViaFramework = True
            _con.Open()
            _isConnected = True
            _conType = 0
        Catch ex As Exception
            _isConnected = False
        End Try
    End Sub

    Public Overrides Sub Close()
        Try
            If _isConnected Then
                _cmd.Dispose()
                _con.Close()

            End If
        Catch ex As Exception

        End Try
        MyBase.Close()
    End Sub
    Public Sub AddProduction(PO_NUMBER As String, REFERENCE As String, QTY_PO As String, QTY_GROUP As String, USER As String)

        Dim str_param As String = "('po_number','reference','qty_po','qty_group','user')"
        Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}','{4}')", PO_NUMBER, REFERENCE, QTY_PO, QTY_GROUP, USER)
        DBInsert("PRODUCT", str_param, str_val)

    End Sub

End Class
