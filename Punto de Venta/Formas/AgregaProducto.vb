Imports System.Data.OleDb
Public Class frmAgregaProducto

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        CalculoCosto()
        Try
            Dim Insertar = "INSERT INTO PRODUCTO VALUES(@ID_PRODUCTO, @CODIGO, @NOM_PRODUCTO, @COSTO, @PRECIO, @CANTIDAD_STOCK, @ID_MARCA, @COSTO_TOTAL)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_PRODUCTO", txtCodigo.Text)
            Cmd.Parameters.AddWithValue("@CODIGO", txtCodigo.Text)
            Cmd.Parameters.AddWithValue("@NOM_PRODUCTO", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@COSTO", txtCosto.Text)
            Cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text)
            Cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", txtCantidad.Text)
            Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
            Cmd.Parameters.AddWithValue("@COSTO_TOTAL", costo)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El producto fue registrado")
        Catch ex As Exception
            MsgBox("El prodcuto ya existe")
        End Try
        Me.Close()

    End Sub

    Private Sub frmAgregaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtCodigo.Text = "" Then
                MsgBox("Debe ingresar el codigo del producto")
            Else
                txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtNombre.Text = "" Then
                MsgBox("Debe ingresar el Nombre del producto")
            Else
                txtCantidad.Focus()
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtCantidad.Text = "" Then
                MsgBox("Debe ingresar la Cantidad en stock del producto")
            Else
                txtCosto.Focus()
            End If
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtCosto.Text = "" Then
                MsgBox("Debe ingresar el Costo del producto")
            Else
                txtPrecio.Focus()
            End If
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtPrecio.Text = "" Then
                MsgBox("Debe ingresar el Precio del producto")
            Else
                btnAgregar.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
    Private Sub CalculoCosto()
        costo = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtCosto.Text)
    End Sub
End Class