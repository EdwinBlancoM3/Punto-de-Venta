'Importar Clases para conectividad a MS-ACCESS
Imports System.Data.OleDb
Public Class Access
    'Variable de instancia del tipo conexion OLEDB
    Public cnx As OleDbConnection

    'Método Constructor que establece la conexión con el origen de datos
    Public Sub New()
        cnx = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DB_PUNTO_VENTA\DB_PUNTO_VENTA1.mdb")
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open() 'Abrir la base de datos
            Catch ex As Exception
                Throw New Exception("Conexión a base de datos no efectuada!!", ex)
            End Try
        End If
    End Sub

    'Método que ejecuta un comando insert, upadate o delete en la base de datos y
    'generar el DataAdapter
    Public Function objetoDataAdapter(ByVal sqlcmd As String) As DataTable
        Dim DA As OleDbDataAdapter
        Dim DT As DataTable

        DA = New OleDbDataAdapter(sqlcmd, cnx)
        DT = New DataTable
        DA.Fill(DT)
        Return DT 'retorna el conjunto de datos
    End Function

    'Método que ejecuta un comando sobre la base de datos
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim sqlcmd As New OleDbCommand(strcmd, cnx)
        sqlcmd.ExecuteNonQuery()
    End Sub

    Function objetoDataReader(ByVal comando As String) As OleDbDataReader
        Dim cmd As New OleDbCommand(comando, cnx)
        Dim resultadoSQL As OleDbDataReader = cmd.ExecuteReader
        Return resultadoSQL
    End Function
End Class
