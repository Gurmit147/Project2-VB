Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form3
    Dim gender As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim username As String = "Admin"
        Dim userpassword As String = "Admin"

        Dim name = InputBox("Please enter username")
        Dim password = InputBox("Please enter password")

        If username = name AndAlso userpassword = password Then
            Form4.Show()
        Else
            MessageBox.Show("Intruder Alert!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd.Connection = con

        Try
            If ValidateInput() Then
                If rMale.Checked = True Then
                    gender = "Male"
                Else
                    gender = "Female"
                End If

                con.Open()
                cmd.CommandText = "SELECT COUNT(*) FROM UserData WHERE [Username] = @Username"
                cmd.Parameters.AddWithValue("@Username", txtUName.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Username already exists", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                Else
                    EnterData()
                    MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    con.Close()
                End If

            Else
                MessageBox.Show("Data is Invalid", "Invalid")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EnterData()

        cmd.Connection = con
        'con.Open()
        cmd.CommandText = "INSERT INTO UserData ([Name],[MatricNumber],[Department],[Gender],[Email], [Username], [Password])" _
                & " Values (" _
                & "'" & txtName.Text & "'," _
                & "'" & txtMatric.Text & "'," _
                & "'" & coDepartment.Text & "'," _
                & "'" & gender & "'," _
                & "'" & txtEmail.Text & "'," _
                & "'" & txtUName.Text & "'," _
                & "'" & txtPassword.Text & "')"



        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully stored data into database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ValidateInput() As Boolean
        Return _
                IsPresent(txtName.Text) AndAlso
                IsPresent(txtMatric.Text) AndAlso
                IsPresent(coDepartment.Text) AndAlso
                IsPresentGender(rMale.Text, rFemale.Text) AndAlso
                IsPresent(txtEmail.Text) AndAlso
                IsPresent(txtUName.Text) AndAlso
                IsPresent(txtPassword.Text) AndAlso
                IsPresent(coDepartment.SelectedItem.ToString()) AndAlso
                ValidateEmail(txtEmail)
    End Function

    Private Function IsPresent(ByVal textbox As String) As Boolean
        If textbox = "" Then
            MessageBox.Show("Please enter all the fields", "Wrong Input")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function IsPresentGender(ByVal male As String, ByVal female As String)
        If male = "" Or female = "" Then
            MessageBox.Show("Please enter all the fields", "Wrong Input")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidateEmail(ByVal email As TextBox) As Boolean
        Dim emailStructure As String = "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
        Dim email_check As New Regex(emailStructure)
        If Not email_check.IsMatch(email.Text) Then
            MessageBox.Show("Invalid e-mail address", "Entry Error")
            email.Select()
            email.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearInputs()
        txtName.Text = ""
        txtMatric.Text = ""
        coDepartment.SelectedIndex = -1
        rMale.Checked = False
        rFemale.Checked = False
        txtEmail.Text = ""
        txtUName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class
