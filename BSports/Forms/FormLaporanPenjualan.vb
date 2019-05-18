Public Class FormLaporanPenjualan
    Dim baris As Integer
    Dim modeProses As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolTampilLaporan.tampilData.ToTable
        DGLaporanPenjualan.DataSource = DTGrid


        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLaporanPenjualan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLaporanPenjualan.CurrentCell = DGLaporanPenjualan.Item(1, baris)

        End If
    End Sub

    Private Sub TampilPeriode(tgl1 As Date, tgl2 As Date)
        DTGrid = KontrolTampilLaporan.cariPeriode(tgl1, tgl2).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLaporanPenjualan.DataSource = DTGrid
            DGLaporanPenjualan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLaporanPenjualan.CurrentCell = DGLaporanPenjualan(1, baris)

        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub FormLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Format(DTP1.Value, "yyyy/mm/dd")
        Format(DTP2.Value, "yyyy/mm/dd")
    End Sub



    Private Sub DGLaporanPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLaporanPenjualan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGLaporanPenjualan.Rows(baris).Selected = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        FormCetakLaporanPenjualan.LaporanPenjualan1.SetParameterValue("awal", DTP1.Text)
        FormCetakLaporanPenjualan.LaporanPenjualan1.SetParameterValue("akhir", DTP2.Text)
        FormCetakLaporanPenjualan.Show()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call TampilPeriode(DTP1.Value, DTP2.Value)
    End Sub

    Private Sub DGLaporanPenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLaporanPenjualan.CellContentClick

    End Sub
End Class