Imports System.IO
Imports System.Data.OleDb
Public Class Access
    Inherits Database
    Public Sub InsertProduct(ART_NUMBER As String, REFERENCE As String, QTY_IND As String, QTY_GROUP As String, BITMAP As String, LOGOFFER As String, INFORMATIONPIC As String)

        Dim str_param As String = "('Art_Number','Reference','Qty_ind','Qty_Group','Bitmap','logoffer','InformationPic')"
        Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}',{4},{5},{6})", ART_NUMBER, REFERENCE, QTY_IND, QTY_GROUP, BITMAP, LOGOFFER, INFORMATIONPIC)
        DBInsert("ProducData", str_param, str_val)



    End Sub

    Public Sub UpdateProduct(ART_NUMBER As String, REFERENCE As String, QTY_IND As String, QTY_GROUP As String, BITMAP As String, LOGOFFER As String, INFORMATIONPIC As String)
        Dim str_param As String = "('Art_Number','Reference','Qty_ind','Qty_Group','Bitmap','logoffer','InformationPic')"
        Dim str_val As String = String.Format("('{0}','{1}','{2}','{3}',{4},{5},{6})", ART_NUMBER, REFERENCE, QTY_IND, QTY_GROUP, BITMAP, LOGOFFER, INFORMATIONPIC)
        DBUpdate("ProducData", str_param, str_val)
    End Sub

    Private Sub SetValue(Item As String, Val As String)
        Try
            Dim str_param As String = String.Format("Value='{0}'", Val)
            Dim str_where As String = String.Format("Item='{0}'", Item)
            DBUpdate("ProductData", str_param, str_where)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveValue(Item As String, Val As String)
        Try
            Dim str_param As String = String.Format("Value='{0}'", Val)
            Dim str_where As String = String.Format("Item='{0}'", Item)
            DBDelete("ProductData", str_param, str_where)
        Catch ex As Exception

        End Try
    End Sub

End Class
