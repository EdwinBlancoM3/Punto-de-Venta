Imports System.Data.OleDb
Public Class frmVentas

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtCodigo.Text = "" Then
                MsgBox("Debe ingresar el Codigo del producto")
            Else
                txtCantidad.Focus()
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtCantidad.Text = "" Then
                MsgBox("Debe ingresar la cantidad del producto")
            Else
                        dgvProducto()
                        txtCodigo.Clear()
                        txtCantidad.Clear()
                        txtCodigo.Focus()
            End If
        End If
    End Sub
    Private Sub dgvProducto()
        Dim subtotal As Decimal
        Dim resurtido As Integer
        Dim BUSCAR = "SELECT CODIGO, NOM_PRODUCTO, PRECIO, CANTIDAD_STOCK FROM PRODUCTO WHERE ID_PRODUCTO=@ID_PRODUCTO"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@NOM_PRODUCTO", txtCodigo.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            If (Lectura(3) < Convert.ToInt64(txtCantidad.Text) Or Lectura(3) <= 0) Then
                MsgBox("ProductoAgotado o Cantidad Stock insuficiente")
            Else
                dgvTicket.Rows.Add(Lectura(0), Lectura(1), Lectura(2), txtCantidad.Text, Lectura(3), (Lectura(3) - Convert.ToDecimal(txtCantidad.Text)), (Lectura(2) * Convert.ToDecimal(txtCantidad.Text)), "Quitar")
                subtotal = Lectura(2) * txtCantidad.Text
                total += subtotal
                txtTotal.Text = total
                resurtido = Lectura(3)
                If resurtido <= 5 Then
                    MsgBox("El Producto esta por agotarse")
                End If
            End If
        Else
            MsgBox("Los Datos del producto no estan registrados")
            txtCodigo.Text = ""
            txtCantidad.Text = ""
        End If

       
        Cnx.Close()

    End Sub

    Private Sub dgvTicket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicket.CellContentClick
        Dim row As DataGridViewRow = dgvTicket.CurrentRow
        If (row.Cells("Codigo").Value) <> "" Then
            total -= ((row.Cells("Precio").Value) * (row.Cells("Cantidad").Value))
            txtTotal.Text = total
            dgvTicket.Rows.Remove(dgvTicket.CurrentRow)
        Else
            MsgBox("accion invalida")
        End If
    End Sub
    Private Sub insert_ventas()
        Try
            Dim Insertar = "INSERT INTO VENTAS VALUES(@ID_VENTA, @FECHA, @IMPORTE)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_VENTA", ID_VENTA)
            Cmd.Parameters.AddWithValue("@FECHA", DateString)
            Cmd.Parameters.AddWithValue("@IMPORTE", txtTotal.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Private Sub Ultimo_ID_VENTA()
        Dim BUSCAR As String = "SELECT MAX(ID_VENTA) FROM VENTAS"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If Lectura.Read Then
            ID_VENTA = Lectura(0)
        End If
        Lectura.Close()
        Cnx.Close()
    End Sub
    Private Sub Ultimo_ID_DET_VENTA()
        Dim BUSCAR As String = "SELECT MAX(ID_DET_VENTA) FROM DET_VENTA"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If Lectura.Read Then
            ID_DET_VENTA = Lectura(0)
        End If
        Lectura.Close()
        Cnx.Close()
    End Sub
    Private Sub insert_det_ventas()
        Dim fila As DataGridViewRow = New DataGridViewRow
        For Each fila In dgvTicket.Rows
            If (Convert.ToString(fila.Cells("Codigo").Value) <> "") Then
                Try
                    Dim Insertar = "INSERT INTO DET_VENTA VALUES(@ID_DET_VENTA, @CANTIDAD, @NOM_PRODUCTO, @ID_VENTA, TOTAL)"
                    Dim Cmd As New OleDbCommand(Insertar, Cnx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@ID_DET_VENTA", ID_DET_VENTA)
                    Cmd.Parameters.AddWithValue("@CANTIDAD", fila.Cells("Cantidad").Value)
                    Cmd.Parameters.AddWithValue("@NOM_PRODUCTO", fila.Cells("Nombre").Value)
                    Cmd.Parameters.AddWithValue("@ID_VENTA", ID_VENTA)
                    Cmd.Parameters.AddWithValue("@TOTAL", fila.Cells("Subtotal").Value)
                    Cnx.Open()
                    Cmd.ExecuteNonQuery()
                    Cnx.Close()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
                ID_DET_VENTA += 1
            Else
                Exit For
            End If
            
        Next
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click

        If (dgvTicket.RowCount - 1 > 0) Then
            Ultimo_ID_VENTA()
            ID_VENTA += 1
            insert_ventas()
            Ultimo_ID_DET_VENTA()
            ID_DET_VENTA += 1
            insert_det_ventas()
            restarCantidad()
            nuevoTicket()
            total = 0
            txtTotal.Text = total
            MsgBox("Venta Realizada con Exito")

        Else
            MessageBox.Show("registre un producto")
        End If
       
    End Sub
    Private Sub nuevoTicket()
        dgvTicket.Rows.Clear()
        total = 0
        txtTotal.Text = ""
        txtCambio.Text = ""
        txtPagoCon.Text = ""
    End Sub
    Private Sub restarCantidad()
        Dim fila As DataGridViewRow = New DataGridViewRow
        Try
            For Each fila In dgvTicket.Rows
                If fila.Cells("Codigo").Value > 0 Then
                    Dim Actualizar = "UPDATE PRODUCTO SET ID_PRODUCTO=@ID_PRODUCTO, CODIGO=@CODIGO, NOM_PRODUCTO=@NOM_PRODUCTO, PRECIO=@PRECIO, CANTIDAD_STOCK=@CANTIDAD_STOCK WHERE ID_PRODUCTO=@ID_PRODUCTO"
                    Dim Cmd As New OleDbCommand(Actualizar, Cnx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@ID_PRODUCTO", fila.Cells("Codigo").Value)
                    Cmd.Parameters.AddWithValue("@CODIGO", fila.Cells("Codigo").Value)
                    Cmd.Parameters.AddWithValue("@NOM_PRODUCTO", fila.Cells("Nombre").Value)
                    Cmd.Parameters.AddWithValue("@PRECIO", fila.Cells("Precio").Value)
                    Cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", fila.Cells("resto").Value)
                    Cnx.Open()
                    Cmd.ExecuteNonQuery()
                    Cnx.Close()
                End If
                
            Next
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        nuevoTicket()
    End Sub
    Private Sub calcularCambio(total As Decimal)
        txtCambio.Text = Convert.ToDecimal(txtPagoCon.Text) - total
    End Sub

    Private Sub txtPagoCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagoCon.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If txtTotal.Text = "" Then
                MsgBox("Ingrese la cantidad con que se paga")
            Else
                calcularCambio(Convert.ToDecimal(txtTotal.Text))
                btnCobrar.Focus()
            End If
        End If
    End Sub

    Private Sub Btn_Regresar_Click(sender As Object, e As EventArgs) Handles Btn_Regresar.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class