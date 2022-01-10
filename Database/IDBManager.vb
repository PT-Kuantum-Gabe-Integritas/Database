Public Interface IDBManager
    Function GetDataBase(filename As String, uid As String, type As String) As IDatabase
    Sub Add(filename As String, type As String, uid As String)

End Interface
