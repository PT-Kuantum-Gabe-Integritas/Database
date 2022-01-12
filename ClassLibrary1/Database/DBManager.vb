Imports System.Threading
Imports Database

Public Class DBManager
    Implements IDBManager

    Public DBList As List(Of IDatabase) = New List(Of IDatabase)()
    Private dbL
    Public Property DBTYPE As String
    Public Property FILENAME As String

    Public Sub New(ByVal _filename As String,
                   ByVal _dbType As Databasemain.DATATYPE)
        FILENAME = _filename
        DBTYPE = _dbType

    End Sub

    Public Sub New()

    End Sub

    Public Function GetDataBase(filename As String, uid As String, type As String, Folder As String) As IDatabase Implements IDBManager.GetDataBase
        Dim result = (From db In DBList Where db.UID = uid).ToArray()
        If result.Count > 0 Then
            Return result.ElementAt(0)
        Else
            Return Add(filename, type, uid, Folder)
        End If
        Return dbL
    End Function


    Private Function Add(filename As String, type As String, uid As String, Folder As String) Implements IDBManager.Add
        Dim sq As SQLite = New SQLite()
        Dim oled As Access = New Access()
        Select Case type
            Case "-SQLite"
                sq.Filename = filename
                sq = New SQLite(filename, Folder)
                sq.UID = uid
                sq.Open()
                DBList.Add(sq)
                Return sq
            Case "-Access"
                oled.Filename = filename
                oled = New Access(filename, Folder)
                oled.UID = uid
                oled.Open()
                DBList.Add(oled)
                Return oled
            Case Else
                sq = New Databasemain()
                oled = New Databasemain()
        End Select
        Return 0
    End Function

End Class