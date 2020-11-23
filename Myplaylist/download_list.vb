Public Class download_list
    Private Sub download_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter

        If TextBox1.Text = "Insert the url" Then

            TextBox1.Text = String.Empty
            TextBox1.ForeColor = Color.Black
            Label7.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave

        If TextBox1.Text <> "Insert the url" AndAlso TextBox1.Text <> String.Empty Then

            TextBox1.ForeColor = Color.Black

        Else

            TextBox1.ForeColor = Color.DarkGray
            Label7.ForeColor = Color.DarkGray

            If String.IsNullOrEmpty(TextBox1.Text) = True Then

                TextBox1.Text = "Insert the url"


            End If

        End If

    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "Start" Then

            TextBox2.Text = String.Empty
            TextBox2.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text <> "Start" AndAlso TextBox2.Text <> String.Empty Then

            TextBox2.ForeColor = Color.Black

        Else

            TextBox2.ForeColor = Color.DarkGray


            If String.IsNullOrEmpty(TextBox2.Text) = True Then

                TextBox2.Text = "Start"


            End If

        End If
    End Sub

    Private Sub TextBox3_MouseEnter(sender As Object, e As EventArgs) Handles TextBox3.MouseEnter
        If TextBox3.Text = "End" Then

            TextBox3.Text = String.Empty
            TextBox3.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBox3_MouseLeave(sender As Object, e As EventArgs) Handles TextBox3.MouseLeave
        If TextBox3.Text <> "Start" AndAlso TextBox3.Text <> String.Empty Then

            TextBox3.ForeColor = Color.Black

        Else

            TextBox3.ForeColor = Color.DarkGray


            If String.IsNullOrEmpty(TextBox3.Text) = True Then

                TextBox3.Text = "End"


            End If

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Label1.Click

        If TextBox1.Text <> "Insert the url" AndAlso TextBox1.Text <> String.Empty AndAlso TextBox2.Text <> "Start" AndAlso TextBox2.Text <> String.Empty AndAlso TextBox3.Text <> "End" AndAlso TextBox3.Text <> String.Empty Then

            Label2.Visible = False

            Shell("cmd.exe /c cd/ & cd Windows & cd youtube-dl & youtube-dl -f " + TextBox5.Text + " -f best -ciw --playlist-items " + TextBox2.Text + "-" + TextBox3.Text + " -o ""C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineVideo_list\%(title)s.%(ext)s"" --no-mtime " + TextBox1.Text, AppWinStyle.NormalFocus)

        Else

            Label2.Visible = True

        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Panel5.Click, Label9.Click

        If TextBox1.Text <> "Insert the url" AndAlso TextBox1.Text <> String.Empty AndAlso TextBox2.Text <> "Start" AndAlso TextBox2.Text <> String.Empty AndAlso TextBox3.Text <> "End" AndAlso TextBox3.Text <> String.Empty Then

            Label2.Visible = False

            Shell("cmd.exe /c cd/ & cd Windows & cd youtube-dl & youtube-dl -x --audio-format " + TextBox4.Text + " -ciw --playlist-items " + TextBox2.Text + "-" + TextBox3.Text + " -o ""C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineSound_list\%(title)s.%(ext)s"" --no-mtime " + TextBox1.Text, AppWinStyle.NormalFocus)

        Else

            Label2.Visible = True

        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Label4.Click

        Shell("cmd.exe /c start " + TextBox1.Text, AppWinStyle.Hide)

    End Sub
End Class