Public Class Venta
    Public Sub New()
    End Sub
    Public Sub poblarVentas(ByVal objeto As ComboBox)
        Dim Lista As OleDb.OleDbDataReader
        Dim strSql As String
        Dim Cnx As New Access

        strSql = "SELECT ID_VENTA FROM VENTAS WHERE ID_VENTA>=1"
        Lista = Cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub
End Class
