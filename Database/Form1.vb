Imports System.IO
Public Class Form1
    'Private _testSQ As SQLite = New SQLite("PRODUCT", Database.DATATYPE.CONFIG)
    'Private _testSQ = SQLite : getInstance
    'Dim _testSQ As SQLite = SQLite.Instance()
    'Dim _testSQ2 As SQLite = SQLite.Instance()

    'Dim list As New List(SQLite)



    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        '_testSQ.Open()
        'If _testSQ Is _testSQ2 Then
        '    MsgBox("Same Instance !!!")
        'End If


    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        '_testSQ.AddProduction("123123321", "TESTPRODUCTXV", 200, 30, "Hermina")
    End Sub
End Class
