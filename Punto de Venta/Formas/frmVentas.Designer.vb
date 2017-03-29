<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.dgvTicket = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.lblImorte = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblPagaCon = New System.Windows.Forms.Label()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.txtCambio = New System.Windows.Forms.Label()
        Me.txtPagoCon = New System.Windows.Forms.TextBox()
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblCodigo.Location = New System.Drawing.Point(12, 40)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(69, 23)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "Codigo"
        '
        'lblCantidad
        '
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblCantidad.Location = New System.Drawing.Point(12, 84)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(100, 23)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.LightBlue
        Me.txtCodigo.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCodigo.Location = New System.Drawing.Point(98, 44)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(205, 27)
        Me.txtCodigo.TabIndex = 0
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.LightBlue
        Me.txtCantidad.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCantidad.Location = New System.Drawing.Point(183, 84)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(120, 27)
        Me.txtCantidad.TabIndex = 1
        '
        'dgvTicket
        '
        Me.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTicket.BackgroundColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTicket.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Precio, Me.Cantidad, Me.Cantidad_Stock, Me.resto, Me.Subtotal, Me.btnQuitar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTicket.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTicket.EnableHeadersVisualStyles = False
        Me.dgvTicket.Location = New System.Drawing.Point(12, 117)
        Me.dgvTicket.Name = "dgvTicket"
        Me.dgvTicket.ReadOnly = True
        Me.dgvTicket.Size = New System.Drawing.Size(814, 327)
        Me.dgvTicket.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 83
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 92
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 78
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 96
        '
        'Cantidad_Stock
        '
        Me.Cantidad_Stock.HeaderText = "Cantidad Stock"
        Me.Cantidad_Stock.Name = "Cantidad_Stock"
        Me.Cantidad_Stock.ReadOnly = True
        Me.Cantidad_Stock.Width = 126
        '
        'resto
        '
        Me.resto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.resto.HeaderText = "Restarian"
        Me.resto.Name = "resto"
        Me.resto.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Sub"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 61
        '
        'btnQuitar
        '
        Me.btnQuitar.HeaderText = "Quitar Producto"
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.ReadOnly = True
        Me.btnQuitar.Text = "quitar"
        Me.btnQuitar.UseColumnTextForButtonValue = True
        Me.btnQuitar.Width = 115
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DB_PUNTO_VENTA\DB_PUNTO_VENTA1.md" & _
    "b"
        '
        'lblImorte
        '
        Me.lblImorte.AutoSize = True
        Me.lblImorte.BackColor = System.Drawing.Color.Transparent
        Me.lblImorte.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImorte.ForeColor = System.Drawing.SystemColors.Control
        Me.lblImorte.Location = New System.Drawing.Point(860, 9)
        Me.lblImorte.Name = "lblImorte"
        Me.lblImorte.Size = New System.Drawing.Size(142, 23)
        Me.lblImorte.TabIndex = 11
        Me.lblImorte.Text = "Importe a Pagar"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotal.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(861, 32)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(184, 46)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCobrar.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCobrar.Location = New System.Drawing.Point(853, 403)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(72, 41)
        Me.btnCobrar.TabIndex = 5
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(957, 403)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 41)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar Venta"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblPagaCon
        '
        Me.lblPagaCon.AutoSize = True
        Me.lblPagaCon.BackColor = System.Drawing.Color.Transparent
        Me.lblPagaCon.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagaCon.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPagaCon.Location = New System.Drawing.Point(857, 113)
        Me.lblPagaCon.Name = "lblPagaCon"
        Me.lblPagaCon.Size = New System.Drawing.Size(77, 23)
        Me.lblPagaCon.TabIndex = 12
        Me.lblPagaCon.Text = "Efectivo"
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.BackColor = System.Drawing.Color.Transparent
        Me.lblCambio.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCambio.Location = New System.Drawing.Point(860, 192)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(74, 23)
        Me.lblCambio.TabIndex = 5
        Me.lblCambio.Text = "Cambio"
        '
        'txtCambio
        '
        Me.txtCambio.BackColor = System.Drawing.SystemColors.Control
        Me.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCambio.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio.ForeColor = System.Drawing.Color.Green
        Me.txtCambio.Location = New System.Drawing.Point(861, 215)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(184, 46)
        Me.txtCambio.TabIndex = 4
        Me.txtCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPagoCon
        '
        Me.txtPagoCon.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagoCon.Location = New System.Drawing.Point(861, 139)
        Me.txtPagoCon.Name = "txtPagoCon"
        Me.txtPagoCon.Size = New System.Drawing.Size(184, 33)
        Me.txtPagoCon.TabIndex = 3
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.BackColor = System.Drawing.Color.DarkBlue
        Me.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Regresar.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Regresar.Location = New System.Drawing.Point(476, 482)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(135, 34)
        Me.Btn_Regresar.TabIndex = 7
        Me.Btn_Regresar.Text = "Menu Principal"
        Me.Btn_Regresar.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1086, 544)
        Me.Controls.Add(Me.Btn_Regresar)
        Me.Controls.Add(Me.txtPagoCon)
        Me.Controls.Add(Me.txtCambio)
        Me.Controls.Add(Me.lblCambio)
        Me.Controls.Add(Me.lblPagaCon)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblImorte)
        Me.Controls.Add(Me.dgvTicket)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto de Venta"
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents dgvTicket As System.Windows.Forms.DataGridView
    Friend WithEvents Cnx As System.Data.OleDb.OleDbConnection
    Friend WithEvents lblImorte As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblPagaCon As System.Windows.Forms.Label
    Friend WithEvents lblCambio As System.Windows.Forms.Label
    Friend WithEvents txtCambio As System.Windows.Forms.Label
    Friend WithEvents txtPagoCon As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Regresar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnQuitar As System.Windows.Forms.DataGridViewButtonColumn
End Class
