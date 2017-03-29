Imports System.Data.OleDb
Public Class frmEliminar

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Eliminar = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO=@ID_PRODUCTO"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", txtCodigo.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El producto fue eliminado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub frmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miProducto As New Producto
        miProducto.poblarProductos(cbProducto)
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Dim BUSCAR = "SELECT * FROM PRODUCTO WHERE NOM_PRODUCTO=@NOM_PRODUCTO"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@NOM_PRODUCTO", cbProducto.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txtCodigo.Text = Lectura(1)
            TxtNombre.Text = Lectura(2)
            txtCosto.Text = Lectura(3)
            txtPrecio.Text = Lectura(4)
            txtCantidad.Text = Lectura(5)
        Else
            MsgBox("Los Datos del producto no estan registrados")
        End If
        Cnx.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
End Class