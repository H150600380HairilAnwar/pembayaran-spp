Public Class Tabel_Siswa

    Private Sub Tabel_Siswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pembayaran_sppDataSet.siswa' table. You can move, or remove it, as needed.
        Me.SiswaTableAdapter.Fill(Me.Pembayaran_sppDataSet.siswa)

    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        KelasTextBox.Enabled = True
        No_AbsenTextBox.Enabled = True
        JurusanTextBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonEdit.Enabled = False
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = False
        ButtonBatal.Enabled = True
        ButtonSimpan.Enabled = True

        SiswaBindingSource.AddNew()
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        KelasTextBox.Enabled = True
        No_AbsenTextBox.Enabled = True
        JurusanTextBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonEdit.Enabled = False
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = False
        ButtonBatal.Enabled = True
        ButtonSimpan.Enabled = True
    End Sub
End Class