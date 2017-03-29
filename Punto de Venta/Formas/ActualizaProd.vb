Imports System.Data.OleDb
Public Class frmActualizarProducto

    Private Sub frmActualizarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            TxtCodigo.Text = Lectura(1)
            txtNombre.Text = Lectura(2)
            TxtCosto.Text = Lectura(3)
            TxtPrecio.Text = Lectura(4)
            TxtCantidadStock.Text = Lectura(5)
        Else
            MsgBox("Los Datos del producto no estan registrados")
        End If
        Cnx.Close()
        NEWCANTIDAD = Convert.ToUInt64(txtCantidadStock.Text)
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim AGREGAR As New Integer
        AGREGAR = Convert.ToInt64(txtAgregar.Text)
        NEWCANTIDAD += AGREGAR
        Try
            Dim Actualizar = "UPDATE PRODUCTO SET ID_PRODUCTO=@NewID_PRODUCTO, CODIGO=@CODIGO, NOM_PRODUCTO=@NOM_PRODUCTO, COSTO=@COSTO, PRECIO=@PRECIO, CANTIDAD_STOCK=@CANTIDAD_STOCK, ID_MARCA=@ID_MARCA WHERE ID_PRODUCTO=@ID_PRODUCTO"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", txtNewCodigo.Text)
            Cmd.Parameters.AddWithValue("@CODIGO", txtNewCodigo.Text)
            Cmd.Parameters.AddWithValue("@NOM_PRODUCTO", cbProducto.SelectedItem.ToString)
            Cmd.Parameters.AddWithValue("@COSTO", txtCosto.Text)
            Cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text)
            Cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", NEWCANTIDAD)
            Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", txtCodigo.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox(" Ya quedo ese pedo")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        txtAgregar.Text = 0
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        txtNewCodigo.Text = txtCodigo.Text
    End Sub
End Class