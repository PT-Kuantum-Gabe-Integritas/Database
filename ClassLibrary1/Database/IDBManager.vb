Public Interface IDBManager
    Function GetDataBase(filename As String, uid As String, type As Boolean, Folder As Databasemain.DATATYPE) As IDatabase
    Function Add(filename As String, type As Boolean, uid As String, Folder As Databasemain.DATATYPE)

End Interface
