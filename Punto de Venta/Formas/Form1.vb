Public Class FrmInicio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Inventario.Click
        Me.Hide()
        Frm_Marcas.Show()

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        End
    End Sub
End Class