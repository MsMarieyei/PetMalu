Imports MySql.Data.MySqlClient

Public Class ClientPage
    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"
    Dim selectedClientID As Integer ' Store selected client's ID

    ' Search Functionality
    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim clientName As String = TxtSearch.Text.Trim()

        If clientName = "" Then
            MessageBox.Show("Please enter a client name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ClientID FROM clients WHERE FullName = @FullName LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FullName", clientName)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    selectedClientID = Convert.ToInt32(reader("ClientID")) ' Ensure it's an integer
                    reader.Close()

                    ' Open ClientInfoPage and pass client ID correctly
                    Dim clientInfoPage As New ClientInfoPage(selectedClientID)
                    clientInfoPage.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End Using
    End Sub

End Class
