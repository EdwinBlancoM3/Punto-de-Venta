Imports System.Data.OleDb
Public Class frmResurtir

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If resurtir = 1 Then
            resurtidoDGV()
        Else
            existenciasDGV()
        End If

    End Sub
    Private Sub resurtidoDGV()
        Dim lectura As New OleDbDataAdapter
        Dim producto As New DataSet
        Dim comando As String = "SELECT CODIGO, NOM_PRODUCTO, COSTO, CANTIDAD_STOCK FROM PRODUCTO WHERE CANTIDAD_STOCK<5"
        lectura = New OleDbDataAdapter(comando, Cnx)
        producto.Tables.Add("Productos")
        lectura.Fill(producto.Tables("Productos"))
        dgvResurtir.DataSource = producto.Tables("Productos")
    End Sub
    Private Sub existenciasDGV()
        Dim lectura As New OleDbDataAdapter
        Dim producto As New DataSet
        Dim comando As String = "SELECT CODIGO, NOM_PRODUCTO, COSTO, PRECIO, CANTIDAD_STOCK FROM PRODUCTO"
        lectura = New OleDbDataAdapter(comando, Cnx)
        producto.Tables.Add("Productos")
        lectura.Fill(producto.Tables("Productos"))
        dgvResurtir.DataSource = producto.Tables("Productos")
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If (dgvResurtir.RowCount - 1 > 0) Then
            If Funciones.GridAExcel(dgvResurtir) = False Then
                MessageBox.Show("Error al exportar!!")
            End If
        Else
            MessageBox.Show("No hay registros para exportar!!")
        End If
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        frmReportes.Show()
        Me.Close()
        resurtir = 0
    End Sub

    Private Sub frmResurtir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvResurtir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResurtir.CellContentClick

    End Sub
End Class