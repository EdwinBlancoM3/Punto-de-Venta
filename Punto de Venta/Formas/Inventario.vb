Imports System.Data.OleDb 'Importamos los objetos utilizados para el manejo de la bd
Public Class Frm_Marcas
    Private Sub AgregarNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) 'Este metodo se activa al presionar el boton del toolstrip
        If (cbMarca.Text = "") Then                                                   'Valida que el usuario haya escogido una marca para poder continuar  
            MsgBox("Seleccione la marca del nuevo producto")
        Else
            frmAgregaProducto.Show()
        End If
    End Sub
    'En este metodo cuando el usuario selecciona una marca se hace una consulta en la bd para traernos el id de esa marca para usarlo en otras consultas
    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.SelectedIndexChanged
        Dim BUSCAR = "SELECT ID_MARCA FROM MARCA WHERE MARCA=@MARCA"    'Declaramos un String donde va ir nuestro Query
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)          'Declaramos un nuevo objeto llamado oledbcommand donde va referenciado nuestro query y conexion
        CmdBuscar.CommandType = CommandType.Text                'Establecemos el tipo de comando como texto 
        CmdBuscar.Parameters.AddWithValue("@MARCA", cbMarca.Text)  ' Agregamos en los parametros del comando el valor 
        Cnx.Open()        'Abrimos la conexion                     'que va a llevar el campo marca en el query que lo tomamos del textbox             
        Dim Lectura As OleDbDataReader              'Declaramos el objeto data reader que es donde se iran haciendo las lecturas que arroje el query
        Lectura = CmdBuscar.ExecuteReader           'Ejecutamos el objeto comando y el resultado lo almacenamos en el datareader
        If (Lectura.Read) Then                      'Validamos que la lectura se pueda leer
            lblIDMARCA.Text = Lectura(0)            'Almacenamos el valor consultado que en este caso es el unico y se guarda en la posicion 0
        Else
            MsgBox("LA MARCA NO ESTA REGISTRADA")   'Si no encuentra coincidencias regresa una ventana de texto para el usuario
        End If
        Cnx.Close()                                 'Cerramos la conexion
        ID_MARCA = lblIDMARCA.Text                  'Guardamos la consulta en una variable global localizada en nuestro modulo
    End Sub

    Private Sub Frm_Marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miMarca As New Marca 'Declaramos un nuevo objeto de la clase Marca
        miMarca.poblarMarcas(cbMarca) 'LLamamos el metodo que se encuentra en la clase para poblar el combobox
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If (cbMarca.Text = "") Then                                 'Validamos que el usuario tenga una marca seleccionada
            MsgBox("Seleccione la marca del producto a actualizar") ' en caso de que no se lo pedimos
        Else
            frmActualizarProducto.Show()                            'muestra la siguiente ventana
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If (cbMarca.Text = "") Then                                 'Validamos que el usuario tenga una marca seleccionada
            MsgBox("Seleccione la marca del producto a Eliminar")   ' en caso de que no se lo pedimos
        Else
            frmEliminar.Show()                                      'muestra la siguiente ventana
        End If
    End Sub
    Sub Ultimo()
        Dim BUSCAR As String = "SELECT MAX(ID_MARCA) FROM MARCA"    'Este metodo efectua la consulta de una funcion de grupo con este
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)              'metodo sabremos cual es el id de la ultima marca registrada
        CmdBuscar.CommandType = CommandType.Text                    'essto nos ayuda a saber que id sigue y no se repita o se salte
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If Lectura.Read Then
            ID_MARCA = Lectura(0)
        End If
        Lectura.Close()
        Cnx.Close()
    End Sub

    Private Sub AgregarNuevaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call Ultimo()                       'En este metodo llamamos al metodo ultimo para saber el numero del ultimo registro
        ID_MARCA += 1                       'le sumamos uno para dar seguimiento a la serie
        frmAgregaMarca.Show()               'y mostramos la siguiente ventana
        btnRefreshMarcas.Visible = True
    End Sub
    Private Sub btnRefreshMarcas_Click(sender As Object, e As EventArgs) Handles btnRefreshMarcas.Click
        Frm_Marcas_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminarMarca.Click
        If ID_MARCA > 0 Then
            Try                                                                 'En este metodo borramos todos los registros de productos
                Dim Eliminar = "DELETE FROM PRODUCTO WHERE ID_MARCA=@ID_MARCA"  'Que estnn relacionados con esa marca por medio del id de la marca
                Dim Cmd As New OleDbCommand(Eliminar, Cnx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
                Cnx.Open()
                Cmd.ExecuteNonQuery()
                Cnx.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try                                                             'Luego Borramos la marca
                Dim Eliminar = "DELETE FROM MARCA WHERE ID_MARCA=@ID_MARCA"
                Dim Cmd As New OleDbCommand(Eliminar, Cnx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
                Cnx.Open()
                Cmd.ExecuteNonQuery()
                Cnx.Close()
                MsgBox("La Marca fue eliminada")
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("No se puede borrar la marca de productos generales")
        End If
        Frm_Marcas_Load(sender, e)
        btnEliminarMarca.Visible = False
        btnRefreshMarcas.Visible = False
        cbMarca.Items.Remove(cbMarca.SelectedItem)

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        btnEliminarMarca.Visible = True
    End Sub
    Private Sub dgvProductosMarca()   'Este metodo nos sirve para rellenar un datagridg
        Dim lectura As New OleDbDataAdapter 'declaramos un dataadapter que nos ayuda a adaptar los datos a un conjunto de datos
        Dim producto As New DataSet         'declaramos nuestro conjunto de dtaos
        Dim comando As String = "SELECT CODIGO, NOM_PRODUCTO, COSTO, PRECIO, CANTIDAD_STOCK FROM PRODUCTO WHERE ID_MARCA =" & ID_MARCA 'query
        lectura = New OleDbDataAdapter(comando, Cnx)   'Rellenamos el adaptador
        producto.Tables.Add("Productos") 'al conjunto de datos que declaramos le agregamos la tabla "Productos"
        lectura.Fill(producto.Tables("Productos"))  'con el dataadapter rellenamos la tabla del conjunto
        dgvConsulta.DataSource = producto.Tables("Productos") 'ahora solo referenciamos la tabla como la fuente de datos de dgv
    End Sub
    Private Sub dgvProductosTodos()
        Dim lectura As New OleDbDataAdapter
        Dim producto As New DataSet
        Dim comando As String = "SELECT CODIGO, NOM_PRODUCTO, COSTO, PRECIO, CANTIDAD_STOCK FROM PRODUCTO"
        lectura = New OleDbDataAdapter(comando, Cnx)
        producto.Tables.Add("Productos")
        lectura.Fill(producto.Tables("Productos"))
        dgvConsulta.DataSource = producto.Tables("Productos")
    End Sub
    Private Sub PorMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione una Marca")
        Else
            dgvConsulta.Visible = True
            dgvProductosMarca()
        End If
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dgvConsulta.Visible = True
        dgvProductosTodos()
    End Sub

    Private Sub Btn_Regresar_Click(sender As Object, e As EventArgs) Handles Btn_Regresar.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione la marca del nuevo producto")
        Else
            frmAgregaProducto.Show()
        End If
    End Sub

    Private Sub BtnActualizarProducto_Click(sender As Object, e As EventArgs)
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione la marca del producto a actualizar")
        Else
            frmActualizarProducto.Show()
        End If
    End Sub

    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs)
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione la marca del producto a Eliminar")
        Else
            frmEliminar.Show()
        End If

    End Sub


    Private Sub BtnConsultarPoducto_Click(sender As Object, e As EventArgs) Handles BtnConsultarPoducto.Click
        dgvConsulta.Visible = True
        dgvProductosTodos()
    End Sub

    Private Sub BtnConsultarMarcaProducto_Click(sender As Object, e As EventArgs) Handles BtnConsultarMarcaProducto.Click
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione una Marca")
        Else
            dgvConsulta.Visible = True
            dgvProductosMarca()
        End If
    End Sub

    Private Sub BtnActualizarProducto_Click_1(sender As Object, e As EventArgs) Handles BtnActualizarProducto.Click
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione la marca del producto a actualizar")
        Else
            frmActualizarProducto.Show()
        End If
    End Sub

    Private Sub BtnEliminarProducto_Click_1(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        If (cbMarca.Text = "") Then
            MsgBox("Seleccione la marca del producto a Eliminar")
        Else
            frmEliminar.Show()
        End If
    End Sub

    Private Sub lblSeleccioneMarca_Click(sender As Object, e As EventArgs) Handles lblSeleccioneMarca.Click

    End Sub

    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        Call Ultimo()
        ID_MARCA += 1
        frmAgregaMarca.Show()
        btnRefreshMarcas.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        btnEliminarMarca.Visible = True
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class