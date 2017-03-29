<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Inventario))
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblCosto = New System.Windows.Forms.Label()
        Me.LblAgregar = New System.Windows.Forms.Label()
        Me.LblCantidadStock = New System.Windows.Forms.Label()
        Me.TxtAgregar = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCantidadStock = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.Cb_Nom_Producto = New System.Windows.Forms.ComboBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.Location = New System.Drawing.Point(510, 403)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(87, 54)
        Me.Btn_Regresar.TabIndex = 21
        Me.Btn_Regresar.Text = "Regresar"
        Me.Btn_Regresar.UseVisualStyleBackColor = True
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.BackColor = System.Drawing.Color.Olive
        Me.LblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio.Location = New System.Drawing.Point(55, 297)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(66, 22)
        Me.LblPrecio.TabIndex = 20
        Me.LblPrecio.Text = "Precio:"
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.BackColor = System.Drawing.Color.Olive
        Me.LblCosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblCosto.Location = New System.Drawing.Point(55, 261)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(63, 22)
        Me.LblCosto.TabIndex = 19
        Me.LblCosto.Text = "Costo:"
        '
        'LblAgregar
        '
        Me.LblAgregar.AutoSize = True
        Me.LblAgregar.BackColor = System.Drawing.Color.Olive
        Me.LblAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAgregar.Location = New System.Drawing.Point(55, 343)
        Me.LblAgregar.Name = "LblAgregar"
        Me.LblAgregar.Size = New System.Drawing.Size(80, 22)
        Me.LblAgregar.TabIndex = 18
        Me.LblAgregar.Text = "Agregar:"
        Me.LblAgregar.Visible = False
        '
        'LblCantidadStock
        '
        Me.LblCantidadStock.AutoSize = True
        Me.LblCantidadStock.BackColor = System.Drawing.Color.Olive
        Me.LblCantidadStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCantidadStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblCantidadStock.Location = New System.Drawing.Point(55, 221)
        Me.LblCantidadStock.Name = "LblCantidadStock"
        Me.LblCantidadStock.Size = New System.Drawing.Size(139, 22)
        Me.LblCantidadStock.TabIndex = 17
        Me.LblCantidadStock.Text = "Cantidad Stock:"
        '
        'TxtAgregar
        '
        Me.TxtAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtAgregar.Location = New System.Drawing.Point(304, 343)
        Me.TxtAgregar.Name = "TxtAgregar"
        Me.TxtAgregar.Size = New System.Drawing.Size(172, 20)
        Me.TxtAgregar.TabIndex = 16
        Me.TxtAgregar.Text = "0"
        Me.TxtAgregar.Visible = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtPrecio.Location = New System.Drawing.Point(304, 299)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(172, 20)
        Me.TxtPrecio.TabIndex = 15
        '
        'TxtCantidadStock
        '
        Me.TxtCantidadStock.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtCantidadStock.Location = New System.Drawing.Point(304, 223)
        Me.TxtCantidadStock.Name = "TxtCantidadStock"
        Me.TxtCantidadStock.Size = New System.Drawing.Size(172, 20)
        Me.TxtCantidadStock.TabIndex = 14
        '
        'TxtCosto
        '
        Me.TxtCosto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtCosto.Location = New System.Drawing.Point(304, 261)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(172, 20)
        Me.TxtCosto.TabIndex = 13
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.BackColor = System.Drawing.Color.Olive
        Me.LblProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(55, 95)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(88, 22)
        Me.LblProducto.TabIndex = 12
        Me.LblProducto.Text = "Producto:"
        '
        'Cb_Nom_Producto
        '
        Me.Cb_Nom_Producto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Cb_Nom_Producto.FormattingEnabled = True
        Me.Cb_Nom_Producto.Location = New System.Drawing.Point(220, 94)
        Me.Cb_Nom_Producto.Name = "Cb_Nom_Producto"
        Me.Cb_Nom_Producto.Size = New System.Drawing.Size(301, 21)
        Me.Cb_Nom_Producto.TabIndex = 11
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Olive
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblCodigo.Location = New System.Drawing.Point(53, 136)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(67, 22)
        Me.LblCodigo.TabIndex = 26
        Me.LblCodigo.Text = "Codigo"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtCodigo.Location = New System.Drawing.Point(302, 138)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(172, 20)
        Me.TxtCodigo.TabIndex = 27
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Location = New System.Drawing.Point(2, 404)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(92, 27)
        Me.Btn_Nuevo.TabIndex = 28
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(100, 404)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(92, 27)
        Me.Btn_Actualizar.TabIndex = 29
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(198, 404)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(92, 27)
        Me.Btn_Guardar.TabIndex = 30
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(394, 404)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(92, 27)
        Me.Btn_Eliminar.TabIndex = 31
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        Me.Btn_Eliminar.Visible = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Olive
        Me.LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblNombre.Location = New System.Drawing.Point(53, 175)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(73, 22)
        Me.LblNombre.TabIndex = 32
        Me.LblNombre.Text = "Nombre"
        Me.LblNombre.Visible = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtNombre.Location = New System.Drawing.Point(302, 175)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(172, 20)
        Me.TxtNombre.TabIndex = 33
        Me.TxtNombre.Visible = False
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DB_PUNTO_VENTA\DB_PUNTO_VENTA1.md" & _
    "b"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(296, 404)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(92, 27)
        Me.btnAplicar.TabIndex = 34
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        Me.btnAplicar.Visible = False
        '
        'Frm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(609, 467)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.Btn_Regresar)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblAgregar)
        Me.Controls.Add(Me.LblCantidadStock)
        Me.Controls.Add(Me.TxtAgregar)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtCantidadStock)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.Cb_Nom_Producto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Regresar As System.Windows.Forms.Button
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents LblCosto As System.Windows.Forms.Label
    Friend WithEvents LblAgregar As System.Windows.Forms.Label
    Friend WithEvents LblCantidadStock As System.Windows.Forms.Label
    Friend WithEvents TxtAgregar As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantidadStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtCosto As System.Windows.Forms.TextBox
    Friend WithEvents LblProducto As System.Windows.Forms.Label
    Friend WithEvents Cb_Nom_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Cnx As System.Data.OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
End Class
