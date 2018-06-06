Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysqlconn = New MySqlConnection("server=127.0.0.1; database=Database; port=3306")

        Try
            mysqlconn.Open()
            MessageBox.Show("Connection Successful")
            mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub
End Class
