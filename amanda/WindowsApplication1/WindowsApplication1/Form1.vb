﻿Public Class Form1

    Private Sub Tabla1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tabla1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabla1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.Database1DataSet.Tabla1)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
