Public Interface IDBManager
    Function GetDataBase(filename As String, uid As String, type As String, Folder As String) As IDatabase
    Function CloseDataBase(uid As String) As IDatabase
    Function Add(filename As String, type As String, uid As String, Folder As String)

End Interface
