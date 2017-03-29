<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.PictureBox()
        Me.btnPunto = New System.Windows.Forms.PictureBox()
        Me.lblPuntoDeVenta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReportes = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.btnInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.Red
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Salir.Location = New System.Drawing.Point(730, 410)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 2
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.Transparent
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.Location = New System.Drawing.Point(122, 161)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(145, 115)
        Me.btnInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInventario.TabIndex = 3
        Me.btnInventario.TabStop = False
        '
        'btnPunto
        '
        Me.btnPunto.BackColor = System.Drawing.Color.Transparent
        Me.btnPunto.Image = CType(resources.GetObject("btnPunto.Image"), System.Drawing.Image)
        Me.btnPunto.Location = New System.Drawing.Point(352, 161)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(145, 115)
        Me.btnPunto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPunto.TabIndex = 4
        Me.btnPunto.TabStop = False
        '
        'lblPuntoDeVenta
        '
        Me.lblPuntoDeVenta.AutoSize = True
        Me.lblPuntoDeVenta.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntoDeVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntoDeVenta.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblPuntoDeVenta.Location = New System.Drawing.Point(364, 279)
        Me.lblPuntoDeVenta.Name = "lblPuntoDeVenta"
        Me.lblPuntoDeVenta.Size = New System.Drawing.Size(123, 20)
        Me.lblPuntoDeVenta.TabIndex = 5
        Me.lblPuntoDeVenta.Text = "Punto De Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.Location = New System.Drawing.Point(154, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Inventario"
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.Location = New System.Drawing.Point(582, 161)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(145, 115)
        Me.btnReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReportes.TabIndex = 8
        Me.btnReportes.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label2.Location = New System.Drawing.Point(578, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Reportes de Ventas"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(612, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(229, 23)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Acerca de M3Technologies"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 458)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPuntoDeVenta)
        Me.Controls.Add(Me.btnPunto)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.Btn_Salir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto De Venta"
        CType(Me.btnInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btnInventario As System.Windows.Forms.PictureBox
    Friend WithEvents btnPunto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPuntoDeVenta As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReportes As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
