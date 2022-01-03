Public Class DBManager

    Public Property ConnectionString As String
    Public Property DBTYPE As String
    Public Property CONTYPE As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal _conString As String,
                   ByVal _dbType As String,
                   ByVal _conType As String
                  )
        ConnectionString = _conString
        DBTYPE = _dbType
        CONTYPE = _conType
    End Sub


    Function GetConnection() As IEnumerable(Of DBManager)
        Return New List(Of DBManager) From
            {
            New DBManager("Product", "Config", "SQL")
            }
    End Function

End Class
