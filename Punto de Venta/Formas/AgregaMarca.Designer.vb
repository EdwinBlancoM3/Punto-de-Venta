<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregaMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregaMarca))
        Me.btnAgregaMarca = New System.Windows.Forms.Button()
        Me.txtNomMarca = New System.Windows.Forms.TextBox()
        Me.txtIdMarca = New System.Windows.Forms.Label()
        Me.lblNombreMarca = New System.Windows.Forms.Label()
        Me.lblNumMarca = New System.Windows.Forms.Label()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregaMarca
        '
        Me.btnAgregaMarca.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregaMarca.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaMarca.ForeColor = System.Drawing.Color.White
        Me.btnAgregaMarca.Location = New System.Drawing.Point(12, 306)
        Me.btnAgregaMarca.Name = "btnAgregaMarca"
        Me.btnAgregaMarca.Size = New System.Drawing.Size(103, 33)
        Me.btnAgregaMarca.TabIndex = 1
        Me.btnAgregaMarca.Text = "Agregar Marca"
        Me.btnAgregaMarca.UseVisualStyleBackColor = False
        '
        'txtNomMarca
        '
        Me.txtNomMarca.Location = New System.Drawing.Point(66, 142)
        Me.txtNomMarca.Name = "txtNomMarca"
        Me.txtNomMarca.Size = New System.Drawing.Size(294, 20)
        Me.txtNomMarca.TabIndex = 0
        '
        'txtIdMarca
        '
        Me.txtIdMarca.BackColor = System.Drawing.Color.Transparent
        Me.txtIdMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtIdMarca.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMarca.ForeColor = System.Drawing.Color.White
        Me.txtIdMarca.Location = New System.Drawing.Point(12, 32)
        Me.txtIdMarca.Name = "txtIdMarca"
        Me.txtIdMarca.Size = New System.Drawing.Size(100, 23)
        Me.txtIdMarca.TabIndex = 24
        Me.txtIdMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombreMarca
        '
        Me.lblNombreMarca.AutoSize = True
        Me.lblNombreMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreMarca.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMarca.ForeColor = System.Drawing.Color.White
        Me.lblNombreMarca.Location = New System.Drawing.Point(102, 105)
        Me.lblNombreMarca.Name = "lblNombreMarca"
        Me.lblNombreMarca.Size = New System.Drawing.Size(178, 23)
        Me.lblNombreMarca.TabIndex = 23
        Me.lblNombreMarca.Text = "Nombre de la Marca"
        Me.lblNombreMarca.Visible = False
        '
        'lblNumMarca
        '
        Me.lblNumMarca.AutoSize = True
        Me.lblNumMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblNumMarca.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMarca.ForeColor = System.Drawing.Color.White
        Me.lblNumMarca.Location = New System.Drawing.Point(2, 9)
        Me.lblNumMarca.Name = "lblNumMarca"
        Me.lblNumMarca.Size = New System.Drawing.Size(158, 23)
        Me.lblNumMarca.TabIndex = 22
        Me.lblNumMarca.Text = "Numero de Marca"
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DB_PUNTO_VENTA\DB_PUNTO_VENTA1.md" & _
    "b"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(306, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 33)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmAgregaMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(420, 351)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAgregaMarca)
        Me.Controls.Add(Me.txtNomMarca)
        Me.Controls.Add(Me.txtIdMarca)
        Me.Controls.Add(Me.lblNombreMarca)
        Me.Controls.Add(Me.lblNumMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 50)
        Me.Name = "frmAgregaMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Nueva Marca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregaMarca As System.Windows.Forms.Button
    Friend WithEvents txtNomMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMarca As System.Windows.Forms.Label
    Friend WithEvents lblNombreMarca As System.Windows.Forms.Label
    Friend WithEvents lblNumMarca As System.Windows.Forms.Label
    Friend WithEvents Cnx As System.Data.OleDb.OleDbConnection
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
