Imports System.IO
Public Class Form1
    Private _testSQ As SQLite = New SQLite("PRODUCT", Database.DATATYPE.CONFIG)


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        _testSQ.Open()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        '_testSQ.AddProduction("123123321", "TESTPRODUCTXV", 200, 30, "Hermina")
    End Sub
End Class
