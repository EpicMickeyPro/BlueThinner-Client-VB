Public Class toolsPage
    Private OpenFileDialog As Object
    Private p As Object
    Public Property OpenFileDialog1 As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub toolsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub PackfilesQuickBMSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PackfilespakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackfilespakToolStripMenuItem.Click
        quickBMS.Show()
    End Sub

    Private Sub EpicMickeyAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EpicMickeyAudioToolStripMenuItem.Click
        downloadEMAConverter.Show()
    End Sub

    Private Sub Download7zipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Download7zipToolStripMenuItem.Click
        download_7zip.Show()
    End Sub
End Class
