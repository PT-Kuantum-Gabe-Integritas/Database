
Imports System.IO
Imports Database

Public Class UserManagement
    Implements IUserManagement
    Private _path As String = Application.StartupPath
    Private _currUser As UserData = Nothing
    Private getdatabase As DBManager = DBManager.getInstance()
    Private _dbUser As SQLite = New SQLite()

    Public Property CurrentUser As UserData
        Get
            Return _currUser
        End Get
        Set(value As UserData)
            _currUser = value
        End Set
    End Property

    Public Sub Initialize()
        _dbUser = getdatabase.GetDataBase("User.db", "US1", "-SQLite", "CONFIG")
    End Sub

    Public Function GetPass(type As String, Optional ByRef pass As String = "") As Boolean Implements IUserManagement.GetPass
        Dim autorized As Boolean = False
        Try
            Dim str_where As String = String.Format("user='{0}'", type)
            Dim dt As DataTable = New DataTable()
            dt = _dbUser.DBSelect("pass, authorization", "tb_user", str_where, False, 1)
            If dt.Rows.Count > 0 Then
                pass = dt.Rows(0).Item("pass")
                autorized = Convert.ToBoolean(dt.Rows(0).Item("authorization"))
            End If
        Catch ex As Exception

        End Try
        Return autorized
    End Function
    Public Function GetPermit(type As String) Implements IUserManagement.GetPermit
        Dim dt As DataTable = New DataTable()
        Try
            Dim str_where As String = String.Format("user='{0}'", type)
            dt = _dbUser.DBSelect("Dashboard, Run, Config, Manual, Reference, LOG, UserManage", "tb_user", str_where, False, 1)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    Public Function GetUserList() As List(Of String) Implements IUserManagement.GetUserList
        Dim users As List(Of String) = New List(Of String)()
        Try
            Dim dt As DataTable = New DataTable()
            dt = _dbUser.DBSelect("user", "tb_user", "", False, 1)

            For i As Integer = 0 To dt.Rows.Count - 1
                users.Add(dt.Rows(i).Item("user"))
            Next
        Catch ex As Exception

        End Try

        Return users
    End Function

    Public Function ValidateUser(user As UserData) As Boolean Implements IUserManagement.ValidateUser
        Dim pass As String = ""
        Dim auth As Boolean = False
        With user
            .Logged = False
            auth = GetPass(.Type, pass)
            .Authorized = auth
            If Not auth Then
                .Logged = True
            Else
                If .Pass = pass Then
                    .Logged = True
                End If
            End If

            If .Logged Then
                _currUser = user
            End If
            Return .Logged
        End With
    End Function

    Public Function AddUser(user As String, pass As String) As Boolean Implements IUserManagement.AddUser
        Dim _success As Boolean
        Dim str_where As String = String.Format("(user,pass)")
        Dim str_val As String = String.Format("('{0}','{1}')", pass, user)
        _dbUser.DBInsert("tb_user", str_where, str_val)
        Return _success
    End Function

    Public Sub DeleteUser(param As String) Implements IUserManagement.DeleteUser
        Dim str_where As String = String.Format("ID='{0}'", param)
        _dbUser.DBDelete("tb_user", str_where)
    End Sub

    Public Sub UpdateUser(user As String, pass As String) Implements IUserManagement.UpdateUser
        Dim str_where As String = String.Format("user = '{0}'", user)
        Dim str_val As String = String.Format("pass = '{0}'", pass)
        _dbUser.DBUpdate("tb_user", str_val, str_where)
    End Sub

    Public Sub ClearUser() Implements IUserManagement.ClearUser
        _currUser = Nothing
    End Sub

    Public Function loadTable() Implements IUserManagement.loadTable
        Dim TableDB As New DataTable
        Try
            _dbUser.DBLoad("tb_user", TableDB, _dbUser._con)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return TableDB
    End Function
End Class
