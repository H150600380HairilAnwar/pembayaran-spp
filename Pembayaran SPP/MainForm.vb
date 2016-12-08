Public Class MainForm

    Private Sub TabelSPPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelSPPToolStripMenuItem.Click
        Tabel_SPP.ShowDialog()
    End Sub

    Private Sub BandaharaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BandaharaToolStripMenuItem.Click
        Bendahara.ShowDialog()
    End Sub

    Private Sub TabelSiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelSiswaToolStripMenuItem.Click
        Tabel_Siswa.ShowDialog()
    End Sub
End Class
