Public Interface IDatabase

    Function DBSelect(param As String, table As String, where As String) As DataTable
    Sub DBInsert(param As String, table As String, values As String)
    Sub DBUpdate(param As String, table As String, where As String)
    Sub DBDelete(table As String, where As String)
    Function GetDate(_date As Date) As String
    Sub FolderExist(path As String)
    ReadOnly Property isConnected As String
    Property BasePath As String
    Function ExecQuery(cmd As String) As DataTable
    Sub ExecNonQuery(cmd As String)
    Enum DATATYPE
        CONFIG
        USER
    End Enum
    Enum CONTYPE
        SQL
        ACCESS
    End Enum

    Function Open(FileName As String, Type As DATATYPE, connection_type As CONTYPE) As Boolean
    Sub Close()

End Interface
