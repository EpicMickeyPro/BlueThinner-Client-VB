Public Class clientHomePage
    Private Sub clientHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        toolsPage.Show()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("v1.0.0 (DEV)

        


Created by EMP - Epic Mickey Pro#7741")

    End Sub
End Class
