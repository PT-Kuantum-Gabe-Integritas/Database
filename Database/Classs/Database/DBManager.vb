Public Class DBManager

    Public Property ConnectionString As String
    Public Property DBTYPE As String
    Public Property CONTYPE As String

    Public Sub New(ByVal _conString As String,
                   ByVal _dbType As String
                  )
        ConnectionString = _conString
        DBTYPE = _dbType

    End Sub

    Public Sub New()

    End Sub

End Class