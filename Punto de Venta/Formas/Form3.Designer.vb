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
        Me.Cb_Nom_Producto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBox_Costo = New System.Windows.Forms.TextBox()
        Me.TxtBox_Stock = New System.Windows.Forms.TextBox()
        Me.Txt_Precio = New System.Windows.Forms.TextBox()
        Me.TxtBox_Agregar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cb_Nom_Producto
        '
        Me.Cb_Nom_Producto.FormattingEnabled = True
        Me.Cb_Nom_Producto.Location = New System.Drawing.Point(139, 52)
        Me.Cb_Nom_Producto.Name = "Cb_Nom_Producto"
        Me.Cb_Nom_Producto.Size = New System.Drawing.Size(301, 21)
        Me.Cb_Nom_Producto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto:"
        '
        'TxtBox_Costo
        '
        Me.TxtBox_Costo.Location = New System.Drawing.Point(268, 228)
        Me.TxtBox_Costo.Name = "TxtBox_Costo"
        Me.TxtBox_Costo.Size = New System.Drawing.Size(172, 20)
        Me.TxtBox_Costo.TabIndex = 2
        '
        'TxtBox_Stock
        '
        Me.TxtBox_Stock.Location = New System.Drawing.Point(268, 108)
        Me.TxtBox_Stock.Name = "TxtBox_Stock"
        Me.TxtBox_Stock.Size = New System.Drawing.Size(172, 20)
        Me.TxtBox_Stock.TabIndex = 3
        '
        'Txt_Precio
        '
        Me.Txt_Precio.Location = New System.Drawing.Point(268, 282)
        Me.Txt_Precio.Name = "Txt_Precio"
        Me.Txt_Precio.Size = New System.Drawing.Size(172, 20)
        Me.Txt_Precio.TabIndex = 4
        '
        'TxtBox_Agregar
        '
        Me.TxtBox_Agregar.Location = New System.Drawing.Point(268, 170)
        Me.TxtBox_Agregar.Name = "TxtBox_Agregar"
        Me.TxtBox_Agregar.Size = New System.Drawing.Size(172, 20)
        Me.TxtBox_Agregar.TabIndex = 5
        Me.TxtBox_Agregar.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(16, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cantidad Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(16, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Agregar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Costo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(16, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio:"
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.Location = New System.Drawing.Point(356, 371)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(84, 32)
        Me.Btn_Regresar.TabIndex = 10
        Me.Btn_Regresar.Text = "Regresar"
        Me.Btn_Regresar.UseVisualStyleBackColor = True
        '
        'Frm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 443)
        Me.Controls.Add(Me.Btn_Regresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_Agregar)
        Me.Controls.Add(Me.Txt_Precio)
        Me.Controls.Add(Me.TxtBox_Stock)
        Me.Controls.Add(Me.TxtBox_Costo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cb_Nom_Producto)
        Me.Name = "Frm_Inventario"
        Me.Text = "Agregar Producto a Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cb_Nom_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBox_Costo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Stock As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Precio As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Agregar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Regresar As System.Windows.Forms.Button
End Class
