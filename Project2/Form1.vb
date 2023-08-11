Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Security.Authentication.ExtendedProtection

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckCredentials(txtId.Text, txtPassword.Text) Then
            Form2.Show()
        Else
            MessageBox.Show("Invalid username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()
    End Sub

    Private Function CheckCredentials(username As String, password As String) As Boolean

        con.Open()
        cmd.CommandText = "SELECT * FROM UserData WHERE [Username] = '" & username & "' AND [Password] = '" & password & "'"
        cmd.Connection = con

        dataReader = cmd.ExecuteReader()

        If (dataReader.Read() = True) Then
            MessageBox.Show("Welcome " + username, "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Return True
        Else

            Return False

        End If
        con.Close()
    End Function




    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form2.Visible = False
        Form3.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
