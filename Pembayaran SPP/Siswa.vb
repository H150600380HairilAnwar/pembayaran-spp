Public Class Siswa

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

        SiswaBindingSource1.AddNew()
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

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            SiswaBindingSource1.RemoveCurrent()

            Me.Validate()
            Me.SiswaBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Pembayaran_sppDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        SiswaBindingSource1.CancelEdit()

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonSimpan.Enabled = False
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.SiswaBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pembayaran_sppDataSet)

        MessageBox.Show("Data Tersimpan")

        NISTextBox.Enabled = False
        NamaTextBox.Enabled = False
        KelasTextBox.Enabled = False
        No_AbsenTextBox.Enabled = False
        JurusanTextBox.Enabled = False

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonSimpan.Enabled = False
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        Me.SiswaTableAdapter.Fill(Me.Pembayaran_sppDataSet.siswa)
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Me.Close()
    End Sub

    Private Sub ButtonCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCari.Click
        SiswaTableAdapter.caridata(Pembayaran_sppDataSet.siswa, "" & TextCari.Text & "")
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged

    End Sub
End Class