Public Class YutubeList_UI

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    Private Sub YutubeList_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetDoubleBuffering(Panel2, True)
        SetDoubleBuffering(Panel1, True)
        SetDoubleBuffering(TableLayoutPanel1, True)
        SetDoubleBuffering(TableLayoutPanel2, True)
        SetDoubleBuffering(TableLayoutPanel3, True)
        SetDoubleBuffering(TableLayoutPanel4, True)
        SetDoubleBuffering(GunaElipsePanel1, True)
        SetDoubleBuffering(GunaElipsePanel2, True)
        SetDoubleBuffering(GunaElipsePanel3, True)

    End Sub

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

    Dim the_url_ As String

    Public Property the_url() As String
        Get
            Return the_url_
        End Get
        Set(ByVal value As String)
            the_url_ = value
        End Set
    End Property

    Public Property the_name() As String
        Get
            Return Label2.Text
        End Get
        Set(ByVal value As String)
            Label2.Text = value
        End Set
    End Property

    Public Property the_name_color() As Color
        Get
            Return Label2.ForeColor
        End Get
        Set(ByVal value As Color)
            Label2.ForeColor = value
        End Set
    End Property



    Public Property the_date() As String
        Get
            Return Label1.Text

        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Public Property the_date_color() As Color
        Get
            Return Label1.ForeColor

        End Get
        Set(ByVal value As Color)
            Label1.ForeColor = value
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

    Public Property the_genre_color() As Color
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

    Public Property the_channel_color() As Color
        Get
            Return Label6.ForeColor
        End Get
        Set(ByVal value As Color)
            Label6.ForeColor = value
        End Set
    End Property

    Dim the_num As String

    Public Property the_number() As String
        Get
            Return the_num
        End Get
        Set(ByVal value As String)
            the_num = value
        End Set
    End Property

    Dim the_id_ As New Label

    Public Property the_id() As String
        Get
            Return the_id_.Text
        End Get
        Set(ByVal value As String)
            the_id_.Text = value
        End Set
    End Property

    Public Property the_delete_backcolor() As Color
        Get
            Return GunaElipsePanel2.BaseColor
        End Get
        Set(ByVal value As Color)
            GunaElipsePanel2.BaseColor = value
        End Set
    End Property

    Public Property the_download_backcolor() As Color
        Get
            Return GunaElipsePanel1.BaseColor
        End Get
        Set(ByVal value As Color)
            GunaElipsePanel1.BaseColor = value
        End Set
    End Property

    Public Property the_open_backcolor() As Color
        Get
            Return GunaElipsePanel3.BaseColor
        End Get
        Set(ByVal value As Color)
            GunaElipsePanel3.BaseColor = value
        End Set
    End Property
    Dim the_id_tag_ As Object
    Public Property the_id_tag() As Object
        Get
            Return the_id_tag_
        End Get
        Set(ByVal value As Object)
            the_id_tag_ = value
        End Set
    End Property

    Public Event pic_click As EventHandler
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RaiseEvent pic_click(Me, e)
    End Sub
    Public Event del_click As EventHandler
    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click, TableLayoutPanel1.Click, Label10.Click

        Me.Hide()

        RaiseEvent del_click(Me, e)


    End Sub
    Public Event download_click As EventHandler
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, TableLayoutPanel3.Click, Label7.Click
        RaiseEvent download_click(Me, e)
    End Sub

    Private Sub TableLayoutPanel1_MouseEnter(sender As Object, e As EventArgs) Handles TableLayoutPanel1.MouseEnter
        Label10.ForeColor = Color.LightGray
        Label8.ForeColor = Color.LightGray
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter

        Label10.ForeColor = Color.White
        Label8.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label7.ForeColor = Color.White
        Label9.ForeColor = Color.White
        Label4.ForeColor = Color.White

    End Sub

    Private Sub TableLayoutPanel3_MouseEnter(sender As Object, e As EventArgs) Handles TableLayoutPanel3.MouseEnter
        Label3.ForeColor = Color.LightGray
        Label7.ForeColor = Color.LightGray
    End Sub

    Private Sub TableLayoutPanel4_MouseEnter(sender As Object, e As EventArgs) Handles TableLayoutPanel4.MouseEnter
        Label9.ForeColor = Color.LightGray
        Label4.ForeColor = Color.LightGray
    End Sub
    Public Event openLink_click As EventHandler
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel4.Click, Label9.Click, Label4.Click
        RaiseEvent openLink_click(Me, e)
    End Sub
End Class
