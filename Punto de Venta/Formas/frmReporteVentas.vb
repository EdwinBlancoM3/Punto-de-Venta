Imports System.Data.OleDb
Public Class frmReporteVentas

    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miVenta As New Venta
        miVenta.poblarVentas(cbVentas)
    End Sub

    Private Sub cbVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVentas.SelectedIndexChanged
        Dim BUSCAR = "SELECT * FROM VENTAS WHERE ID_VENTA=@ID_VENTA"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@ID_VENTA", cbVentas.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            ID_VENTA = Lectura(0)
            txtFecha.Text = Lectura(1)
            txtImporte.Text = Lectura(2)
        Else
            MsgBox("Los Datos del producto no estan registrados")
        End If
        Cnx.Close()
        filldgvDETALLE()
    End Sub
    Private Sub filldgvDETALLE()
        Dim lectura As New OleDbDataAdapter
        Dim Venta As New DataSet
        Dim comando As String = "SELECT * FROM vistaventas WHERE ID_VENTA=" & ID_VENTA
        lectura = New OleDbDataAdapter(comando, Cnx)
        Venta.Tables.Add("VENTAS")
        lectura.Fill(Venta.Tables("VENTAS"))
        dgvDetVentas.DataSource = Venta.Tables("VENTAS")
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If (dgvDetVentas.RowCount - 1 > 0) Then
            If Funciones.GridAExcel(dgvDetVentas) = False Then
                MessageBox.Show("Error al exportar!!")
            End If
        Else
            MessageBox.Show("No hay registros para exportar!!")
        End If
    End Sub
End Class