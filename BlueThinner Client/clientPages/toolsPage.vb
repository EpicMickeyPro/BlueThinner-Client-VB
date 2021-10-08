
Public Class ToolsPage
    Private OpenFileDialog As OpenFileDialog
    Public Property OpenFileDialog1 As Object
    Private urislist As List(Of Uri)
    Private LastAudioUri As Uri
    Private bgmprocess As Process
    'Public quickBMSUri As Uri


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog = New OpenFileDialog With {
            .Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*" 'You can add anything to this filter, you do: "Name file (*.EXTENTION)|*.EXTENTION"
            }
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            urislist.Add(New Uri(OpenFileDialog.FileName)) 'For if you want a list of Uri's (Basically file paths).
            LastAudioUri = New Uri(OpenFileDialog.FileName) 'For if you only want the latest Uri.
            'You can use the list for if you want all the inputted paths to be used at once.
            'You can use the single Uri for if you only want 1 file to be proccessed.
        End If
    End Sub

    Private Sub ToolsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog = New OpenFileDialog With {
            .Filter = "quickbms (quickbms.exe)|quickbms.exe|All files (*.*)|*.*", 'You can add anything to this filter, you do: "Name file (*.EXTENTION)|*.EXTENTION"
            .Title = "Select the quickbms application:"
        }
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            bgmprocess = New Process
            bgmprocess.StartInfo.FileName = OpenFileDialog.FileName
            bgmprocess.StartInfo.Arguments = ""
            bgmprocess.Start()
        End If
    End Sub
End Class