<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class openVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(openVideo))
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.gunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.start_url = New System.Windows.Forms.Timer(Me.components)
        Me.bunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.Location = New System.Drawing.Point(0, 59)
        Me.webBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(15, 14)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.ScrollBarsEnabled = False
        Me.webBrowser1.Size = New System.Drawing.Size(704, 451)
        Me.webBrowser1.TabIndex = 7
        '
        'gunaElipse1
        '
        Me.gunaElipse1.Radius = 2
        Me.gunaElipse1.TargetControl = Me
        '
        'start_url
        '
        Me.start_url.Enabled = True
        Me.start_url.Interval = 29
        '
        'bunifuDragControl1
        '
        Me.bunifuDragControl1.Fixed = True
        Me.bunifuDragControl1.Horizontal = True
        Me.bunifuDragControl1.TargetControl = Me.panel1
        Me.bunifuDragControl1.Vertical = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(704, 59)
        Me.panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(680, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 11)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(704, 510)
        Me.Controls.Add(Me.webBrowser1)
        Me.Controls.Add(Me.panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "openVideo"
        Me.Text = "openVideo"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents webBrowser1 As WebBrowser
    Private WithEvents gunaElipse1 As Guna.UI.WinForms.GunaElipse
    Private WithEvents panel1 As Panel
    Private WithEvents start_url As Timer
    Private WithEvents bunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label3 As Label
End Class
