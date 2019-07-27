Imports System.IO
Public Class edit_list
    '//
    '// Read Settings file
    '//
    Dim File = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Management Soft", "Settings Location", Nothing)
    Dim List = "List"
    Dim a = "a"
    Dim b = "b"
    Dim c = "c"

    Private Sub edit_list_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(File) Then
            TextBox1.Text = ReadIni(File, List, a, "")
            TextBox2.Text = ReadIni(File, List, b, "")
            TextBox3.Text = ReadIni(File, List, c, "")
        Else
            MsgBox("Settings File not found", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If TextBox3.Text <> "" Then
                    Try
                        writeIni(File, List, a, TextBox1.Text)
                        writeIni(File, List, b, TextBox2.Text)
                        writeIni(File, List, c, TextBox3.Text)
                        MsgBox("Saved Successfully", MsgBoxStyle.Information, "Saved")
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
                    End Try
                Else
                    MsgBox("Cannot be empty", MsgBoxStyle.Exclamation, "Error")
                End If
            Else
                MsgBox("Cannot be empty", MsgBoxStyle.Exclamation, "Error")
            End If
        Else
            MsgBox("Cannot be empty", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class