Imports System.IO
Imports System.Threading
Imports Database.DBManager
Imports Database.SQLite
Public Class Form1
    'Private _testSQ As SQLite = New SQLite("PRODUCT", Database.DATATYPE.CONFIG)
    'Private _testSQ = SQLite : getInstance
    'Dim _testSQ As DBManager = DBManager.("user.DB", Database.DATATYPE.USER)
    'Dim _testSQ2 As DBManager = DBManager.getInstance("config.DB", "SQL")

    'Dim list As New List(SQLite)
    Private _testSQ As DBManager = New DBManager("PRODUCT", Database.DATATYPE.CONFIG)




    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        _testSQ.GetDataBase("product", "123", "-sqlite")
        'If _testSQ Is _testSQ2 Then
        'MsgBox("same")
        'End If

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        _testSQ.AddProduction("123123321", "TESTPRODUCTXV", 200, 30, "Hermina")
    End Sub
End Class
