Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysqlconn = New MySqlConnection("server=localhost; user=root; database=7/11 store; port=3306; SslMode=none")
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
