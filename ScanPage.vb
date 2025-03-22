Imports MySql.Data.MySqlClient ' Install MySql.Data via NuGet

Public Class ScanPage
    ' MySQL Connection String (Update with your credentials)
    Private connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    ' Event handler for TextBox1 to trigger on Enter key press
    Private Sub TxtScanNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScanNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim scannedID As String = TxtScanNo.Text.Trim()
            If Not String.IsNullOrEmpty(scannedID) AndAlso IsNumeric(scannedID) Then
                Dim numericID As Integer = Convert.ToInt32(scannedID)

                If IsPetIDExists(numericID) Then
                    SaveToDatabase(numericID, "Scanned Data Here") ' Save scan history
                    OpenClientInfoPage(numericID, New ClientInfoPage(numericID)
) ' Open ClientInfoPage with scanned ID
                    TxtScanNo.Clear() ' Clear textbox after scanning
                Else
                    MessageBox.Show("Error: Pet ID does not exist in the database.", "Foreign Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    ' Function to check if Pet ID exists in the database
    Private Function IsPetIDExists(id As Integer) As Boolean
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM pets_info WHERE PetID = @PetID;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PetID", id)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Sub SaveToDatabase(scannedID As Integer, scanData As String)
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO Scanner (PetID, ScanData, ScanDate) VALUES (@PetID, @ScanData, NOW());"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PetID", scannedID)
                    cmd.Parameters.AddWithValue("@ScanData", scanData)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub OpenClientInfoPage(id As Integer, clientInfoPage As ClientInfoPage)
        ' ✅ Ensure id is valid
        If id > 0 Then

            ' ✅ Ensure TxtPetIDNo exists before using
            If clientInfoPage.TxtPetIDNo IsNot Nothing Then
                clientInfoPage.TxtPetIDNo.Text = id.ToString()
            Else
                MessageBox.Show("Error: TxtPetIDNo is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            clientInfoPage.Show()
        Else
            MessageBox.Show("Invalid ID. Please scan again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' Event handler for Back Button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim DashboardPage As New DashboardPage()
        DashboardPage.Show()
        Me.Hide()
    End Sub
End Class