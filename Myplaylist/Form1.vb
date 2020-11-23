Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO
Imports SimpleWifi


Public Class YoutubeHorn

    Dim s As String
    Dim r1 As String
    Dim nu As Integer = 0
    Dim v As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Shared wifi_ As Wifi

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    ''function to copy all directory to a file
    Public Function CopyDirectory(ByVal SrcPath As String, ByVal DestPath As String, Optional ByVal bQuiet As Boolean = False) As Boolean

        If DestPath.Substring(DestPath.Length - 1, 1) <> System.IO.Path.DirectorySeparatorChar Then
            DestPath += System.IO.Path.DirectorySeparatorChar
        End If
        If Not System.IO.Directory.Exists(DestPath) Then System.IO.Directory.CreateDirectory(DestPath)
        Dim Files As String()
        Files = System.IO.Directory.GetFileSystemEntries(SrcPath)
        Dim element As String
        For Each element In Files
            If System.IO.Directory.Exists(element) Then
                CopyDirectory(element, DestPath & System.IO.Path.GetFileName(element), True)
            Else
                System.IO.File.Copy(element, DestPath & System.IO.Path.GetFileName(element), True)
            End If
        Next
        Return True
    End Function


    Private Sub Myplaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error Resume Next

        wifi_ = New Wifi()

        SetDoubleBuffering(Panel2, True)
        SetDoubleBuffering(FlowLayoutPanel1, True)
        SetDoubleBuffering(TableLayoutPanel2, True)
        SetDoubleBuffering(TableLayoutPanel3, True)
        SetDoubleBuffering(GunaLinePanel1, True)
        SetDoubleBuffering(GunaElipsePanel1, True)
        SetDoubleBuffering(GunaElipsePanel2, True)
        SetDoubleBuffering(GunaElipsePanel3, True)
        SetDoubleBuffering(GunaResizeControl1, True)
        SetDoubleBuffering(GunaSwitch1, True)
        SetDoubleBuffering(GunaWinCircleProgressIndicator1, True)

        Me.CenterToScreen()

        Me.Size = New Size(977, 625)
        GunaElipsePanel1.Size = New Size(383, 27)

        'icon fornt text

        Label8.Text = Char.ConvertFromUtf32("&HF6FA")
        Label3.Text = Char.ConvertFromUtf32("&HE8BB")
        Label5.Text = Char.ConvertFromUtf32("&HE922")
        Label4.Text = Char.ConvertFromUtf32("&HE921")
        Label11.Text = Char.ConvertFromUtf32("&HE81E")
        Label12.Text = Char.ConvertFromUtf32("&HF384")
        Label14.Text = Char.ConvertFromUtf32("&HEC4F")
        Label15.Text = Char.ConvertFromUtf32("&HE149")

        v = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel1, gunaVScrollBar1, False)

        Me.CenterToScreen()

        Label6.Text = SystemInformation.UserName

        'create & copy files 

        CopyDirectory("C:\Users\" + SystemInformation.UserName + "\Desktop\Myplaylist\Myplaylist\bin\x86\Release\youtube-dl", "C:\Windows\youtube-dl")


        My.Computer.FileSystem.CreateDirectory("C:\Users\" + SystemInformation.UserName + "\Desktop\playList")
        My.Computer.FileSystem.CreateDirectory("C:\Users\" + SystemInformation.UserName + "\Desktop\My_list")
        My.Computer.FileSystem.CreateDirectory("C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineVideo_list")
        My.Computer.FileSystem.CreateDirectory("C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineSound_list")
        My.Computer.FileSystem.CreateDirectory("C:\Windows\music_browser\Default\Cache")

        'check the mode dark/light

        If My.Settings.save_mode = True Then

            GunaSwitch1.Checked = True

            Me.BackColor = Color.White
            Panel2.BackColor = Color.FromArgb(242, 242, 242)
            Circular_PictureBox1.BackColor = Color.FromArgb(242, 242, 242)

            GunaSwitch1.CheckedOnColor = Color.PaleTurquoise
            GunaSwitch1.FillColor = Color.FromArgb(27, 125, 214)

            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label9.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            Label12.ForeColor = Color.Black
            Label14.ForeColor = Color.Black
            Label15.ForeColor = Color.Black

            GunaResizeControl1.ForeColor = Color.Black
            GunaLinePanel1.LineColor = Color.FromArgb(239, 239, 239)

        Else

            GunaSwitch1.Checked = False

            Me.BackColor = Color.FromArgb(11, 11, 11)
            Panel2.BackColor = Color.FromArgb(11, 11, 11)
            Circular_PictureBox1.BackColor = Color.FromArgb(11, 11, 11)

            GunaSwitch1.CheckedOffColor = Color.Gray
            GunaSwitch1.FillColor = Color.FromArgb(11, 11, 11)

            Label1.ForeColor = Color.GhostWhite
            Label3.ForeColor = Color.LightGray
            Label5.ForeColor = Color.LightGray
            Label4.ForeColor = Color.LightGray
            Label9.ForeColor = Color.LightGray
            Label12.ForeColor = Color.LightGray
            Label14.ForeColor = Color.LightGray
            Label15.ForeColor = Color.LightGray
            Label6.ForeColor = Color.White


            GunaResizeControl1.ForeColor = Color.White
            GunaLinePanel1.LineColor = Color.FromArgb(55, 55, 55)

        End If


    End Sub

    Private Sub NeeR_button31_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Min__Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Minimized

        End If
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
    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Label7.Click


        FlowLayoutPanel1.Refresh()

        Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

        Dim list_y As New C_UI_.YutubeList_UI



        If TextBox1.Text <> "Insert the url" AndAlso TextBox1.Text <> String.Empty Then

            'the playlist of youtube

            'the url = 32 char                the id = 11 char  the list id                                            number of video
            'https://www.youtube.com/watch?v= wJhm_0rHjAg       &list=RDGMEMYH9CUrFO7CfLJpaD7UR85wVMWi7woZS3w8w&index= 15


            ' the url of video

            'the url = 32 char                the id = 11 char
            'https://www.youtube.com/watch?v= -Zx3CX0KM-E
            'https://www.youtube.com/watch?v=ptx7UlK9yWg

            ' the url of youtube music video

            'https://music.youtube.com/watch?v=2HF-4O9N5sw&feature=share

            st = TextBox1.Text.Replace("https://music.youtube.com", "https://www.youtube.com")


            s = st.Substring(32, 11)

            list_y.Tag = nu.ToString()
            list_y.the_number = "#"



            'add the video

            FlowLayoutPanel1.Controls.Add(list_y)

            AddHandler list_y.pic_click, AddressOf Pic_c
            AddHandler list_y.del_click, AddressOf del_c


        End If

        FlowLayoutPanel1.Refresh()

        Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

        'save the url in txt file in desktop (file name playList)

        Dim w1 As New IO.StreamWriter("C:\Users\" + SystemInformation.UserName + "\Desktop\playList\url" + FlowLayoutPanel1.Controls.Count.ToString + ".txt", True, Encoding.UTF8)
        w1.Write("https://www.youtube.com/watch?v=" + s)
        w1.Close()


        TextBox1.Text = String.Empty
        TextBox1.ForeColor = Color.DarkGray
        Label7.ForeColor = Color.DarkGray

        If String.IsNullOrEmpty(TextBox1.Text) = True Then

            TextBox1.Text = "Insert the url"


        End If

        GunaWinCircleProgressIndicator1.Visible = True
        GunaWinCircleProgressIndicator1.ProgressColor = Color.Green

        show_.Start()


    End Sub

    Private Sub Pic_c(sender As Object, e As EventArgs)

        Shell("cmd.exe /c start " + DirectCast(sender, C_UI_.YutubeList_UI).Name, AppWinStyle.Hide)


    End Sub



    Private Sub Url__Click(sender As Object, e As EventArgs) Handles Label8.Click, TableLayoutPanel2.Click, Label10.Click

        Shell("cmd.exe /c start https://www.youtube.com/", AppWinStyle.Hide)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click


        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
            Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            Me.WindowState = FormWindowState.Normal
            Me.Size = New Size(977, 625)
            Label5.Text = Char.ConvertFromUtf32("&HE922")

        End If





    End Sub
    Dim itemcode As Match
    Dim st As String
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then



            e.SuppressKeyPress = True

            FlowLayoutPanel1.Refresh()

            Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

            ' Dim p As New PictureBox
            Dim list_y As New C_UI_.YutubeList_UI



            If TextBox1.Text <> "Insert the url" AndAlso TextBox1.Text <> String.Empty Then

                'the playlist of youtube

                'the url = 32 char                the id = 11 char  the list id                                            number of video
                'https://www.youtube.com/watch?v= wJhm_0rHjAg       &list=RDGMEMYH9CUrFO7CfLJpaD7UR85wVMWi7woZS3w8w&index= 15

                ' the url of youtube video

                'the url = 32 char                the id = 11 char
                'https://www.youtube.com/watch?v= -Zx3CX0KM-E
                'https://www.youtube.com/watch?v=ptx7UlK9yWg


                ' the url of youtube music video

                'https://music.youtube.com/watch?v=2HF-4O9N5sw&feature=share

                st = TextBox1.Text.Replace("https://music.youtube.com", "https://www.youtube.com")


                s = st.Substring(32, 11)

                list_y.Tag = nu.ToString()
                list_y.the_number = "#"



                'add the video

                FlowLayoutPanel1.Controls.Add(list_y)

                AddHandler list_y.pic_click, AddressOf Pic_c
                AddHandler list_y.del_click, AddressOf del_c


            End If

            FlowLayoutPanel1.Refresh()

            Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

            'save the url in txt file in desktop (file name playList)

            Dim w1 As New IO.StreamWriter("C:\Users\" + SystemInformation.UserName + "\Desktop\playList\url" + FlowLayoutPanel1.Controls.Count.ToString + ".txt", True, Encoding.UTF8)
            w1.Write("https://www.youtube.com/watch?v=" + s)
            w1.Close()


            TextBox1.Text = String.Empty
            TextBox1.ForeColor = Color.DarkGray
            Label7.ForeColor = Color.DarkGray

            If String.IsNullOrEmpty(TextBox1.Text) = True Then

                TextBox1.Text = "Insert the url"


            End If

            GunaWinCircleProgressIndicator1.Visible = True
            GunaWinCircleProgressIndicator1.ProgressColor = Color.Green

            show_.Start()


        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles time_.Tick

        Label9.Text = DateTime.Now

    End Sub


    'function to rename the txt file

    Private Sub renameFiles()

        Dim sourcePath As String = "C:\Users\" + SystemInformation.UserName + "\Desktop\playList"
        Dim searchPattern As String = "*.txt"

        Dim curDir As New DirectoryInfo(sourcePath)

        Dim i As Integer = 1

        For Each t As FileInfo In curDir.GetFiles(searchPattern).OrderBy(Function(num) num.CreationTime)

            File.Move(t.FullName, Path.Combine(t.Directory.FullName, "url" & i & ".txt"))
            i += 1

        Next

    End Sub

    Dim n As Integer = 0
    Dim the_link_id As String
    Private Sub show_Tick(sender As Object, e As EventArgs) Handles show_.Tick


        n += 1

        If n = 2 Then

            'call function to rename text file

            renameFiles()


            'get item number of file

            Dim item_ As ObjectModel.ReadOnlyCollection(Of String)
            item_ = My.Computer.FileSystem.GetFiles("C:\Users\" + SystemInformation.UserName + "\Desktop\playList")



            FlowLayoutPanel1.Controls.Clear()

            If GunaSwitch1.Checked = True Then

                Me.BackColor = Color.White
                Panel2.BackColor = Color.FromArgb(242, 242, 242)
                Circular_PictureBox1.BackColor = Color.FromArgb(242, 242, 242)

                GunaSwitch1.CheckedOnColor = Color.PaleTurquoise
                GunaSwitch1.FillColor = Color.FromArgb(27, 125, 214)

                Label1.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label5.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label9.ForeColor = Color.Black
                Label6.ForeColor = Color.Black
                Label12.ForeColor = Color.Black
                Label14.ForeColor = Color.Black
                Label15.ForeColor = Color.Black


                GunaResizeControl1.ForeColor = Color.Black
                GunaLinePanel1.LineColor = Color.FromArgb(239, 239, 239)

                My.Settings.save_mode = True
                My.Settings.Save()

            Else

                Me.BackColor = Color.FromArgb(11, 11, 11)
                Panel2.BackColor = Color.FromArgb(11, 11, 11)
                Circular_PictureBox1.BackColor = Color.FromArgb(11, 11, 11)

                GunaSwitch1.CheckedOffColor = Color.Gray
                GunaSwitch1.FillColor = Color.FromArgb(11, 11, 11)

                Label1.ForeColor = Color.GhostWhite
                Label3.ForeColor = Color.LightGray
                Label5.ForeColor = Color.LightGray
                Label4.ForeColor = Color.LightGray
                Label9.ForeColor = Color.LightGray
                Label12.ForeColor = Color.LightGray
                Label14.ForeColor = Color.LightGray
                Label15.ForeColor = Color.LightGray
                Label6.ForeColor = Color.White

                GunaResizeControl1.ForeColor = Color.White
                GunaLinePanel1.LineColor = Color.FromArgb(55, 55, 55)

                My.Settings.save_mode = False
                My.Settings.Save()



            End If


            For nu = 1 To item_.Count


                Dim list_y As New C_UI_.YutubeList_UI

                'set the mode dark/light

                If GunaSwitch1.Checked = True Then

                    list_y.the_channel_color = Color.Black
                    list_y.the_date_color = Color.Black
                    list_y.the_genre_color = Color.Black
                    list_y.the_name_color = Color.Black
                    list_y.the_delete_backcolor = Color.FromArgb(95, 0, 231)
                    list_y.the_download_backcolor = Color.FromArgb(95, 0, 231)
                    list_y.the_open_backcolor = Color.FromArgb(95, 0, 231)



                Else

                    list_y.the_channel_color = Color.LightGray
                    list_y.the_date_color = Color.LightGray
                    list_y.the_genre_color = Color.LightGray
                    list_y.the_name_color = Color.White
                    list_y.the_delete_backcolor = Color.FromArgb(23, 23, 23)
                    list_y.the_download_backcolor = Color.FromArgb(23, 23, 23)
                    list_y.the_open_backcolor = Color.FromArgb(23, 23, 23)

                End If


                Dim r1_ As New IO.StreamReader("C:\Users\" + SystemInformation.UserName + "\Desktop\playList\url" + nu.ToString + ".txt")
                If (r1_ IsNot Nothing) Then

                    r1 = r1_.ReadToEnd
                    r1_.Close()

                End If

                list_y.Tag = nu.ToString()
                list_y.the_number = "#" + nu.ToString()

                If r1.Contains("(delete)") Then

                    list_y.Hide()

                End If

                s = r1.Substring(r1.LastIndexOf("=") + 1)

                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.youtube.com/watch?v=" + s)
                Dim response As System.Net.HttpWebResponse = request.GetResponse

                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

                Dim sourcecode As String = sr.ReadToEnd


                'get image of video

                list_y.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/maxresdefault.jpg"
                list_y.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/hqdefault.jpg"

                list_y.the_image_sizeMode = PictureBoxSizeMode.StretchImage

                'get title

                Dim t As New System.Text.RegularExpressions.Regex("<meta name=""title"" content="".*"">")
                Dim matches_t As MatchCollection = t.Matches(sourcecode)

                For Each itemcode As Match In matches_t

                    list_y.the_name = itemcode.Value.Split("""").GetValue(3)


                Next

                'get url

                list_y.Name = "https://www.youtube.com/watch?v=" + s
                list_y.the_url = "https://www.youtube.com/watch?v=" + s


                'get publish date

                Dim r As New System.Text.RegularExpressions.Regex("<meta itemprop=""datePublished"" content="".*"">")
                Dim matches As MatchCollection = r.Matches(sourcecode)

                For Each itemcode As Match In matches

                    list_y.the_date = "publish on:" + itemcode.Value.Split("""").GetValue(3)


                Next



                'get genre

                Dim g As New System.Text.RegularExpressions.Regex("<meta itemprop=""genre"" content="".*"">")
                Dim matches_g As MatchCollection = g.Matches(sourcecode)

                For Each itemcode_g As Match In matches_g

                    list_y.the_genre = "genre:" + itemcode_g.Value.Split("""").GetValue(3)


                Next



                'get channel name


                Dim c As New System.Text.RegularExpressions.Regex("<link itemprop=""name"" content="".*"">")
                Dim matches_c As MatchCollection = c.Matches(sourcecode)

                For Each itemcode_t As Match In matches_c

                    list_y.the_channel = "channel:" + itemcode_t.Value.Split("""").GetValue(3)


                Next


                'get id

                list_y.the_id = "id:" + s
                list_y.the_id_tag = s


                'add the video
                FlowLayoutPanel1.Controls.Add(list_y)


                AddHandler list_y.pic_click, AddressOf Pic_c
                AddHandler list_y.del_click, AddressOf del_c
                AddHandler list_y.download_click, AddressOf download_c
                AddHandler list_y.openLink_click, AddressOf open_c


            Next


            Label2.Text = FlowLayoutPanel1.Controls.Count.ToString() + " items"

            GunaWinCircleProgressIndicator1.Visible = False

            n = 0

            show_.Stop()


        End If



    End Sub

    Private Sub open_c(sender As Object, e As EventArgs)
        Dim ov As New openVideo

        ov.Show()

        openVideo._yUrl = DirectCast(sender, C_UI_.YutubeList_UI).the_id_tag


    End Sub

    Public Shared list_yd As New C_UI_.downlodVideo

    Private Sub download_c(sender As Object, e As EventArgs)


        Dim dv As New download_video()

        dv.Show()


        dv.Location = Me.Location

        dv.Size = Me.Size

        If Me.WindowState = FormWindowState.Maximized Then

            dv.WindowState = FormWindowState.Maximized
            dv.Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            dv.WindowState = FormWindowState.Normal
            dv.Label5.Text = Char.ConvertFromUtf32("&HE922")


        End If

        dv.BackColor = Me.BackColor
        dv.Panel2.BackColor = Panel2.BackColor
        dv.Circular_PictureBox1.BackColor = Circular_PictureBox1.BackColor

        If GunaSwitch1.Checked = True Then


            list_yd.the_back_color_url = Color.White
            list_yd.the_back_color_name = Color.White
            list_yd.the_url_font_color = Color.Black
            list_yd.the_name_font_coloe = Color.Black
            list_yd.the_channel_font_color = Color.Black
            list_yd.the_genre_font_color = Color.Black
            list_yd.the_id_font_color = Color.Black
            list_yd.the_number_font_color = Color.Black
            list_yd.the_date_font_color = Color.Black


        Else

            list_yd.the_back_color_url = Color.FromArgb(11, 11, 11)
            list_yd.the_back_color_name = Color.FromArgb(11, 11, 11)
            list_yd.the_url_font_color = Color.White
            list_yd.the_name_font_coloe = Color.White
            list_yd.the_channel_font_color = Color.White
            list_yd.the_genre_font_color = Color.White
            list_yd.the_id_font_color = Color.White
            list_yd.the_number_font_color = Color.White
            list_yd.the_date_font_color = Color.White

        End If


        dv.Label3.ForeColor = Label3.ForeColor
        dv.Label5.ForeColor = Label5.ForeColor
        dv.Label4.ForeColor = Label4.ForeColor
        dv.Label9.ForeColor = Label9.ForeColor
        dv.Label6.ForeColor = Label6.ForeColor


        dv.GunaResizeControl1.ForeColor = GunaResizeControl1.ForeColor
        dv.GunaResizeControl1.BackColor = GunaResizeControl1.BackColor
        dv.GunaLinePanel1.LineColor = GunaLinePanel1.LineColor


        dv.FlowLayoutPanel1.Controls.Clear()

        list_yd.the_number = "#" + DirectCast(sender, C_UI_.YutubeList_UI).Tag


            s = DirectCast(sender, C_UI_.YutubeList_UI).Name.Substring(DirectCast(sender, C_UI_.YutubeList_UI).Name.LastIndexOf("=") + 1)


        list_yd.Size = dv.FlowLayoutPanel1.Size

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(DirectCast(sender, C_UI_.YutubeList_UI).Name)
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim sourcecode As String = sr.ReadToEnd


        'get image of video

        list_yd.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/maxresdefault.jpg"
            list_yd.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/hqdefault.jpg"



            list_yd.the_image_sizeMode = PictureBoxSizeMode.StretchImage

        'get title

        Dim t As New System.Text.RegularExpressions.Regex("<meta name=""title"" content="".*"">")
        Dim matches_t As MatchCollection = t.Matches(sourcecode)

        For Each itemcode As Match In matches_t

            list_yd.the_name = itemcode.Value.Split("""").GetValue(3)


        Next

        'get url

        list_yd.Name = DirectCast(sender, C_UI_.YutubeList_UI).Name
            list_yd.the_url = DirectCast(sender, C_UI_.YutubeList_UI).Name
            dv.the_link_.Text = DirectCast(sender, C_UI_.YutubeList_UI).Name
            dv.the_link_id = s

        'get publish date





        Dim r As New Regex("<meta itemprop=""datePublished"" content="".*"">")
            Dim matches As MatchCollection = r.Matches(sourcecode)

            For Each itemcode As Match In matches

                list_yd.the_date = "publish on:" + itemcode.Value.Split("""").GetValue(3)


            Next



            'get genre

            Dim g As New Regex("<meta itemprop=""genre"" content="".*"">")
            Dim matches_g As MatchCollection = g.Matches(sourcecode)

            For Each itemcode_g As Match In matches_g

                list_yd.the_genre = "genre:" + itemcode_g.Value.Split("""").GetValue(3)


            Next



            'get channel name


            Dim c As New Regex("<link itemprop=""name"" content="".*"">")
            Dim matches_c As MatchCollection = c.Matches(sourcecode)

            For Each itemcode_t As Match In matches_c

                list_yd.the_channel = "channel:" + itemcode_t.Value.Split("""").GetValue(3)


            Next


            'get id

            list_yd.the_id = "id:" + s


        'add the video
        dv.FlowLayoutPanel1.Controls.Add(list_yd)


    End Sub

    Private Sub del_c(sender As Object, e As EventArgs)

        Dim w1 As New IO.StreamWriter("C:\Users\" + SystemInformation.UserName + "\Desktop\playList\url" + DirectCast(sender, C_UI_.YutubeList_UI).Tag + ".txt", True, Encoding.UTF8)
        w1.Write("(delete)")
        w1.Close()

        System.IO.File.Delete("C:\Users\" + SystemInformation.UserName + "\Desktop\playList\url" + DirectCast(sender, C_UI_.YutubeList_UI).Tag + ".txt")


        GunaWinCircleProgressIndicator1.Visible = True
        GunaWinCircleProgressIndicator1.ProgressColor = Color.Red

        show_.Start()


    End Sub

    Private Sub GunaSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaSwitch1.CheckedChanged

        show_.Start()

    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles TableLayoutPanel2.MouseEnter, Label8.MouseEnter, Label10.MouseEnter
        Label8.ForeColor = Color.LightGray
        Label10.ForeColor = Color.LightGray
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter, Label13.MouseEnter, TableLayoutPanel3.MouseEnter
        Label11.ForeColor = Color.LightGray
        Label13.ForeColor = Color.LightGray
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Label8.ForeColor = Color.White
        Label10.ForeColor = Color.White
        Label11.ForeColor = Color.White
        Label13.ForeColor = Color.White
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel3.Click, Label13.Click, Label11.Click
        Dim listD As New download_list

        listD.Show()

        listD.BackColor = Panel2.BackColor
        listD.GunaLinePanel1.LineColor = GunaLinePanel1.LineColor
        listD.Label3.ForeColor = Label3.ForeColor
        listD.Label11.ForeColor = Label3.ForeColor


    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim offl As New offlineList

        offl.Show()

        offl.Location = Me.Location

        offl.Size = Me.Size

        If Me.WindowState = FormWindowState.Maximized Then

            offl.WindowState = FormWindowState.Maximized
            offl.Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            offl.WindowState = FormWindowState.Normal
            offl.Label5.Text = Char.ConvertFromUtf32("&HE922")


        End If

        offl.BackColor = Me.BackColor
        offl.Panel2.BackColor = Panel2.BackColor
        offl.Circular_PictureBox1.BackColor = Circular_PictureBox1.BackColor

        If GunaSwitch1.Checked = True Then


            offl.Label1.ForeColor = Color.Black
            offl.listView1.BackColor = Me.BackColor
            offl.listView1.ForeColor = Color.Black

        Else

            offl.Label1.ForeColor = Color.LightGray
            offl.listView1.BackColor = Me.BackColor
            offl.listView1.ForeColor = Color.White

        End If


        offl.Label3.ForeColor = Label3.ForeColor
        offl.Label5.ForeColor = Label5.ForeColor
        offl.Label4.ForeColor = Label4.ForeColor
        offl.Label9.ForeColor = Label9.ForeColor
        offl.Label6.ForeColor = Label6.ForeColor
        offl.Label12.ForeColor = Label12.ForeColor
        offl.Label14.ForeColor = Label14.ForeColor


        offl.GunaResizeControl1.ForeColor = GunaResizeControl1.ForeColor
        offl.GunaResizeControl1.BackColor = GunaResizeControl1.BackColor
        offl.GunaLinePanel1.LineColor = GunaLinePanel1.LineColor

        Me.Close()

    End Sub

    Private Sub timer1_Tick_1(sender As Object, e As EventArgs) Handles timer1.Tick
        FlowLayoutPanel1.VerticalScroll.Value = gunaVScrollBar1.Value

    End Sub

    Private Sub FlowLayoutPanel1_MouseEnter(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.MouseEnter
        gunaVScrollBar1.Maximum = FlowLayoutPanel1.VerticalScroll.Maximum
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

        If wifi_.ConnectionStatus = WifiStatus.Connected Then

            Shell("cmd.exe /c cd/ & cd Users & cd " + SystemInformation.UserName + " & cd Desktop & cd Myplaylist & cd music_player_ & cd bin & cd x86 & cd Release & start music_player_.exe", AppWinStyle.Hide)



        Else

            Dim eW As New wifi_error
            eW.Show()

            eW.BackColor = Panel2.BackColor
            eW.GunaLinePanel1.LineColor = GunaLinePanel1.LineColor
            eW.Label3.ForeColor = Label3.ForeColor

        End If


    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

        GunaWinCircleProgressIndicator1.Visible = True
        GunaWinCircleProgressIndicator1.ProgressColor = Color.DodgerBlue

        show_.Start()
    End Sub
End Class
