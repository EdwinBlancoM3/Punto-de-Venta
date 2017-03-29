Public Class Producto
    Private NEW_MARCA As String

    Public Sub New()
        ID_MARCA = IDS.ID_MARCA
    End Sub
    Public Property getSetNEWID_MARCA() As Integer
        Get
            Return ID_MARCA
        End Get
        Set(value As Integer)
            ID_MARCA = value
        End Set
    End Property
    Public Sub poblarProductos(ByVal objeto As ComboBox)
        Dim Lista As OleDb.OleDbDataReader
        Dim strSql As String
        Dim Cnx As New Access

        strSql = "SELECT NOM_PRODUCTO FROM PRODUCTO WHERE ID_MARCA =" & ID_MARCA & " Order By NOM_PRODUCTO"
        Lista = Cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub
    Public Sub poblarCantidad(ByVal objeto As TextBox)

    End Sub
End Class
