Imports System.Data.OleDb
Public Class frmAgregaMarca

    Private Sub btnAgregaMarca_Click(sender As Object, e As EventArgs) Handles btnAgregaMarca.Click
        Try
            Dim Insertar = "INSERT INTO MARCA VALUES(@ID_MARCA, @MARCA)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@ID_MARCA", ID_MARCA)
            Cmd.Parameters.AddWithValue("@CODIGO", txtNomMarca.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("La nueva Marca fue registrada")
        Catch ex As Exception
            MsgBox("La Marca ya existe")
        End Try
        Me.Close()
    End Sub

    Private Sub frmAgregaMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdMarca.Text = ID_MARCA
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class