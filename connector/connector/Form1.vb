﻿Imports MySql.Data.MySqlClient
Public Class Form1
    Private conn As New MySqlConnection
    Private reader As New MySqlDataAdapter
    Private comm As New MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As New DataTable
        Dim query As String
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=7/11 store; port=3306; SslMode=none"
            conn.Open()
            query = "" & TextBox1.Text & ""
            comm = New MySqlCommand(query, conn)
            READER.SelectCommand = comm
            READER.Fill(data)
            source.DataSource = data
            DataGridView1.DataSource = source
            READER.Update(data)


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            conn.Close()
        End Try
    End Sub
End Class
