Public Class mtb
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Mainlabel.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo notfound
        Process.Start("lib\mcm\melee code manager.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub HPSAutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HPSAutoToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\HPSAuto.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub DATTextureWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATTextureWizardToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\DTW\dat texture wizard.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub MeleeToolkitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeToolkitToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\meleetoolkit.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub MeleeToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeToolboxToolStripMenuItem.Click
        MessageBox.Show("This is the Melee Toolbox, baka.")
    End Sub

    Private Sub TextureFinderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureFinderToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\texturefinder.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub UniversalModelConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UniversalModelConverterToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\umc\umc.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub VertConvertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VertConvertToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\vertconvert.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub MeleeCodeManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeCodeManagerToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\mcm\melee code manager.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub ASMTofromWiiRDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASMTofromWiiRDToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\gdnet\asmwiird.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub CrazyHandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrazyHandToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\chand\chand.bat")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub DolphinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DolphinToolStripMenuItem1.Click
        On Error GoTo notfound
        Process.Start("lib\dolphin\dolphin.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub GCRebuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GCRebuilderToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\gcr.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub DolphinDebugFastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DolphinDebugFastToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\dolphindf\dolphin.exe /d")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub HxDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HxDToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\hxd.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub SSBMVersionPatcherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSBMVersionPatcherToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\versionpatch\ssbm_patch.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub ProjektNekoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjektNekoToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\len\Projekt Len.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub EffectsChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EffectsChangerToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\effectschanger.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub LaserChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaserChangerToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\laserchanger.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub AboutMeleeToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeleeToolboxToolStripMenuItem.Click
        Dim AboutBox As New AboutToolbox
        AboutBox.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo notfound
        Process.Start("lib\DTW\dat texture wizard.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo notfound
        Process.Start("lib\chand\chand.bat")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo notfound
        Process.Start("lib\dolphin\dolphin.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error GoTo notfound
        Process.Start("lib\dolphindf\dolphin.exe /d")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo notfound
        Process.Start("lib\gcr.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error GoTo notfound
        Process.Start("lib\hxd.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim AboutBox As New AboutToolbox
        AboutBox.Show()
    End Sub

    Private Sub XXMusicManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XXMusicManagerToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\20xxmm\20XX Music Manager.jar")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub ApplicationCreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationCreditsToolStripMenuItem.Click
        Dim AppCredits As New AppCredits
        AppCredits.Show()
    End Sub

    Private Sub D2hguiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles D2hguiToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\d2hgui.exe")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Private Sub MeleeAudioConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeAudioConverterToolStripMenuItem.Click
        On Error GoTo notfound
        Process.Start("lib\Melee Audio Converter.jar")
        Return
notfound:
        MessageBox.Show("App not found. Update it in the Update Applications menu.")
    End Sub

    Public Sub UpdateApps(ByVal apper As String)
appupdate:
        Dim mc = My.Computer
        On Error GoTo updatewhat
        REM Console.WriteLine("debug: " + cmdArgs(0) + " " + cmdArgs(1))
        If apper IsNot Nothing Then
            On Error GoTo updatefail
            REM Console.WriteLine("  Updating " + mtbapp + "...")
            mc.Network.DownloadFile("http://portland.refreshnet.co.uk/toolbox/" + apper + ".7z", "dl\" + apper + ".7z")
            Using mtbupdate As New Process
                mtbupdate.StartInfo.Arguments = "x -aoa -y dl\" + apper + ".7z"
                mtbupdate.StartInfo.FileName = "\lib\7z.exe"
                mtbupdate.Start()
                mtbupdate.WaitForExit()
            End Using
            mc.FileSystem.DeleteFile("dl\" + apper + ".7z")
            MessageBox.Show("  Done.")
            Return
        End If
        ' Theoretically nothing below this should happen, and if it does it's a bug.
        If apper Is Nothing Then
updatewhat:
            MessageBox.Show("  Update what? (you didn't specify an app)")
            Return
        End If
updatefail:
        MessageBox.Show("Application '" + apper + "' couldn't be downloaded. Check your internet connection and try again later.")
    End Sub

    Private Sub XXMusicManagerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles XXMusicManagerToolStripMenuItem1.Click
        Dim apper = "20xxmm"
        UpdateApps(apper)
    End Sub

    Private Sub ASMTofromWiiRDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ASMTofromWiiRDToolStripMenuItem1.Click
        Dim apper = "asmwiird"
        UpdateApps(apper)
    End Sub

    Private Sub CrazyHandToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrazyHandToolStripMenuItem1.Click
        Dim apper = "crazyhand"
        UpdateApps(apper)
    End Sub

    Private Sub D2hguiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles D2hguiToolStripMenuItem1.Click
        Dim apper = "d2hgui"
        UpdateApps(apper)
    End Sub

    Private Sub DATTextureWizardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DATTextureWizardToolStripMenuItem1.Click
        Dim apper = "dtw"
        UpdateApps(apper)
    End Sub

    Private Sub DolphinDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DolphinDFToolStripMenuItem.Click
        Dim apper = "dolphin"
        UpdateApps(apper)
    End Sub

    Private Sub EffectsChangerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EffectsChangerToolStripMenuItem1.Click
        Dim apper = "efchg"
        UpdateApps(apper)
    End Sub

    Private Sub GCRebuilderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GCRebuilderToolStripMenuItem1.Click
        Dim apper = "gcr"
        UpdateApps(apper)
    End Sub

    Private Sub HPSAutoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HPSAutoToolStripMenuItem1.Click
        Dim apper = "hpsauto"
        UpdateApps(apper)
    End Sub

    Private Sub HxDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HxDToolStripMenuItem1.Click
        Dim apper = "hxd"
        UpdateApps(apper)
    End Sub

    Private Sub LaserChangerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaserChangerToolStripMenuItem1.Click
        Dim apper = "laschg"
        UpdateApps(apper)
    End Sub

    Private Sub MeleeAudioConverterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MeleeAudioConverterToolStripMenuItem1.Click
        Dim apper = "mac"
        UpdateApps(apper)
    End Sub

    Private Sub MeleeCodeManagerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MeleeCodeManagerToolStripMenuItem1.Click
        Dim apper = "mcm"
        UpdateApps(apper)
    End Sub

    Private Sub MeleeToolboxToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MeleeToolboxToolStripMenuItem1.Click
        MessageBox.Show("Baka, you can just click ""Update Toolbox"" on the main menu.")
    End Sub

    Private Sub MeleeToolkitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MeleeToolkitToolStripMenuItem1.Click
        Dim apper = "toolkit"
        UpdateApps(apper)
    End Sub

    Private Sub ProjektLenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjektLenToolStripMenuItem.Click
        Dim apper = "len"
        UpdateApps(apper)
    End Sub

    Private Sub SSBMVersionPatcherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SSBMVersionPatcherToolStripMenuItem1.Click
        Dim apper = "ssbmver"
        UpdateApps(apper)
    End Sub

    Private Sub TextureFinderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TextureFinderToolStripMenuItem1.Click
        Dim apper = "texfind"
        UpdateApps(apper)
    End Sub

    Private Sub UniversalModelConverterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UniversalModelConverterToolStripMenuItem1.Click
        Dim apper = "umc"
        UpdateApps(apper)
    End Sub

    Private Sub VertConvertToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VertConvertToolStripMenuItem1.Click
        Dim apper = "vertconv"
        UpdateApps(apper)
    End Sub

    Private Sub UpdateToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolboxToolStripMenuItem.Click
        Dim apper = "toolbox"
        UpdateApps(apper)
    End Sub
End Class
