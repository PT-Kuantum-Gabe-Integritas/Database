Public Interface IDatabase

    Function DBSelect(param As String, table As String, where As String) As String
    Function DBInsert(param As String, table As String, values As String) As String
    Function DBUpdate(param As String, table As String, where As String) As String
    Function GetDate(_date As Date) As String
    Sub FolderExist(path As String)
    ReadOnly Property isConnected As String
    Property BasePath As String

End Interface
