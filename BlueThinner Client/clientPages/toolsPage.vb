
Public Class ToolsPage
    Private OpenFileDialog As OpenFileDialog
    Public Property OpenFileDialog1 As Object
    Private urislist As List(Of Uri)
    Private LastAudioUri As Uri
    Private bgmprocess As Process


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' W.I.P.

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

        ' Basically finished

        OpenFileDialog = New OpenFileDialog With {
        .Filter = "quickbms (quickbms.exe)|quickbms.exe", 'You can add anything to this filter, you do: "Name file (*.EXTENTION)|*.EXTENTION"
        .Title = "Couldn't find quickbms automatically, select the quickbms application:"
        }

        bgmprocess = New Process
        bgmprocess.StartInfo.FileName = (IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().CodeBase) + "\pak\quickbms.exe") 'Get current path and add the default path to the quickbms.exe
        bgmprocess.StartInfo.Arguments = "-. epic-mickey.bms" 'Automatically get the .bms file if possible

        Try
            bgmprocess.Start()
        Catch err As System.ComponentModel.Win32Exception
            If OpenFileDialog.ShowDialog() = DialogResult.OK Then 'Run the FileDialog and wait for the user to select a file.
                bgmprocess = New Process
                bgmprocess.StartInfo.FileName = OpenFileDialog.FileName
                bgmprocess.Start()
            End If
        End Try
    End Sub
End Class