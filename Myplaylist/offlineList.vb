Imports System.IO
Imports System.Runtime.InteropServices
Imports SimpleWifi

Public Class offlineList

    Private Shared wifi_ As Wifi

    Public listfiles1 As New List(Of String)()

    <DllImport("uxtheme.dll", ExactSpelling:=True, CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(ByVal hwnd As IntPtr, ByVal pszSubAppName As String, ByVal pszSubIdList As String) As Integer
    End Function

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    Dim v As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Private Sub offlineList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        wifi_ = New Wifi()



        SetDoubleBuffering(Panel2, True)
        SetDoubleBuffering(FlowLayoutPanel1, True)
        SetDoubleBuffering(GunaLinePanel1, True)
        SetDoubleBuffering(GunaResizeControl1, True)

        'icon fornt text

        Label3.Text = Char.ConvertFromUtf32("&HE8BB")
        Label5.Text = Char.ConvertFromUtf32("&HE922")
        Label4.Text = Char.ConvertFromUtf32("&HE921")
        Label12.Text = Char.ConvertFromUtf32("&HE12B")
        Label14.Text = Char.ConvertFromUtf32("&HF0E3")

        Me.CenterToScreen()

        v = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel1, gunaVScrollBar1, False)

        Label6.Text = SystemInformation.UserName

        SetWindowTheme(Me.listView1.Handle, "Explorer", Nothing)

        Dim path_ As String = "C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineSound_list"
        Dim path_2 As String = "C:\Users\" + SystemInformation.UserName + "\Desktop\My_offlineVideo_list"


        For Each item As String In Directory.GetFiles(path_)

            imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item))
            Dim fi As New FileInfo(item)
            listfiles1.Add(fi.FullName)
            listView1.Items.Add(fi.Name, imageList1.Images.Count - 1)


        Next


        For Each item As String In Directory.GetFiles(path_2)

            imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item))
            Dim fi As New FileInfo(item)
            listfiles1.Add(fi.FullName)
            listView1.Items.Add(fi.Name, imageList1.Images.Count - 1)


        Next

        Label2.Text = listfiles1.Count.ToString() + " items"

    End Sub

    Private Sub time__Tick(sender As Object, e As EventArgs) Handles time_.Tick
        Label9.Text = DateTime.Now
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Minimized

        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

        If wifi_.ConnectionStatus = WifiStatus.Connected Then

            Dim f As New YoutubeHorn
            f.Show()

            f.Location = Me.Location
            f.Size = Me.Size

            If Me.WindowState = FormWindowState.Maximized Then

                f.WindowState = FormWindowState.Maximized
                f.Label5.Text = Char.ConvertFromUtf32("&HE923")

            Else

                f.WindowState = FormWindowState.Normal
                f.Label5.Text = Char.ConvertFromUtf32("&HE922")


            End If

            Me.Close()

        Else

            Dim eW As New wifi_error
            eW.Show()

            eW.BackColor = Panel2.BackColor
            eW.GunaLinePanel1.LineColor = GunaLinePanel1.LineColor
            eW.Label3.ForeColor = Label3.ForeColor

        End If



    End Sub

    Private Sub listView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listView1.MouseDoubleClick

        Dim vt As New OfflineVideoPlayer

        vt.Show()

        If listfiles1(listView1.FocusedItem.Index).Contains("mp3") OrElse listfiles1(listView1.FocusedItem.Index).Contains("wav") Then


            vt.AxWindowsMediaPlayer1.Visible = False

        End If

        vt.AxWindowsMediaPlayer1.URL = listfiles1(listView1.FocusedItem.Index)

    End Sub

    Private Sub listView1_MouseEnter(sender As Object, e As EventArgs) Handles listView1.MouseEnter
        gunaVScrollBar1.Maximum = FlowLayoutPanel1.VerticalScroll.Maximum

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        FlowLayoutPanel1.VerticalScroll.Value = gunaVScrollBar1.Value
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


End Class