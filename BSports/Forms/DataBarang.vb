Public Class DataBarang
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGDataBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDataBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDataBarang.CurrentCell = DGDataBarang.Item(1, baris)
        End If
    End Sub


    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDataBarang.DataSource = DTGrid
            DGDataBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDataBarang.CurrentCell = DGDataBarang.Item(1, baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub
    Private Sub DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = HalamanKasir
        Call RefreshGrid()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub
End Class