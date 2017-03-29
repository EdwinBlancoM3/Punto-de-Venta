Public Class Marca

    Public Sub New()
    End Sub
    Public Sub poblarMarcas(ByVal objeto As ComboBox)
        Dim Lista As OleDb.OleDbDataReader
        Dim strSql As String
        Dim Cnx As New Access

        strSql = "SELECT MARCA FROM MARCA Order By MARCA"
        Lista = Cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub
End Class
