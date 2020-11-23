<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class offlineList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(offlineList))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.gunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.GunaResizeControl1 = New Guna.UI.WinForms.GunaResizeControl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Circular_PictureBox1 = New C_UI_.Circular_PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.time_ = New System.Windows.Forms.Timer(Me.components)
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLinePanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinePanel1.Controls.Add(Me.gunaVScrollBar1)
        Me.GunaLinePanel1.Controls.Add(Me.GunaResizeControl1)
        Me.GunaLinePanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GunaLinePanel1.Controls.Add(Me.Panel2)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineBottom = 3
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaLinePanel1.LineLeft = 3
        Me.GunaLinePanel1.LineRight = 3
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.LineTop = 3
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(977, 625)
        Me.GunaLinePanel1.TabIndex = 5
        '
        'gunaVScrollBar1
        '
        Me.gunaVScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.gunaVScrollBar1.LargeChange = 10
        Me.gunaVScrollBar1.Location = New System.Drawing.Point(942, 162)
        Me.gunaVScrollBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.gunaVScrollBar1.Maximum = 1
        Me.gunaVScrollBar1.Name = "gunaVScrollBar1"
        Me.gunaVScrollBar1.Radius = 2
        Me.gunaVScrollBar1.ScrollbarSize = 5
        Me.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gunaVScrollBar1.Size = New System.Drawing.Size(29, 452)
        Me.gunaVScrollBar1.TabIndex = 68
        Me.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'GunaResizeControl1
        '
        Me.GunaResizeControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaResizeControl1.BackColor = System.Drawing.Color.Transparent
        Me.GunaResizeControl1.ForeColor = System.Drawing.Color.White
        Me.GunaResizeControl1.ForeColorDepth = 255
        Me.GunaResizeControl1.Location = New System.Drawing.Point(3, 593)
        Me.GunaResizeControl1.Name = "GunaResizeControl1"
        Me.GunaResizeControl1.Size = New System.Drawing.Size(972, 28)
        Me.GunaResizeControl1.TabIndex = 5
        Me.GunaResizeControl1.TargetControl = Me
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.listView1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 162)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(968, 452)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'listView1
        '
        Me.listView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.listView1.ForeColor = System.Drawing.Color.White
        Me.listView1.FullRowSelect = True
        Me.listView1.HideSelection = False
        Me.listView1.LargeImageList = Me.imageList1
        Me.listView1.Location = New System.Drawing.Point(2, 2)
        Me.listView1.Margin = New System.Windows.Forms.Padding(2)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(966, 52428)
        Me.listView1.SmallImageList = Me.imageList1
        Me.listView1.TabIndex = 67
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.List
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(30, 30)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Circular_PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(971, 158)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Myplaylist.My.Resources.Resources.youtube_horn
        Me.PictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(824, 7)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = ""
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(856, 7)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = ""
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(893, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 11)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(55, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Youtube Horn v1.0 | Offline"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(920, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 11)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ""
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(945, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 11)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(435, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 21)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "dateTime:-----"
        '
        'Circular_PictureBox1
        '
        Me.Circular_PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Circular_PictureBox1.Image = Global.Myplaylist.My.Resources.Resources.admin_d2
        Me.Circular_PictureBox1.Location = New System.Drawing.Point(17, 61)
        Me.Circular_PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Circular_PictureBox1.Name = "Circular_PictureBox1"
        Me.Circular_PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.Circular_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Circular_PictureBox1.TabIndex = 9
        Me.Circular_PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(87, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0 items"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'time_
        '
        Me.time_.Enabled = True
        Me.time_.Interval = 1000
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'offlineList
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(977, 625)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(977, 625)
        Me.Name = "offlineList"
        Me.Text = "offlineList"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaResizeControl1 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Circular_PictureBox1 As C_UI_.Circular_PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents time_ As Timer
    Private WithEvents imageList1 As ImageList
    Private WithEvents gunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Private WithEvents timer1 As Timer
    Public WithEvents listView1 As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
