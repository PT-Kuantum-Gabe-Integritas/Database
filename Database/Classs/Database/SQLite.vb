Imports System.IO
Imports System.Data.SQLite

Public Class SQLite
    Inherits Database

    Public Sub New(Path As String)
        _path = Path
    End Sub


    Private Sub SQInsert(table As String, param As String, val As String)
        Dim query = DBInsert(param, table, val)
        ExecNonQuery(query)
    End Sub

    Public Sub InsertProduct(PO_NUMBER As String, REFERENCE As String, QTY_PO As String, QTY_GROUP As String)

        Dim str_param As String = "('po_number','reference','qty_po','qty_group')"
        Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}')", PO_NUMBER, REFERENCE, QTY_PO, QTY_GROUP)
        SQInsert("PRODUCT", str_param, str_val)

    End Sub

    Public Sub SQUpdate(table As String, param As String, val As String)
        Dim query = DBUpdate(param, table, val)
        ExecNonQuery(query)
    End Sub

End Class
