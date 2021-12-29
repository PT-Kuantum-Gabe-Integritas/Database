Imports Database
Imports System.IO

Public Class Database
    Implements IDatabase

    Public _isConnected
    Public _path

    Public Property BasePath As String Implements IDatabase.BasePath
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    Public ReadOnly Property isConnected As String Implements IDatabase.isConnected
        Get
            Return _isConnected

        End Get
    End Property

    Public Function DBInsert(param As String, table As String, values As String) As String Implements IDatabase.DBInsert
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("INSERT INTO {0} {1} VALUES {2}", table, param, values)
        End If
        Return query
    End Function

    Public Function DBUpdate(param As String, table As String, where As String) As String Implements IDatabase.DBUpdate
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("UPDATE {0} SET {1} WHERE {2}", table, param, where)
        End If
        Return query
    End Function


    Public Sub FolderExist(path As String) Implements IDatabase.FolderExist
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function DBSelect(param As String, table As String, where As String) As String Implements IDatabase.DBSelect
        Dim query As String = ""
        If _isConnected Then
            If where = String.Empty Then
                query = String.Format("SELECT {0} FROM {1}",
                                            param, table)
            Else
                query = String.Format("SELECT {0} FROM {1} WHERE {2}",
                                            param, table, where)

            End If
        End If
        Return query
    End Function

    Public Function GetDate(_date As Date) As String Implements IDatabase.GetDate
        Return String.Format("{0:0000}-{1:00}-{2:00}", _date.Year, _date.Month, _date.Day)
    End Function
End Class
