Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Circular_PictureBox : Inherits PictureBox

    Protected Overrides Sub onpaint(ByVal pe As PaintEventArgs)



        MyBase.OnPaint(pe)

        Using obj As GraphicsPath = New GraphicsPath()

            obj.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)
            Region = New System.Drawing.Region(obj)
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            pe.Graphics.DrawEllipse(New System.Drawing.Pen(New SolidBrush(Me.BackColor), 1), 0, 0, Me.Width - 1, Me.Height - 1)

        End Using




    End Sub

End Class