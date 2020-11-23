Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class download_video
    '   Public WithEvents download As WebClient

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    Private Sub download_video_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        AddHandler YoutubeHorn.list_yd.download_video_click, AddressOf download_cv
        AddHandler YoutubeHorn.list_yd.download_sound_click, AddressOf download_cs
        AddHandler YoutubeHorn.list_yd.openLink_click, AddressOf download_co

        SetDoubleBuffering(Panel2, True)
        SetDoubleBuffering(FlowLayoutPanel1, True)
        SetDoubleBuffering(GunaLinePanel1, True)
        SetDoubleBuffering(GunaElipsePanel1, True)
        SetDoubleBuffering(GunaElipsePanel2, True)
        SetDoubleBuffering(GunaResizeControl1, True)


        Label3.Text = Char.ConvertFromUtf32("&HE8BB")
        Label3.Text = Char.ConvertFromUtf32("&HE8BB")
        Label5.Text = Char.ConvertFromUtf32("&HE922")
        Label4.Text = Char.ConvertFromUtf32("&HE921")
        Label7.Text = Char.ConvertFromUtf32("&HE8B2")
        Label8.Text = Char.ConvertFromUtf32("&HEBC5")


        Me.CenterToScreen()

        Label6.Text = SystemInformation.UserName

        show_.Start()



    End Sub

    Public the_link_ As New Label
    Public the_link_id As String

    Private Sub download_co(sender As Object, e As EventArgs)

        Dim ov As New openVideo

        ov.Show()

        openVideo._yUrl = the_link_id

    End Sub

    Private Sub download_cs(sender As Object, e As EventArgs)

        Shell("cmd.exe /c cd/ & cd Windows & cd youtube-dl & youtube-dl -x --audio-format " + TextBox2.Text + " -o ""C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineSound_list\%(title)s.%(ext)s"" --no-mtime " + the_link_.Text, AppWinStyle.NormalFocus)

    End Sub

    Private Sub download_cv(sender As Object, e As EventArgs)

        Shell("cmd.exe /c cd/ & cd Windows & cd youtube-dl & youtube-dl -f " + TextBox1.Text + " -f best -o ""C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineVideo_list\%(title)s.%(ext)s"" --no-mtime " + the_link_.Text, AppWinStyle.NormalFocus)



    End Sub

    Private Sub time__Tick(sender As Object, e As EventArgs) Handles time_.Tick

        Label9.Text = DateTime.Now

        YoutubeHorn.list_yd.the_size = FlowLayoutPanel1.Size

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        YoutubeHorn.list_yd = New C_UI_.downlodVideo

        Me.Close()

    End Sub
    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
            Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            Me.WindowState = FormWindowState.Normal
            Label5.Text = Char.ConvertFromUtf32("&HE922")
            Me.Size = New Size(977, 625)

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Minimized

        End If
    End Sub
    Dim n As Integer = 0
    Private Sub show__Tick(sender As Object, e As EventArgs) Handles show_.Tick

        n += 1

        If n = 2 Then



            GunaLinePanel1.Visible = True

            Panel2.Visible = True

            FlowLayoutPanel1.Visible = True

        End If

    End Sub

End Class