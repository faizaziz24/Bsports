Public Class FormLaporanPembelian
    Dim baris As Integer
    Dim modeProses As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolTampilLaporan2.tampilData.ToTable
        DGLaporanPembelian.DataSource = DTGrid


        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLaporanPembelian.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLaporanPembelian.CurrentCell = DGLaporanPembelian.Item(1, baris)

        End If
    End Sub

    Private Sub TampilPeriode(tgl1 As Date, tgl2 As Date)
        DTGrid = KontrolTampilLaporan2.cariPeriode(tgl1, tgl2).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLaporanPembelian.DataSource = DTGrid
            DGLaporanPembelian.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLaporanPembelian.CurrentCell = DGLaporanPembelian(1, baris)

        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub FormLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = HalamanPemilik
        Format(DTP1.Value, "yyyy/mm/dd")
        Format(DTP2.Value, "yyyy/mm/dd")
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        FormCetakLaporanPembelian.LaporanPembelian1.SetParameterValue("awal", DTP1.Text)
        FormCetakLaporanPembelian.LaporanPembelian1.SetParameterValue("akhir", DTP2.Text)
        FormCetakLaporanPembelian.Show()
    End Sub


    Private Sub DGLaporanPembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLaporanPembelian.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGLaporanPembelian.Rows(baris).Selected = True
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call TampilPeriode(DTP1.Value, DTP2.Value)
    End Sub
End Class