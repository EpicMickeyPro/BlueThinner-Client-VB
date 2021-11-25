<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class toolsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(toolsPage))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DownloadToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackfilespakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpicMickeyAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadGamebryo25ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Download7zipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert Epic Mickey 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Audio Files"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Extract PAK Files"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(334, 32)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 54)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Create PAK Files"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(851, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DownloadToolsToolStripMenuItem
        '
        Me.DownloadToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Download7zipToolStripMenuItem, Me.ToolStripSeparator1, Me.PackfilespakToolStripMenuItem, Me.EpicMickeyAudioToolStripMenuItem, Me.DownloadGamebryo25ToolStripMenuItem})
        Me.DownloadToolsToolStripMenuItem.Name = "DownloadToolsToolStripMenuItem"
        Me.DownloadToolsToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.DownloadToolsToolStripMenuItem.Text = "Download Tools"
        '
        'PackfilespakToolStripMenuItem
        '
        Me.PackfilespakToolStripMenuItem.Name = "PackfilespakToolStripMenuItem"
        Me.PackfilespakToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.PackfilespakToolStripMenuItem.Text = "Packfiles (.pak)"
        '
        'EpicMickeyAudioToolStripMenuItem
        '
        Me.EpicMickeyAudioToolStripMenuItem.Name = "EpicMickeyAudioToolStripMenuItem"
        Me.EpicMickeyAudioToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.EpicMickeyAudioToolStripMenuItem.Text = "Epic Mickey Audio Converter"
        '
        'DownloadGamebryo25ToolStripMenuItem
        '
        Me.DownloadGamebryo25ToolStripMenuItem.Name = "DownloadGamebryo25ToolStripMenuItem"
        Me.DownloadGamebryo25ToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.DownloadGamebryo25ToolStripMenuItem.Text = "Download Gamebryo 2.5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(711, 119)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(279, 6)
        '
        'Download7zipToolStripMenuItem
        '
        Me.Download7zipToolStripMenuItem.Name = "Download7zipToolStripMenuItem"
        Me.Download7zipToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.Download7zipToolStripMenuItem.Text = "Download 7-zip"
        '
        'toolsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.BlueThinner_Client.My.Resources.Resources.BlueThinner_Banner_SUPAHI1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(851, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "toolsPage"
        Me.Text = "Tools"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DownloadToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EpicMickeyAudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackfilespakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DownloadGamebryo25ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Download7zipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
