Public Class Form5
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtMatric.Text = ""
        txtFeedback.Text = ""
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            con.Open()

            cmd.CommandText = "INSERT INTO Review ([Name], [Matric], [Feedback])" _
                            & "VALUES (@Name,@Matric,@Feedback)"

            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Matric", txtMatric.Text)
            cmd.Parameters.AddWithValue("@Feedback", txtFeedback.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully.")

            ' Clear the input fields or perform any necessary actions after successful insertion

        Catch ex As Exception
            MessageBox.Show("An error occurred during the data insertion: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class