Public Class FormCariBarang
    Sub Buatbarang()
        LVBarang.Columns.Add("Kode Barang", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Kode Jenis", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Nama Barang", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Harga Barang", 120, HorizontalAlignment.Center)
        LVBarang.View = View.Details
        LVBarang.GridLines = True
        LVBarang.FullRowSelect = True
    End Sub
    Private Sub FormCariBaRANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buatbarang()
    End Sub

    Private Sub LVBarang_DoubleClick(sender As Object, e As EventArgs) Handles LVBarang.DoubleClick
        With FormPenjualan
            .txtKdBarang.Text = LVBarang.SelectedItems(0).SubItems(0).Text
            .txtNama.Text = LVBarang.SelectedItems(0).SubItems(2).Text
            .txtHarga.Text = LVBarang.SelectedItems(0).SubItems(3).Text
            Me.Close()
            .txtJumlah.Focus()
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolBarang.cariData(txtBarang.Text).ToTable
        LVBarang.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString

                LVBarang.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub
End Class