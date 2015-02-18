Public Class ZombZLauncher
    Sub SetFormBackgroundImage()
        Me.BackgroundImage = My.Resources.bg
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim filecontent As String = My.Resources.ow1
        Dim Filename As String = "C:\Users\Public\ow1.cmd"
        My.Computer.FileSystem.WriteAllText(Filename, filecontent, False)
        Process.Start(Filename)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filecontent As String = My.Resources.ow2
        Dim Filename As String = "C:\Users\Public\ow2.cmd"
        My.Computer.FileSystem.WriteAllText(Filename, filecontent, False)
        Process.Start(Filename)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filecontent As String = My.Resources.ow3
        Dim Filename As String = "C:\Users\Public\ow3.cmd"
        My.Computer.FileSystem.WriteAllText(Filename, filecontent, False)
        Process.Start(Filename)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Dim filecontent As String = My.Resources.ow4
        Dim Filename As String = "C:\Users\Public\ow4.cmd"
        My.Computer.FileSystem.WriteAllText(Filename, filecontent, False)
        Process.Start(Filename)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim filecontent As String = My.Resources.op
        Dim Filename As String = "C:\Users\Public\op.cmd"
        My.Computer.FileSystem.WriteAllText(Filename, filecontent, False)
        Process.Start(Filename)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim url As String = "http://www.zombz.net"

        Process.Start(url)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim url As String = "ts3server://TS3.ZOMBZ.NET/?port=9172&nickname=Zombz Guest"

        Process.Start(url)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim url As String = "http://www.zombz.net"

        Process.Start(url)
    End Sub

    Private Sub ZombZLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filecontent As String = My.Resources.readme
        Dim Filename As String = "C:\Users\Public\readme.txt"
        My.Computer.FileSystem.WriteAllText(Filename, filecontent, False)
        Process.Start(Filename)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
