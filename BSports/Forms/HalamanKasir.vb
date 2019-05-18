Public Class HalamanKasir
    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FormLaporanPenjualan.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        DataBarang.Show()
    End Sub
End Class