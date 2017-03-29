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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Marcas))
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        Me.Btn_OtrasMarcas = New System.Windows.Forms.Button()
        Me.Btn_Jumex = New System.Windows.Forms.Button()
        Me.Btn_Danone = New System.Windows.Forms.Button()
        Me.Btn_SelloRojo = New System.Windows.Forms.Button()
        Me.Btn_Sonrics = New System.Windows.Forms.Button()
        Me.Btn_Ricolino = New System.Windows.Forms.Button()
        Me.Btn_MilpaReal = New System.Windows.Forms.Button()
        Me.Btn_TiaRosa = New System.Windows.Forms.Button()
        Me.Btn_Tecate = New System.Windows.Forms.Button()
        Me.Btn_Corona = New System.Windows.Forms.Button()
        Me.Btn_Nestle = New System.Windows.Forms.Button()
        Me.Btn_Lala = New System.Windows.Forms.Button()
        Me.Btn_Marinela = New System.Windows.Forms.Button()
        Me.Btn_Pepsi = New System.Windows.Forms.Button()
        Me.Btn_Sabritas = New System.Windows.Forms.Button()
        Me.Btn_Gamesa = New System.Windows.Forms.Button()
        Me.Btn_Cocacola = New System.Windows.Forms.Button()
        Me.Btn_Bimbo = New System.Windows.Forms.Button()
        Me.Btn_Barcel = New System.Windows.Forms.Button()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Regresar.Location = New System.Drawing.Point(934, 593)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(120, 59)
        Me.Btn_Regresar.TabIndex = 12
        Me.Btn_Regresar.Text = "Regresar"
        Me.Btn_Regresar.UseVisualStyleBackColor = True
        '
        'Btn_OtrasMarcas
        '
        Me.Btn_OtrasMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OtrasMarcas.Location = New System.Drawing.Point(888, 372)
        Me.Btn_OtrasMarcas.Name = "Btn_OtrasMarcas"
        Me.Btn_OtrasMarcas.Size = New System.Drawing.Size(198, 154)
        Me.Btn_OtrasMarcas.TabIndex = 18
        Me.Btn_OtrasMarcas.Text = "Otras Marcas"
        Me.Btn_OtrasMarcas.UseVisualStyleBackColor = True
        '
        'Btn_Jumex
        '
        Me.Btn_Jumex.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.jumex
        Me.Btn_Jumex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Jumex.Location = New System.Drawing.Point(675, 546)
        Me.Btn_Jumex.Name = "Btn_Jumex"
        Me.Btn_Jumex.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Jumex.TabIndex = 19
        Me.Btn_Jumex.UseVisualStyleBackColor = True
        '
        'Btn_Danone
        '
        Me.Btn_Danone.BackColor = System.Drawing.Color.White
        Me.Btn_Danone.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Danone
        Me.Btn_Danone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Danone.Location = New System.Drawing.Point(888, 199)
        Me.Btn_Danone.Name = "Btn_Danone"
        Me.Btn_Danone.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Danone.TabIndex = 17
        Me.Btn_Danone.UseVisualStyleBackColor = False
        '
        'Btn_SelloRojo
        '
        Me.Btn_SelloRojo.BackColor = System.Drawing.Color.White
        Me.Btn_SelloRojo.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Sello_Rojo
        Me.Btn_SelloRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_SelloRojo.Location = New System.Drawing.Point(888, 26)
        Me.Btn_SelloRojo.Name = "Btn_SelloRojo"
        Me.Btn_SelloRojo.Size = New System.Drawing.Size(198, 154)
        Me.Btn_SelloRojo.TabIndex = 16
        Me.Btn_SelloRojo.UseVisualStyleBackColor = False
        '
        'Btn_Sonrics
        '
        Me.Btn_Sonrics.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Sonrics
        Me.Btn_Sonrics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Sonrics.Location = New System.Drawing.Point(462, 546)
        Me.Btn_Sonrics.Name = "Btn_Sonrics"
        Me.Btn_Sonrics.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Sonrics.TabIndex = 15
        Me.Btn_Sonrics.UseVisualStyleBackColor = True
        '
        'Btn_Ricolino
        '
        Me.Btn_Ricolino.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Ricolino
        Me.Btn_Ricolino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Ricolino.Location = New System.Drawing.Point(249, 546)
        Me.Btn_Ricolino.Name = "Btn_Ricolino"
        Me.Btn_Ricolino.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Ricolino.TabIndex = 14
        Me.Btn_Ricolino.UseVisualStyleBackColor = True
        '
        'Btn_MilpaReal
        '
        Me.Btn_MilpaReal.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Milpa_Real
        Me.Btn_MilpaReal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_MilpaReal.Location = New System.Drawing.Point(36, 546)
        Me.Btn_MilpaReal.Name = "Btn_MilpaReal"
        Me.Btn_MilpaReal.Size = New System.Drawing.Size(198, 154)
        Me.Btn_MilpaReal.TabIndex = 13
        Me.Btn_MilpaReal.UseVisualStyleBackColor = True
        '
        'Btn_TiaRosa
        '
        Me.Btn_TiaRosa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Tia_Rosa
        Me.Btn_TiaRosa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_TiaRosa.Location = New System.Drawing.Point(675, 372)
        Me.Btn_TiaRosa.Name = "Btn_TiaRosa"
        Me.Btn_TiaRosa.Size = New System.Drawing.Size(198, 154)
        Me.Btn_TiaRosa.TabIndex = 11
        Me.Btn_TiaRosa.UseVisualStyleBackColor = True
        '
        'Btn_Tecate
        '
        Me.Btn_Tecate.BackColor = System.Drawing.Color.White
        Me.Btn_Tecate.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Tecate
        Me.Btn_Tecate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Tecate.Location = New System.Drawing.Point(462, 372)
        Me.Btn_Tecate.Name = "Btn_Tecate"
        Me.Btn_Tecate.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Tecate.TabIndex = 10
        Me.Btn_Tecate.UseVisualStyleBackColor = False
        '
        'Btn_Corona
        '
        Me.Btn_Corona.BackColor = System.Drawing.Color.White
        Me.Btn_Corona.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Corona
        Me.Btn_Corona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Corona.Location = New System.Drawing.Point(249, 372)
        Me.Btn_Corona.Name = "Btn_Corona"
        Me.Btn_Corona.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Corona.TabIndex = 9
        Me.Btn_Corona.UseVisualStyleBackColor = False
        '
        'Btn_Nestle
        '
        Me.Btn_Nestle.BackColor = System.Drawing.Color.White
        Me.Btn_Nestle.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Nestle
        Me.Btn_Nestle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Nestle.Location = New System.Drawing.Point(36, 372)
        Me.Btn_Nestle.Name = "Btn_Nestle"
        Me.Btn_Nestle.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Nestle.TabIndex = 8
        Me.Btn_Nestle.UseVisualStyleBackColor = False
        '
        'Btn_Lala
        '
        Me.Btn_Lala.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Lala
        Me.Btn_Lala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Lala.Location = New System.Drawing.Point(36, 199)
        Me.Btn_Lala.Name = "Btn_Lala"
        Me.Btn_Lala.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Lala.TabIndex = 7
        Me.Btn_Lala.UseVisualStyleBackColor = True
        '
        'Btn_Marinela
        '
        Me.Btn_Marinela.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marinela
        Me.Btn_Marinela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Marinela.Location = New System.Drawing.Point(249, 199)
        Me.Btn_Marinela.Name = "Btn_Marinela"
        Me.Btn_Marinela.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Marinela.TabIndex = 6
        Me.Btn_Marinela.UseVisualStyleBackColor = True
        '
        'Btn_Pepsi
        '
        Me.Btn_Pepsi.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Pepsi
        Me.Btn_Pepsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Pepsi.Location = New System.Drawing.Point(462, 199)
        Me.Btn_Pepsi.Name = "Btn_Pepsi"
        Me.Btn_Pepsi.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Pepsi.TabIndex = 5
        Me.Btn_Pepsi.UseVisualStyleBackColor = True
        '
        'Btn_Sabritas
        '
        Me.Btn_Sabritas.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Sabritas
        Me.Btn_Sabritas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Sabritas.Location = New System.Drawing.Point(675, 199)
        Me.Btn_Sabritas.Name = "Btn_Sabritas"
        Me.Btn_Sabritas.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Sabritas.TabIndex = 4
        Me.Btn_Sabritas.UseVisualStyleBackColor = True
        '
        'Btn_Gamesa
        '
        Me.Btn_Gamesa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.gamesa
        Me.Btn_Gamesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Gamesa.Location = New System.Drawing.Point(675, 26)
        Me.Btn_Gamesa.Name = "Btn_Gamesa"
        Me.Btn_Gamesa.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Gamesa.TabIndex = 3
        Me.Btn_Gamesa.UseVisualStyleBackColor = True
        '
        'Btn_Cocacola
        '
        Me.Btn_Cocacola.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Coca_Cola
        Me.Btn_Cocacola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Cocacola.Location = New System.Drawing.Point(462, 26)
        Me.Btn_Cocacola.Name = "Btn_Cocacola"
        Me.Btn_Cocacola.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Cocacola.TabIndex = 2
        Me.Btn_Cocacola.UseVisualStyleBackColor = True
        '
        'Btn_Bimbo
        '
        Me.Btn_Bimbo.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bimbo
        Me.Btn_Bimbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Bimbo.Location = New System.Drawing.Point(249, 26)
        Me.Btn_Bimbo.Name = "Btn_Bimbo"
        Me.Btn_Bimbo.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Bimbo.TabIndex = 1
        Me.Btn_Bimbo.UseVisualStyleBackColor = True
        '
        'Btn_Barcel
        '
        Me.Btn_Barcel.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Barcel
        Me.Btn_Barcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Barcel.Location = New System.Drawing.Point(36, 26)
        Me.Btn_Barcel.Name = "Btn_Barcel"
        Me.Btn_Barcel.Size = New System.Drawing.Size(198, 154)
        Me.Btn_Barcel.TabIndex = 0
        Me.Btn_Barcel.UseVisualStyleBackColor = True
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
        'Frm_Marcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(3, 3)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1119, 730)
        Me.Controls.Add(Me.Btn_Jumex)
        Me.Controls.Add(Me.Btn_OtrasMarcas)
        Me.Controls.Add(Me.Btn_Danone)
        Me.Controls.Add(Me.Btn_SelloRojo)
        Me.Controls.Add(Me.Btn_Sonrics)
        Me.Controls.Add(Me.Btn_Ricolino)
        Me.Controls.Add(Me.Btn_MilpaReal)
        Me.Controls.Add(Me.Btn_Regresar)
        Me.Controls.Add(Me.Btn_TiaRosa)
        Me.Controls.Add(Me.Btn_Tecate)
        Me.Controls.Add(Me.Btn_Corona)
        Me.Controls.Add(Me.Btn_Nestle)
        Me.Controls.Add(Me.Btn_Lala)
        Me.Controls.Add(Me.Btn_Marinela)
        Me.Controls.Add(Me.Btn_Pepsi)
        Me.Controls.Add(Me.Btn_Sabritas)
        Me.Controls.Add(Me.Btn_Gamesa)
        Me.Controls.Add(Me.Btn_Cocacola)
        Me.Controls.Add(Me.Btn_Bimbo)
        Me.Controls.Add(Me.Btn_Barcel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Marcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Barcel As System.Windows.Forms.Button
    Friend WithEvents Btn_Bimbo As System.Windows.Forms.Button
    Friend WithEvents Btn_Cocacola As System.Windows.Forms.Button
    Friend WithEvents Btn_Gamesa As System.Windows.Forms.Button
    Friend WithEvents Btn_Sabritas As System.Windows.Forms.Button
    Friend WithEvents Btn_Pepsi As System.Windows.Forms.Button
    Friend WithEvents Btn_Marinela As System.Windows.Forms.Button
    Friend WithEvents Btn_Lala As System.Windows.Forms.Button
    Friend WithEvents Btn_Nestle As System.Windows.Forms.Button
    Friend WithEvents Btn_Corona As System.Windows.Forms.Button
    Friend WithEvents Btn_Tecate As System.Windows.Forms.Button
    Friend WithEvents Btn_TiaRosa As System.Windows.Forms.Button
    Friend WithEvents Btn_Regresar As System.Windows.Forms.Button
    Friend WithEvents Btn_MilpaReal As System.Windows.Forms.Button
    Friend WithEvents Btn_Ricolino As System.Windows.Forms.Button
    Friend WithEvents Btn_Sonrics As System.Windows.Forms.Button
    Friend WithEvents Btn_SelloRojo As System.Windows.Forms.Button
    Friend WithEvents Btn_Danone As System.Windows.Forms.Button
    Friend WithEvents Btn_OtrasMarcas As System.Windows.Forms.Button
    Friend WithEvents Btn_Jumex As System.Windows.Forms.Button
    Friend WithEvents Cnx As System.Data.OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
