Public Class mtb
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Mainlabel.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Process.Start("lib\mcm\melee code manager.exe")
    End Sub

    Private Sub HPSAutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HPSAutoToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\HPSAuto.exe")
    End Sub

    Private Sub DATTextureWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATTextureWizardToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\DTW\dat texture wizard.exe")
    End Sub

    Private Sub MeleeToolkitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeToolkitToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\meleetoolkit.exe")
    End Sub

    Private Sub MeleeToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeToolboxToolStripMenuItem.Click
        MessageBox.Show("This is the Melee Toolbox, baka.")
    End Sub

    Private Sub TextureFinderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureFinderToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\texturefinder.exe")
    End Sub

    Private Sub VertConvertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VertConvertToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\vertconvert.exe")
    End Sub

    Private Sub MeleeCodeManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeleeCodeManagerToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\mcm\melee code manager.exe")
    End Sub

    Private Sub ASMTofromWiiRDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASMTofromWiiRDToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\gdnet\asmwiird.exe")
    End Sub

    Private Sub CrazyHandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrazyHandToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\chand\chand.jar")
    End Sub

    Private Sub DolphinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DolphinToolStripMenuItem1.Click
        On Error Resume Next
        Process.Start("lib\dolphin\dolphin.exe")
    End Sub

    Private Sub GCRebuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GCRebuilderToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\gcr.exe")
    End Sub

    Private Sub DolphinDebugFastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DolphinDebugFastToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\dolphindf\dolphin.exe /d")
    End Sub

    Private Sub HxDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HxDToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\hxd.exe")
    End Sub

    Private Sub SSBMVersionPatcherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSBMVersionPatcherToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\versionpatch\ssbm_patch.exe")
    End Sub

    Private Sub EffectsChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EffectsChangerToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\effectschanger.exe")
    End Sub

    Private Sub LaserChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaserChangerToolStripMenuItem.Click
        On Error Resume Next
        Process.Start("lib\laserchanger.exe")
    End Sub

    Private Sub AboutMeleeToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeleeToolboxToolStripMenuItem.Click
        MessageBox.Show("Melee Toolbox 4.0" + Environment.NewLine +
                        "Compiled on " + DateString + " " + TimeString + Environment.NewLine + Environment.NewLine +
                        "Copyright 2015, 16 Doqtor Kirby" + Environment.NewLine +
                        "Melee Toolbox is provided to you under the terms of the GNU General Public License version 3.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Process.Start("lib\DTW\dat texture wizard.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        Process.Start("lib\chand\chand.jar")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        Process.Start("lib\dolphin\dolphin.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next
        Process.Start("lib\dolphindf\dolphin.exe /d")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        Process.Start("lib\gcr.exe")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error Resume Next
        Process.Start("lib\hxd.exe")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Melee Toolbox 4.0" + Environment.NewLine +
                        "Compiled on " + DateString + " " + TimeString + Environment.NewLine + Environment.NewLine +
                        "Copyright 2015, 16 Doqtor Kirby" + Environment.NewLine +
                        "Melee Toolbox is provided to you under the terms of the GNU General Public License version 3.")
    End Sub
End Class
