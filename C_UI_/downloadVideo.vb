Public Class downlodVideo

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    Private Sub downloadVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetDoubleBuffering(Panel2, True)
        SetDoubleBuffering(Panel1, True)
        SetDoubleBuffering(Panel3, True)
        SetDoubleBuffering(Panel4, True)
        SetDoubleBuffering(Panel5, True)


    End Sub

    Public Property the_dock() As DockStyle
        Get
            Return Me.Dock
        End Get
        Set(ByVal value As DockStyle)
            Me.Dock = value
        End Set
    End Property

    Public Property the_image() As Image
        Get
            Return PictureBox1.Image
        End Get
        Set(ByVal value As Image)
            PictureBox1.Image = value
        End Set
    End Property

    Public Property the_imageLocation() As String
        Get
            Return PictureBox1.ImageLocation
        End Get
        Set(ByVal value As String)
            PictureBox1.ImageLocation = value
        End Set
    End Property

    Public Property the_image_sizeMode() As PictureBoxSizeMode
        Get
            Return PictureBox1.SizeMode
        End Get
        Set(ByVal value As PictureBoxSizeMode)
            PictureBox1.SizeMode = value
        End Set
    End Property
    Public Property the_image_size() As Size
        Get
            Return PictureBox1.Size
        End Get
        Set(ByVal value As Size)
            PictureBox1.Size = value
        End Set
    End Property

    Public Property the_image_name() As String
        Get
            Return PictureBox1.Name
        End Get
        Set(ByVal value As String)
            PictureBox1.Name = value
        End Set
    End Property

    Public Property the_back_color_list() As Color
        Get
            Return Me.BackColor
        End Get
        Set(ByVal value As Color)
            Me.BackColor = value
        End Set
    End Property

    Public Property the_url() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As String)
            TextBox1.Text = value
        End Set
    End Property
    Public Property the_url_font_color() As Color
        Get
            Return TextBox1.ForeColor
        End Get
        Set(ByVal value As Color)
            TextBox1.ForeColor = value
        End Set
    End Property

    Public Property the_back_color_url() As Color
        Get
            Return TextBox1.BackColor
        End Get
        Set(ByVal value As Color)
            TextBox1.BackColor = value
        End Set
    End Property

    Public Property the_name() As String
        Get
            Return TextBox2.Text
        End Get
        Set(ByVal value As String)
            TextBox2.Text = value
        End Set
    End Property

    Public Property the_name_font_coloe() As Color
        Get
            Return TextBox2.ForeColor
        End Get
        Set(ByVal value As Color)
            TextBox2.ForeColor = value
        End Set
    End Property


    Public Property the_back_color_name() As Color
        Get
            Return TextBox2.BackColor
        End Get
        Set(ByVal value As Color)
            TextBox2.BackColor = value
        End Set
    End Property

    Public Property the_date() As String
        Get
            Return Label8.Text

        End Get
        Set(ByVal value As String)
            Label8.Text = value
        End Set
    End Property

    Public Property the_date_font_color() As Color
        Get
            Return Label8.ForeColor

        End Get
        Set(ByVal value As Color)
            Label8.ForeColor = value
        End Set
    End Property

    Public Property the_genre() As String
        Get
            Return Label5.Text
        End Get
        Set(ByVal value As String)
            Label5.Text = value
        End Set
    End Property

    Public Property the_genre_font_color() As Color
        Get
            Return Label5.ForeColor
        End Get
        Set(ByVal value As Color)
            Label5.ForeColor = value
        End Set
    End Property

    Public Property the_channel() As String
        Get
            Return Label6.Text
        End Get
        Set(ByVal value As String)
            Label6.Text = value
        End Set
    End Property

    Public Property the_channel_font_color() As Color
        Get
            Return Label6.ForeColor
        End Get
        Set(ByVal value As Color)
            Label6.ForeColor = value
        End Set
    End Property

    Public Property the_number() As String
        Get
            Return Label2.Text
        End Get
        Set(ByVal value As String)
            Label2.Text = value
        End Set
    End Property

    Public Property the_number_font_color() As Color
        Get
            Return Label2.ForeColor
        End Get
        Set(ByVal value As Color)
            Label2.ForeColor = value
        End Set
    End Property

    Public Property the_id() As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Public Property the_id_font_color() As Color
        Get
            Return Label1.ForeColor
        End Get
        Set(ByVal value As Color)
            Label1.ForeColor = value
        End Set
    End Property

    Public Property the_size() As Size
        Get
            Return Me.Size
        End Get
        Set(ByVal value As Size)
            Me.Size = value
        End Set
    End Property

    Public Event pic_click As EventHandler
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RaiseEvent pic_click(Me, e)

    End Sub

    Public Event download_video_click As EventHandler
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Label7.Click
        RaiseEvent download_video_click(Panel4, e)
    End Sub
    Public Event openLink_click As EventHandler
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Label4.Click
        RaiseEvent openLink_click(Panel3, e)
    End Sub
    Public Event download_sound_click As EventHandler
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles Panel5.Click, Label9.Click
        RaiseEvent download_sound_click(Panel5, e)
    End Sub
End Class
