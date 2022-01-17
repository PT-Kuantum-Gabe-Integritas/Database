Public Interface IUserManagement

    Function GetPass(type As String, Optional ByRef pass As String = "") As Boolean
    Function GetPermit(type As String)
    Function GetUserList() As List(Of String)
    Function ValidateUser(user As UserData) As Boolean
    Function AddUser(user As String, pass As String) As Boolean
    Function loadTable()
    Sub ClearUser()
    Sub DeleteUser(param As String)
    Sub UpdateUser(user As String, pass As String)

End Interface
