Imports System.Data.OleDb
Public Class Frm_Inventario
    Dim strFileName As String
    Private Sub Btn_Regresar_Click(sender As Object, e As EventArgs) Handles Btn_Regresar.Click
        Me.Close()
        Frm_Marcas.Show()
        IDS.ID_MARCA = 0
        Cb_Nom_Producto.Items.Clear()
    End Sub
    'combo box de productos
    Private Sub Cb_Nom_Producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Nom_Producto.SelectedIndexChanged
        Dim BUSCAR = "SELECT * FROM PRODUCTO WHERE NOM_PRODUCTO=@NOM_PRODUCTO"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@NOM_PRODUCTO", Cb_Nom_Producto.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            TxtCodigo.Text = Lectura(1)
            TxtNombre.Text = Lectura(2)
            TxtCosto.Text = Lectura(3)
            TxtPrecio.Text = Lectura(4)
            TxtCantidadStock.Text = Lectura(5)
        Else
            MsgBox("Los Datos del producto no estan registrados")
        End If
        Cnx.Close()
    End Sub

    Private Sub Frm_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miProducto As New Producto
        miProducto.poblarProductos(Cb_Nom_Producto)
    End Sub
    'boton nuevo
    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Cb_Nom_Producto.Visible = False
        LblCodigo.Visible = True
        TxtCodigo.Visible = True
        LblProducto.Visible = False
        LblAgregar.Visible = False
        TxtAgregar.Visible = False
        LblNombre.Visible = True
        TxtNombre.Visible = True
        Btn_Guardar.Visible = True
        btnAplicar.Visible = False
        Btn_Eliminar.Visible = False
        TxtCodigo.ReadOnly = False
        TxtCantidadStock.Text = ""
        TxtCodigo.Text = ""
        TxtCosto.Text = ""
        TxtPrecio.Text = ""
        TxtNombre.Text = ""

    End Sub
    'boton actualizar
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If (Cb_Nom_Producto.Text = "") Then
            MsgBox("Seleccione un Producto para ser actualizado")
        Else
            LblNombre.Visible = False
            TxtNombre.Visible = False
            Cb_Nom_Producto.Visible = True
            LblProducto.Visible = True
            LblAgregar.Visible = True
            TxtAgregar.Visible = True
            LblCodigo.Visible = True
            TxtCodigo.Visible = True
            Btn_Guardar.Visible = False
            btnAplicar.Visible = True
            Btn_Eliminar.Visible = True
            NEWCANTIDAD = Convert.ToUInt64(TxtCantidadStock.Text)
            Dim BUSCAR = "SELECT * FROM PRODUCTO WHERE NOM_PRODUCTO=@NOM_PRODUCTO"
            Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
            CmdBuscar.CommandType = CommandType.Text
            CmdBuscar.Parameters.AddWithValue("@NOM_PRODUCTO", Cb_Nom_Producto.Text)
            Cnx.Open()
            Dim Lectura As OleDbDataReader
            Lectura = CmdBuscar.ExecuteReader
            If (Lectura.Read) Then
                TxtCodigo.Text = Lectura(1)
                TxtNombre.Text = Lectura(2)
                TxtCosto.Text = Lectura(3)
                TxtPrecio.Text = Lectura(4)
                TxtCantidadStock.Text = Lectura(5)
            Else
                MsgBox("Los Datos del producto no estan registrados")
            End If
            Cnx.Close()
        End If
        

    End Sub
    'boton guardar
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            Dim Insertar = "INSERT INTO PRODUCTO VALUES(@ID_PRODUCTO, @CODIGO, @NOM_PRODUCTO, @COSTO, @PRECIO, @CANTIDAD_STOCK, @ID_MARCA)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", TxtCodigo.Text)
            Cmd.Parameters.AddWithValue("@CODIGO", TxtCodigo.Text)
            Cmd.Parameters.AddWithValue("@NOM_PRODUCTO", TxtNombre.Text)
            Cmd.Parameters.AddWithValue("@COSTO", TxtCosto.Text)
            Cmd.Parameters.AddWithValue("@PRECIO", TxtPrecio.Text)
            Cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", TxtCantidadStock.Text)
            Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El producto fue registrado")
        Catch ex As Exception
            MsgBox("El prodcuto ya existe no seas pendejo!")
        End Try
        TxtCodigo.Clear()
        TxtNombre.Clear()
        TxtCosto.Clear()
        TxtPrecio.Clear()
        TxtCantidadStock.Clear()
    End Sub
    'boton eliminar
    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Try
            Dim Eliminar = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO=@ID_PRODUCTO"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", TxtCodigo.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El producto fue eliminado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        TxtCodigo.Clear()
        TxtNombre.Clear()
        TxtCosto.Clear()
        TxtPrecio.Clear()
        TxtCantidadStock.Clear()
    End Sub
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim AGREGAR As New Integer
        AGREGAR = Convert.ToInt64(TxtAgregar.Text)
        NEWCANTIDAD += AGREGAR
        Try
            Dim Actualizar = "UPDATE PRODUCTO SET ID_PRODUCTO=@ID_PRODUCTO, CODIGO=@CODIGO, NOM_PRODUCTO=@NOM_PRODUCTO, COSTO=@COSTO, PRECIO=@PRECIO, CANTIDAD_STOCK=@CANTIDAD_STOCK, ID_MARCA=@ID_MARCA WHERE ID_PRODUCTO=@ID_PRODUCTO"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", TxtCodigo.Text)
            Cmd.Parameters.AddWithValue("@CODIGO", TxtCodigo.Text)
            Cmd.Parameters.AddWithValue("@NOM_PRODUCTO", Cb_Nom_Producto.SelectedItem.ToString)
            Cmd.Parameters.AddWithValue("@COSTO", TxtCosto.Text)
            Cmd.Parameters.AddWithValue("@PRECIO", TxtPrecio.Text)
            Cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", NEWCANTIDAD)
            Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox(" Ya quedo ese pedo")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        TxtAgregar.Text = 0
        Btn_Actualizar_Click(sender, e)
    End Sub
End Class