Imports System.IO
Imports System.Data.OleDb
Public Class Access
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

    End Sub

    'Public Sub InsertProduct(ART_NUMBER As String, REFERENCE As String, QTY_IND As String, QTY_GROUP As String, BITMAP As String, LOGOFFER As String, INFORMATIONPIC As String)

    '    Dim str_param As String = "('Art_Number','Reference','Qty_ind','Qty_Group','Bitmap','logoffer','InformationPic')"
    '    Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}',{4},{5},{6})", ART_NUMBER, REFERENCE, QTY_IND, QTY_GROUP, BITMAP, LOGOFFER, INFORMATIONPIC)
    '    DBInsert("ProducData", str_param, str_val)
    'End Sub

    'Public Sub UpdateProduct(ART_NUMBER As String, REFERENCE As String, QTY_IND As String, QTY_GROUP As String, BITMAP As String, LOGOFFER As String, INFORMATIONPIC As String)
    '    Dim str_param As String = "('Art_Number','Reference','Qty_ind','Qty_Group','Bitmap','logoffer','InformationPic')"
    '    Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}',{4},{5},{6})", ART_NUMBER, REFERENCE, QTY_IND, QTY_GROUP, BITMAP, LOGOFFER, INFORMATIONPIC)
    '    DBUpdate("ProducData", str_param, str_val)
    'End Sub

    'Private Sub SetValue(Item As String, Val As String)
    '    Try
    '        Dim str_param As String = String.Format("Value='{0}'", Val)
    '        Dim str_where As String = String.Format("Item='{0}'", Item)
    '        DBUpdate("ProductData", str_param, str_where)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub RemoveValue(Item As String, Val As String)
    '    Try
    '        'Dim str_param As String = String.Format("Value='{0}'", Val)
    '        Dim str_where As String = String.Format("Item='{0}'", Item)
    '        DBDelete("ProductData", str_where)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Public Overrides Function Open() As Boolean
        Dim folderPath As String = Path.Combine(_path, GetFolderBase(_dataType))
        Try
            _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Path.Combine(folderPath, _fileName + ".accdb") & ";"
            _con = New OleDbConnection(_connectionString)
            _cmd = New OleDbCommand()
            _con.ParseViaFramework = True
            _con.Open()
            _isConnected = True
        Catch ex As Exception
            _isConnected = False
        End Try
        Return MyBase.Open()
    End Function

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
