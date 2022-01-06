Imports System.Threading
Imports Database.SQLite

Public Class DBManager

    Public DBList As List(Of IDatabase) = New List(Of IDatabase)()
    Public Property ConnectionString As String
    Public Property DBTYPE As String
    Public Property CONTYPE As String
    Public Property FILENAME As String
    Public Enum type
        SQL
        Access
    End Enum
    Public Sub New(ByVal _filename As String,
                   ByVal _dbType As Database.DATATYPE)
        FILENAME = _filename
        DBTYPE = _dbType

    End Sub

    Public Sub New()

    End Sub

    Public Structure asddd
        Public asd As Integer

        Public a As Integer
        Public Function add() As Integer
            Return a + asd
        End Function
        Public Sub Reset()
            asd = 0
            a = 0
        End Sub
    End Structure

    Public Function GetDataBase(filename As String, uid As String, type As String) As IDatabase
        Dim dba As IDatabase = New SQLite()
        Dim result = (From db In DBList Where db.UID = uid).ToArray()
        If result.Count > 0 Then
            Return result.ElementAt(0)
        Else
            Add(filename, type, uid)
        End If

        Return dba
    End Function

    Private Sub Add(filename As String, type As String, uid As String)
        Dim a As IDatabase = New Database()
        Select Case type
            Case "-sqlite"
                a = New SQLite()
                a.Filename = filename

            Case "-access"

            Case Else
                a = New Database()
        End Select
        a.Open()

        DBList.Add(a)
    End Sub

End Class