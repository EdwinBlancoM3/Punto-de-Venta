Public Class frmReportes

    Private Sub btnReorden_Click(sender As Object, e As EventArgs) Handles btnReorden.Click
        resurtir = 1
        frmResurtir.Show()
        Me.Close()
    End Sub

    Private Sub picExistencias_Click(sender As Object, e As EventArgs) Handles picExistencias.Click
        resurtir = 2
        frmResurtir.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnReporteFecha.Click
        frmReporteVentas.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FrmInicio.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnReporteTotal.Click
        frmTodasLasVentas.Show()
    End Sub

    Private Sub lblExistencias_Click(sender As Object, e As EventArgs) Handles lblExistencias.Click

    End Sub
End Class