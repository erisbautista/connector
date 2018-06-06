Imports MySql.Data.MySqlClient
Public Class Form2
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=7/11 store; port=3306; SslMode=none"
            conn.Open()
            query = "" & ComboBox1.Text & ""
            com = New MySqlCommand(query, conn)
            adapt.SelectCommand = com
            adapt.Fill(data)
            source.DataSource = data
            DataGridView1.DataSource = source
            adapt.Update(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class