<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class download_video
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(download_video))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaResizeControl1 = New Guna.UI.WinForms.GunaResizeControl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.time_ = New System.Windows.Forms.Timer(Me.components)
        Me.show_ = New System.Windows.Forms.Timer(Me.components)
        Me.Circular_PictureBox1 = New C_UI_.Circular_PictureBox()
        Me.GunaLinePanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
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
        Me.GunaLinePanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1221, 781)
        Me.GunaLinePanel1.TabIndex = 5
        Me.GunaLinePanel1.Visible = False
        '
        'GunaResizeControl1
        '
        Me.GunaResizeControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaResizeControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.GunaResizeControl1.ForeColor = System.Drawing.Color.White
        Me.GunaResizeControl1.ForeColorDepth = 255
        Me.GunaResizeControl1.Location = New System.Drawing.Point(4, 768)
        Me.GunaResizeControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaResizeControl1.Name = "GunaResizeControl1"
        Me.GunaResizeControl1.Size = New System.Drawing.Size(1214, 9)
        Me.GunaResizeControl1.TabIndex = 5
        Me.GunaResizeControl1.TargetControl = Me
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 159)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1214, 599)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GunaElipsePanel2)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Circular_PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(4, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1214, 154)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.Label8)
        Me.GunaElipsePanel2.Controls.Add(Me.TextBox2)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(642, 69)
        Me.GunaElipsePanel2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(165, 34)
        Me.GunaElipsePanel2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 8)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = ""
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(34, 5)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 21)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "mp3"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label7)
        Me.GunaElipsePanel1.Controls.Add(Me.TextBox1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(468, 70)
        Me.GunaElipsePanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(165, 34)
        Me.GunaElipsePanel1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ""
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(34, 5)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 21)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "mp4"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(1130, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = ""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(1160, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = ""
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(544, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 28)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "dateTime:-----"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(1190, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(104, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name"
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
        'show_
        '
        '
        'Circular_PictureBox1
        '
        Me.Circular_PictureBox1.Image = Global.Myplaylist.My.Resources.Resources.admin_d2
        Me.Circular_PictureBox1.Location = New System.Drawing.Point(19, 31)
        Me.Circular_PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Circular_PictureBox1.Name = "Circular_PictureBox1"
        Me.Circular_PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.Circular_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Circular_PictureBox1.TabIndex = 9
        Me.Circular_PictureBox1.TabStop = False
        '
        'download_video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1221, 781)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1221, 781)
        Me.Name = "download_video"
        Me.Text = "downlod_video"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaResizeControl1 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Circular_PictureBox1 As C_UI_.Circular_PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents time_ As Timer
    Friend WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents show_ As Timer
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Public WithEvents Panel2 As Panel
End Class
