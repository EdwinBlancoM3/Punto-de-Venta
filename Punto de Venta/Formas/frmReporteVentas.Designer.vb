<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteVentas))
        Me.dgvDetVentas = New System.Windows.Forms.DataGridView()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.cbVentas = New System.Windows.Forms.ComboBox()
        Me.lblNoVenta = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        CType(Me.dgvDetVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetVentas
        '
        Me.dgvDetVentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetVentas.Location = New System.Drawing.Point(28, 98)
        Me.dgvDetVentas.Name = "dgvDetVentas"
        Me.dgvDetVentas.Size = New System.Drawing.Size(465, 188)
        Me.dgvDetVentas.TabIndex = 2
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DB_PUNTO_VENTA\DB_PUNTO_VENTA1.md" & _
    "b"
        '
        'cbVentas
        '
        Me.cbVentas.FormattingEnabled = True
        Me.cbVentas.Location = New System.Drawing.Point(107, 54)
        Me.cbVentas.Name = "cbVentas"
        Me.cbVentas.Size = New System.Drawing.Size(155, 21)
        Me.cbVentas.TabIndex = 4
        '
        'lblNoVenta
        '
        Me.lblNoVenta.AutoSize = True
        Me.lblNoVenta.BackColor = System.Drawing.Color.Transparent
        Me.lblNoVenta.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoVenta.ForeColor = System.Drawing.Color.White
        Me.lblNoVenta.Location = New System.Drawing.Point(119, 29)
        Me.lblNoVenta.Name = "lblNoVenta"
        Me.lblNoVenta.Size = New System.Drawing.Size(129, 19)
        Me.lblNoVenta.TabIndex = 5
        Me.lblNoVenta.Text = "Numero de Venta"
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtFecha.Location = New System.Drawing.Point(295, 54)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(144, 23)
        Me.txtFecha.TabIndex = 6
        Me.txtFecha.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtImporte
        '
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtImporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtImporte.Location = New System.Drawing.Point(217, 306)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(144, 23)
        Me.txtImporte.TabIndex = 7
        Me.txtImporte.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.BackColor = System.Drawing.Color.Transparent
        Me.LbFecha.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.White
        Me.LbFecha.Location = New System.Drawing.Point(301, 29)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(126, 19)
        Me.LbFecha.TabIndex = 8
        Me.LbFecha.Text = "Fecha de la Venta"
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.BackColor = System.Drawing.Color.Transparent
        Me.LbImporte.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.ForeColor = System.Drawing.Color.White
        Me.LbImporte.Location = New System.Drawing.Point(39, 310)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(142, 19)
        Me.LbImporte.TabIndex = 9
        Me.LbImporte.Text = "Importe de la Venta"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(434, 439)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Green
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(203, 403)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 11
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'frmReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(582, 496)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LbImporte)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblNoVenta)
        Me.Controls.Add(Me.cbVentas)
        Me.Controls.Add(Me.dgvDetVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.dgvDetVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetVentas As System.Windows.Forms.DataGridView
    Friend WithEvents Cnx As System.Data.OleDb.OleDbConnection
    Friend WithEvents cbVentas As System.Windows.Forms.ComboBox
    Friend WithEvents lblNoVenta As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.Label
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents LbImporte As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
