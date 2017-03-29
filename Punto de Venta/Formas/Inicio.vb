Public Class FrmInicio

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Frm_Marcas.Show()

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim a, b As Decimal
        'For a = 0 To 10
        '    b = a / 10
        '    Me.Opacity = b
        '    Me.Refresh()
        'Next
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Private Sub Btn_PuntoDeVenta_Click(sender As Object, e As EventArgs)
        frmVentas.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Frm_Marcas.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles btnPunto.Click
        frmVentas.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        frmReportes.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Acerca.Show()
    End Sub
End Class