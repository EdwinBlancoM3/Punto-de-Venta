<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportes))
        Me.btnReporteFecha = New System.Windows.Forms.PictureBox()
        Me.btnReorden = New System.Windows.Forms.PictureBox()
        Me.gbVentas = New System.Windows.Forms.GroupBox()
        Me.lblRpVentas = New System.Windows.Forms.Label()
        Me.lblRpDetVentas = New System.Windows.Forms.Label()
        Me.btnReporteTotal = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.picExistencias = New System.Windows.Forms.PictureBox()
        Me.lblResurtir = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.btnReporteFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReorden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVentas.SuspendLayout()
        CType(Me.btnReporteTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReporteFecha
        '
        Me.btnReporteFecha.Image = CType(resources.GetObject("btnReporteFecha.Image"), System.Drawing.Image)
        Me.btnReporteFecha.Location = New System.Drawing.Point(15, 88)
        Me.btnReporteFecha.Name = "btnReporteFecha"
        Me.btnReporteFecha.Size = New System.Drawing.Size(100, 74)
        Me.btnReporteFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReporteFecha.TabIndex = 2
        Me.btnReporteFecha.TabStop = False
        '
        'btnReorden
        '
        Me.btnReorden.Image = CType(resources.GetObject("btnReorden.Image"), System.Drawing.Image)
        Me.btnReorden.Location = New System.Drawing.Point(6, 242)
        Me.btnReorden.Name = "btnReorden"
        Me.btnReorden.Size = New System.Drawing.Size(112, 90)
        Me.btnReorden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReorden.TabIndex = 3
        Me.btnReorden.TabStop = False
        '
        'gbVentas
        '
        Me.gbVentas.BackColor = System.Drawing.Color.Transparent
        Me.gbVentas.Controls.Add(Me.lblRpVentas)
        Me.gbVentas.Controls.Add(Me.lblRpDetVentas)
        Me.gbVentas.Controls.Add(Me.btnReporteTotal)
        Me.gbVentas.Controls.Add(Me.btnReporteFecha)
        Me.gbVentas.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVentas.ForeColor = System.Drawing.Color.White
        Me.gbVentas.Location = New System.Drawing.Point(12, 12)
        Me.gbVentas.Name = "gbVentas"
        Me.gbVentas.Size = New System.Drawing.Size(455, 406)
        Me.gbVentas.TabIndex = 4
        Me.gbVentas.TabStop = False
        Me.gbVentas.Text = "Ventas"
        '
        'lblRpVentas
        '
        Me.lblRpVentas.AutoSize = True
        Me.lblRpVentas.Location = New System.Drawing.Point(128, 139)
        Me.lblRpVentas.Name = "lblRpVentas"
        Me.lblRpVentas.Size = New System.Drawing.Size(162, 23)
        Me.lblRpVentas.TabIndex = 9
        Me.lblRpVentas.Text = "Reporte de Ventas"
        '
        'lblRpDetVentas
        '
        Me.lblRpDetVentas.AutoSize = True
        Me.lblRpDetVentas.Location = New System.Drawing.Point(121, 293)
        Me.lblRpDetVentas.Name = "lblRpDetVentas"
        Me.lblRpDetVentas.Size = New System.Drawing.Size(217, 23)
        Me.lblRpDetVentas.TabIndex = 8
        Me.lblRpDetVentas.Text = "Reporte Detalle de venta"
        '
        'btnReporteTotal
        '
        Me.btnReporteTotal.Image = CType(resources.GetObject("btnReporteTotal.Image"), System.Drawing.Image)
        Me.btnReporteTotal.Location = New System.Drawing.Point(15, 242)
        Me.btnReporteTotal.Name = "btnReporteTotal"
        Me.btnReporteTotal.Size = New System.Drawing.Size(100, 74)
        Me.btnReporteTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReporteTotal.TabIndex = 3
        Me.btnReporteTotal.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblExistencias)
        Me.GroupBox2.Controls.Add(Me.picExistencias)
        Me.GroupBox2.Controls.Add(Me.lblResurtir)
        Me.GroupBox2.Controls.Add(Me.btnReorden)
        Me.GroupBox2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(473, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 406)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventario"
        '
        'lblExistencias
        '
        Me.lblExistencias.AutoSize = True
        Me.lblExistencias.Location = New System.Drawing.Point(133, 125)
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Size = New System.Drawing.Size(199, 23)
        Me.lblExistencias.TabIndex = 7
        Me.lblExistencias.Text = "Reporte de Existencias"
        '
        'picExistencias
        '
        Me.picExistencias.Image = CType(resources.GetObject("picExistencias.Image"), System.Drawing.Image)
        Me.picExistencias.Location = New System.Drawing.Point(6, 72)
        Me.picExistencias.Name = "picExistencias"
        Me.picExistencias.Size = New System.Drawing.Size(112, 90)
        Me.picExistencias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExistencias.TabIndex = 6
        Me.picExistencias.TabStop = False
        '
        'lblResurtir
        '
        Me.lblResurtir.AutoSize = True
        Me.lblResurtir.Location = New System.Drawing.Point(145, 298)
        Me.lblResurtir.Name = "lblResurtir"
        Me.lblResurtir.Size = New System.Drawing.Size(187, 23)
        Me.lblResurtir.TabIndex = 4
        Me.lblResurtir.Text = "Reporte de Resurtido"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(434, 441)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(920, 476)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportes"
        CType(Me.btnReporteFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReorden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVentas.ResumeLayout(False)
        Me.gbVentas.PerformLayout()
        CType(Me.btnReporteTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReporteFecha As System.Windows.Forms.PictureBox
    Friend WithEvents btnReorden As System.Windows.Forms.PictureBox
    Friend WithEvents gbVentas As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExistencias As System.Windows.Forms.Label
    Friend WithEvents picExistencias As System.Windows.Forms.PictureBox
    Friend WithEvents lblResurtir As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnReporteTotal As System.Windows.Forms.PictureBox
    Friend WithEvents lblRpVentas As System.Windows.Forms.Label
    Friend WithEvents lblRpDetVentas As System.Windows.Forms.Label
End Class
