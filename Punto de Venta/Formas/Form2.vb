Imports System.Data.OleDb
Public Class Frm_Marcas
    Private Sub Btn_Regresar_Click(sender As Object, e As EventArgs) Handles Btn_Regresar.Click
        Me.Hide()
        FrmInicio.Show()

    End Sub

    Private Sub Btn_Barcel_Click(sender As Object, e As EventArgs) Handles Btn_Barcel.Click
        IDS.ID_MARCA = 1
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Bimbo_Click(sender As Object, e As EventArgs) Handles Btn_Bimbo.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Cocacola_Click(sender As Object, e As EventArgs) Handles Btn_Cocacola.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Gamesa_Click(sender As Object, e As EventArgs) Handles Btn_Gamesa.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_SelloRojo_Click(sender As Object, e As EventArgs) Handles Btn_SelloRojo.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Lala_Click(sender As Object, e As EventArgs) Handles Btn_Lala.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Marinela_Click(sender As Object, e As EventArgs) Handles Btn_Marinela.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Pepsi_Click(sender As Object, e As EventArgs) Handles Btn_Pepsi.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Sabritas_Click(sender As Object, e As EventArgs) Handles Btn_Sabritas.Click
        IDS.ID_MARCA = 9
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Danone_Click(sender As Object, e As EventArgs) Handles Btn_Danone.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Nestle_Click(sender As Object, e As EventArgs) Handles Btn_Nestle.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Corona_Click(sender As Object, e As EventArgs) Handles Btn_Corona.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Tecate_Click(sender As Object, e As EventArgs) Handles Btn_Tecate.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_TiaRosa_Click(sender As Object, e As EventArgs) Handles Btn_TiaRosa.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_MilpaReal_Click(sender As Object, e As EventArgs) Handles Btn_MilpaReal.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Ricolino_Click(sender As Object, e As EventArgs) Handles Btn_Ricolino.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Sonrics_Click(sender As Object, e As EventArgs) Handles Btn_Sonrics.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_Jumex_Click(sender As Object, e As EventArgs) Handles Btn_Jumex.Click
        Me.Hide()
        Frm_Inventario.Show()
    End Sub

    Private Sub Btn_OtrasMarcas_Click(sender As Object, e As EventArgs) Handles Btn_OtrasMarcas.Click
        ID_MARCA = 15
        Me.Hide()
        Frm_Inventario.Show()
    End Sub
End Class