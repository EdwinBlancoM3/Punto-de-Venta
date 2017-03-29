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
        Me.Btn_PuntoDeVenta = New System.Windows.Forms.Button()
        Me.Btn_Inventario = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_PuntoDeVenta
        '
        Me.Btn_PuntoDeVenta.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.PuntoVenta
        Me.Btn_PuntoDeVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_PuntoDeVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PuntoDeVenta.Location = New System.Drawing.Point(318, 152)
        Me.Btn_PuntoDeVenta.Name = "Btn_PuntoDeVenta"
        Me.Btn_PuntoDeVenta.Size = New System.Drawing.Size(145, 125)
        Me.Btn_PuntoDeVenta.TabIndex = 1
        Me.Btn_PuntoDeVenta.Text = "Punto de Venta"
        Me.Btn_PuntoDeVenta.UseVisualStyleBackColor = True
        '
        'Btn_Inventario
        '
        Me.Btn_Inventario.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Inventario.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Inventario
        Me.Btn_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inventario.Location = New System.Drawing.Point(81, 152)
        Me.Btn_Inventario.Name = "Btn_Inventario"
        Me.Btn_Inventario.Size = New System.Drawing.Size(145, 125)
        Me.Btn_Inventario.TabIndex = 0
        Me.Btn_Inventario.Text = "Inventario"
        Me.Btn_Inventario.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(388, 402)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 2
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(547, 452)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_PuntoDeVenta)
        Me.Controls.Add(Me.Btn_Inventario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto De Venta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Inventario As System.Windows.Forms.Button
    Friend WithEvents Btn_PuntoDeVenta As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
