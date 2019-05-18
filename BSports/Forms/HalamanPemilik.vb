Public Class HalamanPemilik




    Private Sub TransaksiPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormPembelian.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLogin.Show()
        Me.Hide()
    End Sub




    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FormLaporanPenjualan.Show()
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        FormLaporanPembelian.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        FormPembelian.Show()
    End Sub
End Class