Imports System.IO
Imports System.Data.SQLite

Public Class SQLite
    Inherits Database


    Public Sub AddProduction(PO_NUMBER As String, REFERENCE As String, QTY_PO As String, QTY_GROUP As String, USER As String)

        Dim str_param As String = "('po_number','reference','qty_po','qty_group','user')"
        Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}','{4}')", PO_NUMBER, REFERENCE, QTY_PO, QTY_GROUP, USER)
        DBInsert("PRODUCT", str_param, str_val)

    End Sub

    Public Sub SetQty(VAL As Integer, PO_NO As String)
        Dim str_val As String = String.Format("qty_ind = {0}", VAL)
        Dim str_no As String = String.Format("po_no = {0}", PO_NO)
        DBUpdate("PRODUCT", str_val, PO_NO)
    End Sub

    Public Sub SetStatus(VAL As Integer, PO_NO As String)
        Dim str_val As String = String.Format("status = {0}", VAL)
        Dim str_no As String = String.Format("po_no = {0}", PO_NO)
        DBUpdate("PRODUCT", str_val, PO_NO)
    End Sub



End Class
