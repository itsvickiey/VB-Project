Imports MySql.Data.MySqlClient

Public Class LOGIN
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        REGISTER.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim strUsername As String = txtUsername.Text.Trim()
        'Dim strPassword As String = txtPassword.Text.Trim()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim myConnectionString As String

        myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=users"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            MessageBox.Show("succesfully connected to the database")


        Catch ex As MySql.Data.MySqlClient.MySqlException
            Application.Exit()

        End Try

    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class