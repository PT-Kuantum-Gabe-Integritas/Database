Imports System.Threading
Imports Database.SQLite

Public Class DBManager
    Implements IDBManager

    Public DBList As List(Of IDatabase) = New List(Of IDatabase)()
    Private dbL
    Public Property DBTYPE As String
    Public Property FILENAME As String

    Public Sub New(ByVal _filename As String,
                   ByVal _dbType As Database.DATATYPE)
        FILENAME = _filename
        DBTYPE = _dbType

    End Sub

    Public Sub New()

    End Sub

    Public Function GetDataBase(filename As String, uid As String, type As String) As IDatabase Implements IDBManager.GetDataBase
        'Dim dbL As IDatabase = New Database()
        'Dim Tipe = type
        Dim result = (From db In DBList Where db.UID = uid).ToArray()
        If result.Count > 0 Then
            Return result.ElementAt(0)
        Else
            Add(filename, type, uid)
        End If

        'Select Case Tipe
        '    Case "-sqlite"
        '        Return dbTypeee = New SQLite()
        '    Case "-access"
        '        Return dbTypeee = New Access()
        'End Select

        Return dbL
    End Function

    'Private Sub Add(filename As String, type As String, uid As String) Implements IDBManager.Add
    '    Dim a As IDatabase = New Database()
    '    Select Case type
    '        Case "-sqlite"
    '            a = New SQLite(filename, Database.DATATYPE.USER)
    '            a.Filename = filename
    '            a.UID = uid
    '            a.Open()

    '        Case "-access"
    '            a = New Access()
    '            a.Filename = filename
    '            a.UID = uid
    '        Case Else
    '            a = New Database()
    '    End Select
    '    a.Open()
    '    DBList.Add(a)
    'End Sub

    Private Sub Add(filename As String, type As String, uid As String) Implements IDBManager.Add
        Dim a As SQLite = New SQLite()
        Dim b As Access = New Access()
        Select Case type
            Case "-sqlite"
                a.Filename = filename
                a = New SQLite(filename, Database.DATATYPE.USER)
                a.UID = uid
                a.Open()
            Case "-access"
                b.Filename = filename
                b = New Access(filename, Database.DATATYPE.USER)
                b.UID = uid
                b.Open()
            Case Else
                a = New Database()
                b = New Database()
        End Select
        DBList.Add(a)
    End Sub

End Class