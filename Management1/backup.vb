Public Class backup
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text <> "" Then
            Label3.Text = My.Computer.Clock.LocalTime.Date
            Label3.Text = Label3.Text & "_" & My.Computer.Clock.LocalTime.Hour & "_" & My.Computer.Clock.LocalTime.Minute & "_" & My.Computer.Clock.LocalTime.Second
            Label3.Text = Label3.Text.Replace("/", "_")
            Dim path As String
            path = TextBox2.Text & "\Backup_" & Label3.Text & ".accdb.BAK"
            Try
                My.Computer.FileSystem.CopyFile(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Database Location", Nothing), path)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Backup Successfull", MsgBoxStyle.Information, "Backup")
            Me.Close()
            TextBox2.Enabled = True
            TextBox2.Text = ""
        Else
            MsgBox("Please enter Backup location", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class