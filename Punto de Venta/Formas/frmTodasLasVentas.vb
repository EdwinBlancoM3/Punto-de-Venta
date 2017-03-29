Imports System.Data.OleDb
Public Class frmTodasLasVentas
    Private Sub dgvVentasTotales()
        Dim lectura As New OleDbDataAdapter
        Dim Venta As New DataSet
        Dim comando As String = "SELECT * FROM DET_VENTA WHERE ID_DET_VENTA>=1"
        lectura = New OleDbDataAdapter(comando, Cnx)
        Venta.Tables.Add("VENTAS")
        lectura.Fill(Venta.Tables("VENTAS"))
        dgvTotales.DataSource = Venta.Tables("VENTAS")
    End Sub
    Sub ganancias()
        Dim BUSCAR As String = "SELECT SUM(IMPORTE) FROM VENTAS"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If Lectura.Read Then
            txtGanancias.Text = Lectura(0)
        End If
        Lectura.Close()
        Cnx.Close()
    End Sub
    Sub costos()
        Dim BUSCAR As String = "SELECT SUM(COSTO_TOTAL) FROM PRODUCTO"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If Lectura.Read Then
            txtCosto.Text = Lectura(0)
        End If
        Lectura.Close()
        Cnx.Close()
    End Sub
    Private Sub utilidad()
        txtUtilidadNeta.Text = Convert.ToDecimal(txtGanancias.Text) - Convert.ToDecimal(txtCosto.Text)
    End Sub

    Private Sub frmTodasLasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvVentasTotales()
        ganancias()
        costos()
        utilidad()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If (dgvTotales.RowCount - 1 > 0) Then
            If Funciones.GridAExcel(dgvTotales) = False Then
                MessageBox.Show("Error al exportar!!")
            End If
        Else
            MessageBox.Show("No hay registros para exportar!!")
        End If
    End Sub
End Class