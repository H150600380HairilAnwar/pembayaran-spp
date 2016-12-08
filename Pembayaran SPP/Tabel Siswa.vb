Public Class Tabel_Siswa

    Private Sub Tabel_Siswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pembayaran_sppDataSet.siswa' table. You can move, or remove it, as needed.
        Me.SiswaTableAdapter.Fill(Me.Pembayaran_sppDataSet.siswa)

    End Sub
End Class