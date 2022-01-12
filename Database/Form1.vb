Imports System.IO
Imports System.Threading
Imports Database
Public Class Form1
    Private _testSQ As IDBManager = New DBManager()
    Private a As SQLite = New SQLite()
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        a = _testSQ.GetDataBase("PRODUCT", "1", "0", Database.Databasemain.DATATYPE.USER)

    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        AddProduction("123123321", "TESTPRODUCTXV", 200, 30, "Hermina")
        'Dim form2 As New Form2
        'form2._testSQ = _testSQ
        'form2.a = a
        'Me.Hide()
        'form2.Show()
    End Sub
    Public Sub AddProduction(PO_NUMBER As String, REFERENCE As String, QTY_PO As String, QTY_GROUP As String, USER As String)

        Dim str_param As String = "('po_number','reference','qty_po','qty_group','user')"
        Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}','{4}')", PO_NUMBER, REFERENCE, QTY_PO, QTY_GROUP, USER)
        a.DBInsert("PRODUCT", str_param, str_val)

    End Sub
End Class
