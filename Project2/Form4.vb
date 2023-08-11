Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form4
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Public Sub displayData()
        On Error Resume Next
        ds.Clear() 'clear dataset

        cmd = con.CreateCommand 'create command
        cmd.CommandText = "select * from UserData" 'sql command to select all data from table cookies

        da.SelectCommand = cmd

        da.Fill(ds, "UserData") 'fill dataset
        output.DataSource = ds.Tables(0) 'display data in datagridview
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim username As String = txtSearch.Text.Trim
        Try
            con.Open()
            cmd = con.CreateCommand() ' Create a new command object

            cmd.CommandText = "SELECT * FROM UserData WHERE [Username] = ?"
            cmd.Parameters.AddWithValue("?", username)

            ds.Clear()

            da.SelectCommand = cmd
            da.Fill(ds, "UserData")
            output.DataSource = ds.Tables("UserData")
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try 'coding undergoes try and catch
            'messagebox to confirm delete the data
            If MessageBox.Show("Are you sure you want to delete this record?", "DeleteRecord", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                con.Open() 'open connection
                'create sql command to delete da    ta
                Dim Del As OleDb.OleDbCommand = New OleDb.OleDbCommand("DELETE FROM UserData WHERE [Username] = ?", con)
                Del.Parameters.AddWithValue("?", InputBox("Enter username:").Trim())
                Del.ExecuteNonQuery() 'execute sql command
                con.Close() 'close connection
                'messagebox if there is no error
                MessageBox.Show("Successfully delete data from database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                displayData()
            End If

        Catch ex As Exception
            'messagebox if there is error
            MessageBox.Show("Failed to delete data from database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected
        If output.SelectedRows.Count > 0 Then
            ' Retrieve the selected row
            Dim selectedRow As DataGridViewRow = output.SelectedRows(0)

            ' Retrieve the current values from the selected row
            Dim currentMatricNumber As String = selectedRow.Cells("MatricNumber").Value.ToString()

            ' Display an input dialog to allow the user to enter updated values
            Dim updatedName As String = InputBox("Enter updated Name:", "Update Name")
            Dim updatedMatricNumber As String = InputBox("Enter updated MatricNumber:", "Update MatricNumber")
            Dim updatedDepartment As String = InputBox("Enter updated Department:", "Update Department")
            Dim updatedGender As String = InputBox("Enter updated Gender (Male/Female):", "Update Gender")
            Dim updatedEmail As String = InputBox("Enter updated Email:", "Update Email")
            Dim updatedUsername As String = InputBox("Enter updated Username:", "Update Username")
            Dim updatedPassword As String = InputBox("Enter updated Password:", "Update Password")

            ' Retrieve the updated gender selection
            If updatedGender <> "Male" AndAlso updatedGender <> "Female" Then
                MessageBox.Show("Invalid gender input. Please enter 'Male' or 'Female'.")
                Return
            End If

            ' Perform the database update
            Try
                con.Open()

                cmd.Connection = con
                cmd.CommandText = "UPDATE UserData SET " &
                                  "[Name] = ?, " &
                                  "[MatricNumber] = ?, " &
                                  "[Department] = ?, " &
                                  "[Gender] = ?, " &
                                  "[Email] = ?, " &
                                  "[Username] = ?, " &
                                  "[Password] = ? " &
                                  "WHERE [MatricNumber] = ?"

                cmd.Parameters.AddWithValue("@p1", updatedName)
                cmd.Parameters.AddWithValue("@p2", updatedMatricNumber)
                cmd.Parameters.AddWithValue("@p3", updatedDepartment)
                cmd.Parameters.AddWithValue("@p4", updatedGender)
                cmd.Parameters.AddWithValue("@p5", updatedEmail)
                cmd.Parameters.AddWithValue("@p6", updatedUsername)
                cmd.Parameters.AddWithValue("@p7", updatedPassword)
                cmd.Parameters.AddWithValue("@p8", currentMatricNumber)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.")

                ds.Clear() 'clear dataset

                cmd = con.CreateCommand 'create command
                cmd.CommandText = "select * from UserData" 'sql command to select all data from table cookies

                da.SelectCommand = cmd

                da.Fill(ds, "UserData") 'fill dataset
                output.DataSource = ds.Tables(0) 'display data in datagridview

            Catch ex As Exception
                MessageBox.Show("An error occurred during the update: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please select a row in the grid.")
        End If

    End Sub


End Class