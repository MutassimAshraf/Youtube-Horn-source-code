<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfflineVideoPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColorLinearGradient1 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorLinearGradient2 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorLinearGradient3 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfflineVideoPlayer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaCircleButton3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GTrackBar2 = New gTrackBar.gTrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GTrackBar1 = New gTrackBar.gTrackBar()
        Me.play_ = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaCircleButton3)
        Me.Panel1.Controls.Add(Me.GunaCircleButton2)
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GTrackBar2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GTrackBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 623)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1079, 75)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(397, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(405, 53)
        Me.TableLayoutPanel1.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Name"
        '
        'GunaCircleButton3
        '
        Me.GunaCircleButton3.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton3.AnimationSpeed = 0.03!
        Me.GunaCircleButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 20.0!)
        Me.GunaCircleButton3.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.Image = Nothing
        Me.GunaCircleButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton3.Location = New System.Drawing.Point(84, 23)
        Me.GunaCircleButton3.Name = "GunaCircleButton3"
        Me.GunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.OnHoverImage = Nothing
        Me.GunaCircleButton3.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.Size = New System.Drawing.Size(35, 35)
        Me.GunaCircleButton3.TabIndex = 55
        Me.GunaCircleButton3.Text = ""
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Nothing
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(138, 23)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.Size = New System.Drawing.Size(35, 35)
        Me.GunaCircleButton2.TabIndex = 54
        Me.GunaCircleButton2.Text = ""
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(32, 23)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(35, 35)
        Me.GunaCircleButton1.TabIndex = 53
        Me.GunaCircleButton1.Text = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe MDL2 Assets", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1022, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(973, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = ""
        '
        'GTrackBar2
        '
        Me.GTrackBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GTrackBar2.BackColor = System.Drawing.Color.Transparent
        Me.GTrackBar2.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Image
        Me.GTrackBar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GTrackBar2.FloatValue = False
        Me.GTrackBar2.FloatValueFontColor = System.Drawing.Color.DodgerBlue
        Me.GTrackBar2.JumpToMouse = True
        Me.GTrackBar2.Label = Nothing
        Me.GTrackBar2.Location = New System.Drawing.Point(803, 38)
        Me.GTrackBar2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTrackBar2.MaxValue = 100
        Me.GTrackBar2.Name = "GTrackBar2"
        Me.GTrackBar2.ShowFocus = False
        Me.GTrackBar2.Size = New System.Drawing.Size(130, 3)
        Me.GTrackBar2.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Flat
        Me.GTrackBar2.SliderCapStart = System.Drawing.Drawing2D.LineCap.Flat
        ColorLinearGradient1.ColorA = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        ColorLinearGradient1.ColorB = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GTrackBar2.SliderColorHigh = ColorLinearGradient1
        ColorLinearGradient2.ColorA = System.Drawing.Color.White
        ColorLinearGradient2.ColorB = System.Drawing.Color.White
        Me.GTrackBar2.SliderColorLow = ColorLinearGradient2
        Me.GTrackBar2.SliderSize = New System.Drawing.Size(20, 0)
        Me.GTrackBar2.SliderWidthHigh = 10.0!
        Me.GTrackBar2.SliderWidthLow = 10.0!
        Me.GTrackBar2.TabIndex = 50
        Me.GTrackBar2.TickThickness = 1.0!
        Me.GTrackBar2.UpDownShow = False
        Me.GTrackBar2.Value = 50
        Me.GTrackBar2.ValueAdjusted = 50.0!
        Me.GTrackBar2.ValueDivisor = gTrackBar.gTrackBar.eValueDivisor.e1
        Me.GTrackBar2.ValueStrFormat = ""
        Me.GTrackBar2.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(938, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(196, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "0:00/0:00"
        '
        'GTrackBar1
        '
        Me.GTrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.GTrackBar1.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Image
        Me.GTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GTrackBar1.FloatValue = False
        Me.GTrackBar1.FloatValueFontColor = System.Drawing.Color.DodgerBlue
        Me.GTrackBar1.JumpToMouse = True
        Me.GTrackBar1.Label = Nothing
        Me.GTrackBar1.Location = New System.Drawing.Point(-11, 0)
        Me.GTrackBar1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTrackBar1.MaxValue = 100
        Me.GTrackBar1.Name = "GTrackBar1"
        Me.GTrackBar1.ShowFocus = False
        Me.GTrackBar1.Size = New System.Drawing.Size(1103, 3)
        Me.GTrackBar1.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Flat
        Me.GTrackBar1.SliderCapStart = System.Drawing.Drawing2D.LineCap.Flat
        ColorLinearGradient3.ColorA = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        ColorLinearGradient3.ColorB = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GTrackBar1.SliderColorHigh = ColorLinearGradient3
        Me.GTrackBar1.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar1.SliderSize = New System.Drawing.Size(20, 0)
        Me.GTrackBar1.SliderWidthHigh = 10.0!
        Me.GTrackBar1.SliderWidthLow = 10.0!
        Me.GTrackBar1.TabIndex = 47
        Me.GTrackBar1.TickThickness = 1.0!
        Me.GTrackBar1.UpDownShow = False
        Me.GTrackBar1.Value = 0
        Me.GTrackBar1.ValueAdjusted = 0!
        Me.GTrackBar1.ValueDivisor = gTrackBar.gTrackBar.eValueDivisor.e1
        Me.GTrackBar1.ValueStrFormat = ""
        '
        'play_
        '
        Me.play_.Enabled = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1079, 623)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Myplaylist.My.Resources.Resources.icons8_sort_down_20px
        Me.PictureBox3.Location = New System.Drawing.Point(1054, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.Image = Global.Myplaylist.My.Resources.Resources.channels4_profile
        Me.PictureBox1.Location = New System.Drawing.Point(339, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.Myplaylist.My.Resources.Resources.channels4_profile
        Me.PictureBox2.Location = New System.Drawing.Point(390, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(299, 256)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'OfflineVideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1079, 698)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OfflineVideoPlayer"
        Me.Text = "OfflineVideoPlayer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GTrackBar1 As gTrackBar.gTrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents GTrackBar2 As gTrackBar.gTrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    '  Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label7 As Label
    Friend WithEvents GunaCircleButton3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents play_ As Timer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
