<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Marcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Marcas))
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.lblIDMARCA = New System.Windows.Forms.Label()
        Me.lblSeleccioneMarca = New System.Windows.Forms.Label()
        Me.btnRefreshMarcas = New System.Windows.Forms.Button()
        Me.btnEliminarMarca = New System.Windows.Forms.Button()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnAgregarProducto = New System.Windows.Forms.ToolStripButton()
        Me.BtnActualizarProducto = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminarProducto = New System.Windows.Forms.ToolStripButton()
        Me.BtnConsultarPoducto = New System.Windows.Forms.ToolStripButton()
        Me.BtnConsultarMarcaProducto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnAgregarMarca = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.BackColor = System.Drawing.Color.DarkBlue
        Me.Btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Regresar.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Regresar.Location = New System.Drawing.Point(373, 443)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(135, 34)
        Me.Btn_Regresar.TabIndex = 12
        Me.Btn_Regresar.Text = "Menu Principal"
        Me.Btn_Regresar.UseVisualStyleBackColor = False
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
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(12, 88)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(294, 21)
        Me.cbMarca.TabIndex = 14
        '
        'lblIDMARCA
        '
        Me.lblIDMARCA.AutoSize = True
        Me.lblIDMARCA.Location = New System.Drawing.Point(154, 160)
        Me.lblIDMARCA.Name = "lblIDMARCA"
        Me.lblIDMARCA.Size = New System.Drawing.Size(0, 13)
        Me.lblIDMARCA.TabIndex = 15
        Me.lblIDMARCA.Visible = False
        '
        'lblSeleccioneMarca
        '
        Me.lblSeleccioneMarca.AutoSize = True
        Me.lblSeleccioneMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblSeleccioneMarca.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSeleccioneMarca.Location = New System.Drawing.Point(106, 66)
        Me.lblSeleccioneMarca.Name = "lblSeleccioneMarca"
        Me.lblSeleccioneMarca.Size = New System.Drawing.Size(156, 19)
        Me.lblSeleccioneMarca.TabIndex = 16
        Me.lblSeleccioneMarca.Text = "Seleccione una Marca"
        '
        'btnRefreshMarcas
        '
        Me.btnRefreshMarcas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRefreshMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefreshMarcas.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshMarcas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefreshMarcas.Location = New System.Drawing.Point(12, 115)
        Me.btnRefreshMarcas.Name = "btnRefreshMarcas"
        Me.btnRefreshMarcas.Size = New System.Drawing.Size(75, 44)
        Me.btnRefreshMarcas.TabIndex = 17
        Me.btnRefreshMarcas.Text = "Actualizar Listado"
        Me.btnRefreshMarcas.UseVisualStyleBackColor = False
        Me.btnRefreshMarcas.Visible = False
        '
        'btnEliminarMarca
        '
        Me.btnEliminarMarca.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarMarca.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarMarca.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarMarca.Location = New System.Drawing.Point(157, 115)
        Me.btnEliminarMarca.Name = "btnEliminarMarca"
        Me.btnEliminarMarca.Size = New System.Drawing.Size(176, 38)
        Me.btnEliminarMarca.TabIndex = 18
        Me.btnEliminarMarca.Text = "Eliminar Marca"
        Me.btnEliminarMarca.UseVisualStyleBackColor = False
        Me.btnEliminarMarca.Visible = False
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.EnableHeadersVisualStyles = False
        Me.dgvConsulta.Location = New System.Drawing.Point(339, 52)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.ReadOnly = True
        Me.dgvConsulta.Size = New System.Drawing.Size(628, 386)
        Me.dgvConsulta.TabIndex = 19
        Me.dgvConsulta.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnAgregarProducto, Me.BtnActualizarProducto, Me.BtnEliminarProducto, Me.BtnConsultarPoducto, Me.BtnConsultarMarcaProducto, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.btnAgregarMarca, Me.btnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 29)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 26)
        Me.ToolStripLabel1.Text = "Producto"
        '
        'BtnAgregarProducto
        '
        Me.BtnAgregarProducto.AutoSize = False
        Me.BtnAgregarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAgregarProducto.Image = CType(resources.GetObject("BtnAgregarProducto.Image"), System.Drawing.Image)
        Me.BtnAgregarProducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(30, 40)
        Me.BtnAgregarProducto.Text = "Agregar Producto"
        '
        'BtnActualizarProducto
        '
        Me.BtnActualizarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnActualizarProducto.Image = CType(resources.GetObject("BtnActualizarProducto.Image"), System.Drawing.Image)
        Me.BtnActualizarProducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnActualizarProducto.Name = "BtnActualizarProducto"
        Me.BtnActualizarProducto.Size = New System.Drawing.Size(23, 26)
        Me.BtnActualizarProducto.Text = "Actualizar Producto"
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminarProducto.Image = CType(resources.GetObject("BtnEliminarProducto.Image"), System.Drawing.Image)
        Me.BtnEliminarProducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.Size = New System.Drawing.Size(23, 26)
        Me.BtnEliminarProducto.Text = "Eliminar Producto"
        '
        'BtnConsultarPoducto
        '
        Me.BtnConsultarPoducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnConsultarPoducto.Image = CType(resources.GetObject("BtnConsultarPoducto.Image"), System.Drawing.Image)
        Me.BtnConsultarPoducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultarPoducto.Name = "BtnConsultarPoducto"
        Me.BtnConsultarPoducto.Size = New System.Drawing.Size(23, 26)
        Me.BtnConsultarPoducto.Text = "Consultar Productos Existentes"
        '
        'BtnConsultarMarcaProducto
        '
        Me.BtnConsultarMarcaProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnConsultarMarcaProducto.Image = CType(resources.GetObject("BtnConsultarMarcaProducto.Image"), System.Drawing.Image)
        Me.BtnConsultarMarcaProducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultarMarcaProducto.Name = "BtnConsultarMarcaProducto"
        Me.BtnConsultarMarcaProducto.Size = New System.Drawing.Size(23, 26)
        Me.BtnConsultarMarcaProducto.Text = "Consultar Por  Marca"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(51, 26)
        Me.ToolStripLabel2.Text = "Marca"
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAgregarMarca.Image = CType(resources.GetObject("btnAgregarMarca.Image"), System.Drawing.Image)
        Me.btnAgregarMarca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(23, 26)
        Me.btnAgregarMarca.Text = "Agregar Marca"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 26)
        Me.btnEliminar.Text = "Eliminar"
        '
        'Frm_Marcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 489)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvConsulta)
        Me.Controls.Add(Me.btnEliminarMarca)
        Me.Controls.Add(Me.btnRefreshMarcas)
        Me.Controls.Add(Me.lblSeleccioneMarca)
        Me.Controls.Add(Me.lblIDMARCA)
        Me.Controls.Add(Me.cbMarca)
        Me.Controls.Add(Me.Btn_Regresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Marcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas"
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Regresar As System.Windows.Forms.Button
    Friend WithEvents Cnx As System.Data.OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents lblIDMARCA As System.Windows.Forms.Label
    Friend WithEvents lblSeleccioneMarca As System.Windows.Forms.Label
    Friend WithEvents btnRefreshMarcas As System.Windows.Forms.Button
    Friend WithEvents btnEliminarMarca As System.Windows.Forms.Button
    Friend WithEvents dgvConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAgregarProducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnActualizarProducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEliminarProducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnConsultarPoducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnConsultarMarcaProducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAgregarMarca As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
End Class
