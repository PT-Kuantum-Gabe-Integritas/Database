Imports System.IO
Imports System.Threading
Imports Database.DBManager
Imports Database.SQLite
Public Class Form1
    Private _testSQ As IDBManager = New DBManager()
    Private a As SQLite = New SQLite()
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        '_testSQ.GetDataBase("usersDb", TextBox1.Text, "-sqlite")
        a = _testSQ.GetDataBase("PRODUCT", TextBox1.Text, "-sqlite")

    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        a.AddProduction("123123321", "TESTPRODUCTXV", 200, 30, "Hermina")
    End Sub
End Class
