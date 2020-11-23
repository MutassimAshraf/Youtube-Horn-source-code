Public Class OfflineVideoPlayer

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    Private Sub OfflineVideoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        SetDoubleBuffering(Panel1, True)
        SetDoubleBuffering(TableLayoutPanel1, True)

        AxWindowsMediaPlayer1.uiMode = "none"



    End Sub
    Private Sub GTrackBar1_MouseEnter(sender As Object, e As EventArgs) Handles GTrackBar1.MouseEnter
        GTrackBar1.Size = New Size(GTrackBar1.Width, 5)
        GTrackBar2.Visible = False
    End Sub

    Private Sub GTrackBar1_MouseLeave(sender As Object, e As EventArgs) Handles GTrackBar1.MouseLeave
        GTrackBar1.Size = New Size(GTrackBar1.Width, 3)
    End Sub
    Dim ps As Integer = 1
    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click

        ps += 1

        If ps = 2 Then

            GunaCircleButton3.Text = Char.ConvertFromUtf32("&HEDB5")

            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            play_.Stop()
            play_.Enabled = False

            ps = 0

        End If

        If ps = 1 Then

            GunaCircleButton3.Text = Char.ConvertFromUtf32("&HEDB4")

            AxWindowsMediaPlayer1.Ctlcontrols.play()
            play_.Start()
            play_.Enabled = True

        End If

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        GTrackBar2.Visible = True
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub play__Tick(sender As Object, e As EventArgs) Handles play_.Tick

        Label1.Text = AxWindowsMediaPlayer1.currentMedia.name

        GTrackBar1.MaxValue = Convert.ToInt16(AxWindowsMediaPlayer1.currentMedia.duration)
        Label6.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString & "/" & AxWindowsMediaPlayer1.currentMedia.durationString
        GTrackBar1.Value = Convert.ToInt16(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)

    End Sub

    Private Sub GTrackBar1_MouseDown(sender As Object, e As MouseEventArgs) Handles GTrackBar1.MouseDown
        play_.Stop()
        play_.Enabled = False
    End Sub

    Private Sub GTrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles GTrackBar1.MouseUp
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = GTrackBar1.Value
        play_.Start()
        play_.Enabled = True
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub


    Private Sub GTrackBar2_MouseUp(sender As Object, e As MouseEventArgs) Handles GTrackBar2.MouseUp

        If GTrackBar2.Value = 0 Then

            Label4.Text = Char.ConvertFromUtf32("&HE198")

        Else

            Label4.Text = Char.ConvertFromUtf32("&HE994")

        End If

        AxWindowsMediaPlayer1.settings.volume = GTrackBar2.Value

    End Sub
    Dim ft As Integer = 1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        ft += 1

        If ft = 2 Then

            Me.WindowState = FormWindowState.Maximized

            ft = 0
        End If

        If ft = 1 Then

            Me.WindowState = FormWindowState.Normal

        End If



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class