Imports System.IO
Imports System.Threading
Imports Database.DBManager
Imports Database.SQLite
Imports Database.Form1
Public Class Form2

    Public Property _testSQ As DBManager
    Public Property a As SQLite ' = New SQLite()
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        '_testSQ.GetDataBase("usersDb", TextBox1.Text, "-sqlite")
        a = _testSQ.GetDataBase("PRODUCT", "1", "-sqlite")

    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        a.AddProduction("123123321", "TESTPRODUCTXV", 200, 30, "Hermina")
    End Sub
End Class