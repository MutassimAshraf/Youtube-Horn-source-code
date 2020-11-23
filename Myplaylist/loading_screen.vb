Imports SimpleWifi

Public Class loading_screen

    Private Shared wifi_ As Wifi

    Private Sub loading_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        Label1.Text = "Welcome to Youtube Horn " + SystemInformation.UserName + " ..."

        wifi_ = New Wifi()

        Timer1.Start()

    End Sub
    Dim i As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        i += 1

        'Label1.Text = i.ToString

        If i = 50 Then

            If wifi_.ConnectionStatus = WifiStatus.Connected Then

                Dim m As New YoutubeHorn()
                m.Show()

                Me.Close()

            Else

                Dim mo As New offlineList()
                mo.Show()

                Me.Close()

            End If



        End If

    End Sub
End Class