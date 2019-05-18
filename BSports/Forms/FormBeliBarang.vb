Public Class FormBeliBarang

    Sub Buatbarang()
        LVBarang.Columns.Add("Kode Barang", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Kode Jenis", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Nama Barang", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Harga", 120, HorizontalAlignment.Center)
        LVBarang.Columns.Add("Qty", 120, HorizontalAlignment.Center)

        LVBarang.View = View.Details
        LVBarang.GridLines = True
        LVBarang.FullRowSelect = True
    End Sub
    Private Sub FormBeliBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buatbarang()
    End Sub

    Private Sub LVBarang_DoubleClick(sender As Object, e As EventArgs) Handles LVBarang.DoubleClick
        With FormPembelian
            .txtKode.Text = LVBarang.SelectedItems(0).SubItems(0).Text
            .txtNama.Text = LVBarang.SelectedItems(0).SubItems(2).Text

            Me.Close()
            .txtQty.Focus()
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolBarang.cariData(txtBarang.Text).ToTable
        LVBarang.Items.Clear()
        Dim strItem(5) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString
                strItem(4) = DTGrid.Rows(i).Item(4).ToString

                LVBarang.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub LVBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVBarang.SelectedIndexChanged

    End Sub
End Class