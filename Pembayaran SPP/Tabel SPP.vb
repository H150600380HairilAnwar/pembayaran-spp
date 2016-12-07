Public Class Tabel_SPP

    Private Sub SppBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SppBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pembayaran_sppDataSet)

    End Sub

    Private Sub Tabel_SPP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pembayaran_sppDataSet.spp' table. You can move, or remove it, as needed.
        Me.SppTableAdapter.Fill(Me.Pembayaran_sppDataSet.spp)

    End Sub
End Class